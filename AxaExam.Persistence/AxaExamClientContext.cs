using AxaExam.Domain.Entities;
using System.Data.Entity;

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
