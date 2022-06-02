using Crest.Entities;

namespace Crest.Api.Endpoints
{
    public class UserEndpoint
    {
        private readonly CrestHttpManager _manager;

        public UserEndpoint(CrestHttpManager manager)
        {
            _manager = manager;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="InvalidOperationException"></exception>
        public async Task<User> GetOneAsync(ulong id)
        {
            var result = await _manager.SendAsync(new(HttpMethod.Get, $"users/{id}"));

            if (Users.TryParse(this, await result.GetJsonAsync(), out var user))
                return user;
            else
                throw new InvalidOperationException();
        }
    }
}
