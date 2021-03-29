using System;

namespace Domain
{
    public class Movie : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public bool Adult { get; set; }
        public string Backdrop_path { get; set; }
        public string Original_language { get; set; }
        public string Original_title { get; set; }
        public decimal Popularity { get; set; }
        public string Poster_path { get; set; }
        public string Release_date { get; set; }
        public bool Video { get; set; }
        public float Vote_avarage { get; set; }
        public int Vote_count { get; set; }
        
    }
}