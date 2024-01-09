using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace TagHelpers.Models
{
    public class MetaTagHelperComponent : TagHelperComponent
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (string.Equals(context.TagName, "head", StringComparison.OrdinalIgnoreCase))
            {
                output.PostContent.AppendHtml($"<meta name=\"title\" content=\"Sayfanın Başlığı\" /> \r\n");
                output.PostContent.AppendHtml($"<meta name=\"description\" content=\"Sayfanın İzahati\" \r\n />");
            }
        }
    }
}
