using EmprestimoLivros.Models;
using Microsoft.EntityFrameworkCore;

namespace EmprestimoLivros.Data
{
    public class EmprestimoContext : DbContext
    {
        public EmprestimoContext(DbContextOptions<EmprestimoContext> options) : base(options)
        {

        }

        public DbSet<EmprestimosModel> Emprestimos { get; set;}
    }
}
