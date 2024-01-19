using Cf.Dotnet.PracticesAndPatterns.Solid.Domain;

namespace Cf.Dotnet.PracticesAndPatterns.Solid.Application;

/// <summary>
/// Controlador que maneja las operaciones relacionadas con los usuarios.
/// </summary>
public class UsersController
{
    private readonly IUserApplication userApplication;

    /// <summary>
    /// Constructor del controlador de usuarios que inyecta una dependencia de IUserApplication.
    /// </summary>
    /// <param name="userApplication">La instancia de IUserApplication utilizada para operaciones de usuario.</param>
    public UsersController(IUserApplication userApplication)
    {
        this.userApplication = userApplication;
    }

    /// <summary>
    /// Obtiene los datos del usuario basados en el nombre proporcionado.
    /// </summary>
    /// <param name="name">El nombre del usuario a buscar o crear.</param>
    /// <returns>La instancia del usuario.</returns>
    public User GetUsers(string name)
    {
        var user = userApplication.CreateUser(name);
        return user;
    }
}