using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sistemaLibreria.Modelo
{
    [Table("Permisos")]
    public class Permiso
    {
        [Key]
        public int pkPermiso { get; set; }

        [Required(ErrorMessage = "este campo es requerido")]
        [StringLength(40)]
        public String sModulo { get; set; }

        [Required(ErrorMessage = "este campo es requerido")]
        [StringLength(150)]
        public String sDescripcion { get; set; }

        public Boolean bStatus { get; set; }

        public Permiso()
        {
            this.bStatus = true;
        }

        public ICollection<PermisoNegadoRol> PermisosNegadosRol { get; set; }
    }
}
