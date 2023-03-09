# Lab - printtool
Printtool is a simple application written in .NET7 that prints the arguments passed to the tool.

## Prerequisites Azure Devops
The following prerequisites are required before executing the pipelines:

1. Ensure you have a Microsoft account
   - If you don't have a Microsoft account signup [here](https://account.microsoft.com) for a new one.
1. Browse to: https://dev.azure.com and select '_start for free_' <br> ![Sign up for Azure Devops](./.images/Prerequisites_SignUp.png)
1. Fill in the data and pick a name for your project. Set project visibility to '_private_' <br> ![Create project with visibility private](./.images/Prerequisites_CreateProjectVisibilityPrivate.png)
1. Note down the name of your Azure Devops organization you just created. The name of the organization is the same name as the project that is just created. So: `dev.azure.com/<JustCreatedProjectName>`
1. Create a request for parallel jobs [through this form](https://aka.ms/azpipelines-parallelism-request). Fill in with the following data: <br> ![Data required for parallelism request](./.images/Prerequisites_ParallelismRequest.png)
   - Wait untill the request is approved.

## Import pipeline in Azure Devops

1. Import this repo [through these steps](https://learn.microsoft.com/en-us/azure/devops/repos/git/import-git-repository).
1. Create a new pipeline, select use existing YAML <br> ![Use existing YAML](./.images/Prerequisites_UseExistingYAML.png)
1. Do this for the following files:
   - .azure-pipelines/azure-pipelines-hostedagents-start.yml
   - .azure-pipelines/.refactored/azure-pipelines-hostedagents-multistage.yml
