using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using NIssues.Common.Repositories;

namespace NIssues.Common.Domains
{
	[Table("Projects")]
	public class Project : DomainObject
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

		#region repository

		public IProjectRepository ProjectRepository { get; set; }

		public IRoleRepository RoleRepository { get; set; }

		public IUserRepository UserRepository { get; set; }

		public ITrackerRepository TrackerRepository { get; set; }

		public IProjectVersionRepository VersionRepository { get; set; }

		#endregion

		#region relation

		public virtual Project Parent { get; set; }

		public IEnumerable<Role> GetRoles()
		{
			return this.RoleRepository.GetRoles(this.ID);
		}

		public IEnumerable<User> GetUsers()
		{
			return this.UserRepository.GetUsers(this.ID);
		}

		public IEnumerable<Tracker> GetTrackers()
		{
			return this.TrackerRepository.GetTrackers(this.ID);
		}

		public IEnumerable<ProjectVersion> GetVersions()
		{
			return this.VersionRepository.GetVersions(this.ID);
		}

		public IEnumerable<Project> GetChildren()
		{
			return this.ProjectRepository.GetChildProjects(this.ID);
		}

		#endregion

		#region method

		#endregion
	}
}
