public class ToDoItem
{
    public int Id { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }

    public ToDoItem(int id, string description)
    {
        Id = id;
        Description = description;
        IsCompleted = false;
    }

    public override string ToString()
    {
        return $"{Id}.{Description} - {(IsCompleted ? "Completed" : "Not Completed")}";
    }
}