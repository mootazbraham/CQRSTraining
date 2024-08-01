namespace CQRSProject;
using MediatR;
public record CreateProductCommand(string Name, string Description, decimal Price) : IRequest<Guid>;

