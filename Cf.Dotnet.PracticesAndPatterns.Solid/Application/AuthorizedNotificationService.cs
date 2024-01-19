using Cf.Dotnet.PracticesAndPatterns.Solid.Domain;
using Microsoft.Extensions.Logging;

namespace Cf.Dotnet.PracticesAndPatterns.Solid.Application;

/// <summary>
/// Servicio de notificación con autorización adicional. Implementa la interfaz INotificationService.
/// </summary>
public class AuthorizedNotificationService : INotificationService
{
    private readonly ILogger<AuthorizedNotificationService> logger;

    private readonly NotificationService notificationService;

    /// <summary>
    /// Constructor de AuthorizedNotificationService que inyecta una dependencia de NotificationService y ILogger.
    /// </summary>
    /// <param name="notificationService">El servicio de notificación subyacente.</param>
    /// <param name="logger">El logger utilizado para registrar mensajes.</param>
    public AuthorizedNotificationService(NotificationService notificationService,
        ILogger<AuthorizedNotificationService> logger)
    {
        this.notificationService = notificationService;
        this.logger = logger;
    }

    /// <summary>
    /// Envía una notificación con una capa adicional de autorización.
    /// </summary>
    /// <param name="data">Los datos utilizados para formar la notificación.</param>
    public void SendNotification(object data)
    {
        logger.LogInformation("Authorizing notification service...");
        notificationService.SendNotification(data);
    }
}
