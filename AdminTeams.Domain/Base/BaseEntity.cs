namespace AdminTeams.Domain.Base
{
    public abstract class BaseEntity<TId> : IBaseEntity
    {
        public BaseEntity(TId id)
        {
            Id = id;
        }

        public TId Id { get; private set; }
    }
}