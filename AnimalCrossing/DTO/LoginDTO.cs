using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalCrossing.DTO
{
    public class LoginDTO
    {
        public int id_user { get; set; }
        public string email { get; set; }
        public string pseudo { get; set; }
        public string ile { get; set; }
        public string fruit { get; set; }
        public string hemisphere { get; set; }
        public string statut { get; set; }
    }
}