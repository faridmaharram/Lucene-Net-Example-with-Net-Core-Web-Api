using Lucene_Net_Example.Business;
using Lucene_Net_Example.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Lucene_Net_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LuceneController : ControllerBase
    {
        LuceneService _luceneService = new();
        [HttpGet]
        public async Task<IActionResult> Select(string searchKey)
        {
            var result = await _luceneService.SelectData(searchKey);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Insert(List<Person> people)
        {
            var result = _luceneService.InsertData(people);
            return Ok(result);
        }

        [HttpPut]
        public IActionResult Update(List<Person> people)
        {
            var result = _luceneService.UpdateData(people);
            return Ok(result);
        }

        [HttpDelete]
        public IActionResult Delete(string Name)
        {
            var result = _luceneService.DeleteData(Name);
            return Ok(result);
        }
    }
}
