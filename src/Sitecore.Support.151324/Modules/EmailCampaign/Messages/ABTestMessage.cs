using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Modules.EmailCampaign.Messages;
using System.Reflection;

namespace Sitecore.Support.Modules.EmailCampaign.Messages
{   
    public class ABTestMessage : Sitecore.Modules.EmailCampaign.Messages.ABTestMessage
    {
        public ABTestMessage(Item item) : base(item)
        {
        }

        protected override void CloneFields(MessageItem newMessage)
        {
            base.CloneFields(newMessage);
            Dictionary<string, object> tokens = new Dictionary<string, object>(this.CustomPersonTokens);            
            Helper.TokensField.SetValue(newMessage, tokens);
        }
    }    
}