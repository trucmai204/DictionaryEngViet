using Database_Connector;
using Entities;
using Humanizer.Inflections;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VocabulariesController : ControllerBase
    {
        
        private AppDbContext _db;
        public VocabulariesController(AppDbContext db) 
        { 
            _db = db;
        }

        [HttpGet("FindByWord")]
        public ActionResult<List<Entities.Vocabulary>> FindByWord(string keyword) // Kieu du lieu cua function nen dat trong ActionResult<>, vi du: ActionResult<List<Vocabulary>>
        {
            return _db.Vocabulary.Where(name => name.Word.Contains(keyword)).ToList(); // FindByWord thi can phai truyen vao keyword de tim, tuc la tim tat ca nhung tu Contain keyword
        }

        [HttpGet("FindById")]
        public ActionResult<Entities.Vocabulary> FindById(int id)
        {
            try
            {
                var exists = _db.Vocabulary.FirstOrDefault(x => x.Id == id);
                if (exists != null)
                {
                    return Ok(exists);
                }
                else 
                {
                    return NotFound();
                }
                
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message);
            }
        }
        //[HttpGet("GetWord")]
        //public ActionResult<Entities.Vocabulary> GetWord(string name)
        //{
        //    try
        //    {
        //        var exists = _db.Vocabulary.Select(n => n.Word);
        //        if (exists != null)
        //        {
        //            return Ok(exists);
        //        }
        //        else
        //        {
        //            return NotFound();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
        [HttpPost("Create")]
        public ActionResult Create(Entities.Vocabulary vocabulary)
        {
            try
            {
                var isExist = _db.Vocabulary.Any(v => v.Word.Equals(vocabulary.Word));
                if (!isExist)
                {
                    var newWord = new Entities.Vocabulary
                    {
                        Word = vocabulary.Word,
                        WordTypeId = vocabulary.WordTypeId,
                        Pronounciation = vocabulary.Pronounciation,
                        Description = vocabulary.Description
                    };
                    _db.Vocabulary.Add(newWord);
                    _db.SaveChanges();
                    return Created("Successful",newWord); // Thong bao da tao thanh cong
                }
                else
                {
                    return BadRequest("Request cannot be fulfilled");
                }
                
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("Update")]
        public ActionResult Update(int id, [FromBody] Entities.Vocabulary vocabulary)
        {
            try
            {
                var wordChange = _db.Vocabulary.FirstOrDefault(name => name.Id == id);
                if (wordChange != null)
                {
                    wordChange.Word = vocabulary.Word;
                    wordChange.WordTypeId = vocabulary.WordTypeId;
                    wordChange.Pronounciation = vocabulary.Pronounciation;
                    wordChange.Description = vocabulary.Description;

                    _db.Vocabulary.Update(wordChange);
                    _db.SaveChanges();

                    return Ok(wordChange);
                }
                else
                {
                    return BadRequest("Request cannot be fulfilled");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("CreateMany")]
        public async Task<ActionResult> CreateMany([FromBody] Entities.Vocabulary vocabularies)
        {
            try
            {
                var isExist = _db.Vocabulary.Any(v => v.Word.Equals(vocabularies));
                if (!isExist)
                {
                    var newWord = new Entities.Vocabulary
                    {
                        Word = vocabularies.Word,
                        WordTypeId = vocabularies.WordTypeId,
                        Pronounciation = vocabularies.Pronounciation,
                        Description = vocabularies.Description
                    };
                    _db.Vocabulary.AddRange(newWord);
                    _db.SaveChanges();
                    return Created("Successful", newWord); // Thong bao da tao thanh cong
                }
                else
                {
                    return BadRequest("Request cannot be fulfilled");
                }
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("DeleteById")]
        public ActionResult DeleteById(int id)
        {
            try
            {
                var wordType = _db.Vocabulary.FirstOrDefault(x => x.Id == id);
                if (wordType != null)
                {
                    _db.Vocabulary.Remove(wordType);
                    _db.SaveChanges();
                    
                    return Ok(id); // Thong bao thanh cong
                }
                else
                {
                    return BadRequest("Request cannot be fulfilled");
                }
            }
            catch (Exception ex) 
            { 
                return BadRequest(ex.Message);
            }
           
        }

        [HttpDelete("DeleteByKeyword")]
        public ActionResult DeleteByKeyword(string keyword)
        {
            try
            {
                var name = _db.Vocabulary.FirstOrDefault(name => name.Word.Contains(keyword));
               
                if (name != null)
                {
                    _db.Vocabulary.Remove(name);
                    _db.SaveChanges();

                    return Ok(keyword); // Thong bao thanh cong
                }
                else
                {
                    return BadRequest("Request cannot be fulfilled");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
