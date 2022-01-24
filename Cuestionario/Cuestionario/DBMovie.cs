using Microsoft.EntityFrameworkCore;
using Modelo.Entidades;

namespace ModeloDB
{
    class DBMovie : DbContext
    {
        //Conexion a la bdd
        override protected void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "server = DESKTOP-SUOOS8Q\\SQLEXPRESS; Initial Catalog = MovieDB; trusted_connection = true;"
            );
        }

        public DbSet<film> films { get; set; } //film_id title description release_year language_id rental_duration rental_rate lenght replacement_cost rating last_update special_features fulltext 
        public DbSet<language> languages { get; set; } //language_id nams last_update 
        public DbSet<inventory> inventories { get; set; } //inventory_id film_id store_id last_update

        //constructor vacio
        public DBMovie() : base() { }

        //constructor de conexion al padre
        public DBMovie(DbContextOptions<DBMovie> opciones) : base(opciones) { }

        //Modelado
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Relación uno a muchos; un film pertenece a muchos inventories 
            modelBuilder.Entity<inventory>()
                .HasOne(ar => ar.film)
                .WithMany(dc => dc.inventory)
                .HasForeignKey(ar => ar.film_id);

            // Relación uno a muchos; un language varios films  
            modelBuilder.Entity<film>()
                .HasOne(ct => ct.language)
                .WithMany(pc => pc.films)
                .HasForeignKey(ct => ct.language_id);
        }

    }
}
