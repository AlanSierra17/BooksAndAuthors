//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Authors.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Books
    {
        public int IdBooks { get; set; }
        public string BookName { get; set; }
        public short YearOfPublication { get; set; }
        public int Editorial { get; set; }
        public int Author { get; set; }
    
        public virtual Authors Authors { get; set; }
        public virtual Editorials Editorials { get; set; }
    }
}
