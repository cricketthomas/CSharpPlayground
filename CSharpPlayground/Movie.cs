using System;
namespace CSharpPlayground
{
    public class Movie
    {
        public string title; //public can be accessed by any attribute.
        public string director;

        // Ratings allowed, G, PG, PG-13, R, NR how do we enforce this?
        private string rating; // only code inside of movie class can access this rating.

        // Static attributes: Tells you general information about the class. Attributes about the class.
        public static int movieCount = 0; //Members of every class, it belongs to the class.


        public Movie(string aTitle, string aDirector, string aRating) //constructor
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating; //Setter denoted with a capital R is refering to the property.
            movieCount++; //everytime a move is created, it increments this variable to store the total amount of songs. 
        }


        //Properites define getters and setters:

        public string Rating
        {
            get { return rating; } //allow read access.
            set
            { // Ratings allowed, G, PG, PG-13, R, NR - We setting rules otherwise NR, needed for private vars. 

                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;

                }
                else
                {
                    rating = "NR";
                }


            }
        }


        public int getMovieCount()
        {
            return movieCount;
        }
    }
}