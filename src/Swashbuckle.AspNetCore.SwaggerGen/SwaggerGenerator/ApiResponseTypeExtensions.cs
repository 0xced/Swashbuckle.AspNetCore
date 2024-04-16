using Microsoft.AspNetCore.Mvc.ApiExplorer;

namespace Swashbuckle.AspNetCore.SwaggerGen
{
    public static class ApiResponseTypeExtensions
    {
        internal static bool IsDefaultResponse(this ApiResponseType apiResponseType)
        {
            var propertyInfo = apiResponseType.GetType().GetProperty("IsDefaultResponse");
            if (propertyInfo != null)
            {
                return propertyInfo.GetValue(apiResponseType) is true;
            }

            // ApiExplorer < 2.1.0 does not support default response.
            return false;
        }
    }
}
