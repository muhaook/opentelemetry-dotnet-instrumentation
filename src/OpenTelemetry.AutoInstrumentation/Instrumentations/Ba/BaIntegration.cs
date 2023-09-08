// <copyright file="BaIntegration.cs" company="OpenTelemetry Authors">
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
#if NET6_0_OR_GREATER

using OpenTelemetry.AutoInstrumentation.CallTarget;
using OpenTelemetry.AutoInstrumentation.Logging;

namespace OpenTelemetry.AutoInstrumentation.Instrumentations.Ba;

/// <summary>
/// calltarget instrumentation
/// </summary>
[InstrumentMethod(
    assemblyName: "Microsoft.AspNetCore",
    typeName: "Microsoft.AspNetCore.Builder.WebApplication",
    methodName: "Run",
    returnTypeName: "System.Void",
    parameterTypeNames: new string[] { "System.String" },
    minimumVersion: "6.0.0",
    maximumVersion: "7.65535.65535",
    integrationName: "Ba",
    type: InstrumentationType.Trace)]
public class BaIntegration
{
    internal static readonly IOtelLogger Log = OtelLogging.GetLogger();

    /// <summary>
    /// OnMethodBegin callback
    /// </summary>
    /// <typeparam name="TTarget">Type of the target</typeparam>
    /// <typeparam name="TArg1">Type of TArg1</typeparam>
    /// <param name="instance">Instance value, aka `this` of the instrumented method.</param>
    /// <param name="arg1">arg1.</param>
    /// <returns>Calltarget state value</returns>
    public static CallTargetState OnMethodBegin<TTarget, TArg1>(TTarget instance, TArg1 arg1)
    {
        try
        {
            Log.Information("===== WebApplication.Run() gets invoked =====");
        }
        catch (Exception ex)
        {
            try
            {
                Log.Information("Exception from OnMethodBeginEx: " + ex.ToString());
            }
            catch (Exception)
            {
                // swallow it
            }
        }

        return CallTargetState.GetDefault();
    }
}
#endif
