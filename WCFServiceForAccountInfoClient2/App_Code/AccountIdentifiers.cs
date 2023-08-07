using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Linq;

/// <summary>
/// Summary description for AccountIdentifiers
/// </summary>
[CollectionDataContract(Name = "AccountIdentifiers", ItemName = "AccountIdentifier")]
public class AccountIdentifiers : List<AccountIdentifier>
{
}