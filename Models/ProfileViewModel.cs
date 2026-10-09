namespace PortfolioApp.Models;

// The whole page 
public class ProfileViewModel
{
    public string FullName { get; set; } = "";
    public AboutModel About { get; set; } = new();
    public ContactModel Contact { get; set; } = new();
}

// Small helper used by _Photo.cshtml (shows an image or a grey placeholder)
public record PhotoModel(string Path, string Css, string Alt);
