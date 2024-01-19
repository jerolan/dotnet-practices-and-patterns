namespace Cf.Dotnet.PracticesAndPatterns.Solid.Domain;

/// <summary>
/// Proporciona la definición para un servicio de notificación.
/// Este servicio incluye métodos para enviar notificaciones basadas en datos proporcionados.
/// </summary>
public interface INotificationService
{
    /// <summary>
    /// Envía una notificación utilizando los datos proporcionados.
    /// </summary>
    /// <param name="data">Los datos utilizados para formar la notificación.</param>
    /// <remarks>
    /// Este método puede ser utilizado para enviar diferentes tipos de notificaciones, como correos electrónicos,
    /// mensajes SMS, notificaciones push, etc., dependiendo de la implementación concreta del servicio.
    /// </remarks>
    void SendNotification(object data);
}