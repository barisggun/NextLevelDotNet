using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelper.HeisenbergTagHelpers
{
    public class MailLinkTagHelper : TagHelper
    {//override metodun çalışması için nesne üretilecek o entitiyleri de içine ekleyecek
        public string Address { get; set; }
        public string Text { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //context.AllAttributes["address"]
            output.TagName = "a";
            output.Attributes.Add("href", $"mailto: {Address}");
            output.Content.Append(Text);
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}
