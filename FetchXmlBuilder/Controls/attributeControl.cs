﻿using Microsoft.Xrm.Sdk.Metadata;
using Rappen.XRM.Helpers.FetchXML;
using Rappen.XTB.FetchXmlBuilder.Builder;
using Rappen.XTB.FetchXmlBuilder.DockControls;
using Rappen.XTB.FetchXmlBuilder.Views;
using Rappen.XTB.Helpers;
using Rappen.XTB.Helpers.ControlItems;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Rappen.XTB.FetchXmlBuilder.Controls
{
    public partial class attributeControl : FetchXmlElementControlBase
    {
        private readonly AttributeMetadata[] attributes;
        private readonly AttributeMetadata[] allattributes;
        private bool aggregate;
        private Cell cell;

        public attributeControl() : this(null, null, null, null)
        {
        }

        public attributeControl(TreeNode node, AttributeMetadata[] attributes, FetchXmlBuilder fetchXmlBuilder, TreeBuilderControl tree)
        {
            InitializeComponent();
            this.attributes = attributes;
            allattributes = fetchXmlBuilder.GetAllAttribues(node.LocalEntityName()).ToArray();
            InitializeFXB(null, fetchXmlBuilder, tree, node);
        }

        protected override void PopulateControls()
        {
            cmbAttribute.Items.Clear();
            aggregate = fxb.settings.AlwaysShowAggregationProperties || Node.IsFetchAggregate();
            chkLayoutFixedWidths.Checked = fxb.settings.Layout.UseFixedWidths;
            panAggregate.Visible = aggregate;
            grpLayout.Visible = !aggregate;
            cmbAggregate.Enabled = aggregate;
            chkGroupBy.Enabled = aggregate;
            if (!aggregate)
            {
                cmbAggregate.SelectedIndex = -1;
                chkGroupBy.Checked = false;
            }
            cmbAttribute.Items.AddRange(attributes?.Select(a => new AttributeMetadataItem(a, fxb.settings.UseFriendlyNames, fxb.settings.ShowAttributeTypes)).ToArray());
            UpdateUIFromCell();
        }

        protected override ControlValidationResult ValidateControl(Control control)
        {
            if (control == cmbAttribute)
            {
                if (string.IsNullOrWhiteSpace(cmbAttribute.Text))
                {
                    return new ControlValidationResult(ControlValidationLevel.Error, "Attribute", ControlValidationMessage.IsRequired);
                }
                if (fxb.entities != null)
                {
                    var attributename = (cmbAttribute.SelectedItem is AttributeMetadataItem item && item.Metadata != null) ? item.Metadata.LogicalName : cmbAttribute.Text;
                    if (!allattributes.Any(a => a.LogicalName == attributename))
                    {
                        return new ControlValidationResult(ControlValidationLevel.Warning, "Attribute", ControlValidationMessage.NotInMetadata);
                    }
                    if (!cmbAttribute.Items.OfType<AttributeMetadataItem>().Any(a => a.ToString() == cmbAttribute.Text))
                    {
                        return new ControlValidationResult(ControlValidationLevel.Info, "Attribute", ControlValidationMessage.NotShowingNow);
                    }
                }
            }
            else if (control == txtAlias)
            {
                if (Node.IsFetchAggregate() && string.IsNullOrWhiteSpace(txtAlias.Text))
                {
                    return new ControlValidationResult(ControlValidationLevel.Error, "Alias must be specified in aggregate queries");
                }
                if (Validations.ValidateAlias(txtAlias.Text) is ControlValidationResult aliasresult)
                {
                    return aliasresult;
                }
            }

            return base.ValidateControl(control);
        }

        protected override void SaveInternal(bool keyPress)
        {
            base.SaveInternal(keyPress);
            if (IsInitialized)
            {
                UpdateCellFromUI();
            }
        }

        private void chkGroupBy_CheckedChanged(object sender, EventArgs e)
        {
            EnableAggregateControls();
        }

        private void cmbAggregate_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableAggregateControls();
        }

        private void EnableAggregateControls()
        {
            cmbDateGrouping.Enabled = chkGroupBy.Checked;
            chkDistinct.Enabled = aggregate && !chkGroupBy.Checked;
            if (!chkDistinct.Enabled)
            {
                chkDistinct.Checked = false;
            }
            chkUserTZ.Enabled = chkGroupBy.Checked;
            if (!chkGroupBy.Checked)
            {
                cmbDateGrouping.SelectedIndex = -1;
                chkUserTZ.Checked = false;
            }
        }

        private void helpIcon_Click(object sender, EventArgs e)
        {
            fxb.OpenUrl(sender);
        }

        private void cmbAttribute_SelectedIndexChanged(object sender, EventArgs e)
        {
            fxb.ShowMetadata(Metadata());
        }

        internal void UpdateUIFromCell()
        {
            cell = fxb.dockControlBuilder.LayoutXML?.GetCell(Node);
            if (cell != null)
            {
                chkLayoutVisible.Checked = cell.Width > 0;
                trkLayoutWidth.Enabled = chkLayoutVisible.Checked;
                try
                {
                    trkLayoutWidth.Value = cell.Width;
                }
                catch
                {
                    trkLayoutWidth.Value = trkLayoutWidth.Maximum;
                }
            }
            else
            {
                chkLayoutVisible.Checked = true;
            }
            grpLayout.Visible = cell != null;
            UpdateCellUI();
        }

        private void UpdateCellFromUI()
        {
            cell = fxb.dockControlBuilder.LayoutXML?.GetCell(Node);
            if (cell != null)
            {
                cell.Name = Node.GetAttributeLayoutName();
                cell.Width = chkLayoutVisible.Checked ? trkLayoutWidth.Value : 0;
                cell.IsHidden = !chkLayoutVisible.Checked;
                fxb.dockControlLayoutXml?.UpdateXML(cell.Parent?.ToXMLString());
            }
            grpLayout.Visible = cell != null;
            trkLayoutWidth.Enabled = chkLayoutVisible.Checked;
            UpdateCellUI();
            fxb.dockControlGrid?.SetLayoutToGrid();
        }

        private void UpdateCellUI()
        {
            if (cell?.Width > 0)
            {
                var goalwidth = Math.Min(StickWidth(cell.Width), trkLayoutWidth.Maximum);
                var currentwidth = cell.Width;
                lblWidth.Text = $"Width: {currentwidth}{(goalwidth != currentwidth ? $" ({goalwidth})" : "")}";
                lblIndex.Text = $"Display Index: {cell?.DisplayIndex}";
            }
            else
            {
                lblWidth.Text = "Width";
                lblIndex.Text = "Display Index";
            }
        }

        public override MetadataBase Metadata()
        {
            if (cmbAttribute.SelectedItem is AttributeMetadataItem item)
            {
                return item.Metadata;
            }
            return base.Metadata();
        }

        public override void Focus()
        {
            cmbAttribute.Focus();
        }

        private void trkLayoutWidth_Scroll(object sender, EventArgs e)
        {
            if (IsInitialized)
            {
                UpdateCellFromUI();
            }
        }

        private void chkLayoutVisible_CheckedChanged(object sender, EventArgs e)
        {
            if (IsInitialized)
            {
                if (!chkLayoutVisible.Checked)
                {
                    trkLayoutWidth.Value = 0;
                }
                else if (trkLayoutWidth.Value == 0)
                {
                    trkLayoutWidth.Value = 100;
                }
                UpdateCellFromUI();
            }
        }

        private void trkLayoutWidth_MouseUp(object sender = null, MouseEventArgs e = null)
        {
            if (!fxb.settings.Layout.Enabled || !fxb.settings.Layout.UseFixedWidths)
            {
                return;
            }
            int width = StickWidth(trkLayoutWidth.Value);
            trkLayoutWidth.Value = width;
            if (IsInitialized)
            {
                UpdateCellFromUI();
            }
        }

        private int StickWidth(int width)
        {
            if (!fxb.settings.Layout.Enabled || !fxb.settings.Layout.UseFixedWidths)
            {
                return width;
            }
            if (width > 5 && width < 33) width = 25;
            if (width >= 33 && width < 63) width = 50;
            if (width >= 63 && width < 88) width = 75;
            if (width >= 88 && width < 113) width = 100;
            if (width >= 113 && width < 133) width = 125;
            if (width >= 133 && width < 175) width = 150;
            if (width >= 175 && width < 250) width = 200;
            if (width >= 250) width = 300;
            return width;
        }

        private void chkLayoutFixedWidths_CheckedChanged(object sender, EventArgs e)
        {
            fxb.settings.Layout.UseFixedWidths = chkLayoutFixedWidths.Checked;
            trkLayoutWidth_MouseUp();
        }
    }
}