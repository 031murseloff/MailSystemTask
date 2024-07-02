using Posts;
using CostomerException;

namespace Users;

public class User:IUser
{


    public Guid Userid { get; set; }
    public string Name { get; set; }
    public string SurName { get; set; }
    public int Age { get; set; }

    public string Email { get; set; }
    public string Password { get; set; }


    public User( string name, string surName, int age, string email, string password)
    {
        Userid=Guid.NewGuid();
        Name = name;
        SurName = surName;
        Age = age;
        Email = email;
        Password = password;
    }

    public void LikePost(Post Post )
    {
        if (Post == null)
        {
            throw new NullArgumentException("Post cannot be Null");
        }
        Post.LikeCount++;
    }

    public void ViewPosst(Post Post)
    {
        if (Post == null)
        {
            throw new NullArgumentException("Post cannot be Null");
        }
        Post.ViewCount++;
    }
}