using Cf.Dotnet.PracticesAndPatterns.Solid.Domain;
using Microsoft.Extensions.Logging;

namespace Cf.Dotnet.PracticesAndPatterns.Solid.Application;

/// <summary>
/// Servicio para enviar notificaciones. Implementa la interfaz INotificationService.
/// </summary>
public class NotificationService : INotificationService
{
    private readonly ILogger<NotificationService> logger;

    /// <summary>
    /// Constructor de NotificationService que inyecta una dependencia de ILogger.
    /// </summary>
    /// <param name="logger">El logger utilizado para registrar mensajes.</param>
    public NotificationService(ILogger<NotificationService> logger)
    {
        this.logger = logger;
    }

    /// <summary>
    /// Envía una notificación utilizando los datos proporcionados.
    /// </summary>
    /// <param name="data">Los datos utilizados para formar la notificación.</param>
    public void SendNotification(object data)
    {
        // Registrando la acción de enviar una notificación en el log.
        logger.LogInformation("Sending notification...");
    }
}