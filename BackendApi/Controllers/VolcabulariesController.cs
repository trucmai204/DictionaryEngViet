using Database_Connector;
using Entities;
using Functions;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VolcabulariesController : ControllerBase
    {
        //[HttpGet("FindByWord")]
        //public static List<Vocabulary> FindByWord() 
        //{
        //    return VocabularyScope.FindByWord(); 
        //}
        private AppDbContext _db;
        public VolcabulariesController(AppDbContext db) 
        { 
            _db = db;
        }
        [HttpGet("FindByWord")]
        public ActionResult<List<Vocabulary>> FindByWord(string keyword) // Kieu du lieu cua function nen dat trong ActionResult<>, vi du: ActionResult<List<Vocabulary>>
        {
            return _db.Vocabulary.Where(name => name.Word.Contains(keyword)).ToList(); // FindByWord thi can phai truyen vao keyword de tim, tuc la tim tat ca nhung tu Contain keyword
        }

        //[HttpGet("GetWordTypeOf")]
        //public ActionResult<List<EnumWordType>> GetWordTypeOf(EnumWordType wordType) // Kieu du lieu cua function nen dat trong ActionResult<>, vi du: ActionResult<List<Vocabulary>>
        //{
        //    VocabularyScope.GetWordTypeOf(wordType); // FindByWord thi can phai truyen vao keyword de tim, tuc la tim tat ca nhung tu Contain keyword
        //    return Ok(wordType);
        //}

        [HttpPost("Create")]
        public ActionResult Create([FromBody] Vocabulary vocabulary) 
        {
            try
            {
                var isExist = _db.Vocabulary.Any(v => v.Word.Equals(vocabulary.Word));
                if (!isExist)
                {
                    var newWord = new Vocabulary
                    {
                        Word = vocabulary.Word,
                        WordTypeId = vocabulary.WordTypeId,
                        Pronounciation = vocabulary.Pronounciation,
                        Description = vocabulary.Description
                    };
                    _db.Vocabulary.Add(newWord);
                    _db.SaveChanges();
                    return Created("tạo thành công",newWord); // Thong bao da tao thanh cong
                }
                else
                {
                    return BadRequest("Đã tồn tại");
                }
                
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Update")]
        public ActionResult Update(int id, [FromBody] Vocabulary vocabulary)
        {
            try
            {
                var wordChange = _db.Vocabulary.FirstOrDefault(name => name.Id == id);
                if (wordChange != null)
                {
                    wordChange = vocabulary;

                    _db.Vocabulary.Update(wordChange);
                    _db.SaveChanges();

                    return Ok(vocabulary);
                }
                else
                {
                    return BadRequest("Không tồn tại");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost("CreateMany")]
        public ActionResult CreateMany([FromBody] List<Vocabulary> vocabularies)
        {
            // Them nhieu tu moi: VocabularyScope.CreateMany(vocabularies);
            return Created(); // Thong bao da tao thanh cong
        }

        [HttpDelete("DeleteById")]
        public ActionResult DeleteById(int id)
        {
            VocabularyScope.DeleteById(id);
            return Ok(id); // Thong bao thanh cong
        }

        [HttpDelete("DeleteByKeyword")]
        public ActionResult DeleteByKeyword(string keyword)
        {
             VocabularyScope.DeleteByKeyword(keyword);
            return Ok(); // Thong bao thanh cong
        }
    }
}
