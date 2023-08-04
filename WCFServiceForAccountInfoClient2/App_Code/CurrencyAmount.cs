using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Linq;

/// <summary>
/// Summary description for CurrencyAmount
/// </summary>
/// 
[DataContract(Name = "CurrencyAmount")]
public class CurrencyAmount
{
    private decimal amountField;

    private Currency currencyField;

    public CurrencyAmount(decimal amount, Currency currency)
    {
        Amount = amount;
        Currency = currency;
    }

    //
    // Summary:
    //     The value of the currency amount. Always positive by convention.
    [DataMember(Name = "Amount", IsRequired = true, Order = 0)]
    public decimal Amount
    {
        get
        {
            return amountField;
        }
        set
        {
            amountField = value;
        }
    }

    //
    // Summary:
    //     The currency of the monetary amount.
    [DataMember(Name = "Currency", IsRequired = true, Order = 1)]
    public Currency Currency
    {
        get
        {
            return currencyField;
        }
        set
        {
            currencyField = value;
        }
    }
}