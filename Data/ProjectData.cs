using Portfolio.Models;
using Portfolio.Pages;
using static System.Net.Mime.MediaTypeNames;

namespace Portfolio.Data;

public static class ProjectData
{
    public static List<Project> GetProjects()
    {
        return
        [
            new() {
                Id = 1,
                Title = "Service Booking Platform",
                Description = "A full-stack service booking and management platform built as a multi-project .NET 10 solution.",
                Technologies = ".NET 10, ASP.NET Core, Blazor WebAssembly, SQL Server, C#",
                GitHubUrl = "https://github.com/sav-afg/ServiceBookingandManagementPlatform",
                LiveUrl = "",
                Feature1 = "Implemented claims-based authorisation to enforce user ownership and role-specific access (Customer, Staff, Admin).",
                Feature2 = "Developed 92 unit and integration tests covering authentication, booking rules, refresh token rotation, and API endpoints",
                Feature3 = "Built booking conflict detection logic to prevent overlapping reservations using time-range validation.",
                Feature4 = "Structured the API using Controller–Service–DTO separation, enforcing clean architecture and testability.",
                ImagePath4 = "/Images/Projects/Service-Booking-Platform/AdminDashboard.png",
                ImagePath2 = "/Images/Projects/Service-Booking-Platform/BookingPage.png",
                ImagePath3 = "/Images/Projects/Service-Booking-Platform/CreateBooking.png",
                ImagePath1 = "/Images/Projects/Service-Booking-Platform/HomePage.png",
                ImagePath5 = "/Images/Projects/Service-Booking-Platform/LogInForm.png",
                ImagePath6 = "/Images/Projects/Service-Booking-Platform/SeqLogging.png",
                ImagePath7 = "/Images/Projects/Service-Booking-Platform/BookingConflict.png",
                ImagePath8 = "/Images/Projects/Service-Booking-Platform/LogIn.png"
            },
            new() {
                Id = 2,
                Title = "Fitness Saviour",
                Description = "A full-stack fitness and nutrition web application",
                Technologies = ".NET 10, Blazor, C#, HTML, CSS, SQL Server",
                GitHubUrl = "https://github.com/sav-afg/Fitness-Saviour",
                LiveUrl = "",
                Feature1 = "Implemented a questionnaire-driven scoring system to generate personalised diet and exercise recommendations based on user input.",
                Feature2 = "Designed and normalised the relational database schema and integrated it using EF Core for persistent progress tracking.",
                Feature3 = "Built a component-based Blazor UI with dynamic state updates and interactive data visualisations to display user progress over time.",
                Feature4 = "Owned the project end-to-end, including requirements analysis, system design, implementation, testing, and full technical documentation.",
                ImagePath4 = "/Images/Projects/Fitness-Saviour/WorkoutSplitResults.png",
                ImagePath2 = "/Images/Projects/Fitness-Saviour/Graph.png",
                ImagePath3 = "/Images/Projects/Fitness-Saviour/WorkoutSplitQuestionnaire.png",
                ImagePath1 = "/Images/Projects/Fitness-Saviour/HomePage.png",
                ImagePath5 = "/Images/Projects/Fitness-Saviour/ExerciseLoggingSearchBar.png",
                ImagePath6 = "/Images/Projects/Fitness-Saviour/GraphsPage.png",
                ImagePath7 = "/Images/Projects/Fitness-Saviour/MacroComposition.png",
                ImagePath8 = "/Images/Projects/Fitness-Saviour/SummaryStatistics.png",
                ImagePath9 = "/Images/Projects/Fitness-Saviour/UIPersonalisation.png"

            },
            new() {
                Id = 3,
                Title = "Discord Moderation & Interaction Bot",
                Description = "A real-time Discord bot designed for community interaction and server moderation.",
                Technologies = ".NET 10, Discord.NET API, C#",
                ImagePath1 = "/Images/Projects/Discord-Bot/Response.png",
                ImagePath2 = "/Images/Projects/Discord-Bot/SlashCommands.png",
                GitHubUrl = "https://github.com/sav-afg/PawzDiscordBot",
                LiveUrl = "",
                Feature1 = "Implemented modern slash commands for structured user interaction",
                Feature2 = "Developed context-aware message handling based on user input and intent",
                Feature3 = "Generated detailed moderation alerts to assist server administrators",
                Feature4 = "Applied event-driven programming principles and secure configuration practices"
            }
        ];
    }

    public static Project? GetProjectById(int id)
    {
        return GetProjects().FirstOrDefault(p => p.Id == id);
    }
}
