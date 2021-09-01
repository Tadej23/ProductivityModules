using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataModel
{
    

    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new DataModelContext())
            {
                // Create and save a new Person
                Console.Write("Enter a name for a new Person: ");
                var name = Console.ReadLine();

                var person = new Person { PersonID = 1 };
                db.Person.Add(person);
                db.SaveChanges();

                // Display all Blogs from the database
                var query = from b in db.Person
                            orderby b.Name
                            select b;

                Console.WriteLine("All persons in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }

    public class DataModelContext : DbContext
    {
        //public const string ConnectionString = "SERVER=1


        public DbSet<Person> Person { get; set; }
        /* public DbSet<ArtWorks> ArtWorks { get; set; }
        public DbSet<Citations> Citations { get; set; }
        public DbSet<CitationSources> CitationSources { get; set; }
        public DbSet<PatentAuthor> PatentAuthor { get; set; }
        public DbSet<Patents> Patents { get; set; }
        
        public DbSet<PersonProfession> PersonProfession { get; set; }
        public DbSet<PersonProfiles> PersonProfiles { get; set; }
        public DbSet<ProfessionCategory> ProfessionCategory { get; set; }
        public DbSet<Profiles> Profiles { get; set; }
        public DbSet<ProjectPerson> ProjectPerson { get; set; }
        public DbSet<ProjectType> ProjectType { get; set; }
        public DbSet<PublicationAuthor> PublicationAuthor { get; set; }
        public DbSet<Publications> Publications { get; set; }
        public DbSet<SameWork> SameWork { get; set; }
        public DbSet<Projects> Projects { get; set; }*/


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=ResearchDB;Trusted_Connection=True;");
            //Data Source=DESKTOP-EBQTRNL\SQLEXPRESS;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        }


    }


}
