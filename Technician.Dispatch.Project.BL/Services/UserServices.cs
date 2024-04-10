using System;
using Technician.Dispatch.Project.BL.Interfaces;
using Technician.Dispatch.Project.BL.Model;

namespace Technician.Dispatch.Project.BL.Services
{
	public class UserServices : IUser
    {
		public UserServices()
		{
		}

        public async Task<List<UserDto>> GetAllUsers()
        {
            return new List<UserDto>();
        }
    }
}

