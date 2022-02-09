using LabsJournal3._0.Models;

namespace LabsJournal3._0.Data.Repository
{
    public interface IRepository
    {
        IEnumerable<LabsjournalItem> GetAllItems();
        void AddLabsjournal(string labsjournalName, string grouppNum);
        void ValueChanged(LabsjournalItem changedItem);
        void DeleteLabsjournal(int id);
    }
}
