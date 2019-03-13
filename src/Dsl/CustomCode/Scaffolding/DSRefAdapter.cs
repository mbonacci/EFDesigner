using Microsoft.VisualStudio.Data.Services.SupportEntities.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sawczyn.EFDesigner.EFModel
{
    public enum DSRefType { None, Table, View, Procedure, Field }

    [CLSCompliant(false)]
    public class DSRefAdapter
    {
        public DSRefType Type { get; private set; } = DSRefType.None;
        public string ConString { get; private set; }
        public string Name { get; private set; }
        public string Schema { get; private set; }
        public string Provider { get; private set; }

        public List<DSRefNode> Children { get; private set; } = new List<DSRefNode>();

        public DSRefAdapter(IDSRefConsumer dsRefConsumer)
        {
            IntPtr cn = dsRefConsumer.GetFirstChildNode(IntPtr.Zero);
            while (cn != IntPtr.Zero) {
                Children.Add(new DSRefNode(dsRefConsumer, cn));
                cn = dsRefConsumer.GetNextSiblingNode(cn);
            }

            if (Children.Count > 0 && (Children[0].Type & __DSREFTYPE.DSREFTYPE_DATABASE) == __DSREFTYPE.DSREFTYPE_DATABASE) {
                DSRefNode db = Children[0];
                Provider = db.Owner.ToLower();
                ConString = db.Name;

                if (db.Children.Count > 0 && (db.Children[0].Type & __DSREFTYPE.DSREFTYPE_TABLE) == __DSREFTYPE.DSREFTYPE_TABLE) {
                    if (db.Children[0].Children.Count > 0) {
                        if ((db.Children[0].Children[0].Type & __DSREFTYPE.DSREFTYPE_FIELD) == __DSREFTYPE.DSREFTYPE_FIELD) {
                            Type = DSRefType.Field;
                            Name = db.Children[0].Children[0].Name;
                            Schema = db.Children[0].Owner;
                        } else
                            Type = DSRefType.None;
                    } else {
                        Type = DSRefType.Table;
                        Name = db.Children[0].Name;
                        Schema = db.Children[0].Owner;
                    }
                } else
                if (db.Children.Count > 0 && (db.Children[0].Type & __DSREFTYPE.DSREFTYPE_VIEW) == __DSREFTYPE.DSREFTYPE_VIEW) {
                    if (db.Children[0].Children.Count > 0) {
                        if ((db.Children[0].Children[0].Type & __DSREFTYPE.DSREFTYPE_FIELD) == __DSREFTYPE.DSREFTYPE_FIELD) {
                            Type = DSRefType.Field;
                            Name = db.Children[0].Children[0].Name;
                            Schema = db.Children[0].Owner;
                        } else
                            Type = DSRefType.None;
                    } else {
                        Type = DSRefType.View;
                        Name = db.Children[0].Name;
                        Schema = db.Children[0].Owner;
                    }
                } else
                if (db.Children.Count > 0 && (db.Children[0].Type & __DSREFTYPE.DSREFTYPE_STOREDPROCEDURE) == __DSREFTYPE.DSREFTYPE_STOREDPROCEDURE) {
                    Type = DSRefType.Procedure;
                    Name = db.Children[0].Name;
                }
            }
        }
    }

    [CLSCompliant(false)]
    public class DSRefNode
    {
        public IntPtr Node { get; private set; }
        public string Name { get; private set; }
        public string Owner { get; private set; }
        public __DSREFTYPE Type { get; private set; }
        public List<DSRefNode> Children { get; private set; } = new List<DSRefNode>();

        public DSRefNode(IDSRefConsumer dsRefConsumer, IntPtr node)
        {
            ReadNode(dsRefConsumer, node);

            IntPtr cn = dsRefConsumer.GetFirstChildNode(node);
            while (cn != IntPtr.Zero) {
                Children.Add(new DSRefNode(dsRefConsumer, cn));
                cn = dsRefConsumer.GetNextSiblingNode(cn);
            }
        }

        private void ReadNode(IDSRefConsumer dsRefConsumer, IntPtr node)
        {
            Node = node;
            Name = dsRefConsumer.GetName(node);
            Type = dsRefConsumer.GetType(node);
            Owner = dsRefConsumer.GetOwner(node);
        }
    }

}
