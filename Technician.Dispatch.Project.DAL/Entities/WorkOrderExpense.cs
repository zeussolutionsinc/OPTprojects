using System;
using System.Reflection.Metadata.Ecma335;

namespace Technician.Dispatch.Project.DAL.Entities
{
	public class WorkOrderExpense
	{
		public int ExpenseId { get; set; }
		public int Amount { get; set; }
		public string Description { get; set; }
        public RowStatus RowStatus { get; set; }

        public WorkOrder WorkOrderId { get; set; }
    }
}

