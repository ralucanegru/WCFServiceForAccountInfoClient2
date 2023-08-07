using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Linq;

/// <summary>
/// Summary description for Requestor
/// </summary>
[DataContract( Name = "Requestor")]
public enum Requestor
{
    //
    // Summary:
    //     Requestor is ebanking application.
    [EnumMember(Value = "EBA")]
    EBA,
    //
    // Summary:
    //     Requestor is mobile application.
    [EnumMember(Value = "MBA")]
    MBA,
    //
    // Summary:
    //     Requestor is third party application.
    [EnumMember(Value = "TPP")]
    TPP,
    //
    // Summary:
    //     Requestor is PSE.
    [EnumMember(Value = "PSE")]
    PSE
}