using System.Collections.Generic;
using Invoice.Models;

namespace Invoice.Data
{
    public interface ICurrRepo
    {
        IEnumerable<CurrModel> GetAllCurr();
        CurrModel GetCurrId(int CurrId);
    }

}