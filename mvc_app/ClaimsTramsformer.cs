using System;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace mvc_app
{
    public class ClaimsTransformer: IClaimsTransformation
    {
        public Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
        {
            var wi = (WindowsIdentity)principal.Identity;
            if (wi.Groups != null)  
        {  
            foreach (var group in wi.Groups)
                {  
                    try  
                    {  
                        var claim = new Claim(wi.RoleClaimType, group.Value);  
                        wi.AddClaim(claim);                          
                    }  
                    catch (Exception ex)  
                    {  
                       throw ex;  
                    }  
                 }  
         }              
          return Task.FromResult(principal);  
        }
    }
}