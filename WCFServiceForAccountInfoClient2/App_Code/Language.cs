using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Linq;

/// <summary>
/// Summary description for Language
/// </summary>
/// 
[DataContract(Name = "Language")]
public class Language
{
    private string cultureNameField;

    private string shortNameField;

    private string longNameField;

    public Language(string cultureName, string shortName, string longName)
    {
        CultureName = cultureName;
        ShortName = shortName;
        LongName = longName;
    }

    //
    // Summary:
    //     The language name in the format 'languagecode2'-'country/regioncode2', where
    //     'languagecode2' is a lowercase two-letter code derived from ISO 639-1 and 'country/regioncode2'
    //     is an uppercase two-letter code derived from ISO 3166.
    [DataMember(Name = "CultureName", IsRequired = false, Order = 0)]
    public string CultureName
    {
        get
        {
            return cultureNameField;
        }
        set
        {
            cultureNameField = value;
        }
    }

    //
    // Summary:
    //     Short name for a language, for example 'eng'. Should be one of the ISO 639-2
    //     three-letter codes, but might vary depending on banking system's definition.
    [DataMember(Name = "ShortName", IsRequired = false, Order = 1)]
    public string ShortName
    {
        get
        {
            return shortNameField;
        }
        set
        {
            shortNameField = value;
        }
    }

    //
    // Summary:
    //     Long name of a language. For example 'English (United States)'
    //
    // Remarks:
    //     Behaves like System.Globalization.CultureInfo.NativeName.
    //     For CultureName = "en-US", this property should be set to "English (United States)",
    //     for CultureName = "de-DE", this property should be set to "Deutsch (Deutschland)".
    [DataMember(Name = "LongName", IsRequired = false, Order = 2)]
    public string LongName
    {
        get
        {
            return longNameField;
        }
        set
        {
            longNameField = value;
        }
    }
}