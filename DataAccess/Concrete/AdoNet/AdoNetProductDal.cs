﻿using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.AdoNet
{
	public class AdoNetProductDal : IProductDal
	{
		private SqlConnection Connection()
		{
			SqlConnection connection = new SqlConnection(
				@"Server = (localdb)\mssqllocaldb;Database=ECommerce;Trusted_Connection=true;");
			if (connection.State == System.Data.ConnectionState.Closed)
				connection.Open();
			return connection;
		}
		public void Add(Product entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Product entity)
		{
			throw new NotImplementedException();
		}

		public Product Get(Expression<Func<Product, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
		{
			SqlCommand command = new SqlCommand("Select * from Products", Connection());
			SqlDataReader reader = command.ExecuteReader();
			List<Product> products = new List<Product>();
			while (reader.Read())
			{
				Product product = new Product
				{
					Id = (int)reader["Id"],
					ProductName = reader["ProductName"].ToString(),
					UnitInStock = Convert.ToInt32(reader["UnitInPrice"]),
					UnitInPrice = Convert.ToDecimal(reader["UnitInStock"])
				};
				products.Add(product);
			}
			return products;
		}

		public void Update(Product entity)
		{
			throw new NotImplementedException();
		}
	}
}