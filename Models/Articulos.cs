using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Models
{
    public class Articulos
    {
        [Key] 
        public int ArticuloId { get; set; }
        [Required(ErrorMessage = "Se necesita colocar una fecha")]
        [Range(typeof(DateTime), minimum: "1/1/1980", maximum: "1/1/2025", ErrorMessage = "La fecha esta mal")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Se necesita colocar una descripcion")]
        [StringLength(maximumLength: 99, MinimumLength = 2, ErrorMessage = "Es muy corto o muy largo")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "Se necesita colocar un costo")]
        [Range(typeof(decimal), minimum: "0", maximum: "1000000", ErrorMessage = "El costo esta muy elevado")]
        public decimal Costo { get; set; }

        [Required(ErrorMessage = "Se necesita colocar una ganancia")]
        [Range(typeof(decimal), minimum: "0", maximum: "1000000", ErrorMessage = "El costo estan muy elevadas")]
        public decimal Ganancia { get; set; }

        [Required(ErrorMessage = "Se necesita colocar un precio")]
        [Range(typeof(decimal), minimum: "1", maximum: "100000000", ErrorMessage = "Las ganancia esta muy elevada")]
        public decimal Precio { get; set; }

        public Articulos()
        {
            ArticuloId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Costo = 0;
            Ganancia = 0;
            Precio = 0;
        }
    }
}
