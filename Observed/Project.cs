using System.Collections.Generic;

public class Project
{
    public int ProjectId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Task> Tasks { get; } = new List<Task>();
}
