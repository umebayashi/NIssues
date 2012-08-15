using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using NIssues.Common.Repositories;

namespace NIssues.Common.Domains
{
	[Table("Users")]
	public class User : DomainObject
	{
		#region field
		
		[Column("ID", TypeName = "uniqueidentifier")]
		[Key]
		public Guid ID { get; set; }

		[Column("Name", TypeName = "nvarchar")]
		public string Name { get; set; }

		[Column("Description", TypeName = "nvarchar")]
		public string Description { get; set; }

		#endregion
	}
}
