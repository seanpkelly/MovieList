using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10MovieList
{
    class Movies
    {
        #region fields
        private string _genre;
        private string _title;
        private string _quality;
        #endregion

        #region Properties
        public string Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Quality
        {
            get { return _quality; }
            set { _quality = value; }
        }
        #endregion
        #region Constructors
        public Movies()
        {
            _title = "Does Not Exist";
        }

        public Movies(string genre, string title, string quality)
        {
            _genre = genre;
            _title = title;
            _quality = quality;
        }
        #endregion

        #region Methods

        public void FilmTitles()
        {
            

        }

        #endregion

    }
}
