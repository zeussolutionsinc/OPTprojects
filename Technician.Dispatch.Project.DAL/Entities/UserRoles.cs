using System;
namespace Technician.Dispatch.Project.DAL.Entities
{
	public class UserRole
	{
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime UpdatedTime { get; set; }
        public RowStatus RowStatus { get; set; }

        public User UserID{ get; set;}
        public ICollection<Role> RoleIDs { get; set; }
    }
}

