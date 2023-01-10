using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;

namespace TinderBot2._0.Objects
{
    [ProtoContract]
    public class SMSLoginRequest
    {
        [ProtoMember(1)] public long RefreshToken { get; set; } = 168430858;

        [ProtoMember(62)]
        public string Phone { get; set; }
    }
}
