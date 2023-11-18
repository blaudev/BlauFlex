using Blau.Entities;

namespace Blau.Flex.Core.TenantAggregate;

public class Tenant : Entity, IAggregateRoot
{
    public string Name { get; set; } = default!;
}
