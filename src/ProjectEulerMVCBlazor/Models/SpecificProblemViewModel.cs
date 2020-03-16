namespace ProjectEulerMVCBlazor.Models
{
    public class SpecificProblemViewModel : DefaultViewModel
    {
        public string Header { get; set; }
        public string RequestedProblemName { get; set; }
        public string Answer { get; set; }
        public string TimeTaken { get; set; }
    }
}