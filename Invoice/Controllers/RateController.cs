using System.Collections.Generic;
using Invoice.Data;
using Invoice.Models;
using Microsoft.AspNetCore.Mvc;


namespace Invoice.Controllers
{
    [Route("api/Rate")]
    [ApiController]
    public class RateController : ControllerBase
    {
        private readonly MockRateRepo _repository = new MockRateRepo();
        [HttpGet]
        public ActionResult <IEnumerable<RateModel>> GetAllRate()
        {
            var RateItems = _repository.GetAllRate();

            return Ok(RateItems);
        }

        [HttpGet("{RateId}")]
        public ActionResult <RateModel> GetRateId(int RateId)
        {
            var RateItem = _repository.GetRateId(RateId);
            return Ok(RateItem);
        }
    }
}