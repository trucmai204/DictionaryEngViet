using Database_Connector;
using Entities;

namespace Functions
{
    public static class VocabularyScope
    {
        private static AppDbContext _db = new AppDbContext(null);

        public static List<Vocabulary> FindByWord(string keyword)
        {
            return _db.Vocabulary.Where(name => name.Word.Contains(keyword)).ToList();
        }

        public static void Create(string word, EnumWordType wordtypeId, string pronouciation, string description)
        {
            var isExist = _db.Vocabulary.Any(v => v.Word.Equals(word));
            if (!isExist)
            {
                var newWord = new Vocabulary
                {
                    Word = word,
                    WordTypeId = wordtypeId,
                    Pronounciation = pronouciation,
                    Description = description
                };
                _db.Vocabulary.Add(newWord);
                _db.SaveChanges();
            }
            else
            {
                throw new Exception("Từ đã tồn tại");
            }
        }

        public static List<EnumWordType> GetWordTypeOf(EnumWordType wordType)
        {
            return _db.Vocabulary.Select(type => type.WordTypeId).Distinct().ToList();

        }
        public static void Upgrade(int id, string word, EnumWordType wordtypeId, string pronouciation, string description)
        {
            var wordChange = _db.Vocabulary.FirstOrDefault(name => name.Id == id);
            if (wordChange != null)
            {
                wordChange.Word = word;
                wordChange.WordTypeId = wordtypeId;
                wordChange.Description = description;
                wordChange.Pronounciation = pronouciation;

                _db.Vocabulary.Update(wordChange);
                _db.SaveChanges();
            }
        }
        public static void DeleteById(int id)
        {
            var wordType = _db.Vocabulary.FirstOrDefault(x => x.Id == id);
            if (wordType != null)
            {
                _db.Vocabulary.Remove(wordType);
                _db.SaveChanges();
            }
        }

        public static void DeleteByKeyword(string word)
        {
            var name = _db.Vocabulary.FirstOrDefault(name => name.Word.Contains(word));
            _db.Vocabulary.Remove(name);
            _db.SaveChanges();
        }
    }
}
