//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoBaseDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Estudiante
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estudiante()
        {
            this.ClienteEstudiantes = new HashSet<ClienteEstudiante>();
        }
    
        public int idEstudiante { get; set; }
        public short idInstitucionEducativa { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string curso { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClienteEstudiante> ClienteEstudiantes { get; set; }
        public virtual InstitucionEducativa InstitucionEducativa { get; set; }
    }
}
