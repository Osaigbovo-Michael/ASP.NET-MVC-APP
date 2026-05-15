using Microsoft.EntityFrameworkCore;
using MVC_App.Models;

namespace MVC_App.DAL
{
    public class ExpenseContext : DbContext
    {

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("YourConnectionStringHere");
        //}

        public ExpenseContext(DbContextOptions<ExpenseContext> options) : base(options)
        {
        }

        public DbSet<Expense> Expenses { get; set; }
    }
}
