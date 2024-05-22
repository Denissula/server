namespace API.Dtos;

public class RefreshTokenDto
{
    public string RefreshToken { get; set; } = null!;
    public string Token { get; set; } = null!;
    public string Email { get; set; } = null!;
}