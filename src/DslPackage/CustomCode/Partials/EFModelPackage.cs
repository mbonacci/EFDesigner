﻿using System.ComponentModel;
using Sawczyn.EFDesigner.EFModel.DslPackage.CustomCode;

namespace Sawczyn.EFDesigner.EFModel
{
   internal sealed partial class EFModelPackage
   {
      public static EFModelPackage Instance
      {
         get;
         private set;
      }

      protected override void Initialize()
      {
         Instance = this;
         TypeDescriptor.AddProvider(new ModelClassTypeDescriptionProvider(), typeof(ModelClass));
         TypeDescriptor.AddProvider(new ModelEnumTypeDescriptionProvider(), typeof(ModelEnum));
         TypeDescriptor.AddProvider(new AssociationTypeDescriptionProvider(), typeof(Association));
         TypeDescriptor.AddProvider(new ModelAttributeTypeDescriptionProvider(), typeof(ModelAttribute));
         TypeDescriptor.AddProvider(new ModelRootTypeDescriptionProvider(), typeof(ModelRoot));
         TypeDescriptor.AddProvider(new ModelProcedureTypeDescriptionProvider(), typeof(ModelProcedure));
         TypeDescriptor.AddProvider(new ModelParameterTypeDescriptionProvider(), typeof(ModelParameter));

         base.Initialize();
      }
   }
}
