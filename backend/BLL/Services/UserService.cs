using AutoMapper;
using BLL.DTOs;
using BLL.Interfaces;
using DAL.Models;
using DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Registration(UserDTO item)
        {
            var mapper = new MapperConfiguration(conf => conf.CreateMap<UserDTO, User>()).CreateMapper();

            User user = mapper.Map<UserDTO, User>(item);
            _unitOfWork.Users.Create(user);
            _unitOfWork.Save();
        }

        public void Autorization(UserDTO item)
        {
            
        }

        
    }
}
