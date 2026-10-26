using IncidentManagement.Application.Dtos.Requests;
using IncidentManagement.Application.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentManagement.Application.Service_Interfaces
{
    public interface IUserService
    {
        Task<UserResponse> CreateUserAsync(CreateUserRequest request);
        Task<IEnumerable<UserResponse>> GetAllUserAsync();
        Task<UserResponse> UpdateUserStatusAsync(UpdateUserStatusRequest request);
    }
}
