using Entities.Concrete.API;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Abstract
{
    public interface ILogin 
    {
        public Task<ResultStatus<LoginResult>> Login([FromBody] string username, string password);
    }
}
