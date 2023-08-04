using System.Runtime.Serialization;

/// <summary>
/// Summary description for BankIdentifier
/// </summary>
[DataContract(Name = "BankIdentifier")]
[KnownType(typeof(BankIdentifierType))]
public class BankIdentifier
{
    private string codeField;

    private BankIdentifierType bankIdentifierTypeField;

    public BankIdentifier(string code, BankIdentifierType bankIdentifierType)
    {
        Code = code;
        BankIdentifierType = bankIdentifierType;
    }

    //
    // Summary:
    //     Code of the bank identifier. Refer to the 'BankIdentifierType' member in order
    //     to interpret the code.
    [DataMember(Name = "Code", IsRequired = false, Order = 0)]
    public string Code
    {
        get
        {
            return codeField;
        }
        set
        {
            codeField = value;
        }
    }

    //
    // Summary:
    //     Idicates the type of the bank identifier code.
    [DataMember(Name = "BankIdentifierType", IsRequired = false, Order = 1)]
    public BankIdentifierType BankIdentifierType
    {
        get
        {
            return bankIdentifierTypeField;
        }
        set
        {
            bankIdentifierTypeField = value;
        }
    }

    public BankIdentifier()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}