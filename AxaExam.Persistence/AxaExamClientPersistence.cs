using AxaExam.Domain.Entities;
using System;

namespace AxaExam.Persistence
{
	public class AxaExamClientPersistence
	{
		public Client Create(Client model)
		{
			if (model == null)
			{
				throw new NullReferenceException();
			}
			using (var context = new AxaExamClientContext())
			{
				var clientCreated = context.Clients.Add(model);
				context.SaveChanges();
				return clientCreated;
			}
		}
	}
}
