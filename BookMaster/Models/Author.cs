//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookMaster.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Author
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Author()
        {
            this.BookAuthor = new HashSet<BookAuthor>();
        }
    
        public int Id { get; set; }
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string MiddleName { get; set; }
        public string FullName { get
            {
                return Lastname + " " + Name + " " + MiddleName;
            } }
        public string Bio { get; set; }
        public System.DateTime BirthDay { get; set; }
        public Nullable<System.DateTime> DeathDate { get; set; }
        public string Wikipedia { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BookAuthor> BookAuthor { get; set; }
    }
}
