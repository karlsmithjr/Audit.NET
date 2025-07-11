# Audit.NET

**[USAGE](#usage) | [OUTPUT](#output) | [CUSTOMIZATION](#custom-fields-and-comments) | [DATA PROVIDERS](#data-providers) | [CREATION POLICY](#event-creation-policy) | [CONFIGURATION](#configuration) | [EXTENSIONS](#extensions)**

issues | build status | Quality gate | donations
------------ | ---------------- | ---------------- |  --------------
[![issues-open](https://img.shields.io/github/issues-raw/thepirat000/Audit.NET.svg?label=open)](https://github.com/thepirat000/Audit.NET/issues)  [![issues-closed](https://img.shields.io/github/issues-closed-raw/thepirat000/Audit.NET.svg?label=closed)](https://github.com/thepirat000/Audit.NET/issues) | [![build-status](https://img.shields.io/github/actions/workflow/status/thepirat000/audit.net/dotnet.yml)](https://github.com/thepirat000/Audit.NET/actions) | [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=Audit.NET&metric=alert_status)](https://sonarcloud.io/summary/overall?id=Audit.NET)  [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=Audit.NET&metric=coverage)](https://sonarcloud.io/summary/overall?id=Audit.NET) | [![backers](https://opencollective.com/auditnet/tiers/backer/badge.svg?label=backer&color=brightgreen)](https://opencollective.com/auditnet) [![paypal](https://img.shields.io/badge/donate-PayPal-blue.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=thepirat000%40hotmail.com&currency_code=USD&source=url)

![Alt](https://repobeats.axiom.co/api/embed/81f877a65a813b88933812fd28671411e71c10b5.svg "Repobeats analytics image")

### An extensible framework to audit executing operations in .NET and .NET Core.

Generate [audit logs](https://en.wikipedia.org/wiki/Audit_trail) with evidence for reconstruction and examination of activities that have affected specific operations or procedures. 

With Audit.NET, you can generate detailed tracking information for executed operations. It captures environmental data such as the caller's user ID, machine name, method name, exceptions, and execution time. The framework also provides an extensible mechanism to enrich logs and manage audit outputs.

- [**Interaction extensions**](#extensions) to audit different systems are provided, such as [Entity Framework](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.EntityFramework/README.md), 
[MVC](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.Mvc/README.md), 
[WebAPI](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.WebApi/README.md), 
[WCF](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.WCF/README.md), 
[File System](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.FileSystem/README.md), 
[SignalR](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.SignalR/README.md),
[MongoClient](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.MongoClient/README.md) 
and [HttpClient](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.HttpClient/README.md).

- [**Output extensions**](#data-providers-included) are provided to log to [JSON Files](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/Providers/FileDataProvider.cs), 
[Event Log](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/Providers/EventLogDataProvider.cs), 
[Open Telemetry Spans](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/Providers/ActivityDataProvider.cs), 
[SQL](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.SqlServer/README.md), 
[MySQL](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.MySql/README.md), 
[PostgreSQL](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.PostgreSql/README.md), 
[RavenDB](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.RavenDB/README.md), 
[MongoDB](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.MongoDB/README.md), 
[AzureBlob](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.AzureStorageBlobs/README.md), 
[AzureTables](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.AzureStorageTables/README.md), 
[AzureCosmos](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.AzureCosmos/README.md), 
[AzureEventHubs](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.AzureEventHubs/README.md), 
[Redis](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Redis/README.md), 
[Elasticsearch](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.ElasticSearch/README.md), 
[OpenSearch](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.OpenSearch/README.md), 
[DynamoDB](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.DynamoDB/README.md), 
[ImmuDB](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.ImmuDB/README.md), 
[UDP datagrams](https://github.com/thepirat000/Audit.NET/tree/master/src/Audit.NET.Udp/README.md), 
[Channels](https://github.com/thepirat000/Audit.NET/tree/master/src/Audit.NET.Channels/README.md) and more. 

- [**Output wrappers**](#data-provider-wrappers) are included 
to facilitate the encapsulation of other Data Providers for diverse purposes, like resilience or lazy instantiation, such as
[Polly](#polly-data-provider), 
[Lazy](#lazy-factory-data-provider),
[Deferred](#deferred-factory-data-provider) and
[Conditional](#conditional-data-provider).


## [NuGet](https://www.nuget.org/packages/Audit.NET/)

[![NuGet Status](https://img.shields.io/nuget/v/Audit.NET.svg?style=flat)](https://www.nuget.org/packages/Audit.NET/)
[![NuGet Count](https://img.shields.io/nuget/dt/Audit.NET.svg)](https://www.nuget.org/packages/Audit.NET/)

To install the package run the following command on the Package Manager Console:

```
PM> Install-Package Audit.NET
```

## Changelog
Check the [CHANGELOG.md](https://github.com/thepirat000/Audit.NET/blob/master/CHANGELOG.md) file.

## ZZZ Projects - Sponsorship

[Entity Framework Extensions](https://entityframework-extensions.net/) and [Dapper Plus](https://dapper-plus.net/) are major sponsors and are proud to contribute to the development of Audit.NET

Combine the power of auditing with the speed of Bulk Operations to get the best of both worlds — audit and performance.

[![Entity Framework Extensions - Sponsor](https://raw.githubusercontent.com/thepirat000/Audit.NET/master/documents/entity-framework-extensions-sponsor.png)](https://entityframework-extensions.net/bulk-insert)

[![Dapper Plus - Sponsor](https://raw.githubusercontent.com/thepirat000/Audit.NET/master/documents/dapper-plus-sponsor.png)](https://dapper-plus.net/bulk-insert)

# Introduction

The **Audit Scope** and **Audit Event** are the central objects of this framework. 

### Audit Scope
The `AuditScope` serves as the central object in this framework, representing the scope of an audited operation or event. 
It acts as a context for auditing, capturing pertinent details like the start time, involved entities, and any additional 
custom information. Essentially, the `AuditScope` encapsulates an `AuditEvent`, controlling its life cycle.

The `AuditScope` is a disposable object, commonly utilized within a using statement to ensure proper finalization and recording of audit information upon exiting the scope.

See the [audit scope statechart](#auditscope-statechart).

### Audit Event
The `AuditEvent` functions as an extensible information container that captures the details of the audited operation, 
is the representation of the audited information within an Audit Scope.
It includes details about the audited operation, such as the event type, timestamp, execution duration, 
and any custom fields or properties. 

The `AuditEvent` is typically serialized into a format suitable for storage or transmission, such as JSON.

The audit events are stored using a **Data Provider**. You can use one of the [available data providers](https://github.com/thepirat000/Audit.NET?tab=readme-ov-file#storage-providers) or [implement your own](https://github.com/thepirat000/Audit.NET?tab=readme-ov-file#data-providers).

### Audit Scope Factory

The preferred method for creating audit scopes is by using an `IAuditScopeFactory` instance. 
This approach ensures a centralized and consistent configuration for all audit scopes.

```c#
var factory = new AuditScopeFactory();
using var scope = factory.Create(new AuditScopeOptions(...));
...
```

If you're using a DI container, you can register the `IAuditScopeFactory` as a service and inject it into your classes. 
The default implementation of `IAuditScopeFactory` is provided by the `AuditScopeFactory` class.

```c#
services.AddScoped<IAuditScopeFactory, AuditScopeFactory>();
```

Then you can inject the IAuditScopeFactory into your classes to create audit scopes:

```c#
public class MyService
{
  private readonly IAuditScopeFactory _auditScopeFactory;

  public MyService(IAuditScopeFactory auditScopeFactory)
  {
    _auditScopeFactory = auditScopeFactory;
  }

  public void MyMethod()
  {
    using var scope = _auditScopeFactory.Create(new AuditScopeOptions(...));
    ...
  }
}
```

You can also implement your own `IAuditScopeFactory` to customize the creation of audit scopes. 
The recommended approach is to inherit from the `AuditScopeFactory` class. 
By overriding the `OnConfiguring` and `OnScopeCreated` methods, you can configure the audit scope options before creation and customize the audit scope after creation respectively.

For example:

```c#
public class MyAuditScopeFactory : AuditScopeFactory
{
  private readonly IMyService _myService;
  public MyAuditScopeFactory(IMyService myService)
  {
    _myService = myService;
  }

  public override void OnConfiguring(AuditScopeOptions options)
  {
    // Set the data provider to use
    options.DataProvider = new SqlDataProvider(...);
  }

  public override void OnScopeCreated(AuditScope auditScope)
  {
    // Add a custom field to the audit scope
    auditScope.SetCustomField("CustomId", _myService.GetId());
  }
}
```

Several extensions for generating audit events, such as [Audit.EntityFramework.Core](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.EntityFramework/README.md), [Audit.WebApi.Core](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.WebApi/README.md), [Audit.Mvc.Core](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.Mvc/README.md), and [Audit.SignalR](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.SignalR/README.md), will automatically attempt to resolve the `IAuditScopeFactory` and `AuditDataProvider` instances from the service provider.

# Support for older .NET frameworks

Beginning with version 23.0.0, this library and its extensions have discontinued support for older .NET Framework and Entity Framework (versions that lost Microsoft support before 2023).

For reference, please consult the following links:

- [.NET Core Support Policy](https://dotnet.microsoft.com/en-us/platform/support/policy/dotnet-core)
- [Entity Framework Core releases](https://learn.microsoft.com/en-us/ef/core/what-is-new/#stable-releases)

This library and its extensions will maintain support for the following **minimum** .NET framework versions:

- .NET Framework 4.6.2 (net462)
- .NET Standard 2.0 (netstandard2.0)
- .NET 6 (net6.0)

## Usage

The **Audit Scope** is the central object of this framework. It encapsulates an audit event, controlling its life cycle. 
The **Audit Event** is an extensible information container of an audited operation. 

There are several ways to create an Audit Scope:

- Calling the `Create()` / `CreateAsync()` methods of an `AuditScopeFactory` instance.
This is the recommended approach. For example:

    ```c#
    var scope = auditScopeFactory.Create(new AuditScopeOptions(...));
    ```

- Using the overloads of the static methods `Create()` / `CreateAsync()` on `AuditScope`, for example:

    ```c#
    var scope = AuditScope.Create(new AuditScopeOptions()
    {
      EventType = "Order:Update",
      TargetGetter = () => order,
      ExtraFields = new { MyProperty = "value" }
    });
    ```

- Using the provided fluent API, for example:

    ```c#
    var scope = AuditScope.Create(_ => _
        .EventType("Order:Update")
        .ExtraFields(new { MyProperty = "value" })
        .Target(() => order));
    ```

#### AuditScope options

Option | Type | Description 
------------ | ---------------- | ---------------- 
EventType | `string` | A string representing the type of the event
TargetGetter | `Func<object>` | Target object getter (a func that returns the object to track)
ExtraFields | `object` | Anonymous object that contains additional fields to be merged into the audit event
DataProvider | `AuditDataProvider` | The [data provider](#data-providers) to use. Defaults to the DataProvider configured on `Audit.Core.Configuration.DataProvider`
CreationPolicy | `EventCreationPolicy` | The [creation policy](#creation-policy) to use. Default is `InsertOnEnd` 
IsCreateAndSave | `bool` | Value indicating whether this scope should be immediately ended and saved after creation. Default is false
AuditEvent | `AuditEvent` | Custom initial audit event to use. By default it will create a new instance of basic `AuditEvent`
SkipExtraFrames | `int` | Value used to indicate how many frames in the stack should be skipped to determine the calling method. Default is 0
CallingMethod | `MethodBase` | Specific calling method to store on the event. Default is to use the calling stack to determine the calling method.
Items | `Dictionary<string, object>` | A dictionary of items that can be used to store additional information on the scope, accessible from the `AuditScope` instance.

For instance, consider the following code to _cancel an order_ that you want to audit:

```c#
Order order = Db.GetOrder(orderId);
order.Status = -1;
order.OrderItems = null;
order = Db.OrderUpdate(order);
```

To audit this operation, you can wrap the code in a `using` block that initializes an `AuditScope`, specifying the target object to monitor:

```c#
Order order = Db.GetOrder(orderId);
using (AuditScope.Create("Order:Update", () => order))
{
  order.Status = -1;
  order.OrderItems = null;
  order = Db.OrderUpdate(order);
}
```

> **Note**
> 
> Using a `using` block is not required, but it streamlines the syntax when auditing a single code block. It also enables automatic exception detection and duration calculation by implicitly saving the event upon disposal. 

> **Note**
> 
> When using the [extensions](#extensions) that logs interactions with different systems, like [Audit.EntityFramework](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.EntityFramework/README.md), [Audit.WebApi](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.WebApi/README.md), etc. you don't need to explicitly create the `AuditScope` or `AuditEvent`, they are created internally by the extension.

### Simple logging

If you are not tracking an object or the duration of an event, you can use the `Log` shortcut method that logs an event immediately. 
For example:
```c#
AuditScope.Log("Event Type", new { ExtraField = "extra value" });
```

### Manual Saving

You can control the creation and saving logic, by creating a _manual_ `AuditScope`. For example to log a pair of `Start`/`End` method calls as a single event:

```c#
public class SomethingThatStartsAndEnds
{
    private AuditScope auditScope;

    public int Status { get; set; }

    public void Start()
    {
        // Create a manual scope
        auditScope = AuditScope.Create(new AuditScopeOptions()
        {
            EventType = "MyEvent",
            TargetGetter = () => this.Status,
            CreationPolicy = EventCreationPolicy.Manual
        });
    }

    public void End()
    {
        // Save the event
        auditScope.Save();  
        // Discard to avoid further saving
        auditScope.Discard();
    }
}
```

For more information about the `EventCreationPolicy` please see [Event Creation Policy](https://github.com/thepirat000/Audit.NET/blob/master/README.md#event-creation-policy) section.

## Output

The library will generate an output (`AuditEvent`) for each operation, including:
- Tracked object's state before and after the operation.
- Execution time and duration.
- Environment information such as user, machine, domain, locale, etc.
- [Comments and Custom Fields](#custom-fields-and-comments) provided.

An example of the output in JSON:

```javascript
{
    "EventType": "Order:Update",
    "Environment": {
        "UserName": "Federico",
        "MachineName": "HP",
        "DomainName": "HP",
        "CallingMethodName": "Audit.UnitTest.AuditTests.TestUpdate()",
        "Exception": null,
        "Culture": "en-GB"
    },
    "Activity": {
        "StartTimeUtc": "2023-12-01T17:36:52.2256288Z",
	"SpanId": "23a93b9e8cbc457f",
	"TraceId": "2d3e5e90f790c7d2274d9bb047531f66",
	"ParentId": "0000000000000000",
	"Operation": "Update"
    },
    "StartDate": "2016-08-23T11:33:14.653191Z",
    "EndDate": "2016-08-23T11:33:23.1820786Z",
    "Duration": 8529,
    "Target": {
        "Type": "Order",
        "Old": {
            "OrderId": "39dc0d86-d5fc-4d2e-b918-fb1a97710c99",
            "Status": 2,
            "OrderItems": [{
                "Sku": "1002",
                "Quantity": 3.0
            }]
        },
        "New": {
            "OrderId": "39dc0d86-d5fc-4d2e-b918-fb1a97710c99",
            "Status": -1,
            "OrderItems": null
        }
    }
}
```

## Output details

The following tables describe the output fields:

- ### [AuditEvent object](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/AuditEvent.cs)
Field Name | Type | Description 
------------ | ---------------- |  -------------- 
**EventType** | string | User-defined string to group the events 
**Environment** | [**Environment**](#environment-object) | Contains information about the execution environment 
**StartDate** | DateTime | Date and time when the event has started 
**EndDate** | DateTime | Date and time when the event has ended 
**Duration** | integer | Duration of the event in milliseconds 
**Target** | [**Target**](#target-object) | User-defined tracked object 
**Comments** | Array of strings | User-defined comments 
**CustomFields** | Dictionary | User-defined custom fields 


- ### [Environment object](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/AuditEventEnvironment.cs)
Field Name | Type | Description
------------ | ---------------- |  --------------
**UserName** | string | Current logged user name
**MachineName** | string | Executing machine name
**DomainName** | string | Current user domain
**CallingMethodName** | string | Calling method signature information
**StackTrace** | string | The full stack trace at the moment of the audit scope creation (NULL unless it's enabled by configuration)
**Exception** | string | Indicates if an Exception has been detected (NULL if no exception has been thrown)
**Culture** | string | Current culture identifier

- ### [Target object](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/AuditTarget.cs)
Field Name | Type | Description
------------ | ---------------- |  --------------
**Type** | string | Tracked object type name
**Old** | Object | Value of the tracked object at the beginning of the event
**New** | Object | Value of the tracked object at the end of the event

## Custom Fields and Comments

The `AuditScope` object provides two methods to extend the event output.

- Use `SetCustomField()` method to add any object as an extra field to the event.
- Use `Comment()` to add textual comments to the event's `Comments` array.

For example:

```c#
Order order = Db.GetOrder(orderId);
using (var audit = AuditScope.Create("Order:Update", () => order))
{
    audit.SetCustomField("ReferenceId", orderId);
    order.Status = -1;
    order = Db.OrderUpdate(order);
    audit.Comment("Status Updated to Cancelled");
}
```

You can also set Custom Fields when creating the `AuditScope`, by passing an anonymous object with the properties you want as extra fields. For example:

```c#
using (var audit = AuditScope.Create("Order:Update", () => order, new { ReferenceId = orderId }))
{
    order.Status = -1;
    order = Db.OrderUpdate(order);
    audit.Comment("Status Updated to Cancelled");
}
```

You can also access the Custom Fields directly from `Event.CustomFields` property of the scope. For example:
```c#
using (var audit = AuditScope.Create("Order:Update", () => order, new { ReferenceId = orderId }))
{
    audit.Event.CustomFields["ReferenceId"] = orderId;
}
```

> **Note**
> 
> Custom fields are not limited to single properties, you can store any object as well, by default they will be JSON serialized.

### Extending AuditEvent

Another way to enrich the event output is to create a class inheriting from the `AuditEvent` class, then you can pass an instance of your class to the AuditScope.Create method. For example:

```c#
public class YourAuditEvent : AuditEvent
{
    public Guid ReferenceId { get; set; } = Guid.NewGuid();
}

using (var scope = AuditScope.Create(new AuditScopeOptions { AuditEvent = new YourAuditEvent() }))
{
    //...
}
```

The output of the previous examples would be:

```javascript
{
    "EventType": "Order:Update",
    "Environment": {
        "UserName": "Federico",
        "MachineName": "HP",
        "DomainName": "HP",
        "CallingMethodName": "Audit.UnitTest.AuditTests.TestUpdate()",
        "Exception": null,
        "Culture": "en-GB"
    },
    "Target": {
        "Type": "Order",
        "Old": {
            "OrderId": "39dc0d86-d5fc-4d2e-b918-fb1a97710c99",
            "Status": 2,
            
        },
        "New": {
            "OrderId": "39dc0d86-d5fc-4d2e-b918-fb1a97710c99",
            "Status": -1,
            
        }
    },
    "ReferenceId": "39dc0d86-d5fc-4d2e-b918-fb1a97710c99",           // <-- Custom Field
    "Comments": ["Status Updated to Cancelled"],                     // <-- Comments
    "StartDate": "2016-08-23T11:34:44.656101-05:00",
    "EndDate": "2016-08-23T11:34:55.1810821-05:00",
    "Duration": 8531
}
```

## Discard option

The `AuditScope` object has a `Discard()` method to allow the user to discard an event. Discarding an event means it won't be saved.

For example, if you want to avoid saving the audit event under certain conditions:

```c#
using (var scope = AuditScope.Create(new AuditScopeOptions("SomeEvent", () => someTarget)))
{
    try
    {
        //some operation
        Critical.Operation();
    }
    catch (Exception ex)
    {
        //If an exception is thrown, discard the audit event
        scope.Discard();
    }
}
```

## Data providers

A _data provider_ (or _storage sink_) contains the logic to handle the audit event output, where you define what to do with the audit logs.

You can use one of the [data providers included](#data-providers-included) or inject your own mechanism 
by creating a class that implements `IAuditDataProvider` or inherits from `AuditDataProvider` and overrides its methods:

- `InsertEvent`: should store the event and return a unique ID. 
- `ReplaceEvent`: should update an event given its ID. This method is only used for [Creation Policies](#event-creation-policy) **Manual** or **InsertOnStartReplaceOnEnd**.

If your data provider supports asynchronous operations, you must also implement the following methods:

- `InsertEventAsync`: Asynchronous implementation of the InsertEvent method. 
- `ReplaceEventAsync`: Asynchronous implementation of the ReplaceEvent method.

If your data provider will support event retrieval, you should implement the following methods:

- `GetEvent`: Retrieves an event by id. 
- `GetEventAsync`: Asynchronous implementation of the GetEvent method. 


For example:
```c#
public class MyCustomDataProvider : AuditDataProvider
{
    public override object InsertEvent(AuditEvent auditEvent)
    {
        var fileName = $"Log{Guid.NewGuid()}.json";
        File.WriteAllText(fileName, auditEvent.ToJson());
        return fileName;
    }
    public override void ReplaceEvent(object eventId, AuditEvent auditEvent)
    {
        var fileName = eventId.ToString();
        File.WriteAllText(fileName, auditEvent.ToJson());
    }
    public override T GetEvent<T>(object eventId)
    {
        var fileName = eventId.ToString();
        return JsonConvert.DeserializeObject<T>(File.ReadAllText(fileName));
    }
    // async implementation:
    public override async Task<object> InsertEventAsync(AuditEvent auditEvent, CancellationToken cancellationToken = default)
    {
        var fileName = $"Log{Guid.NewGuid()}.json";
        await File.WriteAllTextAsync(fileName, auditEvent.ToJson(), cancellationToken);
        return fileName;
    }
    public override async Task ReplaceEventAsync(object eventId, AuditEvent auditEvent, CancellationToken cancellationToken = default)
    {
        var fileName = eventId.ToString();
        await File.WriteAllTextAsync(fileName, auditEvent.ToJson(), cancellationToken);
    }
    public override async Task<T> GetEventAsync<T>(object eventId, CancellationToken cancellationToken = default)
    {
        var fileName = eventId.ToString();
        return await GetFromFileAsync<T>(cancellationToken);
    }
}
```

### Data provider selection

The data provider can be set globally for the entire application or per audit scope.

> **Note**
> 
> If you don't specify a global data provider, it will default to a `FileDataProvider` that logs events as .json files into the current working directory.

To set the global data provider, assign the `DataProvider` property on the static `Audit.Core.Configuration` object, or call the fluent API `Use()`. For example:

```c#
Audit.Core.Configuration.DataProvider = new MyCustomDataProvider();
```

Or using the fluent API `Use()` method:

```c#
Audit.Core.Configuration.Setup()
  .Use(new MyCustomDataProvider());
```

To set the data provider per-scope, use the `AuditScopeOptions` when creating an `AuditScope`. For example:

```c#
var scope = AuditScope.Create(new AuditScopeOptions 
{ 
  DataProvider = new MyCustomDataProvider(), ... }
);
```

Every data provider is accompanied by a fluent API accessible during object construction or via its respective `Use___()` method. 
For instance, in the case of the [SqlDataProvider]((https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.SqlServer/README.md)):

```c#
var sqlDataProvider = new SqlDataProvider(_ => _
    .ConnectionString("your connection string")
    .TableName("your table name")
    .IdColumnName("your id column name")
    .JsonColumnName("your json column name"));
```

```c#
Audit.Core.Configuration.Setup()
  .UseSqlServer(_ => _
    .ConnectionString("your connection string")
    .TableName("your table name")
    .IdColumnName("your id column name")
    .JsonColumnName("your json column name"));
```

### Data provider wrappers

A special type of Data Providers that allows wrapping other Data Provider with different purposes.

#### Dynamic data provider

As an alternative to creating a data provider class, you can define the mechanism at run time by using the `DynamicDataProvider` or `DynamicAsyncDataProvider` classes. For example:

```c#
Audit.Core.Configuration.Setup()
  .UseDynamicProvider(config => config
    .OnInsert(ev => Console.Write(ev.ToJson())));
```

For async operations, you should use the `DynamicAsyncDataProvider`, for example:

```c#
Audit.Core.Configuration.Setup()
  .UseDynamicAsyncProvider(config => config
    .OnInsert(async ev => await File.WriteAllTextAsync(filePath, ev.ToJson())));
```

#### Lazy Factory data provider

You can set the global data provider using a deferred instantiation technique, with a **lazy factory method** that will be called upon its initial utilization. 
For instance, in situations where dependency resolution is needed but not immediately accessible during initialization.

Allows to lazily instantiate the data provider to use. The data provider factory method will be called only once; the first time it's needed.

For example:

```c#
Audit.Core.Configuration.Setup()
    .UseLazyFactory(() => app.ApplicationServices.GetService<CustomDataProvider>());
```

#### Deferred Factory data provider

You can defer creating the data provider for each Audit Event until it is ready to be saved by using a **deferred factory method**. 
The factory method will be called for each audit event being saved. 

For example:

```c#
var sqlDataProvider = new SqlDataProvider(config => config...);
var fileDataProvider = new FileDataProvider(config => config...);

Audit.Core.Configuration.Setup()
    .UseDeferredFactory(auditEvent => auditEvent is AuditEventWebApi ? sqlDataProvider : fileDataProvider);
```

#### Conditional data provider

Enables the configuration of different data providers based on conditions related to the audit event.
  
For example:

```c#
Configuration.DataProvider = new ConditionalDataProvider(config => config
  .When(auditEvent => auditEvent.EventType.Equals("A"), new MyCustomDataProvider())
  .When(auditEvent => auditEvent.EventType.Equals("B"), new SqlDataProvider())
  .Otherwise(new FileDataProvider()));
```

#### Polly data provider

Allows to define [Polly](https://www.pollydocs.org/index.html) resilience strategies to any [Data Provider](https://github.com/thepirat000/Audit.NET?tab=readme-ov-file#data-providers).

This is useful when you want to add resilience to your data provider, for example, to retry failed operations, or to add a circuit breaker.

For example:

```c#
Audit.Core.Configuration.Setup()
  .UsePolly(p => p
    .DataProvider(new SqlDataProvider(...))
    .WithResilience(resilience => resilience
      .AddRetry(new()
      {
        ShouldHandle = new PredicateBuilder().Handle<SqlException>(),
        MaxRetryAttempts = 2
      })));
```       

For more information, please refer to the [Audit.NET.Polly documentation](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Polly/README.md).

### Data providers included

The Data Providers included are summarized in the following table:

| **Type** | **Technology**    | **Package / Class**                                                                                                                                                                                                                                                                                                       | **Description**                                                                                                              | **[Configuration API](#configuration-fluent-api)**     |
|----------|-------------------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------|
| SQL      | Amazon QLDB       | [Audit.NET.AmazonQLDB](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.AmazonQLDB/README.md) / [AmazonQldbDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.AmazonQLDB/Providers/AmazonQldbDataProvider.cs)                                                             | Store the audit events using [Amazon QLDB](https://aws.amazon.com/es/qldb/).                                                 | `.UseAmazonQldb()`                                     |
| SQL      | Entity Framework  | [Audit.EntityFramework](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.EntityFramework/README.md#entity-framework-data-provider) / [EntityFrameworkDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.EntityFramework/Providers/EntityFrameworkDataProvider.cs)                 | Store EntityFramework audit events in the same EF context. (This data provider can only be used for Entity Framework audits) | `.UseEntityFramework()`                                |
| SQL      | EF Core DbContext | [Audit.EntityFramework](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.EntityFramework/README.md#entity-framework-data-provider) / [DbContextDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.EntityFramework/Providers/DbContextDataProvider.cs)                             | Store the events using Entity Framework Core DbContext. (This data provider can be used for any kind of audits events)       | `.UseDbContext()`                                      |
| SQL      | MySql             | [Audit.NET.MySql](https://github.com/thepirat000/Audit.NET/tree/master/src/Audit.NET.MySql#auditnetmysql) / [MySqlDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.MySql/Providers/MySqlDataProvider.cs)                                                                                  | Store the events as rows in a **MySQL** database table, in JSON format.                                                      | `.UseMySql()`                                          |
| SQL      | Postgre SQL       | [Audit.NET.PostgreSql](https://github.com/thepirat000/Audit.NET/tree/master/src/Audit.NET.PostgreSql#auditnetpostgresql) / [PostgreSqlDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.PostgreSql/Providers/PostgreSqlDataProvider.cs)                                                    | Store the events as rows in a **PostgreSQL** database table, in JSON format.                                                 | `.UsePostgreSql()`                                     |
| SQL      | SQL Server        | [Audit.NET.SqlServer](https://github.com/thepirat000/Audit.NET/tree/master/src/Audit.NET.SqlServer#auditnetsqlserver) / [SqlDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.SqlServer/Providers/SqlDataProvider.cs)                                                                      | Store the events as rows in a **MS SQL** Table, in JSON format.                                                              | `.UseSqlServer()`                                      |
| NoSQL    | Azure Cosmos      | [Audit.NET.AzureCosmos](https://github.com/thepirat000/Audit.NET/tree/master/src/Audit.NET.AzureCosmos#auditnetazurecosmos) / [AzureCosmosDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.AzureCosmos/Providers/AzureCosmosDataProvider.cs)                                              | Store the events in an **Azure Cosmos DB** container, in JSON format.                                                        | `.UseAzureCosmos()`                                    |
| NoSQL    | Azure Event Hub   | [Audit.NET.AzureEventHubs](https://github.com/thepirat000/Audit.NET/tree/master/src/Audit.NET.AzureEventHubs) / [AzureEventHubsDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.AzureEventHubs/Providers/AzureEventHubsDataProvider.cs)                                                   | Send the events to an **Azure Event Hub**, in JSON format.                                                                   | `.UseAzureEventHubs()`                                 |
| NoSQL    | Azure Storage     | [Audit.NET.AzureStorageBlobs](https://github.com/thepirat000/Audit.NET/tree/master/src/Audit.NET.AzureStorageBlobs) / [AzureStorageBlobDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.AzureStorageBlobs/Providers/AzureStorageBlobDataProvider.cs)                                      | Store the events in an **Azure Blob Storage** container, in JSON format.                                                     | `.UseAzureStorageBlobs()`                              |
| NoSQL    | Azure Tables      | [Audit.NET.AzureStorageTables](https://github.com/thepirat000/Audit.NET/tree/master/src/Audit.NET.AzureStorageTables) / [AzureStorageTableDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.AzureStorageTables/Providers/AzureTableDataProvider.cs)                                        | Store the events in an **Azure Table Storage**.                                                                              | `.UseAzureTableStorage()`                              |
| NoSQL    | Dynamo DB         | [Audit.NET.DynamoDB](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.DynamoDB/README.md) / [DynamoDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.DynamoDB/Providers/DynamoDataProvider.cs)                                                                           | Store audit events in [Amazon DynamoDB™](https://aws.amazon.com/dynamodb/) tables.                                           | `.UseDynamoDB()`                                       |
| NoSQL    | Elasticsearch     | [Audit.NET.Elasticsearch](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.ElasticSearch/README.md) / [ElasticsearchDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.ElasticSearch/Providers/ElasticsearchDataProvider.cs)                                              | Store audit events in Elasticsearch indices.                                                                                 | `.UseElasticsearch()`                                  |
| NoSQL    | Firestore         | [Audit.NET.Firestore](https://github.com/thepirat000/Audit.NET/tree/master/src/Audit.NET.Firestore#auditnetfirestore) / [FirestoreDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Firestore/Providers/FirestoreDataProvider.cs)                                                        | Store the events in a **Google Cloud Firestore** collection, in JSON format.                                                 | `.UseFirestore()`                                      |
| NoSQL    | Kafka             | [Audit.NET.Kafka](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Kafka/README.md) / [KafkaDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Kafka/Providers/KafkaDataProvider.cs)                                                                                      | Stream the audit events to [Apache Kafka](https://kafka.apache.org/) topics.                                                 | `.UseKafka()` / `.UseKafka<TKey>()`                    |
| NoSQL    | Mongo DB          | [Audit.NET.MongoDB](https://github.com/thepirat000/Audit.NET/tree/master/src/Audit.NET.MongoDB#auditnetmongodb) / [MongoDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.MongoDB/Providers/MongoDataProvider.cs)                                                                          | Store the events in a **Mongo DB** collection, in BSON format.                                                               | `.UseMongoDB()`                                        |
| NoSQL    | OpenSearch        | [Audit.NET.OpenSearch](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.OpenSearch/README.md) / [OpenSearchDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.OpenSearch/Providers/OpenSearchDataProvider.cs)                                                             | Store audit events in OpenSearch indices.                                                                                    | `.UseOpenSearch()`                                  |
| NoSQL    | Raven DB          | [Audit.NET.RavenDB](https://github.com/thepirat000/Audit.NET/tree/master/src/Audit.NET.RavenDB#auditnetravendb) / [RavenDbDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.RavenDB/Providers/RavenDbSqlDataProvider.cs)                                                                   | Store the events as documents in a **Raven DB** database table, in JSON format.                                              | `.UseRavenDB()`                                        |
| NoSQL    | Redis             | [Audit.NET.Redis](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Redis/README.md) / [RedisDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Redis/Providers/RedisDataProvider.cs)                                                                                      | Store audit logs in Redis as Strings, Lists, SortedSets, Hashes, Streams or publish to a PubSub channel.                     | `.UseRedis()`                                          |
| NoSQL    | Immu DB           | [Audit.NET.ImmuDB](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.ImmuDB/README.md) / [ImmuDbDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.ImmuDB/Providers/ImmuDbDataProvider.cs)                                                                                 | Store audit events in an [ImmuDB](https://immudb.io/) immutable database                                                     | `.UseImmuDb()`                                         |
| Local    | Windows Event Log | [Audit.NET](https://github.com/thepirat000/Audit.NET) / [Audit.NET.EventLog.Core](https://github.com/thepirat000/Audit.NET/tree/master/src/Audit.NET.EventLog.Core) 7 [EventLogDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/Providers/EventLogDataProvider.cs)                        | Write the audit logs to the Windows EventLog.                                                                                | `.UseEventLogProvider()`                               |
| Local    | File System       | [Audit.NET](https://github.com/thepirat000/Audit.NET) / [FileDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/Providers/FileDataProvider.cs)                                                                                                                                              | Store the audit logs as files. Dynamically configure the directory and path.                                                 | `.UseFileLogProvider()`                                |
| Tracing  | OpenTelemetry     | [Audit.NET](https://github.com/thepirat000/Audit.NET) / [ActivityDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/Providers/ActivityDataProvider.cs)                                                                                                                                      | Emits each AuditEvent as a System.Diagnostics.Activity span via an ActivitySource.                                           | `.UseActivityProvider()`                               |
| InMemory | In-Memory List    | [Audit.NET](https://github.com/thepirat000/Audit.NET) / [InMemoryDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/Providers/InMemoryDataProvider.cs)                                                                                                                                      | Store the audit logs in memory in a thread-safe list. Useful for testing purposes.                                           | `.UseInMemoryProvider()`                               |
| InMemory | In-Memory Blocking Collection | [Audit.NET](https://github.com/thepirat000/Audit.NET) / [BlockingCollectionDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/Providers/BlockingCollectionDataProvider.cs)                                                                                                      | Store the audit events in a BlockingCollection that can be accessed by different threads to consume the events               | `.UseInMemoryBlockingCollectionProvider()`             |
| InMemory | In-Memory Channel | [Audit.NET.Channels](https://github.com/thepirat000/Audit.NET/tree/master/src/Audit.NET.Channels/README.md) / [ChannelDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Channels/Providers/ChannelDataProvider.cs)                                                                                                                                      | Store the audit events in a Channel (from System.Threading.Channels) that can be accessed to consume the events      | `.UseInMemoryChannelProvider()`                        |
| Logging  | Log4net           | [Audit.NET.log4net](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.log4net/README.md) / [Log4netDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.log4net/Providers/Log4netDataProvider.cs)                                                                            | Store the audit events using [Apache log4net™](https://logging.apache.org/log4net/).                                         | `.UseLog4net()`                                        |
| Logging  | NLog              | [Audit.NET.NLog](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.NLog/README.md) / [NLogDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.NLog/Providers/NLogDataProvider.cs)                                                                                           | Store the audit events using [NLog](https://nlog-project.org/).                                                              | `.UseNLog()`                                           |
| Logging  | Serilog           | [Audit.NET.Serilog](https://github.com/thepirat000/Audit.NET/tree/master/src/Audit.NET.Serilog/README.md) / [SerilogDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Serilog/Providers/SerilogDataProvider.cs)                                                                            | Store the audit events using [Serilog™](https://serilog.net/)                                                                | `.UseSerilog()`                                        |
| Network  | UDP               | [Audit.NET.Udp](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Udp/README.md) / [UdpDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Udp/Providers/UdpDataProvider.cs)                                                                                                | Send Audit Logs as UDP datagrams to a network.                                                                               | `.UseUdp()`                                            |
| Wrapper  | Conditional       | [Audit.NET](https://github.com/thepirat000/Audit.NET) / [ConditionalDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/Providers/Wrappers/ConditionalDataProvider.cs)                                                                                                                       | Allows the configuration of different data providers based on conditions related to the audit event.                         | `.UseConditional()`                                    |
| Wrapper  | Deferred          | [Audit.NET](https://github.com/thepirat000/Audit.NET) / [DeferredDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/Providers/Wrappers/DeferredDataProvider.cs)                                                                                                                             | Facilitates delayed data provider instantiation via a factory method that is invoked for each Audit Event.                   | `.UseDeferredFactory()`                                |
| Wrapper  | Dynamic           | [Audit.NET](https://github.com/thepirat000/Audit.NET) / [DynamicDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/Providers/DynamicDataProvider.cs) / [DynamicAsyncDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/Providers/DynamicAsyncDataProvider.cs) | Dynamically change the behavior at run-time. Define _Insert_ and a _Replace_ actions with lambda expressions.                | `.UseDynamicProvider()` / `.UseDynamicAsyncProvider()` |
| Wrapper  | Lazy              | [Audit.NET](https://github.com/thepirat000/Audit.NET) / [LazyDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/Providers/Wrappers/LazyDataProvider.cs)                                                                                                                                     | Facilitates delayed data provider instantiation via a factory method that is invoked just once, upon the initial need.       | `.UseLazyFactory()`                                    |
| Wrapper  | Polly             | [Audit.NET.Polly](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Polly/README.md) / [PollyDataProvider](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Polly/Providers/PollyDataProvider.cs)                                                                                      | Allows to define [Polly](https://www.pollydocs.org/index.html) resilience strategies to any Data Provider                    | `.UsePolly()`                                          |


## Event Creation Policy

The audit scope allows configuration for invoking its data provider through different approaches:

- **Insert on End** (default): The audit event is recorded when the scope is disposed.

- **Insert on Start, Replace on End**: The initial state of the event is recorded upon scope creation, and the complete event information is updated when the scope is disposed.

- **Insert on Start, Insert on End**: Two versions of the event are recorded—one at scope creation and another at scope disposal.

- **Manual**: Event saving (insert or replace) must be explicitly triggered by calling the `Save()` method on the `AuditScope`.

The Creation Policy can be set on a per-scope basis. For example, to configure the policy explicitly to Manual:

```c#
using (var scope = AuditScope.Create(new AuditScopeOptions { CreationPolicy = EventCreationPolicy.Manual }))
{
    //...
    scope.Save();
}
```

> **Note**
> 
> If you don't provide a Creation Policy when creating the `AuditScope`, the globally configured Creation Policy will be used (see the [configuration](#configuration) section)

## AuditScope statechart

The following is the internal state machine representation of the `AuditScope` object:

<img src="https://i.imgur.com/7WqGECe.png" alt="AuditScope statecart" />

# Configuration

### Data provider
To change the default data provider, set the static property `DataProvider` on `Audit.Core.Configuration` class. This should be done before the `AuditScope` creation, i.e. during application startup.

For example, to set your own provider as the default data provider:
```c#
Audit.Core.Configuration.DataProvider = new MyCustomDataProvider();
```

> **Note**
> 
> If you don't specify a Data Provider, a default `FileDataProvider` will be used to write the events as .json files into the current working directory.

### Creation Policy
To change the default creation policy, set the static property `CreationPolicy` on `Audit.Core.Configuration` class. This should be done before the `AuditScope` creation, i.e. during application startup.
 
For example, to set the default creation policy to Manual:
```c#
Audit.Core.Configuration.CreationPolicy = EventCreationPolicy.Manual;
```

> **Note**
> 
> If you don't specify a Creation Policy, the default `Insert on End` will be used.

### Custom Actions
You can configure Custom Actions to be executed across all Audit Scopes in your application. 
This allows you to globally modify behavior and data, intercepting scopes after they are created, before they are saved, or during disposal

Call the static `AddCustomAction()` method on `Audit.Core.Configuration` class to attach a custom action. 

For example, to globally discard the events under a certain condition:
```c#
Audit.Core.Configuration.AddCustomAction(ActionType.OnScopeCreated, scope =>
{
    if (DateTime.Now.Hour >= 17)
    {
        scope.Discard();
        return false;
    }
    return true;
});
```

> **Note**
> 
> The custom actions can return a boolean value to indicate if subsequent actions of the same type should be executed.


Or to add custom fields/comments globally to all scopes:
```c#
Audit.Core.Configuration.AddCustomAction(ActionType.OnEventSaving, scope =>
{
    if (scope.Event.Environment.Exception != null)
    {
        scope.SetCustomField("Oops", true);
    }
    scope.Comment("Saved at " + DateTime.Now);
});
```

Custom actions can also be asynchronous, for example:
```c#
Audit.Core.Configuration.AddCustomAction(ActionType.OnScopeCreated, async scope =>
{
    var result = await svcProvider.GetService<InfoService>().GetInfoAsync();
    scope.SetCustomField("Info", result);
});
```

The `ActionType` indicates when to perform the action. The allowed values are:
- `OnScopeCreated`: When the Audit Scope is being created, before any saving. This is executed once per Audit Scope.
- `OnEventSaving`: When an Audit Scope's Event is about to be saved. 
- `OnEventSaved`: After an Audit Scope's Event is saved. 
- `OnScopeDisposed`: When an Audit Scope is disposed.

### Stack Trace

To include the stack trace details into the event environment, ensure that the `IncludeStackTrace` configuration is set to `true`. Default is `false`.

```c#
Audit.Core.Configuration.IncludeStackTrace = true;
```

or 

```c#
Audit.Core.Configuration.Setup()
    .IncludeStackTrace();
```

### Activity Trace

To include the current activity trace details from [System.Diagnostics.Activity](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.activity?view=net-8.0) 
API into the event, ensure that the `IncludeActivityTrace` configuration is set to `true`. The default is `false`.

It will include the current `Activity` operation name, ID, and StartTime, along with associated Tags and Events.

```c#
Audit.Core.Configuration.IncludeActivityTrace = true;
```

or 

```c#
Audit.Core.Configuration.Setup()
    .IncludeActivityTrace();
```

To create and start a new distributed activity trace, you can use the `StartActivityTrace` configuration:

```c#
Audit.Core.Configuration.Setup()
    .StartActivityTrace();
```

If you require more control over the creation of the activity trace, use the ActivityDataProvider instead.

### Global switch off

You can disable audit logging by setting the static property `Configuration.AuditDisabled` to `true`. 
The audit events are globally ignored while this flag is set. For example to disable the audits on certain environments:

```c#
if (environment.IsDevelopment())
{
    Audit.Core.Configuration.AuditDisabled = true;
}
```

### Global serialization settings

Most of the data providers serialize audit events in JSON format. Audit.NET uses `System.Text.Json` by default for the serialization and deserialization of audit events. 

If you want to change the behavior, you can change the settings via the static property `Configuration.JsonSettings`.

For example:

```c#
Audit.Core.Configuration.JsonSettings = new JsonSerializerOptions
{
    DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault,
    AllowTrailingCommas = true
};
```

#### Custom serialization mechanism

If you want to use a custom JSON serialization mechanism for the Audit Events, you can create a class implementing `IJsonAdapter` and assign it to the 
static property `Configuration.JsonAdapter`.

For example:
```c#
Audit.Core.Configuration.JsonAdapter = new MyCustomAdapter(); 
```

Or by using the fluent API:
```c#
Audit.Core.Configuration.Setup()
    .JsonAdapter<MyCustomAdapter>()
    ...
```

> **Note**
> 
> Take into account that some of the `AuditEvent` properties rely on attribute decoration for serialization and deserialization.
> The recommendation is to use the default adapter and, when needed, use the Newtonsoft Json adapter provided (see next section).

#### Alternative serialization mechanism

This library offers the option to configure an alternative JSON serialization mechanism through the following adapter:

- [`Audit.NET.JsonNewtonsoftAdapter`](https://github.com/thepirat000/Audit.NET/tree/master/src/Audit.NET.JsonNewtonsoftAdapter)

    Use this when you prefer employing Newtonsoft.Json as the serialization mechanism.

    Assign an instance of `JsonNewtonsoftAdapter` to the static configuration property `Configuration.JsonAdapter`. For example:

    ```c#
    var settings = new JsonSerializerSettings()
    {
        TypeNameHandling = TypeNameHandling.All
    };
    Audit.Core.Configuration.JsonAdapter = new JsonNewtonsoftAdapter(settings);
    ```

    Alternatively, you can use the fluent configuration API with the `JsonNewtonsoftAdapter()` method, like this:


    ```c#
    Audit.Core.Configuration.Setup()
        .JsonNewtonsoftAdapter(settings)
        ...
    ```

    > NOTE: This `JsonNewtonsoftAdapter` takes into account `JsonExtensionDataAttribute` and `JsonIgnoreAttribute` decorators from both `System.Text.Json` and `Newtonsoft.Json`, so the Audit Events 
    > will be properly serialized.

## Configuration Fluent API
Alternatively to the properties/methods mentioned before, you can configure the library using a convenient [Fluent API](http://martinfowler.com/bliki/FluentInterface.html) provided by the method `Audit.Core.Configuration.Setup()`, this is the most straightforward way to configure the library.

For example, to set the FileLog Provider with its default settings using a Manual creation policy:
```c#
Audit.Core.Configuration.Setup
    .IncludeStackTrace()
    .IncludeActivityTrace()
    .UseFileLogProvider()
    .WithCreationPolicy(EventCreationPolicy.Manual);
```

## Configuration examples

##### File log provider with dynamic directory path and filename:
```c#
Audit.Core.Configuration.Setup()
    .UseFileLogProvider(config => config
        .DirectoryBuilder(_ => $@"C:\Logs\{DateTime.Now:yyyy-MM-dd}")
        .FilenameBuilder(auditEvent => $"{auditEvent.Environment.UserName}_{DateTime.Now.Ticks}.json"));
```

##### File log provider with an InsertOnStart-ReplaceOnEnd creation policy, and a global custom field set in a custom action:
```c#
Audit.Core.Configuration.Setup()
    .UseFileLogProvider(config => config
        .FilenamePrefix("Event_")
        .Directory(@"C:\AuditLogs\1"))
    .WithCreationPolicy(EventCreationPolicy.InsertOnStartReplaceOnEnd)
    .WithAction(x => x.OnScopeCreated(scope => scope.SetCustomField("ApplicationId", "MyApplication")));
```


##### Event log provider with an InsertOnEnd creation policy:
```c#
Audit.Core.Configuration.Setup()
    .UseEventLogProvider(config => config
        .SourcePath("My Audited Application")
        .LogName("Application"))
    .WithCreationPolicy(EventCreationPolicy.InsertOnEnd);
```

##### Dynamic provider to log to the console:
```c#
Audit.Core.Configuration.Setup()
    .UseDynamicProvider(config => config
        .OnInsert(ev => Console.WriteLine("{0}: {1}->{2}", ev.StartDate, ev.Environment.UserName, ev.EventType)));
```

##### Multiple providers with conditional logic:

```c#
var sqlDataProvider = new SqlDataProvider(sql => sql.ConnectionString(CnnString).TableName("Logs"));
var fileDataProvider = new FileDataProvider(file => file.Directory(@"C:\logs"));

Audit.Core.Configuration.Setup()
    .UseConditional(c => c
        .When(ev => ev.EventType == "API", sqlDataProvider)
        .Otherwise(fileDataProvider));
```

##### Activity data provider:

```c#
Audit.Core.Configuration.Setup()
    .UseActivityProvider(config => config
        .Source("MyApp", "2.0")
        .ActivityName(auditEvent => auditEvent.EventType)
        .IncludeDefaultTags()
        .AdditionalTags(auditEvent => new Dictionary<string, object>
        {
            { "Application", "MyApp" }
        })
        .OnActivityCreated((activity, auditEvent) =>
        {
            activity.SetTag("event.json", auditEvent.ToJson());
            activity.SetCustomProperty("event", auditEvent);
        }));

```

##### Firestore data provider:

```c#
Audit.Core.Configuration.Setup()
    .UseFirestore(config => config
        .ProjectId("my-project-id")
        .Collection("audit-events")
        .CredentialsFilePath("path/to/credentials.json"));
```

-----------

# Extensions

The following packages are extensions to log interactions with different systems such as MVC, ASP.NET Web APIs, WCF, and Entity Framework: 

<a></a> | Package | Description 
------------ | ------------------- | ------------------
<img src="https://i.imgur.com/hVMM5WF.png" alt="icon" width="90"/> | **[Audit.DynamicProxy](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.DynamicProxy/README.md)** | Generate detailed audit logs for **any class** without changing its code by using a proxy.
<img src="https://i.imgur.com/wdVHFoc.png" alt="icon" width="90"/> | **[Audit.EntityFramework](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.EntityFramework/README.md)** | Generate detailed audit logs for saving operations on **Entity Framework**, by inheriting from a provided `DbContext` or `IdentityDbContext`.  Includes support for EF 6 and EF 7 (EF Core).
<img src="https://i.imgur.com/Fn4thn0.png" alt="icon" width="90"/> | **[Audit.FileSystem](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.FileSystem/README.md)** | Generate audit logs by intercepting **file system** events via FileSystemWatcher.
<img src="https://i.imgur.com/8lV5DRk.png" alt="icon" width="90" /> | **[Audit.HttpClient](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.HttpClient/README.md)** | Generate detailed client-side audit logs for **HttpClient** REST calls, by configuring a provided message handler.
<img src="https://i.imgur.com/ap6CeoG.png" alt="icon" width="90"/> | **[Audit.MVC](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.Mvc/README.md)** | Generate detailed audit logs by decorating **MVC** Actions and Controllers with an action filter attribute. Includes support for ASP.NET Core MVC.
<img src="https://i.imgur.com/GB2e52X.jpg" alt="icon" width="90"/> | **[Audit.SignalR](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.SignalR/README.md)** | Generate audit logs for **SignalR** and **SignalR Core** invocations by intercepting the hub processing
<img src="https://i.imgur.com/p6knit4.png" alt="icon" width="90" /> | **[Audit.WCF](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.WCF/README.md)** | Generate detailed **server-side** audit logs for **Windows Communication Foundation (WCF)** service calls, by configuring a provided behavior.
<img src="https://i.imgur.com/p6knit4.png" alt="icon" width="90" /> | **[Audit.WCF.Client](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.WCF.Client/README.md)** | Generate detailed **client-side** audit logs for **Windows Communication Foundation (WCF)** service calls, by configuring a provided behavior.
<img src="https://i.imgur.com/9go2b0f.png" alt="icon" width="90"/> | **[Audit.WebApi](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.WebApi/README.md)** | Generate detailed audit logs by decorating **Web API** Methods and Controllers with an action filter attribute, or by using a middleware. Includes support for ASP.NET Core.
<img src="https://i.imgur.com/1nMVLQo.png" alt="icon" width="90"/> | **[Audit.MongoClient](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.MongoClient/README.md)** | Generate detailed audit logs by adding a [Command Event Subscriber](https://mongodb.github.io/mongo-csharp-driver/2.8/reference/driver_core/events/) into the configuration of the MongoDB Driver.

# Data providers

A Data Provider (or Storage Provider) is a component responsible for handling how audit event data is stored or processed. The purpose of the Data Provider is to manage the persistence of audit logs once an audit event is triggered and captured. The Data Provider defines how the Audit Event is saved.

Audit.NET offers a range of built-in Data Providers for various storage solutions, including [File System](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/Providers/FileDataProvider.cs), [Event Log](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/Providers/EventLogDataProvider.cs), [InMemory List](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/Providers/InMemoryDataProvider.cs), and [InMemory Blocking Collection](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET/Providers/BlockingCollectionDataProvider.cs). 

Moreover, several [Data Provider Wrappers](#data-provider-wrappers) are available to encapsulate other Data Providers for various purposes, such as resilience and lazy instantiation. Examples include [Polly](#polly-data-provider), [Lazy](#lazy-factory-data-provider), [Deferred](#deferred-factory-data-provider), and [Conditional](#conditional-data-provider).

In addition, a variety of other Data Providers are available through separate packages, as shown below:

<a></a> | Package | Description
------------- | ------------------- | ------------------
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/amazondynamodb.svg" /> | **[Audit.NET.AmazonQLDB](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.AmazonQLDB/README.md)** | Store the audit events in **Amazon QLDB** (Quantum Ledger Database).
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/microsoftazure.svg" /> | **[Audit.NET.AzureCosmos](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.AzureCosmos/README.md)** | Store the events in an **Azure Cosmos DB** container, in JSON format.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/microsoftazure.svg" /> | **[Audit.NET.AzureEventHubs](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.AzureEventHubs/README.md)** | Send the events to an **Azure Event Hub**, in JSON format.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/microsoftazure.svg" /> | **[Audit.NET.AzureStorage](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.AzureStorage/README.md)** | Store the events in an **Azure Blob Storage** container or an **Azure Table** using the legacy client [WindowsAzure.Storage](https://www.nuget.org/packages/WindowsAzure.Storage/).
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/microsoftazure.svg" /> | **[Audit.NET.AzureStorageBlobs](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.AzureStorageBlobs/README.md)** | Store the events in an **Azure Blob Storage** container using the latest client [Azure.Storage.Blobs](https://docs.microsoft.com/en-us/dotnet/api/overview/azure/storage.blobs-readme).
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/microsoftazure.svg" /> | **[Audit.NET.AzureStorageTables](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.AzureStorageTables/README.md)** | Store the events in an **Azure Table Storage** using the latest client [Azure.Data.Tables](https://docs.microsoft.com/en-us/dotnet/api/overview/azure/data.tables-readme).
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/csharp.svg" /> | **[Audit.NET.Channels](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Channels/README.md)** | Store the audit events in a Channel (from System.Threading.Channels) that can be accessed to consume the events.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/amazondynamodb.svg" /> | **[Audit.NET.DynamoDB](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.DynamoDB/README.md)** | Store the audit events in Amazon DynamoDB tables.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/elasticsearch.svg" /> | **[Audit.NET.Elasticsearch](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.ElasticSearch/README.md)** | Store the audit events in Elasticsearch indices.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/firebase.svg" /> | **[Audit.NET.Firestore](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Firestore/README.md)** | Store the audit events in Google Cloud Firestore collections.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/csharp.svg" /> | **[Audit.NET.ImmuDB](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.ImmuDB/README.md)** | Store audit events in an [ImmuDB](https://immudb.io/) immutable database.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/apachekafka.svg" /> | **[Audit.NET.Kafka](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Kafka/README.md)** | Stream the audit events to an **Apache Kafka** server.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/csharp.svg" /> | **[Audit.NET.log4net](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.log4net/README.md)** | Store the audit events using Apache log4net™.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/mongodb.svg" /> | **[Audit.NET.MongoDB](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.MongoDB/README.md)** | Store the events in a **Mongo DB** Collection, in BSON format.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/mysql.svg" /> | **[Audit.NET.MySql](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.MySql/README.md)** | Store the events as rows in **MySQL** database, in JSON format.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/csharp.svg" /> | **[Audit.NET.NLog](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.NLog/README.md)** | Store the audit events using NLog™.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/opensearch.svg" /> | **[Audit.NET.OpenSearch](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.OpenSearch/README.md)** | Store the audit events in OpenSearch indices.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/csharp.svg" /> | **[Audit.NET.Polly](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Polly/README.md)** | Define [Polly](https://www.pollydocs.org/) resiliencie strategies to any data provider.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/postgresql.svg" /> | **[Audit.NET.PostgreSql](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.PostgreSql/README.md)** | Store the events as rows in a **PostgreSQL** database, in JSON format.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/csharp.svg" /> | **[Audit.NET.RavenDB](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.RavenDB/README.md)** | Store the events as documents in a **Raven DB** database, in JSON format.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/redis.svg" /> | **[Audit.NET.Redis](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Redis/README.md)** | Store Audit Logs in a **Redis** database as String, List, Hash, Sorted Set, Streams or publishing to a Redis PubSub channel.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/microsoftsqlserver.svg" /> | **[Audit.NET.SqlServer](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.SqlServer/README.md)** | Store the events as rows in a **SQL** Table, in JSON format.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/csharp.svg" /> | **[Audit.EntityFramework.Core](https://github.com/thepirat000/Audit.NET/tree/master/src/Audit.EntityFramework#generic-dbcontext-data-provider)** | Store the audit events in one or multiple entities using Entity Framework Core.
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/csharp.svg" /> | **[Audit.NET.Serilog](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Serilog/README.md)** | Store the audit events using [Serilog™](https://serilog.net/)
<img width="80" src="https://unpkg.com/simple-icons@v11/icons/csharp.svg" /> | **[Audit.NET.Udp](https://github.com/thepirat000/Audit.NET/blob/master/src/Audit.NET.Udp/README.md)** | Send audit events as **UDP datagrams** to a network.

# Change Log

For detailed information on changes in the new release refer to the [change log](https://github.com/thepirat000/Audit.NET/blob/master/CHANGELOG.md).

# Contribute

If you like this project please contribute in any of the following ways:

- [Sponsoring this project](https://github.com/sponsors/thepirat000).
- [![paypal](https://img.shields.io/badge/donate-PayPal-blue.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_donations&business=thepirat000%40hotmail.com&currency_code=USD&source=url)
