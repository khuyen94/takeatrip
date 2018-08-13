using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakeATrip.Web.HtmlExtensions
{
    public static class OrderNavPages
    {
        public static string YourCart => "YourCart";

        public static string Payment => "Payment";

        public static string Finish => "Finish";

        public static string YourCartNavClass(ViewContext viewContext) => PageNavClass(viewContext, YourCart);

        public static string PaymentNavClass(ViewContext viewContext) => PageNavClass(viewContext, Payment);

        public static string FinishNavClass(ViewContext viewContext) => PageNavClass(viewContext, Finish);

        public static string PageNavClass(ViewContext viewContext, string page)
        {
            var activePage = viewContext.ViewData["ActivePage"] as string;
            return string.Equals(activePage, page, StringComparison.OrdinalIgnoreCase) ? "active" : "disabled";
        }        
    }
}
