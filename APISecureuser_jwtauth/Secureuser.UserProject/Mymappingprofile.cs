using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Secureuser.Models.ViewModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System;
using Secureuser.DataAccess.DBModels;

namespace Secureuser.UserProject
{
    public class Mymappingprofile : Profile
    {
        public Mymappingprofile() {

            CreateMap<User, UserCreatedto>().ReverseMap();
            }
        }
    }







         