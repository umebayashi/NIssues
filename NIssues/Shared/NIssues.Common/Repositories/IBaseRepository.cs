using System;
using System.Collections.Generic;
using System.Linq;
using NIssues.Common.Domains;

namespace NIssues.Common.Repositories
{
	public interface IBaseRepository<T> where T : DomainObject
	{
		void UpdateObject(T domainObject);
	}
}
