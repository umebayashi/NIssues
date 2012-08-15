using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using NIssues.Common.Repositories;

namespace NIssues.Common.Domains
{
	[Table("Roles")]
	public class Role : DomainObject
	{
		#region field

		[Column("ID", TypeName = "uniqueidentifier")]
		[Key]
		public Guid ID { get; set; }

		[Column("ProjectID", TypeName = "uniqueidentifier")]
		[ForeignKey("Project")]
		public Guid ProjectID { get; set; }

		[Column("Name", TypeName = "nvarchar")]
		public string Name { get; set; }

		[Column("Description", TypeName = "nvarchar")]
		public string Description { get; set; }

		#endregion

		#region repository

		public IPrivilegeRepository PrivilegeRepository { get; set; }

		#endregion

		#region relation

		public virtual Project Project { get; set; }

		public IEnumerable<Privilege> GetPrivileges()
		{
			return this.PrivilegeRepository.GetRolePrivileges(this.ID);
		}

		#endregion
	}
}
