﻿using Database_Connector;
using Entities;

namespace Functions
{
    public static class VocabularyScope
    {
        private static AppDbContext Db = new AppDbContext();
     
        public static List<Vocabulary> FindByWord(string keyword)
        {
            return Db.Vocabulary.Where(name => name.Word.Contains(keyword)).ToList();
        }

        public static void Create(string word, EnumWordType wordtypeId, string pronouciation, string description)
        {
            var isExist = Db.Vocabulary.Any(v => v.Word.Equals(word));
            if (!isExist)
            {
                var newWord = new Vocabulary
                {
                    Word = word,
                    WordTypeId = wordtypeId,
                    Pronounciation = pronouciation,
                    Description = description
                };
                Db.Vocabulary.Add(newWord);
                Db.SaveChanges();
            }
            else 
            {
                throw new Exception("Từ đã tồn tại");
            }
        }

        public static List<EnumWordType> GetWordTypeOf(EnumWordType wordType) 
        { 
            return Db.Vocabulary.Select(type => type.WordTypeId).Distinct().ToList();

        }
        public static void Upgrade(int id, string word, EnumWordType wordtypeId, string pronouciation, string description) 
        {
            var wordChange = Db.Vocabulary.FirstOrDefault(name => name.Id == id);
            if (wordChange != null) 
            {
                wordChange.Word = word;
                wordChange.WordTypeId = wordtypeId;
                wordChange.Description = description;
                wordChange.Pronounciation = pronouciation;

                Db.Vocabulary.Update(wordChange);
                Db.SaveChanges();
            }
        }
        public static void DeleteById(int id) 
        { 
            var wordType = Db.Vocabulary.FirstOrDefault(x => x.Id == id);
            if (wordType != null) 
            { 
                Db.Vocabulary.Remove(wordType);
                Db.SaveChanges();
            }
        }

        public static void DeleteByKeyword(string word) 
        { 
            var name = Db.Vocabulary.FirstOrDefault(name => name.Word.Contains(word));
            Db.Vocabulary.Remove(name);
            Db.SaveChanges();
        }
    }
}
