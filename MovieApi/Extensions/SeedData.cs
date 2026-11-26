using Microsoft.EntityFrameworkCore;
using MovieApi.Models; // using Models to gain access to everything Movie[] needs
namespace MovieApi.Extensions
{
    public static class SeedData
    {
        public static void Seed(this MovieApiContext context)
        {
            // Check if there already are movies seeded
            if (context.Movies.Any())
            {
                return;
            }

            // Populate the Movies-list with movies. A movie needs: Title, Year, Genre, Duration. Then it needs additional MovieDetails, info about the Actor, and Reviews
            var movies = new Movie[]
            {
                new Movie
                {
                    Title = "Iron Man",
                    Year = 2008,
                    Genre = "Action/Sci-Fi",
                    Duration = 126,
                    MovieDetails = new MovieDetails
                    {
                        Synopsis = "När industrimannen och miljardären Tony Stark kidnappas och tvingas bygga vapen åt fienden konstruerar han en robotiserad järnrustning som han använder för att fly. I rustningen blir han Iron man och börjar bekämpa ondska i världen.",
                        Language = "Engelska",
                        Budget = 150000000
                    },
                    Actors = new Actor[]
                    {
                        new Actor
                        {
                            Name = "Robert Downey Jr.",
                            BirthYear = 1965
                        },
                        new Actor
                        {
                            Name = "Gwyneth Paltrow",
                            BirthYear = 1972
                        },
                        new Actor
                        {
                            Name = "Jon Favreau",
                            BirthYear = 1966
                        }
                    }.ToList(),
                    Reviews = new Review[]
                    {
                        new Review
                        {
                            ReviewerName = "Anders Andersson",
                            Comment = "Mycket bra",
                            Rating = 4
                        },
                        new Review
                        {
                            ReviewerName = "Berit Beritsson",
                            Comment = "Fint startskott på MCU",
                            Rating = 5
                        },
                        new Review
                        {
                            ReviewerName = "Zinedine Zidane",
                            Comment = "Oui oui",
                            Rating = 4
                        }
                    }.ToList()
                },
                new Movie
                {
                    Title = "Sagan Om Ringen: Härskarringen",
                    Year = 2001,
                    Genre = "Action Epic",
                    Duration = 178,
                    MovieDetails = new MovieDetails
                    {
                        Synopsis = "Hoben Frodo Bagger ärver en magisk ring från sin farbror Bilbo, men ringen visar sig vara den mäktiga Härskarringen, ett föremål som kan ge dess onde skapare Sauron kraften att återta sin makt och förslava Midgårds fria folk.",
                        Language = "Engelska",
                        Budget = 93000000
                    },
                    Actors = new Actor[]
            {
                new Actor
                {
                    Name = "Elijah Wood",
                    BirthYear = 1981
                },
                new Actor
                {
                    Name = "Sir Ian McKellen",
                    BirthYear = 1939
                },
                new Actor
                {
                    Name = "Orlando Bloom",
                    BirthYear = 1977
                }
            }.ToList(),
                    Reviews = new Review[]
            {
                new Review
                {
                    ReviewerName = "Godric Gryffindor",
                    Comment = "Splendid film",
                    Rating = 5
                },
                new Review
                {
                    ReviewerName = "Rowena Ravenclaw",
                    Comment = "Not my cup of tea",
                    Rating = 2
                },
                new Review
                {
                    ReviewerName = "Will Turner",
                    Comment = "Legolas is my favourite character",
                    Rating = 5
                }
            }.ToList()
                }

            };

            context.Movies.AddRange(movies); //add the movies to the Movies table, along with corresponding information to the related tables
            context.SaveChanges(); // Save the information stored in the tables
        }
    }
}
