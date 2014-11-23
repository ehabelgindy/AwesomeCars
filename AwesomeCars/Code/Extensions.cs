using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using Sitecore.Web;

namespace AwesomeCars.Code
{
    public static class Extensions
    {
        public static void SubscribeToEvent(this UserControl control,  string eventName, EventHandler handler)
        {
            Sitecore.Events.Event.Subscribe(eventName + HttpContext.Current.Session.SessionID, handler);
        }

        public static void UnsubscribeFromEvent(this UserControl control, string eventName, EventHandler handler)
        {
            Sitecore.Events.Event.Unsubscribe(eventName + HttpContext.Current.Session.SessionID, handler);
        }

        public static void RaiseEvent(this UserControl control, string eventName, params object[] parameters)
        {
            Sitecore.Events.Event.RaiseEvent(eventName + HttpContext.Current.Session.SessionID, parameters);
        }

        public static string UpdateQueryString(this UserControl control, string key, string value,
                                               params string[] keysToRemove)
        {
            var parameters = WebUtil.ParseQueryString(HttpContext.Current.Request.Url.Query);
            foreach (var keyToRemove in keysToRemove)
            {
                parameters.Remove(keyToRemove);
            }
            parameters[key] = value;
            var queryString = WebUtil.BuildQueryString(parameters, false);
            return string.Format("{0}?{1}", HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Path),queryString);

        }
    }
}