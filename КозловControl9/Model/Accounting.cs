//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace КозловControl9.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accounting
    {
        public int Id { get; set; }
        public System.DateTime DateGame { get; set; }
        public int IdGroup { get; set; }
        public int IdTypeCompetition { get; set; }
        public decimal Evaluation { get; set; }
    
        public virtual Group Group { get; set; }
        public virtual TypeCompetition TypeCompetition { get; set; }
    }
}
