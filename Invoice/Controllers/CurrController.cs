using System.Collections.Generic;
using Invoice.Data;
using Invoice.Models;
using Microsoft.AspNetCore.Mvc;


namespace Invoice.Controllers
{
    [Route("api/Currency")]
    [ApiController]
    public class CurrController : ControllerBase
    {
        private readonly MockCurrRepo _repository = new MockCurrRepo();
        [HttpGet]
        public ActionResult <IEnumerable<CurrModel>> GetAllCurr()
        {
            var CurrItems = _repository.GetAllCurr();

            return Ok(CurrItems);
        }

        [HttpGet("{CurrId}")]
        public ActionResult <CurrModel> GetCurrId(int CurrId)
        {
            var CurrItem = _repository.GetCurrId(CurrId);
            return Ok(CurrItem);
        }
    }
}