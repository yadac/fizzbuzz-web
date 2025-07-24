# run_tests_with_coverage.ps1

dotnet test .\FizzBuzz.Tests\FizzBuzz.Tests.csproj `
    /p:CollectCoverage=true `
    /p:CoverletOutputFormat=cobertura `
    /p:Include="[FizzBuzz]*" `
    /p:Exclude="[xunit.*]*"

Write-Host "`n🟢 テストとカバレッジ収集が完了しました。"
