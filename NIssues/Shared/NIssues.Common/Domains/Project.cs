using System;
using System.Collections.Generic;
using System.Linq;

namespace NIssues.Common.Domains
{
	public class Project
	{
		#region field

		public Guid ID { get; set; }

		public string Name { get; set; }

		public string Description { get; set; }

		public Guid? ParentID { get; set; }

		#endregion

		#region relation

		public virtual Project Parent { get; set; }

		public virtual ICollection<Role> Roles { get; set; }

		public virtual ICollection<User> Users { get; set; }

		public virtual ICollection<Tracker> Trackers { get; set; }

		public virtual ICollection<Version> Versions { get; set; }

		#endregion

		#region method

		#endregion
	}
}
