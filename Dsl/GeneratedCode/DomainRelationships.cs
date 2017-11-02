﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
namespace Ufba.visualForm
{
	/// <summary>
	/// DomainRelationship FormModelHasElements
	/// Embedding relationship between the Model and Elements
	/// </summary>
	[DslDesign::DisplayNameResource("Ufba.visualForm.FormModelHasElements.DisplayName", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Ufba.visualForm.FormModelHasElements.Description", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Ufba.visualForm.visualFormDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship(IsEmbedding=true)]
	[DslModeling::DomainObjectId("b85919e7-c8d5-4c02-a30a-028057cafde3")]
	public partial class FormModelHasElements : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// FormModelHasElements domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xb85919e7, 0xc8d5, 0x4c02, 0xa3, 0x0a, 0x02, 0x80, 0x57, 0xca, 0xfd, 0xe3);
	
				
		/// <summary>
		/// Constructor
		/// Creates a FormModelHasElements link in the same Partition as the given FormModel
		/// </summary>
		/// <param name="source">FormModel to use as the source of the relationship.</param>
		/// <param name="target">Form to use as the target of the relationship.</param>
		public FormModelHasElements(FormModel source, Form target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(FormModelHasElements.FormModelDomainRoleId, source), new DslModeling::RoleAssignment(FormModelHasElements.ElementDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public FormModelHasElements(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public FormModelHasElements(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public FormModelHasElements(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public FormModelHasElements(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region FormModel domain role code
		
		/// <summary>
		/// FormModel domain role Id.
		/// </summary>
		public static readonly global::System.Guid FormModelDomainRoleId = new global::System.Guid(0xb3d25977, 0x077d, 0x4ddb, 0xba, 0xee, 0xfb, 0x8e, 0xd4, 0xc1, 0x89, 0x53);
		
		/// <summary>
		/// DomainRole FormModel
		/// </summary>
		[DslDesign::DisplayNameResource("Ufba.visualForm.FormModelHasElements/FormModel.DisplayName", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Ufba.visualForm.FormModelHasElements/FormModel.Description", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "Elements", PropertyDisplayNameKey="Ufba.visualForm.FormModelHasElements/FormModel.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.PropagatesCopyToLinkAndOppositeRolePlayer, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("b3d25977-077d-4ddb-baee-fb8ed4c18953")]
		public virtual FormModel FormModel
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (FormModel)DslModeling::DomainRoleInfo.GetRolePlayer(this, FormModelDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, FormModelDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access FormModel of a Form
		/// <summary>
		/// Gets FormModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static FormModel GetFormModel(Form element)
		{
			return DslModeling::DomainRoleInfo.GetLinkedElement(element, ElementDomainRoleId) as FormModel;
		}
		
		/// <summary>
		/// Sets FormModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static void SetFormModel(Form element, FormModel newFormModel)
		{
			DslModeling::DomainRoleInfo.SetLinkedElement(element, ElementDomainRoleId, newFormModel);
		}
		#endregion
		#region Element domain role code
		
		/// <summary>
		/// Element domain role Id.
		/// </summary>
		public static readonly global::System.Guid ElementDomainRoleId = new global::System.Guid(0xd914a7bf, 0xf84a, 0x46b8, 0x8b, 0x4f, 0x51, 0x19, 0x2e, 0xd9, 0x27, 0xc9);
		
		/// <summary>
		/// DomainRole Element
		/// </summary>
		[DslDesign::DisplayNameResource("Ufba.visualForm.FormModelHasElements/Element.DisplayName", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Ufba.visualForm.FormModelHasElements/Element.Description", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "FormModel", PropertyDisplayNameKey="Ufba.visualForm.FormModelHasElements/Element.PropertyDisplayName", PropagatesDelete = true,  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.One)]
		[DslModeling::DomainObjectId("d914a7bf-f84a-46b8-8b4f-51192ed927c9")]
		public virtual Form Element
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (Form)DslModeling::DomainRoleInfo.GetRolePlayer(this, ElementDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, ElementDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Elements of a FormModel
		/// <summary>
		/// Gets a list of Elements.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<Form> GetElements(FormModel element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<Form>, Form>(element, FormModelDomainRoleId);
		}
		#endregion
		#region FormModel link accessor
		/// <summary>
		/// Get the list of FormModelHasElements links to a FormModel.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Ufba.visualForm.FormModelHasElements> GetLinksToElements ( global::Ufba.visualForm.FormModel formModelInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Ufba.visualForm.FormModelHasElements>(formModelInstance, global::Ufba.visualForm.FormModelHasElements.FormModelDomainRoleId);
		}
		#endregion
		#region Element link accessor
		/// <summary>
		/// Get the FormModelHasElements link to a Form.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Ufba.visualForm.FormModelHasElements GetLinkToFormModel (global::Ufba.visualForm.Form elementInstance)
		{
			global::System.Collections.Generic.IList<global::Ufba.visualForm.FormModelHasElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Ufba.visualForm.FormModelHasElements>(elementInstance, global::Ufba.visualForm.FormModelHasElements.ElementDomainRoleId);
			global::System.Diagnostics.Debug.Assert(links.Count <= 1, "Multiplicity of Element not obeyed.");
			if ( links.Count == 0 )
			{
				return null;
			}
			else
			{
				return links[0];
			}
		}
		#endregion
		#region FormModelHasElements instance accessors
		
		/// <summary>
		/// Get any FormModelHasElements links between a given FormModel and a Form.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Ufba.visualForm.FormModelHasElements> GetLinks( global::Ufba.visualForm.FormModel source, global::Ufba.visualForm.Form target )
		{
			global::System.Collections.Generic.List<global::Ufba.visualForm.FormModelHasElements> outLinks = new global::System.Collections.Generic.List<global::Ufba.visualForm.FormModelHasElements>();
			global::System.Collections.Generic.IList<global::Ufba.visualForm.FormModelHasElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Ufba.visualForm.FormModelHasElements>(source, global::Ufba.visualForm.FormModelHasElements.FormModelDomainRoleId);
			foreach ( global::Ufba.visualForm.FormModelHasElements link in links )
			{
				if ( target.Equals(link.Element) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one FormModelHasElements link between a given FormModeland a Form.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Ufba.visualForm.FormModelHasElements GetLink( global::Ufba.visualForm.FormModel source, global::Ufba.visualForm.Form target )
		{
			global::System.Collections.Generic.IList<global::Ufba.visualForm.FormModelHasElements> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Ufba.visualForm.FormModelHasElements>(source, global::Ufba.visualForm.FormModelHasElements.FormModelDomainRoleId);
			foreach ( global::Ufba.visualForm.FormModelHasElements link in links )
			{
				if ( target.Equals(link.Element) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
namespace Ufba.visualForm
{
	/// <summary>
	/// DomainRelationship FormHasFields
	/// Description for Ufba.visualForm.FormHasFields
	/// </summary>
	[DslDesign::DisplayNameResource("Ufba.visualForm.FormHasFields.DisplayName", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Ufba.visualForm.FormHasFields.Description", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Ufba.visualForm.visualFormDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship(IsEmbedding=true)]
	[DslModeling::DomainObjectId("b5b0cef9-5f2d-4c27-b715-cbd5df5c58b7")]
	public partial class FormHasFields : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// FormHasFields domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xb5b0cef9, 0x5f2d, 0x4c27, 0xb7, 0x15, 0xcb, 0xd5, 0xdf, 0x5c, 0x58, 0xb7);
	
				
		/// <summary>
		/// Constructor
		/// Creates a FormHasFields link in the same Partition as the given Form
		/// </summary>
		/// <param name="source">Form to use as the source of the relationship.</param>
		/// <param name="target">Field to use as the target of the relationship.</param>
		public FormHasFields(Form source, Field target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(FormHasFields.FormDomainRoleId, source), new DslModeling::RoleAssignment(FormHasFields.FieldDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public FormHasFields(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public FormHasFields(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public FormHasFields(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public FormHasFields(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region Form domain role code
		
		/// <summary>
		/// Form domain role Id.
		/// </summary>
		public static readonly global::System.Guid FormDomainRoleId = new global::System.Guid(0x56d7699c, 0xf9b1, 0x44f0, 0x99, 0x81, 0xba, 0x72, 0x1e, 0xbc, 0xfe, 0x3d);
		
		/// <summary>
		/// DomainRole Form
		/// Description for Ufba.visualForm.FormHasFields.Form
		/// </summary>
		[DslDesign::DisplayNameResource("Ufba.visualForm.FormHasFields/Form.DisplayName", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Ufba.visualForm.FormHasFields/Form.Description", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "Fields", PropertyDisplayNameKey="Ufba.visualForm.FormHasFields/Form.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.PropagatesCopyToLinkAndOppositeRolePlayer, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("56d7699c-f9b1-44f0-9981-ba721ebcfe3d")]
		public virtual Form Form
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (Form)DslModeling::DomainRoleInfo.GetRolePlayer(this, FormDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, FormDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Form of a Field
		/// <summary>
		/// Gets Form.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static Form GetForm(Field element)
		{
			return DslModeling::DomainRoleInfo.GetLinkedElement(element, FieldDomainRoleId) as Form;
		}
		
		/// <summary>
		/// Sets Form.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static void SetForm(Field element, Form newForm)
		{
			DslModeling::DomainRoleInfo.SetLinkedElement(element, FieldDomainRoleId, newForm);
		}
		#endregion
		#region Field domain role code
		
		/// <summary>
		/// Field domain role Id.
		/// </summary>
		public static readonly global::System.Guid FieldDomainRoleId = new global::System.Guid(0x7583647e, 0xbdd5, 0x4e01, 0xbe, 0x55, 0xc7, 0x23, 0xd0, 0x61, 0xcc, 0x4b);
		
		/// <summary>
		/// DomainRole Field
		/// Description for Ufba.visualForm.FormHasFields.Field
		/// </summary>
		[DslDesign::DisplayNameResource("Ufba.visualForm.FormHasFields/Field.DisplayName", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Ufba.visualForm.FormHasFields/Field.Description", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "Form", PropertyDisplayNameKey="Ufba.visualForm.FormHasFields/Field.PropertyDisplayName", PropagatesDelete = true,  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.One)]
		[DslModeling::DomainObjectId("7583647e-bdd5-4e01-be55-c723d061cc4b")]
		public virtual Field Field
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (Field)DslModeling::DomainRoleInfo.GetRolePlayer(this, FieldDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, FieldDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Fields of a Form
		/// <summary>
		/// Gets a list of Fields.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<Field> GetFields(Form element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<Field>, Field>(element, FormDomainRoleId);
		}
		#endregion
		#region Form link accessor
		/// <summary>
		/// Get the list of FormHasFields links to a Form.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Ufba.visualForm.FormHasFields> GetLinksToFields ( global::Ufba.visualForm.Form formInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Ufba.visualForm.FormHasFields>(formInstance, global::Ufba.visualForm.FormHasFields.FormDomainRoleId);
		}
		#endregion
		#region Field link accessor
		/// <summary>
		/// Get the FormHasFields link to a Field.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Ufba.visualForm.FormHasFields GetLinkToForm (global::Ufba.visualForm.Field fieldInstance)
		{
			global::System.Collections.Generic.IList<global::Ufba.visualForm.FormHasFields> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Ufba.visualForm.FormHasFields>(fieldInstance, global::Ufba.visualForm.FormHasFields.FieldDomainRoleId);
			global::System.Diagnostics.Debug.Assert(links.Count <= 1, "Multiplicity of Field not obeyed.");
			if ( links.Count == 0 )
			{
				return null;
			}
			else
			{
				return links[0];
			}
		}
		#endregion
		#region FormHasFields instance accessors
		
		/// <summary>
		/// Get any FormHasFields links between a given Form and a Field.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Ufba.visualForm.FormHasFields> GetLinks( global::Ufba.visualForm.Form source, global::Ufba.visualForm.Field target )
		{
			global::System.Collections.Generic.List<global::Ufba.visualForm.FormHasFields> outLinks = new global::System.Collections.Generic.List<global::Ufba.visualForm.FormHasFields>();
			global::System.Collections.Generic.IList<global::Ufba.visualForm.FormHasFields> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Ufba.visualForm.FormHasFields>(source, global::Ufba.visualForm.FormHasFields.FormDomainRoleId);
			foreach ( global::Ufba.visualForm.FormHasFields link in links )
			{
				if ( target.Equals(link.Field) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one FormHasFields link between a given Formand a Field.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Ufba.visualForm.FormHasFields GetLink( global::Ufba.visualForm.Form source, global::Ufba.visualForm.Field target )
		{
			global::System.Collections.Generic.IList<global::Ufba.visualForm.FormHasFields> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Ufba.visualForm.FormHasFields>(source, global::Ufba.visualForm.FormHasFields.FormDomainRoleId);
			foreach ( global::Ufba.visualForm.FormHasFields link in links )
			{
				if ( target.Equals(link.Field) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}
namespace Ufba.visualForm
{
	/// <summary>
	/// DomainRelationship FieldHasOptions
	/// Description for Ufba.visualForm.FieldHasOptions
	/// </summary>
	[DslDesign::DisplayNameResource("Ufba.visualForm.FieldHasOptions.DisplayName", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("Ufba.visualForm.FieldHasOptions.Description", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::Ufba.visualForm.visualFormDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainRelationship(IsEmbedding=true)]
	[DslModeling::DomainObjectId("a918d1b4-a0e5-4900-b371-a211456714f7")]
	public partial class FieldHasOptions : DslModeling::ElementLink
	{
		#region Constructors, domain class Id
		
		/// <summary>
		/// FieldHasOptions domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xa918d1b4, 0xa0e5, 0x4900, 0xb3, 0x71, 0xa2, 0x11, 0x45, 0x67, 0x14, 0xf7);
	
				
		/// <summary>
		/// Constructor
		/// Creates a FieldHasOptions link in the same Partition as the given Field
		/// </summary>
		/// <param name="source">Field to use as the source of the relationship.</param>
		/// <param name="target">Option to use as the target of the relationship.</param>
		public FieldHasOptions(Field source, Option target)
			: base((source != null ? source.Partition : null), new DslModeling::RoleAssignment[]{new DslModeling::RoleAssignment(FieldHasOptions.FieldDomainRoleId, source), new DslModeling::RoleAssignment(FieldHasOptions.OptionDomainRoleId, target)}, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public FieldHasOptions(DslModeling::Store store, params DslModeling::RoleAssignment[] roleAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public FieldHasOptions(DslModeling::Store store, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, roleAssignments, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		public FieldHasOptions(DslModeling::Partition partition, params DslModeling::RoleAssignment[] roleAssignments)
			: base(partition, roleAssignments, null)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new link is to be created.</param>
		/// <param name="roleAssignments">List of relationship role assignments.</param>
		/// <param name="propertyAssignments">List of properties assignments to set on the new link.</param>
		public FieldHasOptions(DslModeling::Partition partition, DslModeling::RoleAssignment[] roleAssignments, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, roleAssignments, propertyAssignments)
		{
		}
		#endregion
		#region Field domain role code
		
		/// <summary>
		/// Field domain role Id.
		/// </summary>
		public static readonly global::System.Guid FieldDomainRoleId = new global::System.Guid(0xabbd89c5, 0x183c, 0x41ba, 0xa1, 0xfc, 0x2b, 0xb4, 0xb6, 0xb4, 0xe3, 0x63);
		
		/// <summary>
		/// DomainRole Field
		/// Description for Ufba.visualForm.FieldHasOptions.Field
		/// </summary>
		[DslDesign::DisplayNameResource("Ufba.visualForm.FieldHasOptions/Field.DisplayName", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Ufba.visualForm.FieldHasOptions/Field.Description", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Source, PropertyName = "Options", PropertyDisplayNameKey="Ufba.visualForm.FieldHasOptions/Field.PropertyDisplayName",  PropagatesCopy = DslModeling::PropagatesCopyOption.PropagatesCopyToLinkAndOppositeRolePlayer, Multiplicity = DslModeling::Multiplicity.ZeroMany)]
		[DslModeling::DomainObjectId("abbd89c5-183c-41ba-a1fc-2bb4b6b4e363")]
		public virtual Field Field
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (Field)DslModeling::DomainRoleInfo.GetRolePlayer(this, FieldDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, FieldDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Field of a Option
		/// <summary>
		/// Gets Field.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static Field GetField(Option element)
		{
			return DslModeling::DomainRoleInfo.GetLinkedElement(element, OptionDomainRoleId) as Field;
		}
		
		/// <summary>
		/// Sets Field.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static void SetField(Option element, Field newField)
		{
			DslModeling::DomainRoleInfo.SetLinkedElement(element, OptionDomainRoleId, newField);
		}
		#endregion
		#region Option domain role code
		
		/// <summary>
		/// Option domain role Id.
		/// </summary>
		public static readonly global::System.Guid OptionDomainRoleId = new global::System.Guid(0x8306791b, 0x7955, 0x4538, 0x86, 0x02, 0xb9, 0x7e, 0xbc, 0x78, 0x40, 0xf5);
		
		/// <summary>
		/// DomainRole Option
		/// Description for Ufba.visualForm.FieldHasOptions.Option
		/// </summary>
		[DslDesign::DisplayNameResource("Ufba.visualForm.FieldHasOptions/Option.DisplayName", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("Ufba.visualForm.FieldHasOptions/Option.Description", typeof(global::Ufba.visualForm.visualFormDomainModel), "Ufba.visualForm.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainRole(DslModeling::DomainRoleOrder.Target, PropertyName = "Field", PropertyDisplayNameKey="Ufba.visualForm.FieldHasOptions/Option.PropertyDisplayName", PropagatesDelete = true,  PropagatesCopy = DslModeling::PropagatesCopyOption.DoNotPropagateCopy, Multiplicity = DslModeling::Multiplicity.One)]
		[DslModeling::DomainObjectId("8306791b-7955-4538-8602-b97ebc7840f5")]
		public virtual Option Option
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return (Option)DslModeling::DomainRoleInfo.GetRolePlayer(this, OptionDomainRoleId);
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetRolePlayer(this, OptionDomainRoleId, value);
			}
		}
				
		#endregion
		#region Static methods to access Options of a Field
		/// <summary>
		/// Gets a list of Options.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static DslModeling::LinkedElementCollection<Option> GetOptions(Field element)
		{
			return GetRoleCollection<DslModeling::LinkedElementCollection<Option>, Option>(element, FieldDomainRoleId);
		}
		#endregion
		#region Field link accessor
		/// <summary>
		/// Get the list of FieldHasOptions links to a Field.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Ufba.visualForm.FieldHasOptions> GetLinksToOptions ( global::Ufba.visualForm.Field fieldInstance )
		{
			return DslModeling::DomainRoleInfo.GetElementLinks<global::Ufba.visualForm.FieldHasOptions>(fieldInstance, global::Ufba.visualForm.FieldHasOptions.FieldDomainRoleId);
		}
		#endregion
		#region Option link accessor
		/// <summary>
		/// Get the FieldHasOptions link to a Option.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Ufba.visualForm.FieldHasOptions GetLinkToField (global::Ufba.visualForm.Option optionInstance)
		{
			global::System.Collections.Generic.IList<global::Ufba.visualForm.FieldHasOptions> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Ufba.visualForm.FieldHasOptions>(optionInstance, global::Ufba.visualForm.FieldHasOptions.OptionDomainRoleId);
			global::System.Diagnostics.Debug.Assert(links.Count <= 1, "Multiplicity of Option not obeyed.");
			if ( links.Count == 0 )
			{
				return null;
			}
			else
			{
				return links[0];
			}
		}
		#endregion
		#region FieldHasOptions instance accessors
		
		/// <summary>
		/// Get any FieldHasOptions links between a given Field and a Option.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<global::Ufba.visualForm.FieldHasOptions> GetLinks( global::Ufba.visualForm.Field source, global::Ufba.visualForm.Option target )
		{
			global::System.Collections.Generic.List<global::Ufba.visualForm.FieldHasOptions> outLinks = new global::System.Collections.Generic.List<global::Ufba.visualForm.FieldHasOptions>();
			global::System.Collections.Generic.IList<global::Ufba.visualForm.FieldHasOptions> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Ufba.visualForm.FieldHasOptions>(source, global::Ufba.visualForm.FieldHasOptions.FieldDomainRoleId);
			foreach ( global::Ufba.visualForm.FieldHasOptions link in links )
			{
				if ( target.Equals(link.Option) )
				{
					outLinks.Add(link);
				}
			}
			return outLinks.AsReadOnly();
		}
		/// <summary>
		/// Get the one FieldHasOptions link between a given Fieldand a Option.
		/// </summary>
		[global::System.Diagnostics.DebuggerStepThrough]
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1011")]
		public static global::Ufba.visualForm.FieldHasOptions GetLink( global::Ufba.visualForm.Field source, global::Ufba.visualForm.Option target )
		{
			global::System.Collections.Generic.IList<global::Ufba.visualForm.FieldHasOptions> links = DslModeling::DomainRoleInfo.GetElementLinks<global::Ufba.visualForm.FieldHasOptions>(source, global::Ufba.visualForm.FieldHasOptions.FieldDomainRoleId);
			foreach ( global::Ufba.visualForm.FieldHasOptions link in links )
			{
				if ( target.Equals(link.Option) )
				{
					return link;
				}
			}
			return null;
		}
		
		#endregion
	}
}