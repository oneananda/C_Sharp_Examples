using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatR_Console_Implementation
{
    internal class PingHandler : IRequestHandler<Ping, string>
    {
        public Task<string> Handle(Ping request, CancellationToken cancellationToken)
        {
            return Task.FromResult("Pong");
        }
    }
}
