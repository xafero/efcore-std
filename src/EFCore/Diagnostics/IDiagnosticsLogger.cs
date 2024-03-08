// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Runtime.CompilerServices;

namespace Microsoft.EntityFrameworkCore.Diagnostics;

/// <summary>
///     Combines <see cref="ILogger" /> and <see cref="DiagnosticSource" />
///     for use by all EF Core logging so that events can be sent to both <see cref="ILogger" />
///     for ASP.NET and <see cref="DiagnosticSource" /> for everything else.
/// </summary>
/// <remarks>
///     <para>
///         This service cannot depend on services registered as <see cref="ServiceLifetime.Scoped" />.
///     </para>
///     <para>
///         See <see href="https://aka.ms/efcore-docs-providers">Implementation of database providers and extensions</see>
///         for more information and examples.
///     </para>
/// </remarks>
public interface IDiagnosticsLogger
{
}
