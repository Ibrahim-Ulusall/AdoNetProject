using Business.Abstract;
using Business.Contants;
using Business.Validation;
using Core.CrossCuttingConcerns.Validation;
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
			ValidationTool.Validate(new ProductValidator(), product);
			
			_productDal.Add(product);
			return new SuccessResult(Messages.Added);
		}

		public IResult Delete(Product product)
		{
			_productDal.Delete(product);
			return new SuccessResult(Messages.Deleted);
		}

		public IDataResult<List<Product>> GetAll()
		{
			return new SuccessDataResult<List<Product>>(_productDal.GetAll());
		}

		public IResult Update(Product product)
		{
			_productDal.Update(product);
			return new SuccessResult(Messages.Updated);
		}
	}
}
