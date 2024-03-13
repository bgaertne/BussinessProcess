using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Urlaubsantrag
{
    public class EmailStep:Step
    {
        [JsonConstructor]
        public EmailStep() {}
        public EmailStep(string id, int state, Boolean ended, string to, string from) :base(id, state, ended) 
        {
            To = to;
            From = from;
        }
        public string To {  get; set; }
        public string From { get; set; }

        public override void   processStep() {
            Console.WriteLine($"Email von {From} an {To} versended");
            Ended = true;
        }
    }
}
