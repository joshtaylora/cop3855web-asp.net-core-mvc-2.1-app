using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cop3855web.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int TotalPages => (int)Math.Ceiling(decimal.Divide(TotalItems, ItemsPerPage));
    }
}
