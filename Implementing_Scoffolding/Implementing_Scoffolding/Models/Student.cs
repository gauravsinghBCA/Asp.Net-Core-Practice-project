using System.ComponentModel;

namespace Implementing_Scoffolding.Models
{
    public class Student
    {
        [DisplayName("Student Id")]
        public int stid {  get; set; }
        [DisplayName("Student Name")]
        public string stname { get; set; }
        [DisplayName("Student DOB")]
        public DateTime stage { get; set; }
        [DisplayName("Student Gender")]
        public string gender { get; set; }
        [DisplayName("Student EmailID")]
        public string emailid { get; set; }
        
    }
}
