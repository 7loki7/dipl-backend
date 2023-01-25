using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseAPI.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Surname { get; set; }

        [Column(TypeName = "nvarchar(150)")]
        public string Username { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string Password { get; set; }

        [Column(TypeName = "nvarchar(15)")]
        public string Email { get; set; }
    }
}
