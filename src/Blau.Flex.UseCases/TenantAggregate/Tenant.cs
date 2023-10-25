using Blau.Entities;

namespace Blau.Flex.UseCases.TenantAggregate;

public class Tenant : Entity, IAggregateRoot
{
    public string Name { get; set; } = default!;
}
