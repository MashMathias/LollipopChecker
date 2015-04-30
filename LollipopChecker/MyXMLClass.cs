
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class response
{

    private responseAuth_model_check auth_model_checkField;

    private string req_cmdField;

    private string statusField;

    /// <remarks/>
    public responseAuth_model_check auth_model_check
    {
        get
        {
            return this.auth_model_checkField;
        }
        set
        {
            this.auth_model_checkField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string req_cmd
    {
        get
        {
            return this.req_cmdField;
        }
        set
        {
            this.req_cmdField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string status
    {
        get
        {
            return this.statusField;
        }
        set
        {
            this.statusField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class responseAuth_model_check
{

    private string resultField;

    private ulong esnField;

    private string modelField;

    private string suffixField;

    private string msnField;

    private object esn_dateField;

    private string sw_versionField;

    private string sw_urlField;

    private object sw_locale_urlField;

    private object sw_recommand_uriField;

    private object app_versionField;

    private object app_urlField;

    private string cs_em_flagField;

    private string cs_em_uriField;

    private string chip_typeField;

    private string prod_typeField;

    private string buyerField;

    /// <remarks/>
    public string result
    {
        get
        {
            return this.resultField;
        }
        set
        {
            this.resultField = value;
        }
    }

    /// <remarks/>
    public ulong esn
    {
        get
        {
            return this.esnField;
        }
        set
        {
            this.esnField = value;
        }
    }

    /// <remarks/>
    public string model
    {
        get
        {
            return this.modelField;
        }
        set
        {
            this.modelField = value;
        }
    }

    /// <remarks/>
    public string suffix
    {
        get
        {
            return this.suffixField;
        }
        set
        {
            this.suffixField = value;
        }
    }

    /// <remarks/>
    public string msn
    {
        get
        {
            return this.msnField;
        }
        set
        {
            this.msnField = value;
        }
    }

    /// <remarks/>
    public object esn_date
    {
        get
        {
            return this.esn_dateField;
        }
        set
        {
            this.esn_dateField = value;
        }
    }

    /// <remarks/>
    public string sw_version
    {
        get
        {
            return this.sw_versionField;
        }
        set
        {
            this.sw_versionField = value;
        }
    }

    /// <remarks/>
    public string sw_url
    {
        get
        {
            return this.sw_urlField;
        }
        set
        {
            this.sw_urlField = value;
        }
    }

    /// <remarks/>
    public object sw_locale_url
    {
        get
        {
            return this.sw_locale_urlField;
        }
        set
        {
            this.sw_locale_urlField = value;
        }
    }

    /// <remarks/>
    public object sw_recommand_uri
    {
        get
        {
            return this.sw_recommand_uriField;
        }
        set
        {
            this.sw_recommand_uriField = value;
        }
    }

    /// <remarks/>
    public object app_version
    {
        get
        {
            return this.app_versionField;
        }
        set
        {
            this.app_versionField = value;
        }
    }

    /// <remarks/>
    public object app_url
    {
        get
        {
            return this.app_urlField;
        }
        set
        {
            this.app_urlField = value;
        }
    }

    /// <remarks/>
    public string cs_em_flag
    {
        get
        {
            return this.cs_em_flagField;
        }
        set
        {
            this.cs_em_flagField = value;
        }
    }

    /// <remarks/>
    public string cs_em_uri
    {
        get
        {
            return this.cs_em_uriField;
        }
        set
        {
            this.cs_em_uriField = value;
        }
    }

    /// <remarks/>
    public string chip_type
    {
        get
        {
            return this.chip_typeField;
        }
        set
        {
            this.chip_typeField = value;
        }
    }

    /// <remarks/>
    public string prod_type
    {
        get
        {
            return this.prod_typeField;
        }
        set
        {
            this.prod_typeField = value;
        }
    }

    /// <remarks/>
    public string buyer
    {
        get
        {
            return this.buyerField;
        }
        set
        {
            this.buyerField = value;
        }
    }
}

