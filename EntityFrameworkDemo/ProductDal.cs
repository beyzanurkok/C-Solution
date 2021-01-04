using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.ToList();
            }
        }
        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())
            {
                // bu işlemi veri tabanında yapmak daha hızlı sonuç verir.
                return context.Products.Where(p=>p.Name.Contains(key)).ToList(); 
                                                                                
            }
        }

        public Product GetById(int id)
        {
            using (ETradeContext context = new ETradeContext())
            {
                // FirstOrDefault listede belirtilen nesne varsa ilkini döndürür.Yoksa null döndürür.
                var result = context.Products.FirstOrDefault(p => p.Id == id);

                // SingleOrDefault listede belirtilen nesne varsa bir kere varsa onu döndürür,birden fazla nesne bulursa hata verir.Yoksa null döndürür.
                //var result = context.Products.SingleOrDefault(p => p.Id == id);

                return result;

            }
        }

        public List<Product> GetByUnitPrice(decimal min ,decimal max)
        {
            // Min max parametreleri arasında bulunan unitprice a sahip ürünleri döndürür.
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <= max).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal price)
        {
            // Min max parametreleri arasında bulunan unitprice a sahip ürünleri döndürür.
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= price).ToList();
            }
        }

        public void Add(Product product)
        {
            using(ETradeContext context = new ETradeContext())
            {
                // context.Products.Add(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }

}
