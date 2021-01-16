using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> Instgram = new List<User>();

            User UserName = new User();
            User TotalViews = new User();
            User Likes = new User();
            User Comments = new User();

            Instgram.Add(UserName);
            Instgram.Add(TotalViews);
            Instgram.Add(Likes);
            Instgram.Add(Comments);

            List<myComments> myComments = new List<myComments>();


            myComments myComments1 = new myComments();
            myComments commentOne = myComments1;
            commentOne.Comment = "I Love You!";

            myComments commentTwo = myComments1;
            commentTwo.Comment = "Stay Home Order!";

            myComments commentThree = myComments1;
            commentThree.Comment = "We are Happy!";

            myComments.Add(commentOne);
            myComments.Add(commentTwo);
            myComments.Add(commentThree);

           

            Console.WriteLine("My favorite Comments is:" + myComments.Last());

        }
    }
}
public class User
{
    public string UserName { get; set; } = string.Empty;
    public string Comments { get; internal set; }
}
public class MyViews
{
    public string TotalViews { get; set; }
}
public class MyLikes
{
    public string Likes { get; set; }
}
public class myComments
{
  
    public string Comment { get; set; }

}

