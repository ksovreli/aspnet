using datasource_aspnet_efcore.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace datasource_aspnet_efcore.Data
{
    public class TodoListContext : DbContext
    {
        public DbSet<TodoListItem> todoListItems { get; set; }

        public TodoListContext(DbContextOptions options): base(options)
        {

        }
    }
}
