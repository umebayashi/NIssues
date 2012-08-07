using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NIssues.Common.Domains
{
	public class Ticket
	{
		#region field

		public Guid ID { get; set; }

		public string Name { get; set; }

		public Guid TrackerID { get; set; }

		public Guid? StatusID { get; set; }

		public Guid? PriorityID { get; set; }

		public Guid? CategoryID { get; set; }

		#endregion

		#region relation

		public virtual Tracker Tracker { get; set; }

		public virtual TicketStatus Status { get; set; }

		public virtual TicketPriority Priority { get; set; }

		public virtual TicketCategory Category { get; set; }

		#endregion

		#region method

		#endregion
	}
}
