using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AnimalCrossing.DTO;

namespace AnimalCrossing.Interface
{
    public interface IRepository
    {
        LoginDTO Authentifier(string email, string password);
    }
}