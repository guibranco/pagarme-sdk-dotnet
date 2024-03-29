# Pagar.Me SDK client

The [Pagar.Me](https://pagar.me) SDK for .NET projects.

[![GitHub license](https://img.shields.io/github/license/guibranco/pagarme-sdk-dotnet)](https://github.com/guibranco/pagarme-sdk-dotnet)
[![time tracker](https://wakatime.com/badge/github/guibranco/pagarme-sdk-dotnet.svg)](https://wakatime.com/badge/github/guibranco/pagarme-sdk-dotnet)

![Pagar.Me SDK .NET](https://raw.githubusercontent.com/guibranco/pagarme-sdk-dotnet/main/logo.png)

## CI/CD

| Build status | Last commit | Tests | Coverage | Code Smells | LOC |
|--------------|-------------|-------|----------|-------------|-----|
| [![Build status](https://ci.appveyor.com/api/projects/status/ksmbsr9j92baj2d0/branch/main?svg=true)](https://ci.appveyor.com/project/guibranco/pagarme-sdk-dotnet) | [![GitHub last commit](https://img.shields.io/github/last-commit/guibranco/pagarme-sdk-dotnet/main)](https://github.com/guibranco/pagarme-sdk-dotnet) | [![AppVeyor tests (branch)](https://img.shields.io/appveyor/tests/guibranco/pagarme-sdk-dotnet/main?compact_message)](https://ci.appveyor.com/project/guibranco/pagarme-sdk-dotnet) | [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=guibranco_pagarme-sdk-dotnet&metric=coverage)](https://sonarcloud.io/dashboard?id=guibranco_pagarme-sdk-dotnet) | [![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=guibranco_pagarme-sdk-dotnet&metric=code_smells)](https://sonarcloud.io/dashboard?id=guibranco_pagarme-sdk-dotnet) | [![Lines of Code](https://sonarcloud.io/api/project_badges/measure?project=guibranco_pagarme-sdk-dotnet&metric=ncloc)](https://sonarcloud.io/dashboard?id=guibranco_pagarme-sdk-dotnet)

## Code Quality
[![Codacy Badge](https://app.codacy.com/project/badge/Grade/7d2d55d973504d37b6046db35243e6d8)](https://www.codacy.com/gh/guibranco/pagarme-sdk-dotnet/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=guibranco/pagarme-sdk-dotnet&amp;utm_campaign=Badge_Grade)
[![Codacy Badge](https://app.codacy.com/project/badge/Coverage/7d2d55d973504d37b6046db35243e6d8)](https://www.codacy.com/gh/guibranco/pagarme-sdk-dotnet/dashboard?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=guibranco/pagarme-sdk-dotnet&amp;utm_campaign=Badge_Grade)
[![codecov](https://codecov.io/gh/guibranco/pagarme-sdk-dotnet/branch/main/graph/badge.svg)](https://codecov.io/gh/guibranco/pagarme-sdk-dotnet)

[![Maintainability](https://api.codeclimate.com/v1/badges/8dbe39c9694e094431ec/maintainability)](https://codeclimate.com/github/guibranco/pagarme-sdk-dotnet/maintainability)
[![Test Coverage](https://api.codeclimate.com/v1/badges/8dbe39c9694e094431ec/test_coverage)](https://codeclimate.com/github/guibranco/pagarme-sdk-dotnet/test_coverage)

[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=guibranco_pagarme-sdk-dotnet&metric=alert_status)](https://sonarcloud.io/dashboard?id=guibranco_pagarme-sdk-dotnet)
[![Maintainability Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_pagarme-sdk-dotnet&metric=sqale_rating)](https://sonarcloud.io/dashboard?id=guibranco_pagarme-sdk-dotnet)

[![Technical Debt](https://sonarcloud.io/api/project_badges/measure?project=guibranco_pagarme-sdk-dotnet&metric=sqale_index)](https://sonarcloud.io/dashboard?id=guibranco_pagarme-sdk-dotnet)
[![Duplicated Lines (%)](https://sonarcloud.io/api/project_badges/measure?project=guibranco_pagarme-sdk-dotnet&metric=duplicated_lines_density)](https://sonarcloud.io/dashboard?id=guibranco_pagarme-sdk-dotnet)

[![Reliability Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_pagarme-sdk-dotnet&metric=reliability_rating)](https://sonarcloud.io/dashboard?id=guibranco_pagarme-sdk-dotnet)
[![Security Rating](https://sonarcloud.io/api/project_badges/measure?project=guibranco_pagarme-sdk-dotnet&metric=security_rating)](https://sonarcloud.io/dashboard?id=guibranco_pagarme-sdk-dotnet)

[![Bugs](https://sonarcloud.io/api/project_badges/measure?project=guibranco_pagarme-sdk-dotnet&metric=bugs)](https://sonarcloud.io/dashboard?id=guibranco_pagarme-sdk-dotnet)
[![Vulnerabilities](https://sonarcloud.io/api/project_badges/measure?project=guibranco_pagarme-sdk-dotnet&metric=vulnerabilities)](https://sonarcloud.io/dashboard?id=guibranco_pagarme-sdk-dotnet)

---

## Installation

### Github Releases

[![GitHub last release](https://img.shields.io/github/release-date/guibranco/pagarme-sdk-dotnet.svg?style=flat)](https://github.com/guibranco/pagarme-sdk-dotnet) [![Github All Releases](https://img.shields.io/github/downloads/guibranco/pagarme-sdk-dotnet/total.svg?style=flat)](https://github.com/guibranco/pagarme-sdk-dotnet)

Download the latest zip file from the [Release](https://github.com/GuiBranco/pagarme-sdk-dotnet/releases) page.

### Nuget package manager

| Package | Version | Downloads |
|------------------|:-------:|:-------:|
| **PagarMeSDK** | [![ViaCEP NuGet Version](https://img.shields.io/nuget/v/PagarMeSDK.svg?style=flat)](https://www.nuget.org/packages/PagarMeSDK/) | [![PagarMeSDK NuGet Downloads](https://img.shields.io/nuget/dt/PagarMeSDK.svg?style=flat)](https://www.nuget.org/packages/PagarMeSDK/) |

---

## Features

Implements all features of Pagar.Me API available at [Pagar.Me](https://docs.pagar.me/docs/overview-principal)

- Feature #1
- Feature #2
- Feature #3
- Feature #N

---

## Usage

```cs

//sample CSharp code showing how to use the lib
var client = new PagarMeSDKClient();
client.CallSomeMethod();

```

---
