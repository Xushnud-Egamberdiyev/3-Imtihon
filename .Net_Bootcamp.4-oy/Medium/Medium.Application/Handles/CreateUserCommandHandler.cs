using AutoMapper;
using MediatR;
using Medium.Application.Abstractions;
using Medium.Application.Commads;
using Medium.Domain.Entity;
using Medium.Domain.Entity.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium.Application.Handles
{
    public class CreateUserCommandHandler : AsyncRequestHandler<CreateUserCommand>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CreateUserCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper; 
        }

        

        protected async override Task Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);

            await _context.Users.AddAsync(user);
            await _context.SavaChagesAsync(cancellationToken);
        }
    }
}
