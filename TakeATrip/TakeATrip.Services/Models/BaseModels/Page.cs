using System;
using System.Collections.Generic;
using System.Text;

namespace TakeATrip.Services.Models.BaseModels
{
    public class Page<T>
    {
        /// <summary>
        /// Gets or sets the zero-based page index.
        /// </summary>
        public int PageIndex { get; set; }

        /// <summary>
        /// Gets or sets the number of items in the page.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the total number of items.
        /// </summary>
        public int TotalCount { get; set; }

        /// <summary>
        /// Gets or sets the name of the item's property used to sort items.
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the order of items is ascending.
        /// </summary>
        public bool IsOrderAscending { get; set; }

        /// <summary>
        /// Gets or sets the text used to filter the query result.
        /// </summary>
        public string SearchText { get; set; }

        /// <summary>
        /// Gets or sets the items of this page.
        /// </summary>
        public T[] Items { get; set; }
    }
}
