using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class CursosInstructores
    {
        public int Id { get; set; }
        public short IdCurso { get; set; }
        public int IdInstructor { get; set; }
        public DateTime? FechaContratacion { get; set; }

        public virtual Cursos IdCursoNavigation { get; set; }
        public virtual Instructores IdInstructorNavigation { get; set; }
    }
}
