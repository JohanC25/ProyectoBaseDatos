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
    
    public partial class InformeCliente
    {
        public int idCliente { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string cedula { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string ciudad { get; set; }
        public string dirección { get; set; }
        public string nombreEmpresa { get; set; }
        public string telefonoEmpresa { get; set; }
        public string direccionEmpresa { get; set; }
        public string conyugue { get; set; }
        public string empresaConyugue { get; set; }
        public string tipoVivienda { get; set; }
        public string direccionCobros { get; set; }
        public int nContrato { get; set; }
        public System.DateTime fecha { get; set; }
        public decimal descuento { get; set; }
        public decimal valorFinal { get; set; }
        public decimal entrada { get; set; }
        public decimal bonoInicial { get; set; }
        public System.DateTime fechaPrimerCobro { get; set; }
        public string informacionExtra { get; set; }
        public string estado { get; set; }
        public Nullable<int> idComprobante { get; set; }
        public Nullable<decimal> valor { get; set; }
        public Nullable<System.DateTime> fechaPago { get; set; }
        public Nullable<System.DateTime> fechaSiguientePago { get; set; }
        public Nullable<decimal> deuda { get; set; }
        public string metodoPago { get; set; }
    }
}
