using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace SoftwareCompany.Client.WebApp.Infrasctucture
{
    public static class SessionsExtensions
    {
        public static void SetJson(this ISession session, string key, object value)
        {
            session.SetString(key,JsonConvert.SerializeObject(value));
        }

        public static T GetJson<T>(this ISession session, string key)
        {
            var sessionData = session.GetString(key);

            return sessionData == null ? default : JsonConvert.DeserializeObject<T>(sessionData);
        }
    }
}
