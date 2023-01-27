// <auto-generated />
#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

// NOTE: Disable warnings for nullable reference types.
// `#nullable disable` causes compile error on old C# compilers (-7.3)
#pragma warning disable 8603 // Possible null reference return.
#pragma warning disable 8618 // Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
#pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type.

namespace MagicOnion
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::MagicOnion;
    using global::MagicOnion.Client;

    public static partial class MagicOnionInitializer
    {
        static bool isRegistered = false;

#if UNITY_2019_4_OR_NEWER
        [UnityEngine.RuntimeInitializeOnLoadMethod(UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad)]
#elif NET5_0_OR_GREATER
        [System.Runtime.CompilerServices.ModuleInitializer]
#endif
        public static void Register()
        {
            if (isRegistered) return;
            isRegistered = true;

            global::MagicOnion.Client.MagicOnionClientFactoryProvider.Default =
                (global::MagicOnion.Client.MagicOnionClientFactoryProvider.Default is global::MagicOnion.Client.ImmutableMagicOnionClientFactoryProvider immutableMagicOnionClientFactoryProvider)
                    ? immutableMagicOnionClientFactoryProvider.Add(MagicOnionGeneratedClientFactoryProvider.Instance)
                    : new global::MagicOnion.Client.ImmutableMagicOnionClientFactoryProvider(MagicOnionGeneratedClientFactoryProvider.Instance);

            global::MagicOnion.Client.StreamingHubClientFactoryProvider.Default =
                (global::MagicOnion.Client.StreamingHubClientFactoryProvider.Default is global::MagicOnion.Client.ImmutableStreamingHubClientFactoryProvider immutableStreamingHubClientFactoryProvider)
                    ? immutableStreamingHubClientFactoryProvider.Add(MagicOnionGeneratedClientFactoryProvider.Instance)
                    : new global::MagicOnion.Client.ImmutableStreamingHubClientFactoryProvider(MagicOnionGeneratedClientFactoryProvider.Instance);
        }
    }

    public partial class MagicOnionGeneratedClientFactoryProvider : global::MagicOnion.Client.IMagicOnionClientFactoryProvider, global::MagicOnion.Client.IStreamingHubClientFactoryProvider
    {
        public static MagicOnionGeneratedClientFactoryProvider Instance { get; } = new MagicOnionGeneratedClientFactoryProvider();

        MagicOnionGeneratedClientFactoryProvider() {}

        bool global::MagicOnion.Client.IMagicOnionClientFactoryProvider.TryGetFactory<T>(out global::MagicOnion.Client.MagicOnionClientFactoryDelegate<T> factory)
            => (factory = MagicOnionClientFactoryCache<T>.Factory) != null;

        bool global::MagicOnion.Client.IStreamingHubClientFactoryProvider.TryGetFactory<TStreamingHub, TReceiver>(out global::MagicOnion.Client.StreamingHubClientFactoryDelegate<TStreamingHub, TReceiver> factory)
            => (factory = StreamingHubClientFactoryCache<TStreamingHub, TReceiver>.Factory) != null;

        static class MagicOnionClientFactoryCache<T> where T : global::MagicOnion.IService<T>
        {
            public readonly static global::MagicOnion.Client.MagicOnionClientFactoryDelegate<T> Factory;

            static MagicOnionClientFactoryCache()
            {
                object factory = default(global::MagicOnion.Client.MagicOnionClientFactoryDelegate<T>);

                if (typeof(T) == typeof(global::Jane.Unity.ServerShared.Services.IChatService))
                {
                    factory = ((global::MagicOnion.Client.MagicOnionClientFactoryDelegate<global::Jane.Unity.ServerShared.Services.IChatService>)((x, y) => new Jane.Unity.ServerShared.Services.ChatServiceClient(x, y)));
                }
                Factory = (global::MagicOnion.Client.MagicOnionClientFactoryDelegate<T>)factory;
            }
        }
        
        static class StreamingHubClientFactoryCache<TStreamingHub, TReceiver> where TStreamingHub : global::MagicOnion.IStreamingHub<TStreamingHub, TReceiver>
        {
            public readonly static global::MagicOnion.Client.StreamingHubClientFactoryDelegate<TStreamingHub, TReceiver> Factory;

            static StreamingHubClientFactoryCache()
            {
                object factory = default(global::MagicOnion.Client.StreamingHubClientFactoryDelegate<TStreamingHub, TReceiver>);

                if (typeof(TStreamingHub) == typeof(global::Jane.Unity.ServerShared.Hubs.IChatHub) && typeof(TReceiver) == typeof(global::Jane.Unity.ServerShared.Hubs.IChatHubReceiver))
                {
                    factory = ((global::MagicOnion.Client.StreamingHubClientFactoryDelegate<global::Jane.Unity.ServerShared.Hubs.IChatHub, global::Jane.Unity.ServerShared.Hubs.IChatHubReceiver>)((a, _, b, c, d, e) => new Jane.Unity.ServerShared.Hubs.ChatHubClient(a, b, c, d, e)));
                }

                Factory = (global::MagicOnion.Client.StreamingHubClientFactoryDelegate<TStreamingHub, TReceiver>)factory;
            }
        }
    }

}

#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 612
#pragma warning restore 618

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

// NOTE: Disable warnings for nullable reference types.
// `#nullable disable` causes compile error on old C# compilers (-7.3)
#pragma warning disable 8603 // Possible null reference return.
#pragma warning disable 8618 // Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
#pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type.
namespace MagicOnion
{
    using global::System;
    using global::MemoryPack;
    public class MagicOnionMemoryPackFormatterProvider
    {
        public static void RegisterFormatters()
        {
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MagicOnion.Serialization.MemoryPack.DynamicArgumentTupleFormatter<global::System.Collections.Generic.List<global::System.Int32>, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String>>());
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MemoryPack.Formatters.DictionaryFormatter<global::System.Int32, global::System.String>());
            global::MemoryPack.MemoryPackFormatterProvider.Register(new global::MemoryPack.Formatters.ListFormatter<global::System.Int32>());
        }
    }
}
#pragma warning restore 168
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 612
#pragma warning restore 618

#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

// NOTE: Disable warnings for nullable reference types.
// `#nullable disable` causes compile error on old C# compilers (-7.3)
#pragma warning disable 8603 // Possible null reference return.
#pragma warning disable 8618 // Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
#pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type.

namespace Jane.Unity.ServerShared.Services
{
    using global::System;
    using global::Grpc.Core;
    using global::MagicOnion;
    using global::MagicOnion.Client;
    using global::MessagePack;
    
    [global::MagicOnion.Ignore]
    public class ChatServiceClient : global::MagicOnion.Client.MagicOnionClientBase<global::Jane.Unity.ServerShared.Services.IChatService>, global::Jane.Unity.ServerShared.Services.IChatService
    {
        class ClientCore
        {
            public global::MagicOnion.Client.Internal.RawMethodInvoker<global::System.String, global::MessagePack.Nil> GenerateException;
            public global::MagicOnion.Client.Internal.RawMethodInvoker<global::System.String, global::MessagePack.Nil> SendReportAsync;
            public ClientCore(global::MagicOnion.Serialization.IMagicOnionSerializerProvider serializerProvider)
            {
                this.GenerateException = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_RefType_ValueType<global::System.String, global::MessagePack.Nil>(global::Grpc.Core.MethodType.Unary, "IChatService", "GenerateException", serializerProvider);
                this.SendReportAsync = global::MagicOnion.Client.Internal.RawMethodInvoker.Create_RefType_ValueType<global::System.String, global::MessagePack.Nil>(global::Grpc.Core.MethodType.Unary, "IChatService", "SendReportAsync", serializerProvider);
            }
        }
        
        readonly ClientCore core;
        
        public ChatServiceClient(global::MagicOnion.Client.MagicOnionClientOptions options, global::MagicOnion.Serialization.IMagicOnionSerializerProvider serializerProvider) : base(options)
        {
            this.core = new ClientCore(serializerProvider);
        }
        
        private ChatServiceClient(MagicOnionClientOptions options, ClientCore core) : base(options)
        {
            this.core = core;
        }
        
        protected override global::MagicOnion.Client.MagicOnionClientBase<IChatService> Clone(global::MagicOnion.Client.MagicOnionClientOptions options)
            => new ChatServiceClient(options, core);
        
        public global::MagicOnion.UnaryResult GenerateException(global::System.String message)
            => this.core.GenerateException.InvokeUnaryNonGeneric(this, "IChatService/GenerateException", message);
        public global::MagicOnion.UnaryResult SendReportAsync(global::System.String message)
            => this.core.SendReportAsync.InvokeUnaryNonGeneric(this, "IChatService/SendReportAsync", message);
    }
}


#pragma warning disable 618
#pragma warning disable 612
#pragma warning disable 414
#pragma warning disable 219
#pragma warning disable 168

// NOTE: Disable warnings for nullable reference types.
// `#nullable disable` causes compile error on old C# compilers (-7.3)
#pragma warning disable 8603 // Possible null reference return.
#pragma warning disable 8618 // Non-nullable variable must contain a non-null value when exiting constructor. Consider declaring it as nullable.
#pragma warning disable 8625 // Cannot convert null literal to non-nullable reference type.

namespace Jane.Unity.ServerShared.Hubs
{
    using global::System;
    using global::Grpc.Core;
    using global::MagicOnion;
    using global::MagicOnion.Client;
    using global::MessagePack;
    
    [global::MagicOnion.Ignore]
    public class ChatHubClient : global::MagicOnion.Client.StreamingHubClientBase<global::Jane.Unity.ServerShared.Hubs.IChatHub, global::Jane.Unity.ServerShared.Hubs.IChatHubReceiver>, global::Jane.Unity.ServerShared.Hubs.IChatHub
    {
        protected override global::Grpc.Core.Method<global::System.Byte[], global::System.Byte[]> DuplexStreamingAsyncMethod { get; }
        
        public ChatHubClient(global::Grpc.Core.CallInvoker callInvoker, global::System.String host, global::Grpc.Core.CallOptions options, global::MagicOnion.Serialization.IMagicOnionSerializerProvider serializerProvider, global::MagicOnion.Client.IMagicOnionClientLogger logger)
            : base(callInvoker, host, options, serializerProvider, logger)
        {
            var marshaller = global::MagicOnion.MagicOnionMarshallers.ThroughMarshaller;
            DuplexStreamingAsyncMethod = new global::Grpc.Core.Method<global::System.Byte[], global::System.Byte[]>(global::Grpc.Core.MethodType.DuplexStreaming, "IChatHub", "Connect", marshaller, marshaller);
        }
        
        public global::System.Threading.Tasks.ValueTask JoinAsync(global::Jane.Unity.ServerShared.MemoryPackObjects.JoinRequest request)
            => new global::System.Threading.Tasks.ValueTask(base.WriteMessageWithResponseAsync<global::Jane.Unity.ServerShared.MemoryPackObjects.JoinRequest, global::MessagePack.Nil>(-733403293, request));
        public global::System.Threading.Tasks.ValueTask LeaveAsync()
            => new global::System.Threading.Tasks.ValueTask(base.WriteMessageWithResponseAsync<global::MessagePack.Nil, global::MessagePack.Nil>(1368362116, global::MessagePack.Nil.Default));
        public global::System.Threading.Tasks.ValueTask SendMessageAsync(global::System.String message)
            => new global::System.Threading.Tasks.ValueTask(base.WriteMessageWithResponseAsync<global::System.String, global::MessagePack.Nil>(-601690414, message));
        public global::System.Threading.Tasks.ValueTask GenerateException(global::System.String message)
            => new global::System.Threading.Tasks.ValueTask(base.WriteMessageWithResponseAsync<global::System.String, global::MessagePack.Nil>(517938971, message));
        public global::System.Threading.Tasks.ValueTask SampleMethod(global::System.Collections.Generic.List<global::System.Int32> sampleList, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String> sampleDictionary)
            => new global::System.Threading.Tasks.ValueTask(base.WriteMessageWithResponseAsync<global::MagicOnion.DynamicArgumentTuple<global::System.Collections.Generic.List<global::System.Int32>, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String>>, global::MessagePack.Nil>(-852153394, new global::MagicOnion.DynamicArgumentTuple<global::System.Collections.Generic.List<global::System.Int32>, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String>>(sampleList, sampleDictionary)));
        
        public global::Jane.Unity.ServerShared.Hubs.IChatHub FireAndForget()
            => new FireAndForgetClient(this);
        
        [global::MagicOnion.Ignore]
        class FireAndForgetClient : global::Jane.Unity.ServerShared.Hubs.IChatHub
        {
            readonly ChatHubClient parent;
        
            public FireAndForgetClient(ChatHubClient parent)
                => this.parent = parent;
        
            public global::Jane.Unity.ServerShared.Hubs.IChatHub FireAndForget() => this;
            public global::System.Threading.Tasks.Task DisposeAsync() => throw new global::System.NotSupportedException();
            public global::System.Threading.Tasks.Task WaitForDisconnect() => throw new global::System.NotSupportedException();
        
            public global::System.Threading.Tasks.ValueTask JoinAsync(global::Jane.Unity.ServerShared.MemoryPackObjects.JoinRequest request)
                => new global::System.Threading.Tasks.ValueTask(parent.WriteMessageFireAndForgetAsync<global::Jane.Unity.ServerShared.MemoryPackObjects.JoinRequest, global::MessagePack.Nil>(-733403293, request));
            public global::System.Threading.Tasks.ValueTask LeaveAsync()
                => new global::System.Threading.Tasks.ValueTask(parent.WriteMessageFireAndForgetAsync<global::MessagePack.Nil, global::MessagePack.Nil>(1368362116, global::MessagePack.Nil.Default));
            public global::System.Threading.Tasks.ValueTask SendMessageAsync(global::System.String message)
                => new global::System.Threading.Tasks.ValueTask(parent.WriteMessageFireAndForgetAsync<global::System.String, global::MessagePack.Nil>(-601690414, message));
            public global::System.Threading.Tasks.ValueTask GenerateException(global::System.String message)
                => new global::System.Threading.Tasks.ValueTask(parent.WriteMessageFireAndForgetAsync<global::System.String, global::MessagePack.Nil>(517938971, message));
            public global::System.Threading.Tasks.ValueTask SampleMethod(global::System.Collections.Generic.List<global::System.Int32> sampleList, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String> sampleDictionary)
                => new global::System.Threading.Tasks.ValueTask(parent.WriteMessageFireAndForgetAsync<global::MagicOnion.DynamicArgumentTuple<global::System.Collections.Generic.List<global::System.Int32>, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String>>, global::MessagePack.Nil>(-852153394, new global::MagicOnion.DynamicArgumentTuple<global::System.Collections.Generic.List<global::System.Int32>, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String>>(sampleList, sampleDictionary)));
            
        }
        
        protected override void OnBroadcastEvent(global::System.Int32 methodId, global::System.ArraySegment<global::System.Byte> data)
        {
            switch (methodId)
            {
                case -1297457280: // Void OnJoin(global::System.String userName)
                    {
                        var value = base.Deserialize<global::System.String>(data);
                        receiver.OnJoin(value);
                    }
                    break;
                case 532410095: // Void OnLeave(global::System.String userName)
                    {
                        var value = base.Deserialize<global::System.String>(data);
                        receiver.OnLeave(value);
                    }
                    break;
                case -552695459: // Void OnSendMessage(global::Jane.Unity.ServerShared.MemoryPackObjects.MessageResponse message)
                    {
                        var value = base.Deserialize<global::Jane.Unity.ServerShared.MemoryPackObjects.MessageResponse>(data);
                        receiver.OnSendMessage(value);
                    }
                    break;
            }
        }
        
        protected override void OnResponseEvent(global::System.Int32 methodId, global::System.Object taskCompletionSource, global::System.ArraySegment<global::System.Byte> data)
        {
            switch (methodId)
            {
                case -733403293: // ValueTask JoinAsync(global::Jane.Unity.ServerShared.MemoryPackObjects.JoinRequest request)
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
                case 1368362116: // ValueTask LeaveAsync()
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
                case -601690414: // ValueTask SendMessageAsync(global::System.String message)
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
                case 517938971: // ValueTask GenerateException(global::System.String message)
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
                case -852153394: // ValueTask SampleMethod(global::System.Collections.Generic.List<global::System.Int32> sampleList, global::System.Collections.Generic.Dictionary<global::System.Int32, global::System.String> sampleDictionary)
                    base.SetResultForResponse<global::MessagePack.Nil>(taskCompletionSource, data);
                    break;
            }
        }
        
    }
}


