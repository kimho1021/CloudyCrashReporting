# Cloudy Crash Reporting

A playground for testing out different cloud services with regards to crashes and exceptions.

## Overview

Below is a matrix of the cloud services, SDK features and platforms. Clicking the cloud service name will take you to a
more detailed section of the service. I have also attached notes to various parts for more information. 

|                Service Name | Android | iOS | macOS | Windows |    Tizen     | .NET Ex |  Native Ex   |
|----------------------------:|:-------:|:---:|:-----:|:-------:|:------------:|:-------:|:------------:|
|                 **Datadog** |    ➖    |  ➖  |   ➖   |    ➖    |      ➖       |    ➖    |      ➖       |
|               **Dynatrace** |    ➖    |  ➖  |   ➖   |    ➖    |      ➖       |    ➖    |      ➖       |
|    **Firebase Crashlytics** |    ➖    |  ➖  |   ➖   |    ➖    |      ➖       |    ➖    |      ➖       |
|    **Microsoft App Center** |    ➖    |  ➖  |   ➖   |    ➖    |      ➖       |    ➖    |      ➖       |
| [**New Relic**](#new-relic) |    ✅    |  ✅  |   ❌   |    ❌    |      ❌       |    ✅    | ➗ [[1]](#n1) |
|                  **Raygun** |    ➖    |  ➖  |   ➖   |    ➖    |      ➖       |    ➖    |      ➖       |
|  [**Sentry.io**](#sentryio) |    ✅    |  ✅  |   ✅   |    ✅    | ➗ [[2]](#n2) |    ✅    |      ✅       |
|                             |    ➖    |  ➖  |   ➖   |    ➖    |      ➖       |    ➖    |      ➖       |
|                             |    ➖    |  ➖  |   ➖   |    ➖    |      ➖       |    ➖    |      ➖       |
|                             |    ➖    |  ➖  |   ➖   |    ➖    |      ➖       |    ➖    |      ➖       |

> **Key**  
> ✅ → fully supported  
> ➗ → partially supported, see notes  
> ❌ → not supported at all  
> ➖ → unknown / yet to be determined  

### Notes

1. <a name="n1"></a> **[New Relic]** Android native crash reporting is still in development and actually is not enabled for .NET MAUI Android apps:
   https://docs.newrelic.com/docs/mobile-monitoring/mobile-monitoring-ui/crashes/investigate-mobile-app-crash-report/#android-native-reporting
2. <a name="n2"></a> **[Sentry.io]** There is no explicit native Tizen SDK for Sentry, however the .NET SDK does have support for all .NET frameworks,
   which includes the Tizen .NET SDK.

## Types of Crashes & Exceptions

In a mobile or desktop app, there are a few types of issues that can cause catastrophic failure:

* Native code failures/exceptions
* Unhandled exceptions in .NET/managed code
* Exception reporting for handled exceptions

## Cloud Services

### New Relic

**Links:**

* Home: https://newrelic.com
* Mobile: https://docs.newrelic.com/docs/mobile-monitoring/new-relic-mobile/get-started/introduction-mobile-monitoring
* .NET MAUI Setup: https://docs.newrelic.com/docs/mobile-monitoring/new-relic-mobile-maui-dotnet/monitor-your-net-maui-application

**Pros:**

* Easy to set up
* Collects all crashes on iOS (managed/native)
* Partially open source SDKs:
  * .NET MAUI: https://github.com/newrelic/newrelic-maui-plugin
  * Android: https://github.com/newrelic/newrelic-android-agent 
  * iOS: Not open source

**Cons:**

* No support for desktop (macOS and Windows)
* Does not collect exceptions from unobserved Tasks
* Does not collect crashes from background threads on Android


### Sentry.io

**Links:**

* Home: https://sentry.io
* .NET MAUI Setup: https://docs.sentry.io/platforms/dotnet/guides/maui

**Pros:**

* Easy setup - especially the integration with the builder
* Fully open source SDKs: https://github.com/getsentry/sentry-dotnet
* Native crash reports
* Catches exceptions from unobserved tasks

**Cons:**

* None yet, in my limited testing


### OTHER

**Links:**

* Home:
* .NET MAUI Setup:

**Pros:**

* ...

**Cons:**

* ...

