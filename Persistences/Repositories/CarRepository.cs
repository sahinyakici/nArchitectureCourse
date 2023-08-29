using Application.Services.Repositories;
using Core.Packages.Repositories;
using Domain.Entities;
using Persistences.Contexts;

namespace Persistences.Repositories;

public class CarRepository : EfRepositoryBase<Car, Guid, BaseDbContext>, ICarRepository
{
    public CarRepository(BaseDbContext context) : base(context)
    {
    }
}