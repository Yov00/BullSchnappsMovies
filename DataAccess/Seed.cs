using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace DataAccess
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            // if(context.Commands.Any()) {
            //     // var allComs = context.Commands.ToList();
            //     // context.Commands.RemoveRange(allComs);
            //     // await context.SaveChangesAsync();
            //     return;
            // }

            // var commands = new List<Command>
            // {
            //    new Command{ HowTo = "Boil an egg", Line="Boil water", Platform="Kattle & Pan" },
            //    new Command{ HowTo = "Cut bread", Line="Get a knife", Platform="Chopping board" },
            //    new Command{ HowTo = "Make cup of tea", Line="Place teabag in cup", Platform="Tea pot" },
            // };
            // await context.Commands.AddRangeAsync(commands);
            // await context.SaveChangesAsync();
        }
    }
}