using System.ComponentModel.DataAnnotations;

namespace Fullstack.Data.Models;

public class BlogPost
{
    public int Id { get; set; }
    
    [MaxLength(256)]
    public string Title { get; set; } = "";
    
    [MaxLength(256)]
    public string Content { get; set; } = "";
    
    public DateTime Created { get; set; }
    
    public DateTime Edited { get; set; }
}