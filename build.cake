var target = Argument("target", "build");
var version = Argument("assembly-version", "1.0");
var configuration = Argument("configuration", "debug");

///////////////////////////////////////////////////////////////////////////////
// ENVIRONMENT
///////////////////////////////////////////////////////////////////////////////

string RootDirectory = MakeAbsolute(Directory("./")).ToString();
string ApplicationProjectPath = $"{RootDirectory}/Your.App.Multiplatform/Your.App.csproj";
string NetworkProjectPath = $"{RootDirectory}/Your.Network/Your.Network.csproj";
string ArtifactsDirectory = $"{RootDirectory}/Artifacts";

///////////////////////////////////////////////////////////////////////////////
// TASKS
///////////////////////////////////////////////////////////////////////////////

Task("clean").Does(() => {
   CleanDirectories("./**/bin");
   CleanDirectories("./**/obj");
   CleanDirectory(ArtifactsDirectory);
});

Task("build")
   .IsDependentOn("clean")
   .Does(() => DotNetBuild(ApplicationProjectPath, new DotNetBuildSettings {
      Configuration = configuration,
   }));

Task("publish")
   .IsDependentOn("clean")
   .Does(() => {
      var settings = new DotNetMSBuildSettings().WithProperty("RuntimeIdentifier", "ios-arm64");
      DotNetPublish(ApplicationProjectPath, new DotNetPublishSettings {
         MSBuildSettings = settings,
         OutputDirectory = ArtifactsDirectory,
         Configuration = "release",
         Framework = "net7.0-ios"
      });
      DotNetPublish(ApplicationProjectPath, new DotNetPublishSettings {
         OutputDirectory = ArtifactsDirectory,
         Configuration = "release",
         Framework = "net7.0-android"
      });
   });


RunTarget(target);