# TraktorService

[![NuGet](https://img.shields.io/nuget/v/Horsesoft.Traktor.svg)](https://www.nuget.org/packages/Horsesoft.Traktor/)

A C# library for interacting with Native Instruments Traktor's NML database files.

## Overview

TraktorService (Horsesoft.Traktor) is a .NET library that provides comprehensive tools for reading, parsing, and searching Traktor DJ software's music collection database. The library deserializes Traktor's XML-based NML format into strongly-typed C# objects, making it easy to work with your music collection programmatically.

## Features

- **NML Deserialization**: Async deserialization of Traktor's NML database files into structured objects
- **Music Collection Search**: Search functionality for tracks by artist, title, or musical key
- **Data Conversion**: Convert Traktor entries to simplified `MusicFileTag` objects with essential metadata
- **Comprehensive Metadata Support**: Access to all track information including:
  - Artist, Title, Album information
  - BPM (tempo) and Musical Key
  - Bitrate, File Location, and File Size
  - Genre, Label, and Comments
  - Ranking, Play Count, and Last Played date
  - Cue points and Loop information
  - Playlists and Collection structure

## Requirements

- .NET Framework 4.6.1 or higher
- Visual Studio 2015 or higher (for development)

## Installation

### Building from Source

1. Clone the repository:
```bash
git clone https://github.com/horseyhorsey/TraktorService.git
```

2. Open `Horsesoft.Traktor.sln` in Visual Studio

3. Build the solution (F6)

The compiled library will be available in `Horsesoft.Traktor/bin/Debug/` or `Horsesoft.Traktor/bin/Release/`

## Usage

### Deserializing Traktor Database

```csharp
using Horsesoft.Traktor;
using Horsesoft.Traktor.Models;

// Create a serializer instance
var serializer = new NmlSerializer();

// Deserialize the Traktor collection
string nmlPath = @"C:\Users\YourName\Documents\Native Instruments\Traktor [Version]\collection.nml";
NML traktorDatabase = await serializer.DeserializeNmlDatabaseAsync(nmlPath);

// Access collection entries
foreach (var entry in traktorDatabase.COLLECTION.ENTRY)
{
    Console.WriteLine($"{entry.ARTIST} - {entry.TITLE}");
}
```

### Searching for Tracks

```csharp
using Horsesoft.Traktor;
using Horsesoft.Traktor.Enums;

var search = new SearchNml();

// Search by artist name
var results = search.SearchDatabaseNml(nmlPath, SearchElement.ARTIST, "Daft Punk");

foreach (var track in results)
{
    Console.WriteLine($"Found: {track.ARTIST} - {track.TITLE}");
}

// Search by title
var titleResults = search.SearchDatabaseNml(nmlPath, SearchElement.TITLE, "One More Time");

// Search by musical key
var keyResults = search.SearchDatabaseNml(nmlPath, SearchElement.MUSICAL_KEY, "1");
```

### Converting to Simplified Format

```csharp
using Horsesoft.Traktor;

var converter = new TraktorConverter();

// Convert NML entries to MusicFileTag objects
var musicTags = await converter.NmlToMusicFileTagsAsync(nmlPath);

foreach (var tag in musicTags)
{
    Console.WriteLine($"{tag.Artist} - {tag.Title}");
    Console.WriteLine($"BPM: {tag.Bpm}, Key: {tag.Key}");
    Console.WriteLine($"Location: {tag.FileLocation}{tag.FileName}");
}
```

## Project Structure

```
TraktorService/
├── Horsesoft.Traktor/              # Main library
│   ├── Models/                     # Data models for NML structure
│   │   ├── Nml.cs                  # Root NML structure
│   │   ├── Entry.cs                # Track entry models
│   │   ├── MusicFileTag.cs         # Simplified music tag model
│   │   └── ENTRYMASTER.cs          # Base entry class
│   ├── Enums/                      # Enumeration types
│   │   ├── MusicKeys.cs            # Musical key definitions
│   │   └── SearchElement.cs        # Search filter types
│   ├── NmlSerializer.cs            # NML file deserialization
│   ├── SearchNml.cs                # Search functionality
│   └── TraktorConverter.cs         # Data conversion utilities
└── Horsesoft.TraktorTests/         # Unit tests
    ├── SerializerTests.cs
    └── SearchNmlTest.cs
```

## API Reference

### Core Classes

#### `NmlSerializer`
- `DeserializeNmlDatabaseAsync(string fileName)`: Asynchronously deserializes a Traktor NML file

#### `SearchNml`
- `SearchDatabaseNml(string nmlPath, SearchElement elementName, string searchText)`: Searches the database for tracks matching criteria

#### `TraktorConverter`
- `NmlToMusicFileTagsAsync(string nmlCollection)`: Converts NML collection to simplified MusicFileTag objects

### Search Elements
- `ARTIST`: Search by artist name
- `TITLE`: Search by track title
- `MUSICAL_KEY`: Search by musical key value

## Contributing

Contributions are welcome! Please feel free to submit pull requests or open issues for bugs and feature requests.

## License

Copyright © 2016. License details not specified in the project. Please contact the repository owner for licensing information.

## About Traktor

Native Instruments Traktor is a professional DJ software. This library works with the NML (XML) database file that Traktor uses to store collection information, typically located at:
- Windows: `C:\Users\[Username]\Documents\Native Instruments\Traktor [Version]\collection.nml`
- macOS: `~/Documents/Native Instruments/Traktor [Version]/collection.nml`

## Notes

- This library is for **reading** Traktor databases. Writing/modifying NML files is not currently supported
- Always backup your Traktor collection before working with NML files
- The library supports multiple Traktor versions that use the NML format

## Author

horseyhorsey

## Related Projects

This library can be used in various applications:
- Music collection analysis and statistics
- Playlist management tools
- DJ set preparation utilities
- Music library synchronization tools
