using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassLab11
{
    class Movie
    {
       public Movie(string Title, string Category)
        {
            movieTitle = Title;
            movieCategory = Category;
        }
        private string movieTitle;
        public string MovieTitle
        {
            get
            {
                return movieTitle;
            }
            set
            {
                movieTitle = value;
            }
        }
        private string movieCategory;
        public string MovieCategory
        {
            get
            {
                return movieCategory;
            }
            set
            {
                movieCategory = value;
            }
        }
    }
}