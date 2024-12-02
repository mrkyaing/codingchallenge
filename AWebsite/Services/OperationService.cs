namespace AWebsite.Services;
public class OperationService : ISingletonService, IScopedService, ITransientService
{
    public Guid Value { get; private set; } = Guid.NewGuid();
}
