using Northwind.DataAccess.Abstract;
using Nortwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DataAccess.Concrete.EntityFramework.NHibernate
{
    public class NhCategoryDal : ICategoryDal
    {
        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            List<Category> categories = new List<Category>
            {
                new Category
                {
                    CategoryId=2,
                    CategoryName="Chai"
                   
                }
            };
            return categories;
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
