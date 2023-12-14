using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcPractice.Views.HtmlHelpers
{
	public static class SelectHelper
	{
        public static HtmlString CreateSelect(this IHtmlHelper html, string text, Dictionary<int, string> options)
        {
            string result = $"<label>{text}:</label>";
            result += $"<select class=\"form-control\">";
            result += $"<option value=\"\">Select options</option>";
            foreach (var option in options)
            {
                result += $"<option value={option.Key}>{option.Value}</option>";
            }
            result += "</select>";

            return new HtmlString(result);

        }
    }
}

