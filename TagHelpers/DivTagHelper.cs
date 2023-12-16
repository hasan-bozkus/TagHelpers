using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TagHelpers.TagHelpers
{
    [HtmlTargetElement(ParentTag = "form", Attributes = "fontsize")]
    public class DivTagHelper : TagHelper
    {
        public string fontsize { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.SetAttribute("style", $"font-size:{fontsize}");
        }
    }
}
