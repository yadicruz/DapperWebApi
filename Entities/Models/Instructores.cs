using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Instructores
    {
        public Instructores()
        {
            CursosInstructores = new HashSet<CursosInstructores>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Rfc { get; set; }
        public string Curp { get; set; }
        public decimal CuotaHora { get; set; }
        public bool Activo { get; set; }

        public virtual ICollection<CursosInstructores> CursosInstructores { get; set; }
    }
}
