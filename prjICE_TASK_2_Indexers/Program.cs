namespace prjICE_TASK_2_Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movies movie = new Movies("Avengers Infinity War", "The Russso Brothers", "Action", 2018, 85);
            movie[2] = "Superhero Action";

            Console.WriteLine(movie[0]); // Output: Avengers Infinity War
            Console.WriteLine(movie[1]); //Output: The Russso Brothers
            Console.WriteLine(movie[2]); // Output: Superhero Action
            Console.WriteLine(movie[3]); // Output: 2018
            Console.WriteLine(movie[4]); // Output: 85

            Movies movies = new Movies("Avengers Endgame", "The Russso Brothers", "Sci-fi", 2018, 94);
            movies["movieGenre"] = "Sci-fi & Superhero Action";

            Console.WriteLine($"Movie title: {movies["movieTitle"]}"); // Output: Avengers Endgame
            Console.WriteLine($"Movie director: {movies["movieDirector"]}"); // Output: The Russso Brothers
            Console.WriteLine($"Movie genre: {movies["movieGenre"]}"); // Output: Sci-fi & Superhero Action
            Console.WriteLine($"Release year: {movies["releaseYear"]}"); // Output: 2018
            Console.WriteLine($"Rotten tomato score: {movies["reviewScore"]}"); // Output: 94
        }
    }
}
