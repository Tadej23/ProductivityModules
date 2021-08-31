
using Microsoft.EntityFrameworkCore;

namespace DataModel
{
    public class Program : DbContext
    {
       
        
        public DbSet<ArtWorkAuthor> ArtWorkAuthor { get; set; }
        public DbSet<ArtWorks> ArtWorks { get; set; }
        public DbSet<Citations> Citations{ get; set; }
        public DbSet<CitationSources> CitationSources { get; set; }
        public DbSet<PatentAuthor> PatentAuthor { get; set; }
        public DbSet<Patents> Patents { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<PersonProfession> PersonProfession { get; set; }
        public DbSet<PersonProfiles> PersonProfiles { get; set; }
        public DbSet<ProfessionCategory> ProfessionCategory { get; set; }
        public DbSet<Profiles> Profiles { get; set; }
        public DbSet<ProjectPerson> ProjectPerson { get; set; }
        public DbSet<ProjectType> ProjectType { get; set; }
        public DbSet<PublicationAuthor> PublicationAuthor { get; set; }
        public DbSet<Publications> Publications { get; set; }
        public DbSet<SameWork> SameWork { get; set; }
        public DbSet<Projects> ArtWorkAuthor { get; set; }



    }
}
