using System;
using System.Collections.Generic;
using System.Text;

namespace TakeATrip.Services.Models.BaseModels
{
    public abstract class GetPageQuery
    {
        /// <summary>
        /// Gets or sets the page index. Page index begins from zero.
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// Gets or sets the number of items in the page.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the text used to filter the query result.
        /// Search text should be <c>null</c> or empty if the query
        /// doesn't need filtering.
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or sets the name of the item's property used to sort items.
        /// </summary>
        public string OrderBy { get; set; }
    }
}
