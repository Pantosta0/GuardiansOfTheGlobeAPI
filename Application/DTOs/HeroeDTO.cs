using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class HeroeDTO
    {
        public virtual string NombreSuper { get; set; } = string.Empty;
        public virtual string Nombre { get; set; } = string.Empty;
        public virtual int Edad { get; set; }
        public virtual string Sexo { get; set; } = string.Empty;
        public virtual string GrupoEdad { get; set; } = string.Empty;
     
        public virtual string Habilidades { get; set; } = string.Empty;
        public virtual string Debilidades { get; set; } = string.Empty;
        public virtual string RelacionesPersonales { get; set; } = string.Empty;
        public virtual int PatrocinadorId { get; set; }
        public virtual ICollection<Patrocinador> Patrocinadores { get; set; }
        public virtual ICollection<Agenda> Agendas { get; set; }
        public virtual ICollection<Pelea> Peleas { get; set; }

    }
}
