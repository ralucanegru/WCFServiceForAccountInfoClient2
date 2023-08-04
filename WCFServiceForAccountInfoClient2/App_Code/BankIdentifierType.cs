using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for BankIdentifierType
/// </summary>
public enum BankIdentifierType
{
    //
    // Summary:
    //     Bank Identification Code.
    [EnumMember(Value = "BIC")]
    BIC,
    //
    // Summary:
    //     National payment systems defined bank identifier .
    [EnumMember(Value = "NationalPaymentSystem")]
    NationalPaymentSystem
}