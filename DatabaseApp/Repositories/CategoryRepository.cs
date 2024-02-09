

using DatabaseApp.Contexts;
using DatabaseApp.Entities;

namespace DatabaseApp.Repositories;

internal class CategoryRepository : Repo<CategoryEntity>
{
    public CategoryRepository(DataContext context) : base(context)
    {
    }
}
