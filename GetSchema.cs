using Azure.Data.SchemaRegistry;
using Azure.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Samples
{
    public class GetSchema
    {
        private readonly ILogger<GetSchema> _logger;

        public GetSchema(ILogger<GetSchema> logger)
        {
            _logger = logger;
        }

        [Function("GetSchema")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route ="schema/{schemaId}")] HttpRequest req,
            string schemaId)
        {
            // Reference: https://learn.microsoft.com/en-us/dotnet/api/overview/azure/data.schemaregistry-readme?view=azure-dotnet
            
            string fullyQualifiedNamespace = Environment.GetEnvironmentVariable("EventHubsFullyQualifiedNamespace") 
                ?? throw new InvalidOperationException("Environment variable 'EventHubsFullyQualifiedNamespace' is not set.");
            
            var client = new SchemaRegistryClient(fullyQualifiedNamespace: fullyQualifiedNamespace, 
                credential: new DefaultAzureCredential());

            SchemaRegistrySchema schema = client.GetSchema(schemaId);
            string definition = schema.Definition;            

            return new OkObjectResult(definition);
        }
    }
}
