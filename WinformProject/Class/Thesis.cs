using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformProject.Class
{
    class Thesis
    {
        Random random = new Random();
        public string ThesisID { get; set; }
        public string StudentID { get; set; }
        public string ThesisName { get; set; }
        public string Status { get; set; }
        public string Reason { get; set; }

        public Thesis(string StudentID, string ThesisName, string Reason)
        {
            this.StudentID = StudentID;
            this.ThesisName = ThesisName;
            this.Reason = Reason;
            Status = "Chua Duoc Duyet";
            ThesisID = random.Next(1, 1000).ToString("D3");
        }
    }
}
