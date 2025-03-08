namespace Ambev.DeveloperEvaluation.Domain.Common;

public abstract class DomainEventBase : IDomainEvent
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}