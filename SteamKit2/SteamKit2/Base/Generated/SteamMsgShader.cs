// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: steammessages_shader.steamclient.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace SteamKit2.Internal
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CShader_RegisterShader_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string gpu_desc
        {
            get => __pbn__gpu_desc ?? "";
            set => __pbn__gpu_desc = value;
        }
        public bool ShouldSerializegpu_desc() => __pbn__gpu_desc != null;
        public void Resetgpu_desc() => __pbn__gpu_desc = null;
        private string __pbn__gpu_desc;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string driver_desc
        {
            get => __pbn__driver_desc ?? "";
            set => __pbn__driver_desc = value;
        }
        public bool ShouldSerializedriver_desc() => __pbn__driver_desc != null;
        public void Resetdriver_desc() => __pbn__driver_desc = null;
        private string __pbn__driver_desc;

        [global::ProtoBuf.ProtoMember(4)]
        public global::System.Collections.Generic.List<Shader> shaders { get; } = new global::System.Collections.Generic.List<Shader>();

        [global::ProtoBuf.ProtoContract()]
        public partial class Shader : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public byte[] cache_key_sha
            {
                get => __pbn__cache_key_sha;
                set => __pbn__cache_key_sha = value;
            }
            public bool ShouldSerializecache_key_sha() => __pbn__cache_key_sha != null;
            public void Resetcache_key_sha() => __pbn__cache_key_sha = null;
            private byte[] __pbn__cache_key_sha;

            [global::ProtoBuf.ProtoMember(2)]
            public byte[] shader_code_sha
            {
                get => __pbn__shader_code_sha;
                set => __pbn__shader_code_sha = value;
            }
            public bool ShouldSerializeshader_code_sha() => __pbn__shader_code_sha != null;
            public void Resetshader_code_sha() => __pbn__shader_code_sha = null;
            private byte[] __pbn__shader_code_sha;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CShader_RegisterShader_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public global::System.Collections.Generic.List<uint> requested_codeids { get; } = new global::System.Collections.Generic.List<uint>();

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CShader_SendShader_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        public global::System.Collections.Generic.List<ShaderCode> shaders { get; } = new global::System.Collections.Generic.List<ShaderCode>();

        [global::ProtoBuf.ProtoContract()]
        public partial class ShaderCode : global::ProtoBuf.IExtensible
        {
            private global::ProtoBuf.IExtension __pbn__extensionData;
            global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
                => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

            [global::ProtoBuf.ProtoMember(1)]
            public byte[] shader_code_sha
            {
                get => __pbn__shader_code_sha;
                set => __pbn__shader_code_sha = value;
            }
            public bool ShouldSerializeshader_code_sha() => __pbn__shader_code_sha != null;
            public void Resetshader_code_sha() => __pbn__shader_code_sha = null;
            private byte[] __pbn__shader_code_sha;

            [global::ProtoBuf.ProtoMember(2)]
            public byte[] shader_code
            {
                get => __pbn__shader_code;
                set => __pbn__shader_code = value;
            }
            public bool ShouldSerializeshader_code() => __pbn__shader_code != null;
            public void Resetshader_code() => __pbn__shader_code = null;
            private byte[] __pbn__shader_code;

        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CShader_SendShader_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CShader_GetBucketManifest_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string gpu_desc
        {
            get => __pbn__gpu_desc ?? "";
            set => __pbn__gpu_desc = value;
        }
        public bool ShouldSerializegpu_desc() => __pbn__gpu_desc != null;
        public void Resetgpu_desc() => __pbn__gpu_desc = null;
        private string __pbn__gpu_desc;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string driver_desc
        {
            get => __pbn__driver_desc ?? "";
            set => __pbn__driver_desc = value;
        }
        public bool ShouldSerializedriver_desc() => __pbn__driver_desc != null;
        public void Resetdriver_desc() => __pbn__driver_desc = null;
        private string __pbn__driver_desc;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CShader_GetBucketManifest_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong manifestid
        {
            get => __pbn__manifestid.GetValueOrDefault();
            set => __pbn__manifestid = value;
        }
        public bool ShouldSerializemanifestid() => __pbn__manifestid != null;
        public void Resetmanifestid() => __pbn__manifestid = null;
        private ulong? __pbn__manifestid;

        [global::ProtoBuf.ProtoMember(2)]
        public ulong depotsize
        {
            get => __pbn__depotsize.GetValueOrDefault();
            set => __pbn__depotsize = value;
        }
        public bool ShouldSerializedepotsize() => __pbn__depotsize != null;
        public void Resetdepotsize() => __pbn__depotsize = null;
        private ulong? __pbn__depotsize;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong bucketid
        {
            get => __pbn__bucketid.GetValueOrDefault();
            set => __pbn__bucketid = value;
        }
        public bool ShouldSerializebucketid() => __pbn__bucketid != null;
        public void Resetbucketid() => __pbn__bucketid = null;
        private ulong? __pbn__bucketid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CShader_GetStaleBucket_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string gpu_desc
        {
            get => __pbn__gpu_desc ?? "";
            set => __pbn__gpu_desc = value;
        }
        public bool ShouldSerializegpu_desc() => __pbn__gpu_desc != null;
        public void Resetgpu_desc() => __pbn__gpu_desc = null;
        private string __pbn__gpu_desc;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string driver_desc
        {
            get => __pbn__driver_desc ?? "";
            set => __pbn__driver_desc = value;
        }
        public bool ShouldSerializedriver_desc() => __pbn__driver_desc != null;
        public void Resetdriver_desc() => __pbn__driver_desc = null;
        private string __pbn__driver_desc;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CShader_GetStaleBucket_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public ulong bucketid
        {
            get => __pbn__bucketid.GetValueOrDefault();
            set => __pbn__bucketid = value;
        }
        public bool ShouldSerializebucketid() => __pbn__bucketid != null;
        public void Resetbucketid() => __pbn__bucketid = null;
        private ulong? __pbn__bucketid;

        [global::ProtoBuf.ProtoMember(2)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(3)]
        public ulong manifestid
        {
            get => __pbn__manifestid.GetValueOrDefault();
            set => __pbn__manifestid = value;
        }
        public bool ShouldSerializemanifestid() => __pbn__manifestid != null;
        public void Resetmanifestid() => __pbn__manifestid = null;
        private ulong? __pbn__manifestid;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CShader_ReportExternalBuild_Request : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1)]
        public uint appid
        {
            get => __pbn__appid.GetValueOrDefault();
            set => __pbn__appid = value;
        }
        public bool ShouldSerializeappid() => __pbn__appid != null;
        public void Resetappid() => __pbn__appid = null;
        private uint? __pbn__appid;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string gpu_desc
        {
            get => __pbn__gpu_desc ?? "";
            set => __pbn__gpu_desc = value;
        }
        public bool ShouldSerializegpu_desc() => __pbn__gpu_desc != null;
        public void Resetgpu_desc() => __pbn__gpu_desc = null;
        private string __pbn__gpu_desc;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string driver_desc
        {
            get => __pbn__driver_desc ?? "";
            set => __pbn__driver_desc = value;
        }
        public bool ShouldSerializedriver_desc() => __pbn__driver_desc != null;
        public void Resetdriver_desc() => __pbn__driver_desc = null;
        private string __pbn__driver_desc;

        [global::ProtoBuf.ProtoMember(4)]
        public ulong manifestid
        {
            get => __pbn__manifestid.GetValueOrDefault();
            set => __pbn__manifestid = value;
        }
        public bool ShouldSerializemanifestid() => __pbn__manifestid != null;
        public void Resetmanifestid() => __pbn__manifestid = null;
        private ulong? __pbn__manifestid;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string source_gpu_desc
        {
            get => __pbn__source_gpu_desc ?? "";
            set => __pbn__source_gpu_desc = value;
        }
        public bool ShouldSerializesource_gpu_desc() => __pbn__source_gpu_desc != null;
        public void Resetsource_gpu_desc() => __pbn__source_gpu_desc = null;
        private string __pbn__source_gpu_desc;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue("")]
        public string source_driver_desc
        {
            get => __pbn__source_driver_desc ?? "";
            set => __pbn__source_driver_desc = value;
        }
        public bool ShouldSerializesource_driver_desc() => __pbn__source_driver_desc != null;
        public void Resetsource_driver_desc() => __pbn__source_driver_desc = null;
        private string __pbn__source_driver_desc;

        [global::ProtoBuf.ProtoMember(7)]
        public ulong depotsize
        {
            get => __pbn__depotsize.GetValueOrDefault();
            set => __pbn__depotsize = value;
        }
        public bool ShouldSerializedepotsize() => __pbn__depotsize != null;
        public void Resetdepotsize() => __pbn__depotsize = null;
        private ulong? __pbn__depotsize;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CShader_ReportExternalBuild_Response : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    }

    public interface IShader
    {
        CShader_RegisterShader_Response RegisterShader(CShader_RegisterShader_Request request);
        CShader_SendShader_Response SendShader(CShader_SendShader_Request request);
        CShader_GetBucketManifest_Response GetBucketManifest(CShader_GetBucketManifest_Request request);
        CShader_GetStaleBucket_Response GetStaleBucket(CShader_GetStaleBucket_Request request);
        CShader_ReportExternalBuild_Response ReportExternalBuild(CShader_ReportExternalBuild_Request request);
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
