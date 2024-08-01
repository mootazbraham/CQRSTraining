using MediatR;

namespace CQRSProject;
public record ListProductsQuery : IRequest<List<ProductDto>>;
