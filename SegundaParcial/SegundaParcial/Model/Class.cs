using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

public partial class Productos
{
    public class Producto
    {
        [Required(ErrorMessage = "El número de inventario es obligatorio.")]
        public int NumeroInventario { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [StringLength(200, ErrorMessage = "El nombre no puede tener más de 200 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El departamento es obligatorio.")]
        public string Departamento { get; set; }
    }
}
