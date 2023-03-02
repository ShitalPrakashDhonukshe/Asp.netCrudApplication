namespace CurdApplication.Models
{
    public class Pager
    {
        public int totalItems { get; private set; }
        public int CurrentPage { get; private set; }
        public int PageSize { get; private set; }

        public int TotalPages { get; private set; }
        public int StartPage { get; private set;}
        public int EndPage { get; private set; }

        public Pager()
        {
            
        }
        public Pager(int TotalItems, int Page,int pagesize=10)
        {
            int totalPages = (int)Math.Ceiling((decimal)TotalItems / (decimal)PageSize);
            int currentPage = Page;
            if (StartPage <= 0)
            {
                EndPage = EndPage - (StartPage - 1);
                StartPage = 1;
            }

            totalItems = totalItems;
            CurrentPage = CurrentPage;
            PageSize = PageSize;
            TotalPages = totalPages;
            StartPage = StartPage;
            EndPage = EndPage;
        }

    }
}
