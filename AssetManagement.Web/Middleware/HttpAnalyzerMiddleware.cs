namespace AssetManagement.Web.Middleware
{
    public class HttpAnalyzerMiddleware
    {
        private readonly RequestDelegate _next;

        public HttpAnalyzerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if (!context.Response.HasStarted)
            {

            }


            await _next(context);
        }
    }
}
