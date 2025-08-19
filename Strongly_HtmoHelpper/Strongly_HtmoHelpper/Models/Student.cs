using System.ComponentModel;

namespace Strongly_HtmoHelpper.Models
{
    public class Student
    {
        [DisplayName("User Name")]
        public string sname { get; set; }
        [DisplayName("User Password")]
        public string pass { get; set; }
    }
}
