using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace TagHelpers.TagHelpers
{
    [HtmlTargetElement("namesurname-tag-helper")]
    public class CustomTagHelpers : TagHelper
    {
        public string NameSurname { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "CustomTagHelpers";
            output.TagMode = TagMode.StartTagAndEndTag;

            var sb = new StringBuilder();
            sb.AppendFormat("<span>SelamünAleyküm {0}</span>", this.NameSurname);
            output.PreContent.SetHtmlContent(sb.ToString());
        }
    }
}
