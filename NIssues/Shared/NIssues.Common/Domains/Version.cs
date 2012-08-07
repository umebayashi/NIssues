using System;
using System.Collections.Generic;
using System.Linq;

namespace NIssues.Common.Domains
{
	public class Version
	{
		#region field / property

		public Guid ID { get; set; }

		public Guid ProjectID { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public Guid? StatusID { get; set; }

		public DateTime? DueDate { get; set; }

		#endregion

		#region relation

		public virtual Project Project { get; set; }

		public virtual VersionStatus Status { get; set; }

		#endregion

		#region method

		#endregion
	}
}
