namespace GetDraftList.Models
{
    public record DbFileContent
    {
        public DraftList[] DraftLists { get;  set; }
    }
}