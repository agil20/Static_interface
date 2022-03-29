﻿using System;

namespace Static_.Interface
{
    internal class User : IAccount
    {
        private int _id;
        private  string _password;
        public  int Id
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = 1;
                Id++;
            }
        }
        public  string Fullname { get; set; }
        public string Email { get; set; }
        public string Password
        {
            get { return _password; }
            set
            {
                

            }
        }





        bool IAccount.PasswordChecker(string password)
        {
            Password = password;
            //  - şifrədə minimum 8 character olmalıdı
            bool result = false;
            bool result1 = false;//   - şifrədə ən az 1 böyük hərf olmalıdır
            bool result2 = false;// - şifrədə ən az 1 kiçik hərf olmalıdır
            bool result3 = false;// -şifrədə ən az 1 rəqəm olmalıdır
            for (int i = 0; i < password.Length; i++)
            {
                result1 = char.IsUpper(password[i]);
                result2 = char.IsLower(password[i]);
                result3 = char.IsNumber(password[i]);


            }
            if (password.Length >= 8 && result1 == true && result2 == true && result3 == true)
            {
                result = true;
            }
            return result;
        }
            public void ShowIfo() 
        {
            Console.WriteLine($"ID: {Id}\n" +
     $"Fullname: {Fullname}\n" +
     $"Email: {Email}");
        }

        public User(string email, string password) // yarandığı zaman email və password təyin edilməsi məcburidir
        {
            Password = password;
            Email = email;
        }        //public static int IdNo()
        //{
        //    return Id++;
        //}


    }
}
