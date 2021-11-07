using System;

namespace TodoApi.Domain.Entities
{
    public abstract class Entity : IEquatable<Entity>
    {
        public Entity(Guid id)
        {
            id = Guid.NewGuid();
        }

        public Guid Id { get; private set; }

        public bool Equals(Entity other)
        {
            return Id == other.Id;
        }
    }
}
