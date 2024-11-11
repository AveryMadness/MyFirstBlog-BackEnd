using MyFirstBlog.Dtos;
using MyFirstBlog.Entities;

namespace MyFirstBlog {
    public static class Extensions {
        public static PostDto AsDto(this Post post)
        {
            if (post == null) return null;
            return new PostDto
            {
                Id = post.Id,
                Title = post.Title,
                Slug = post.Slug,
                Body = post.Body,
                CreatedDate = post.CreatedDate
            };
            
        }
    }
};
