

using DatabaseApp.Contexts;
using DatabaseApp.Entities;

namespace DatabaseApp.Repositories;

internal class RoleRepository : Repo<RoleEntity>
{
    public RoleRepository(DataContext context) : base(context)
    {
    }
}