# SnapRename

A desktop application for batch renaming photos using EXIF metadata. Define a custom template like `{YYYY}-{MM}-{DD}_{label}_{###}` and rename hundreds of files in seconds. Part of the SnapPress ecosystem.

![C#](https://img.shields.io/badge/C%23-12.0-blue) ![WinUI](https://img.shields.io/badge/WinUI-3-green) ![Platform](https://img.shields.io/badge/Platform-Windows-lightgrey)

## Features

- Drag & drop photo selection
- EXIF-based renaming templates with live preview
- Customizable template tags: `{YYYY}`, `{MM}`, `{DD}`, `{label}`, `{###}`, `{cam}`
- Batch rename — hundreds of files at once
- Output folder selection — originals are never overwritten
- Dark / light mode following system theme
- Supports JPG, PNG, CR2, NEF, HEIC

## Screenshots

*Coming soon*

## Requirements

- Windows 10 version 1809 or later
- [.NET 8.0 Runtime](https://dotnet.microsoft.com/download)

## Installation

### Windows

1. Download the `.exe` installer from the current release
2. Run the installer and follow the steps
3. Launch SnapRename from the Start Menu or Desktop shortcut

## Usage

1. Drag & drop photos onto the app or click **Select photos**
2. Set your renaming template (e.g. `{YYYY}-{MM}-{DD}_{label}_{###}`)
3. Type a custom label if needed
4. Preview the new filenames in the list
5. Click **Rename and save**
6. Renamed files are saved to the selected output folder — originals untouched

## Template tags

| Tag | Description | Example |
|-----|-------------|---------|
| `{YYYY}` | Year from EXIF | `2026` |
| `{MM}` | Month from EXIF | `08` |
| `{DD}` | Day from EXIF | `04` |
| `{label}` | Custom text label | `Albania` |
| `{###}` | Auto-incrementing number | `001` |
| `{cam}` | Camera model from EXIF | `Canon_EOS_2000D` |

## Roadmap

- [ ] Drag & drop photo selection (1.0.0)
- [ ] EXIF date reading (1.0.0)
- [ ] Live template preview (1.0.0)
- [ ] Output folder selection (1.1.0)
- [ ] Rename engine with conflict handling (1.2.0)
- [ ] Dark / light mode following system theme (1.3.0)
- [ ] RAW file support — CR2, NEF (1.4.0)
- [ ] Template history — save and reuse templates (1.5.0)
- [ ] Thumbnails in file list (1.6.0)
- [ ] Windows installer (1.7.0)
- [ ] Web version (2.0.0)
- [ ] Linux version (2.0.0)
- [ ] Android port (3.0.0)

## Tech stack

- C# 12
- WinUI 3 — GUI
- .NET 8
- MetadataExtractor — EXIF reading

## Part of the SnapPress ecosystem

| App | Platform | Language |
|-----|----------|----------|
| [SnapPress](https://github.com/Sebian12/SnapPress) | Windows / Linux / macOS | Python |
| [SnapPress Android](https://github.com/Sebian12/SnapPress-Android) | Android | Kotlin |
| SnapRename | Windows | C# |
| SnapRename Web | Browser | JavaScript |
| SnapRename Android | Android | Kotlin |

## License

MIT
