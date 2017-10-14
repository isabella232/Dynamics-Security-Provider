﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CrmAttributeCollectionAdapter.cs" company="Sitecore A/S">
//   Copyright (c) Sitecore A/S. All rights reserved.
// </copyright>
// <summary>
//   Defines the CrmAttributeCollectionAdapter type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CRMSecurityProvider.Sources.Repository.V3.Attribute
{
  using System.Collections;
  using System.Collections.Generic;
  using System.Linq;
  using CRMSecurityProvider.crm3.webservice;
  using CRMSecurityProvider.Sources.Attribute;

  /// <summary>
  /// The crm attribute collection adapter.
  /// </summary>
  internal class CrmAttributeCollectionAdapter : AdapterBase<DynamicEntity>, ICrmAttributeCollection
  {
    /// <summary>
    /// Initializes a new instance of the <see cref="CrmAttributeCollectionAdapter"/> class.
    /// </summary>
    /// <param name="dynamicEntity">The dynamicEntity.</param>
    public CrmAttributeCollectionAdapter(DynamicEntity dynamicEntity)
      : base(dynamicEntity)
    {
      if (this.Adaptee.Properties == null)
      {
        this.Adaptee.Properties = new Property[] { };
      }
    }

    /// <summary>
    /// Gets the <see cref="System.Object"/> with the specified key.
    /// </summary>
    /// <value>
    /// The <see cref="System.Object"/>.
    /// </value>
    /// <param name="key">The key.</param>
    public ICrmAttribute this[string key]
    {
      get
      {
        var attribute = this.Adaptee.Properties.FirstOrDefault(p => p.Name.Equals(key));
        return attribute != null ? new CrmAttributeAdapter(attribute) : null;
      }
    }

    /// <summary>
    /// Adds the specified name.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="type">The type.</param>
    /// <param name="value">The value.</param>
    /// <param name="data">The data.</param>
    public ICrmAttribute Create(string name, CrmAttributeType type, string value, params string[] data)
    {
      Property property = null;
      switch (type)
      {
        case CrmAttributeType.Boolean:
          property = new CrmBooleanProperty();
          break;
        case CrmAttributeType.Customer:
          property = new CustomerProperty();
          break;
        case CrmAttributeType.DateTime:
          property = new CrmDateTimeProperty();
          break;
        case CrmAttributeType.Decimal:
          property = new CrmDecimalProperty();
          break;
        case CrmAttributeType.Float:
          property = new CrmFloatProperty();
          break;
        case CrmAttributeType.Integer:
          property = new CrmNumberProperty();
          break;
        case CrmAttributeType.Lookup:
          property = new LookupProperty();
          break;
        case CrmAttributeType.Memo:
          property = new StringProperty();
          break;
        case CrmAttributeType.Money:
          property = new CrmMoneyProperty();
          break;
        case CrmAttributeType.Owner:
          property = new OwnerProperty();
          break;
        case CrmAttributeType.Picklist:
          property = new PicklistProperty();
          break;
        case CrmAttributeType.State:
          property = new StateProperty();
          break;
        case CrmAttributeType.Status:
          property = new StatusProperty();
          break;
        case CrmAttributeType.String:
          property = new StringProperty();
          break;
        case CrmAttributeType.UniqueIdentifier:
          property = new UniqueIdentifierProperty();
          break;
        case CrmAttributeType.PartyList:
          property = new DynamicEntityArrayProperty();
          break;
        case CrmAttributeType.Virtual:
        case CrmAttributeType.CalendarRules:
        case CrmAttributeType.Internal:
        case CrmAttributeType.PrimaryKey:
          break;
      }

      this.Add(property);

      var crmAttributeAdapter = new CrmAttributeAdapter(property)
      {
        Name = name
      };
      crmAttributeAdapter.SetValue(value, data);

      return crmAttributeAdapter;
    }

    /// <summary>
    /// Removes the specified name.
    /// </summary>
    /// <param name="name">The name.</param>
    public void Remove(string name)
    {
      var properties = this.Adaptee.Properties.Where(p => !p.Name.Equals(name));
      this.Adaptee.Properties = properties.ToArray();
    }

    /// <summary>
    /// Returns an enumerator that iterates through the collection.
    /// </summary>
    /// <returns>
    /// A <see cref="T:System.Collections.Generic.IEnumerator`1" /> that can be used to iterate through the collection.
    /// </returns>
    public IEnumerator<KeyValuePair<string, ICrmAttribute>> GetEnumerator()
    {
      return this.Adaptee.Properties.Select(p => new KeyValuePair<string, ICrmAttribute>(p.Name, new CrmAttributeAdapter(p))).GetEnumerator();
    }

    /// <summary>
    /// Returns an enumerator that iterates through a collection.
    /// </summary>
    /// <returns>
    /// An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
    /// </returns>
    IEnumerator IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }

    /// <summary>
    /// Adds the range.
    /// </summary>
    /// <param name="properties">The properties.</param>
    private void AddRange(IEnumerable<Property> properties)
    {
      if (properties == null)
      {
        return;
      }

      this.Adaptee.Properties = this.Adaptee.Properties.Union(properties).ToArray();
    }

    /// <summary>
    /// Adds the specified property.
    /// </summary>
    /// <param name="property">The property.</param>
    private void Add(Property property)
    {
      if (property == null)
      {
        return;
      }

      this.AddRange(new[] { property });
    }
  }
}