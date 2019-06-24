using System;
namespace CSharpPlayground
{
    public class UsefulTools //add the static keyword if you dont want to create a new instance of it. 
    {
        public UsefulTools()
        {
        }

        public static void SayHi(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
