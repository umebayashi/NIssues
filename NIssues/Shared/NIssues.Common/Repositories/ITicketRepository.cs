using System;
using System.Collections.Generic;
using System.Linq;
using NIssues.Common.Domains;

namespace NIssues.Common.Repositories
{
	public interface ITicketRepository : IBaseRepository<Ticket>
	{
		IEnumerable<Ticket> GetTickets(Guid versionID);
	}
}
