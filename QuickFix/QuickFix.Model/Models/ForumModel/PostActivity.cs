using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickFix.Model.Models.ForumModel
{
    public class PostActivity
    {
        [Key]
        public int PostActivityId { get; set; }
        [Required]
        [ForeignKey("PostId")]
        public int PostId { get; set; }
        public bool IsBookmark { get; set; }
        public bool IsLike { get; set; }
        [Required]
        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        [Required]
        public DateTime ModifiedDate { get; set; }
    }
}
