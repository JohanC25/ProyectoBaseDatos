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
    
    public partial class Secretario
    {
        public int idSecretario { get; set; }
        public byte idTrabajador { get; set; }
        public string email { get; set; }
    
        public virtual Trabajador Trabajador { get; set; }
    }
}
