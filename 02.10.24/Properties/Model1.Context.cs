﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class toursEntities2 : DbContext
    {

        private static toursEntities2 _context;

        public toursEntities2()
            : base("name=toursEntities2")
        {
        }

        public static toursEntities2 GetContext()
        {
            if (_context == null)
                _context = new toursEntities2();
            return _context;
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Картинки___> Картинки___ { get; set; }
        public virtual DbSet<Комментарии___> Комментарии___ { get; set; }
        public virtual DbSet<Отели> Отели { get; set; }
        public virtual DbSet<Страны___> Страны___ { get; set; }
        public virtual DbSet<Типы_туров___> Типы_туров___ { get; set; }
        public virtual DbSet<Туры> Туры { get; set; }
    }
}