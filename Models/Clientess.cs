using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Clientes.Models
{
    public class Clientess
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es obligatorio")]
        public string Nombre { get; set; }

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$")]
        [Phone(ErrorMessage = "Digite correctamente el numero de su celular. Ejemplo 809-244-9957")]
        public string Telefono { get; set; }

        [RegularExpression(@"^\d{3}-\d{3}-\d{4}$")]
        [Phone(ErrorMessage = "Digite correctamente el numero Telefonico. Ejemplo 809-244-9957")]
        public string Celular { get; set; }

        [Required(ErrorMessage = "El RNC es requerido")]
        public string RNC { get; set; }

        [Remote(action: "VerifyEmail", controller: "Users")]
        [EmailAddress(ErrorMessage = "digite un email valido. Ejemplo example01@example.com")]
        public string Email { get; set; }

        [Required(ErrorMessage = "La dirección es requerida")]
        public string Direccion { get; set; }
    }
}
