using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Oneiros.Auth;

public class UserAccount
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    
    public string Username { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string AuthToken { get; set; }
}