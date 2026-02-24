namespace Portfolio.Models;

public class Project
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Technologies { get; set; } = string.Empty;
    public string ImagePath1 { get; set; } = string.Empty;
    public string ImagePath2 { get; set; } = string.Empty;
    public string? ImagePath3 { get; set; }
    public string? ImagePath4 { get; set; }
    public string? ImagePath5 { get; set; }
    public string? ImagePath6 { get; set; }
    public string? ImagePath7 { get; set; }
    public string? ImagePath8 { get; set; }
    public string? ImagePath9 { get; set; }
    public string? ImagePath1Alt { get; set; }
    public string? ImagePath2Alt { get; set; }
    public string? ImagePath3Alt { get; set; }
    public string? ImagePath4Alt { get; set; }
    public string? ImagePath5Alt { get; set; }
    public string? ImagePath6Alt { get; set; }
    public string? ImagePath7Alt { get; set; }
    public string? ImagePath8Alt { get; set; }
    public string? ImagePath9Alt { get; set; }
    public string? ImagePath1Title { get; set; }
    public string? ImagePath2Title { get; set; }
    public string? ImagePath3Title { get; set; }
    public string? ImagePath4Title { get; set; }
    public string? ImagePath5Title { get; set; }
    public string? ImagePath6Title { get; set; }
    public string? ImagePath7Title { get; set; }
    public string? ImagePath8Title { get; set; }
    public string? ImagePath9Title { get; set; }
    public string GitHubUrl { get; set; } = string.Empty;
    public string LiveUrl { get; set; } = string.Empty;
    public string Feature1 { get; set; } = string.Empty;
    public string Feature2 { get; set; } = string.Empty;
    public string Feature3 { get; set; } = string.Empty;
    public string Feature4 { get; set; } = string.Empty;
    public bool HasWalkthrough { get; set; }
}
