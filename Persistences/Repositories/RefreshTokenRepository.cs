using Application.Services.Repositories;
using Core.Packages.Repositories;
using Core.Security.Entities;
using Microsoft.EntityFrameworkCore;
using Persistences.Contexts;

namespace Persistences.Repositories;

public class RefreshTokenRepository : EfRepositoryBase<RefreshToken, int, BaseDbContext>,
    IRefreshTokenRepository
{
    public RefreshTokenRepository(BaseDbContext context) : base(context)
    {
    }

    public async Task<IList<RefreshToken>> GetOldRefreshTokensAsync(int userId, int refreshTokenTtl)
    {
        List<RefreshToken> tokens = await Query().AsNoTracking().Where(r =>
            r.UserId == userId && r.Revoked == null && r.Expires >= DateTime.UtcNow &&
            r.CreatedDate.AddDays(refreshTokenTtl) <= DateTime.UtcNow).ToListAsync();
        return tokens;
    }
}