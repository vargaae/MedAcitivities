using System;
using Domain;

namespace Persistence;

public class DbInitalizer
{
    public static async Task SeedData(AppDbContext context)
    {
        if (context.Activities.Any()) return;

        var activities = new List<Activity>
        {
           new()
           {
               Title = "Első ortopédiai vizsgálat",
               Date = DateTime.Now.AddMonths(-2),
               Description = "Első szakorvosi vizsgálat jobb Achilles-ín fájdalom miatt.",
               Category = "Vizsgálat",
               City = "Budapest",
               Venue = "Semmelweis Egyetem Ortopédiai Klinika",
               Latitude = 47.488820,
               Longitude = 19.086320
           },
new()
{
    Title = "MR vizsgálat",
    Date = DateTime.Now.AddMonths(-1),
    Description = "Lumbális gerinc MR vizsgálat derékfájdalom kivizsgálására.",
    Category = "Képalkotó vizsgálat",
    City = "Budapest",
    Venue = "Affidea Diagnosztika",
    Latitude = 47.505000,
    Longitude = 19.070500
},
new()
{
    Title = "Gyógytorna állapotfelmérés",
    Date = DateTime.Now.AddMonths(1),
    Description = "Első gyógytorna konzultáció és mozgásszervi állapotfelmérés.",
    Category = "Gyógytorna",
    City = "Budapest",
    Venue = "Physio Praxis",
    Latitude = 47.513600,
    Longitude = 19.050100
},
new()
{
    Title = "Kontroll ortopédiai vizsgálat",
    Date = DateTime.Now.AddMonths(2),
    Description = "A kezelés eredményének kontrollvizsgálata.",
    Category = "Kontroll",
    City = "Budapest",
    Venue = "Ortopédiai Szakrendelő",
    Latitude = 47.510500,
    Longitude = 19.040700
},
new()
{
    Title = "Lökéshullám-terápia",
    Date = DateTime.Now.AddMonths(3),
    Description = "Krónikus Achilles-ín gyulladás kezelése lökéshullám-terápiával.",
    Category = "Kezelés",
    City = "Budapest",
    Venue = "Mozgásszervi Rehabilitációs Centrum",
    Latitude = 47.507900,
    Longitude = 19.048300
},
new()
{
    Title = "Laborvizsgálat",
    Date = DateTime.Now.AddMonths(4),
    Description = "Általános laborvizsgálat és gyulladásos paraméterek ellenőrzése.",
    Category = "Labor",
    City = "Budapest",
    Venue = "Synlab Diagnosztika",
    Latitude = 47.506800,
    Longitude = 19.060500
},
new()
{
    Title = "Reumatológiai szakvizsgálat",
    Date = DateTime.Now.AddMonths(5),
    Description = "Krónikus derékfájdalom kivizsgálása.",
    Category = "Vizsgálat",
    City = "Budapest",
    Venue = "ORFI",
    Latitude = 47.498900,
    Longitude = 19.067400
},
new()
{
    Title = "Kontroll gyógytorna",
    Date = DateTime.Now.AddMonths(6),
    Description = "Funkcionális állapot felmérése és gyakorlatok módosítása.",
    Category = "Gyógytorna",
    City = "Budapest",
    Venue = "Physio Praxis",
    Latitude = 47.513600,
    Longitude = 19.050100
},
new()
{
    Title = "Műtéti konzultáció",
    Date = DateTime.Now.AddMonths(7),
    Description = "Sebészeti konzultáció a további kezelési lehetőségekről.",
    Category = "Konzultáció",
    City = "Budapest",
    Venue = "Traumatológiai Centrum",
    Latitude = 47.492600,
    Longitude = 19.071000
},
new()
{
    Title = "Éves mozgásszervi kontroll",
    Date = DateTime.Now.AddMonths(8),
    Description = "Éves komplex ortopédiai és fizioterápiás kontrollvizsgálat.",
    Category = "Kontroll",
    City = "Budapest",
    Venue = "Semmelweis Egészségközpont",
    Latitude = 47.495900,
    Longitude = 19.084300
}
        };

        context.Activities.AddRange(activities);

        await context.SaveChangesAsync();
    }

}
