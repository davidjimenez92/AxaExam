using AxaExam.Domain.Entities;
using System.Data.Entity;

namespace AxaExam.Persistence
{
	class AxaExamPoliciesContext: DbContext
	{
		public DbSet<Policies> Policies { get; set; }

		public AxaExamPoliciesContext() : base("")
		{
		}
	}
}
