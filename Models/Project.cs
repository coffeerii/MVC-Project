using Microsoft.AspNetCore.SignalR;

namespace MyPortfolio.Models
{
    public class Project 
    {
    public interface Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Technologies { get; set; }
    public string GithubUrl { get; set; }
    }
}