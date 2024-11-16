# 16112024C
simple solution combining console app and class library

## help

`dotnet --help`

## create

`dotnet new list`\
`dotnet new solution`\
`dotnet new console -o ColorApp`\
`dotnet new classlib -o ColorLibrary`\

## add package

`dotnet add package System.CommandLine --prerelease`

## build

`dotnet build`

## run

`dotnet run`

## publish

`cd ColorApp`
`dotnet publish -o out`

## run publish

`out\ColorApp --help`

## references
[web-commandline](https://learn.microsoft.com/en-us/dotnet/standard/commandline/)\
[git-commandline](https://github.com/dotnet/docs/blob/main/docs/standard/commandline/get-started-tutorial.md)