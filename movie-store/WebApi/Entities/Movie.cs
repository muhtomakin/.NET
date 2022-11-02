using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities;

public class Movie
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public int GenreId { get; set; }
    public string Title { get; set; }
    public string Year { get; set; }
    public string Director { get; set; }
    public string Actors { get; set; }
    public int Price { get; set; }
    public Genre Genre { get; set; }
}