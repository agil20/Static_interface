using System;

namespace Static_.Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {

              Console.WriteLine("Daxil edin   ");
            Console.WriteLine("Email  ");

            User.Email= Console.ReadLine();
            Console.WriteLine("Password  ");
            User.Password= Console.ReadLine();    
           
            Console.WriteLine("Ad");
            User.Fullname = Console.ReadLine();
                //Id dəyəri hər dəfə bir user obyekti yaranan zaman avtomatik artmalıdır 
                User.ShowInfo();
                
                
            } while (true);



        }
    }
}
