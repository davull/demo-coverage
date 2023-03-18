
# Collect code coverage data

## Setup

Install dotnet tools

``` powershell
dotnet new tool-manifest

dotnet tool install dotnet-config
dotnet tool install dotnet-reportgenerator-globaltool
```

Configure ReportGenerator

``` powershell
dotnet dotnet-config ReportGenerator.report "./.testresults/*/coverage.cobertura.xml"
dotnet dotnet-config ReportGenerator.targetdir ".coverage"
dotnet dotnet-config ReportGenerator.reporttypes "Cobertura;MarkdownSummary;HtmlInline_AzurePipelines"
dotnet dotnet-config ReportGenerator.title "Code coverage report"

dotnet dotnet-config --list
```

## Run unit tests

### Collect coverage with coverlet

``` powershell

# Run unit tests
# --verbosity: q[uiet], m[inimal], n[ormal], d[etailed], diag[nostic]
# --diag test.log
dotnet test `
  --collect:"XPlat Code Coverage" `
  --settings test.runsettings `
  --verbosity m `
  --diag ./.testresults/log/test.log `
  ./WebApplication1.Tests/WebApplication1.Tests.csproj

# Generate coverage report
dotnet reportgenerator

```