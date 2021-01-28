using System.Collections.Generic;
using Invoice.Models;

namespace Invoice.Data
{
    public interface IReceiverRepo
    {
        IEnumerable<ReceiverModel> GetAllReceiver();
        ReceiverModel GetReceiverId(int ReceiverId);
    }

}