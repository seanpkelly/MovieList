using System;
using System.Collections.Generic;

namespace Lab10MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(",.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.");
            Console.WriteLine(",.Welcome to the Movie List Application!.,");
            Console.WriteLine(",.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.,.");
           
            List<Movies> movielist = new List<Movies>
            {
                new Movies("comedy", "Naked Gun", "five star"),
                new Movies("drama", "Goodfellas", "five star"),
                new Movies("thriller", "The Shining", "five star"),
                new Movies("fantasy", "Twlight", "ne Star"),
                new Movies("comedy", "The Master of Disguise", "one star"),
                new Movies("drama", "The Room", "one star"),
                new Movies("fantasy", "Pans Labrinth", "four star"),
                new Movies("thriller", "Parasite", "five star")
            };

     
            bool programStart = true;
            while(programStart)
            {
                Console.WriteLine("What genre are you interested in?");
                string answer = Console.ReadLine().Trim();
                answer = answer.ToLower();

                if (answer == "drama" || answer == "comedy" || answer == "fantasy" || answer == "thriller")
                {
                    
                    for (int i = 0; i < movielist.Count; i++)
                    {
                        
                        if (answer == movielist[i].Genre)
                        {
                            movielist[i].FilmTitles();
                            Console.WriteLine($"{movielist[i].Title}");
                            Console.WriteLine($"that's a {movielist[i].Quality} film.");
                        }
                        
                    }

                }
                else
                {
                    Console.WriteLine("That's not a valid response! The genres are drama, comedy, fantasy and thriller.");
                    continue;

                }
                while (true)
                {


                    Console.WriteLine("Would you like to keep going? y/n");
                    Console.WriteLine();
                    string responseLast = Console.ReadLine();
                    if (responseLast == "y")
                    {
                        programStart = true;
                        break;
                    }

                    else if (responseLast == "n" || responseLast == "no")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Alright. Thanks for your time, bye!");
                        programStart = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Seriously? y/n?");
                    }
                }
            }
            
        }
    }

}