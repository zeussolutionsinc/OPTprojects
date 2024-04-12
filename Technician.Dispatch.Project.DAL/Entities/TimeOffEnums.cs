using System;
namespace Technician.Dispatch.Project.DAL.Entities
{
	public enum TimeOffType
	{
		VacationLeave,
		SickLeave,
		PersonalLeave,
		ParentalLeave
	}

	public enum TimeOffStatus
	{
		Approved,
		Pending,
		Rejected,
	}
}

