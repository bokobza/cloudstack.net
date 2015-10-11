using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DeleteVpnCustomerGatewayRequest : APIRequest
    {
        public DeleteVpnCustomerGatewayRequest() : base("deleteVpnCustomerGateway") {}

        /// <summary>
        /// id of customer gateway
        /// </summary>
        public Guid Id {
            get { return (Guid) Parameters[nameof(Id).ToLower()]; }
            set { Parameters[nameof(Id).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Delete site to site vpn customer gateway
    /// </summary>
    /// <summary>
    /// Delete site to site vpn customer gateway
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DeleteVpnCustomerGateway(DeleteVpnCustomerGatewayRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DeleteVpnCustomerGateway(DeleteVpnCustomerGatewayRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
