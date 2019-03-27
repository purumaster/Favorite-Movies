using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;


namespace Favorit_movies
{
    class Program
    {
        public static void Main(string[] args)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
       
            var fileName = Path.Combine(directory.FullName, "FavoritMovie.json");  //My Json file name
            var movies = DeserializeMovies(fileName);

           
            var title = "";

            bool keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("To search - enter 1, to add your favorite movie - enter 2, to comment movie - enter 3, to exit - enter 4 ");
                var result = Console.ReadLine();
                int option = 0;
                try
                {
                    option = Int32.Parse(result);
                }
                catch
                {
                    Console.WriteLine("You didn't enter a number");
                }
                if (option == 1)  //Search
                {
                    Console.WriteLine("Search movies: Enter title ");
                    string search = Console.ReadLine();
                    bool found = false;
                    foreach (var movie in movies)
                    {
                        if (movie.Title.ToLower().Contains(search.ToLower()))
                        {
                            found = true;
                            Console.WriteLine("Movie found:");
                            movie.PrintMovie();
                            break;
                        }

                    }
                    if (found == false)
                    {
                        Console.WriteLine("Movie not found");
                    }
                    }
                if (option == 2) // Enter favorit movie
                {
                    Console.WriteLine("Enter the title: ");
                    title = Console.ReadLine();
                   
                    Console.WriteLine("Enter year");
                    var year = Console.ReadLine();
                    Console.WriteLine("Enter actor");
                    var actor = Console.ReadLine();
                    var newMovie = new Movie();
                    newMovie.Title = title;
                    newMovie.Year = year;
                    newMovie.Actor = actor;

                    movies.Add(newMovie);

                    SerializeMoviesToFile(movies, fileName);

                }

                if (option == 3)  //Commnent
                {
                    Console.WriteLine("Comment movies: Enter movie name ");
                    string search = Console.ReadLine();
                    //bool found = false;
                    foreach (var movie in movies)
                    {
                        if (movie.Title.ToLower().Contains(search.ToLower()))
                        {
                            string comment = Console.ReadLine();
                            movie.Comment = comment;
                            SerializeMoviesToFile(movies, fileName);
                            Console.WriteLine("Comment was added");
                            break;
                        }

                    }
                   // if (found == false)
                   // {
                    //    Console.WriteLine("Movie not found");
                    //}

                }
                
                if (option == 4)  //Exit
                {
                    break; 
                }

            }

            foreach (var movie in movies)
            {
                Console.WriteLine("Title: " + movie.Title + "Year: " + movie.Year + "Actor: " + movie.Actor);
            }
        }

        public static void TryParse(int v, out int option)
        {
            throw new NotImplementedException();
        }

        //Reading my cvs file
        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }

        

        //Reading Line
        public static List<string[]> ReadMyProject(string fileName)
        {
            var myProject = new List<string[]>();
            using (var reader = new StreamReader(fileName))
            {
                string line = "";
                reader.ReadLine();
                while ((line = reader.ReadLine()) !=null)
                {
                    
                    string[] values = line.Split(',');
                    myProject.Add(values);
                }
            }
             return myProject;
        }

        //Set JSON seroialzer
        public static List<Movie> DeserializeMovies(string fileName)
        {
            var movies = new List<Movie>();
            var serializer = new JsonSerializer();
            using (var reader = new StreamReader(fileName))
            using (var jsonReader = new JsonTextReader(reader))
            {
                movies = serializer.Deserialize<List<Movie>>(jsonReader);
            }
                
            return movies;
        }

        public static void SerializeMoviesToFile(List<Movie> movies, string fileName)
        {
            var serializer = new JsonSerializer();
            using (var writer = new StreamWriter(fileName))
            using (var jsonWriter = new JsonTextWriter(writer))
            {
                serializer.Serialize(jsonWriter, movies);
            }  
        }
    }
}

