using System.ComponentModel.DataAnnotations;

namespace AngularAPI.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Year { get; set; }
    }
}
