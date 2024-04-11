using System;
namespace Technician.Dispatch.Project.BL.Model
{
	public class WorkOrdersDto
	{
        public int WorkOrderId { get; set; }
        public string Description { get; set; }
        public int UserId{ get; set; }
        public DateTime DateAssigned{ get; set; }
        public DateTime DateCompleted { get; set; }
        public WorkOrderStatus WorkOrderStatus{ get; set; }
        public int HoursWorked { get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}

