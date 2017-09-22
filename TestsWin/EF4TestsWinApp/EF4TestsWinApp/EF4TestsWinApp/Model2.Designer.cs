﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace EF4TestsWinApp
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class EF4TestsEntities2 : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new EF4TestsEntities2 object using the connection string found in the 'EF4TestsEntities2' section of the application configuration file.
        /// </summary>
        public EF4TestsEntities2() : base("name=EF4TestsEntities2", "EF4TestsEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EF4TestsEntities2 object.
        /// </summary>
        public EF4TestsEntities2(string connectionString) : base(connectionString, "EF4TestsEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new EF4TestsEntities2 object.
        /// </summary>
        public EF4TestsEntities2(EntityConnection connection) : base(connection, "EF4TestsEntities2")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Customer> Customers
        {
            get
            {
                if ((_Customers == null))
                {
                    _Customers = base.CreateObjectSet<Customer>("Customers");
                }
                return _Customers;
            }
        }
        private ObjectSet<Customer> _Customers;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Customers EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCustomers(Customer customer)
        {
            base.AddObject("Customers", customer);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EF4TestsModel", Name="Customer")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Customer : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Customer object.
        /// </summary>
        /// <param name="customerID">Initial value of the CustomerID property.</param>
        /// <param name="contactPerson">Initial value of the ContactPerson property.</param>
        public static Customer CreateCustomer(global::System.String customerID, global::System.String contactPerson)
        {
            Customer customer = new Customer();
            customer.CustomerID = customerID;
            customer.ContactPerson = contactPerson;
            return customer;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                if (_CustomerID != value)
                {
                    OnCustomerIDChanging(value);
                    ReportPropertyChanging("CustomerID");
                    _CustomerID = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("CustomerID");
                    OnCustomerIDChanged();
                }
            }
        }
        private global::System.String _CustomerID;
        partial void OnCustomerIDChanging(global::System.String value);
        partial void OnCustomerIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CustomerName
        {
            get
            {
                return _CustomerName;
            }
            set
            {
                OnCustomerNameChanging(value);
                ReportPropertyChanging("CustomerName");
                _CustomerName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CustomerName");
                OnCustomerNameChanged();
            }
        }
        private global::System.String _CustomerName;
        partial void OnCustomerNameChanging(global::System.String value);
        partial void OnCustomerNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String MemberCategory
        {
            get
            {
                return _MemberCategory;
            }
            set
            {
                OnMemberCategoryChanging(value);
                ReportPropertyChanging("MemberCategory");
                _MemberCategory = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("MemberCategory");
                OnMemberCategoryChanged();
            }
        }
        private global::System.String _MemberCategory;
        partial void OnMemberCategoryChanging(global::System.String value);
        partial void OnMemberCategoryChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Address
        {
            get
            {
                return _Address;
            }
            set
            {
                OnAddressChanging(value);
                ReportPropertyChanging("Address");
                _Address = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Address");
                OnAddressChanged();
            }
        }
        private global::System.String _Address;
        partial void OnAddressChanging(global::System.String value);
        partial void OnAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String City
        {
            get
            {
                return _City;
            }
            set
            {
                OnCityChanging(value);
                ReportPropertyChanging("City");
                _City = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("City");
                OnCityChanged();
            }
        }
        private global::System.String _City;
        partial void OnCityChanging(global::System.String value);
        partial void OnCityChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String OldPostalCode
        {
            get
            {
                return _OldPostalCode;
            }
            set
            {
                OnOldPostalCodeChanging(value);
                ReportPropertyChanging("OldPostalCode");
                _OldPostalCode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("OldPostalCode");
                OnOldPostalCodeChanged();
            }
        }
        private global::System.String _OldPostalCode;
        partial void OnOldPostalCodeChanging(global::System.String value);
        partial void OnOldPostalCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PostalCode
        {
            get
            {
                return _PostalCode;
            }
            set
            {
                OnPostalCodeChanging(value);
                ReportPropertyChanging("PostalCode");
                _PostalCode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PostalCode");
                OnPostalCodeChanged();
            }
        }
        private global::System.String _PostalCode;
        partial void OnPostalCodeChanging(global::System.String value);
        partial void OnPostalCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CountryCode
        {
            get
            {
                return _CountryCode;
            }
            set
            {
                OnCountryCodeChanging(value);
                ReportPropertyChanging("CountryCode");
                _CountryCode = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CountryCode");
                OnCountryCodeChanged();
            }
        }
        private global::System.String _CountryCode;
        partial void OnCountryCodeChanging(global::System.String value);
        partial void OnCountryCodeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ContactTitle
        {
            get
            {
                return _ContactTitle;
            }
            set
            {
                OnContactTitleChanging(value);
                ReportPropertyChanging("ContactTitle");
                _ContactTitle = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ContactTitle");
                OnContactTitleChanged();
            }
        }
        private global::System.String _ContactTitle;
        partial void OnContactTitleChanging(global::System.String value);
        partial void OnContactTitleChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String PhoneNumber
        {
            get
            {
                return _PhoneNumber;
            }
            set
            {
                OnPhoneNumberChanging(value);
                ReportPropertyChanging("PhoneNumber");
                _PhoneNumber = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("PhoneNumber");
                OnPhoneNumberChanged();
            }
        }
        private global::System.String _PhoneNumber;
        partial void OnPhoneNumberChanging(global::System.String value);
        partial void OnPhoneNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Extension
        {
            get
            {
                return _Extension;
            }
            set
            {
                OnExtensionChanging(value);
                ReportPropertyChanging("Extension");
                _Extension = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Extension");
                OnExtensionChanged();
            }
        }
        private global::System.String _Extension;
        partial void OnExtensionChanging(global::System.String value);
        partial void OnExtensionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String FaxNumber
        {
            get
            {
                return _FaxNumber;
            }
            set
            {
                OnFaxNumberChanging(value);
                ReportPropertyChanging("FaxNumber");
                _FaxNumber = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("FaxNumber");
                OnFaxNumberChanged();
            }
        }
        private global::System.String _FaxNumber;
        partial void OnFaxNumberChanging(global::System.String value);
        partial void OnFaxNumberChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String EmailAddress
        {
            get
            {
                return _EmailAddress;
            }
            set
            {
                OnEmailAddressChanging(value);
                ReportPropertyChanging("EmailAddress");
                _EmailAddress = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("EmailAddress");
                OnEmailAddressChanged();
            }
        }
        private global::System.String _EmailAddress;
        partial void OnEmailAddressChanging(global::System.String value);
        partial void OnEmailAddressChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Notes
        {
            get
            {
                return _Notes;
            }
            set
            {
                OnNotesChanging(value);
                ReportPropertyChanging("Notes");
                _Notes = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Notes");
                OnNotesChanged();
            }
        }
        private global::System.String _Notes;
        partial void OnNotesChanging(global::System.String value);
        partial void OnNotesChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String ContactPerson
        {
            get
            {
                return _ContactPerson;
            }
            set
            {
                OnContactPersonChanging(value);
                ReportPropertyChanging("ContactPerson");
                _ContactPerson = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("ContactPerson");
                OnContactPersonChanged();
            }
        }
        private global::System.String _ContactPerson;
        partial void OnContactPersonChanging(global::System.String value);
        partial void OnContactPersonChanged();

        #endregion
    
    }

    #endregion
    
}
