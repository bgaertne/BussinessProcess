using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Urlaubsantrag
{
    public class AuthorizationStep:Step
    {
        [JsonConstructor]
        public AuthorizationStep() { }
        public AuthorizationStep(string id, int state, Boolean ended, Employee toBeAuthorizedBy):base(id, state, ended)
        {
            ToBeAuthorizedBy = toBeAuthorizedBy;
        }

        public Employee ToBeAuthorizedBy { get; set; }

        public override void processStep() {
            Console.WriteLine($"Muss von {ToBeAuthorizedBy.FirstName} {ToBeAuthorizedBy.LastName} authorisiert werden");

            Console.WriteLine($"Wurde von {ToBeAuthorizedBy.FirstName} {ToBeAuthorizedBy.LastName} authorisiert");
            Ended = true;
        }

    }
}
