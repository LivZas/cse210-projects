public class Address
{
    private string streetAddress;
    private string city;
    private string stateOrProvince;
    private string country;

    public Address(string streetAddress, string city, string stateOrProvince, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateOrProvince = stateOrProvince;
        this.country = country;
    }

    public bool IsInSomewhere()
    {
        return country.ToLower() == "place";
    }

    public string GetFullAddress()
    {
        return $"{streetAddress}\n{city}, {stateOrProvince}\n{country}";
    }

    public string StreetAddress => streetAddress;
    public string City => city;
    public string StateOrProvince => stateOrProvince;
    public string Country => country;
}
