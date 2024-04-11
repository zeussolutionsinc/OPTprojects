using System;
namespace Technician.Dispatch.Project.BL.Model
{
	public class SkillsDto
	{
		public string Name{ get; set; }
		public int SkillId{ get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}

