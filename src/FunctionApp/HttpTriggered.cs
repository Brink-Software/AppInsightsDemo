using System;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace FunctionApp
{
    public class HttpTriggered
    {
        [FunctionName("HttpTriggered")]
        public IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req, ILogger log)
        {
            // The current request telemetry item gets a property
            

            // The current telemetry item gets a property. Useful if the function is not triggered by an http request
            

            // Subsequent telemetry gets this property attached
            
            
            //_telemetryClient.TrackEvent("HttpTriggered Function Executed");

            //using (_telemetryClient.StartOperation<DependencyTelemetry>("aSubOperationOfHttpTriggered"))
            //{
            //    // This dependency telemetry will have only the properties set using Activity.Current.AddBaggage(..)

            //    // This event telemetry will have only the properties set using Activity.Current.AddBaggage(..)
            //    _telemetryClient.TrackEvent("anEventInSubOperationOfHttpTriggered");
            //}

            // Generate an entry in the exceptions table and an entry in the trace table of severity warning with message `Some Message`
            log.LogWarning(new Exception("Demo"), "Some Message");

            log.LogInformation("Finished Execution");

            return new OkResult();
        }
    }
}