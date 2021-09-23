using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphQL.Data;

namespace GraphQL
{
    public class AddSpeakerPayload
    {
        public Speaker Speaker { get; }

        public AddSpeakerPayload(Speaker speaker)
        {
            this.Speaker = speaker;
        }
    }
}
