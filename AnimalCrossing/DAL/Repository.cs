using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AnimalCrossing.DTO;
using AnimalCrossing.Interface;


namespace AnimalCrossing.DAL
{
    public class Repository : IRepository
    {
        private SchoolContext db = new SchoolContext();

        public LoginDTO Authentifier(string email, string password)
        {
            var logg = (from r in db.Utilisateurs
                        where r.email == email && r.mdp == password
                        select new LoginDTO
                        {
                            email = r.email,
                            pseudo=r.pseudo,
                            id_user = r.ID,
                        }).FirstOrDefault();
            return logg;
        }
    }
}