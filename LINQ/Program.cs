using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var favMovieList = new List<string>() { "The Dark Knight", "Avatar 2", "Something Borrowed", "She's Out of Your League", "Harry Potter"};

            //var listMovieOrdered = favMovieList.OrderBy(name => name.Length).ToList();

            //foreach(var movie in listMovieOrdered)
            //{
            // Console.WriteLine(movie);
            //}

            //LINQ method

            //listMovieOrdered.ForEach(Console.WriteLine);

            //LINQ method concise

            favMovieList.OrderBy(name => name.Length).ToList().ForEach(Console.WriteLine);
        }
    }
}
