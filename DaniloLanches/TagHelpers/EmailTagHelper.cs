using Microsoft.AspNetCore.Razor.TagHelpers;

namespace DaniloLanches.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string Endereco { get; set; }
        public string Conteudo { get; set; }
        
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            var endereco = Endereco + Conteudo;
            output.Attributes.SetAttribute("href", "mailto:" + endereco);
            output.Content.SetContent(Conteudo);
        }
    }
}