// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: dac_gcmessages_common.proto
// </auto-generated>

#pragma warning disable CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.GC.Underlords.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CExtraMsgBlock : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint msg_type
        {
            get { return __pbn__msg_type.GetValueOrDefault(); }
            set { __pbn__msg_type = value; }
        }
        public bool ShouldSerializemsg_type() => __pbn__msg_type != null;
        public void Resetmsg_type() => __pbn__msg_type = null;
        private uint? __pbn__msg_type;

        [global::ProtoBuf.ProtoMember(2)]
        public byte[] contents
        {
            get { return __pbn__contents; }
            set { __pbn__contents = value; }
        }
        public bool ShouldSerializecontents() => __pbn__contents != null;
        public void Resetcontents() => __pbn__contents = null;
        private byte[] __pbn__contents;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong msg_key
        {
            get { return __pbn__msg_key.GetValueOrDefault(); }
            set { __pbn__msg_key = value; }
        }
        public bool ShouldSerializemsg_key() => __pbn__msg_key != null;
        public void Resetmsg_key() => __pbn__msg_key = null;
        private ulong? __pbn__msg_key;

        [global::ProtoBuf.ProtoMember(4)]
        public bool is_compressed
        {
            get { return __pbn__is_compressed.GetValueOrDefault(); }
            set { __pbn__is_compressed = value; }
        }
        public bool ShouldSerializeis_compressed() => __pbn__is_compressed != null;
        public void Resetis_compressed() => __pbn__is_compressed = null;
        private bool? __pbn__is_compressed;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CServerLobbyData_PlayerInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint account_id
        {
            get { return __pbn__account_id.GetValueOrDefault(); }
            set { __pbn__account_id = value; }
        }
        public bool ShouldSerializeaccount_id() => __pbn__account_id != null;
        public void Resetaccount_id() => __pbn__account_id = null;
        private uint? __pbn__account_id;

        [global::ProtoBuf.ProtoMember(2)]
        public uint mmr_level
        {
            get { return __pbn__mmr_level.GetValueOrDefault(); }
            set { __pbn__mmr_level = value; }
        }
        public bool ShouldSerializemmr_level() => __pbn__mmr_level != null;
        public void Resetmmr_level() => __pbn__mmr_level = null;
        private uint? __pbn__mmr_level;

        [global::ProtoBuf.ProtoMember(3)]
        public uint event_id
        {
            get { return __pbn__event_id.GetValueOrDefault(); }
            set { __pbn__event_id = value; }
        }
        public bool ShouldSerializeevent_id() => __pbn__event_id != null;
        public void Resetevent_id() => __pbn__event_id = null;
        private uint? __pbn__event_id;

        [global::ProtoBuf.ProtoMember(4)]
        public uint event_points
        {
            get { return __pbn__event_points.GetValueOrDefault(); }
            set { __pbn__event_points = value; }
        }
        public bool ShouldSerializeevent_points() => __pbn__event_points != null;
        public void Resetevent_points() => __pbn__event_points = null;
        private uint? __pbn__event_points;

        [global::ProtoBuf.ProtoMember(5)]
        public bool event_owned
        {
            get { return __pbn__event_owned.GetValueOrDefault(); }
            set { __pbn__event_owned = value; }
        }
        public bool ShouldSerializeevent_owned() => __pbn__event_owned != null;
        public void Resetevent_owned() => __pbn__event_owned = null;
        private bool? __pbn__event_owned;

        [global::ProtoBuf.ProtoMember(6)]
        public global::System.Collections.Generic.List<LoadoutSlot> loadout { get; } = new global::System.Collections.Generic.List<LoadoutSlot>();

        [global::ProtoBuf.ProtoMember(7)]
        public global::System.Collections.Generic.List<Achievement> achievements { get; } = new global::System.Collections.Generic.List<Achievement>();

        [global::ProtoBuf.ProtoMember(8)]
        public global::System.Collections.Generic.List<Challenge> challenges { get; } = new global::System.Collections.Generic.List<Challenge>();

        [global::ProtoBuf.ProtoContract()]
        public partial class LoadoutSlot : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public uint loadout_slot
            {
                get { return __pbn__loadout_slot.GetValueOrDefault(); }
                set { __pbn__loadout_slot = value; }
            }
            public bool ShouldSerializeloadout_slot() => __pbn__loadout_slot != null;
            public void Resetloadout_slot() => __pbn__loadout_slot = null;
            private uint? __pbn__loadout_slot;

            [global::ProtoBuf.ProtoMember(2)]
            public uint def_index
            {
                get { return __pbn__def_index.GetValueOrDefault(); }
                set { __pbn__def_index = value; }
            }
            public bool ShouldSerializedef_index() => __pbn__def_index != null;
            public void Resetdef_index() => __pbn__def_index = null;
            private uint? __pbn__def_index;

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class Achievement : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public uint achievement_id
            {
                get { return __pbn__achievement_id.GetValueOrDefault(); }
                set { __pbn__achievement_id = value; }
            }
            public bool ShouldSerializeachievement_id() => __pbn__achievement_id != null;
            public void Resetachievement_id() => __pbn__achievement_id = null;
            private uint? __pbn__achievement_id;

            [global::ProtoBuf.ProtoMember(2)]
            public uint progress
            {
                get { return __pbn__progress.GetValueOrDefault(); }
                set { __pbn__progress = value; }
            }
            public bool ShouldSerializeprogress() => __pbn__progress != null;
            public void Resetprogress() => __pbn__progress = null;
            private uint? __pbn__progress;

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class Challenge : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public uint challenge_id
            {
                get { return __pbn__challenge_id.GetValueOrDefault(); }
                set { __pbn__challenge_id = value; }
            }
            public bool ShouldSerializechallenge_id() => __pbn__challenge_id != null;
            public void Resetchallenge_id() => __pbn__challenge_id = null;
            private uint? __pbn__challenge_id;

            [global::ProtoBuf.ProtoMember(2)]
            public uint progress
            {
                get { return __pbn__progress.GetValueOrDefault(); }
                set { __pbn__progress = value; }
            }
            public bool ShouldSerializeprogress() => __pbn__progress != null;
            public void Resetprogress() => __pbn__progress = null;
            private uint? __pbn__progress;

            [global::ProtoBuf.ProtoMember(3)]
            public uint sequence_id
            {
                get { return __pbn__sequence_id.GetValueOrDefault(); }
                set { __pbn__sequence_id = value; }
            }
            public bool ShouldSerializesequence_id() => __pbn__sequence_id != null;
            public void Resetsequence_id() => __pbn__sequence_id = null;
            private uint? __pbn__sequence_id;

            [global::ProtoBuf.ProtoMember(4)]
            public uint slot_id
            {
                get { return __pbn__slot_id.GetValueOrDefault(); }
                set { __pbn__slot_id = value; }
            }
            public bool ShouldSerializeslot_id() => __pbn__slot_id != null;
            public void Resetslot_id() => __pbn__slot_id = null;
            private uint? __pbn__slot_id;

            [global::ProtoBuf.ProtoMember(5)]
            public uint config_id
            {
                get { return __pbn__config_id.GetValueOrDefault(); }
                set { __pbn__config_id = value; }
            }
            public bool ShouldSerializeconfig_id() => __pbn__config_id != null;
            public void Resetconfig_id() => __pbn__config_id = null;
            private uint? __pbn__config_id;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgRegionPingTimesClient : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, DataFormat = global::ProtoBuf.DataFormat.FixedSize, IsPacked = true)]
        public global::System.Collections.Generic.List<uint> data_center_codes { get; } = new global::System.Collections.Generic.List<uint>();

        [global::ProtoBuf.ProtoMember(2, IsPacked = true)]
        public global::System.Collections.Generic.List<uint> ping_times { get; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CSODACLobby : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint server_version
        {
            get { return __pbn__server_version.GetValueOrDefault(); }
            set { __pbn__server_version = value; }
        }
        public bool ShouldSerializeserver_version() => __pbn__server_version != null;
        public void Resetserver_version() => __pbn__server_version = null;
        private uint? __pbn__server_version;

        [global::ProtoBuf.ProtoMember(3, DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
        public ulong server_steam_id
        {
            get { return __pbn__server_steam_id.GetValueOrDefault(); }
            set { __pbn__server_steam_id = value; }
        }
        public bool ShouldSerializeserver_steam_id() => __pbn__server_steam_id != null;
        public void Resetserver_steam_id() => __pbn__server_steam_id = null;
        private ulong? __pbn__server_steam_id;

        [global::ProtoBuf.ProtoMember(5)]
        public ulong lobby_id
        {
            get { return __pbn__lobby_id.GetValueOrDefault(); }
            set { __pbn__lobby_id = value; }
        }
        public bool ShouldSerializelobby_id() => __pbn__lobby_id != null;
        public void Resetlobby_id() => __pbn__lobby_id = null;
        private ulong? __pbn__lobby_id;

        [global::ProtoBuf.ProtoMember(6)]
        public ulong match_id
        {
            get { return __pbn__match_id.GetValueOrDefault(); }
            set { __pbn__match_id = value; }
        }
        public bool ShouldSerializematch_id() => __pbn__match_id != null;
        public void Resetmatch_id() => __pbn__match_id = null;
        private ulong? __pbn__match_id;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(ELobbyServerState.k_eLobbyServerState_Assign)]
        public ELobbyServerState server_state
        {
            get { return __pbn__server_state ?? ELobbyServerState.k_eLobbyServerState_Assign; }
            set { __pbn__server_state = value; }
        }
        public bool ShouldSerializeserver_state() => __pbn__server_state != null;
        public void Resetserver_state() => __pbn__server_state = null;
        private ELobbyServerState? __pbn__server_state;

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue(EDACMatchMode.k_EDACMatchMode_Casual)]
        public EDACMatchMode match_mode
        {
            get { return __pbn__match_mode ?? EDACMatchMode.k_EDACMatchMode_Casual; }
            set { __pbn__match_mode = value; }
        }
        public bool ShouldSerializematch_mode() => __pbn__match_mode != null;
        public void Resetmatch_mode() => __pbn__match_mode = null;
        private EDACMatchMode? __pbn__match_mode;

        [global::ProtoBuf.ProtoMember(11)]
        public uint udp_connect_ip
        {
            get { return __pbn__udp_connect_ip.GetValueOrDefault(); }
            set { __pbn__udp_connect_ip = value; }
        }
        public bool ShouldSerializeudp_connect_ip() => __pbn__udp_connect_ip != null;
        public void Resetudp_connect_ip() => __pbn__udp_connect_ip = null;
        private uint? __pbn__udp_connect_ip;

        [global::ProtoBuf.ProtoMember(12)]
        public uint udp_connect_port
        {
            get { return __pbn__udp_connect_port.GetValueOrDefault(); }
            set { __pbn__udp_connect_port = value; }
        }
        public bool ShouldSerializeudp_connect_port() => __pbn__udp_connect_port != null;
        public void Resetudp_connect_port() => __pbn__udp_connect_port = null;
        private uint? __pbn__udp_connect_port;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CSODACParty : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong party_id
        {
            get { return __pbn__party_id.GetValueOrDefault(); }
            set { __pbn__party_id = value; }
        }
        public bool ShouldSerializeparty_id() => __pbn__party_id != null;
        public void Resetparty_id() => __pbn__party_id = null;
        private ulong? __pbn__party_id;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<Member> members { get; } = new global::System.Collections.Generic.List<Member>();

        [global::ProtoBuf.ProtoMember(3)]
        public global::System.Collections.Generic.List<Invite> invites { get; } = new global::System.Collections.Generic.List<Invite>();

        [global::ProtoBuf.ProtoMember(5)]
        public bool in_match_making
        {
            get { return __pbn__in_match_making.GetValueOrDefault(); }
            set { __pbn__in_match_making = value; }
        }
        public bool ShouldSerializein_match_making() => __pbn__in_match_making != null;
        public void Resetin_match_making() => __pbn__in_match_making = null;
        private bool? __pbn__in_match_making;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string party_password
        {
            get { return __pbn__party_password ?? ""; }
            set { __pbn__party_password = value; }
        }
        public bool ShouldSerializeparty_password() => __pbn__party_password != null;
        public void Resetparty_password() => __pbn__party_password = null;
        private string __pbn__party_password;

        [global::ProtoBuf.ProtoMember(8)]
        public uint min_client_version
        {
            get { return __pbn__min_client_version.GetValueOrDefault(); }
            set { __pbn__min_client_version = value; }
        }
        public bool ShouldSerializemin_client_version() => __pbn__min_client_version != null;
        public void Resetmin_client_version() => __pbn__min_client_version = null;
        private uint? __pbn__min_client_version;

        [global::ProtoBuf.ProtoMember(9)]
        public uint max_client_version
        {
            get { return __pbn__max_client_version.GetValueOrDefault(); }
            set { __pbn__max_client_version = value; }
        }
        public bool ShouldSerializemax_client_version() => __pbn__max_client_version != null;
        public void Resetmax_client_version() => __pbn__max_client_version = null;
        private uint? __pbn__max_client_version;

        [global::ProtoBuf.ProtoMember(10)]
        public global::System.Collections.Generic.List<LeftMember> left_members { get; } = new global::System.Collections.Generic.List<LeftMember>();

        [global::ProtoBuf.ProtoMember(11)]
        public ulong join_code
        {
            get { return __pbn__join_code.GetValueOrDefault(); }
            set { __pbn__join_code = value; }
        }
        public bool ShouldSerializejoin_code() => __pbn__join_code != null;
        public void Resetjoin_code() => __pbn__join_code = null;
        private ulong? __pbn__join_code;

        [global::ProtoBuf.ProtoMember(12)]
        [global::System.ComponentModel.DefaultValue(EBotDifficulty.k_eBotDifficulty_None)]
        public EBotDifficulty bot_difficulty
        {
            get { return __pbn__bot_difficulty ?? EBotDifficulty.k_eBotDifficulty_None; }
            set { __pbn__bot_difficulty = value; }
        }
        public bool ShouldSerializebot_difficulty() => __pbn__bot_difficulty != null;
        public void Resetbot_difficulty() => __pbn__bot_difficulty = null;
        private EBotDifficulty? __pbn__bot_difficulty;

        [global::ProtoBuf.ProtoContract()]
        public partial class Member : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public uint account_id
            {
                get { return __pbn__account_id.GetValueOrDefault(); }
                set { __pbn__account_id = value; }
            }
            public bool ShouldSerializeaccount_id() => __pbn__account_id != null;
            public void Resetaccount_id() => __pbn__account_id = null;
            private uint? __pbn__account_id;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue("")]
            public string persona_name
            {
                get { return __pbn__persona_name ?? ""; }
                set { __pbn__persona_name = value; }
            }
            public bool ShouldSerializepersona_name() => __pbn__persona_name != null;
            public void Resetpersona_name() => __pbn__persona_name = null;
            private string __pbn__persona_name;

            [global::ProtoBuf.ProtoMember(3)]
            public uint rights_flags
            {
                get { return __pbn__rights_flags.GetValueOrDefault(); }
                set { __pbn__rights_flags = value; }
            }
            public bool ShouldSerializerights_flags() => __pbn__rights_flags != null;
            public void Resetrights_flags() => __pbn__rights_flags = null;
            private uint? __pbn__rights_flags;

            [global::ProtoBuf.ProtoMember(4)]
            public bool is_ready
            {
                get { return __pbn__is_ready.GetValueOrDefault(); }
                set { __pbn__is_ready = value; }
            }
            public bool ShouldSerializeis_ready() => __pbn__is_ready != null;
            public void Resetis_ready() => __pbn__is_ready = null;
            private bool? __pbn__is_ready;

            [global::ProtoBuf.ProtoMember(5)]
            [global::System.ComponentModel.DefaultValue(CSODACParty.EPlayerType.k_ePlayerType_Player)]
            public CSODACParty.EPlayerType player_type
            {
                get { return __pbn__player_type ?? CSODACParty.EPlayerType.k_ePlayerType_Player; }
                set { __pbn__player_type = value; }
            }
            public bool ShouldSerializeplayer_type() => __pbn__player_type != null;
            public void Resetplayer_type() => __pbn__player_type = null;
            private CSODACParty.EPlayerType? __pbn__player_type;

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class LeftMember : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public uint account_id
            {
                get { return __pbn__account_id.GetValueOrDefault(); }
                set { __pbn__account_id = value; }
            }
            public bool ShouldSerializeaccount_id() => __pbn__account_id != null;
            public void Resetaccount_id() => __pbn__account_id = null;
            private uint? __pbn__account_id;

            [global::ProtoBuf.ProtoMember(2)]
            public uint rights_flags
            {
                get { return __pbn__rights_flags.GetValueOrDefault(); }
                set { __pbn__rights_flags = value; }
            }
            public bool ShouldSerializerights_flags() => __pbn__rights_flags != null;
            public void Resetrights_flags() => __pbn__rights_flags = null;
            private uint? __pbn__rights_flags;

            [global::ProtoBuf.ProtoMember(3)]
            [global::System.ComponentModel.DefaultValue(CSODACParty.EPlayerType.k_ePlayerType_Player)]
            public CSODACParty.EPlayerType player_type
            {
                get { return __pbn__player_type ?? CSODACParty.EPlayerType.k_ePlayerType_Player; }
                set { __pbn__player_type = value; }
            }
            public bool ShouldSerializeplayer_type() => __pbn__player_type != null;
            public void Resetplayer_type() => __pbn__player_type = null;
            private CSODACParty.EPlayerType? __pbn__player_type;

        }

        [global::ProtoBuf.ProtoContract()]
        public partial class Invite : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public uint account_id
            {
                get { return __pbn__account_id.GetValueOrDefault(); }
                set { __pbn__account_id = value; }
            }
            public bool ShouldSerializeaccount_id() => __pbn__account_id != null;
            public void Resetaccount_id() => __pbn__account_id = null;
            private uint? __pbn__account_id;

            [global::ProtoBuf.ProtoMember(2)]
            [global::System.ComponentModel.DefaultValue("")]
            public string persona_name
            {
                get { return __pbn__persona_name ?? ""; }
                set { __pbn__persona_name = value; }
            }
            public bool ShouldSerializepersona_name() => __pbn__persona_name != null;
            public void Resetpersona_name() => __pbn__persona_name = null;
            private string __pbn__persona_name;

            [global::ProtoBuf.ProtoMember(3)]
            public uint invited_by
            {
                get { return __pbn__invited_by.GetValueOrDefault(); }
                set { __pbn__invited_by = value; }
            }
            public bool ShouldSerializeinvited_by() => __pbn__invited_by != null;
            public void Resetinvited_by() => __pbn__invited_by = null;
            private uint? __pbn__invited_by;

        }

        [global::ProtoBuf.ProtoContract()]
        public enum EMemberRights
        {
            k_eMemberRights_Admin = 1,
            k_eMemberRights_Creator = 2,
        }

        [global::ProtoBuf.ProtoContract()]
        public enum EPlayerType
        {
            k_ePlayerType_Player = 0,
            k_ePlayerType_Spectator = 1,
        }

        [global::ProtoBuf.ProtoContract()]
        public enum EBotDifficulty
        {
            k_eBotDifficulty_None = 0,
            k_eBotDifficulty_Easy = 1,
            k_eBotDifficulty_Medium = 2,
            k_eBotDifficulty_Hard = 3,
            k_eBotDifficulty_Nightmare = 4,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CSOGameAccountClient : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint account_id
        {
            get { return __pbn__account_id.GetValueOrDefault(); }
            set { __pbn__account_id = value; }
        }
        public bool ShouldSerializeaccount_id() => __pbn__account_id != null;
        public void Resetaccount_id() => __pbn__account_id = null;
        private uint? __pbn__account_id;

        [global::ProtoBuf.ProtoMember(2)]
        public uint mmr_level
        {
            get { return __pbn__mmr_level.GetValueOrDefault(); }
            set { __pbn__mmr_level = value; }
        }
        public bool ShouldSerializemmr_level() => __pbn__mmr_level != null;
        public void Resetmmr_level() => __pbn__mmr_level = null;
        private uint? __pbn__mmr_level;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgStartFindingMatchInfo : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2)]
        public uint client_version
        {
            get { return __pbn__client_version.GetValueOrDefault(); }
            set { __pbn__client_version = value; }
        }
        public bool ShouldSerializeclient_version() => __pbn__client_version != null;
        public void Resetclient_version() => __pbn__client_version = null;
        private uint? __pbn__client_version;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(EDACMatchMode.k_EDACMatchMode_Casual)]
        public EDACMatchMode match_mode
        {
            get { return __pbn__match_mode ?? EDACMatchMode.k_EDACMatchMode_Casual; }
            set { __pbn__match_mode = value; }
        }
        public bool ShouldSerializematch_mode() => __pbn__match_mode != null;
        public void Resetmatch_mode() => __pbn__match_mode = null;
        private EDACMatchMode? __pbn__match_mode;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(EDACPlatform.k_eDACPlatform_None)]
        public EDACPlatform platform
        {
            get { return __pbn__platform ?? EDACPlatform.k_eDACPlatform_None; }
            set { __pbn__platform = value; }
        }
        public bool ShouldSerializeplatform() => __pbn__platform != null;
        public void Resetplatform() => __pbn__platform = null;
        private EDACPlatform? __pbn__platform;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgAnyToGCReportAsserts : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint version
        {
            get { return __pbn__version.GetValueOrDefault(); }
            set { __pbn__version = value; }
        }
        public bool ShouldSerializeversion() => __pbn__version != null;
        public void Resetversion() => __pbn__version = null;
        private uint? __pbn__version;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<TrackedAssert> asserts { get; } = new global::System.Collections.Generic.List<TrackedAssert>();

        [global::ProtoBuf.ProtoContract()]
        public partial class TrackedAssert : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            [global::System.ComponentModel.DefaultValue("")]
            public string filename
            {
                get { return __pbn__filename ?? ""; }
                set { __pbn__filename = value; }
            }
            public bool ShouldSerializefilename() => __pbn__filename != null;
            public void Resetfilename() => __pbn__filename = null;
            private string __pbn__filename;

            [global::ProtoBuf.ProtoMember(2)]
            public uint line_number
            {
                get { return __pbn__line_number.GetValueOrDefault(); }
                set { __pbn__line_number = value; }
            }
            public bool ShouldSerializeline_number() => __pbn__line_number != null;
            public void Resetline_number() => __pbn__line_number = null;
            private uint? __pbn__line_number;

            [global::ProtoBuf.ProtoMember(3)]
            [global::System.ComponentModel.DefaultValue("")]
            public string sample_msg
            {
                get { return __pbn__sample_msg ?? ""; }
                set { __pbn__sample_msg = value; }
            }
            public bool ShouldSerializesample_msg() => __pbn__sample_msg != null;
            public void Resetsample_msg() => __pbn__sample_msg = null;
            private string __pbn__sample_msg;

            [global::ProtoBuf.ProtoMember(4)]
            [global::System.ComponentModel.DefaultValue("")]
            public string sample_stack
            {
                get { return __pbn__sample_stack ?? ""; }
                set { __pbn__sample_stack = value; }
            }
            public bool ShouldSerializesample_stack() => __pbn__sample_stack != null;
            public void Resetsample_stack() => __pbn__sample_stack = null;
            private string __pbn__sample_stack;

            [global::ProtoBuf.ProtoMember(5)]
            public uint times_fired
            {
                get { return __pbn__times_fired.GetValueOrDefault(); }
                set { __pbn__times_fired = value; }
            }
            public bool ShouldSerializetimes_fired() => __pbn__times_fired != null;
            public void Resettimes_fired() => __pbn__times_fired = null;
            private uint? __pbn__times_fired;

            [global::ProtoBuf.ProtoMember(6)]
            [global::System.ComponentModel.DefaultValue("")]
            public string function_name
            {
                get { return __pbn__function_name ?? ""; }
                set { __pbn__function_name = value; }
            }
            public bool ShouldSerializefunction_name() => __pbn__function_name != null;
            public void Resetfunction_name() => __pbn__function_name = null;
            private string __pbn__function_name;

            [global::ProtoBuf.ProtoMember(7)]
            [global::System.ComponentModel.DefaultValue("")]
            public string condition
            {
                get { return __pbn__condition ?? ""; }
                set { __pbn__condition = value; }
            }
            public bool ShouldSerializecondition() => __pbn__condition != null;
            public void Resetcondition() => __pbn__condition = null;
            private string __pbn__condition;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CMsgAnyToGCReportAssertsResponse : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public bool success
        {
            get { return __pbn__success.GetValueOrDefault(); }
            set { __pbn__success = value; }
        }
        public bool ShouldSerializesuccess() => __pbn__success != null;
        public void Resetsuccess() => __pbn__success = null;
        private bool? __pbn__success;

    }

    [global::ProtoBuf.ProtoContract()]
    public enum EGCDACCommonMessages
    {
        k_EMsgAnyToGCReportAsserts = 7000,
        k_EMsgAnyToGCReportAssertsResponse = 7001,
        k_EMsgGCItemEditorReservationsRequest = 7283,
        k_EMsgGCItemEditorReservationsResponse = 7284,
        k_EMsgGCItemEditorReserveItemDef = 7285,
        k_EMsgGCItemEditorReserveItemDefResponse = 7286,
        k_EMsgGCItemEditorReleaseReservation = 7287,
        k_EMsgGCItemEditorReleaseReservationResponse = 7288,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EDACMatchMode
    {
        k_EDACMatchMode_Casual = 1,
        k_EDACMatchMode_PrivateLobby = 2,
        k_EDACMatchMode_SoloBot = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EDACPlatform
    {
        k_eDACPlatform_None = 0,
        k_eDACPlatform_PC = 1,
        k_eDACPlatform_Mac = 2,
        k_eDACPlatform_Linux = 3,
        k_eDACPlatform_Android = 4,
        k_eDACPlatform_iOS = 5,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EDACLobbyTeam
    {
        k_EDACLobbyTeam_Team0 = 0,
        k_EDACLobbyTeam_Team1 = 1,
        k_EDACLobbyTeam_Team2 = 2,
        k_EDACLobbyTeam_Team3 = 3,
        k_EDACLobbyTeam_Team4 = 4,
        k_EDACLobbyTeam_Team5 = 5,
        k_EDACLobbyTeam_Team6 = 6,
        k_EDACLobbyTeam_Team7 = 7,
        k_EDACLobbyTeam_Spectator = 250,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EDACAIType
    {
        k_EDACAIType_Invalid = 0,
        k_EDACAIType_Lvl1 = 1,
        k_EDACAIType_Lvl2 = 2,
        k_EDACAIType_Lvl3 = 3,
        k_EDACAIType_Lvl4 = 4,
        k_EDACAIType_Lvl5 = 5,
        k_EDACAIType_Lvl6 = 6,
        k_EDACAIType_Lvl7 = 7,
        k_EDACAIType_Lvl8 = 8,
        k_EDACAIType_PB0 = 20,
        k_EDACAIType_PB1 = 21,
        k_EDACAIType_PB2 = 22,
        k_EDACAIType_PB3 = 23,
        k_EDACAIType_PB4 = 24,
        k_EDACAIType_PB5 = 25,
        k_EDACAIType_PB6 = 26,
        k_EDACAIType_PB7 = 27,
        k_EDACAIType_PB8 = 28,
        k_EDACAIType_PB9 = 29,
        k_EDACAIType_PB10 = 30,
        k_EDACAIType_PB11 = 31,
        k_EDACAIType_PB12 = 32,
        k_EDACAIType_PB13 = 33,
        k_EDACAIType_PB14 = 34,
        k_EDACAIType_PB15 = 35,
        k_EDACAIType_PB16 = 36,
        k_EDACAIType_PB17 = 37,
        k_EDACAIType_PB18 = 38,
        k_EDACAIType_PB19 = 39,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EDACMatchState
    {
        k_EMatchState_InProgress = 0,
        k_EMatchState_Completed = 1,
        k_EMatchState_Failed_NetworkIssues = 2,
        k_EMatchState_Failed_ServerCrash = 3,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum EDACPlayerState
    {
        k_EPlayerState_Playing = 0,
        k_EPlayerState_Eliminated = 1,
        k_EPlayerState_Abandoned = 2,
        k_EPlayerState_Disconnected = 3,
        k_EPlayerState_ServerCrashed = 4,
    }

    [global::ProtoBuf.ProtoContract()]
    public enum ELobbyServerState
    {
        k_eLobbyServerState_Assign = 0,
        k_eLobbyServerState_InGame = 1,
        k_eLobbyServerState_PostMatch = 2,
        k_eLobbyServerState_SignedOut = 3,
        k_eLobbyServerState_Abandoned = 4,
    }

}

#pragma warning restore CS0612, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
