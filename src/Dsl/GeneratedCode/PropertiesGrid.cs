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

#region Custom property definitions for ModelRoot
namespace Sawczyn.EFDesigner.EFModel
{
	
	/// <summary>
	/// Factory class for ModelRoot type descriptors.
	/// Double-derived class to allow easier code customization.
	/// </summary>
	internal sealed partial class ModelRootTypeDescriptionProvider : ModelRootTypeDescriptionProviderBase
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelRootTypeDescriptionProvider()
		{
		}
		
	}
	
	/// <summary>
	/// Base factory class for ModelRoot type descriptors.
	/// </summary>
	abstract internal class ModelRootTypeDescriptionProviderBase : DslDesign::ElementTypeDescriptionProvider
	{
		/// <summary>
		/// Called by the System.ComponentModel framework when it requires a type descriptor instance.
		/// </summary>
		protected override DslDesign::ElementTypeDescriptor CreateTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent, DslModeling::ModelElement element)
		{
			return new ModelRootTypeDescriptor(parent, element);
		}
	}
	
	/// <summary>
	/// Custom type descriptor class for ModelRoot elements.
	/// </summary>
	public partial class ModelRootTypeDescriptor : DslDesign::ElementTypeDescriptor
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelRootTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent, 
											DslModeling::ModelElement selectedElement)
			: base(parent, selectedElement)
		{
		}
	
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelRootTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent,
												global::System.Type modelElementType)
			: base(parent, modelElementType)
		{
		}
	
		public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties(global::System.Attribute[] attributes)
		{
			// The following method needs to be added in a partial class
			//   private override global::System.ComponentModel.PropertyDescriptorCollection GetCustomProperties(global::System.Attribute[] attributes)
			// The skeleton of a suggested method is provided in the comment below.
			return this.GetCustomProperties(attributes);
	
		}
	
		// EXAMPLE "GetCustomProperties" METHOD
		///// <summary>
		///// Returns a collection of property descriptors an instance of ModelRoot.
		///// </summary>
		//private global::System.ComponentModel.PropertyDescriptorCollection GetCustomProperties(global::System.Attribute[] attributes)
		//{
		//    // Get the default property descriptors from the base class
		//    global::System.ComponentModel.PropertyDescriptorCollection propertyDescriptors = base.GetProperties(attributes);
	
		//    // Get a reference to the model element that is being described.
		//    ModelRoot source = this.ModelElement as ModelRoot;
		//    if (source != null)
		//    {
		//        //Add in extra custom properties here...
		//    }
	
		//    // Return the property descriptors for this element
		//    return propertyDescriptors;
		//}
	
	}
	
	
}
#endregion
#region Custom property definitions for ModelClass
namespace Sawczyn.EFDesigner.EFModel
{
	
	/// <summary>
	/// Factory class for ModelClass type descriptors.
	/// Double-derived class to allow easier code customization.
	/// </summary>
	internal sealed partial class ModelClassTypeDescriptionProvider : ModelClassTypeDescriptionProviderBase
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelClassTypeDescriptionProvider()
		{
		}
		
	}
	
	/// <summary>
	/// Base factory class for ModelClass type descriptors.
	/// </summary>
	abstract internal class ModelClassTypeDescriptionProviderBase : DslDesign::ElementTypeDescriptionProvider
	{
		/// <summary>
		/// Called by the System.ComponentModel framework when it requires a type descriptor instance.
		/// </summary>
		protected override DslDesign::ElementTypeDescriptor CreateTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent, DslModeling::ModelElement element)
		{
			return new ModelClassTypeDescriptor(parent, element);
		}
	}
	
	/// <summary>
	/// Custom type descriptor class for ModelClass elements.
	/// </summary>
	public partial class ModelClassTypeDescriptor : DslDesign::ElementTypeDescriptor
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelClassTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent, 
											DslModeling::ModelElement selectedElement)
			: base(parent, selectedElement)
		{
		}
	
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelClassTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent,
												global::System.Type modelElementType)
			: base(parent, modelElementType)
		{
		}
	
		public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties(global::System.Attribute[] attributes)
		{
			// The following method needs to be added in a partial class
			//   private override global::System.ComponentModel.PropertyDescriptorCollection GetCustomProperties(global::System.Attribute[] attributes)
			// The skeleton of a suggested method is provided in the comment below.
			return this.GetCustomProperties(attributes);
	
		}
	
		// EXAMPLE "GetCustomProperties" METHOD
		///// <summary>
		///// Returns a collection of property descriptors an instance of ModelClass.
		///// </summary>
		//private global::System.ComponentModel.PropertyDescriptorCollection GetCustomProperties(global::System.Attribute[] attributes)
		//{
		//    // Get the default property descriptors from the base class
		//    global::System.ComponentModel.PropertyDescriptorCollection propertyDescriptors = base.GetProperties(attributes);
	
		//    // Get a reference to the model element that is being described.
		//    ModelClass source = this.ModelElement as ModelClass;
		//    if (source != null)
		//    {
		//        //Add in extra custom properties here...
		//    }
	
		//    // Return the property descriptors for this element
		//    return propertyDescriptors;
		//}
	
	}
	
	
}
#endregion
#region Custom property definitions for ModelAttribute
namespace Sawczyn.EFDesigner.EFModel
{
	
	/// <summary>
	/// Factory class for ModelAttribute type descriptors.
	/// Double-derived class to allow easier code customization.
	/// </summary>
	internal sealed partial class ModelAttributeTypeDescriptionProvider : ModelAttributeTypeDescriptionProviderBase
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelAttributeTypeDescriptionProvider()
		{
		}
		
	}
	
	/// <summary>
	/// Base factory class for ModelAttribute type descriptors.
	/// </summary>
	abstract internal class ModelAttributeTypeDescriptionProviderBase : DslDesign::ElementTypeDescriptionProvider
	{
		/// <summary>
		/// Called by the System.ComponentModel framework when it requires a type descriptor instance.
		/// </summary>
		protected override DslDesign::ElementTypeDescriptor CreateTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent, DslModeling::ModelElement element)
		{
			return new ModelAttributeTypeDescriptor(parent, element);
		}
	}
	
	/// <summary>
	/// Custom type descriptor class for ModelAttribute elements.
	/// </summary>
	public partial class ModelAttributeTypeDescriptor : DslDesign::ElementTypeDescriptor
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelAttributeTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent, 
											DslModeling::ModelElement selectedElement)
			: base(parent, selectedElement)
		{
		}
	
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelAttributeTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent,
												global::System.Type modelElementType)
			: base(parent, modelElementType)
		{
		}
	
		public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties(global::System.Attribute[] attributes)
		{
			// The following method needs to be added in a partial class
			//   private override global::System.ComponentModel.PropertyDescriptorCollection GetCustomProperties(global::System.Attribute[] attributes)
			// The skeleton of a suggested method is provided in the comment below.
			return this.GetCustomProperties(attributes);
	
		}
	
		// EXAMPLE "GetCustomProperties" METHOD
		///// <summary>
		///// Returns a collection of property descriptors an instance of ModelAttribute.
		///// </summary>
		//private global::System.ComponentModel.PropertyDescriptorCollection GetCustomProperties(global::System.Attribute[] attributes)
		//{
		//    // Get the default property descriptors from the base class
		//    global::System.ComponentModel.PropertyDescriptorCollection propertyDescriptors = base.GetProperties(attributes);
	
		//    // Get a reference to the model element that is being described.
		//    ModelAttribute source = this.ModelElement as ModelAttribute;
		//    if (source != null)
		//    {
		//        //Add in extra custom properties here...
		//    }
	
		//    // Return the property descriptors for this element
		//    return propertyDescriptors;
		//}
	
	}
	
	
}
#endregion
#region Custom property definitions for ModelEnum
namespace Sawczyn.EFDesigner.EFModel
{
	
	/// <summary>
	/// Factory class for ModelEnum type descriptors.
	/// Double-derived class to allow easier code customization.
	/// </summary>
	internal sealed partial class ModelEnumTypeDescriptionProvider : ModelEnumTypeDescriptionProviderBase
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelEnumTypeDescriptionProvider()
		{
		}
		
	}
	
	/// <summary>
	/// Base factory class for ModelEnum type descriptors.
	/// </summary>
	abstract internal class ModelEnumTypeDescriptionProviderBase : DslDesign::ElementTypeDescriptionProvider
	{
		/// <summary>
		/// Called by the System.ComponentModel framework when it requires a type descriptor instance.
		/// </summary>
		protected override DslDesign::ElementTypeDescriptor CreateTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent, DslModeling::ModelElement element)
		{
			return new ModelEnumTypeDescriptor(parent, element);
		}
	}
	
	/// <summary>
	/// Custom type descriptor class for ModelEnum elements.
	/// </summary>
	public partial class ModelEnumTypeDescriptor : DslDesign::ElementTypeDescriptor
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelEnumTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent, 
											DslModeling::ModelElement selectedElement)
			: base(parent, selectedElement)
		{
		}
	
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelEnumTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent,
												global::System.Type modelElementType)
			: base(parent, modelElementType)
		{
		}
	
		public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties(global::System.Attribute[] attributes)
		{
			// The following method needs to be added in a partial class
			//   private override global::System.ComponentModel.PropertyDescriptorCollection GetCustomProperties(global::System.Attribute[] attributes)
			// The skeleton of a suggested method is provided in the comment below.
			return this.GetCustomProperties(attributes);
	
		}
	
		// EXAMPLE "GetCustomProperties" METHOD
		///// <summary>
		///// Returns a collection of property descriptors an instance of ModelEnum.
		///// </summary>
		//private global::System.ComponentModel.PropertyDescriptorCollection GetCustomProperties(global::System.Attribute[] attributes)
		//{
		//    // Get the default property descriptors from the base class
		//    global::System.ComponentModel.PropertyDescriptorCollection propertyDescriptors = base.GetProperties(attributes);
	
		//    // Get a reference to the model element that is being described.
		//    ModelEnum source = this.ModelElement as ModelEnum;
		//    if (source != null)
		//    {
		//        //Add in extra custom properties here...
		//    }
	
		//    // Return the property descriptors for this element
		//    return propertyDescriptors;
		//}
	
	}
	
	
}
#endregion
#region Custom property definitions for ModelProcedure
namespace Sawczyn.EFDesigner.EFModel
{
	
	/// <summary>
	/// Factory class for ModelProcedure type descriptors.
	/// Double-derived class to allow easier code customization.
	/// </summary>
	internal sealed partial class ModelProcedureTypeDescriptionProvider : ModelProcedureTypeDescriptionProviderBase
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelProcedureTypeDescriptionProvider()
		{
		}
		
	}
	
	/// <summary>
	/// Base factory class for ModelProcedure type descriptors.
	/// </summary>
	abstract internal class ModelProcedureTypeDescriptionProviderBase : DslDesign::ElementTypeDescriptionProvider
	{
		/// <summary>
		/// Called by the System.ComponentModel framework when it requires a type descriptor instance.
		/// </summary>
		protected override DslDesign::ElementTypeDescriptor CreateTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent, DslModeling::ModelElement element)
		{
			return new ModelProcedureTypeDescriptor(parent, element);
		}
	}
	
	/// <summary>
	/// Custom type descriptor class for ModelProcedure elements.
	/// </summary>
	public partial class ModelProcedureTypeDescriptor : DslDesign::ElementTypeDescriptor
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelProcedureTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent, 
											DslModeling::ModelElement selectedElement)
			: base(parent, selectedElement)
		{
		}
	
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelProcedureTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent,
												global::System.Type modelElementType)
			: base(parent, modelElementType)
		{
		}
	
		public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties(global::System.Attribute[] attributes)
		{
			// The following method needs to be added in a partial class
			//   private override global::System.ComponentModel.PropertyDescriptorCollection GetCustomProperties(global::System.Attribute[] attributes)
			// The skeleton of a suggested method is provided in the comment below.
			return this.GetCustomProperties(attributes);
	
		}
	
		// EXAMPLE "GetCustomProperties" METHOD
		///// <summary>
		///// Returns a collection of property descriptors an instance of ModelProcedure.
		///// </summary>
		//private global::System.ComponentModel.PropertyDescriptorCollection GetCustomProperties(global::System.Attribute[] attributes)
		//{
		//    // Get the default property descriptors from the base class
		//    global::System.ComponentModel.PropertyDescriptorCollection propertyDescriptors = base.GetProperties(attributes);
	
		//    // Get a reference to the model element that is being described.
		//    ModelProcedure source = this.ModelElement as ModelProcedure;
		//    if (source != null)
		//    {
		//        //Add in extra custom properties here...
		//    }
	
		//    // Return the property descriptors for this element
		//    return propertyDescriptors;
		//}
	
	}
	
	
}
#endregion
#region Custom property definitions for ModelParameter
namespace Sawczyn.EFDesigner.EFModel
{
	
	/// <summary>
	/// Factory class for ModelParameter type descriptors.
	/// Double-derived class to allow easier code customization.
	/// </summary>
	internal sealed partial class ModelParameterTypeDescriptionProvider : ModelParameterTypeDescriptionProviderBase
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelParameterTypeDescriptionProvider()
		{
		}
		
	}
	
	/// <summary>
	/// Base factory class for ModelParameter type descriptors.
	/// </summary>
	abstract internal class ModelParameterTypeDescriptionProviderBase : DslDesign::ElementTypeDescriptionProvider
	{
		/// <summary>
		/// Called by the System.ComponentModel framework when it requires a type descriptor instance.
		/// </summary>
		protected override DslDesign::ElementTypeDescriptor CreateTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent, DslModeling::ModelElement element)
		{
			return new ModelParameterTypeDescriptor(parent, element);
		}
	}
	
	/// <summary>
	/// Custom type descriptor class for ModelParameter elements.
	/// </summary>
	public partial class ModelParameterTypeDescriptor : DslDesign::ElementTypeDescriptor
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelParameterTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent, 
											DslModeling::ModelElement selectedElement)
			: base(parent, selectedElement)
		{
		}
	
		/// <summary>
		/// Constructor
		/// </summary>
		public ModelParameterTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent,
												global::System.Type modelElementType)
			: base(parent, modelElementType)
		{
		}
	
		public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties(global::System.Attribute[] attributes)
		{
			// The following method needs to be added in a partial class
			//   private override global::System.ComponentModel.PropertyDescriptorCollection GetCustomProperties(global::System.Attribute[] attributes)
			// The skeleton of a suggested method is provided in the comment below.
			return this.GetCustomProperties(attributes);
	
		}
	
		// EXAMPLE "GetCustomProperties" METHOD
		///// <summary>
		///// Returns a collection of property descriptors an instance of ModelParameter.
		///// </summary>
		//private global::System.ComponentModel.PropertyDescriptorCollection GetCustomProperties(global::System.Attribute[] attributes)
		//{
		//    // Get the default property descriptors from the base class
		//    global::System.ComponentModel.PropertyDescriptorCollection propertyDescriptors = base.GetProperties(attributes);
	
		//    // Get a reference to the model element that is being described.
		//    ModelParameter source = this.ModelElement as ModelParameter;
		//    if (source != null)
		//    {
		//        //Add in extra custom properties here...
		//    }
	
		//    // Return the property descriptors for this element
		//    return propertyDescriptors;
		//}
	
	}
	
	
}
#endregion
#region Custom property definitions for Association
namespace Sawczyn.EFDesigner.EFModel
{
	
	/// <summary>
	/// Factory class for Association type descriptors.
	/// Double-derived class to allow easier code customization.
	/// </summary>
	internal sealed partial class AssociationTypeDescriptionProvider : AssociationTypeDescriptionProviderBase
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public AssociationTypeDescriptionProvider()
		{
		}
		
	}
	
	/// <summary>
	/// Base factory class for Association type descriptors.
	/// </summary>
	abstract internal class AssociationTypeDescriptionProviderBase : DslDesign::ElementTypeDescriptionProvider
	{
		/// <summary>
		/// Called by the System.ComponentModel framework when it requires a type descriptor instance.
		/// </summary>
		protected override DslDesign::ElementTypeDescriptor CreateTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent, DslModeling::ModelElement element)
		{
			return new AssociationTypeDescriptor(parent, element);
		}
	}
	
	/// <summary>
	/// Custom type descriptor class for Association elements.
	/// </summary>
	public partial class AssociationTypeDescriptor : DslDesign::ElementTypeDescriptor
	{
		/// <summary>
		/// Constructor
		/// </summary>
		public AssociationTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent, 
											DslModeling::ModelElement selectedElement)
			: base(parent, selectedElement)
		{
		}
	
		/// <summary>
		/// Constructor
		/// </summary>
		public AssociationTypeDescriptor(global::System.ComponentModel.ICustomTypeDescriptor parent,
												global::System.Type modelElementType)
			: base(parent, modelElementType)
		{
		}
	
		public override global::System.ComponentModel.PropertyDescriptorCollection GetProperties(global::System.Attribute[] attributes)
		{
			// The following method needs to be added in a partial class
			//   private override global::System.ComponentModel.PropertyDescriptorCollection GetCustomProperties(global::System.Attribute[] attributes)
			// The skeleton of a suggested method is provided in the comment below.
			return this.GetCustomProperties(attributes);
	
		}
	
		// EXAMPLE "GetCustomProperties" METHOD
		///// <summary>
		///// Returns a collection of property descriptors an instance of Association.
		///// </summary>
		//private global::System.ComponentModel.PropertyDescriptorCollection GetCustomProperties(global::System.Attribute[] attributes)
		//{
		//    // Get the default property descriptors from the base class
		//    global::System.ComponentModel.PropertyDescriptorCollection propertyDescriptors = base.GetProperties(attributes);
	
		//    // Get a reference to the model element that is being described.
		//    Association source = this.ModelElement as Association;
		//    if (source != null)
		//    {
		//        //Add in extra custom properties here...
		//    }
	
		//    // Return the property descriptors for this element
		//    return propertyDescriptors;
		//}
	
	}
	
	
}
#endregion
