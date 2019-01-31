namespace Sawczyn.EFDesigner.EFModel
{

   /// <summary>
   ///          Property in a class as the result of an association to another class.
   /// </summary>
   public class NavigationProperty
   {

      /// <summary>
      /// The type of the property.
      /// </summary>
      public ModelClass ClassType { get; set; }
      

      /// <summary>
      /// Gets or sets the association object from the model that describes
      /// this navigation property.
      /// </summary>
      public Association AssociationObject { get; set; }


      /// <summary>
      /// The name of the property in the generated code.
      /// </summary>
      public string PropertyName { get; set; }


      /// <summary>
      ///          The multiplicity of this property.
      /// </summary>
      public Multiplicity Cardinality { get; set; }


      /// <summary>Gets a value indicating whether this NavigationProperty is a collection.</summary>
      /// <value>True if this NavigationProperty is a collection, false if not.</value>
      public bool IsCollection
      {
         get
         {
            return Cardinality == Multiplicity.ZeroMany;
         }
      }


      /// <summary>Gets a value indicating whether this NavigationProperty is required.</summary>
      /// <value>True if required, false if not.</value>
      public bool Required
      {
         get
         {
            return Cardinality == Multiplicity.One;
         }
      }

      /// <summary>
      /// Should this property only be used as a constructor parameter?
      /// </summary>
      public bool ConstructorParameterOnly { get; set; }


      /// <summary>
      /// Gets or sets the XML doc summary.
      /// </summary>
      public string Summary { get; set; }


      /// <summary>
      /// Gets or sets the XML doc remarks.
      /// </summary>
      public string Description { get; set; }


      /// <summary>
      /// Any custom attributes that should be applied to this property.
      /// </summary>
      public string CustomAttributes { get; set; }
      

      /// <summary>
      /// Value for {Name} in a Display[Name="{name}"] attribute for this property
      /// </summary>
      public string DisplayText { get; set; }


      /// <summary>
      /// Gets or sets a value indicating whether this NavigationProperty is an automatic property.
      /// </summary>
      /// <value>True if this NavigationProperty is an automatic property, false if not.</value>
      public bool IsAutoProperty { get; set; }
   }
}
