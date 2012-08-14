using System;
using System.Collections.Generic;
using System.Linq;
using NIssues.Common.Domains;

namespace NIssues.Common.Repositories
{
	public interface IProjectRepository : IBaseRepository<Project>
	{
		IEnumerable<Project> GetProjects();

		IEnumerable<Project> GetChildProjects(Guid parentProjectID);
	}
}
