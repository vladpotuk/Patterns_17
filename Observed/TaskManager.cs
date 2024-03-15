using System;
using System.Collections.Generic;

public class TaskManager
{
    private List<Task> tasks = new List<Task>();
    private List<User> users = new List<User>();
    private List<Project> projects = new List<Project>();

    public List<Task> GetTasks()
    {
        return tasks;
    }

    public List<User> GetUsers()
    {
        return users;
    }

    public List<Project> GetProjects()
    {
        return projects;
    }

    public void AddTask(Task task)
    {
        tasks.Add(task);
    }

    public void AddUser(User user)
    {
        users.Add(user);
    }

    public void AddProject(Project project)
    {
        projects.Add(project);
    }
}
