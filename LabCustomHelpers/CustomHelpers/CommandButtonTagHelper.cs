using Microsoft.AspNetCore.Razor.TagHelpers;

namespace LabCustomHelpers.CustomHelpers
{
    [HtmlTargetElement("command-button")]
    public class CommandButtonTagHelper : TagHelper
    {
        [HtmlAttributeName("value")]
        public string Value { get; set; }

        [HtmlAttributeName("class")]
        public string CssClass { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            string strHtml = $"<button type='submit' name='command' ass='{CssClass}'>{Value}</button>";
            output.Content.SetHtmlContent(strHtml);
        }
    }
}
