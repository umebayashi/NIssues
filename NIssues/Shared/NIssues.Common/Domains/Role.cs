using System;
using System.Collections.Generic;
using System.Linq;
using NIssues.Common.Repositories;

namespace NIssues.Common.Domains
{
	public class Role : DomainObject
	{
		#region field

		public Guid ID { get; set; }

		public string Name { get; set; }

		#endregion

		#region repository

		public IPrivilegeRepository PrivilegeRepository { get; set; }

		#endregion

		#region relation

		public IEnumerable<Privilege> GetPrivileges()
		{
			return this.PrivilegeRepository.GetRolePrivileges(this.ID);
		}

		#endregion
	}
}
