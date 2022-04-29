using System.ComponentModel.DataAnnotations;

namespace BlazorWAI.Server.Data;
public class ShipmentModel
{
    public ShipmentModel()
    {
        UserInfo = new UserInfoModel();
        ShippingAddress = new AddressModel();
    }

    public UserInfoModel UserInfo { get; set; }
    public AddressModel ShippingAddress { get; set; }
}

public class UserInfoModel
{
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    [Phone]
    public string? Phone { get; set; }
}

public class AddressModel
{
    [Required]
    public string? Name { get; set; }
    [Required]
    public string? Street { get; set; }
    [Required]
    public string? City { get; set; }
    [Required]
    public string? PostalCode { get; set; }
    [Required]
    public string? Country { get; set; }
}
