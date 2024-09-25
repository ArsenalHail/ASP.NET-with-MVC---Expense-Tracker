using System.ComponentModel.DataAnnotations;

namespace ASP_NET_Tutorial___SpendSmart.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        
        [Required]        
        public string? Description { get; set; } // ? allows for null values in string
    }
}
