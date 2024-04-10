using System;
using System.Reflection.Metadata.Ecma335;

namespace Technician.Dispatch.Project.BL.Model
{
	public class WorkOrderExpenses
	{
		public int ExpenseId{ get; set; }
		public int WorkOrderId { get; set; }
		public int Amount { get; set; }
		public string Description { get; set; }
	}
}

