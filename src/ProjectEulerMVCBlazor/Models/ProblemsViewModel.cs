using System.Collections.Generic;

namespace ProjectEulerMVCBlazor.Models
{
    public class ProblemsViewModel : DefaultViewModel
    {
        public IEnumerable<(string, string)> ProblemsLinks { get; set; }
    }
}