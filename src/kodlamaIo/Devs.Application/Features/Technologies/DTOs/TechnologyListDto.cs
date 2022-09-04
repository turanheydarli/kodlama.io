﻿using Devs.Application.Services.Mapping;
using Devs.Domain.Entities;

namespace Devs.Application.Features.Technologies.DTOs;

public class TechnologyListDto : IMapFrom<Technology>
{
    public int Id { get; set; }
    public string Name { get; set; }
}