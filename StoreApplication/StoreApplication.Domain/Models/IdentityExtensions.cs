using System.Security.Claims;
using System.Security.Principal;

namespace StoreApplication.Domain.Models { 

    public static class IdentityExtensions
    {
        //public static string FirstName(this IIdentity identity)
        //{
        //    var claim = ((ClaimsIdentity)identity).FindFirst(ClaimTypes.GivenName);
        //    // Test for null to avoid issues during local testing
        //    return (claim != null) ? claim.Value : string.Empty;
        //}


        //public static string LastName(this IIdentity identity)
        //{
        //    var claim = ((ClaimsIdentity)identity).FindFirst(ClaimTypes.Surname);
        //    // Test for null to avoid issues during local testing
        //    return (claim != null) ? claim.Value : string.Empty;
        //}

        //public static string Address(this IIdentity identity)
        //{
        //    var claim = ((ClaimsIdentity)identity).FindFirst(ClaimTypes.StreetAddress);
        //    // Test for null to avoid issues during local testing
        //    return (claim != null) ? claim.Value : string.Empty;
        //}

        //public static string State (this IIdentity identity)
        //{
        //    var claim = ((ClaimsIdentity)identity).FindFirst(ClaimTypes.StateOrProvince);
        //    // Test for null to avoid issues during local testing
        //    return (claim != null) ? claim.Value : string.Empty;
        //}

        //public static string Zipcode(this IIdentity identity)
        //{
        //    var claim = ((ClaimsIdentity)identity).FindFirst(ClaimTypes.PostalCode);
        //    // Test for null to avoid issues during local testing
        //    return (claim != null) ? claim.Value : string.Empty;
        //}

    }
}