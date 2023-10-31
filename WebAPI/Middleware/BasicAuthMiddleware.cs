namespace WebAPI.Middleware
{
    public class BasicAuthMiddleware
    {
        private readonly RequestDelegate _next;

        public BasicAuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            string authHeader = context.Request.Headers["Authorization"];
            if (authHeader != null && authHeader.StartsWith("Basic "))
            {
                // Kullanıcı zaten kimlik doğrulamasını göndermişse, devam et
                await _next(context);
            }
            else
            {
                // Kimlik doğrulama bilgisi istemciye gönderilir
                context.Response.Headers["WWW-Authenticate"] = "Basic";
                context.Response.StatusCode = 401;
            }
        }
    }

}
