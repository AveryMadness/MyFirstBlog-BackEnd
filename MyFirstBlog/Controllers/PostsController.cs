using System.Security.Cryptography;
using MyFirstBlog.Entities;

namespace MyFirstBlog.Controllers;

using Microsoft.AspNetCore.Mvc;
using MyFirstBlog.Dtos;
using MyFirstBlog.Services;

[ApiController]
[Route("posts")]

public class PostsController : ControllerBase {
    private IPostService _postService;

    public PostsController(IPostService postService) {
        _postService = postService;
    }

    // Get /posts
    [HttpGet]
    public IEnumerable<PostDto> GetPosts() {
        return _postService.GetPosts();
    }

    // Get /posts/:slug
    [HttpGet("{slug}")]
    public ActionResult<PostDto> GetPost(string slug) {
        var post = _postService.GetPost(slug);

        if (post is null) {
            return NotFound();
        }

        return post;
    }

    [HttpPost]
    public ActionResult NewPost(NewPost newPost)
    {
        List<string> errors = new List<string>();
        if (newPost != null)
        {
            if (string.IsNullOrEmpty(newPost.Title))
            {
                errors.Add("Title cannot be empty.");
            }

            if (string.IsNullOrEmpty(newPost.Description))
            {
                errors.Add("Description cannot be empty.");
            }
        }
        else
        {
            errors.Add("Post is invalid.");
        }

       

        string Slug = newPost.Title.ToLower().Trim().Replace(" ", "-");

        if (_postService.GetPost(Slug) != null)
        {
            errors.Add($"Post with title '{newPost.Title}' already exists.");
        }
        
        Guid NewPostGuid = Guid.NewGuid();

        Post post = new()
        {
            Body = newPost.Description,
            CreatedDate = DateTime.UtcNow,
            Id = NewPostGuid,
            Slug = Slug,
            Title = newPost.Title
        };
        
        if (errors.Count > 0)
        {
            return BadRequest(new {errors});
        }

        _postService.CreatePost(post);
        
        return Ok(new {post});
    }
}
