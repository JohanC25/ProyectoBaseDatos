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
    
    public partial class Contrato
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contrato()
        {
            this.DetalleContratoes = new HashSet<DetalleContrato>();
        }
    
        public int nContrato { get; set; }
        public byte idTrabajador { get; set; }
        public int idCliente { get; set; }
        public Nullable<int> nCuenta { get; set; }
        public System.DateTime fecha { get; set; }
        public decimal descuento { get; set; }
        public decimal valorFinal { get; set; }
        public decimal entrada { get; set; }
        public decimal bonoInicial { get; set; }
        public System.DateTime fechaPrimerCobro { get; set; }
        public string informacionExtra { get; set; }
        public string estado { get; set; }
    
        public virtual Cliente Cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetalleContrato> DetalleContratoes { get; set; }
        public virtual Trabajador Trabajador { get; set; }
    }
}