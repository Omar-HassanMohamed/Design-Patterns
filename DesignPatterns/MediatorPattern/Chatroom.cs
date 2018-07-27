using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.MediatorPattern
{
    public class Chatroom : AbstractChatroom
    {
        private Dictionary<string, Participant> _participants = new Dictionary<string, Participant>();
    
        public override void Register(Participant participant)
        {
            if (!_participants.ContainsValue(participant))
                _participants[participant.Name] = participant;
        }

        public override void Send(string from, string to, string message)
        {

        }
    }
}
