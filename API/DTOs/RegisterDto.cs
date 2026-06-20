using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        [Required]// 检查用户是否给该字段提供了有效值 无该字段，null，空字符串都不行。
        public string DisplayName { get; set; } = ""; // 提供初始值 => Displayname就非null了  想象DisplayName.Length() 如果null => 报错， 如果空字符串 => 0 不报错。
        [Required]
        [EmailAddress]
        public string Email { get; set; } = ""; //requried只检查是否赋值 空字符串并不会报错， 就会出现用户名字为空的情况
        [Required]
        [MinLength(4)]
        public string Password { get; set; } = "";
    }
    
}