using System;
namespace Technician.Dispatch.Project.BL.Model
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

