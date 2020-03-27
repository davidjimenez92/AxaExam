using AxaExam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxaExam.Persistence
{
	public class AxaExamClientContext: DbContext
	{
		public DbSet<Client> Clients { get; set; }

		public AxaExamClientContext() : base("")
		{
		}
	}
}
