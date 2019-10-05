using MainProject.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MainProject.Data.Models
{
    public interface IForum
    {
        Forum GetById(int id);
        IEnumerable<Forum> GetAll();
        IEnumerable<ApplicationUser> GetAllActiveUsers(int forumId);

        Task Create(Forum forum);
        Task Delete(int forumId);
        Task UpdateForumTitle(int forumId, string newTitle);
        Task UpdateForumDescription(int forumId, string newDescription);
        Post GetLatestPost(int forumId);
        bool HasRecentPost(int id);
        Task Add(Models.Forum forum);
        Task SetForumImage(int id, Uri uri);
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        IEnumerable<Post> GetFilteredPosts(int forumId, string modelSearchQuery);
    }
}
