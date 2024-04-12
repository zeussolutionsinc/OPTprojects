using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Technician.Dispatch.Project.DAL.Entities
{
    public class User
    {
        
        public Guid UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailId { get; set; }
        public int HourlyRate { get; set; }

        public UserStatus Status { get; set; }
        public RowStatus RowStatus { get; set; }

        [ForeignKey("CreatedUser")]
        public Guid CreatedBy { get; set; }
        public User CreatedUser { get; set; }
        public DateTime CreatedTime { get; set; }

        [ForeignKey("UpdatedUser")]
        public Guid UpdatedBy { get; set; }
        public User UpdatedUser { get; set; }
        public DateTime UpdatedTime { get; set; }

        [ForeignKey("Supervisor")]
        public Guid SuperVisorID { get; set; }
        public User Supervisor { get; set; }


    }
}


