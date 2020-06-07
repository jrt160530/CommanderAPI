using Commander.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class CommanderContext : DbContext
    {
       // Type "ctor" + tab for auto generatrion
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }

        // "prop" + tab for quick generation.
        public DbSet<Command> Commands { get; set; }

    }
}