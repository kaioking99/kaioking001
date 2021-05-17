using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Opc.Ua;
using Opc.Ua.Server;
using Opc.Ua.Configuration;

namespace Opc.Ua.Server.Controls.Function_Form
{
    public partial class AddressSpaceCtrl : UserControl
    {
        #region Constructor
        public AddressSpaceCtrl()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Fields
        private StandardServer m_server;
        private ApplicationConfiguration m_configuration;
        #endregion

        #region Public Interface
        /// <summary>
        /// Creates a form which displays the status for a UA server.
        /// </summary>
        /// <param name="server">The server displayed in the form.</param>
        /// <param name="configuration">The configuration used to initialize the server.</param>
        public void Initialize(StandardServer server, ApplicationConfiguration configuration)
        {
            m_server = server;
            m_configuration = configuration;
            BrowseTreeView.Nodes.Clear();
            AttributesView.Items.Clear();
            BrowseTreeView.Enabled = true;
            AttributesView.Enabled = true;
            PopulateBranch(ObjectIds.RootFolder, BrowseTreeView.Nodes);
        }

        #endregion

        #region Private Methods
        private ReferenceDescriptionCollection Browse(StandardServer server, BrowseDescriptionCollection nodesToBrowse, bool throwOnError)
        {
            try
            {
                ReferenceDescriptionCollection references = new ReferenceDescriptionCollection();
                BrowseDescriptionCollection unprocessedOperations = new BrowseDescriptionCollection();

                while (nodesToBrowse.Count > 0)
                {
                    // start the browse operation.
                    OperationContext context = new OperationContext(new RequestHeader(), RequestType.Browse);
                    BrowseResultCollection results = null;
                    DiagnosticInfoCollection diagnosticInfos = null;

                    server.CurrentInstance.NodeManager.Browse(
                        context,
                        null,
                        0,
                        nodesToBrowse,
                        out results,
                        out diagnosticInfos);                   
                   

                    ByteStringCollection continuationPoints = new ByteStringCollection();

                    for (int ii = 0; ii < nodesToBrowse.Count; ii++)
                    {
                        // check for error.
                        if (StatusCode.IsBad(results[ii].StatusCode))
                        {
                            // this error indicates that the server does not have enough simultaneously active 
                            // continuation points. This request will need to be resent after the other operations
                            // have been completed and their continuation points released.
                            if (results[ii].StatusCode == StatusCodes.BadNoContinuationPoints)
                            {
                                unprocessedOperations.Add(nodesToBrowse[ii]);
                            }

                            continue;
                        }

                        // check if all references have been fetched.
                        if (results[ii].References.Count == 0)
                        {
                            continue;
                        }

                        // save results.
                        references.AddRange(results[ii].References);

                        // check for continuation point.
                        if (results[ii].ContinuationPoint != null)
                        {
                            continuationPoints.Add(results[ii].ContinuationPoint);
                        }
                    }

                    // process continuation points.
                    ByteStringCollection revisedContiuationPoints = new ByteStringCollection();

                    while (continuationPoints.Count > 0)
                    {
                        // continue browse operation.
                        server.CurrentInstance.NodeManager.BrowseNext(
                            context,
                            false,
                            continuationPoints,
                            out results,
                            out diagnosticInfos);
                        

                        for (int ii = 0; ii < continuationPoints.Count; ii++)
                        {
                            // check for error.
                            if (StatusCode.IsBad(results[ii].StatusCode))
                            {
                                continue;
                            }

                            // check if all references have been fetched.
                            if (results[ii].References.Count == 0)
                            {
                                continue;
                            }

                            // save results.
                            references.AddRange(results[ii].References);

                            // check for continuation point.
                            if (results[ii].ContinuationPoint != null)
                            {
                                revisedContiuationPoints.Add(results[ii].ContinuationPoint);
                            }
                        }

                        // check if browsing must continue;
                        revisedContiuationPoints = continuationPoints;
                    }

                    // check if unprocessed results exist.
                    nodesToBrowse = unprocessedOperations;
                }

                // return complete list.
                return references;
            }
            catch (Exception exception)
            {
                if (throwOnError)
                {
                    throw new ServiceResultException(exception, StatusCodes.BadUnexpectedError);
                }

                return null;
            }
        }
        private void PopulateBranch(NodeId sourceId, TreeNodeCollection nodes)
        {
            try
            {
                nodes.Clear();

                // find all of the components of the node.
                BrowseDescription nodeToBrowse1 = new BrowseDescription();

                nodeToBrowse1.NodeId = sourceId;
                nodeToBrowse1.BrowseDirection = BrowseDirection.Forward;
                nodeToBrowse1.ReferenceTypeId = ReferenceTypeIds.Aggregates;
                nodeToBrowse1.IncludeSubtypes = true;
                nodeToBrowse1.NodeClassMask = (uint)(NodeClass.Object | NodeClass.Variable);
                nodeToBrowse1.ResultMask = (uint)BrowseResultMask.All;

                // find all nodes organized by the node.
                BrowseDescription nodeToBrowse2 = new BrowseDescription();

                nodeToBrowse2.NodeId = sourceId;
                nodeToBrowse2.BrowseDirection = BrowseDirection.Forward;
                nodeToBrowse2.ReferenceTypeId = ReferenceTypeIds.Organizes;
                nodeToBrowse2.IncludeSubtypes = true;
                nodeToBrowse2.NodeClassMask = (uint)(NodeClass.Object | NodeClass.Variable);
                nodeToBrowse2.ResultMask = (uint)BrowseResultMask.All;

                //find all type orgranized by the node.
                BrowseDescription nodetoBrowse3 = new BrowseDescription();

                nodetoBrowse3.NodeId = sourceId;
                nodetoBrowse3.BrowseDirection = BrowseDirection.Forward;
                nodetoBrowse3.ReferenceTypeId = ReferenceTypeIds.References;
                nodetoBrowse3.IncludeSubtypes = true;
                nodetoBrowse3.NodeClassMask = (uint)(NodeClass.ReferenceType | NodeClass.ObjectType | NodeClass.DataType | NodeClass.VariableType);
                nodetoBrowse3.ResultMask = (uint)BrowseResultMask.All;


                BrowseDescriptionCollection nodesToBrowse = new BrowseDescriptionCollection();
                nodesToBrowse.Add(nodeToBrowse1);
                nodesToBrowse.Add(nodeToBrowse2);
                nodesToBrowse.Add(nodetoBrowse3);

                // fetch references from the server.
                ReferenceDescriptionCollection references = Browse(m_server, nodesToBrowse, false);

                // process results.
                for (int ii = 0; ii < references.Count; ii++)
                {
                    ReferenceDescription target = references[ii];

                    // add node.
                    TreeNode child = new TreeNode(Utils.Format("{0}", target));
                    child.Tag = target;
                    child.Nodes.Add(new TreeNode());
                    nodes.Add(child);
                }

                // update the attributes display.
                DisplayAttributes(sourceId);
            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
        }

        /// <summary>
        /// Displays the attributes and properties in the attributes view.
        /// </summary>
        /// <param name="sourceId">The NodeId of the Node to browse.</param>
        private void DisplayAttributes(NodeId sourceId)
        {
            try
            {
                AttributesView.Items.Clear();

                ReadValueIdCollection nodesToRead = new ReadValueIdCollection();

                // attempt to read all possible attributes.
                for (uint ii = Attributes.NodeClass; ii <= Attributes.UserExecutable; ii++)
                {
                    ReadValueId nodeToRead = new ReadValueId();
                    nodeToRead.NodeId = sourceId;
                    nodeToRead.AttributeId = ii;
                    nodesToRead.Add(nodeToRead);
                }

                int startOfProperties = nodesToRead.Count;

                // find all of the pror of the node.
                BrowseDescription nodeToBrowse1 = new BrowseDescription();

                nodeToBrowse1.NodeId = sourceId;
                nodeToBrowse1.BrowseDirection = BrowseDirection.Forward;
                nodeToBrowse1.ReferenceTypeId = ReferenceTypeIds.HasProperty;
                nodeToBrowse1.IncludeSubtypes = true;
                nodeToBrowse1.NodeClassMask = 0;
                nodeToBrowse1.ResultMask = (uint)BrowseResultMask.All;

                BrowseDescriptionCollection nodesToBrowse = new BrowseDescriptionCollection();
                nodesToBrowse.Add(nodeToBrowse1);

                // fetch property references from the server.
                ReferenceDescriptionCollection references = Browse(m_server, nodesToBrowse, false);

                if (references == null)
                {
                    return;
                }

                for (int ii = 0; ii < references.Count; ii++)
                {
                    // ignore external references.
                    if (references[ii].NodeId.IsAbsolute)
                    {
                        continue;
                    }

                    ReadValueId nodeToRead = new ReadValueId();
                    nodeToRead.NodeId = (NodeId)references[ii].NodeId;
                    nodeToRead.AttributeId = Attributes.Value;
                    nodesToRead.Add(nodeToRead);
                }

                // read all values.
                OperationContext context = new OperationContext(new RequestHeader(), RequestType.Browse);
                DataValueCollection results = null;
                DiagnosticInfoCollection diagnosticInfos = null;

                m_server.CurrentInstance.NodeManager.Read(
                    context,
                    0,
                    TimestampsToReturn.Neither,
                    nodesToRead,
                    out results,
                    out diagnosticInfos);

                ListViewItem idnode = new ListViewItem("NodeID");
                idnode.SubItems.Add(sourceId.ToString());
                AttributesView.Items.Add(idnode);
                // process results.
                for (int ii = 0; ii < results.Count; ii++)
                {
                    string name = null;
                    string datatype = null;
                    string value = null;

                    // process attribute value.
                    if (ii < startOfProperties)
                    {
                        
                        // ignore attributes which are invalid for the node.
                        if (results[ii].StatusCode == StatusCodes.BadAttributeIdInvalid)
                        {
                            continue;
                        }                        
                        // get the name of the attribute.
                        name = Attributes.GetBrowseName(nodesToRead[ii].AttributeId);

                        // display any unexpected error.
                        if (StatusCode.IsBad(results[ii].StatusCode))
                        {
                            datatype = Utils.Format("{0}", Attributes.GetDataTypeId(nodesToRead[ii].AttributeId));
                            value = Utils.Format("{0}", results[ii].StatusCode);
                        }

                        // display the value.
                        else
                        {
                            TypeInfo typeInfo = TypeInfo.Construct(results[ii].Value);

                            datatype = typeInfo.BuiltInType.ToString();

                            if (typeInfo.ValueRank >= ValueRanks.OneOrMoreDimensions)
                            {
                                datatype += "[]";
                            }

                            value = Utils.Format("{0}", results[ii].Value);
                        }
                    }

                    // process property value.
                    else
                    {
                        // ignore properties which are invalid for the node.
                        if (results[ii].StatusCode == StatusCodes.BadNodeIdUnknown)
                        {
                            continue;
                        }

                        // get the name of the property.
                        name = Utils.Format("{0}", references[ii - startOfProperties]);

                        // display any unexpected error.
                        if (StatusCode.IsBad(results[ii].StatusCode))
                        {
                            datatype = String.Empty;
                            value = Utils.Format("{0}", results[ii].StatusCode);
                        }

                        // display the value.
                        else
                        {
                            TypeInfo typeInfo = TypeInfo.Construct(results[ii].Value);

                            datatype = typeInfo.BuiltInType.ToString();

                            if (typeInfo.ValueRank >= ValueRanks.OneOrMoreDimensions)
                            {
                                datatype += "[]";
                            }

                            value = Utils.Format("{0}", results[ii].Value);
                        }
                    }

                    // add the attribute name/value to the list view.
                    ListViewItem item = new ListViewItem(name);
                    item.SubItems.Add(value);
                    item.SubItems.Add(datatype);
                    AttributesView.Items.Add(item);
                }

                // adjust width of all columns.
                for (int ii = 0; ii < AttributesView.Columns.Count; ii++)
                {
                    AttributesView.Columns[ii].Width = -2;
                }
            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
        }
        #endregion

        #region Events Handler

        #endregion

        private void BrowseTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                // get the source for the node.
                ReferenceDescription reference = e.Node.Tag as ReferenceDescription;

                if (reference == null || reference.NodeId.IsAbsolute)
                {
                    return;
                }

                // populate children.
                PopulateBranch((NodeId)reference.NodeId, e.Node.Nodes);
            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
        }

        private void BrowseTreeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                // check if node has already been expanded once.
                if (e.Node.Nodes.Count != 1 || e.Node.Nodes[0].Text != String.Empty)
                {
                    return;
                }

                // get the source for the node.
                ReferenceDescription reference = e.Node.Tag as ReferenceDescription;

                if (reference == null || reference.NodeId.IsAbsolute)
                {
                    e.Cancel = true;
                    return;
                }

                // populate children.
                PopulateBranch((NodeId)reference.NodeId, e.Node.Nodes);
            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
        }

        private void BrowseTreeView_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                BrowseTreeView.SelectedNode = BrowseTreeView.GetNodeAt(e.X, e.Y);
            }
            catch (Exception exception)
            {
                ServerUtils.HandleException(this.Text, exception);
            }
        }
    }
}
