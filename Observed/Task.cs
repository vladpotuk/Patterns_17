using System;

public class Task : ITaskAssignable
{
    public int TaskId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Status { get; set; }
    public int Priority { get; set; }
    public string AssignedTo { get; set; }
    public string Project { get; set; }
    public string AssignedBy { get; set; }
    public DateTime AssignedDate { get; set; }
    
}
