- @azure Rule - Use Azure Best Practices: When generating code for Azure, running terminal commands for Azure, or performing operations related to Azure, invoke your `azure_development-get_best_practices` tool if available.

## Application code

- Use C# as the programming language.
- Use the most recent version of .NET 8.
- Application code should go in the `src` directory.
- Use the most recent NuGet packages compatible with .NET 8.

## Unit tests

- Use the most recent version of xUnit.
- Ensure all tests are organized and follow naming conventions.
- Ensure tests cover edge cases and error handling.
- Tests should go in the `tests` directory.
- Tests should be in a separate project.
- Ensure tests are isolated and do not depend on external state.
- Ensure the test project is included in the solution file (.sln).
