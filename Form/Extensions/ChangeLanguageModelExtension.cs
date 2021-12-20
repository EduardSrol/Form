using Form.Enums;
using Form.Models;

namespace Form.Extensions
{
    public static class ChangeLanguageModelExtension
    {
        public static string ToShort(this ChangeLanguageModel model)
        {
            return model.Language switch
            {
                Language.English => "en-US",
                Language.Czech => "cs-CZ",
                _ => ""
            };
        }
    }
}
