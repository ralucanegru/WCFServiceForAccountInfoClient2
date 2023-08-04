using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Linq;

/// <summary>
/// Summary description for Currency
/// </summary>
/// 
[DataContract(Name = "Currency")]
public class Currency
{
    private string isoCodeField;

    public Currency(string isoCode)
    {
        IsoCode = isoCode;
    }

    //
    // Summary:
    //     ISO code. 3 Letters.
    [DataMember(Name = "IsoCode", IsRequired = true, Order = 0)]
    public string IsoCode
    {
        get
        {
            return isoCodeField;
        }
        set
        {
            isoCodeField = value;
        }
    }
}