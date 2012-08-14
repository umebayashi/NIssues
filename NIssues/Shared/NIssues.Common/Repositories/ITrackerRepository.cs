using System;
using System.Collections.Generic;
using System.Linq;
using NIssues.Common.Domains;

namespace NIssues.Common.Repositories
{
	public interface ITrackerRepository : IBaseRepository<Tracker>
	{
		IEnumerable<Tracker> GetTrackers(Guid projectID);
	}
}
