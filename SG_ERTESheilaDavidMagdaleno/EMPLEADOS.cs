//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SG_ERTESheilaDavidMagdaleno
{
    using System;
    using System.Collections.Generic;
    
    public partial class EMPLEADOS
    {
        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Email { get; set; }
        public string Domicilio { get; set; }
        public byte[] Foto { get; set; }
        public string Empresa { get; set; }
    
        public virtual EMPRESAS EMPRESAS { get; set; }
    }
}
