﻿using Newtonsoft.Json;

namespace Mirai.Net.Data.Events.Concrete.Args.Group
{
    public class GroupMemberLeftGroupActiveEventArgs : EventArgsBase
    {
        public override string Type { get; set; }
        
        [JsonProperty("member")]
        public GroupMember Member {get; set;}
    }
}