using Microsoft.EntityFrameworkCore;
using Form.Models;

namespace Form.Data
{
    public class FormDbContext : DbContext
    {
        public FormDbContext(DbContextOptions<FormDbContext> options) : base(options)
        {
        }
        public DbSet<FormModel> Forms { get; set; }

    }
}
