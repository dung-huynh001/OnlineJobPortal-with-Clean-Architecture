using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineJobPortal.Application.Responses
{
    public class PaginatedResult<T> where T : class
    {
        public IList<T> Items { get; set; }
        public Nullable<int> PageNumber { get; set; }
        public Nullable<int> PageSize { get; set; }
        public Nullable<int> TotalCount { get; set; }
        public Nullable<int> TotalPages { get; set; }

        public PaginatedResult() { }

        private PaginatedResult(IList<T> items, int pageNumber, int pageSize, int totalCount, int totalPages)
        {
            Items = items;
            PageNumber = pageNumber;
            PageSize = pageSize;
            TotalCount = totalCount;
            TotalPages = totalPages;
        }

        public static PaginatedResult<T> Create(IList<T> items, int pageNumber,
            int pageSize, int totalCount, int totalPage)
        {
            return new PaginatedResult<T>(items, pageNumber, pageSize, totalCount, totalPage);
        }
    }
}