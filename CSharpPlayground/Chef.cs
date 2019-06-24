using System;
namespace CSharpPlayground
{
    public class Chef
    {
        
        public Chef()
        {
        }

        public void MakeChicken()
        {
            Console.WriteLine("The Chef makes Chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The Chef makes Salad");
        }
        public virtual void MakeSpecialtyDish() //the virtual keyword enforces that it can be overwwritten in different classes. 
        {
            Console.WriteLine("The Chef makes BBQ Ribs");
        }
    }
     
}
