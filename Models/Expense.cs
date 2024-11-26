using System.ComponentModel.DataAnnotations;

namespace Maris_Sorana_Lab5.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Secret { get; set; }
    }
}
