using Core.Packages.Repositories;

namespace Domain.Entities;

public class Brand : Entity<Guid>
{
    public String Name { get; set; }

    public Brand()
    {
    }

    public Brand(Guid id, string name)
    {
        Id = id;
        Name = name;
    }
}