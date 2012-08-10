using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace NIssues.Common.Domains
{
	[Table("Project")]
	public class Project
	{
		#region field

		[Column("ID", TypeName = "uniqueidentifier")]
		[Key]
		public Guid ID { get; set; }

		[Column("Name", TypeName = "nvarchar")]
		public string Name { get; set; }

		[Column("Description", TypeName = "nvarchar")]
		public string Description { get; set; }

		[Column("ParentID", TypeName = "uniqueidentifier")]
		[ForeignKey("Parent")]
		public Guid? ParentID { get; set; }

		#endregion

		#region relation

		public virtual Project Parent { get; set; }

		public IEnumerable<Role> GetRoles()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<User> GetUsers()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Tracker> GetTrackers()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Version> GetVersions()
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Project> GetChildren()
		{
			throw new NotImplementedException();
		}

		#endregion

		#region method

		#endregion
	}
}
