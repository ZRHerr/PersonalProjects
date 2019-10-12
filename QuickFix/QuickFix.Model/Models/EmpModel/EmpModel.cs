using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickFix.Model.Models.EmpModel
{
    public class EmpModel : UserModel
    {
        public long EmpId { get; set; }
        public string EmployerName { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Photo { get; set; }
        [Required]
        public DateTime LastLoggedInDate { get; set; }
    }
}
