using System;

namespace HW._06._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            user.Fullname = "Emil Quluzade";
            user.Email = "emilquluzade@gmail.com";
            user.Password = "Salam4321";
            ShowInfo(user);


            User user1 = new User();
            user1.Fullname = "Tural Ismayilov";
            user1.Email = "ismayilov@gmail.com";
            user1.Password = "Salam4321";
            ShowInfo(user1);

        }

        static void ShowInfo(User user)
        {
            Console.WriteLine(user.PasswordChecker());
            Console.WriteLine(user.Fullname);
            Console.WriteLine(user.Email);

            
        }
    }
}
