# Release Workflow Documentation

## Overview

This project now supports multi-targeting for .NET Framework 4.6.1, .NET Standard 2.0, and .NET 9.0, with automated build and NuGet publishing through GitHub Actions.

## Target Frameworks

The `Horsesoft.Traktor` library now builds for three target frameworks:

- **net461**: .NET Framework 4.6.1 (for Windows-only applications)
- **netstandard2.0**: .NET Standard 2.0 (for maximum compatibility across .NET Framework 4.6.1+ and .NET Core 2.0+)
- **net9.0**: .NET 9.0 (latest .NET for modern applications)

## Project Changes

### Main Project (Horsesoft.Traktor.csproj)

- Converted from legacy .NET Framework project format to SDK-style format
- Added multi-targeting support
- Included NuGet package metadata (PackageId, Description, Authors, etc.)
- Removed manual file references (SDK-style auto-includes all .cs files)

### Test Project (Horsesoft.TraktorTests.csproj)

- Converted to SDK-style format targeting .NET 9.0
- Updated NUnit from v3.0.1 to v4.2.2
- Migrated from packages.config to PackageReference
- Updated test assertions to use NUnit 4.x API

### Removed Files

- `Horsesoft.Traktor/Convert.cs` - Unused duplicate of TraktorConverter with compilation errors
- `Horsesoft.TraktorTests/packages.config` - Replaced by PackageReference in SDK-style project

## Release Workflow

### Setup

To publish packages to NuGet, you need to configure a secret in your GitHub repository:

1. Go to your repository on GitHub
2. Navigate to Settings → Secrets and variables → Actions
3. Add a new repository secret:
   - Name: `NUGET_API_KEY`
   - Value: Your NuGet API key (get it from https://www.nuget.org/account/apikeys)

### Creating a Release

To trigger a release build and publish to NuGet:

1. Ensure all changes are committed and pushed to the main branch
2. Create and push a version tag:
   ```bash
   git tag v1.0.0
   git push origin v1.0.0
   ```

The workflow will automatically:
- Restore dependencies
- Build the solution for all target frameworks
- Run tests
- Create a NuGet package
- Publish to NuGet.org
- Upload the package as a GitHub artifact

### Workflow File

Location: `.github/workflows/release.yml`

The workflow:
- Triggers on push of tags matching `v*` pattern
- Runs on Ubuntu (supports all target frameworks through SDK-style projects)
- Uses .NET 9.0 SDK (which can build all target frameworks)
- Publishes to NuGet only if all tests pass

## Building Locally

### Requirements

- .NET 9.0 SDK (or later)

### Build Commands

```bash
# Restore dependencies
dotnet restore Horsesoft.Traktor.sln

# Build all configurations
dotnet build Horsesoft.Traktor.sln -c Release

# Run tests
dotnet test Horsesoft.Traktor.sln -c Release

# Create NuGet package
dotnet pack Horsesoft.Traktor/Horsesoft.Traktor.csproj -c Release -o ./artifacts
```

The build output will include assemblies for all three target frameworks:
- `Horsesoft.Traktor/bin/Release/net461/Horsesoft.Traktor.dll`
- `Horsesoft.Traktor/bin/Release/netstandard2.0/Horsesoft.Traktor.dll`
- `Horsesoft.Traktor/bin/Release/net9.0/Horsesoft.Traktor.dll`

## Version Management

The package version is controlled in `Horsesoft.Traktor/Horsesoft.Traktor.csproj`:

```xml
<Version>1.0.0</Version>
```

Update this version before creating a new release tag.

## Compatibility

Applications can now use this library on:

- ✅ .NET Framework 4.6.1 and later (Windows)
- ✅ .NET Core 2.0 and later (via .NET Standard 2.0)
- ✅ .NET 5, 6, 7, 8, 9+ (via .NET Standard 2.0 or direct net9.0 target)
- ✅ Xamarin, Unity, and other platforms supporting .NET Standard 2.0

## Troubleshooting

### Build Issues

If you encounter build issues:

1. Ensure you have .NET 9.0 SDK installed:
   ```bash
   dotnet --version
   ```

2. Clean the solution:
   ```bash
   dotnet clean Horsesoft.Traktor.sln
   rm -rf **/bin **/obj
   ```

3. Restore and rebuild:
   ```bash
   dotnet restore Horsesoft.Traktor.sln
   dotnet build Horsesoft.Traktor.sln -c Release
   ```

### Workflow Issues

If the GitHub Actions workflow fails:

1. Check that the `NUGET_API_KEY` secret is set correctly
2. Verify the tag format matches `v*` (e.g., v1.0.0, not 1.0.0)
3. Review the workflow logs in the Actions tab of your repository
4. Ensure the package version in the .csproj doesn't conflict with an existing version on NuGet
