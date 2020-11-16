using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common.Tools;
using Models.Insightly;

namespace Services.Insightly
{
    public class UserService : BaseService<User>
    {
        public UserService(string apiKey) : base(apiKey, "Users")
        {
        }

        private User Get(long id)
        {
            return GetByUrlAsync<User>(id.ToString())?.Result;
        }

        internal async Task<IEnumerable<User>> Search(string field, object value)
        {
            return await GetByUrlAsync<IEnumerable<User>>($"Search?field_name={field}&field_value={value}");
        }

        public User GetUser(long? id)
        {
            try
            {
                if (id == null) return null;
                Utils.LogMessage($"Getting user #{id}...");

                var user = Get((long)id);
                if (user != null) Utils.LogMessage($"Successfully retrieved user, {user.FIRST_NAME} {user.LAST_NAME}!");
                return user;
            }
            catch (Exception ex)
            {
                Utils.LogMessage($"Error getting user id #{id}: {ex.Message}");
                throw;
            }
        }

        public IEnumerable<User> SearchUsers(string field, object value)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(field) || value == null) return null;
                Utils.LogMessage($"Searching for users with {value} in {field}...");

                var users = Search(field, value).Result;
                if (users != null && users.Count() > 0) Utils.LogMessage($"Successfully found {users.Count()} users!");
                return users;
            }
            catch (Exception ex)
            {
                Utils.LogError($"Searching for users with {value} in {field}: {ex.Message}");
                throw;
            }
        }
    }
}
