﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;
using Microsoft.VisualStudio.Data.Framework;
using Microsoft.VisualStudio.Data.Services.SupportEntities.Interop;
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Diagrams;
using Microsoft.VisualStudio.Modeling.Diagrams.GraphObject;

namespace Sawczyn.EFDesigner.EFModel
{
   public partial class EFModelDiagram
   {
      public override void OnInitialize()
      {
         base.OnInitialize();

         // because we can hide elements, line routing looks odd when it thinks it's jumping over lines
         // that really aren't visible. Since replacing the routing algorithm is too hard (impossible?)
         // let's just stop it from showing jumps at all. A change to the highlighting on mouseover
         // makes it easier to see which lines are which in complex diagrams, so this doesn't hurt anything.
         RouteJumpType = VGPageLineJumpCode.NoJumps;
      }

      public static bool IsDropping { get; private set; }
      public static DSRefAdapter DSRef { get; private set; }

        public override void OnDragOver(DiagramDragEventArgs diagramDragEventArgs)
      {
         base.OnDragOver(diagramDragEventArgs);

         if (diagramDragEventArgs.Effect == DragDropEffects.None && IsAcceptableDropItem(diagramDragEventArgs))
            diagramDragEventArgs.Effect = DragDropEffects.Copy;
      }

      private bool IsAcceptableDropItem(DiagramDragEventArgs diagramDragEventArgs)
      {
            DSRef = null;
            if (diagramDragEventArgs.Data is DSRefClipboardObject dsRefCO) {
                object dsRef = dsRefCO.GetDSRef(ActiveDiagramView.Site);
                if (dsRef != null && dsRef is IDSRefConsumer c) {
                    DSRefAdapter ds = new DSRefAdapter(c);
                    if (ds.Type == DSRefType.Table || ds.Type == DSRefType.View || ds.Type == DSRefType.Procedure) {
                        DSRef = ds;
                        return true;
                    }
                }
            }
            IsDropping = (diagramDragEventArgs.Data.GetData("Text") is string filename && File.Exists(filename)) || 
                      (diagramDragEventArgs.Data.GetData("FileDrop") is string[] filenames && filenames.All(File.Exists));

         return IsDropping;
      }

      public override void OnDragDrop(DiagramDragEventArgs diagramDragEventArgs)
      {
         base.OnDragDrop(diagramDragEventArgs);

        if (DSRef != null) {
            ModelGen.ModelGenerator.GenerateItem(Store, DSRef);
            DSRef = null;
            IsDropping = false;
        }

         if (IsDropping)
         {
            string[] missingFiles = null;

            if (diagramDragEventArgs.Data.GetData("Text") is string filename)
            {
               if (!File.Exists(filename)) 
                  missingFiles = new[] {filename};
               else                
                  FileDropHelper.HandleDrop(Store, filename);
            }
            else if (diagramDragEventArgs.Data.GetData("FileDrop") is string[] filenames)
            {
               string[] existingFiles = filenames.Where(File.Exists).ToArray();
               FileDropHelper.HandleMultiDrop(Store, existingFiles);
               missingFiles = filenames.Except(existingFiles).ToArray();
            }
            else
               base.OnDragDrop(diagramDragEventArgs);

            if (missingFiles != null && missingFiles.Any())
            {
               if (missingFiles.Length > 1)
                  missingFiles[missingFiles.Length - 1] = "and " + missingFiles[missingFiles.Length - 1];
               ErrorDisplay.Show($"Can't find files {string.Join(", ", missingFiles)}");
            }
         }

         IsDropping = false;
      }

      /// <summary>Called by the control's OnMouseUp().</summary>
      /// <param name="e">A DiagramMouseEventArgs that contains event data.</param>
      public override void OnMouseUp(DiagramMouseEventArgs e)
      {
         IsDropping = false;
         base.OnMouseUp(e);
      }
   }
}
