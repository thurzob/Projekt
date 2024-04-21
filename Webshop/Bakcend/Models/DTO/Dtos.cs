namespace Bakcend.Models.DTO
{
    public record CreateUserDto(string Name, string Password, string Email, int MerchantId);
    public record UpdateUserDto(string Name, string Password, string Email);
    public record CreateQuantityDto(int Extant, int Sold, int Revenue);
    public record UpdateQuantityDto(int Extant, int Sold, int Revenue);


}
