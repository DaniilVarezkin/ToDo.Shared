namespace ToDo.Shared.Dto.Auth
{
    /// <summary>
    /// DTO возвращаемое при входе в аккаунт
    /// </summary>
    public class LoginResponse
    {
        public string Token { get; set; } = default!;
    }
}
