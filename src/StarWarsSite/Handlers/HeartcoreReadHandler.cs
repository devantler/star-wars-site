using MediatR;

namespace StarWarsSite.Handlers;

public class HeartcoreReadHandler<TRequest, TResponse> : IRequestHandler<TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    public Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}