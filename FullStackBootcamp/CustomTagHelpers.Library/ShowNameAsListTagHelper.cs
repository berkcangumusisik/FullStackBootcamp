using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomTagHelpers.Library
{
    public class ShowNameAsListTagHelper : TagHelper
    {
        public List<string> Names { get; set; } = new List<string>();

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "ul";

            foreach (var name in Names)
            {
                output.Content.AppendHtml($"<li>{name}</li>");
            }
        }
    }
}
