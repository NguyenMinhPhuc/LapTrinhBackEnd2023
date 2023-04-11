using Models.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAO
{
    public class ProductDao : IDisposable
    {
       
       //Khai báo đối tượng DbContext
       ShopOnlineDbContext context;
       public void Dispose()
       {
           if (context != null)
           {
               context.Dispose();
               context = null;
           }
       }
       //Hàm tạo (Contructor)
       public ProductDao()
       {
           context = new ShopOnlineDbContext();
       }

        //lấy data product
       public List<Product> GetProducts()
       {
           return context.Database.SqlQuery<Product>("PSP_Product_Select").ToList();
       }
       public Product GetProductByID(int id)
       {
           SqlParameter[] sqlParameter = new SqlParameter[]{
                new SqlParameter("@ID", id)
           };
           return context.Database.SqlQuery<Product>("PSP_Product_SelectByID @ID", sqlParameter).SingleOrDefault();
       }
        //them product
        //sua product
        //xoa product
    }
}
