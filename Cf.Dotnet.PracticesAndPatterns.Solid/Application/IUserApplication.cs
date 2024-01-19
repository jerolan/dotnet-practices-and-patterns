using Cf.Dotnet.PracticesAndPatterns.Solid.Domain;

namespace Cf.Dotnet.PracticesAndPatterns.Solid.Application;

/// <summary>
/// Define la interfaz para una aplicación de usuario, proporcionando la funcionalidad para crear usuarios.
/// </summary>
public interface IUserApplication
{
    /// <summary>
    /// Crea y devuelve un nuevo usuario con el nombre especificado.
    /// </summary>
    /// <param name="name">El nombre del nuevo usuario.</param>
    /// <returns>El usuario recién creado.</returns>
    User CreateUser(string name);
}