using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TakeATrip.Web.HtmlExtensions
{
    public static class RazorExtensions
    {
        public static string ActivePageKey => "ActivePage";
        public static void AddActivePage(this ViewDataDictionary viewData, string activePage) => viewData[ActivePageKey] = activePage;
    }
}
