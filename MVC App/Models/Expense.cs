using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace MVC_App.Models

{
    public partial class Expense
    {
        public string ? Id { get; set; }
        [Required]
        [StringLength(200)]
        public string ? Description { get; set; } = null;
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Amount must be greater than zero.")]
        public double Amount { get; set; }
        [Required]
        [StringLength(100)]
        public string ? Category { get; set; } = null;

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
