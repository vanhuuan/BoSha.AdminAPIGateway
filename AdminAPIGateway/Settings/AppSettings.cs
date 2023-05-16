using Newtonsoft.Json;

namespace AdminAPIGateway.Settings;

public class AppSettings
{
    public Logging Logging { get; set; }
    public string AllowedHosts { get; set; }
    public JwtConfig JwtConfig { get; set; }
}

public class JwtConfig
{
    public string Secret { get; set; }
    public string Secret2 { get; set; }
    public int ExpirationInHours { get; set; }
    public int ExpirationInMonths { get; set; }
}

public class Logging
{
    public LogLevel LogLevel { get; set; }
}

public class LogLevel
{
    public string Default { get; set; }

    [JsonProperty("Microsoft.AspNetCore")]
    public string MicrosoftAspNetCore { get; set; }
}


