# Date Utils MCP Server (HTTP)

A Model Context Protocol (MCP) server that provides comprehensive date and time utilities via HTTP transport. This server exposes various tools for date manipulation, formatting, and comparison that can be used by MCP clients like Claude Desktop.

## Features

### Current Date and Time
- Get current server date and time (local and UTC)
- Get day of week and day of year
- Server timezone-aware operations

### Date Manipulation
- Add/subtract days, hours, minutes, seconds to current date
- Add weeks, months, and years to dates
- Flexible time arithmetic operations

### Date Comparison
- Compare two dates and determine their relationship
- Human-readable comparison results

### Date Formatting
- Format dates to various standard formats
- Get lists of available date formats
- Country-specific date format references
- Support for custom format strings

## Requirements

- .NET 9.0 or later
- ASP.NET Core runtime

## Installation

1. Clone this repository:
```bash
git clone <repository-url>
cd DateUtilsMCPServerHttp
```

2. Restore dependencies:
```bash
dotnet restore
```

3. Build the project:
```bash
dotnet build
```

## Running the Server

Start the MCP server:
```bash
dotnet run
```

The server will start on `http://localhost:3001` by default.

## Claude Desktop Integration

To use this MCP server with Claude Desktop, add the following configuration to your `claude_desktop_config.json` file:

```json
{
  "mcpServers": {
    "DateUtilsServerHttp": {
      "command": "npx",
      "args": [
        "mcp-remote",
        "http://localhost:3001"
      ]
    }
  }
}
```

### Claude Desktop Config File Location

The `claude_desktop_config.json` file should be placed in:
- **macOS**: `~/Library/Application Support/Claude/claude_desktop_config.json`
- **Windows**: `%APPDATA%\Claude\claude_desktop_config.json`
- **Linux**: `~/.config/Claude/claude_desktop_config.json`

A sample configuration file is included in this repository as `claude_desktop_config.json` for reference.

## Available Tools

### Current Date/Time Tools
- `GetServerDate()` - Get today's date (server timezone)
- `GetServerDayOfWeek()` - Get current day of week
- `GetCurrentServerDateTime()` - Get current local date and time
- `GetServerDayOfYear()` - Get day of year (server timezone)
- `GetCurrentUTCDateTime()` - Get current UTC date and time
- `GetCurrentUTCDayOfWeek()` - Get current UTC day of week
- `GetCurrentUTCDayOfYear()` - Get current UTC day of year

### Date Manipulation Tools
- `AddDaysToCurrentDate(int days)` - Add days to current date
- `AddHoursToCurrentDateTime(int hours)` - Add hours to current datetime
- `AddMinutesToCurrentDateTime(int minutes)` - Add minutes to current datetime
- `AddSecondsToCurrentDateTime(int seconds)` - Add seconds to current datetime
- `AddWeeksToCurrentDate(int weeks)` - Add weeks to current date
- `AddMonthsToCurrentDate(int months)` - Add months to current date
- `AddYearsToCurrentDate(int years)` - Add years to current date

### Date Comparison Tools
- `CompareDates(string date1, string date2)` - Compare two dates

### Date Formatting Tools
- `FormatDate(string date, string format)` - Format a date string
- `GetAvailableDateFormats()` - Get list of available date formats
- `GetCommonDateFormatsByCountry()` - Get common date formats by country

## Development

### Project Structure
```
DateUtilsMCPServerHttp/
├── Program.cs                    # Main application entry point
├── DateUtilsMCPServerHttp.csproj # Project file
├── Tools/
│   └── DateTimeTools.cs         # Date/time utility tools
├── Properties/
│   └── launchSettings.json      # Launch configuration
├── claude_desktop_config.json   # Sample Claude Desktop config
└── README.md                    # This file
```

### Dependencies
- `ModelContextProtocol.AspNetCore` (v0.3.0-preview.2) - MCP server framework

### Adding New Tools

To add new date/time tools:

1. Add a new static method to the `DateTimeTools` class in `Tools/DateTimeTools.cs`
2. Decorate the method with `[McpServerTool]` and `[Description]` attributes
3. The method will be automatically discovered and exposed by the MCP server

Example:
```csharp
[McpServerTool, Description("Get the number of days until a specific date.")]
public static string GetDaysUntilDate(string targetDate)
{
    DateTime target = DateTime.Parse(targetDate);
    DateTime now = DateTime.Now;
    TimeSpan difference = target - now;
    return difference.Days.ToString();
}
```

## Configuration

The server runs on `http://localhost:3001` by default. This can be changed in `Program.cs`:

```csharp
app.Run("http://localhost:3001"); // Change port here
```

## License

[Add your license information here]

## Contributing

[Add contribution guidelines here]

## Support

[Add support information here]
