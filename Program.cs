using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        TaskManager<Task> taskManager = new TaskManager<Task>();

        
        Task task1 = new Task { TaskId = 1, Title = "Task 1", Description = "Description of Task 1", Status = "In Progress", Priority = 1, AssignedTo = "user1", Project = "Project A", AssignedBy = "user2", AssignedDate = DateTime.Now };
        Task task2 = new Task { TaskId = 2, Title = "Task 2", Description = "Description of Task 2", Status = "Open", Priority = 2, AssignedTo = "user2", Project = "Project B", AssignedBy = "user1", AssignedDate = DateTime.Now };
        taskManager.AddItem(task1);
        taskManager.AddItem(task2);

        
        Console.WriteLine("Tasks:");
        foreach (var task in taskManager.GetItems())
        {
            Console.WriteLine($"Title: {task.Title}, AssignedTo: {task.AssignedTo}, Project: {task.Project}");
        }

      
        TaskManager<User> userManager = new TaskManager<User>();
        User user1 = new User { UserId = 1, Username = "user1", Email = "user1@example.com", Role = "Developer" };
        User user2 = new User { UserId = 2, Username = "user2", Email = "user2@example.com", Role = "Manager" };
        userManager.AddItem(user1);
        userManager.AddItem(user2);

        
        Console.WriteLine("\nUsers:");
        foreach (var user in userManager.GetItems())
        {
            Console.WriteLine($"Username: {user.Username}, Email: {user.Email}, Role: {user.Role}");
        }

        Console.ReadLine();
    }
}
