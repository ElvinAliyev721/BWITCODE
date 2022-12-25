namespace BWITCODE.ViewModels
{
    public class WorkListViewModel
    {
        public string WorkTitle { get; set; }
        public List<string> WorkList { get; set; }
        public byte[] WorkIcon { get; set; }
        public int WorkCount { get; set; }
    }
}