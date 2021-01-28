using System.Collections.Generic;
using Invoice.Models;

namespace Invoice.Data
{
    public class MockCurrRepo : ICurrRepo
    {
        public IEnumerable<CurrModel> GetAllCurr()
        {
            var currency = new List<CurrModel>
            {
                new CurrModel{CurrId = 1, CurrName = "IDR (Indonesian Rupiah)"},
                new CurrModel{CurrId = 2, CurrName = "USD (United States Dollar)"}
            };
            return currency;
        }

        public CurrModel GetCurrId(int CurrId)
        {
           if(CurrId == 1)
           {
               return new CurrModel{CurrId = 1, CurrName = "IDR (Indonesian Rupiah)"};
           }
           else
           {
               return new CurrModel{CurrId = 2, CurrName = "USD (United States Dollar)"};
           }
        }
    }
}