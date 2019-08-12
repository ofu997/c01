using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCwithAuth.Models
{
    public class MockPostRepository : IPostRepository
    {
        private List<Post> _postList;

        public MockPostRepository()
        {
            _postList = new List<Post>()
            {
                new Post(){Id = 1, Title="My day so far", Content="things are good so far"}
            };
        }

        public Post Add(Post post)
        {
            _postList.Add(post);
            return post;
        }

        // public IEnumerable<Post> GetAllPosts()
        // {

        // }
    }
}