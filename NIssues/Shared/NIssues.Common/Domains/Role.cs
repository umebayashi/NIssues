using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NIssues.Common.Domains
{
	public class Role
	{
		#region field

		public Guid ID { get; set; }

		public string Name { get; set; }

		#endregion

		#region relation

		public virtual ICollection<Privilege> Privileges { get; set; }

		#endregion
	}
}
