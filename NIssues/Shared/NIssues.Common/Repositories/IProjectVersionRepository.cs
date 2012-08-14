using System;
using System.Collections.Generic;
using System.Linq;
using NIssues.Common.Domains;

namespace NIssues.Common.Repositories
{
	public interface IProjectVersionRepository : IBaseRepository<ProjectVersion>
	{
		IEnumerable<ProjectVersion> GetVersions(Guid projectID);
	}
}
