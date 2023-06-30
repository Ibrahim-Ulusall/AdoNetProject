using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
	public interface IEntityCrudRepository<TEntity> where TEntity: class , IEntity, new()
	{

	}
}
