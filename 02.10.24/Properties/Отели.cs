//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _02._10._24.Properties
{
    using System;
    using System.Collections.Generic;
    
    public partial class Отели
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Отели()
        {
            this.Картинки___ = new HashSet<Картинки___>();
            this.Комментарии___ = new HashSet<Комментарии___>();
            this.Туры = new HashSet<Туры>();
        }
    
        public int Код_отеля { get; set; }
        public string Краткое_название_страны { get; set; }
        public string Название_отеля { get; set; }
        public Nullable<int> Оценка { get; set; }
        public string название_страны { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Картинки___> Картинки___ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Комментарии___> Комментарии___ { get; set; }
        public virtual Страны___ Страны___ { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Туры> Туры { get; set; }
    }
}
