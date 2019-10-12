using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickFix.Model.Models.ForumModel
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Required]
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }

        [Required]
        [Column(TypeName = "varchar(250)")]
        public string Title { get; set; }

        [Required]
        [Column(TypeName = "varchar(max)")]
        public string Description { get; set; }

        [Required]
        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }


    }
}
