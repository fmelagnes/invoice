using System.Collections.Generic;
using Invoice.Models;

namespace Invoice.Data
{
    public class MockRateRepo : IRateRepo
    {
        public IEnumerable<RateModel> GetAllRate()
        {
            var rate = new List<RateModel>
            {
                new RateModel{RateId = 1, RateCode = "km", RateName = "kilometer"},
                new RateModel{RateId = 2, RateCode = "m", RateName = "meter"},
                new RateModel{RateId = 3, RateCode = "kg", RateName = "kilogram"},
                new RateModel{RateId = 4, RateCode = "jam", RateName = "jam"},
                new RateModel{RateId = 5, RateCode = "menit", RateName = "menit"},
                new RateModel{RateId = 6, RateCode = "strip", RateName = "strip"}

            };
            return rate;
        }

        public RateModel GetRateId(int RateId)
        {
           switch (RateId)
           {
               case 1 :
               return new RateModel{RateId = 1, RateCode = "km", RateName = "kilometer"};
               break;
               case 2 :
               return new RateModel{RateId = 2, RateCode = "m", RateName = "meter"};
               break;
               case 3 :
               return new RateModel{RateId = 3, RateCode = "kg", RateName = "kilogram"};
               break;
               case 4 :
               return new RateModel{RateId = 4, RateCode = "jam", RateName = "jam"};
               break;
               case 5 :
               return new RateModel{RateId = 5, RateCode = "menit", RateName = "menit"};
               break;
               case 6 :
               return new RateModel{RateId = 6, RateCode = "strip", RateName = "strip"};
               break;
               default:
               return new RateModel{RateId = 6, RateCode = "strip", RateName = "strip"};
               break;
           }
        }
    }
}