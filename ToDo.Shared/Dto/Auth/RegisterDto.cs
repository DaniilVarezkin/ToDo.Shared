namespace ToDo.Shared.Dto.Auth
{
    /// <summary>
    /// DTO для регистрации пользователя.
    /// </summary>
    public class RegisterDto
    {
        /// <summary>
        /// Имя пользователя (логин).
        /// </summary>
        public string UserName { get; set; } = null!;

        /// <summary>
        /// Электронная почта пользователя.
        /// </summary>
        public string Email { get; set; } = null!;

        /// <summary>
        /// Пароль для аккаунта.
        /// </summary>
        public string Password { get; set; } = null!;
    }
}
