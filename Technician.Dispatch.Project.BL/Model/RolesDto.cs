using System;
using System.Reflection.Metadata.Ecma335;

namespace Technician.Dispatch.Project.BL.Model
{
	public class RolesDto
	{
		public int RoleId { get; set; }
		public string Name { get; set; }
		public int BasePrice{ get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}

