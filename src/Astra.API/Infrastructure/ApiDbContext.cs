using Astra.EntityFramework;

namespace Astra.API.Infrastructure
{
    /// <summary>
    /// 
    /// </summary>
    public class ApiDbContext : MainDbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public ApiDbContext() : base("DefaultConnection")
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
    }
}