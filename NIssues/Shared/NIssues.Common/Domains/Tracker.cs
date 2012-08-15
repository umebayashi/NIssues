using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace NIssues.Common.Domains
{
	[Table("Trackers")]
	public class Tracker : DomainObject
	{
		#region field

		[Column("ID", TypeName = "uniqueidentifier")]
		[Key]
		public Guid ID { get; set; }

		[Column("ProjectID", TypeName = "uniqueidentier")]
		[ForeignKey("Project")]
		public Guid ProjectID { get; set; }

		[Column("Name", TypeName = "nvarchar")]
		public string Name { get; set; }

		[Column("Description", TypeName = "nvarchar")]
		public string Description { get; set; }

		#endregion

		#region relation

		public virtual Project Project { get; set; }

		#endregion
	}
}
