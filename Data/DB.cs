using LabsJournal3._0.Models;
using Microsoft.EntityFrameworkCore;

namespace LabsJournal3._0.Data
{
    public class DB: DbContext
    {
        public DB(DbContextOptions<DB> options) : base(options) {  }
        public DbSet<LabsjournalItem> LabsjournalItems { get; set; }
        
    }
}
