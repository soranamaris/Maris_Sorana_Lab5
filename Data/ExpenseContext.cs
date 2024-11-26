using Maris_Sorana_Lab5.Models;
using Microsoft.EntityFrameworkCore;
namespace Maris_Sorana_Lab5.Data
{

    public class ExpenseContext : DbContext
    {
        public ExpenseContext(DbContextOptions<ExpenseContext> options) : base(options)
        {
        }
        public DbSet<Expense> Expense { get; set; }

    }
}

