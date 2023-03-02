using CurdApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace CurdApplication.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductMasterContext _Db;


        public ProductController(ProductMasterContext Db)
        {
            _Db = Db;
        }

        [HttpPost]
        public ActionResult Index(int currentPageIndex)
        {
            return View(this.GetProducts(currentPageIndex));
        }

        private ProductModel GetProducts(int currentPage)
        {
            int maxRows = 10;
            
            {
                ProductModel productModel = new ProductModel();
                {
                    productModel.Products = (from Product in entities.Product
                                             join CategoryMaster in entities.Catergorey
                                             on Product.ProductID equals CategoryMaster.ProductId
                                             select new Product

                                             {
                                                 ProductId = CategoryMaster.ProductId,
                                                 CategoryName = Product.ProductName,
                                                 CategoryId = CategoryMaster.CategoryId,

                                             })
                    .OrderBy(x => x.ProductId)
                    .Skip((currentPage - 1) * maxRows)
                    .Take(maxRows).ToList();

                    double pageCount = (double)((decimal)entities.ProductModel.Count() / Convert.ToDecimal(maxRows));
                    productModel.PageCount = (int)Math.Ceiling(pageCount);

                    productModel.CurrentPageIndex = currentPage;

                    return productModel;


                }
            }
        }
    }
}

  