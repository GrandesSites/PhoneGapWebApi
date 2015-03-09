using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Domain.Models;
using WebApiRepository.Interfaces;

namespace WebApiRepository
{
    public class TB_LoginRepository:RepositoryBase<TB_Login>, ITB_Login
    {
    }
}