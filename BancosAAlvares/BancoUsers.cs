//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BancosAAlvares
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class BancoUsers
    {
        [Key]
        public int IdBancoUser { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Grupos { get; set; }
    }
}
