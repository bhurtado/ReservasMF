//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReservasMF.Repositorio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reserva
    {
        public int Id { get; set; }
        public System.DateTime FechaIngreso { get; set; }
        public System.DateTime FechaSalida { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}