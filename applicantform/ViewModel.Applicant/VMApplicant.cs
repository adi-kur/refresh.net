using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel.Applicant
{
    public class VMApplicant
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Contact_Number { get; set; }
        public string Email { get; set; }
        public System.DateTime Date_Of_Birth { get; set; }
        public string Address { get; set; }
        public Nullable<bool> Major { get; set; }
        public string Question { get; set; }
        public bool Is_Delete { get; set; }
        public string Created_By { get; set; }
        public Nullable<System.DateTime> Created_On { get; set; }
        public string Modified_By { get; set; }
        public Nullable<System.DateTime> Modified_On { get; set; }
    }
}
