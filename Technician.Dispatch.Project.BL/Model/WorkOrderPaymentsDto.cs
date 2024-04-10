using System;
namespace Technician.Dispatch.Project.BL.Model
{
	public class WorkOrderPaymentsDto
	{
        public int WorkOrderId { get; set; }
        public int PaymentId { get; set; }
        public PaymentTypes PaymentTypes{ get; set; }
        public int AmountCollected { get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}

