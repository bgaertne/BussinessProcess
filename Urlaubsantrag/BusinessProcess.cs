using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Urlaubsantrag
{
    public class BusinessProcess
    {
        [JsonConstructor]
        public BusinessProcess() {
            
        }

        public BusinessProcess(Guid id, List<Step> processSteps, int state, bool ended)
        {
            Id = id;
            ProcessSteps = processSteps;
            State = state;
            Ended = ended;
        }

        public Guid Id { get; set; }
        public List<Step> ProcessSteps { get; set; }
        public int State {  get; set; }
        public bool Ended {  get; set; }

        public void stopBusinessProcess() { 
            Console.WriteLine("process stopped");
        }
        public void continueBusinessProcess() {
            ProcessSteps[State].processStep();
            State++;
            if (State == ProcessSteps.Count)
            {
                Console.WriteLine("Geschäftsprozess beendet");
                Ended = true;
            }
            else { 
                stopBusinessProcess();
            }
            
        }
    }
}
