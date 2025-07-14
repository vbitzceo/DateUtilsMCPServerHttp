using System.ComponentModel;
using ModelContextProtocol.Server;

namespace DateUtilsMCPServerHttp.Resources;

[McpServerResourceType]
public static class HolidayResources
{
    [McpServerResource(UriTemplate = "holidays://us", Name = "US Holidays"), Description("List of major holidays in the United States")]
    public static string GetUSHolidays()
    {
        return @"{
            ""country"": ""United States"",
            ""code"": ""US"",
            ""holidays"": [
                {
                    ""name"": ""New Year's Day"",
                    ""date"": ""January 1"",
                    ""type"": ""Federal"",
                    ""description"": ""Celebrates the beginning of the new year""
                },
                {
                    ""name"": ""Martin Luther King Jr. Day"",
                    ""date"": ""Third Monday in January"",
                    ""type"": ""Federal"",
                    ""description"": ""Honors civil rights leader Martin Luther King Jr.""
                },
                {
                    ""name"": ""Presidents' Day"",
                    ""date"": ""Third Monday in February"",
                    ""type"": ""Federal"",
                    ""description"": ""Honors all U.S. presidents, particularly George Washington and Abraham Lincoln""
                },
                {
                    ""name"": ""Memorial Day"",
                    ""date"": ""Last Monday in May"",
                    ""type"": ""Federal"",
                    ""description"": ""Honors military personnel who died in service""
                },
                {
                    ""name"": ""Independence Day"",
                    ""date"": ""July 4"",
                    ""type"": ""Federal"",
                    ""description"": ""Celebrates the Declaration of Independence in 1776""
                },
                {
                    ""name"": ""Labor Day"",
                    ""date"": ""First Monday in September"",
                    ""type"": ""Federal"",
                    ""description"": ""Celebrates the American labor movement""
                },
                {
                    ""name"": ""Columbus Day"",
                    ""date"": ""Second Monday in October"",
                    ""type"": ""Federal"",
                    ""description"": ""Commemorates Christopher Columbus's arrival in the Americas""
                },
                {
                    ""name"": ""Veterans Day"",
                    ""date"": ""November 11"",
                    ""type"": ""Federal"",
                    ""description"": ""Honors all military veterans""
                },
                {
                    ""name"": ""Thanksgiving Day"",
                    ""date"": ""Fourth Thursday in November"",
                    ""type"": ""Federal"",
                    ""description"": ""Traditional harvest festival""
                },
                {
                    ""name"": ""Christmas Day"",
                    ""date"": ""December 25"",
                    ""type"": ""Federal"",
                    ""description"": ""Celebrates the birth of Jesus Christ""
                }
            ]
        }";
    }

    [McpServerResource(UriTemplate = "holidays://uk", Name = "UK Holidays"), Description("List of major holidays in the United Kingdom")]
    public static string GetUKHolidays()
    {
        return @"{
            ""country"": ""United Kingdom"",
            ""code"": ""UK"",
            ""holidays"": [
                {
                    ""name"": ""New Year's Day"",
                    ""date"": ""January 1"",
                    ""type"": ""Bank Holiday"",
                    ""description"": ""Celebrates the beginning of the new year""
                },
                {
                    ""name"": ""Good Friday"",
                    ""date"": ""Friday before Easter"",
                    ""type"": ""Bank Holiday"",
                    ""description"": ""Christian holy day commemorating the crucifixion of Jesus""
                },
                {
                    ""name"": ""Easter Monday"",
                    ""date"": ""Monday after Easter"",
                    ""type"": ""Bank Holiday"",
                    ""description"": ""Christian holy day following Easter Sunday""
                },
                {
                    ""name"": ""Early May Bank Holiday"",
                    ""date"": ""First Monday in May"",
                    ""type"": ""Bank Holiday"",
                    ""description"": ""Traditional spring holiday""
                },
                {
                    ""name"": ""Spring Bank Holiday"",
                    ""date"": ""Last Monday in May"",
                    ""type"": ""Bank Holiday"",
                    ""description"": ""Late spring holiday""
                },
                {
                    ""name"": ""Summer Bank Holiday"",
                    ""date"": ""Last Monday in August"",
                    ""type"": ""Bank Holiday"",
                    ""description"": ""Late summer holiday""
                },
                {
                    ""name"": ""Christmas Day"",
                    ""date"": ""December 25"",
                    ""type"": ""Bank Holiday"",
                    ""description"": ""Celebrates the birth of Jesus Christ""
                },
                {
                    ""name"": ""Boxing Day"",
                    ""date"": ""December 26"",
                    ""type"": ""Bank Holiday"",
                    ""description"": ""Traditional gift-giving day following Christmas""
                }
            ]
        }";
    }

    [McpServerResource(UriTemplate = "holidays://ca", Name = "Canada Holidays"), Description("List of major holidays in Canada")]
    public static string GetCanadaHolidays()
    {
        return @"{
            ""country"": ""Canada"",
            ""code"": ""CA"",
            ""holidays"": [
                {
                    ""name"": ""New Year's Day"",
                    ""date"": ""January 1"",
                    ""type"": ""Federal"",
                    ""description"": ""Celebrates the beginning of the new year""
                },
                {
                    ""name"": ""Good Friday"",
                    ""date"": ""Friday before Easter"",
                    ""type"": ""Federal"",
                    ""description"": ""Christian holy day commemorating the crucifixion of Jesus""
                },
                {
                    ""name"": ""Easter Monday"",
                    ""date"": ""Monday after Easter"",
                    ""type"": ""Federal"",
                    ""description"": ""Christian holy day following Easter Sunday""
                },
                {
                    ""name"": ""Victoria Day"",
                    ""date"": ""Monday preceding May 25"",
                    ""type"": ""Federal"",
                    ""description"": ""Honors Queen Victoria's birthday""
                },
                {
                    ""name"": ""Canada Day"",
                    ""date"": ""July 1"",
                    ""type"": ""Federal"",
                    ""description"": ""Celebrates Canadian Confederation in 1867""
                },
                {
                    ""name"": ""Labour Day"",
                    ""date"": ""First Monday in September"",
                    ""type"": ""Federal"",
                    ""description"": ""Celebrates the labour movement""
                },
                {
                    ""name"": ""Thanksgiving"",
                    ""date"": ""Second Monday in October"",
                    ""type"": ""Federal"",
                    ""description"": ""Traditional harvest festival""
                },
                {
                    ""name"": ""Remembrance Day"",
                    ""date"": ""November 11"",
                    ""type"": ""Federal"",
                    ""description"": ""Honors military personnel who died in service""
                },
                {
                    ""name"": ""Christmas Day"",
                    ""date"": ""December 25"",
                    ""type"": ""Federal"",
                    ""description"": ""Celebrates the birth of Jesus Christ""
                },
                {
                    ""name"": ""Boxing Day"",
                    ""date"": ""December 26"",
                    ""type"": ""Federal"",
                    ""description"": ""Traditional gift-giving day following Christmas""
                }
            ]
        }";
    }

    [McpServerResource(UriTemplate = "holidays://au", Name = "Australia Holidays"), Description("List of major holidays in Australia")]
    public static string GetAustraliaHolidays()
    {
        return @"{
            ""country"": ""Australia"",
            ""code"": ""AU"",
            ""holidays"": [
                {
                    ""name"": ""New Year's Day"",
                    ""date"": ""January 1"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates the beginning of the new year""
                },
                {
                    ""name"": ""Australia Day"",
                    ""date"": ""January 26"",
                    ""type"": ""National"",
                    ""description"": ""Commemorates the arrival of the First Fleet in 1788""
                },
                {
                    ""name"": ""Good Friday"",
                    ""date"": ""Friday before Easter"",
                    ""type"": ""National"",
                    ""description"": ""Christian holy day commemorating the crucifixion of Jesus""
                },
                {
                    ""name"": ""Easter Saturday"",
                    ""date"": ""Saturday before Easter"",
                    ""type"": ""National"",
                    ""description"": ""Part of the Easter weekend""
                },
                {
                    ""name"": ""Easter Monday"",
                    ""date"": ""Monday after Easter"",
                    ""type"": ""National"",
                    ""description"": ""Christian holy day following Easter Sunday""
                },
                {
                    ""name"": ""ANZAC Day"",
                    ""date"": ""April 25"",
                    ""type"": ""National"",
                    ""description"": ""Commemorates Australian and New Zealand Army Corps""
                },
                {
                    ""name"": ""Queen's Birthday"",
                    ""date"": ""Second Monday in June"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates the monarch's birthday""
                },
                {
                    ""name"": ""Christmas Day"",
                    ""date"": ""December 25"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates the birth of Jesus Christ""
                },
                {
                    ""name"": ""Boxing Day"",
                    ""date"": ""December 26"",
                    ""type"": ""National"",
                    ""description"": ""Traditional gift-giving day following Christmas""
                }
            ]
        }";
    }

    [McpServerResource(UriTemplate = "holidays://de", Name = "Germany Holidays"), Description("List of major holidays in Germany")]
    public static string GetGermanyHolidays()
    {
        return @"{
            ""country"": ""Germany"",
            ""code"": ""DE"",
            ""holidays"": [
                {
                    ""name"": ""New Year's Day"",
                    ""date"": ""January 1"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates the beginning of the new year""
                },
                {
                    ""name"": ""Epiphany"",
                    ""date"": ""January 6"",
                    ""type"": ""Regional"",
                    ""description"": ""Christian feast celebrating the revelation of God in Jesus""
                },
                {
                    ""name"": ""Good Friday"",
                    ""date"": ""Friday before Easter"",
                    ""type"": ""National"",
                    ""description"": ""Christian holy day commemorating the crucifixion of Jesus""
                },
                {
                    ""name"": ""Easter Monday"",
                    ""date"": ""Monday after Easter"",
                    ""type"": ""National"",
                    ""description"": ""Christian holy day following Easter Sunday""
                },
                {
                    ""name"": ""Labour Day"",
                    ""date"": ""May 1"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates workers and the labour movement""
                },
                {
                    ""name"": ""Ascension Day"",
                    ""date"": ""39 days after Easter"",
                    ""type"": ""National"",
                    ""description"": ""Christian holy day commemorating the ascension of Jesus""
                },
                {
                    ""name"": ""Whit Monday"",
                    ""date"": ""50 days after Easter"",
                    ""type"": ""National"",
                    ""description"": ""Christian holy day following Pentecost""
                },
                {
                    ""name"": ""German Unity Day"",
                    ""date"": ""October 3"",
                    ""type"": ""National"",
                    ""description"": ""Commemorates German reunification in 1990""
                },
                {
                    ""name"": ""Christmas Day"",
                    ""date"": ""December 25"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates the birth of Jesus Christ""
                },
                {
                    ""name"": ""Boxing Day"",
                    ""date"": ""December 26"",
                    ""type"": ""National"",
                    ""description"": ""Second day of Christmas""
                }
            ]
        }";
    }

    [McpServerResource(UriTemplate = "holidays://fr", Name = "France Holidays"), Description("List of major holidays in France")]
    public static string GetFranceHolidays()
    {
        return @"{
            ""country"": ""France"",
            ""code"": ""FR"",
            ""holidays"": [
                {
                    ""name"": ""New Year's Day"",
                    ""date"": ""January 1"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates the beginning of the new year""
                },
                {
                    ""name"": ""Easter Monday"",
                    ""date"": ""Monday after Easter"",
                    ""type"": ""National"",
                    ""description"": ""Christian holy day following Easter Sunday""
                },
                {
                    ""name"": ""Labour Day"",
                    ""date"": ""May 1"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates workers and the labour movement""
                },
                {
                    ""name"": ""Victory in Europe Day"",
                    ""date"": ""May 8"",
                    ""type"": ""National"",
                    ""description"": ""Commemorates the end of World War II in Europe""
                },
                {
                    ""name"": ""Ascension Day"",
                    ""date"": ""39 days after Easter"",
                    ""type"": ""National"",
                    ""description"": ""Christian holy day commemorating the ascension of Jesus""
                },
                {
                    ""name"": ""Whit Monday"",
                    ""date"": ""50 days after Easter"",
                    ""type"": ""National"",
                    ""description"": ""Christian holy day following Pentecost""
                },
                {
                    ""name"": ""Bastille Day"",
                    ""date"": ""July 14"",
                    ""type"": ""National"",
                    ""description"": ""Commemorates the French Revolution in 1789""
                },
                {
                    ""name"": ""Assumption of Mary"",
                    ""date"": ""August 15"",
                    ""type"": ""National"",
                    ""description"": ""Christian feast celebrating the assumption of Mary""
                },
                {
                    ""name"": ""All Saints' Day"",
                    ""date"": ""November 1"",
                    ""type"": ""National"",
                    ""description"": ""Christian feast honoring all saints""
                },
                {
                    ""name"": ""Armistice Day"",
                    ""date"": ""November 11"",
                    ""type"": ""National"",
                    ""description"": ""Commemorates the armistice signed to end World War I""
                },
                {
                    ""name"": ""Christmas Day"",
                    ""date"": ""December 25"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates the birth of Jesus Christ""
                }
            ]
        }";
    }

    [McpServerResource(UriTemplate = "holidays://jp", Name = "Japan Holidays"), Description("List of major holidays in Japan")]
    public static string GetJapanHolidays()
    {
        return @"{
            ""country"": ""Japan"",
            ""code"": ""JP"",
            ""holidays"": [
                {
                    ""name"": ""New Year's Day"",
                    ""date"": ""January 1"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates the beginning of the new year""
                },
                {
                    ""name"": ""Coming of Age Day"",
                    ""date"": ""Second Monday in January"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates those who have reached the age of majority""
                },
                {
                    ""name"": ""National Foundation Day"",
                    ""date"": ""February 11"",
                    ""type"": ""National"",
                    ""description"": ""Commemorates the founding of Japan""
                },
                {
                    ""name"": ""Emperor's Birthday"",
                    ""date"": ""February 23"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates the current Emperor's birthday""
                },
                {
                    ""name"": ""Vernal Equinox Day"",
                    ""date"": ""Around March 20"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates the spring equinox""
                },
                {
                    ""name"": ""Showa Day"",
                    ""date"": ""April 29"",
                    ""type"": ""National"",
                    ""description"": ""Commemorates Emperor Showa's birthday""
                },
                {
                    ""name"": ""Constitution Memorial Day"",
                    ""date"": ""May 3"",
                    ""type"": ""National"",
                    ""description"": ""Commemorates the Japanese Constitution""
                },
                {
                    ""name"": ""Greenery Day"",
                    ""date"": ""May 4"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates nature and the environment""
                },
                {
                    ""name"": ""Children's Day"",
                    ""date"": ""May 5"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates children's well-being and happiness""
                },
                {
                    ""name"": ""Marine Day"",
                    ""date"": ""Third Monday in July"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates the ocean and marine resources""
                },
                {
                    ""name"": ""Mountain Day"",
                    ""date"": ""August 11"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates mountains and their benefits""
                },
                {
                    ""name"": ""Respect for the Aged Day"",
                    ""date"": ""Third Monday in September"",
                    ""type"": ""National"",
                    ""description"": ""Honors elderly citizens""
                },
                {
                    ""name"": ""Autumnal Equinox Day"",
                    ""date"": ""Around September 23"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates the autumn equinox""
                },
                {
                    ""name"": ""Health and Sports Day"",
                    ""date"": ""Second Monday in October"",
                    ""type"": ""National"",
                    ""description"": ""Promotes health and physical fitness""
                },
                {
                    ""name"": ""Culture Day"",
                    ""date"": ""November 3"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates arts, culture, and academic endeavors""
                },
                {
                    ""name"": ""Labor Thanksgiving Day"",
                    ""date"": ""November 23"",
                    ""type"": ""National"",
                    ""description"": ""Celebrates workers and labor""
                }
            ]
        }";
    }

    [McpServerResource(UriTemplate = "holidays://list", Name = "Available Countries"), Description("List of all available holiday resources by country")]
    public static string GetAvailableHolidayCountries()
    {
        return @"{
            ""available_countries"": [
                {
                    ""name"": ""United States"",
                    ""code"": ""US"",
                    ""uri"": ""holidays://us"",
                    ""description"": ""Federal holidays in the United States""
                },
                {
                    ""name"": ""United Kingdom"",
                    ""code"": ""UK"",
                    ""uri"": ""holidays://uk"",
                    ""description"": ""Bank holidays in the United Kingdom""
                },
                {
                    ""name"": ""Canada"",
                    ""code"": ""CA"",
                    ""uri"": ""holidays://ca"",
                    ""description"": ""Federal holidays in Canada""
                },
                {
                    ""name"": ""Australia"",
                    ""code"": ""AU"",
                    ""uri"": ""holidays://au"",
                    ""description"": ""National holidays in Australia""
                },
                {
                    ""name"": ""Germany"",
                    ""code"": ""DE"",
                    ""uri"": ""holidays://de"",
                    ""description"": ""National holidays in Germany""
                },
                {
                    ""name"": ""France"",
                    ""code"": ""FR"",
                    ""uri"": ""holidays://fr"",
                    ""description"": ""National holidays in France""
                },
                {
                    ""name"": ""Japan"",
                    ""code"": ""JP"",
                    ""uri"": ""holidays://jp"",
                    ""description"": ""National holidays in Japan""
                }
            ]
        }";
    }
}
