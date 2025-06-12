namespace ToDo.Shared.Dto.Auth
{
    /// <summary>
    /// DTO для входа пользователя.
    /// </summary>
    public class LoginDto
    {
        /// <summary>
        /// Электронная почта пользователя.
        /// </summary>
        public string Email { get; set; } = null!;

        /// <summary>
        /// Пароль пользователя.
        /// </summary>
        public string Password { get; set; } = null!;
    }
}
