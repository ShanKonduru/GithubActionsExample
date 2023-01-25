#Configuring Code Coverage

```bash
dotnet new --install TimHeuer.GitHubActions.Templates
```


Lets explore the dotnet tool called dotnet coverage and learn how to use this tool to collect code coverage and generate code coverage report using the reportgenerator tool. 
I will also see how we can be integrated to GitHub actions.

## Step #1) 
install the dotnet coverage tool, the version i am using is 17.6.3, use the following command 
```bash
dotnet tool install --global dotnet-coverage --version 17.6.3
```
### NOTE: 
On your local machine,  we are installing it as global tool. But in CI/CD systems it should be installed as local tool. to do that use the following commands.
```bash
dotnet new tool-manifest # if you are setting up this repo
dotnet tool install --local dotnet-coverage --version 17.6.3
```

## Step #2) 
install the report generator tool, the version i am using is 5.1.15, use the following command 
```bash
dotnet tool install --global dotnet-reportgenerator-globaltool --version 5.1.15
```
### NOTE: 
On your local machine,  we are installing it as global tool. But in CI/CD systems it should be installed as local tool. to do that use the following commands.
```bash
dotnet new tool-manifest # if you are setting up this repo
dotnet tool install --local dotnet-reportgenerator-globaltool --version 5.1.15
```

## Step #3) 
Now, run the command dotnet coverage collect dotnet test. 
```bash
dotnet coverage collect dotnet test --output .\Tests\CodeCoverage --output-format cobertura
```
after this command is executed, you will get a file with .cobertura.xml. We need to use the filename in the report generator.

## Step #4) 
Generate HTML file for Code Coverage
```bash
reportgenerator -reports:.\Tests\CodeCoverage.cobertura.xml -targetdir:".\Tests\CoverageReport" -reporttypes:Html
```

## Usefull links
For more information check this URL
https://dotnetthoughts.net/generating-code-coverage-reports-in-dotnet-core/