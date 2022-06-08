using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPA_Integrador.Entidades
{
    internal class RecursoTecnologico
    {
        public string numeroRT { get; set; }
        public DateTime fechaAlta { get; set; }
        public Image imagenes { get; set; }
        public DateTime periodicidadMantenimientoPrev { get; set; }
        public DateTime duracionMantPrev { get; set; }
        public TimeOnly fraccionHorariaTurno { get; set; }

        public TipoRecurso tipoRecurso { get; set; }
        public List<CaracteristicaRecurso> caracteristicasRecursos { get; set; }

        public Modelo modeloRT { get; set; }
        public List<Mantenimiento> mantenimientos { get; set; }
        public List<Horario> disponibilidad { get; set; }

        public List<Turno> turnos { get; set; }
        public List<CambioEstado> cambioEstadosRT { get; set; }
    }
}
