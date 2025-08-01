using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace prjICE_TASK_2_Indexers
{
    public class Movies
    {
        //declare variables related tomovie details
        private string movieTitle = "";
        private string movieDirector = "";
        private string movieGenre = "";
        private int releaseYear = 0;
        private int reviewScore = 0;

        //constructor to give values to variables
        public Movies(string movieTitle, string movieDirector, string movieGenre, int releaseYear, int reviewScore)
        {
            this.movieTitle = movieTitle;
            this.movieDirector = movieDirector;
            this.movieGenre = movieGenre;
            this.releaseYear = releaseYear;
            this.reviewScore = reviewScore;
        }

        //integer indexer
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.movieTitle;
                else if (index == 1)
                    return this.movieDirector;
                else if (index == 2)
                    return this.movieGenre;
                else if (index == 3)
                    return this.releaseYear;
                else if (index == 4)
                    return this.reviewScore;
                else return null;
            }
            set
            {
                if (index == 0)
                    this.movieTitle = (string)value;
                else if (index == 1)
                    this.movieDirector = (string)value;
                else if (index == 2)
                    this.movieGenre = (string) value;
                else if (index == 3)
                    this.releaseYear = (int)value;
                else if (index == 4)
                    this.reviewScore = (int)value;
            }
        }

        //string indexer
        public object this[string attrName]
        {
            get
            {
                if (attrName == "title")
                    return this.movieTitle;
                if (attrName == "director")
                    return this.movieDirector;
                else if (attrName == "genre")
                    return this.movieGenre;
                else if (attrName == "year")
                    return this.releaseYear;
                else if (attrName == "review")
                    return this.reviewScore;
                else return null;
            }
            set
            {
                if (attrName.ToLower().Equals("title"))
                    this.movieTitle = (string)value;
                else if (attrName.ToLower().Equals("director"))
                    this.movieDirector = (string)value;
                else if (attrName.ToLower().Equals("genre"))
                    this.movieGenre = (string)value;
                else if (attrName.ToLower().Equals("year"))
                    this.releaseYear = (int)value;
                else if (attrName.ToLower().Equals("review"))
                    this.reviewScore = (int)value;
            }


        }
    }
}
