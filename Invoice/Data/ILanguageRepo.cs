using System.Collections.Generic;
using Invoice.Models;

namespace Invoice.Data
{
    public interface ILanguageRepo
    {
        IEnumerable<LanguageModel> GetAllLanguage();
        LanguageModel GetLanguageId(int LanguageId);
    }

}