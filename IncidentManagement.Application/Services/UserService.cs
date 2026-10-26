using IncidentManagement.Application.Dtos.Requests;
using IncidentManagement.Application.Dtos.Responses;
using IncidentManagement.Application.Helpers;
using IncidentManagement.Application.Service_Interfaces;
using IncidentManagement.Application.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace IncidentManagement.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<UserResponse> CreateUserAsync(CreateUserRequest request)
        {
            var user = DtoMapper.MapToEntity(request);
            await _unitOfWork.Users.AddAsync(user);
            await _unitOfWork.CompleteAsync();
            return DtoMapper.MapToResponse(user);
        }

        public Task<IEnumerable<UserResponse>> GetAllUserAsync()
        {
            throw new NotImplementedException();
        }

        public Task<UserResponse> UpdateUserStatusAsync(UpdateUserStatusRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
