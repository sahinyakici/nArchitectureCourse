using Application.Services.Repositories;
using Core.Packages.Repositories;
using Domain.Entities;
using Persistences.Contexts;

namespace Persistences.Repositories;

public class TransmissionRepository : EfRepositoryBase<Transmission, Guid, BaseDbContext>, ITransmissionRepository
{
    public TransmissionRepository(BaseDbContext context) : base(context)
    {
    }
}