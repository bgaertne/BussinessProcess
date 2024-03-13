using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urlaubsantrag
{
    public class Request
    {
        public Request(Employee applicant, DateOnly requestdate, int state) {
            Id = new Guid();
            Applicant = applicant;
            RequestDate = requestdate;
            State = state;
        }

        public Guid Id { get; set; }
        public Employee Applicant { get; set; }
        public DateOnly RequestDate { get; set; }
        public int State { get; set; }
    }
}
