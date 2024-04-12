using System;
namespace Technician.Dispatch.Project.DAL.Entities
{
	public class TimeOff
	{
		public int UserId{ get; set; }
		public TimeOffType TimeOffType{ get; set; }
		public TimeOffStatus TimeOffStatus{ get; set; }
		public int RequestId { get; set; }
		public DateTime StartDate{ get; set; }
        public DateTime EndDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime UpdatedTime { get; set; }
        public RowStatus RowStatus { get; set; }
    }
}

