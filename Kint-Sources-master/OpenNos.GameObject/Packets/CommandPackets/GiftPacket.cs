﻿////<auto-generated <- Codemaid exclusion for now (PacketIndex Order is important for maintenance)

using OpenNos.Core;
using OpenNos.Domain;

namespace OpenNos.GameObject.CommandPackets
{
    [PacketHeader("$Gift", PassNonParseablePacket = true, Authority = AuthorityType.Operator)]
    public class GiftPacket : PacketDefinition
    {
        #region Properties

        [PacketIndex(0)]
        public string CharacterName { get; set; }

        [PacketIndex(1)]
        public short VNum { get; set; }

        [PacketIndex(2)]
        public byte Amount { get; set; }

        [PacketIndex(3)]
        public sbyte Rare { get; set; }

        [PacketIndex(4)]
        public byte Upgrade { get; set; }

        public static string ReturnHelp()
        {
            return "$Gift CHARACTERNAME(*) VNUM AMOUNT RARE UPGRADE";
        }

        #endregion
    }
}