# Azure Schema Registry API

This project provides an Azure Function API for retrieving schema definitions from Azure Schema Registry. It allows clients to fetch schema details using a schema ID via an HTTP GET request. The API is designed to integrate seamlessly with Azure Event Hubs and follows Azure best practices for authentication and resource management.

## Features
- Retrieve schema definitions from Azure Schema Registry using a schema ID.
- Built with Azure Functions for serverless execution.
- Uses Azure Identity for secure authentication with Azure resources.

## Testing the API
You can test the API using the provided `.http` file, which contains sample HTTP requests. This file can be used with tools like [REST Client](https://marketplace.visualstudio.com/items?itemName=humao.rest-client) in Visual Studio Code.

## Configuration
The project requires specific environment variables to be set for proper functionality. A sample configuration file, `local.settings.sample.json`, is included to help you set up your local environment. Copy this file to `local.settings.json` and update the values as needed.

### Required Settings
- `EventHubsFullyQualifiedNamespace`: The fully qualified namespace of your Azure Event Hubs instance.

## Getting Started
1. Clone the repository:
   ```bash
   git clone https://github.com/your-repo/schema-registry-api.git
   cd schema-registry-api
2. Install the Azure Function Core Tools if not already installed 
   ```bash
   brew install azure-functions-core-tools@4
3. Set up your local environment:
   Copy `local.settings.sample.json` to `local.settings.json`.
   Update the environment variables with your Azure credentials.
4. Start the Azure Function locally:
   ```bash
   func start
5. Use the `.http` file to test the API endpoints.

References
- [Azure Schema Registry Documentation](https://learn.microsoft.com/en-us/azure/event-hubs/schema-registry-overview)
- [Azure Functions Documentation](https://learn.microsoft.com/en-us/azure/azure-functions/)