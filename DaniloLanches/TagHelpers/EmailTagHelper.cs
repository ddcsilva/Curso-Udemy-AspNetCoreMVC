using Microsoft.AspNetCore.Razor.TagHelpers;

/// <summary>
/// Classe responsável por representar o tag helper de email
/// </summary>
namespace DaniloLanches.TagHelpers;

public class EmailTagHelper : TagHelper
{
    public string Endereco { get; set; }
    public string Conteudo { get; set; }

    /// <summary>
    /// Método responsável por processar o tag helper
    /// </summary>
    /// <param name="context"></param>
    /// <param name="output"></param>
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "a";
        var endereco = Endereco + Conteudo;
        output.Attributes.SetAttribute("href", "mailto:" + endereco);
        output.Content.SetContent(Conteudo);
    }
}