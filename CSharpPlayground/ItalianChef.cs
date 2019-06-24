using System;
namespace CSharpPlayground
{

    public class ItalianChef : Chef  //inheritance done using : colon
    {
        public ItalianChef()
        {
        }
        public void MakePasta()
        { 
            Console.WriteLine("The Chef makes pasta");
        }

         public override void MakeSpecialtyDish() //the override keyword enforces that it can be overwwritten from inherited classes.
        {
            Console.WriteLine("The Chef makes Chicken Parm");
        }
    }
}
