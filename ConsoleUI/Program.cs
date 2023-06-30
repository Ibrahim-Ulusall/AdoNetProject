using Business.Concrete;
using DataAccess.Concrete.AdoNet;

internal class Program
{
	private static void Main(string[] args)
	{
		ProductServiceManager serviceManager = new ProductServiceManager(new AdoNetProductDal());

		foreach (var item in serviceManager.GetAll().Data)
		{
			Console.WriteLine(item.ProductName);
		}
	}
}