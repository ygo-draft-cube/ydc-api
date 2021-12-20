namespace DraftList.Models
{
    public record DraftList
    {
        public string Id { get; set; }
        public string[] List { get; set; }
    }
}