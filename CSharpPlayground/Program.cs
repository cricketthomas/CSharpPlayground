using System;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayground
{
    class Program
    {


        static void Main(string[] args) //everything runs in this block. 
        {
            Chef chef = new Chef();
            //create instance of the ItalianChef, then it can access all the methods from regular Chef
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakePasta();
            //Override a method which was inherited
            italianChef.MakeSpecialtyDish();
            chef.MakeSpecialtyDish();
        },




    }
}


//Lesson 1

/*
 *
 *     string CharacterName = "arthur";
            int CharacterAge = 22;
            
            Console.WriteLine("Hello World!");
            Console.WriteLine("How old are you?");
            CharacterAge = 25;
            string x = Console.ReadLine();
            Console.WriteLine($"You're {x}and {CharacterName} is {CharacterAge}");
//Lesson 2 Data types:
 string phrase = "C# rocks";
            char grade = 'F';
            int DogAge = 5;
            double DogAgeInHumanYears = 23.2;
            bool Happy = true;

            if (Happy)
            {
                Console.WriteLine(2);
            }

    //Strings
        string phrase = "Arthurs Code and understanding of it is, garbage.";
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.IndexOf('A')); // let me know where "A" begins in the string, so index 0. "-1" ALways means Flase or no char in string.
            Console.WriteLine(phrase[0]); // index of the first element and printing the value. In theis case, its A. String index. 
            Console.WriteLine(phrase.Contains("Dog")); //method to see if it contains the word dog. False of course. 
            Console.WriteLine(phrase.Replace("Code","Program"));
            Console.WriteLine(phrase.Substring(41)); //grabs a part of the string. Start index gets you everthung after. "garbage."
            Console.WriteLine(phrase.Substring(0, 7)); //grabs a part of the string. Start index gets you everthung after. "Arthur"


    //Working with numbers
          int dogAge = Convert.ToInt32( Console.ReadLine());
            Console.WriteLine($"Your dog is {dogAge} and {dogAge * 7} in human years"); //pemdas 10
            
            Console.WriteLine(Math.PI);
            Console.WriteLine(Math.Abs(-40)); //will retrun 40. 
            Console.WriteLine(Math.Pow(1,5)); //will 1^5 = 1
            Console.WriteLine(Math.Max(10, 500)); //get max value. Min, Sqrt
            Console.WriteLine(Math.Round((4.2)); //round up.


    //Get user input

      try
            {
                Console.Write("enter the first number to add: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter the second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"{num1}+{num2} = {num1 + num2}");

            }
            catch
            {
                Console.WriteLine("Thats not a valid input");
            }

    // mad lib game:

        string color, pluralNoun, celebirty;
            Console.Write("Enter a color");
            color = Console.ReadLine();
            Console.Write("Enter a Noun");
            pluralNoun = Console.ReadLine();
            Console.Write("Enter a Celebirty");
            celebirty = Console.ReadLine();
            Console.WriteLine($"Roses are {color}");
            Console.WriteLine($"Violets are {pluralNoun}");
            Console.WriteLine($"I love {celebirty}");



//Arrays

     int[] luckyNumbers = {5, 8 ,15, 16, 77 };
            string[] friends = new string[5]; // we must inidacate how many values the arrays will hold. in this case it is 5 values
            double[] myDoublearray = new double[1]; //holds one value which is  double. 
            luckyNumbers[1] = 900;
            friends[0] = "Jim";
            friends[1] = "Kelly"
            Console.Write(luckyNumbers[1]);

    //methods
      static void Main(string[] args) //everything runs in this block. 
        {
            SayHi("Arthur", 5);
        }

        //Custom methods
         static void SayHi(string name, int age) //void means returns nothing
        {
            Console.WriteLine($"Hello, {name}, you're {age}!");
        }

    //return stament in methods:
       static void Main(string[] args) //everything runs in this block. 
        {

            Console.Write(Cube(5));
        }



        //Custom methods

        static int Cube(int num) //int means returns a int
        {
            int result = num * num * num;
            return result;
        }
    }

    //If statements:

            bool isMale = false;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.Write("Youre a tall male.");
            }
            else if (isMale && !isTall)
            {
                Console.Write("Youre a male and short.");

            } else if (!isMale && isTall)
            {
                Console.Write("Youre a tall.");

            }
            else
            {
                Console.Write("Your not tall or male.");
            }
            Console.ReadLine();




    //Advanced if

    static void Main(string[] args) //everything runs in this block. 
        {

            Console.WriteLine("which number is bigger checker");
            Console.WriteLine(GetMax(2, 8, 100));
            //Advnaced if statements using methods
            Console.ReadLine();
        }

        static int GetMax(int num1, int num2, int num3)
        {
            if (num1 >= num2 && num1 >= num3)
            {
                return num1;
            }

            else if (num2 >= num1 && num2 >= num3)
            {
                return num2;
            }

            return num3;
        }

    //Better calculator:

     Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());


            Console.Write("Enter a math operator: ");
            string MathOperator = Console.ReadLine();

            Console.Write("Enter a second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            if (MathOperator == "+")
            {
                Console.Write (num1 + num2);
            }
            else if (MathOperator == "-")
            {
                Console.Write (num1 - num2);

            }
            else if (MathOperator == "/")
            {
                Console.Write (num1 / num2);

            }
            else if (MathOperator == "*")
            {
                Console.Write( num1 * num2);

            }
            else
            {
                Console.WriteLine("Invalid operator");
            }

            Console.ReadLine();


    //Switch statemnt
            static string GetDay(int dayNum)
        {
            string dayName;

            switch (dayNum)
            {
                case 0:
                    dayName = "sunday";
                    break;
                case 1:
                    dayName = "monday";
                    break;
                case 2:
                    dayName = "tuesday";
                    break;
                case 3:
                    dayName = "wednesday";
                    break;
                case 4:
                    dayName = "thursday";
                    break;
                case 5:
                    dayName = "friday";
                    break;
                case 6:
                    dayName = "saturday";
                    break;
                default:
                    dayName = "Invalid day/num";
                   break;

            }
            return dayName;


        }


    //while loops:
     //WHile loops
            int index = 0;
            while(index <= 100)
            {
                Console.WriteLine(index);
                index++;

            }
            Console.WriteLine("END OF WHILE");


            int index2 = 100;
            do
            {
                Console.WriteLine(index++);
                index2++;

            } while (index2 <= 200); //always excutes once before condition is checked.

              Console.WriteLine("END DO WHILE");



            for (int index3 = 200;  index3 <= 300; index3++)
            {
                Console.WriteLine(index3);

            }

            Console.WriteLine("END For loop");

            Console.ReadLine();



    //Guessing game.
     string secretWord = "dog";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;
           
            while (guess != secretWord && !outOfGuesses)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter a new guess of the secret word: ");
                    guess = Console.ReadLine();
                    guessCount++;
                    Console.WriteLine($"Guesses left: {guessLimit - guessCount}");
                }
                else 
                {
                    outOfGuesses = true;

                }

            }
            if (outOfGuesses)
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("You Win!");
            }


    //game with do while
    
            string secretWord = "dog";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            do
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter a new guess of the secret word: ");
                    guess = Console.ReadLine();
                    guessCount++;
                    Console.WriteLine($"Guesses left: {guessLimit - guessCount}");
                }
                else
                {
                    outOfGuesses = true;

                }

            } while (guess != secretWord && !outOfGuesses);

            if (outOfGuesses)
            {
                Console.WriteLine("You lose.");
            }
            else
            {
                Console.WriteLine("You Win!");
            }



      //For loops:
            int[] luckyNumbers = { 1, 40, 11, 45, 220, 2 };

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

    //create expoenent function

    static void Main(string[] args) //everything runs in this block. 
        {
            //build an exponent function
            Console.Write(GetPow(3, 2));

        }

        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }

            return result;
        }


       // 2d array
            int[,] numberGrid = {
                { 1,2 },
                { 3,4 },
                { 5,6 }
            };
            int[,] myArray = new int[2,3]; //if you dont know what ill be stores, you just define the array then insert them later, but you must declare the size.
            Console.WriteLine(numberGrid[1, 1]);// row then column.




    //try catch blocks:

    
            try
            {
                Console.Write("Enter a number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter a second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($" The division of these numbers is:{ num1 / num2}");
            }
            catch(DivideByZeroException error)
            {
                Console.WriteLine(error.Message);
            }

            catch(FormatException error)
            {
                Console.WriteLine(error.Message);

            }
            finally
            {
                Console.WriteLine("this code is alway exceuted");
            }


    //Classes and Objects:
      Book Book1 = new Book();
            Book1.title = "Harry Potter and the Goblet of Fire";
            Book1.author = "JK rowling";
            Book1.pages = 502;

            Book Book2 = new Book();
            Book2.title = "Lord of the rings";
            Book2.author = "Random guy";
            Book2.pages = 9000;

            Console.WriteLine(Book1.title, Book2.title);
    //Constructors

    
            Book Book1 = new Book("Harry Potter and the Goblet of Fire", "JK rowling", 502); // you can pass data into this and call the function once initialized. 
            Book Book2 = new Book("Lord of the Rings", "Tolkien", 550);
            Book Book3 = new Book("The Life of Paige", "Paige Thomas", 600);

    // More constructors methods:

      Student student1 = new Student("Jim", "Business", 2.5);
            Student student2 =  new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());



    // Getters and Setters: Check Movie class for more info. 
            Movie big = new Movie("Big", "Spike Lee", "IDK"); //setter will get filtered out since its invalid as determined by the getter. 
            Movie lebowski = new Movie("The Big Lebowski", "Q. Tarintino", "R");

            Console.WriteLine(big.Rating);
            Console.WriteLine(lebowski.Rating);
    // Static memebers, check movie.

    
            Movie big = new Movie("Big", "Spike Lee", "IDK"); //setter will get filtered out since its invalid as determined by the getter. 
            Movie lebowski = new Movie("The Big Lebowski", "Q. Tarintino", "R");

          
            Console.WriteLine(Movie.movieCount);
            Console.WriteLine(big.getMovieCount()); //

    //Static classes:
    
            //Static methos in classes, meaning we dont have to create an instant of the class to use it.
            UsefulTools.SayHi("Arthur");


    //Inheritance chef and italian cheff files.

            Chef chef = new Chef();
            //create instance of the ItalianChef, then it can access all the methods from regular Chef
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakePasta();
            //Override a method which was inherited
            italianChef.MakeSpecialtyDish();
            chef.MakeSpecialtyDish();
     







     */
