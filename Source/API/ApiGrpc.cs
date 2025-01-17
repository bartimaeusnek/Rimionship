// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/api.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace RimionshipServer.API {
  public static partial class API
  {
    static readonly string __ServiceName = "api.API";

    static readonly grpc::Marshaller<global::RimionshipServer.API.HelloRequest> __Marshaller_api_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.HelloRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RimionshipServer.API.HelloResponse> __Marshaller_api_HelloResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.HelloResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RimionshipServer.API.LoginRequest> __Marshaller_api_LoginRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.LoginRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RimionshipServer.API.LoginResponse> __Marshaller_api_LoginResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.LoginResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RimionshipServer.API.LinkAccountRequest> __Marshaller_api_LinkAccountRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.LinkAccountRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RimionshipServer.API.LinkAccountResponse> __Marshaller_api_LinkAccountResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.LinkAccountResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RimionshipServer.API.SyncRequest> __Marshaller_api_SyncRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.SyncRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RimionshipServer.API.SyncResponse> __Marshaller_api_SyncResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.SyncResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RimionshipServer.API.StartRequest> __Marshaller_api_StartRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.StartRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RimionshipServer.API.StartResponse> __Marshaller_api_StartResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.StartResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RimionshipServer.API.StopRequest> __Marshaller_api_StopRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.StopRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RimionshipServer.API.StopResponse> __Marshaller_api_StopResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.StopResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RimionshipServer.API.StatsRequest> __Marshaller_api_StatsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.StatsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RimionshipServer.API.StatsResponse> __Marshaller_api_StatsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.StatsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RimionshipServer.API.FutureEventsRequest> __Marshaller_api_FutureEventsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.FutureEventsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RimionshipServer.API.FutureEventsResponse> __Marshaller_api_FutureEventsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.FutureEventsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RimionshipServer.API.AttentionRequest> __Marshaller_api_AttentionRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.AttentionRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::RimionshipServer.API.AttentionResponse> __Marshaller_api_AttentionResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::RimionshipServer.API.AttentionResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::RimionshipServer.API.HelloRequest, global::RimionshipServer.API.HelloResponse> __Method_Hello = new grpc::Method<global::RimionshipServer.API.HelloRequest, global::RimionshipServer.API.HelloResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Hello",
        __Marshaller_api_HelloRequest,
        __Marshaller_api_HelloResponse);

    static readonly grpc::Method<global::RimionshipServer.API.LoginRequest, global::RimionshipServer.API.LoginResponse> __Method_Login = new grpc::Method<global::RimionshipServer.API.LoginRequest, global::RimionshipServer.API.LoginResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Login",
        __Marshaller_api_LoginRequest,
        __Marshaller_api_LoginResponse);

    static readonly grpc::Method<global::RimionshipServer.API.LinkAccountRequest, global::RimionshipServer.API.LinkAccountResponse> __Method_LinkAccount = new grpc::Method<global::RimionshipServer.API.LinkAccountRequest, global::RimionshipServer.API.LinkAccountResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "LinkAccount",
        __Marshaller_api_LinkAccountRequest,
        __Marshaller_api_LinkAccountResponse);

    static readonly grpc::Method<global::RimionshipServer.API.SyncRequest, global::RimionshipServer.API.SyncResponse> __Method_Sync = new grpc::Method<global::RimionshipServer.API.SyncRequest, global::RimionshipServer.API.SyncResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Sync",
        __Marshaller_api_SyncRequest,
        __Marshaller_api_SyncResponse);

    static readonly grpc::Method<global::RimionshipServer.API.StartRequest, global::RimionshipServer.API.StartResponse> __Method_Start = new grpc::Method<global::RimionshipServer.API.StartRequest, global::RimionshipServer.API.StartResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Start",
        __Marshaller_api_StartRequest,
        __Marshaller_api_StartResponse);

    static readonly grpc::Method<global::RimionshipServer.API.StopRequest, global::RimionshipServer.API.StopResponse> __Method_Stop = new grpc::Method<global::RimionshipServer.API.StopRequest, global::RimionshipServer.API.StopResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Stop",
        __Marshaller_api_StopRequest,
        __Marshaller_api_StopResponse);

    static readonly grpc::Method<global::RimionshipServer.API.StatsRequest, global::RimionshipServer.API.StatsResponse> __Method_Stats = new grpc::Method<global::RimionshipServer.API.StatsRequest, global::RimionshipServer.API.StatsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Stats",
        __Marshaller_api_StatsRequest,
        __Marshaller_api_StatsResponse);

    static readonly grpc::Method<global::RimionshipServer.API.FutureEventsRequest, global::RimionshipServer.API.FutureEventsResponse> __Method_FutureEvents = new grpc::Method<global::RimionshipServer.API.FutureEventsRequest, global::RimionshipServer.API.FutureEventsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "FutureEvents",
        __Marshaller_api_FutureEventsRequest,
        __Marshaller_api_FutureEventsResponse);

    static readonly grpc::Method<global::RimionshipServer.API.AttentionRequest, global::RimionshipServer.API.AttentionResponse> __Method_Attention = new grpc::Method<global::RimionshipServer.API.AttentionRequest, global::RimionshipServer.API.AttentionResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Attention",
        __Marshaller_api_AttentionRequest,
        __Marshaller_api_AttentionResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::RimionshipServer.API.ApiReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of API</summary>
    public abstract partial class APIBase
    {
      public virtual global::System.Threading.Tasks.Task<global::RimionshipServer.API.HelloResponse> Hello(global::RimionshipServer.API.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::RimionshipServer.API.LoginResponse> Login(global::RimionshipServer.API.LoginRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::RimionshipServer.API.LinkAccountResponse> LinkAccount(global::RimionshipServer.API.LinkAccountRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::RimionshipServer.API.SyncResponse> Sync(global::RimionshipServer.API.SyncRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::RimionshipServer.API.StartResponse> Start(global::RimionshipServer.API.StartRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::RimionshipServer.API.StopResponse> Stop(global::RimionshipServer.API.StopRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::RimionshipServer.API.StatsResponse> Stats(global::RimionshipServer.API.StatsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::RimionshipServer.API.FutureEventsResponse> FutureEvents(global::RimionshipServer.API.FutureEventsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::RimionshipServer.API.AttentionResponse> Attention(global::RimionshipServer.API.AttentionRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for API</summary>
    public partial class APIClient : grpc::ClientBase<APIClient>
    {
      /// <summary>Creates a new client for API</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public APIClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for API that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public APIClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected APIClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected APIClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::RimionshipServer.API.HelloResponse Hello(global::RimionshipServer.API.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Hello(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::RimionshipServer.API.HelloResponse Hello(global::RimionshipServer.API.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Hello, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.HelloResponse> HelloAsync(global::RimionshipServer.API.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return HelloAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.HelloResponse> HelloAsync(global::RimionshipServer.API.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Hello, null, options, request);
      }
      public virtual global::RimionshipServer.API.LoginResponse Login(global::RimionshipServer.API.LoginRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Login(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::RimionshipServer.API.LoginResponse Login(global::RimionshipServer.API.LoginRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Login, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.LoginResponse> LoginAsync(global::RimionshipServer.API.LoginRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LoginAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.LoginResponse> LoginAsync(global::RimionshipServer.API.LoginRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Login, null, options, request);
      }
      public virtual global::RimionshipServer.API.LinkAccountResponse LinkAccount(global::RimionshipServer.API.LinkAccountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LinkAccount(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::RimionshipServer.API.LinkAccountResponse LinkAccount(global::RimionshipServer.API.LinkAccountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_LinkAccount, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.LinkAccountResponse> LinkAccountAsync(global::RimionshipServer.API.LinkAccountRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return LinkAccountAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.LinkAccountResponse> LinkAccountAsync(global::RimionshipServer.API.LinkAccountRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_LinkAccount, null, options, request);
      }
      public virtual global::RimionshipServer.API.SyncResponse Sync(global::RimionshipServer.API.SyncRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Sync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::RimionshipServer.API.SyncResponse Sync(global::RimionshipServer.API.SyncRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Sync, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.SyncResponse> SyncAsync(global::RimionshipServer.API.SyncRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SyncAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.SyncResponse> SyncAsync(global::RimionshipServer.API.SyncRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Sync, null, options, request);
      }
      public virtual global::RimionshipServer.API.StartResponse Start(global::RimionshipServer.API.StartRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Start(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::RimionshipServer.API.StartResponse Start(global::RimionshipServer.API.StartRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Start, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.StartResponse> StartAsync(global::RimionshipServer.API.StartRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StartAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.StartResponse> StartAsync(global::RimionshipServer.API.StartRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Start, null, options, request);
      }
      public virtual global::RimionshipServer.API.StopResponse Stop(global::RimionshipServer.API.StopRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Stop(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::RimionshipServer.API.StopResponse Stop(global::RimionshipServer.API.StopRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Stop, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.StopResponse> StopAsync(global::RimionshipServer.API.StopRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StopAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.StopResponse> StopAsync(global::RimionshipServer.API.StopRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Stop, null, options, request);
      }
      public virtual global::RimionshipServer.API.StatsResponse Stats(global::RimionshipServer.API.StatsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Stats(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::RimionshipServer.API.StatsResponse Stats(global::RimionshipServer.API.StatsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Stats, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.StatsResponse> StatsAsync(global::RimionshipServer.API.StatsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return StatsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.StatsResponse> StatsAsync(global::RimionshipServer.API.StatsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Stats, null, options, request);
      }
      public virtual global::RimionshipServer.API.FutureEventsResponse FutureEvents(global::RimionshipServer.API.FutureEventsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FutureEvents(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::RimionshipServer.API.FutureEventsResponse FutureEvents(global::RimionshipServer.API.FutureEventsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_FutureEvents, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.FutureEventsResponse> FutureEventsAsync(global::RimionshipServer.API.FutureEventsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return FutureEventsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.FutureEventsResponse> FutureEventsAsync(global::RimionshipServer.API.FutureEventsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_FutureEvents, null, options, request);
      }
      public virtual global::RimionshipServer.API.AttentionResponse Attention(global::RimionshipServer.API.AttentionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Attention(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::RimionshipServer.API.AttentionResponse Attention(global::RimionshipServer.API.AttentionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Attention, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.AttentionResponse> AttentionAsync(global::RimionshipServer.API.AttentionRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return AttentionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::RimionshipServer.API.AttentionResponse> AttentionAsync(global::RimionshipServer.API.AttentionRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Attention, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override APIClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new APIClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(APIBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Hello, serviceImpl.Hello)
          .AddMethod(__Method_Login, serviceImpl.Login)
          .AddMethod(__Method_LinkAccount, serviceImpl.LinkAccount)
          .AddMethod(__Method_Sync, serviceImpl.Sync)
          .AddMethod(__Method_Start, serviceImpl.Start)
          .AddMethod(__Method_Stop, serviceImpl.Stop)
          .AddMethod(__Method_Stats, serviceImpl.Stats)
          .AddMethod(__Method_FutureEvents, serviceImpl.FutureEvents)
          .AddMethod(__Method_Attention, serviceImpl.Attention).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, APIBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Hello, serviceImpl.Hello);
      serviceBinder.AddMethod(__Method_Login, serviceImpl.Login);
      serviceBinder.AddMethod(__Method_LinkAccount, serviceImpl.LinkAccount);
      serviceBinder.AddMethod(__Method_Sync, serviceImpl.Sync);
      serviceBinder.AddMethod(__Method_Start, serviceImpl.Start);
      serviceBinder.AddMethod(__Method_Stop, serviceImpl.Stop);
      serviceBinder.AddMethod(__Method_Stats, serviceImpl.Stats);
      serviceBinder.AddMethod(__Method_FutureEvents, serviceImpl.FutureEvents);
      serviceBinder.AddMethod(__Method_Attention, serviceImpl.Attention);
    }

  }
}
#endregion
