using System;
namespace Technician.Dispatch.Project.DAL.Entities
{
	public class WorkOrder
	{
        public int WorkOrderId { get; set; }
        public string Description { get; set; }
        public DateTime DateAssigned{ get; set; }
        public DateTime DateCompleted { get; set; }
        public WorkOrderStatus WorkOrderStatus{ get; set; }
        public int HoursWorked { get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime UpdatedTime { get; set; }
        

        public User UserID { get; set; }
    }
}

