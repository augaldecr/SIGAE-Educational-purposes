namespace SIGAE.Web.Helpers
{
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Microsoft.AspNetCore.Razor.TagHelpers;

    [HtmlTargetElement("gira-tag-helper")]
    public class GiraTagHelper : TagHelper
    {
        [HtmlAttributeName("for-id")]
        public ModelExpression Id { get; set; }
        [HtmlAttributeName("for-fecha")]
        public ModelExpression Fecha { get; set; }
        [HtmlAttributeName("for-localidad")]
        public ModelExpression Localidad { get; set; }
        [HtmlAttributeName("for-usuario")]
        public ModelExpression Usuario { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "GiraTagHelper";
            output.TagMode = TagMode.StartTagAndEndTag;

            string tag = $"<tr><th class='hide'>{this.Id}</th><th scope='row'>{this.Usuario}</th><th>{this.Fecha}</th>";

            output.PreContent.SetHtmlContent(tag);
        }
    }
}
