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

        [HttpGet("FindByWord")]
        public ActionResult<List<Vocabulary>> FindByWord(string keyword) // Kieu du lieu cua function nen dat trong ActionResult<>, vi du: ActionResult<List<Vocabulary>>
        {
            return VocabularyScope.FindByWord(keyword); // FindByWord thi can phai truyen vao keyword de tim, tuc la tim tat ca nhung tu Contain keyword
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
                VocabularyScope.Create(vocabulary.Word, vocabulary.WordTypeId, vocabulary.Pronounciation, vocabulary.Description);
                return Created(); // Thong bao da tao thanh cong
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Upgrade {id}")]
        public ActionResult Upgrade(int id, [FromBody] Vocabulary vocabulary)
        {
            try
            {
                VocabularyScope.Upgrade(id, vocabulary.Word, vocabulary.WordTypeId, vocabulary.Pronounciation, vocabulary.Description);
                return Ok(vocabulary);
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
