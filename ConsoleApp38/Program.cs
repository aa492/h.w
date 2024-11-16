using System;
using System.Collections;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    class UserAccount
    {
        public string Email;
        public string Password;
        public UserAccount(string email,string password ) 
        { 
            Email = email;
            Password = password;
        }
        public UserAccount( UserAccount exac) 
        {
            Email = exac.Email;
            Password = exac.Password;
        }
    }
   
    internal class Program
    {
       
        static void Main(string[] args)
        {
            ArrayList acnts = new ArrayList();
            UserAccount ogac1 = new UserAccount("user1@example.com", "1234");
            UserAccount ogac2 = new UserAccount("user2@example.com", "9999");
            UserAccount ogac3 = new UserAccount("user3@example.com", "7690");
            UserAccount cgac = new UserAccount(ogac1);
            acnts.Add(cgac);
            cgac = new UserAccount(ogac2);
            acnts.Add(cgac);
            cgac = new UserAccount(ogac3);
            acnts.Add(cgac);
            Console.WriteLine("you have 3 attempts :");
            for (int i = 0;i<3;i++)
            {
                Console.WriteLine("enter the email :");
                string e= Console.ReadLine();
                Console.WriteLine("enter the password");
                string p= Console.ReadLine();
                bool n=false;
                for (int j=0;j<acnts.Count;j++)
                {
                    UserAccount c = (UserAccount)acnts[j];
                    if(c.Email == e&&c.Password==p) 
                    { 
                        n = true;
                        Console.WriteLine("correct");
                        break;

                    }

                }
                if (!n) Console.WriteLine("wrong !!");
                else
                    break;
            }
          


            Console.ReadLine();




        }

    }
}
