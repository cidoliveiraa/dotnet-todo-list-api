namespace dotnet_todo_list_api.Models
{
  public class TodoListDatabaseSettings: ITodoListDatabaseSettings
  {
    public string TasksCollectionName { get; set; }
    public string ConnectionString { get; set; }
    public string DatabaseName { get; set; }
  }
  
  public interface ITodoListDatabaseSettings
  {
    string TasksCollectionName { get; set; }
    string ConnectionString { get; set; }
    string DatabaseName { get; set; }
  }
}