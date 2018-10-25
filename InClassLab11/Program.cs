using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace InClassLab11
{
    class Program
    {
        public static ArrayList mooovies = new ArrayList()
        {
            new Movie("Finding Nemo", "animated"),
            new Movie("Atlantis", "animated"),
            new Movie("Fivel Goes West", "animated"),
            new Movie("Halloween", "horror"),
            new Movie("Friday the 13th", "horror"),
            new Movie("Nightmare On Elm Street", "horror"),
            new Movie("Planet Of The Apes", "scifi"),
            new Movie("Star Wars", "scifi"),
            new Movie("Space Balls", "scifi"),
            new Movie("Lord Of The Rings", "scifi") //just for you Dan LOL
        };

        static void Main(string[] args)
        {
            bool again = true;
            while (again == true)
            {
                try
                {

                    Console.WriteLine("Please enter a genre(Animated, Horror, Scifi): ");
                    string userInput = Console.ReadLine().ToLower();
                    foreach (Movie userMovie in mooovies)
                    {
                        if (userInput == userMovie.MovieCategory)
                        {
                            Console.WriteLine(userMovie.MovieTitle);
                        }
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Please choose one of the genres, Animated, Horror, Scifi");
                    continue;
                }

                Console.WriteLine("Would you like to run this program again? Y/N");
                string ans = Console.ReadLine().ToLower();
                if (ans == "y")
                    {
                        again = true;
                        continue;
                    }
                    if (ans == "n")
                    {
                        again = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please choose between y/n");
                        continue;
                    }
            }
            Console.ReadLine();

        }
    }
}

