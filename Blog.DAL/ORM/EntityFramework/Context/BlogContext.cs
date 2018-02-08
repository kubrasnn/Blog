namespace Blog.DAL.ORM.EntityFramework.Context
{
    using Blog.DAL.ORM.EntityFramework.Configurations;
    using Blog.Entity.Entities;
    using System;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using System.Linq;

    public class BlogContext : DbContext
    {
    
        public BlogContext() : base("BlogContext")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<BlogContext>());
        }
    
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Kullanici> Kullanici { get; set; }
        public virtual DbSet<KullaniciRol> KullaniciRol { get; set; }
        public virtual DbSet<Makale> Makale { get; set; }
        public virtual DbSet<Resim> Resim { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Yorum> Yorum { get; set; }
        public virtual DbSet<Iletisim> Iletisim { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new KategoriMap());
            modelBuilder.Configurations.Add(new KullaniciMap());
            modelBuilder.Configurations.Add(new KullaniciRolMap());
            modelBuilder.Configurations.Add(new MakaleMap());
            modelBuilder.Configurations.Add(new ResimMap());
            modelBuilder.Configurations.Add(new RolMap());
            modelBuilder.Configurations.Add(new YorumMap());
            modelBuilder.Configurations.Add(new IletisimMap());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
         
            modelBuilder.Conventions.Add(new OneToManyCascadeDeleteConvention());
        }
    }

   
}