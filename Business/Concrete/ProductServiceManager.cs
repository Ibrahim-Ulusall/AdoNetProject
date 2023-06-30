using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
	public class ProductServiceManager:IProductService
	{
		IProductDal _productDal;
        public ProductServiceManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

		public IResult Add(Product product)
		{
			_productDal.Add(product);
			return new SuccessResult("Product Added");
		}

		public IDataResult<List<Product>> GetAll()
		{
			return new SuccessDataResult<List<Product>>(_productDal.GetAll());
		}
	}
}
