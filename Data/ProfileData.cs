using PortfolioApp.Models;

namespace PortfolioApp.Data;

public static class ProfileData
{
    public static ProfileViewModel Get() => new()
    {
        FullName = "Alexandra Geane M. Remolacio",
        About    = GetAbout(),
        Contact  = GetContact(),
    };
   
    //  ABOUT
    private static AboutModel GetAbout() => new()
    {
        IntroText  = "I'm Alexandra Geane M. Remolacio, a 3rd Year Computer Science Student in Polytechnic University of the Philippines",
        IntroImage = "/images/aboutme.jpg", 

        Educations = new()
        {
            new() { Year = "2024-Present", School = "Polytechnic University of the Philippines",      Description = "Bachelor of Science in Computer Science" },
            new() { Year = "2022-2024", School = "Ramon Magsaysay (Cubao) High School",    Description = "Science, Technology, Engineering, Mathematics (STEM)"},
            new() { Year = "2018-2022", School = "Don Alejandro Roces Sr. Science Technology High School", Description = "3 year course of Computer System Servicing" },
        },

        SkillsImage = "/images/skills.jpg",
        Skills = new()
        {
            new() { Name = "Languages: C, Java, Python, TypeScript, SQL, HTML/CSS ",               Level = 90 },
            new() { Name = "Database/Deployment: Firebase Firestore, MySQL, Supabase, Vercel",       Level = 75 },
            new() { Name = "DevOps: Git, GitHub",       Level = 80 },
            new() { Name = "Tools: Cisco Packet Tracer, Visual Studio Code, Firebase Studio",       Level = 80 },
        },

        Experiences = new()
        {
            new() { Year = "2025-Present", Company = "PUP Association of Students for Computer Intelligence Integration",      Description = "Member of PUP ASCII, mostly created review materials for study sessions " },
            new() { Year = "2025", Company = "SPARKFEST GDG PUP Hackathon", Description = "Created the documentation and integrated features" },
            new() { Year = "2024-2025", Company = "Amazon Web Service Department of Cloud Computing and Infrastructure in PUP", Description = "Member of AWSCCI." },
        },
        ExperienceImages = new() { "/images/exp.jpg", "/images/exp1.jpg" },

        Projects = new()
        {
            new() { Year = "2025", Name = "Sintang Iskolar Database", Description = "A scholarship database web application for organizing and managing scholar information", Url = "https://sintang-iskolar-database.vercel.app/" },
            new() { Year = "2025", Name = "Ligtas Larga",    Description = "A crowdsourced navigation platform that focuses on issues and hazards", Url = "https://ligtas-larga.vercel.app/" },
            new() { Year = "2024", Name = "Orthonormal Basis Finder",    Description = "A Gram-Schmidt calculator that provides an orthonormal basis if inputs are linearly independent", Url = "https://group-2-orthonormal-basis-finder-linear.onrender.com/" },
        },
    };

    
    //  CONTACT
    private static ContactModel GetContact() => new()
    {
        Text        = "I'm open to new opportunities. Contact me through this platforms and I'll get back to you soon.",
        Image       = "/images/contact.jpg",  
        Email       = "gnlxndrmlc@gmail.com",
        GitHub      = "https://github.com/gnlxndr",
        LinkedIn    = "https://www.linkedin.com/in/geane-remolacio/",
        Phone       = "+63 969 320 1666",
    };
}
