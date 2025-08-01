using prjICE_TASK_2_Indexers;

namespace TestMovies
{
    [TestClass]
    public sealed class Test1
    {
        //test that values are get and set correctly 
        [TestMethod]
        public void TestTitleIntIndex()
        {
            Movies movie = new Movies("Avatar", "James Cameron", "Sci-fi", 2009, 81);
            Assert.AreEqual(movie[0], "Avatar");
        }

        [TestMethod]
        public void TestGenreStringIndex()
        {
            Movies movie = new Movies("Avatar", "James Cameron", "Sci-fi", 2009, 81);
            Assert.AreEqual(movie["genre"], "Sci-fi");
        }

        [TestMethod]
        public void TestUpdateIntIndex()
        {
            Movies movie = new Movies("Avatar", "James Cameron", "Sci-fi", 2009, 81);
            movie[0] = "Alien";
            movie[1] = "Ridley Scott";
            movie[2] = "Horror & Sci-fi";
            movie[3] = 1979;
            movie[4] = 93;
            Assert.AreEqual(movie[1], "Ridley Scott");
        }

        [TestMethod]
        public void TestUpdateStringIndex()
        {
            Movies movie = new Movies("Avatar", "James Cameron", "Sci-fi", 2009, 81);
            movie[0] = "Alien";
            movie[1] = "Ridley Scott";
            movie[2] = "Horror & Sci-fi";
            movie[3] = 1979;
            movie[4] = 93;
            Assert.AreEqual(movie["year"], 1979);
        }

        [TestMethod]
        public void TestOutputIntIndex()
        {
            Movies movie = new Movies("Interstellar", "Christopher Nolan", "Adventure, Drama & Sci-fi", 2014, 74);
            string expected = $"The film, Interstellar, was released in {2014} and is directed by Christopher Nolan. " +
                $"It is an Adventure, Drama & Sci-fi film and got a review score of {74}";
            string actual = $"The film, {movie[0]}, was released in {movie["year"]} and is directed by {movie["director"]}. " +
                $"It is an {movie[2]} film and got a review score of {movie[4]}";
            Assert.AreEqual(expected, actual);
        }
    }
}
