using System;
using Microsoft.EntityFrameworkCore;

namespace Technician.Dispatch.Project.DAL.Entities
{
	public class CompanyContext : DbContext
	{
		public CompanyContext(DbContextOptions options) : base(options)
		{
			
		}
        //public DbSet<Role> Roles { get; set; }
        //public DbSet<Skill> Skills { get; set; }
        //public DbSet<TimeOff> TimeOffs { get; set; }
        public DbSet<User> Users { get; set; }
        //public DbSet<UserRole> UserRoles { get; set; }
        //public DbSet<UserSkill> UserSkills { get; set; }
        //public DbSet<WorkOrderExpense> WorkOrderExpenses { get; set; }
        //public DbSet<WorkOrderPayment> WorkOrderPayments { get; set; }
        //public DbSet<WorkOrder> WorkOrders { get; set; }
    }
}

