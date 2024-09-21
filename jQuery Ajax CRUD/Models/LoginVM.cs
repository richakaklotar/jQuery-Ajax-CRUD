using System.ComponentModel.DataAnnotations;

namespace jQuery_Ajax_CRUD.Models;

public class LoginVM
{
    public int Id { get; set; }
    [Required(ErrorMessage ="Username is required.")]
    public string? Username { get; set; }

    [Required(ErrorMessage ="Password is required.")]
    [DataType(DataType.Password)]
    public string? Password { get; set; }

    [Display(Name ="Remember Me")]
    public bool RememberMe { get; set; }
}
