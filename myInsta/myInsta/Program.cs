using System;
using System.Collections;
using System.Collections.Generic;


namespace UserName
{
    class Program {


        static void Main(string[] args)
        {
            User User = new User();

            User.UserName = "Rodrigus";
            User.totalView = 7;
            User.likes = 15;

            User.Comments = new List<string>();
            User.Comments.Add("I love my family");
            User.Comments.Add("We are having fun!");
            User.Comments.Add("One day I will be back!");

            Console.WriteLine("The User " + User.UserName +
                                 "  has Total Views of:" + User.totalView +
                                " , with the total likes of:" + User.likes!);

            Console.WriteLine("User had the following Comments:");
            foreach(var item in User.Comments)
            {
                Console.WriteLine(item);

            }
        }

        public class User 

        {

            public string UserName { get; set; } = string.Empty;
            public int totalView { get; set; }
            public int likes { get; set; }
            public List<string> Comments { get; set; }
           

        }
        
    }
}

