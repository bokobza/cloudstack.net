using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace CloudStack.Net
{
    public class DetachIsoRequest : APIRequest
    {
        public DetachIsoRequest() : base("detachIso") {}

        /// <summary>
        /// The ID of the virtual machine
        /// </summary>
        public Guid VirtualMachineId {
            get { return (Guid) Parameters[nameof(VirtualMachineId).ToLower()]; }
            set { Parameters[nameof(VirtualMachineId).ToLower()] = value; }
        }

    }
    /// <summary>
    /// Detaches any ISO file (if any) currently attached to a virtual machine.
    /// </summary>
    /// <summary>
    /// Detaches any ISO file (if any) currently attached to a virtual machine.
    /// </summary>
    public partial interface ICloudStackAPIClient
    {
        AsyncJobResponse DetachIso(DetachIsoRequest request);
    }
    public partial class CloudStackAPIClient : ICloudStackAPIClient
    {
        public AsyncJobResponse DetachIso(DetachIsoRequest request) => _proxy.Request<AsyncJobResponse>(request);
    }
}
