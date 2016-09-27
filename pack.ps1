$root = (split-path -parent $MyInvocation.MyCommand.Definition)
$version = [System.Reflection.Assembly]::LoadFile("$root\CSIntel.Ipp\bin\Release\CSIntel.Ipp.dll").GetName().Version
$versionStr = "{0}.{1}.{2}" -f ($version.Major, $version.Minor, $version.Build)

Write-Host "Setting .nuspec version tag to $versionStr"

$content = (Get-Content $root\CSIntelPerfLibs.nuspec) 
$content = $content -replace '\$version\$',$versionStr

$content | Out-File $root\CSIntelPerfLibs.compiled.nuspec

& nuget pack $root\CSIntelPerfLibs.compiled.nuspec