# DevOps.Code.Entities.AddEntityTypeRecord

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-entities-addentitytyperecord.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/devops-code-entities-addentitytyperecord)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.Entities.AddEntityTypeRecord.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.AddEntityTypeRecord)

## Description

Function adds the given entity type information to an Azure Storage Table ledger

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.DevOps.Code.Entities.GetAzureTable](https://github.com/CDorst/DevOps.Code.Entities.GetAzureTable) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-entities-getazuretable.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-code-entities-getazuretable) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.Entities.GetAzureTable.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.GetAzureTable)
[CDorst.DevOps.Code.Entities.EntityTypeLedger.Builder](https://github.com/CDorst/DevOps.Code.Entities.EntityTypeLedger.Builder) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-entities-entitytypeledger-builder.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-code-entities-entitytypeledger-builder) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.Entities.EntityTypeLedger.Builder.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.EntityTypeLedger.Builder)

## NuGet

This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.AddEntityTypeRecord](https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.AddEntityTypeRecord)

## Version

1.0.2

## Metaproject

DevOps.Code.Entities.AddEntityTypeRecord is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

