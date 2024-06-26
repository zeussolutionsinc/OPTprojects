﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Technician.Dispatch.Project.DAL.Entities
{
	public class UserSkill
	{
        public RowStatus RowStatus { get; set; }

        [ForeignKey("CreatedUser")]
        public Guid CreatedBy { get; set; }
        public User CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }

        [ForeignKey("UpdatedUser")]
        public Guid UpdatedBy { get; set; }
        public User UpdatedUser { get; set; }
        public DateTime UpdatedTime { get; set; }

        public User UserID { get; set; }
        public Skill SkillId { get; set; }
    }
}

