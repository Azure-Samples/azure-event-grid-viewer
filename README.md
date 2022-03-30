---
page_type: sample
languages:
  - csharp
products:
  - dotnet
  - azure
  - azure-event-grid
description: "Source code for a site that displays events from Azure Event Grid in near-real time."
---

# Azure Event Grid Viewer

This repository contains the source code for a site that displays events from Azure Event Grid in near-real time. It is built on [ASP.NET Core](https://docs.microsoft.com/aspnet/core) and leverages [SignalR](https://dotnet.microsoft.com/apps/aspnet/signalr) to display incoming messages.

For details about how it was put together, please refer to the [accompanying blog post](https://madeofstrings.com/2018/03/14/azure-event-grid-viewer-with-asp-net-core-and-signalr/).

## Deploy the solution

### 1. Select Deploy to Azure

This will launch a custom template for the Azure portal instance that you are logged into.

<a href="https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2FAzure-Samples%2Fazure-event-grid-viewer%2Fmain%2Fazuredeploy.json" target="_blank"><img src="https://raw.githubusercontent.com/Azure/azure-quickstart-templates/master/1-CONTRIBUTION-GUIDE/images/deploytoazure.svg?sanitize=true"/></a>

### 2. Fill out the required fields

This will take about 2-5 minutes to provision.

![Custom deployment](https://raw.githubusercontent.com/Azure-Samples/azure-event-grid-viewer/main/customdeployment_sm.png)

### 3. Launch the site

Launch the site to ensure that it is running. Make note of the address for the next step.

### 4. Register the endpoint as an event subscription

The event subscription endpoint will be the address with the following suffix: */api/updates*.

For example: `https://{{site-name}}.azurewebsites.net/api/updates`

### 5. References

- [Routing events to a custom endpoint](https://docs.microsoft.com/azure/storage/blobs/storage-blob-event-quickstart?toc=%2fazure%2fevent-grid%2ftoc.json)
- [Receive events to an HTTP endpoint](https://docs.microsoft.com/azure/event-grid/receive-events)
