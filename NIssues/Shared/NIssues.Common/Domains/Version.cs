using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace NIssues.Common.Domains
{
	[Table("Version")]
	public class Version
	{
		#region field / property

		[Column("ID", TypeName = "uniqueidentifier")]
		public Guid ID { get; set; }

		[Column("ProjectID", TypeName = "uniqueidentifier")]
		[ForeignKey("Project")]
		public Guid ProjectID { get; set; }

		[Column("Name", TypeName = "nvarchar")]
		public string Name { get; set; }

		[Column("Description", TypeName = "nvarchar")]
		public string Description { get; set; }

		[Column("StatusID", TypeName = "uniqueidentifier")]
		[ForeignKey("Status")]
		public Guid? StatusID { get; set; }

		[Column("DueDate", TypeName = "datetime")]
		public DateTime? DueDate { get; set; }

		#endregion

		#region relation

		public virtual Project Project { get; set; }

		public virtual VersionStatus Status { get; set; }

		#endregion

		#region method

		public IEnumerable<Ticket> GetTickets()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
