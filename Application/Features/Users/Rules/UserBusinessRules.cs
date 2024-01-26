﻿using Application.Features.Auth.Constants;
using Application.Services.Repositories;
using Core.Application.Rules;
using Core.CrossCuttingConcerns.Exceptions.Types;
using Core.Security.Entities;
using Core.Security.Hashing;

namespace Application.Features.Users.Rules;

public class UserBusinessRules : BaseBusinessRules
{
    private readonly IUserRepository _userRepository;

    public UserBusinessRules(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public Task UserShouldBeExistsWhenSelected(User? user)
    {
        if (user == null)
        {
            throw new BusinessException(AuthMessages.UserDontExist);
        }

        return Task.CompletedTask;
    }

    public async Task UserIdShouldExistWhenSelected(int id)
    {
        bool doesExist = await _userRepository.AnyAsync(predicate: u => u.Id == id, enableTracking: false);
        if (doesExist)
            throw new BusinessException(AuthMessages.UserDontExist);
    }

    public Task UserPasswordShouldBeMatched(User user, string password)
    {
        if (!HashingHelper.VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
        {
            throw new BusinessException(AuthMessages.PasswordDontMatch);
        }

        return Task.CompletedTask;
    }

    public async Task UserEmailShouldNotExistsWhenInsert(string email)
    {
        bool doesExists = await _userRepository.AnyAsync(predicate: u => u.Email == email, enableTracking: false);
        if (doesExists)
        {
            throw new BusinessException(AuthMessages.UserMailAlreadyExists);
        }
    }

    public async Task UserEmailShouldNotExistsWhenUpdate(int id, string email)
    {
        bool doesExists =
            await _userRepository.AnyAsync(predicate: u => u.Id == id && u.Email == email, enableTracking: false);
        if (doesExists)
        {
            throw new BusinessException(AuthMessages.UserMailAlreadyExists);
        }
    }
}