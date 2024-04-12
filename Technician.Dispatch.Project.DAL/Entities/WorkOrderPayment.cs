using System;
namespace Technician.Dispatch.Project.DAL.Entities
{
	public class WorkOrderPayment
	{
        public int PaymentId { get; set; }
        public PaymentTypes PaymentTypes{ get; set; }
        public int AmountCollected { get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime UpdatedTime { get; set; }

        public WorkOrder WorkOrderId { get; set; }
        public RowStatus RowStatus { get; set; }
    }
}

