using Postgrest.Attributes;
using Postgrest.Models;

namespace Cinepolis.Models
{
    [Table("peliculas")]
    class Movie : BaseModel
    {
        [PrimaryKey("idPelicula")]
        public int idPelicula { get; set; }
        [Column("nombre")]
        public string nombre { get; set; }
        [Column("synopsis")]
        public string synopsis { get; set; }
        [Column("anio")]
        public string anio { get; set; }
        [Column("clasificacion")]
        public string clasificacion { get; set; }
        [Column("genero")]
        public string genero { get; set; }
        [Column("director")]
        public string director { get; set; }
        [Column("duracion")]
        public string duracion { get; set; }
        [Column("video")]
        public string video { get; set; }
        [Column("banner")]
        public string banner { get; set; }
        [Column("location")]
        public string location { get; set; }
    }
    
}
