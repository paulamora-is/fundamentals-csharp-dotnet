namespace fundamentals.csharp.dotnet.api.Models;

public class Phone
{
    public Phone(string countryCode, string areaCode, string number)
    {
        CountryCode = countryCode;
        AreaCode = areaCode;
        Number = number;
    }

    public Phone() { }

    public string CountryCode { get; set; }
    public string AreaCode { get; set; }
    public string Number { get; set; }
}