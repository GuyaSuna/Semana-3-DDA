using System.ComponentModel.DataAnnotations;

namespace Ej1_Semana3.Models
{
    public class Turno
    {

        public int Id { get; set; }

        [Required(ErrorMessage ="Nombre es obligatorio")]
        public string NombreMascota { get; set; } = string.Empty;
        [Required(ErrorMessage ="Responsable es obligatorio")]
        public string Responsable {  get; set; } = string.Empty;

        [Required(ErrorMessage = "Servicio contratado es obligatorio")]
        public string ServicioSolicitado {  get; set; } = string.Empty;

        public bool Confirmado { get; set; }
    }
}
