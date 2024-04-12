using System;
namespace Technician.Dispatch.Project.BL.Model
{
	public class User
	{
		public Guid UserID{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public int HourlyRate { get; set; }
    }
}

