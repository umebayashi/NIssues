using System;
using System.Collections.Generic;
using System.Linq;
using NIssues.Common.Domains;

namespace NIssues.Common.Repositories
{
	public interface IUserRepository : IBaseRepository<User>
	{
		IEnumerable<User> GetUsers(Guid projectID);
	}
}
