﻿using SQLite;
namespace Cinepolis.Models
{
    public class Usuario
    {
        [PrimaryKey]
        public int codigo { get; set; }
        public string nombre { get; set; }

        public string correo { get; set; }
    }
}
