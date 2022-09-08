﻿using Devs.Application.Features.Users.DTOs;
using MediatR;

namespace Devs.Application.Features.Users.Commands.UpdateUser;

public class UpdateUserCommand : IRequest<UpdatedUserDto>
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string GitHubUrl { get; set; }
}