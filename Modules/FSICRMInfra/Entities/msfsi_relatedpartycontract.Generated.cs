//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Microsoft.CloudForFSI.Tables
{
    using Microsoft.CloudForFSI.OptionSets;
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum msfsi_relatedpartycontractState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// A table that links the service providers with service requestors/participants to the relevant contract.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msfsi_relatedpartycontract")]
	public partial class msfsi_relatedpartycontract : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msfsi_relatedpartycontract() : 
				base(EntityLogicalName)
		{
		}
		
		public const string AlternateKeys = "msfsi_contractpart,msfsi_party,msfsi_contractpartidtype,msfsi_partyidtype,msfsi_v" +
			"alidfrom,msfsi_relatedparty_role";
		
		public const string EntityLogicalName = "msfsi_relatedpartycontract";
		
		public const string EntitySchemaName = "msfsi_relatedpartycontract";
		
		public const string PrimaryIdAttribute = "msfsi_relatedpartycontractid";
		
		public const string PrimaryNameAttribute = "msfsi_name";
		
		public const string EntityLogicalCollectionName = "msfsi_relatedpartycontracts";
		
		public const string EntitySetName = "msfsi_relatedpartycontracts";
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the record was modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// The first address city of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_address1_city")]
		public string msfsi_address1_city
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msfsi_address1_city");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_address1_city");
				this.SetAttributeValue("msfsi_address1_city", value);
				this.OnPropertyChanged("msfsi_address1_city");
			}
		}
		
		/// <summary>
		/// The first address country or region for the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_address1_country")]
		public string msfsi_address1_country
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msfsi_address1_country");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_address1_country");
				this.SetAttributeValue("msfsi_address1_country", value);
				this.OnPropertyChanged("msfsi_address1_country");
			}
		}
		
		/// <summary>
		/// Type the county for the primary address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_address1_county")]
		public string msfsi_address1_county
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msfsi_address1_county");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_address1_county");
				this.SetAttributeValue("msfsi_address1_county", value);
				this.OnPropertyChanged("msfsi_address1_county");
			}
		}
		
		/// <summary>
		/// The first address of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_address1_name")]
		public string msfsi_address1_name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msfsi_address1_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_address1_name");
				this.SetAttributeValue("msfsi_address1_name", value);
				this.OnPropertyChanged("msfsi_address1_name");
			}
		}
		
		/// <summary>
		/// The main phone number of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_address1_telephone1")]
		public string msfsi_address1_telephone1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msfsi_address1_telephone1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_address1_telephone1");
				this.SetAttributeValue("msfsi_address1_telephone1", value);
				this.OnPropertyChanged("msfsi_address1_telephone1");
			}
		}
		
		/// <summary>
		/// The first address post office box of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_address1postofficebox")]
		public string msfsi_address1postofficebox
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msfsi_address1postofficebox");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_address1postofficebox");
				this.SetAttributeValue("msfsi_address1postofficebox", value);
				this.OnPropertyChanged("msfsi_address1postofficebox");
			}
		}
		
		/// <summary>
		/// The first address state or province of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_address1stateprovince")]
		public string msfsi_address1stateprovince
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msfsi_address1stateprovince");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_address1stateprovince");
				this.SetAttributeValue("msfsi_address1stateprovince", value);
				this.OnPropertyChanged("msfsi_address1stateprovince");
			}
		}
		
		/// <summary>
		/// The first address ZIP Code or postal code of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_address1zippostalcode")]
		public string msfsi_address1zippostalcode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msfsi_address1zippostalcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_address1zippostalcode");
				this.SetAttributeValue("msfsi_address1zippostalcode", value);
				this.OnPropertyChanged("msfsi_address1zippostalcode");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_age")]
		public System.Nullable<int> msfsi_age
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("msfsi_age");
			}
		}
		
		/// <summary>
		/// The birthday of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_birthday")]
		public System.Nullable<System.DateTime> msfsi_birthday
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("msfsi_birthday");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_birthday");
				this.SetAttributeValue("msfsi_birthday", value);
				this.OnPropertyChanged("msfsi_birthday");
			}
		}
		
		/// <summary>
		/// Link to the original record of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_contact")]
		public Microsoft.Xrm.Sdk.EntityReference msfsi_contact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msfsi_contact");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_contact");
				this.SetAttributeValue("msfsi_contact", value);
				this.OnPropertyChanged("msfsi_contact");
			}
		}
		
		/// <summary>
		/// The contract part the relationship is about.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_contractpart")]
		public Microsoft.Xrm.Sdk.EntityReference msfsi_contractpart
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msfsi_contractpart");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_contractpart");
				this.SetAttributeValue("msfsi_contractpart", value);
				this.OnPropertyChanged("msfsi_contractpart");
			}
		}
		
		/// <summary>
		/// The credit check associated with the application contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_credit_check")]
		public Microsoft.Xrm.Sdk.EntityReference msfsi_credit_check
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msfsi_credit_check");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_credit_check");
				this.SetAttributeValue("msfsi_credit_check", value);
				this.OnPropertyChanged("msfsi_credit_check");
			}
		}
		
		/// <summary>
		/// The credeit score associated with this application contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_creditscore")]
		public System.Nullable<int> msfsi_creditscore
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("msfsi_creditscore");
			}
		}
		
		/// <summary>
		/// Number of dependents associated with the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_dependents")]
		public System.Nullable<int> msfsi_dependents
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("msfsi_dependents");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_dependents");
				this.SetAttributeValue("msfsi_dependents", value);
				this.OnPropertyChanged("msfsi_dependents");
			}
		}
		
		/// <summary>
		/// List of ages of the dependents of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_dependentsyears")]
		public string msfsi_dependentsyears
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msfsi_dependentsyears");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_dependentsyears");
				this.SetAttributeValue("msfsi_dependentsyears", value);
				this.OnPropertyChanged("msfsi_dependentsyears");
			}
		}
		
		/// <summary>
		/// The first email of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_emailaddress")]
		public string msfsi_emailaddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msfsi_emailaddress");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_emailaddress");
				this.SetAttributeValue("msfsi_emailaddress", value);
				this.OnPropertyChanged("msfsi_emailaddress");
			}
		}
		
		/// <summary>
		/// The first name of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_firstname")]
		public string msfsi_firstname
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msfsi_firstname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_firstname");
				this.SetAttributeValue("msfsi_firstname", value);
				this.OnPropertyChanged("msfsi_firstname");
			}
		}
		
		/// <summary>
		/// The passport number or other government ID of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_governmentid")]
		public string msfsi_governmentid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msfsi_governmentid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_governmentid");
				this.SetAttributeValue("msfsi_governmentid", value);
				this.OnPropertyChanged("msfsi_governmentid");
			}
		}
		
		/// <summary>
		/// When true, indicates that the applicant is the primary on the application.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_isprimary")]
		public System.Nullable<bool> msfsi_isprimary
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msfsi_isprimary");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_isprimary");
				this.SetAttributeValue("msfsi_isprimary", value);
				this.OnPropertyChanged("msfsi_isprimary");
			}
		}
		
		/// <summary>
		/// The Know Your Customer record associated with this application contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_kyc_check")]
		public Microsoft.Xrm.Sdk.EntityReference msfsi_kyc_check
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msfsi_kyc_check");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_kyc_check");
				this.SetAttributeValue("msfsi_kyc_check", value);
				this.OnPropertyChanged("msfsi_kyc_check");
			}
		}
		
		/// <summary>
		/// The Know Your Customer assessment date associated with this application contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_kycassessmentdate")]
		public System.Nullable<System.DateTime> msfsi_kycassessmentdate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("msfsi_kycassessmentdate");
			}
		}
		
		/// <summary>
		/// The Know Your Customer score associated with this application contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_kycscore")]
		public System.Nullable<int> msfsi_kycscore
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("msfsi_kycscore");
			}
		}
		
		
		/// <summary>
		/// The last name of the contact.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_lastname")]
		public string msfsi_lastname
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msfsi_lastname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_lastname");
				this.SetAttributeValue("msfsi_lastname", value);
				this.OnPropertyChanged("msfsi_lastname");
			}
		}
		
		/// <summary>
		/// The Contact's middle name.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_middlename")]
		public string msfsi_middlename
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msfsi_middlename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_middlename");
				this.SetAttributeValue("msfsi_middlename", value);
				this.OnPropertyChanged("msfsi_middlename");
			}
		}
		
		/// <summary>
		/// Required name field.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_name")]
		public string msfsi_name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msfsi_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_name");
				this.SetAttributeValue("msfsi_name", value);
				this.OnPropertyChanged("msfsi_name");
			}
		}
		
		/// <summary>
		/// Defines the service provider e.g. insurance agency, bank, agent.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_party")]
		public Microsoft.Xrm.Sdk.EntityReference msfsi_party
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msfsi_party");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_party");
				this.SetAttributeValue("msfsi_party", value);
				this.OnPropertyChanged("msfsi_party");
			}
		}
		
		/// <summary>
		/// A calculated field helping determine if this application contact is the primary member of the application.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_primarymemberhelper")]
		public string msfsi_primarymemberhelper
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msfsi_primarymemberhelper");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_primarymemberhelper");
				this.SetAttributeValue("msfsi_primarymemberhelper", value);
				this.OnPropertyChanged("msfsi_primarymemberhelper");
			}
		}
		
		/// <summary>
		/// The role the related party plays in the current relationship context.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_relatedparty_role")]
		public Microsoft.Xrm.Sdk.EntityReference msfsi_relatedparty_role
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msfsi_relatedparty_role");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_relatedparty_role");
				this.SetAttributeValue("msfsi_relatedparty_role", value);
				this.OnPropertyChanged("msfsi_relatedparty_role");
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_relatedpartycontractid")]
		public System.Nullable<System.Guid> msfsi_relatedpartycontractId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("msfsi_relatedpartycontractid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_relatedpartycontractId");
				this.SetAttributeValue("msfsi_relatedpartycontractid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("msfsi_relatedpartycontractId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_relatedpartycontractid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.msfsi_relatedpartycontractId = value;
			}
		}
		
		/// <summary>
		/// Validity start date for related party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_validfrom")]
		public System.Nullable<System.DateTime> msfsi_validfrom
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("msfsi_validfrom");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_validfrom");
				this.SetAttributeValue("msfsi_validfrom", value);
				this.OnPropertyChanged("msfsi_validfrom");
			}
		}
		
		/// <summary>
		/// Expiry date of related party.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msfsi_validto")]
		public System.Nullable<System.DateTime> msfsi_validto
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("msfsi_validto");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msfsi_validto");
				this.SetAttributeValue("msfsi_validto", value);
				this.OnPropertyChanged("msfsi_validto");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Owner Id
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the business unit that owns the record
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Status of the Related party
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<Microsoft.CloudForFSI.Tables.msfsi_relatedpartycontractState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
                    return ((Microsoft.CloudForFSI.Tables.msfsi_relatedpartycontractState)(System.Enum.ToObject(typeof(Microsoft.CloudForFSI.Tables.msfsi_relatedpartycontractState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Related party
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual msfsi_relatedpartycontract_StatusCode? StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((msfsi_relatedpartycontract_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msfsi_relatedpartycontract(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int)value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["msfsi_relatedpartycontractid"] = base.Id;
                        break;
                    case "msfsi_relatedpartycontractid":
                        var id = (System.Nullable<System.Guid>)value;
                        if (id == null)
                        { continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}
}