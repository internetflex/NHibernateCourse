﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace NovCoure.Model
{
	public class MaintenanceJob
	{
		public virtual int Id { get; set; }

		public virtual Building Building { get; set; }
		public virtual DateTime At { get; set; }
		public virtual ICollection<Employee> By { get; set; }
		public virtual IDictionary<string,Employee> EmpsByWork { get; set; }
		public virtual dynamic Details { get; set; }
		public virtual IList<string> Parts { get; set; }
	}
}