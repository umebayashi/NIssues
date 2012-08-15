using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace NIssues.Common.Domains
{
	[Table("Tickets")]
	public class Ticket : DomainObject
	{
		#region field

		[Column("ID", TypeName = "uniqueidentifier")]
		[Key]
		public Guid ID { get; set; }

		[Column("Name", TypeName = "nvarchar")]
		public string Name { get; set; }

		[Column("Description", TypeName = "nvarchar")]
		public string Description { get; set; }

		[Column("TrackerID", TypeName = "uniqueidentifier")]
		[ForeignKey("Tracker")]
		public Guid TrackerID { get; set; }

		[Column("StatusID", TypeName = "uniqueidentifier")]
		[ForeignKey("Status")]
		public Guid? StatusID { get; set; }

		[Column("PriorityID", TypeName = "uniqueidentifier")]
		[ForeignKey("Priority")]
		public Guid? PriorityID { get; set; }

		[Column("InChargeUserID", TypeName = "uniqueidentifier")]
		[ForeignKey("InChargeUser")]
		public Guid? InChargeUserID { get; set; }

		[Column("CategoryID", TypeName = "uniqueidentifier")]
		[ForeignKey("Category")]
		public Guid? CategoryID { get; set; }

		[Column("TargetVersionID", TypeName = "uniqueidentifier")]
		[ForeignKey("TargetVersion")]
		public Guid? TargetVersionID { get; set; }

		[Column("ParentID", TypeName = "uniqueidentifier")]
		[ForeignKey("Parent")]
		public Guid? ParentID { get; set; }

		[Column("StartDate", TypeName = "datetime")]
		public DateTime? StartDate { get; set; }

		[Column("DueDate", TypeName = "datetime")]
		public DateTime? DueDate { get; set; }

		[Column("EstimatedHours", TypeName = "decimal")]
		public decimal? EstimatedHours { get; set; }

		[Column("Progress", TypeName = "decimal")]
		public decimal? Progress { get; set; }

		#endregion

		#region relation

		public virtual Tracker Tracker { get; set; }

		public virtual TicketStatus Status { get; set; }

		public virtual TicketPriority Priority { get; set; }

		public virtual User InChageUser { get; set; }

		public virtual TicketCategory Category { get; set; }

		public virtual ProjectVersion TargetVersion { get; set; }

		public virtual Ticket Parent { get; set; }

		#endregion

		#region method

		#endregion
	}
}
