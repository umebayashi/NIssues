using System;
using System.Collections.Generic;
using System.Linq;
using NIssues.Common.Domains;

namespace NIssues.Common.Repositories
{
	public interface IRoleRepository : IBaseRepository<Role>
	{
		IEnumerable<Role> GetRoles(Guid projectID);
	}
}
