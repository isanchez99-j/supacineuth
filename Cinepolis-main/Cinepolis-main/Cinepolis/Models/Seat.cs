using Postgrest.Attributes;
using Postgrest.Models;

namespace Cinepolis.Models
{
    [Table("seats")]
    class Seat : BaseModel
    {
        [PrimaryKey("id")]
        public int id { get; set; }
        [Column("busy")]
        public bool busy { get; set; }
        [Column("id_pelicula")]
        public int idPelicula { get; set; }
    }
}

