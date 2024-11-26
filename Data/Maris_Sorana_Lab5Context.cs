using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Maris_Sorana_Lab5.Models;

namespace Maris_Sorana_Lab5.Data
{
    public class Maris_Sorana_Lab5Context : DbContext
    {
        public Maris_Sorana_Lab5Context (DbContextOptions<Maris_Sorana_Lab5Context> options)
            : base(options)
        {
        }

        public DbSet<Maris_Sorana_Lab5.Models.Expense> Expenses { get; set; } = default!;
        public DbSet<ExpenseDTO> ExpenseDTO { get; set; }
    }
}
