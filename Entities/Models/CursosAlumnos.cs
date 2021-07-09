using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class CursosAlumnos
    {
        public int Id { get; set; }
        public short IdCurso { get; set; }
        public int IdAlumno { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public DateTime? FechaBaja { get; set; }
        public byte? Calificacion { get; set; }

        public virtual Alumnos IdAlumnoNavigation { get; set; }
        public virtual Cursos IdCursoNavigation { get; set; }
    }
}
