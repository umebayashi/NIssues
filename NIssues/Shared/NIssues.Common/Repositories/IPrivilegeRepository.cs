using System;
using System.Collections.Generic;
using System.Linq;
using NIssues.Common.Domains;

namespace NIssues.Common.Repositories
{
	public interface IPrivilegeRepository : IBaseRepository<Privilege>
	{
		IEnumerable<Privilege> GetAllPrivileges();

		IEnumerable<Privilege> GetRolePrivileges(Guid roleID);
	}
}
