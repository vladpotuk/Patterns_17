using System;

class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();

      
        User user1 = new User { UserId = 1, Username = "user1", Email = "user1@example.com", Role = "Developer" };
        User user2 = new User { UserId = 2, Username = "user2", Email = "user2@example.com", Role = "Manager" };
        taskManager.AddUser(user1);
        taskManager.AddUser(user2);

        Project project1 = new Project { ProjectId = 1, Name = "Project A", Description = "Description of Project A" };
        Project project2 = new Project { ProjectId = 2, Name = "Project B", Description = "Description of Project B" };
        taskManager.AddProject(project1);
        taskManager.AddProject(project2);

        Task task1 = new Task { TaskId = 1, Title = "Task 1", Description = "Description of Task 1", Status = "In Progress", Priority = 1, AssignedTo = "user1", Project = "Project A", AssignedBy = "user2", AssignedDate = DateTime.Now };
        Task task2 = new Task { TaskId = 2, Title = "Task 2", Description = "Description of Task 2", Status = "Open", Priority = 2, AssignedTo = "user2", Project = "Project B", AssignedBy = "user1", AssignedDate = DateTime.Now };
        taskManager.AddTask(task1);
        taskManager.AddTask(task2);

        
        Console.WriteLine("Tasks:");
        foreach (var task in taskManager.GetTasks())
        {
            Console.WriteLine($"Title: {task.Title}, AssignedTo: {task.AssignedTo}, Project: {task.Project}");
        }

        Console.WriteLine("\nUsers:");
        foreach (var user in taskManager.GetUsers())
        {
            Console.WriteLine($"Username: {user.Username}, Email: {user.Email}, Role: {user.Role}");
        }

        Console.WriteLine("\nProjects:");
        foreach (var project in taskManager.GetProjects())
        {
            Console.WriteLine($"Name: {project.Name}, Description: {project.Description}");
        }

        Console.ReadLine();
    }
}
