using Application.Services.Repositories;
using Core.Packages.Repositories;
using Domain.Entities;
using Persistences.Contexts;

namespace Persistences.Repositories;

public class BrandRepository : EfRepositoryBase<Brand, Guid, BaseDbContext>, IBrandRepository
{
    public BrandRepository(BaseDbContext context) : base(context)
    {
    }
}