using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Modules.EmailCampaign.Messages;

namespace Sitecore.Support.Modules.EmailCampaign.Messages
{
    public class HtmlMail : Sitecore.Modules.EmailCampaign.Messages.HtmlMail
    {
        public HtmlMail(Item item) : base(item)
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