namespace Cf.Dotnet.PracticesAndPatterns.Solid.Domain;

/// <summary>
/// Proporciona la definición para un servicio de actualización de usuarios.
/// </summary>
public interface IUserUpdateService
{
    /// <summary>
    /// Actualiza la información de un usuario existente.
    /// </summary>
    /// <param name="user">El usuario con la información actualizada.</param>
    void UpdateUser(User user);
}