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
       //     var fileName = Path.Combine(directory.FullName, "MyProject.csv");  //My csv file name
       //     var fileContents = ReadMyProject(fileName);
            var fileName = Path.Combine(directory.FullName, "FavoritMovie.json");  //My Json file name
            var movies = DeserializeMovies(fileName);

            //Enter favorite movie
            Console.WriteLine("Enter q to quit: ");
            var title = "";

            while (true)
            {
                Console.WriteLine("To search - enter 1, to add your favorite movie - enter 2 ");
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
                if (option == 1)
                {
                    Console.WriteLine("Search movies: ");
                }
                if (option == 2)
                {
                    Console.WriteLine("Enter the title: ");
                    title = Console.ReadLine();
                    if (title == "q")
                    {
                        break;  // Stop looping
                    }
                    Console.WriteLine();
                    var year = Console.ReadLine();
                    Console.WriteLine();
                    var actor = Console.ReadLine();
                    var newMovie = new Movie();
                    newMovie.Title = title;
                    newMovie.Year = year;
                    newMovie.Actor = actor;

                    movies.Add(newMovie);
                }
            }

            foreach (var movie in movies)
            {
                Console.WriteLine("Title: " + movie.Title + "Year: " + movie.Year + "Actor: " + movie.Actor);
            }
        }

        private static void TryParse(int v, out int option)
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

