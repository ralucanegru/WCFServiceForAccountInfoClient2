using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Xml.Linq;

/// <summary>
/// Summary description for MultiLanguageText
/// </summary>
/// 
[DataContract(Name = "MultiLanguageText")]
public class MultiLanguageText
{
    private Language languageField;

    private string textField;

    public MultiLanguageText(Language language, string text)
    {
        Language = language;
        Text = text;
    }

    //
    // Summary:
    //     Language of the curren text item.
    [DataMember(Name = "Language", IsRequired = false, Order = 1)]
    public Language Language
    {
        get
        {
            return languageField;
        }
        set
        {
            languageField = value;
        }
    }

    //
    // Summary:
    //     Text in Quipu.Banking.DataContracts.MultiLanguageText.Language.
    [DataMember(Name = "Text", IsRequired = false, Order = 0)]
    public string Text
    {
        get
        {
            return textField;
        }
        set
        {
            textField = value;
        }
    }
}