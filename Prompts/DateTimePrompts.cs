using ModelContextProtocol.Server;
using System.ComponentModel;

namespace DateUtilsMCPServerHttp.Prompts;

[McpServerPromptType]
public static class DateTimePrompts
{
    [McpServerPrompt(Name = "Current Date and Time"), Description("Get the current date and time")]
    public static string GetCurrentDateTimePrompt() => "What is the current date and time?";

    [McpServerPrompt(Name = "What was five days ago"), Description("Get the date for five days ago")]
    public static string WhatWasFiveDaysAgoPrompt() => "What was the date five days ago?";

    [McpServerPrompt(Name = "Five days from now"), Description("Get the date for five days from now")]
    public static string WhatWillFiveDaysFromNowPrompt() => "What will be the date five days from now?";

    [McpServerPrompt(Name = "What is the day of the week"), Description("Get the day of the week for a given date")]
    public static string WhatIsTheDayOfTheWeekPrompt([Description("The date to check")] string givenDate) => $"What is the day of the week for {givenDate}?";

    [McpServerPrompt(Name = "Compare two dates"), Description("Compare which date is earlier or later")]
    public static string CompareTwoDatesPrompt([Description("First date")] string date1, [Description("Second date")] string date2) => $"Which date is earlier: {date1} or {date2}?";

    [McpServerPrompt(Name = "Format date in different style"), Description("Format a date using a specific format")]
    public static string FormatDatePrompt([Description("The date to format")] string date, [Description("The desired format")] string format) => $"Please format the date {date} using the format {format}";

    [McpServerPrompt(Name = "What day of year is it"), Description("Get the day of the year for today")]
    public static string WhatDayOfYearPrompt() => "What day of the year is it today?";

    [McpServerPrompt(Name = "Add months to current date"), Description("Calculate a date by adding months to today")]
    public static string AddMonthsToDatePrompt([Description("Number of months to add")] int months) => $"What will be the date {months} months from now?";

    [McpServerPrompt(Name = "Get available date formats"), Description("Show available date formatting options")]
    public static string GetDateFormatsPrompt() => "What date formats are available for formatting dates?";
}
