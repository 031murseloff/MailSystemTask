
using Users;
using Admins;
using Posts;
using CostomerException;

Post post1 = new("Mycontent", 0, 0);
List<Post> posts = new List<Post>();
posts.Add(post1);
List<User> users = new List<User>();
User user1 = new("Sadiq", "Mursalov", 18, "sadiqMursalov@gmail.com", "12345678");
users.Add(user1);

Notification not1 = new("my text", DateTime.Now, user1);
List<Admin> admins=new List<Admin>();   
Admin admin1 = new("031murseloff","26052005AA","elshanmurselov@gmail.com",not1,post1);

admins.Add(admin1);

Console.WriteLine("Are you Admin or User?");
Console.WriteLine("1.Admin");
Console.WriteLine("2.User");
Console.Write("Your choice:");

int choosen1=int.Parse(Console.ReadLine());
Console.Write("Gmail:");
string verifationGmail=Console.ReadLine();
Console.Write("Pasword:");
string verificationPassword=Console.ReadLine();



switch (choosen1)
{
    case 1:
        {
           foreach (var admin in admins)
            {
                if(admin.AdminPassword==verificationPassword && admin.AdminEmail == verifationGmail)
                {
                    Console.WriteLine(" hesaba ugurla daxil oldunuz...");
                    

                    return;
                }
            }
            throw new NotFoundUserOrAdmin("sifre ve ya gmail yanlisdir");
        }

        case 2:
        {

            foreach (var user in users)
            {
                if (user.Password == verificationPassword && user.Email == verifationGmail)
                {
                    Console.WriteLine($"{user.Name} {user.SurName} hesaba ugurla daxil oldunuz");

                    string yoxlama2;
                    Console.Write ("Baxmaq isdediyiniz postun adini daxil edin: ");
                    yoxlama2 = Console.ReadLine();

                    foreach (var post in posts)
                    {
                        if (yoxlama2 == post.Name)
                        {
                            string yoxlama3;
                            Console.Write("Like etmek isteyirsiz?(Yes/NO)");
                            yoxlama3 = Console.ReadLine();
                            if(yoxlama3=="yes" ||yoxlama3== "Yes")
                            {
                                user.LikePost(post);
                            }
                            return; 
                        }
                        throw new NoTFoundPostException("Qeyd edilen ada post tapilmadi");
                    }
                    return;
                }
            }
            throw new NotFoundUserOrAdmin("sifre ve ya gmail yanlisdir"); 
            
        }

        default: {
            throw new InputException();
        }
}





