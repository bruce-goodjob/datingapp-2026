namespace API.Entities;

public class AppUser
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public required string DisplayName { get; set; } //required 不能为空，创建对象必须赋值
    public required string Email { get; set; } //string? 允许为空，创建对象可以不赋值
    public required byte[] PasswordHash { get; set; }
    public required byte[] PasswordSalt { get; set; }
}