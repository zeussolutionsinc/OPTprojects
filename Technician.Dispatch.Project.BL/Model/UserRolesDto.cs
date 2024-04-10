using System;
namespace Technician.Dispatch.Project.BL.Model
{
	public class UserRolesDto
	{
		public int UserId { get; set; }
		public int RoleId { get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}

