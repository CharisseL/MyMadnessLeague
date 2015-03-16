namespace MyMadnessLeague.Migrations
{
    using MyMadnessLeague.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyMadnessLeague.Models.MatchupsDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "MyMadnessLeague.Models.MatchupsDBContext";
        }

        protected override void Seed(MyMadnessLeague.Models.MatchupsDBContext context)
        {
            context.Matchups.AddOrUpdate(i => i.Team1,
                new MatchUp
                {
                    Team1 = "(1) Kentucky",
                    Team2 = "(16) Hampton",
                    UserSelection = "Kentucky"
                },

                 new MatchUp
                {
                    Team1 = "(8) Cincinnati",
                    Team2 = "(9) Purdue",
                    UserSelection = "Purdue"
                },

                 new MatchUp
                {
                    Team1 = "(5) West Virginia",
                    Team2 = "(12) Buffalo",
                    UserSelection = "West Virginia"
                },
                 new MatchUp
                {
                    Team1 = "(4) Maryland",
                    Team2 = "(13) Valparaiso",
                    UserSelection = "Maryland"
                },

                 new MatchUp
                {
                    Team1 = "(6) Butler",
                    Team2 = "(11) Texas",
                    UserSelection = "Texas"
                },

                 new MatchUp
                {
                    Team1 = "(3) Notre Dame",
                    Team2 = "(14) Northeastern",
                    UserSelection = "Notre Dame"
                },

                 new MatchUp
                {
                    Team1 = "(7) Wichita State",
                    Team2 = "(10) Indiana",
                    UserSelection = "Wichita State"
                },
                 new MatchUp
                {
                    Team1 = "(2) Kansas",
                    Team2 = "(15) New Mexico State",
                    UserSelection = "Kansas"
                }

               );
        
        }
    }
}
