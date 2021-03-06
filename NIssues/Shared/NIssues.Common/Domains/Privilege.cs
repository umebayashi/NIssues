﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace NIssues.Common.Domains
{
	[Table("Privileges")]
	public class Privilege : DomainObject
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
