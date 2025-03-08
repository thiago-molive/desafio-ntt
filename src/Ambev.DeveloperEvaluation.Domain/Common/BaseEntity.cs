using Ambev.DeveloperEvaluation.Common.Validation;

namespace Ambev.DeveloperEvaluation.Domain.Common;

public class BaseEntity : IComparable<BaseEntity>
{
    private readonly List<DomainEventBase> _domainEvents = new();

    public Guid Id { get; set; }

    public Task<IEnumerable<ValidationErrorDetail>> ValidateAsync()
    {
        return Validator.ValidateAsync(this);
    }

    public virtual IReadOnlyCollection<DomainEventBase> GetEvents() => _domainEvents.ToList();

    public virtual void ClearEvents() => _domainEvents.Clear();

    protected virtual void Publish(DomainEventBase domainEvent) => _domainEvents.Add(domainEvent);

    public int CompareTo(BaseEntity? other)
    {
        if (other == null)
        {
            return 1;
        }

        return other!.Id.CompareTo(Id);
    }
}