namespace CQRSProject;
using MediatR;
public record ProductCreatedNotification(Guid Id) : INotification;