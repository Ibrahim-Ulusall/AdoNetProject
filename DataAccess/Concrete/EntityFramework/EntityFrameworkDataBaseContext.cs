﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
	public class EntityFrameworkDataBaseContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database = ECommarce; Trusted_Connection=true");
		}

        public DbSet<Product> Products { get; set; }
    }
}
