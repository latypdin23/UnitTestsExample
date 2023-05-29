namespace TaskManager.Model
{
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Status() { }
        public Status(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
