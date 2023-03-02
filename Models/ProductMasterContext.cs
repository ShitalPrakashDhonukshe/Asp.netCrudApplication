using Microsoft.EntityFrameworkCore;

namespace CurdApplication.Models
{
    public class ProductMasterContext : DbContext
    {
        public ProductMasterContext(DbContextOptions<ProductMasterContext> options):base(options)
        {
            
        }
         public DbSet<ProductModel> tbl_ProductModel { get; set; }
        public DbSet<CategoryMaster> tbl_CategoryMaster { get;set; }
            
    }
}
