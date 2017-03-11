using System;
using System.Net;

namespace AntServiceStack.ServiceHost
{
    public interface ICookies
    {
        void DeleteCookie(string cookieName);
        void AddCookie(Cookie cookie);
        void AddPermanentCookie(string cookieName, string cookieValue, bool? secureOnly = null);
        void AddSessionCookie(string cookieName, string cookieValue, bool? secureOnly = null);
    }
}