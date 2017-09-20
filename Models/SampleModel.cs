using System.ComponentModel.DataAnnotations;

namespace multilang.Models
{
    public class SampleModel
    {
        [Display(Name = "Hello")]
        public string Content { get; set; }
    }
}