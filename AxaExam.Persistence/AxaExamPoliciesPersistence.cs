using AxaExam.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxaExam.Persistence
{
	class AxaExamPoliciesPersistence
	{
		public Policies Create(Policies model)
		{
			if (model == null)
			{
				throw new NullReferenceException();
			}
			using (var context = new AxaExamPoliciesContext())
			{
				var policieCreated = context.Policies.Add(model);
				context.SaveChanges();
				return policieCreated;
			}
		}
	}
}
