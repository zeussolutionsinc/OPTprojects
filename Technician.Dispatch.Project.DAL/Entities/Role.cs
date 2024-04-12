using System;
using System.Reflection.Metadata.Ecma335;

namespace Technician.Dispatch.Project.DAL.Entities
{
	public class Role
	{
		public int RoleID { get; set; }
		public string Name { get; set; }
		public int BasePrice{ get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime UpdatedTime { get; set; }
        public RowStatus RowStatus { get; set; }
    }
}

