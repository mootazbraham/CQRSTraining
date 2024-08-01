namespace CQRSProject;
using MediatR;
public record DeleteProductCommand(Guid Id) : IRequest;