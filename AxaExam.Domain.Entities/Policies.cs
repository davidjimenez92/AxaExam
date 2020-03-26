using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AxaExam.Domain.Entities
{
	public class Policies
	{
		[Key]
		public Guid Id { get; set; }
		[Required]
		public double AmountInsured { get; set; }
		[Required]
		public DateTime InceptionDate { get; set; }
		[Required]
		public bool InstallmentPayment { get; set; }

		[ForeignKey("Client")]
		public Guid ClientRefId { get; set; }
		public virtual Client Client { get; set; }
	}
}
