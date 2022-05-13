using MediatR;

namespace StarWarsSite.Handlers;

public class HeartcoreReadAllHandler<TRequest, TResponse> : IRequestHandler<TRequest, IEnumerable<TResponse>>
            where TRequest : IRequest<IEnumerable<TResponse>>
{
    Task<IEnumerable<TResponse>> IRequestHandler<TRequest, IEnumerable<TResponse>>.Handle(TRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}