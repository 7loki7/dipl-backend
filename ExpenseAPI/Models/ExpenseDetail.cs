using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseAPI.Models
{
    public class ExpenseDetail
    {
        [Key]
        public int ExpenseId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string ExpenseName { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Category { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string Username { get; set; }

    }
}
