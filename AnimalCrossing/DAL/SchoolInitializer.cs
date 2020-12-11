using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AnimalCrossing.Models;

namespace AnimalCrossing.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<SchoolContext>
    {
        protected override void Seed(SchoolContext context)
        {
            var students = new List<Student>
            {
            new Student{nomhabitant="Laura",espece="Ourson",personnalite="Arrogante",genre="Féminin"},
            new Student{nomhabitant="Raymond",espece="Chat",personnalite="Chic",genre="Masculin"},
            new Student{nomhabitant="Capri",espece="Chèvre",personnalite="Nature",genre="Masculin"},
            new Student{nomhabitant="Monica",espece="Loup",personnalite="Vive",genre="Féminin"},
            new Student{nomhabitant="Viviane",espece="Loup",personnalite="Arrogante",genre="Féminin"},
            new Student{nomhabitant="Lico",espece="Cheval",personnalite="Chic",genre="Masculin"},
            new Student{nomhabitant="Mistigri",espece="Chat",personnalite="Normale",genre="Féminin"},
            new Student{nomhabitant="Pansy",espece="Cochon",personnalite="Grande soeur",genre="Féminin"},
           /* new Student{nomhabitant="Robert",espece="Chat",personnalite="¨Paresseux",genre="Masculin"},
            new Student{nomhabitant="Bibi",espece="Biche",personnalite="Normale",genre="Féminin"},
            new Student{nomhabitant="Curt",espece="Ours",personnalite="Versatile",genre="Masculin"},
            new Student{nomhabitant="Dalma",espece="Chien",personnalite="Arrogante",genre="Féminin"},
            new Student{nomhabitant="Dolph",espece="Tigre",personnalite="Sportif",genre="Masculin"},
            new Student{nomhabitant="Rosalie",espece="Ourson",personnalite="Vive",genre="Féminin"},
            new Student{nomhabitant="Gary",espece="Loup",personnalite="Chic",genre="Masculin"},
            new Student{nomhabitant="Gustave",espece="Gorille",personnalite="Paresseux",genre="Masculin"}*/

            };

           var utilisateur = new List<Utilisateur>
            {
             new Utilisateur{pseudo="Cassylie",email="cassandra.laubry@moderateur.be",mdp="condorcet",ile="Paradise",hemisphere="Nord",fruit="poire"},
             new Utilisateur{pseudo="Huwa1105",email="hugo.walem@moderateur.be",mdp="1230",ile="Paradise",hemisphere="Nord",fruit="peche"},
            };
            utilisateur.ForEach(s => context.Utilisateurs.Add(s));
            context.SaveChanges();
        }
    }
}