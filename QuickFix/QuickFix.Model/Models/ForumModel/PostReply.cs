using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickFix.Model.Models.ForumModel
{
    public class PostReply
    {
        [Key]
        public int PostReplyId { get; set; }

        [Required]
        [ForeignKey("PostId")]
        public int PostId { get; set; }

        [Required]
        [Column(TypeName = "varchar(250)")]
        public string ReplyWithAnswer { get; set; }

        [Required]
        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}
