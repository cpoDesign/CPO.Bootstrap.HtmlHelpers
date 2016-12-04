
using System.Web.Mvc;

namespace Bootstrap.HtmlHelpers
{
    public static class ButtonsExtensions
    {
        // ButtonType.Button, "Primary", Btn.Primary
        public static MvcHtmlString BootstrapButton(this HtmlHelper helper, ButtonType buttonType, string title, string btnClass)
        {
            var btn = new TagBuilder("button");
            btn.AddCssClass(btnClass);
            btn.Attributes.Add("type", buttonType.ToString().ToLower());
            btn.SetInnerText(title);
            return new MvcHtmlString(btn.ToString(TagRenderMode.Normal));
        }
    }

}

//    public class ContainerSection : IDisposableB
//    {
//        protected HtmlHelper _helper;

//        public ContainerSection(HtmlHelper helper, string title)
//        {
//            _helper = helper;
//            _helper.ViewContext.Writer.Write("<div class=\"row\">");
//            _helper.ViewContext.Writer.Write("<div class=\"col-lg-12\">");
//            _helper.ViewContext.Writer.Write("<div class=\"hpanel\">");
//            _helper.ViewContext.Writer.Write("<div class=\"panel-heading\">");
//            _helper.ViewContext.Writer.Write("<div class=\"panel-tools\">");
//            _helper.ViewContext.Writer.Write("<a class=\"showhide\"><i class=\"fa fa-chevron-up\"></i></a>");
//            _helper.ViewContext.Writer.Write("<a class=\"closebox\"><i class=\"fa fa-times\"></i></a>");
//            _helper.ViewContext.Writer.Write("</div>");
//            _helper.ViewContext.Writer.Write(title);
//            _helper.ViewContext.Writer.Write("</div>");
//            _helper.ViewContext.Writer.Write("<div class=\"panel-body\">");
//        }

//        public void Dispose()
//        {
//            _helper.ViewContext.Writer.Write("</div></div></div></div>");
//        }
//    }

//    public static class CustomDisposableHelpers
//    {
//        public static ContainerSection ContainerPanel(this HtmlHelper self, string title)
//        {
//            return new ContainerSection(self, title);
//        }
//    }
//}

//    public static class HeadersExtensions
//    {
//        public static MvcHtmlString SectionHeader(this HtmlHelper helper, string title)
//        {
//            var builder = new StringBuilder();
//            builder.Append(@"<div class=""normalheader transition animated fadeIn"">
//            <div class=""hpanel"" >
//                <div class=""panel-body"" >
//                    <h2 class=""font-light m-b-xs"">" + title + @"</h2>
//                </div>
//            </div>
//        </div>");
//            return new MvcHtmlString(builder.ToString());
//        }
//        public static MvcHtmlString SectionHeader(this HtmlHelper helper, string title, string description)
//        {
//            var builder = new StringBuilder();
//            builder.Append(@"<div class=""normalheader transition animated fadeIn"">
//            <div class=""hpanel"" >
//                <div class=""panel-body"" >
//                    <h2 class=""font-light m-b-xs"">" + title + @"</h2>
//                    <small>" + description + @"</small>
//                </div>
//            </div>
//        </div>");
//            return new MvcHtmlString(builder.ToString());
//        }

//        public static MvcHtmlString SectionHeaderWithCustomHtml(this HtmlHelper helper, string title, string rightHtml)
//        {
//            var builder = new StringBuilder();
//            builder.Append(@"<div class=""normalheader transition animated fadeIn"">
//            <div class=""hpanel"" >
//                <div class=""panel-body"" >
//                    <div class=""pull-right"">" + rightHtml + @"</div>
//                    <h2 class=""font-light m-b-xs"">" + title + @"</h2>
//                </div>
//            </div>
//        </div>");
//            return new MvcHtmlString(builder.ToString());
//        }

//        public static MvcHtmlString SectionHeaderWithLink(this HtmlHelper helper, string title, string link, string linkText)
//        {
//            var builder = new StringBuilder();
//            builder.Append(@"<div class=""normalheader transition animated fadeIn"">
//            <div class=""hpanel"" >
//                <div class=""panel-body"" >
//                    <div class=""pull-right"">" + string.Format("<a href=\"{0}\">{1}</a>", link, linkText) + @"</div>
//                    <h2 class=""font-light m-b-xs"">" + title + @"</h2>
//                </div>
//            </div>
//        </div>");
//            return new MvcHtmlString(builder.ToString());
//        }
//        public static MvcHtmlString SectionHeaderWithLink(this HtmlHelper helper, string title, string description, string link, string linkText)
//        {
//            var builder = new StringBuilder();
//            builder.Append(@"<div class=""normalheader transition animated fadeIn"">
//            <div class=""hpanel"" >
//                <div class=""panel-body"" >
//                    <div class=""pull-right"">" + string.Format("<a href=\"{0}\">{1}</a>", link, linkText) + @"</div>
//                    <h2 class=""font-light m-b-xs"">" + title + @"</h2>
//                    <small>" + description + @"</small>
//                </div>
//            </div>
//        </div>");
//            return new MvcHtmlString(builder.ToString());
//        }
//    }
