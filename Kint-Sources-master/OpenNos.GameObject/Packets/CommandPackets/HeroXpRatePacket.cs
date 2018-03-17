﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core;
using OpenNos.Domain;

namespace OpenNos.GameObject.CommandPackets
{
    [PacketHeader("$HeroXpRate", PassNonParseablePacket = true, Authority = AuthorityType.Operator)]
    public class HeroXpRatePacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public int Value { get; set; }

        public static string ReturnHelp()
        {
            return "$HeroXpRate VALUE";
        }

        #endregion
    }
}