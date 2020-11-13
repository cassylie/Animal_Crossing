using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalCrossing.Models
{
    public class Utilisateur
    {
        public int ID { get; set; }
        public string pseudo { get; set; }
        public string email { get; set; }
        public string mdp { get; set; }
        public string ile { get; set; }
        public string hemisphere { get; set; }
        public string fruit { get; set; }

    }
}