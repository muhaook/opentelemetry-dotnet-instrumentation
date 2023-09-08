﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the InstrumentationDefinitionsGenerator tool. To safely
//     modify this file, edit InstrumentMethodAttribute on the classes and
//     compile project.

//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated. 
// </auto-generated>
//------------------------------------------------------------------------------

using OpenTelemetry.AutoInstrumentation.Configurations;

namespace OpenTelemetry.AutoInstrumentation;

internal static partial class InstrumentationDefinitions
{
    private static readonly string AssemblyFullName = typeof(InstrumentationDefinitions).Assembly.FullName!;

    private static NativeCallTargetDefinition[] GetDefinitionsArray()
    {
        var nativeCallTargetDefinitions = new List<NativeCallTargetDefinition>(18);
        // Traces
        var tracerSettings = Instrumentation.TracerSettings.Value;
        if (tracerSettings.TracesEnabled)
        {
            // Ba
            if (tracerSettings.EnabledInstrumentations.Contains(TracerInstrumentation.Ba))
            {
                nativeCallTargetDefinitions.Add(new("Microsoft.AspNetCore", "Microsoft.AspNetCore.Builder.WebApplication", "Run", new[] {"System.Void", "System.String"}, 6, 0, 0, 7, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Ba.BaIntegration"));
            }

            // MongoDB
            if (tracerSettings.EnabledInstrumentations.Contains(TracerInstrumentation.MongoDB))
            {
                nativeCallTargetDefinitions.Add(new("MongoDB.Driver", "MongoDB.Driver.MongoClient", ".ctor", new[] {"System.Void", "MongoDB.Driver.MongoClientSettings"}, 2, 13, 3, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.MongoDB.MongoClientIntegration"));
            }

            // NServiceBus
            if (tracerSettings.EnabledInstrumentations.Contains(TracerInstrumentation.NServiceBus))
            {
                nativeCallTargetDefinitions.Add(new("NServiceBus.Core", "NServiceBus.EndpointConfiguration", ".ctor", new[] {"System.Void", "System.String"}, 8, 0, 0, 8, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.NServiceBus.EndpointConfigurationIntegration"));
            }

            // StackExchangeRedis
            if (tracerSettings.EnabledInstrumentations.Contains(TracerInstrumentation.StackExchangeRedis))
            {
                nativeCallTargetDefinitions.Add(new("StackExchange.Redis", "StackExchange.Redis.ConnectionMultiplexer", "ConnectImpl", new[] {"StackExchange.Redis.ConnectionMultiplexer", "System.Object", "System.IO.TextWriter"}, 2, 0, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.StackExchangeRedis.StackExchangeRedisIntegration"));
                nativeCallTargetDefinitions.Add(new("StackExchange.Redis", "StackExchange.Redis.ConnectionMultiplexer", "ConnectImpl", new[] {"StackExchange.Redis.ConnectionMultiplexer", "StackExchange.Redis.ConfigurationOptions", "System.IO.TextWriter"}, 2, 0, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.StackExchangeRedis.StackExchangeRedisIntegration"));
                nativeCallTargetDefinitions.Add(new("StackExchange.Redis", "StackExchange.Redis.ConnectionMultiplexer", "ConnectImpl", new[] {"StackExchange.Redis.ConnectionMultiplexer", "StackExchange.Redis.ConfigurationOptions", "System.IO.TextWriter", "System.Nullable`1[StackExchange.Redis.ServerType]"}, 2, 0, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.StackExchangeRedis.StackExchangeRedisIntegration"));
                nativeCallTargetDefinitions.Add(new("StackExchange.Redis", "StackExchange.Redis.ConnectionMultiplexer", "ConnectImpl", new[] {"StackExchange.Redis.ConnectionMultiplexer", "StackExchange.Redis.ConfigurationOptions", "System.IO.TextWriter", "System.Nullable`1[StackExchange.Redis.ServerType]", "StackExchange.Redis.EndPointCollection"}, 2, 0, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.StackExchangeRedis.StackExchangeRedisIntegration"));
                nativeCallTargetDefinitions.Add(new("StackExchange.Redis", "StackExchange.Redis.ConnectionMultiplexer", "ConnectImplAsync", new[] {"System.Threading.Tasks.Task`1[StackExchange.Redis.ConnectionMultiplexer]", "System.Object", "System.IO.TextWriter"}, 2, 0, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.StackExchangeRedis.StackExchangeRedisIntegrationAsync"));
                nativeCallTargetDefinitions.Add(new("StackExchange.Redis", "StackExchange.Redis.ConnectionMultiplexer", "ConnectImplAsync", new[] {"System.Threading.Tasks.Task`1[StackExchange.Redis.ConnectionMultiplexer]", "StackExchange.Redis.ConfigurationOptions", "System.IO.TextWriter"}, 2, 0, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.StackExchangeRedis.StackExchangeRedisIntegrationAsync"));
                nativeCallTargetDefinitions.Add(new("StackExchange.Redis", "StackExchange.Redis.ConnectionMultiplexer", "ConnectImplAsync", new[] {"System.Threading.Tasks.Task`1[StackExchange.Redis.ConnectionMultiplexer]", "StackExchange.Redis.ConfigurationOptions", "System.IO.TextWriter", "System.Nullable`1[StackExchange.Redis.ServerType]"}, 2, 0, 0, 2, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.StackExchangeRedis.StackExchangeRedisIntegrationAsync"));
            }

            // WcfClient
            if (tracerSettings.EnabledInstrumentations.Contains(TracerInstrumentation.WcfClient))
            {
                nativeCallTargetDefinitions.Add(new("System.Private.ServiceModel", "System.ServiceModel.ChannelFactory", "InitializeEndpoint", new[] {"System.Void", "System.String", "System.ServiceModel.EndpointAddress"}, 4, 0, 0, 4, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Wcf.Client.WcfClientIntegration"));
                nativeCallTargetDefinitions.Add(new("System.Private.ServiceModel", "System.ServiceModel.ChannelFactory", "InitializeEndpoint", new[] {"System.Void", "System.ServiceModel.Description.ServiceEndpoint"}, 4, 0, 0, 4, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Wcf.Client.WcfClientIntegration"));
                nativeCallTargetDefinitions.Add(new("System.Private.ServiceModel", "System.ServiceModel.ChannelFactory", "InitializeEndpoint", new[] {"System.Void", "System.ServiceModel.Channels.Binding", "System.ServiceModel.EndpointAddress"}, 4, 0, 0, 4, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Wcf.Client.WcfClientIntegration"));
                nativeCallTargetDefinitions.Add(new("System.ServiceModel.Primitives", "System.ServiceModel.ChannelFactory", "InitializeEndpoint", new[] {"System.Void", "System.String", "System.ServiceModel.EndpointAddress"}, 6, 0, 0, 6, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Wcf.Client.WcfClientIntegration"));
                nativeCallTargetDefinitions.Add(new("System.ServiceModel.Primitives", "System.ServiceModel.ChannelFactory", "InitializeEndpoint", new[] {"System.Void", "System.ServiceModel.Description.ServiceEndpoint"}, 6, 0, 0, 6, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Wcf.Client.WcfClientIntegration"));
                nativeCallTargetDefinitions.Add(new("System.ServiceModel.Primitives", "System.ServiceModel.ChannelFactory", "InitializeEndpoint", new[] {"System.Void", "System.ServiceModel.Channels.Binding", "System.ServiceModel.EndpointAddress"}, 6, 0, 0, 6, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Wcf.Client.WcfClientIntegration"));
            }
        }

        // Logs
        var logSettings = Instrumentation.LogSettings.Value;
        if (logSettings.LogsEnabled)
        {
            // ILogger
            if (logSettings.EnabledInstrumentations.Contains(LogInstrumentation.ILogger))
            {
                nativeCallTargetDefinitions.Add(new("Microsoft.Extensions.Logging", "Microsoft.Extensions.Logging.LoggingBuilder", ".ctor", new[] {"System.Void", "Microsoft.Extensions.DependencyInjection.IServiceCollection"}, 3, 1, 0, 7, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.Logger.LoggingBuilderIntegration"));
            }
        }

        // Metrics
        var metricSettings = Instrumentation.MetricSettings.Value;
        if (metricSettings.MetricsEnabled)
        {
            // NServiceBus
            if (metricSettings.EnabledInstrumentations.Contains(MetricInstrumentation.NServiceBus))
            {
                nativeCallTargetDefinitions.Add(new("NServiceBus.Core", "NServiceBus.EndpointConfiguration", ".ctor", new[] {"System.Void", "System.String"}, 8, 0, 0, 8, 65535, 65535, AssemblyFullName, "OpenTelemetry.AutoInstrumentation.Instrumentations.NServiceBus.EndpointConfigurationIntegration"));
            }
        }

        return nativeCallTargetDefinitions.ToArray();
    }
}
