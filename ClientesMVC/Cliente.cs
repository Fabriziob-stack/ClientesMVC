using System.ComponentModel.DataAnnotations;

namespace ClientesMVC.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(11, ErrorMessage = "El CUIT debe tener 11 dígitos.")]
        public string CUIT { get; set; }

        [Required]
        [StringLength(200)]
        public string RazonSocial { get; set; }

        [Required]
        [StringLength(20)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(200)]
        public string Direccion { get; set; }

        public bool Activo { get; set; }
    }
}