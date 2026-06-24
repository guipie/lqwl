using System.ComponentModel.DataAnnotations;

namespace Ape.Volo.SharedModel.Dto.Core.Permission.User;

/// <summary>
/// 用户偏好设置Dto
/// </summary>
public class UpdateUserPreferencesConfigDto
{
    /// <summary>
    /// 旧密码
    /// </summary>
    [Display(Name = "User.PreferencesConfig")]
    [Required(ErrorMessage = "{0}required")]
    public string PreferencesConfig { get; set; }
}