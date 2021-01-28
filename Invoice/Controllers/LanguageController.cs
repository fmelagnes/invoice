using System.Collections.Generic;
using Invoice.Data;
using Invoice.Models;
using Microsoft.AspNetCore.Mvc;


namespace Invoice.Controllers
{
    [Route("api/language")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly MockLanguageRepo _repository = new MockLanguageRepo();
        [HttpGet]
        public ActionResult <IEnumerable<LanguageModel>> GetAllLanguage()
        {
            var LanguageItems = _repository.GetAllLanguage();

            return Ok(LanguageItems);
        }

        [HttpGet("{LanguageId}")]
        public ActionResult <LanguageModel> GetLanguageId(int LanguageId)
        {
            var LanguageItem = _repository.GetLanguageId(LanguageId);
            return Ok(LanguageItem);
        }
    }
}