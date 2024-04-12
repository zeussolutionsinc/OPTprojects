using System;
namespace Technician.Dispatch.Project.DAL.Entities
{
	public class Skill
	{
		public string Name{ get; set; }
		public Guid SkillId{ get; set; }
        public string CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime UpdatedTime { get; set; }
        public RowStatus RowStatus { get; set; }


    }
}

