# Release History

## 1.0.0-beta.2 (2022-10-01)

### Features Added

-   Support for scope filtering of targets (currently only supports VMSS availability zones)
-   Added `kind` property to `CapabilityType`

### Bugs Fixed

-   Fixes serialization/deserialization of `TimeSpan` properties to support expected ISO8601 format

## 1.0.0-beta.1 (2022-09-15)

### Breaking Changes

New design of track 2 initial commit.

### Package Name

The package name has been changed from `Microsoft.Azure.Management.Chaos` to `Azure.ResourceManager.Chaos`.

### General New Features

    - Support MSAL.NET, Azure.Identity is out of box for supporting MSAL.NET
    - Support [OpenTelemetry](https://opentelemetry.io/) for distributed tracing
    - HTTP pipeline with custom policies
    - Better error-handling
    - Support uniform telemetry across all languages

This package follows the [Azure SDK Design Guidelines for .NET](https://azure.github.io/azure-sdk/dotnet_introduction.html) which provide a number of core capabilities that are shared amongst all Azure SDKs, including the intuitive Azure Identity library, an HTTP Pipeline with custom policies, error-handling, distributed tracing, and much more.

This is a Public Preview version, so expect incompatible changes in subsequent releases as we improve the product. To provide feedback, please submit an issue in our [Azure SDK for .NET GitHub repo](https://github.com/Azure/azure-sdk-for-net/issues).
