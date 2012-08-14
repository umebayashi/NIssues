﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace NIssues.Common.Domains
{
	public class Privilege : DomainObject
	{
		#region field

		public Guid ID { get; set; }

		public string Name { get; set; }

		#endregion
	}
}
