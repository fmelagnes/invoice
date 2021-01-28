using System.Collections.Generic;
using Invoice.Data;
using Invoice.Models;
using Microsoft.AspNetCore.Mvc;


namespace Invoice.Controllers
{
    [Route("api/Receiver")]
    [ApiController]
    public class ReceiverController : ControllerBase
    {
        private readonly MockReceiverRepo _repository = new MockReceiverRepo();
        [HttpGet]
        public ActionResult <IEnumerable<ReceiverModel>> GetAllReceiver()
        {
            var ReceiverItems = _repository.GetAllReceiver();

            return Ok(ReceiverItems);
        }

        [HttpGet("{ReceiverId}")]
        public ActionResult <ReceiverModel> GetReceiverId(int ReceiverId)
        {
            var ReceiverItem = _repository.GetReceiverId(ReceiverId);
            return Ok(ReceiverItem);
        }
    }
}