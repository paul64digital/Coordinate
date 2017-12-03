using System.Data.Entity;

namespace CoordinateDatabase.Contexts
{
    public class Context : DbContext
    {

        public Context() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=testingCoord;Integrated Security=True;MultipleActiveResultSets=True")
        {
            //Connect to testing when no value supplied
        }

        public Context(string connStr) : base(connStr)
        {
            Database.SetInitializer<Context>(new MigrateDatabaseToLatestVersion<Context, Migrations.Configuration>(true));

            ////Force an update
            //var dbMigrator = new System.Data.Entity.Migrations.DbMigrator(new Migrations.Configuration());
            //dbMigrator.Update();
        }

        public DbSet<Entities.Company> Companies { get; set; }
        public DbSet<Entities.Project> Projects { get; set; }
        public DbSet<Entities.ProjectType> ProjectTypes { get; set; }
        public DbSet<Entities.Requirement> Requirements { get; set; }
        public DbSet<Entities.RequirementType> RequirementTypes { get; set; }
        public DbSet<Entities.Resource> Resources { get; set; }
        public DbSet<Entities.Skill> Skills { get; set; }
        public DbSet<Entities.StoryPoint> StoryPoints { get; set; }
        public DbSet<Entities.Task> Tasks { get; set; }
        public DbSet<Entities.TaskStatus> TaskStatuses { get; set; }
        public DbSet<Entities.User> Users { get; set; }
        public DbSet<Entities.UserSkill> UserSkills { get; set; }

    }
}
