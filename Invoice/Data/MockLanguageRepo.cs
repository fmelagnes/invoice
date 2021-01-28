using System.Collections.Generic;
using Invoice.Models;

namespace Invoice.Data
{
    public class MockLanguageRepo : ILanguageRepo
    {
        public IEnumerable<LanguageModel> GetAllLanguage()
        {
            var language = new List<LanguageModel>
            {
                new LanguageModel{LanguageId = 1, LanguageName = "Indonesia"},
                new LanguageModel{LanguageId = 2, LanguageName = "English"}
            };
            return language;
        }

        public LanguageModel GetLanguageId(int LanguageId)
        {
            if(LanguageId == 1)
            {
                return new LanguageModel{LanguageId = 1, LanguageName = "Indonesia"};
            }
            else
            {
                return new LanguageModel{LanguageId = 2, LanguageName = "English"};
            }
        }
    }
}