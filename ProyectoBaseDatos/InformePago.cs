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
    
    public partial class InformePago
    {
        public int idCliente { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public int idComprobante { get; set; }
        public decimal Monto { get; set; }
        public System.DateTime Fecha_de_Pago { get; set; }
        public decimal Deuda { get; set; }
        public string Método_de_Pago { get; set; }
    }
}
