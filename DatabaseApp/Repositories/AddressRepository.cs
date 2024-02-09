

using DatabaseApp.Contexts;
using DatabaseApp.Entities;

namespace DatabaseApp.Repositories;

internal class AddressRepository : Repo<AddressEntity>
{
    public AddressRepository(DataContext context) : base(context)
    {
    }
}
