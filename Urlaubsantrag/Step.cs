using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Urlaubsantrag
{
    [JsonDerivedType(typeof(Step), typeDiscriminator: "step")]
    [JsonDerivedType(typeof(AuthorizationStep), typeDiscriminator: "auth")]
    [JsonDerivedType(typeof(EmailStep), typeDiscriminator: "email")]
    public class Step
    {

        [JsonConstructor]
        public Step() {
        
        }
        public Step(string id, int state, Boolean ended ) { 
            Id = id;
            State = state;
            Ended = ended;
        }
        public String Id { get; set; }
        public int State { get; set; }
        public Boolean Ended {  get; set; }

        public virtual void processStep() {
            
        }
    }
}
