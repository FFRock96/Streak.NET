# Streak.NET
<h1>A .NET/C# implementation of the Streak CRM REST API</h1>

Website: https://www.streak.com/
API Documentation: https://www.streak.com/api/

This is .NET/C# wrapper which can be used to interact with the Streak API thereby enabling you to work with pipelines, boxes, fields etc. This projecty has only one dependency: Newtonsoft.Json v. 9.0.1+ (https://www.nuget.org/packages/newtonsoft.json/) 

The wrapper is written to give users two ways of communicating with the API: 

1. The RAW services which will deliver the raw JSON response and HTTP status code from the API. 
2. The .NET object services which will deserialize and deliver domain objects from the delivered JSON

<h3>Prerequisites - Before you begin you need the following:</h3>
- The latest release of this package
- The latest version of Newtonsoft.Json (9.0.1+). Download it via NuGet.
- An API key from Streak: https://www.streak.com/api/#apikey

<h3>API services with domain models</h3>
You can use the services like this:

```C#
var streakServices = new StreakServices("{YOUR_API_KEY", true); // Setting true to include the raw response from the API (see below)
var pipeline = streakServices.Pipelines.GetPipeline("PIPELINE_KEY");
var pipelineName = pipeline.Name;
var pipelineDescription = pipeline.Description;
// Since I passed true in the constructor I am able to read the raw API response as well like this (will be null if false is passed):
var returnedHttpStatusCode = pipeline.RawApiResponse.HttpStatusCode;
var returnedJson = pipeline.RawApiResponse.Json;
```

<h3>RAW API services</h3>
You can use the RAW services like this:

```C#
var rawStreakServices = new RawStreakServices("{YOUR_API_KEY");
var pipeline = rawStreakServices.PipelinesRaw.GetPipeline("PIPELINE_KEY");
var returnedJson = pipeline.Json;
var returnedHttpStatusCode = pipeline.HttpStatusCode;
```

The RAW services either returns an object of the type RawApiResponse.cs OR an exception of the type StreakApiException.cs (this exception has two additional attributes: RawJsonResponse (the error message from the API) and HttpStatusCode (the returned status code).
