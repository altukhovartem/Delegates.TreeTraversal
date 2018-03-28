using System;
using System.Collections.Generic;
using System.Linq;
using Delegates.TreeTraversal;
using NUnitLite;

class Program
{
	static void Main(string[] args)
	{
		var data = new Job
		{
			Name = "4",
			Subjobs = new List<Job>
				  {
					  new Job
					  {
						  Name="3"
					  },
					  new Job
					  {
						  Name="A",
						  Subjobs=new List<Job>
						  {
							  new Job
							  {
								  Name="1"
							  },
							  new Job
							  {
								  Name="2"
							  }
						  }

					  }
				  }
		};

		var x = Traversal.GetEndJobs(data);

		//new AutoRun().Execute(args);
	}
}
