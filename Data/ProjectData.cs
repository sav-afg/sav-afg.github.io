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
                ImagePath8 = "/Images/Projects/Service-Booking-Platform/LogIn.png",
                ImagePath1Alt = "Home page showing service listings and search functionality",
                ImagePath2Alt = "A page where you can view your bookings, make changes to them, and make a new booking.",
                ImagePath3Alt = "A form to create a new booking, with date and time pickers and validation messages.",
                ImagePath4Alt = "Admin dashboard showing user management and booking overview features.",
                ImagePath5Alt = "Log in form with fields for email and password, and validation messages.",
                ImagePath6Alt = "Seq logging dashboard showing structured logs from the application.",
                ImagePath7Alt = "Error message displayed when trying to create a booking that conflicts with an existing one.",
                ImagePath8Alt = "Log in page with form and error message for invalid credentials.",
                ImagePath1Title = "Home Page",
                ImagePath2Title = "Bookings Page",
                ImagePath3Title = "Create Booking Form",
                ImagePath4Title = "Admin Dashboard",
                ImagePath5Title = "Log In Form",
                ImagePath6Title = "Structured Logging with Seq",
                ImagePath7Title = "Booking Conflict Detection",
                ImagePath8Title = "Log In Validation",
                HasWalkthrough = true
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
                ImagePath9 = "/Images/Projects/Fitness-Saviour/UIPersonalisation.png",
                ImagePath1Alt = "Home page showing welcome message and navigation options",
                ImagePath2Alt = "A graph showing the user's weight and calorie intake over time.",
                ImagePath3Alt = "A questionnaire form asking about the user's workout preferences and goals.",
                ImagePath4Alt = "Results page showing the recommended workout split based on the user's questionnaire responses.",
                ImagePath5Alt = "Exercise logging page with a search bar to find exercises and log sets, reps, and weight.",
                ImagePath6Alt = "Graphs page showing various progress visualisations based on the user's logged data.",
                ImagePath7Alt = "A pie chart showing the recommended macronutrient composition for the user's diet.",
                ImagePath8Alt = "Summary statistics page showing key metrics about the user's progress and adherence to recommendations.",
                ImagePath9Alt = "A personalised UI theme based on the user's preferences",
                ImagePath1Title = "Home Page",
                ImagePath2Title = "Progress Graph",
                ImagePath3Title = "Workout Split Questionnaire",
                ImagePath4Title = "Workout Split Results",
                ImagePath5Title = "Exercise Logging",
                ImagePath6Title = "Progress Visualisations",
                ImagePath7Title = "Macronutrient Composition",
                ImagePath8Title = "Summary Statistics",
                ImagePath9Title = "Personalised UI Theme",
                HasWalkthrough = true

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
                Feature4 = "Applied event-driven programming principles and secure configuration practices",
                HasWalkthrough = false
            }
        ];
    }

    public static Project? GetProjectById(int id)
    {
        return GetProjects().FirstOrDefault(p => p.Id == id);
    }
}
