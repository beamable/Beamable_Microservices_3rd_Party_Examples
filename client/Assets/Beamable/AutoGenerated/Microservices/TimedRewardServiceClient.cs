//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Beamable.Server.Clients
{
    using System;
    using Beamable.Platform.SDK;
    using Beamable.Server;
    
    
    /// <summary> A generated client for <see cref="Beamable.Server.TimedRewardService.TimedRewardService"/> </summary
    public sealed class TimedRewardServiceClient : Beamable.Server.MicroserviceClient
    {
        
        /// <summary>
        /// Call the Claim method on the TimedRewardService microservice
        /// <see cref="Beamable.Server.TimedRewardService.TimedRewardService.Claim"/>
        /// </summary>
        public Beamable.Common.Promise<bool> Claim(TimeRewardRef rewardRef)
        {
            string serialized_rewardRef = this.SerializeArgument<TimeRewardRef>(rewardRef);
            string[] serializedFields = new string[] {
                    serialized_rewardRef};
            return this.Request<bool>("TimedRewardService", "Claim", serializedFields);
        }
    }
}
