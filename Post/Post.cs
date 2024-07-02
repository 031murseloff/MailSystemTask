namespace Posts;

public class Post
{
  

    public Guid Id { get; set; }
    DateTime CreatTime { get; set; }
    public string Name { get; set; }
    static public int LikeCount { get; set; } = 0;
    public int ViewCount { get; set; } = 0;

    public Post(string Name, int likeCount, int viewCount)
    {
        Id= Guid.NewGuid();
        CreatTime = DateTime.Now;
        this.Name = Name;
       
    }



}