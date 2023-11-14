using asp.net_mvc_ecommerce_features_labtask.Models;
using System.Linq;

public class UserRepository
{
    private readonly EcommerceDBEntities _context;

    public UserRepository(EcommerceDBEntities context)
    {
        _context = context;
    }

    public User GetUserByCredentials(int userId, string username)
    {
        return _context.Users.FirstOrDefault(u => u.UserId == userId && u.UserName == username);
    }
}
