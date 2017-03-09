using Sitecore.Modules.EmailCampaign.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace Sitecore.Support.Modules.EmailCampaign.Messages
{
    public static class Helper
    {
        static FieldInfo tokens;
        public static FieldInfo TokensField
        {
            get
            {
                if (tokens == null)
                {
                    Type t = typeof(MessageItem);
                    tokens = t.GetField("_customPersonTokens", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                }

                return tokens;
            }
        }
    }
}