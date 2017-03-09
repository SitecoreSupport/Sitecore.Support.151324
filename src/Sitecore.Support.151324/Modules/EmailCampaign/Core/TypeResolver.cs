using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data.Items;
using Sitecore.Modules.EmailCampaign.Messages;

namespace Sitecore.Support.Modules.EmailCampaign.Core
{
    public class TypeResolver: Sitecore.Modules.EmailCampaign.Core.TypeResolver
    {
        public override MessageItem GetCorrectMessageObject(Item item)
        {
            MessageItem result= base.GetCorrectMessageObject(item);
            if(result is Sitecore.Modules.EmailCampaign.Messages.ABTestMessage)
            {
                return new Sitecore.Support.Modules.EmailCampaign.Messages.ABTestMessage(item);
            }

            if(result is Sitecore.Modules.EmailCampaign.Messages.WebPageMail)
            {
                return new Sitecore.Support.Modules.EmailCampaign.Messages.WebPageMail(item);
            }

            if(result is Sitecore.Modules.EmailCampaign.Messages.HtmlMail)
            {
                return new Sitecore.Support.Modules.EmailCampaign.Messages.HtmlMail(item);
            }

            if(result is Sitecore.Modules.EmailCampaign.Messages.TextMail)
            {
                return new Sitecore.Support.Modules.EmailCampaign.Messages.TextMail(item);
            }

            return result;            
        }
    }
}