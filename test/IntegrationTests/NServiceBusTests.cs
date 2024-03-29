// <copyright file="NServiceBusTests.cs" company="OpenTelemetry Authors">
// Copyright The OpenTelemetry Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using IntegrationTests.Helpers;
using OpenTelemetry.AutoInstrumentation.Configurations;
using Xunit.Abstractions;

namespace IntegrationTests;

public class NServiceBusTests : TestHelper
{
    public NServiceBusTests(ITestOutputHelper output)
        : base("NServiceBus", output)
    {
        EnableBytecodeInstrumentation();
    }

    [Theory]
    [Trait("Category", "EndToEnd")]
    [MemberData(nameof(LibraryVersion.NServiceBus), MemberType = typeof(LibraryVersion))]
    public void SubmitsTraces(string packageVersion)
    {
        using var collector = new MockSpansCollector(Output);
        SetExporter(collector);
        collector.Expect("NServiceBus.Core");
        SetEnvironmentVariable(ConfigurationKeys.Metrics.MetricsEnabled, bool.FalseString); // make sure that metrics instrumentation is not needed

        using var process = StartTestApplication(new TestSettings
        {
#if NET462
            Framework = "net472",
#endif
            PackageVersion = packageVersion
        });

        collector.AssertExpectations();
    }

    [Theory]
    [Trait("Category", "EndToEnd")]
    [MemberData(nameof(LibraryVersion.NServiceBus), MemberType = typeof(LibraryVersion))]
    public void SubmitMetrics(string packageVersion)
    {
        using var collector = new MockMetricsCollector(Output);
        SetExporter(collector);
        collector.Expect("NServiceBus.Core");

        SetEnvironmentVariable("LONG_RUNNING", "true");
        SetEnvironmentVariable("OTEL_METRIC_EXPORT_INTERVAL", "100");
        SetEnvironmentVariable(ConfigurationKeys.Traces.TracesEnabled, bool.FalseString); // make sure that traces instrumentation is not needed

        using var process = StartTestApplication(new TestSettings
        {
#if NET462
            Framework = "net472",
#endif
            PackageVersion = packageVersion
        });

        try
        {
            collector.AssertExpectations();
        }
        finally
        {
            process?.Kill();
        }
    }
}
