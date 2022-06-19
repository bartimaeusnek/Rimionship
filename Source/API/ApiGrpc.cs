// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/api.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Api {
  public static partial class API
  {
    static readonly string __ServiceName = "api.API";

    static readonly grpc::Marshaller<global::Api.HelloRequest> __Marshaller_api_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Api.HelloRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Api.HelloReply> __Marshaller_api_HelloReply = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Api.HelloReply.Parser.ParseFrom);

    static readonly grpc::Method<global::Api.HelloRequest, global::Api.HelloReply> __Method_Hello = new grpc::Method<global::Api.HelloRequest, global::Api.HelloReply>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Hello",
        __Marshaller_api_HelloRequest,
        __Marshaller_api_HelloReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Api.ApiReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of API</summary>
    public abstract partial class APIBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Api.HelloReply> Hello(global::Api.HelloRequest request, grpc::ServerCallContext context)
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

      public virtual global::Api.HelloReply Hello(global::Api.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return Hello(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Api.HelloReply Hello(global::Api.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Hello, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Api.HelloReply> HelloAsync(global::Api.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return HelloAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Api.HelloReply> HelloAsync(global::Api.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Hello, null, options, request);
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
          .AddMethod(__Method_Hello, serviceImpl.Hello).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, APIBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_Hello, serviceImpl.Hello);
    }

  }
}
#endregion