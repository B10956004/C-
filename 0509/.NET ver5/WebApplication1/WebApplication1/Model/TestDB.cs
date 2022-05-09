using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Model
{
    public class TestDB:DbContext
    {
        public TestDB(DbContextOptions<TestDB> options)
            :base(options)
        { 
        }
        /// <summary>
        /// 資料表
        /// </summary>
        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
