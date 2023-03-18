
# Collect code coverage data

## Run unit tests

### Collect coverage with coverlet

``` powershell

# --verbosity: q[uiet], m[inimal], n[ormal], d[etailed], diag[nostic]
# --diag test.log
dotnet test `
  --collect:"XPlat Code Coverage" `
  --settings test.runsettings `
  --verbosity m `
  --diag ./.testresults/log/test.log `
  ./WebApplication1.Tests/WebApplication1.Tests.csproj

```