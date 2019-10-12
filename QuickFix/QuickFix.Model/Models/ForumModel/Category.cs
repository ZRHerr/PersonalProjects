using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickFix.Model.Models.ForumModel
{

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]

        [Column(TypeName = "varchar(100)")]
        public string CategoryName { get; set; }
    }

}
