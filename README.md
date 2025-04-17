# GitHub Copilot Demo for Software Engineers

## Overview

This 10 minute demo covers three powerful ways GitHub Copilot can assist in software engineering projects:

1. Boilerplate Code Generation
1. In-Context Code Understanding
1. Conversion
1. Test Generation for Functions

## 1. Boilerplate Code Generation

### Goal

Show how Copilot can quickly generate boilerplate code based on intent.

### Steps

1. Open a new file (e.g., `usersApi.js`).
1. Type the following comment:

   ```javascript
   // Create an Express.js API endpoint that returns a list of users
   ```

1. Pause and let Copilot suggest the implementation.
1. Run it - `npm start`

#### Expected result

```javascript
const express = require("express");
const app = express();
const port = 3000;

const users = [
  { id: 1, name: "John Doe" },
  { id: 2, name: "Jane Smith" },
  { id: 3, name: "Bob Johnson" },
];

app.get("/api/users", (req, res) => {
  res.json(users);
});

app.listen(port, () => {
  console.log(`Server is running at http://localhost:${port}`);
});
```

### Takaway

Copilot saves time by writting common patterns and boilerplate code for you.

## 2. In-Context Code Understanding

### Goal

Show how Copilot helps explain unfamiliar or legacy code.

### Steps

1. Paste the following into a file:

   ````javascript
   function isValidEmail(email) {
       const regex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
       return regex.test(email);
   }
   ```
   ````

1. Add a comment directly above.

   ```text
   Explain what this function does.
   ```

1. Press Enter. Let Copilot generate the explaination.
1. Show document generation (`/doc`)
1. Show explain feature (`/explain`)

#### Expected result

    ```
    ```

### Takeaway

Copilot helps you read and document unfamiliar codebases faster.

## 3. Conversion

### Goal

Utilize Copilot to convert from a Bash shell script to a PowerShell script.

### Steps

1. Open `/conversion/deploy.sh` file.
1. Use GitHub Copilot chat to convert the file to PowerShell.
1. Highlight section on environment variable and use `/explain`.

### Expected result

```powershell
# Exit on error
$ErrorActionPreference = "Stop"

# Get the script directory
$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
Write-Host "Script directory: $scriptDir"

# Load .env file if it exists

$envFile = Join-Path $scriptDir ".env"
if (Test-Path $envFile) {
    Write-Host "Loading .env"
    Get-Content $envFile | ForEach-Object {
        if ($_ -match "^(.*?)=(.*)$") {
            [System.Environment]::SetEnvironmentVariable($matches[1], $matches[2])
        }
    }
} else {
    Write-Host "No .env file found - copy sample.env and fill out the values"
    exit 1
}

# Check required environment variables
if (-not $env:RESOURCE_GROUP) {
    Write-Host "RESOURCE_GROUP not specified"
    exit 1
}
if (-not $env:APPLICATION_NAME) {
    Write-Host "APPLICATION_NAME not specified"
    exit 1
}

# Create a zip file of the source code
Push-Location -Path (Join-Path $scriptDir "source")
Compress-Archive -Path * -DestinationPath (Join-Path $scriptDir "deployment.zip") -Force
Pop-Location

# Deploy using Azure CLI
az webapp deploy `
    --resource-group $env:RESOURCE_GROUP `
    --name $env:APPLICATION_NAME `
    --type zip `
    --src-path (Join-Path $scriptDir "deployment.zip") `
    --verbose
```

### Takeaway

Use GitHub Copilot to aid in converting code from one language to another.

## 4. Test Generation for Functions

### Goal

Demonstrate how Copilot helps write unit tests quickly.

### Steps

1. Show `/test` to write a unit test.
1. Show using the GitHub Copilot Agent. Use **Claude 3.5 Sonnet**.
1. Show the use of the _copilot-instructions.md_ file.
1. Creat the tests.

   ```text
   Create unit tests for my project.
   ```

1. Let Copilot write the test.
1. Ask Copilot agent if there are more test scenarios ("What other tests should I write?")
1. Let Copilot agent write and run the tests.

#### Expected result

### Takeaway

Copilot encourages testing by reducing the friction to write useful test cases.

## Wrap-up

### Key Takeways

- **Reduces boilerplate** and repetitive coding
- **Improves onboarding** by helping understand unfamiliar code
- **Encourages testing** with fast, accurate test scaffolding
