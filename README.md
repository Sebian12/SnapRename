# SnapRename

A desktop application for batch renaming photos using EXIF metadata. Define a custom template like `{YYYY}-{MM}-{DD}_{label}_{###}` and rename hundreds of files in seconds. Part of the SnapPress ecosystem.

![C++](https://img.shields.io/badge/C++-17-blue) ![Qt](https://img.shields.io/badge/Qt-6.x-green) ![Platform](https://img.shields.io/badge/Platform-Windows%20%7C%20Linux-lightgrey)

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

- Qt 6.x
- CMake 3.16+
- C++17 compatible compiler (MSVC 2022 or GCC 11+)

## Installation

### Windows

1. Download the `.exe` installer from the current release

### Linux

1. Download the Linux binary from the current release
2. Make it executable:
```bash
chmod +x SnapRename
```
3. Run:
```bash
./SnapRename
```

### Build from source (Windows, Linux)

1. Clone the repository:
```bash
git clone https://github.com/Sebian12/SnapRename.git
cd SnapRename
```

2. Configure and build:
```bash
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build
```

## Usage

1. Drag & drop photos onto the app or click **Select photos**
2. Set your renaming template (e.g. `{YYYY}-{MM}-{DD}_{label}_{###}`)
3. Preview the new filenames in the list
4. Click **Rename and save**
5. Renamed files are saved to the selected output folder — originals untouched

## Template tags

| Tag | Description | Example |
|-----|-------------|---------|
| `{YYYY}` | Year from EXIF | `2026` |
| `{MM}` | Month from EXIF | `08` |
| `{DD}` | Day from EXIF | `04` |
| `{label}` | Custom text label | `Albania` |
| `{###}` | Auto-incrementing number | `001` |
| `{cam}` | Camera model from EXIF | `Canon EOS 2000D` |

## Roadmap

- [ ] Drag & drop support (0.1.0)
- [ ] EXIF date reading (0.2.0)
- [ ] Live template preview (0.2.0)
- [ ] Output folder selection (0.3.0)
- [ ] Rename engine with conflict handling (0.4.0)
- [ ] Dark / light mode (0.5.0)
- [ ] RAW file support — CR2, NEF (0.6.0)
- [ ] Template history (0.7.0)
- [ ] Windows installer (1.0.0)
- [ ] Linux binary (1.0.0)
- [ ] Android port (2.0.0)

## Tech stack

- C++ 17
- Qt 6 / QML — GUI
- CMake — build system
- libexif — EXIF metadata reading

## Part of the SnapPress ecosystem

| App | Platform | Language |
|-----|----------|----------|
| [SnapPress](https://github.com/Sebian12/SnapPress) | Windows / Linux | Python |
| [SnapPress Android](https://github.com/Sebian12/SnapPress-Android) | Android | Kotlin |
| SnapRename | Windows / Linux | C++ / Qt |
| SnapRename Android | Android | Kotlin |

## License

MIT
