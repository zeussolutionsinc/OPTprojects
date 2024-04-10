using System;
using System.Reflection.Metadata.Ecma335;

namespace Technician.Dispatch.Project.BL.Model
{
	public class UserSkills
	{
		public int UserId{ get; set; }
		public int SkillId { get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}

