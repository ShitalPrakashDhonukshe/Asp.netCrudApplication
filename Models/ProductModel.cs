namespace CurdApplication.Models
{

    public class ProductModel
    {
  
            public List<Product>? Products { get; set; }
            public int CurrentPageIndex { get; set; }
            public int PageCount { get; set; }

        }

    public class Product
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

        
    }

