using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaBot3.Models
{
    public class Player
    {
        public Guid PlayerId { get; set; }
        public string PlayerSlackId { get; set; }
        public string PlayerFirstName { get; set; }
        public string PlayerLastName { get; set; }
        public string PlayerMention { get; set; }
        public List<Attempt> Attempts { get; set; }
        public string DirectMessage { get; set; }
    }
}
