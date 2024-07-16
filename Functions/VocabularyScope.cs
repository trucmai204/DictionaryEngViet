using Database_Connector;
using Entities;

namespace Functions
{
    public static class VocabularyScope
    {
        private static AppDbContext Db = new AppDbContext();
        public static List<Vocabulary> FindByWord()
        {
            return Db.Vocabulary.OrderBy(name => name.Word).ToList();
        }
    }
}
