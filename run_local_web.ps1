# run_local_web.ps1
# Reactアプリをビルドし、ビルド成果物をWebアプリにコピーして、dotnet runを実行する

# スクリプトのある場所を基準に相対パスを解決
$baseDir = Split-Path -Parent $MyInvocation.MyCommand.Path
Push-Location $baseDir

# パス設定
$clientAppPath = Join-Path $baseDir "ClientApp"
$webAppPath = Join-Path $baseDir "FizzBuzz.Web"
$buildPath = Join-Path $clientAppPath "build"
$targetPath = Join-Path $webAppPath "wwwroot\spa"

# Reactアプリをビルド
Write-Host "🔧 Building React app..."
Push-Location $clientAppPath
npm run build
Pop-Location

# wwwroot/spa を初期化して build 配下をコピー
Write-Host "🚚 Copying build output to wwwroot/spa..."
Get-ChildItem -Path "$targetPath" -Exclude ".gitkeep" | Remove-Item -Recurse -Force
Copy-Item "$buildPath\*" $targetPath -Recurse

# dotnet run でアプリを起動
Write-Host "🚀 Running FizzBuzz.Web..."
Push-Location $webAppPath
dotnet run
Pop-Location

# 元のカレントディレクトリに戻る
Pop-Location
