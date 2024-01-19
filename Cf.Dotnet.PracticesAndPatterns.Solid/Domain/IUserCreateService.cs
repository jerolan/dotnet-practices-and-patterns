// Definición del espacio de nombres para la interfaz IUserCreateService.
namespace Cf.Dotnet.PracticesAndPatterns.Solid.Domain;

/// <summary>
/// Define la funcionalidad para un servicio de creación de usuarios.
/// </summary>
public interface IUserCreateService
{
    /// <summary>
    /// Crea un nuevo usuario con el nombre especificado.
    /// </summary>
    /// <param name="name">El nombre del usuario a crear.</param>
    /// <returns>El usuario recién creado.</returns>
    User CreateUser(string name);
}