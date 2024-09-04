using Microsoft.EntityFrameworkCore;
using TodoAPI.Models;

namespace TodoAPI.Models
{
    public class TodoContext : DbContext
    {
        /*
        * 資料庫內容
        */
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
