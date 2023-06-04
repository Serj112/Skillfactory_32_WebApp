/*using Microsoft.EntityFrameworkCore;

namespace Skillfactory_32_WebApp.Models
{
    public class UserInfoRepository: IUserInfoRepository
    {
        private readonly CoreStartAppContext _context;

        public UserInfoRepository(CoreStartAppContext context)
        {
            _context = context;
        }
        public async Task Add(UserInfo userInfo)
        {
            var entry = _context.Entry(userInfo);

            if(entry.State == EntityState.Detached)
            {
                await _context.UserInfos.AddAsync(userInfo);
            }

            throw new System.NotImplementedException();
        }
    }
}
*/