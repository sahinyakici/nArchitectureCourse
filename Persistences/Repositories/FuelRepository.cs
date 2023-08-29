using Application.Services.Repositories;
using Core.Packages.Repositories;
using Domain.Entities;
using Persistences.Contexts;

namespace Persistences.Repositories;

public class FuelRepository : EfRepositoryBase<Fuel, Guid, BaseDbContext>, IFuelRepository
{
    public FuelRepository(BaseDbContext context) : base(context)
    {
    }
}