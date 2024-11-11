namespace MyFirstBlog.Entities;
public record NewPost {
    public string Title { get; init; } = default!;
    public string Description { get; init; } = default!;
}
