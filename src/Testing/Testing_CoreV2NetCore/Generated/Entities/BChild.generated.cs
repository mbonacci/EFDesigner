//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Testing_CoreV2NetCore
{
   public partial class BChild
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected BChild()
      {
         BParentCollection = new System.Collections.Generic.HashSet<BParentCollection>();
         BParentCollection_2 = new System.Collections.Generic.HashSet<BParentCollection>();

         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="_bparentrequired"></param>
      /// <param name="_bparentrequired_1"></param>
      /// <param name="_bparentrequired_2"></param>
      public BChild(BParentRequired _bparentrequired, BParentRequired _bparentrequired_1, BParentRequired _bparentrequired_2)
      {
         if (_bparentrequired == null) throw new ArgumentNullException(nameof(_bparentrequired));
         BParentRequired = _bparentrequired;

         if (_bparentrequired_1 == null) throw new ArgumentNullException(nameof(_bparentrequired_1));
         BParentRequired_1 = _bparentrequired_1;

         if (_bparentrequired_2 == null) throw new ArgumentNullException(nameof(_bparentrequired_2));
         BParentRequired_2 = _bparentrequired_2;

         BParentCollection = new HashSet<BParentCollection>();
         BParentCollection_2 = new HashSet<BParentCollection>();
         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="_bparentrequired"></param>
      /// <param name="_bparentrequired_1"></param>
      /// <param name="_bparentrequired_2"></param>
      public static BChild Create(BParentRequired _bparentrequired, BParentRequired _bparentrequired_1, BParentRequired _bparentrequired_2)
      {
         return new BChild(_bparentrequired, _bparentrequired_1, _bparentrequired_2);
      }

      // Persistent properties

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public int Id { get; set; }

      // Persistent navigation properties

      /// <summary>
      ///  // Required
      /// </summary>
      public virtual BParentRequired BParentRequired { get; set; }  // Required
      /// <summary>
      ///  // Required
      /// </summary>
      public virtual BParentRequired BParentRequired_1 { get; set; }  // Required
      /// <summary>
      ///  // Required
      /// </summary>
      public virtual BParentRequired BParentRequired_2 { get; set; }  // Required
      public virtual ICollection<BParentCollection> BParentCollection { get; set; } 
      public virtual ICollection<BParentCollection> BParentCollection_2 { get; set; } 
      public virtual BParentOptional BParentOptional { get; set; } 
      public virtual BParentOptional BParentOptional_1 { get; set; } 
      public virtual BParentOptional BParentOptional_2 { get; set; } 
   }
}

