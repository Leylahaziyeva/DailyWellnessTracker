using WellnessTracker.Domain.Entities;
using WellnessTracker.Infrastructure.EfCore.DataContext;

namespace WellnessTracker.UI;
internal class Program
{
    static void Main(string[] args)
    {
        using var db = new WellnessDbContext();

        var userName = "Leyla Haziyeva";
        var user = db.Users.FirstOrDefault(u => u.UserName == userName);

        if (user == null)
        {
            user = new User
            {
                UserName = userName,
                RegisteredDate = DateTime.Now
            };
            db.Users.Add(user);
            db.SaveChanges();
        }

        var today = DateTime.Today;
        var entry = db.WellnessEntries.FirstOrDefault(e => e.UserId == user.Id && e.Date == today);

        if (entry == null)
        {
            entry = new WellnessEntry
            {
                Date = today,
                UserId = user.Id,
                Details = new WellnessDetails
                {
                    Mood = "Happy",
                    SleepHours = 8,
                    Activities = new List<string> { "Jogging", "Meditation" },
                    Notes = "Felt great after a morning run."
                }
            };
            db.WellnessEntries.Add(entry);
            db.SaveChanges();
            Console.WriteLine("New entry added.");
        }

        var update = db.WellnessEntries.FirstOrDefault(e => e.UserId == user.Id && e.Date == today);

        if (update != null)
        {
            update.Details.Mood = "Tired";
            update.Details.SleepHours = 6;
            update.Details.Activities = new List<string> { "Work", "Short Walk" };
            update.Details.Notes = "Felt tired after long work hours.";

            db.SaveChanges();
            Console.WriteLine("Entry updated successfully.");
        }

        var delete = db.WellnessEntries.FirstOrDefault(e => e.UserId == user.Id && e.Date == today);

        if (delete != null)
        {
            db.WellnessEntries.Remove(delete);
            db.SaveChanges();
            Console.WriteLine("Entry deleted successfully.");
        }
    }
}