// Load the recipe
#load nuget:?package=NUnit.Cake.Recipe&version=2.0.0-beta.4.9
// Comment out above line and uncomment below for local tests of recipe changes
//#load ../NUnit.Cake.Recipe/recipe/*.cake

// Load additional cake files
//#load package-tests.cake

// Initialize BuildSettings
BuildSettings.Initialize(
    Context,
    title: "NUnit Extensibility",
    githubRepository: "NUnit.Extensibility",
    solutionFile: "NUnit.Extensibility.slnx");

//////////////////////////////////////////////////////////////////////
// INDIVIDUAL PACKAGE DEFINITIONS
//////////////////////////////////////////////////////////////////////

BuildSettings.Packages.Add(new NuGetPackage(
    id: "NUnit.Extensibility.Api",
    source: BuildSettings.SourceDirectory + "NUnit.Extensibility.Api/NUnit.Extensibility.Api.csproj",
    checks: new PackageCheck[] {
        HasFile("LICENSE.txt"),
        HasDirectory("lib/net462").WithFile("nunit.extensibility.api.dll"),
        HasDirectory("lib/netstandard2.0").WithFile("nunit.extensibility.api.dll")
    },
    symbols: new PackageCheck[] {
        HasDirectory("lib/net462").WithFile("nunit.extensibility.api.pdb"),
        HasDirectory("lib/netstandard2.0").WithFile("nunit.extensibility.api.pdb")
    }));

BuildSettings.Packages.Add(new NuGetPackage(
    id: "NUnit.Extensibility",
    source: BuildSettings.SourceDirectory + "NUnit.Extensibility/NUnit.Extensibility.csproj",
    checks: new PackageCheck[]
    {
        HasFile("LICENSE.txt"),
        HasDirectory("lib/net462").WithFile("nunit.extensibility.dll"),
        HasDirectory("lib/netstandard2.0").WithFile("nunit.extensibility.dll"),
        HasDependency("NUnit.Extensibility.Api"),
        HasDependency("NUnit.Engine.Api"),
        HasDependency("NUnit.Common"),
        HasDependency("TestCentric.Metadata", "3.0.4")
    },
    symbols: new PackageCheck[]
    {
        HasDirectory("lib/net462").WithFile("nunit.extensibility.pdb"),
        HasDirectory("lib/netstandard2.0").WithFile("nunit.extensibility.pdb")
    }));

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

Build.Run()
