using Cf.Dotnet.PracticesAndPatterns.Solid.Domain;

namespace Cf.Dotnet.PracticesAndPatterns.Solid.Application;

/// <summary>
/// Clase que implementa la interfaz IUserApplication y coordina la creación de usuarios y el envío de notificaciones.
/// </summary>
public class UserApplication : IUserApplication
{
    private readonly INotificationService notificationService;
    private readonly IUserCreateService userCreateService;

    /// <summary>
    /// Constructor de UserApplication que inyecta dependencias de IUserCreateService y INotificationService.
    /// </summary>
    /// <param name="userCreateService">Servicio para la creación de usuarios.</param>
    /// <param name="notificationService">Servicio para el envío de notificaciones.</param>
    public UserApplication(IUserCreateService userCreateService, INotificationService notificationService)
    {
        this.userCreateService = userCreateService;
        this.notificationService = notificationService;
    }

    /// <summary>
    /// Crea un nuevo usuario y envía una notificación relacionada.
    /// </summary>
    /// <param name="name">Nombre del usuario a crear.</param>
    /// <returns>El usuario recién creado.</returns>
    public User CreateUser(string name)
    {
        var user = userCreateService.CreateUser(name);
        notificationService.SendNotification(user);
        return user;
    }
}