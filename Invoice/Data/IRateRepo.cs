using System.Collections.Generic;
using Invoice.Models;

namespace Invoice.Data
{
    public interface IRateRepo
    {
        IEnumerable<RateModel> GetAllRate();
        RateModel GetRateId(int RateId);
    }

}