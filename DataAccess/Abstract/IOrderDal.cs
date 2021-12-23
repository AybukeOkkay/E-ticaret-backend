using Core.DataAccess;
using Core.DateAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
	public interface IOrderDal:IEntityRepository<Order>
	{
	}
}
