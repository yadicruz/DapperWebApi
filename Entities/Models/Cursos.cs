using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Cursos
    {
        public Cursos()
        {
            CursosAlumnos = new HashSet<CursosAlumnos>();
            CursosInstructores = new HashSet<CursosInstructores>();
        }

        public short Id { get; set; }
        public short? IdCatCurso { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaTermino { get; set; }
        public bool? Activo { get; set; }

        public virtual CatCursos IdCatCursoNavigation { get; set; }
        public virtual ICollection<CursosAlumnos> CursosAlumnos { get; set; }
        public virtual ICollection<CursosInstructores> CursosInstructores { get; set; }
    }
}
