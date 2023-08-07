using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Linq;

/// <summary>
/// Summary description for AccessContract
/// </summary>
/// 
[DataContract(Name = "AccessContract")]
[KnownType(typeof(Requestor))]
public class AccessContract
{   
    private string accessIdentifierField;

    private Requestor requestorField;

    //
    // Summary:
    //     Identifies the contract.
    [DataMember(Name = "AccessIdentifier", IsRequired = true, Order = 0)]
    public string AccessIdentifier
    {
        get
        {
            return accessIdentifierField;
        }
        set
        {
            accessIdentifierField = value;
        }
    }

    //
    // Summary:
    //     Identifies the calling application.
    [DataMember(Name = "Requestor", IsRequired = true, Order = 1)]
    public Requestor Requestor
    {
        get
        {
            return requestorField;
        }
        set
        {
            requestorField = value;
        }
    }

    public AccessContract(string accessIdentifier, Requestor requestor)
    {
        AccessIdentifier = accessIdentifier;
        Requestor = requestor;
    }
}