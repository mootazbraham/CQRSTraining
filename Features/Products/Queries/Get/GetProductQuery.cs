namespace CQRSProject;
using MediatR;

public record GetProductQuery(Guid Id) : IRequest<ProductDto>;

