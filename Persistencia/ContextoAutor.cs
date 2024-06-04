using Api.Microeservice.Autor.Modelo;
using Microsoft.EntityFrameworkCore;

namespace Api.Microeservice.Autor.Persistencia
{
    public class ContextoAutor : DbContext
    {
        public ContextoAutor(DbContextOptions<ContextoAutor> options) : base(options) { }
        public DbSet<AutorLibro> AutorLibros { get; set; }
        public DbSet<GradoAcademico> GradosAcademicos { get; set; }
    }
}
