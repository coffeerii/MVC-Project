namespace PortfolioApp.Models;

// Data for the ABOUT section (intro, education, skills, work experience, projects)
public class AboutModel
{
    public string IntroText { get; set; } = "";
    public string IntroImage { get; set; } = "";

    public List<Education> Educations { get; set; } = new();

    public string SkillsImage { get; set; } = "";
    public List<Skill> Skills { get; set; } = new();

    public List<Experience> Experiences { get; set; } = new();
    public List<string> ExperienceImages { get; set; } = new();

    public List<Project> Projects { get; set; } = new();
}

public class Education  { public string Year { get; set; } = ""; public string School  { get; set; } = ""; public string Description { get; set; } = ""; }
public class Skill      { public string Name { get; set; } = ""; public int Level { get; set; } = 80; }   // Level: 0-100
public class Experience { public string Year { get; set; } = ""; public string Company { get; set; } = ""; public string Description { get; set; } = ""; }
public class Project    { public string Year { get; set; } = ""; public string Name    { get; set; } = ""; public string Description { get; set; } = ""; public string Url { get; set; } = ""; }
