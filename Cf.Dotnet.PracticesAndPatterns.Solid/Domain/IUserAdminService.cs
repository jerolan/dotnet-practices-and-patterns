namespace Cf.Dotnet.PracticesAndPatterns.Solid.Domain;

/// <summary>
/// Proporciona la definición para un servicio de administración de usuarios,
/// incluyendo la asignación de roles.
/// </summary>
public interface IUserAdminService
{
    /// <summary>
    /// Asigna un rol específico a un usuario.
    /// </summary>
    /// <param name="user">El usuario al que se le asignará el rol.</param>
    /// <param name="role">El rol que se asignará al usuario.</param>
    void AssignRole(User user, Role role);
}