using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxaExam.Domain.Entities
{
	class Admin : Client
	{
		public override string Role => "Admin";
	}
}
