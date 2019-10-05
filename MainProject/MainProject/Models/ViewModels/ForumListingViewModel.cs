using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MainProject.Models.ViewModels
{
    public class ForumListingViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int NumberOfPosts { get; set; }
        public int NumberOfUsers { get; set; }
        public bool HasRecentPost { get; set; }

        public PostListingViewModel Recent { get; set; }
        public IEnumerable<PostListingViewModel> AllPosts { get; set; }
    }
}
