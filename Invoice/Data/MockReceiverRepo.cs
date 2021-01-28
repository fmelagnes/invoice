using System.Collections.Generic;
using Invoice.Models;

namespace Invoice.Data
{
    public class MockReceiverRepo : IReceiverRepo
    {
        public IEnumerable<ReceiverModel> GetAllReceiver()
        {
            var receiver = new List<ReceiverModel>
            {
                new ReceiverModel{ReceiverId = 1, ReceiverName = "Fitria", Address = "Jl. Mandala Tengah No. 3 Tomang Grogol"},
                new ReceiverModel{ReceiverId = 2, ReceiverName = "Mela Agnes", Address = "Jl. Mandala Barat No. 4 Tomang Grogol"}
            };
            return receiver;
        }

        public ReceiverModel GetReceiverId(int ReceiverId)
        {
            if (ReceiverId == 1)
            {
                return new ReceiverModel{ReceiverId = 1, ReceiverName = "Fitria", Address = "Jl. Mandala Tengah No. 3 Tomang Grogol"};
            }
            else
            {
                return new ReceiverModel{ReceiverId = 2, ReceiverName = "Mela Agnes", Address = "Jl. Mandala Barat No. 4 Tomang Grogol"};
            }
        }
    }
}