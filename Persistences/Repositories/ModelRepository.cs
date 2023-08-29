using Application.Services.Repositories;
using Core.Packages.Repositories;
using Domain.Entities;
using Persistences.Contexts;

namespace Persistences.Repositories;

public class ModelRepository : EfRepositoryBase<Model, Guid, BaseDbContext>, IModelRepository
{
    public ModelRepository(BaseDbContext context) : base(context)
    {
    }
}