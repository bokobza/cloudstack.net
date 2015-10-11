using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class UpdateFirewallRuleRequest : APIRequest
    {
        public UpdateFirewallRuleRequest() : base("updateFirewallRule") {}

        /// <summary>
        /// the ID of the firewall rule
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, in case you want to set a custom id to the resource. Allowed to Root Admins only
        /// </summary>
        public string CustomId {
            get { return (string) Parameters[nameof(CustomId).ToLower()]; }
            set { Parameters[nameof(CustomId).ToLower()] = value; }
        }

        /// <summary>
        /// an optional field, whether to the display the rule to the end user or not
        /// </summary>
        public bool? Fordisplay {
            get { return (bool?) Parameters[nameof(Fordisplay).ToLower()]; }
            set { Parameters[nameof(Fordisplay).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Updates firewall rule 
    /// </summary>
    /// <summary>
    /// Updates firewall rule 
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse UpdateFirewallRule(UpdateFirewallRuleRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse UpdateFirewallRule(UpdateFirewallRuleRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
