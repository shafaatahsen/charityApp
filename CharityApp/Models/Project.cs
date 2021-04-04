namespace CharityApp.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TargetAmount { get; set; }
        public int CurrentAmount { get; set; }
        public bool Finished { get; set; }
    }
}