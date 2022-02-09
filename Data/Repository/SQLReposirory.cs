using LabsJournal3._0.Models;

namespace LabsJournal3._0.Data.Repository
{
    public class SQLReposirory : IRepository
    {
        private readonly DB _context;

        public SQLReposirory(DB context)
        {
            _context = context;
        }

        public void AddLabsjournal(string labsjournalName, string grouppNum)
        {
            LabsjournalItem newItem = new LabsjournalItem()
            {
                Name = labsjournalName,
                Group = grouppNum,
                ExecutionOfWork = false,
                ReportExecution = false,
                ProtectingTheReport = false
            };

            _context.LabsjournalItems.Add(newItem);
            _context.SaveChanges();

        }

        public void DeleteLabsjournal(int id)
        {
            var deletedItem = _context.LabsjournalItems.Find(id);
            if (deletedItem != null)
            {
                _context.LabsjournalItems.Remove(deletedItem);
                _context.SaveChanges();
            }
        }

        public IEnumerable<LabsjournalItem> GetAllItems()
        {
            return _context.LabsjournalItems;
        }

        public void ValueChanged(LabsjournalItem changedItem)
        {
            var item =_context.LabsjournalItems.Attach(changedItem);
            item.State= Microsoft.EntityFrameworkCore.EntityState.Modified;

            _context.SaveChanges();
        }
    }
}
