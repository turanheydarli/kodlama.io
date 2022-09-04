﻿namespace Core.Persistence.Repositories;

public abstract class Entity
{
    public int Id { get; set; }
    public DateTime CreatedTime { get; set; } = DateTime.UtcNow;
    public DateTime UpdatedTime { get; set; }
    
    public Entity() { }

    public Entity(int id) : this()
    {
        Id = id;
    }
}