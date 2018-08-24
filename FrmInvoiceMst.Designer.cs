namespace Inv
{
    partial class FrmInvoiceMst
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlitemDescription = new DevExpress.XtraEditors.PanelControl();
            this.label27 = new System.Windows.Forms.Label();
            this.txtitemdesc = new DevExpress.XtraEditors.MemoEdit();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.Srno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSNCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxableAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaxName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGSTPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGSTPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGSTPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CmbUnit = new BControls.bComboBox_dx();
            this.txtItemAmount = new BControls.bTextBox_text();
            this.txtSGSTAmt = new BControls.bTextBox_text();
            this.txtSGSTPer = new BControls.bTextBox_text();
            this.txtCGSTAmt = new BControls.bTextBox_text();
            this.txtCGSTPer = new BControls.bTextBox_text();
            this.txtIGSTAmt = new BControls.bTextBox_text();
            this.txtIGSTPer = new BControls.bTextBox_text();
            this.txtTaxableAMt = new BControls.bTextBox_text();
            this.txtDiscAmt = new BControls.bTextBox_text();
            this.txtDiscPer = new BControls.bTextBox_text();
            this.label31 = new System.Windows.Forms.Label();
            this.lblSGSTAmt = new System.Windows.Forms.Label();
            this.lblSGSTPer = new System.Windows.Forms.Label();
            this.lblCGSTAmt = new System.Windows.Forms.Label();
            this.lblCGSTPer = new System.Windows.Forms.Label();
            this.lblIGSTAmt = new System.Windows.Forms.Label();
            this.lblIGSTPer = new System.Windows.Forms.Label();
            this.lblItemLevelTax = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.LblDiscAmt = new System.Windows.Forms.Label();
            this.LblDiscPer = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQty = new BControls.bTextBox_text();
            this.txtRate = new BControls.bTextBox_text();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.cmbItemLevelTax = new DevExpress.XtraEditors.LookUpEdit();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTotal = new BControls.bTextBox_numeric();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNetInvoiceAmt = new BControls.bTextBox_numeric();
            this.txtOth1AddAmt = new BControls.bTextBox_numeric();
            this.txtT_DiscountAmt = new BControls.bTextBox_numeric();
            this.txtT_PackingAmt = new BControls.bTextBox_numeric();
            this.txtT_FreightAmt = new BControls.bTextBox_numeric();
            this.txtT_SGSTAmt = new BControls.bTextBox_numeric();
            this.txtT_CGSTAmt = new BControls.bTextBox_numeric();
            this.txtT_IGSTAmt = new BControls.bTextBox_numeric();
            this.label16 = new System.Windows.Forms.Label();
            this.lblOth1Add = new System.Windows.Forms.Label();
            this.lbl_aft_disc = new System.Windows.Forms.Label();
            this.lbl_aft_Packing = new System.Windows.Forms.Label();
            this.lbl_aft_freight = new System.Windows.Forms.Label();
            this.lblT_SGST = new System.Windows.Forms.Label();
            this.lblT_CGST = new System.Windows.Forms.Label();
            this.lblT_IGST = new System.Windows.Forms.Label();
            this.txtOth1AddPer = new BControls.bTextBox_numeric();
            this.txtT_DiscountPer = new BControls.bTextBox_numeric();
            this.txtT_PackingPer = new BControls.bTextBox_numeric();
            this.txtT_bf_FreightAmt = new BControls.bTextBox_numeric();
            this.txtT_bf_AddAmt = new BControls.bTextBox_numeric();
            this.txtT_bf_DiscAmt = new BControls.bTextBox_numeric();
            this.bTextBox_numeric4 = new BControls.bTextBox_numeric();
            this.txtT_FreightPer = new BControls.bTextBox_numeric();
            this.txtT_SGSTPer = new BControls.bTextBox_numeric();
            this.txtT_CGSTPer = new BControls.bTextBox_numeric();
            this.txtT_IGSTPer = new BControls.bTextBox_numeric();
            this.txtT_bf_freightPer = new BControls.bTextBox_numeric();
            this.txtT_bf_AddPer = new BControls.bTextBox_numeric();
            this.txtT_bf_DiscPer = new BControls.bTextBox_numeric();
            this.lbl_bf_freight = new System.Windows.Forms.Label();
            this.lbl_bf_add = new System.Windows.Forms.Label();
            this.lbl_bf_discount = new System.Windows.Forms.Label();
            this.lblTotal_TaxableAmt = new System.Windows.Forms.Label();
            this.PnlShippingDetails = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.txtTransporterName = new BControls.bTextBox_text();
            this.label24 = new System.Windows.Forms.Label();
            this.txtVehicleNo = new BControls.bTextBox_text();
            this.label22 = new System.Windows.Forms.Label();
            this.txtLrNo = new BControls.bTextBox_text();
            this.txtOrderNo = new BControls.bTextBox_text();
            this.label21 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpChallanDate = new DevExpress.XtraEditors.DateEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtChallanNo = new BControls.bTextBox_text();
            this.dtpOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.ChkPrintAfterSave = new System.Windows.Forms.CheckBox();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.label17 = new System.Windows.Forms.Label();
            this.panl = new System.Windows.Forms.Panel();
            this.txtHSNCode = new BControls.bTextBox_text();
            this.cmbGSTType = new BControls.bComboBox_dx();
            this.LkpCustomerName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtItemName = new BControls.bTextBox_text();
            this.slkp_ItemName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnlDueDate = new System.Windows.Forms.Panel();
            this.dtpInvDueDate = new DevExpress.XtraEditors.DateEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCreditDays = new BControls.bTextBox_text();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new DevExpress.XtraEditors.MemoEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerName = new BControls.bTextBox_text();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label26 = new System.Windows.Forms.Label();
            this.dtpInvDate = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new BControls.bTextBox_text();
            this.lblTotalLevelTax = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbInvoiceType = new BControls.bComboBox_dx();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTotalLevelTax = new DevExpress.XtraEditors.LookUpEdit();
            this.cmbBook = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlitemDescription)).BeginInit();
            this.pnlitemDescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtitemdesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbUnit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSGSTAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSGSTPer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCGSTAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCGSTPer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIGSTAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIGSTPer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxableAMt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscPer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbItemLevelTax.Properties)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetInvoiceAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOth1AddAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_DiscountAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_PackingAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_FreightAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_SGSTAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_CGSTAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_IGSTAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOth1AddPer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_DiscountPer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_PackingPer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_bf_FreightAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_bf_AddAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_bf_DiscAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTextBox_numeric4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_FreightPer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_SGSTPer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_CGSTPer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_IGSTPer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_bf_freightPer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_bf_AddPer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_bf_DiscPer.Properties)).BeginInit();
            this.PnlShippingDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransporterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVehicleNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLrNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpChallanDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpChallanDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChallanNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            this.panl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHSNCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGSTType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LkpCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkp_ItemName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.pnlDueDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpInvDueDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpInvDueDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreditDays.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpInvDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpInvDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoiceType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTotalLevelTax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBook.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlitemDescription);
            this.panel1.Controls.Add(this.dgvItems);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panl);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 665);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pnlitemDescription
            // 
            this.pnlitemDescription.Controls.Add(this.label27);
            this.pnlitemDescription.Controls.Add(this.txtitemdesc);
            this.pnlitemDescription.Location = new System.Drawing.Point(-1, 167);
            this.pnlitemDescription.Name = "pnlitemDescription";
            this.pnlitemDescription.Size = new System.Drawing.Size(402, 100);
            this.pnlitemDescription.TabIndex = 7;
            this.pnlitemDescription.Visible = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(3, 2);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(85, 13);
            this.label27.TabIndex = 9;
            this.label27.Text = "Item Description";
            // 
            // txtitemdesc
            // 
            this.txtitemdesc.Location = new System.Drawing.Point(4, 16);
            this.txtitemdesc.Name = "txtitemdesc";
            this.txtitemdesc.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtitemdesc.Properties.Appearance.Options.UseFont = true;
            this.txtitemdesc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtitemdesc.Size = new System.Drawing.Size(393, 79);
            this.txtitemdesc.TabIndex = 8;
            this.txtitemdesc.Leave += new System.EventHandler(this.txtitemdesc_Leave);
            // 
            // dgvItems
            // 
            this.dgvItems.AllowUserToAddRows = false;
            this.dgvItems.AllowUserToDeleteRows = false;
            this.dgvItems.AllowUserToOrderColumns = true;
            this.dgvItems.AllowUserToResizeRows = false;
            this.dgvItems.BackgroundColor = System.Drawing.Color.White;
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Srno,
            this.ItemId,
            this.ItemName,
            this.ItemDesc,
            this.HSNCode,
            this.Unit,
            this.Qty,
            this.Rate,
            this.DiscPer,
            this.DiscAmt,
            this.TaxableAmt,
            this.TaxId,
            this.TaxName,
            this.IGSTPer,
            this.IGSTAmt,
            this.CGSTPer,
            this.CGSTAmt,
            this.SGSTPer,
            this.SGSTAmt,
            this.Amount});
            this.dgvItems.Location = new System.Drawing.Point(1, 165);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersVisible = false;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(997, 265);
            this.dgvItems.TabIndex = 6;
            this.dgvItems.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentDoubleClick);
            this.dgvItems.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellDoubleClick);
            this.dgvItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvItems_KeyDown);
            // 
            // Srno
            // 
            this.Srno.HeaderText = "SrNo";
            this.Srno.Name = "Srno";
            this.Srno.ReadOnly = true;
            this.Srno.Width = 35;
            // 
            // ItemId
            // 
            this.ItemId.HeaderText = "ItemCode";
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            this.ItemId.Visible = false;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 150;
            // 
            // ItemDesc
            // 
            this.ItemDesc.HeaderText = "ItemDesc";
            this.ItemDesc.Name = "ItemDesc";
            this.ItemDesc.Width = 150;
            // 
            // HSNCode
            // 
            this.HSNCode.HeaderText = "HSNCode";
            this.HSNCode.Name = "HSNCode";
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.Width = 50;
            // 
            // Qty
            // 
            this.Qty.HeaderText = "Qty";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 50;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 75;
            // 
            // DiscPer
            // 
            this.DiscPer.HeaderText = "Disc %";
            this.DiscPer.Name = "DiscPer";
            this.DiscPer.ReadOnly = true;
            this.DiscPer.Width = 50;
            // 
            // DiscAmt
            // 
            this.DiscAmt.HeaderText = "Disc Amt";
            this.DiscAmt.Name = "DiscAmt";
            this.DiscAmt.ReadOnly = true;
            this.DiscAmt.Width = 80;
            // 
            // TaxableAmt
            // 
            this.TaxableAmt.HeaderText = "TaxableAmt";
            this.TaxableAmt.Name = "TaxableAmt";
            this.TaxableAmt.ReadOnly = true;
            this.TaxableAmt.Visible = false;
            // 
            // TaxId
            // 
            this.TaxId.HeaderText = "TaxId";
            this.TaxId.Name = "TaxId";
            this.TaxId.Visible = false;
            // 
            // TaxName
            // 
            this.TaxName.HeaderText = "TaxName";
            this.TaxName.Name = "TaxName";
            this.TaxName.ReadOnly = true;
            this.TaxName.Width = 75;
            // 
            // IGSTPer
            // 
            this.IGSTPer.HeaderText = "IGST %";
            this.IGSTPer.Name = "IGSTPer";
            this.IGSTPer.ReadOnly = true;
            this.IGSTPer.Width = 75;
            // 
            // IGSTAmt
            // 
            this.IGSTAmt.HeaderText = "IGST Amt";
            this.IGSTAmt.Name = "IGSTAmt";
            this.IGSTAmt.Width = 90;
            // 
            // CGSTPer
            // 
            this.CGSTPer.HeaderText = "CGST %";
            this.CGSTPer.Name = "CGSTPer";
            this.CGSTPer.ReadOnly = true;
            this.CGSTPer.Width = 80;
            // 
            // CGSTAmt
            // 
            this.CGSTAmt.HeaderText = "CGST Amt";
            this.CGSTAmt.Name = "CGSTAmt";
            this.CGSTAmt.ReadOnly = true;
            this.CGSTAmt.Width = 90;
            // 
            // SGSTPer
            // 
            this.SGSTPer.HeaderText = "SGST %";
            this.SGSTPer.Name = "SGSTPer";
            this.SGSTPer.ReadOnly = true;
            this.SGSTPer.Width = 80;
            // 
            // SGSTAmt
            // 
            this.SGSTAmt.HeaderText = "SGST Amt";
            this.SGSTAmt.Name = "SGSTAmt";
            this.SGSTAmt.ReadOnly = true;
            this.SGSTAmt.Width = 90;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 16;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.CmbUnit, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtItemAmount, 14, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSGSTAmt, 13, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSGSTPer, 12, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCGSTAmt, 11, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtCGSTPer, 10, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtIGSTAmt, 9, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtIGSTPer, 8, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtTaxableAMt, 6, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDiscAmt, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtDiscPer, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label31, 14, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSGSTAmt, 13, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblSGSTPer, 12, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCGSTAmt, 11, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblCGSTPer, 10, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblIGSTAmt, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblIGSTPer, 8, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblItemLevelTax, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.label23, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblDiscAmt, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.LblDiscPer, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label20, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label19, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label18, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtQty, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtRate, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnAdd, 15, 1);
            this.tableLayoutPanel2.Controls.Add(this.cmbItemLevelTax, 7, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1, 116);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(999, 49);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // CmbUnit
            // 
            this.CmbUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CmbUnit.Location = new System.Drawing.Point(131, 25);
            this.CmbUnit.Margin = new System.Windows.Forms.Padding(1);
            this.CmbUnit.Name = "CmbUnit";
            this.CmbUnit.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbUnit.Properties.Appearance.Options.UseFont = true;
            this.CmbUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbUnit.Properties.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.CmbUnit.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.CmbUnit.Size = new System.Drawing.Size(50, 22);
            this.CmbUnit.TabIndex = 3;
            // 
            // txtItemAmount
            // 
            this.txtItemAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtItemAmount.Location = new System.Drawing.Point(938, 25);
            this.txtItemAmount.Margin = new System.Windows.Forms.Padding(1);
            this.txtItemAmount.Name = "txtItemAmount";
            this.txtItemAmount.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemAmount.Properties.Appearance.Options.UseFont = true;
            this.txtItemAmount.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtItemAmount.Properties.Mask.EditMask = "n";
            this.txtItemAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtItemAmount.Properties.NullText = "0";
            this.txtItemAmount.Properties.NullValuePrompt = "0";
            this.txtItemAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtItemAmount.Size = new System.Drawing.Size(100, 22);
            this.txtItemAmount.TabIndex = 29;
            // 
            // txtSGSTAmt
            // 
            this.txtSGSTAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSGSTAmt.Location = new System.Drawing.Point(869, 25);
            this.txtSGSTAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtSGSTAmt.Name = "txtSGSTAmt";
            this.txtSGSTAmt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGSTAmt.Properties.Appearance.Options.UseFont = true;
            this.txtSGSTAmt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtSGSTAmt.Properties.Mask.EditMask = "n";
            this.txtSGSTAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSGSTAmt.Properties.NullText = "0";
            this.txtSGSTAmt.Properties.NullValuePrompt = "0";
            this.txtSGSTAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSGSTAmt.Size = new System.Drawing.Size(67, 22);
            this.txtSGSTAmt.TabIndex = 27;
            // 
            // txtSGSTPer
            // 
            this.txtSGSTPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSGSTPer.Location = new System.Drawing.Point(811, 25);
            this.txtSGSTPer.Margin = new System.Windows.Forms.Padding(1);
            this.txtSGSTPer.Name = "txtSGSTPer";
            this.txtSGSTPer.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGSTPer.Properties.Appearance.Options.UseFont = true;
            this.txtSGSTPer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtSGSTPer.Properties.Mask.EditMask = "n";
            this.txtSGSTPer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSGSTPer.Properties.NullText = "0";
            this.txtSGSTPer.Properties.NullValuePrompt = "0";
            this.txtSGSTPer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSGSTPer.Size = new System.Drawing.Size(56, 22);
            this.txtSGSTPer.TabIndex = 25;
            this.txtSGSTPer.EditValueChanged += new System.EventHandler(this.txtSGSTPer_EditValueChanged);
            // 
            // txtCGSTAmt
            // 
            this.txtCGSTAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCGSTAmt.Location = new System.Drawing.Point(744, 25);
            this.txtCGSTAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtCGSTAmt.Name = "txtCGSTAmt";
            this.txtCGSTAmt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGSTAmt.Properties.Appearance.Options.UseFont = true;
            this.txtCGSTAmt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCGSTAmt.Properties.Mask.EditMask = "n";
            this.txtCGSTAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCGSTAmt.Properties.NullText = "0";
            this.txtCGSTAmt.Properties.NullValuePrompt = "0";
            this.txtCGSTAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCGSTAmt.Size = new System.Drawing.Size(65, 22);
            this.txtCGSTAmt.TabIndex = 23;
            // 
            // txtCGSTPer
            // 
            this.txtCGSTPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCGSTPer.Location = new System.Drawing.Point(686, 25);
            this.txtCGSTPer.Margin = new System.Windows.Forms.Padding(1);
            this.txtCGSTPer.Name = "txtCGSTPer";
            this.txtCGSTPer.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGSTPer.Properties.Appearance.Options.UseFont = true;
            this.txtCGSTPer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCGSTPer.Properties.Mask.EditMask = "n";
            this.txtCGSTPer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCGSTPer.Properties.NullText = "0";
            this.txtCGSTPer.Properties.NullValuePrompt = "0";
            this.txtCGSTPer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCGSTPer.Size = new System.Drawing.Size(56, 22);
            this.txtCGSTPer.TabIndex = 21;
            this.txtCGSTPer.EditValueChanged += new System.EventHandler(this.txtCGSTPer_EditValueChanged);
            // 
            // txtIGSTAmt
            // 
            this.txtIGSTAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIGSTAmt.Location = new System.Drawing.Point(622, 25);
            this.txtIGSTAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtIGSTAmt.Name = "txtIGSTAmt";
            this.txtIGSTAmt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGSTAmt.Properties.Appearance.Options.UseFont = true;
            this.txtIGSTAmt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtIGSTAmt.Properties.Mask.EditMask = "n";
            this.txtIGSTAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIGSTAmt.Properties.NullText = "0";
            this.txtIGSTAmt.Properties.NullValuePrompt = "0";
            this.txtIGSTAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIGSTAmt.Size = new System.Drawing.Size(62, 22);
            this.txtIGSTAmt.TabIndex = 19;
            // 
            // txtIGSTPer
            // 
            this.txtIGSTPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtIGSTPer.Location = new System.Drawing.Point(570, 25);
            this.txtIGSTPer.Margin = new System.Windows.Forms.Padding(1);
            this.txtIGSTPer.Name = "txtIGSTPer";
            this.txtIGSTPer.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIGSTPer.Properties.Appearance.Options.UseFont = true;
            this.txtIGSTPer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtIGSTPer.Properties.Mask.EditMask = "n";
            this.txtIGSTPer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIGSTPer.Properties.NullText = "0";
            this.txtIGSTPer.Properties.NullValuePrompt = "0";
            this.txtIGSTPer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIGSTPer.Size = new System.Drawing.Size(50, 22);
            this.txtIGSTPer.TabIndex = 17;
            this.txtIGSTPer.EditValueChanged += new System.EventHandler(this.txtIGSTPer_EditValueChanged);
            // 
            // txtTaxableAMt
            // 
            this.txtTaxableAMt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTaxableAMt.Location = new System.Drawing.Point(402, 25);
            this.txtTaxableAMt.Margin = new System.Windows.Forms.Padding(1);
            this.txtTaxableAMt.Name = "txtTaxableAMt";
            this.txtTaxableAMt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxableAMt.Properties.Appearance.Options.UseFont = true;
            this.txtTaxableAMt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtTaxableAMt.Properties.Mask.EditMask = "n";
            this.txtTaxableAMt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTaxableAMt.Properties.NullText = "0";
            this.txtTaxableAMt.Properties.NullValuePrompt = "0";
            this.txtTaxableAMt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTaxableAMt.Size = new System.Drawing.Size(72, 22);
            this.txtTaxableAMt.TabIndex = 13;
            this.txtTaxableAMt.Visible = false;
            // 
            // txtDiscAmt
            // 
            this.txtDiscAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiscAmt.Location = new System.Drawing.Point(343, 25);
            this.txtDiscAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtDiscAmt.Name = "txtDiscAmt";
            this.txtDiscAmt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscAmt.Properties.Appearance.Options.UseFont = true;
            this.txtDiscAmt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtDiscAmt.Properties.Mask.EditMask = "n";
            this.txtDiscAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscAmt.Properties.NullText = "0";
            this.txtDiscAmt.Properties.NullValuePrompt = "0";
            this.txtDiscAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscAmt.Size = new System.Drawing.Size(57, 22);
            this.txtDiscAmt.TabIndex = 11;
            // 
            // txtDiscPer
            // 
            this.txtDiscPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDiscPer.Location = new System.Drawing.Point(295, 25);
            this.txtDiscPer.Margin = new System.Windows.Forms.Padding(1);
            this.txtDiscPer.Name = "txtDiscPer";
            this.txtDiscPer.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscPer.Properties.Appearance.Options.UseFont = true;
            this.txtDiscPer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtDiscPer.Properties.Mask.EditMask = "n";
            this.txtDiscPer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDiscPer.Properties.NullText = "0";
            this.txtDiscPer.Properties.NullValuePrompt = "0";
            this.txtDiscPer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscPer.Size = new System.Drawing.Size(46, 22);
            this.txtDiscPer.TabIndex = 9;
            this.txtDiscPer.EditValueChanged += new System.EventHandler(this.txtDiscPer_EditValueChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.ForeColor = System.Drawing.Color.Black;
            this.label31.Location = new System.Drawing.Point(938, 1);
            this.label31.Margin = new System.Windows.Forms.Padding(1);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(100, 22);
            this.label31.TabIndex = 28;
            this.label31.Text = "Amount";
            // 
            // lblSGSTAmt
            // 
            this.lblSGSTAmt.AutoSize = true;
            this.lblSGSTAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSGSTAmt.ForeColor = System.Drawing.Color.Black;
            this.lblSGSTAmt.Location = new System.Drawing.Point(869, 1);
            this.lblSGSTAmt.Margin = new System.Windows.Forms.Padding(1);
            this.lblSGSTAmt.Name = "lblSGSTAmt";
            this.lblSGSTAmt.Size = new System.Drawing.Size(67, 22);
            this.lblSGSTAmt.TabIndex = 26;
            this.lblSGSTAmt.Text = "SGST Amt";
            // 
            // lblSGSTPer
            // 
            this.lblSGSTPer.AutoSize = true;
            this.lblSGSTPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSGSTPer.ForeColor = System.Drawing.Color.Black;
            this.lblSGSTPer.Location = new System.Drawing.Point(811, 1);
            this.lblSGSTPer.Margin = new System.Windows.Forms.Padding(1);
            this.lblSGSTPer.Name = "lblSGSTPer";
            this.lblSGSTPer.Size = new System.Drawing.Size(56, 22);
            this.lblSGSTPer.TabIndex = 24;
            this.lblSGSTPer.Text = "SGST %";
            // 
            // lblCGSTAmt
            // 
            this.lblCGSTAmt.AutoSize = true;
            this.lblCGSTAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCGSTAmt.ForeColor = System.Drawing.Color.Black;
            this.lblCGSTAmt.Location = new System.Drawing.Point(744, 1);
            this.lblCGSTAmt.Margin = new System.Windows.Forms.Padding(1);
            this.lblCGSTAmt.Name = "lblCGSTAmt";
            this.lblCGSTAmt.Size = new System.Drawing.Size(65, 22);
            this.lblCGSTAmt.TabIndex = 22;
            this.lblCGSTAmt.Text = "CGST Amt";
            // 
            // lblCGSTPer
            // 
            this.lblCGSTPer.AutoSize = true;
            this.lblCGSTPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCGSTPer.ForeColor = System.Drawing.Color.Black;
            this.lblCGSTPer.Location = new System.Drawing.Point(686, 1);
            this.lblCGSTPer.Margin = new System.Windows.Forms.Padding(1);
            this.lblCGSTPer.Name = "lblCGSTPer";
            this.lblCGSTPer.Size = new System.Drawing.Size(56, 22);
            this.lblCGSTPer.TabIndex = 20;
            this.lblCGSTPer.Text = "CGST %";
            // 
            // lblIGSTAmt
            // 
            this.lblIGSTAmt.AutoSize = true;
            this.lblIGSTAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIGSTAmt.ForeColor = System.Drawing.Color.Black;
            this.lblIGSTAmt.Location = new System.Drawing.Point(622, 1);
            this.lblIGSTAmt.Margin = new System.Windows.Forms.Padding(1);
            this.lblIGSTAmt.Name = "lblIGSTAmt";
            this.lblIGSTAmt.Size = new System.Drawing.Size(62, 22);
            this.lblIGSTAmt.TabIndex = 18;
            this.lblIGSTAmt.Text = "IGST Amt";
            // 
            // lblIGSTPer
            // 
            this.lblIGSTPer.AutoSize = true;
            this.lblIGSTPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIGSTPer.ForeColor = System.Drawing.Color.Black;
            this.lblIGSTPer.Location = new System.Drawing.Point(570, 1);
            this.lblIGSTPer.Margin = new System.Windows.Forms.Padding(1);
            this.lblIGSTPer.Name = "lblIGSTPer";
            this.lblIGSTPer.Size = new System.Drawing.Size(50, 22);
            this.lblIGSTPer.TabIndex = 16;
            this.lblIGSTPer.Text = "IGST %";
            // 
            // lblItemLevelTax
            // 
            this.lblItemLevelTax.AutoSize = true;
            this.lblItemLevelTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblItemLevelTax.ForeColor = System.Drawing.Color.Black;
            this.lblItemLevelTax.Location = new System.Drawing.Point(476, 1);
            this.lblItemLevelTax.Margin = new System.Windows.Forms.Padding(1);
            this.lblItemLevelTax.Name = "lblItemLevelTax";
            this.lblItemLevelTax.Size = new System.Drawing.Size(92, 22);
            this.lblItemLevelTax.TabIndex = 14;
            this.lblItemLevelTax.Text = "Tax";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(402, 1);
            this.label23.Margin = new System.Windows.Forms.Padding(1);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(72, 22);
            this.label23.TabIndex = 12;
            this.label23.Text = "TaxableAmt";
            this.label23.Visible = false;
            // 
            // LblDiscAmt
            // 
            this.LblDiscAmt.AutoSize = true;
            this.LblDiscAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDiscAmt.ForeColor = System.Drawing.Color.Black;
            this.LblDiscAmt.Location = new System.Drawing.Point(343, 1);
            this.LblDiscAmt.Margin = new System.Windows.Forms.Padding(1);
            this.LblDiscAmt.Name = "LblDiscAmt";
            this.LblDiscAmt.Size = new System.Drawing.Size(57, 22);
            this.LblDiscAmt.TabIndex = 10;
            this.LblDiscAmt.Text = "Disc Amt";
            // 
            // LblDiscPer
            // 
            this.LblDiscPer.AutoSize = true;
            this.LblDiscPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblDiscPer.ForeColor = System.Drawing.Color.Black;
            this.LblDiscPer.Location = new System.Drawing.Point(295, 1);
            this.LblDiscPer.Margin = new System.Windows.Forms.Padding(1);
            this.LblDiscPer.Name = "LblDiscPer";
            this.LblDiscPer.Size = new System.Drawing.Size(46, 22);
            this.LblDiscPer.TabIndex = 8;
            this.LblDiscPer.Text = "Disc %";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(234, 1);
            this.label20.Margin = new System.Windows.Forms.Padding(1);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 22);
            this.label20.TabIndex = 6;
            this.label20.Text = "Rate";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(183, 1);
            this.label19.Margin = new System.Windows.Forms.Padding(1);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 22);
            this.label19.TabIndex = 4;
            this.label19.Text = "Qty";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(131, 1);
            this.label18.Margin = new System.Windows.Forms.Padding(1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 22);
            this.label18.TabIndex = 2;
            this.label18.Text = "Unit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(1, 1);
            this.label3.Margin = new System.Windows.Forms.Padding(1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Item Name               ";
            // 
            // txtQty
            // 
            this.txtQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQty.EditValue = "0";
            this.txtQty.Location = new System.Drawing.Point(183, 25);
            this.txtQty.Margin = new System.Windows.Forms.Padding(1);
            this.txtQty.Name = "txtQty";
            this.txtQty.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Properties.Appearance.Options.UseFont = true;
            this.txtQty.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtQty.Properties.Mask.EditMask = "n";
            this.txtQty.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtQty.Properties.NullText = "0";
            this.txtQty.Properties.NullValuePrompt = "0";
            this.txtQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtQty.Size = new System.Drawing.Size(49, 22);
            this.txtQty.TabIndex = 5;
            this.txtQty.EditValueChanged += new System.EventHandler(this.txtQty_EditValueChanged);
            // 
            // txtRate
            // 
            this.txtRate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRate.Location = new System.Drawing.Point(234, 25);
            this.txtRate.Margin = new System.Windows.Forms.Padding(1);
            this.txtRate.Name = "txtRate";
            this.txtRate.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Properties.Appearance.Options.UseFont = true;
            this.txtRate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtRate.Properties.Mask.EditMask = "n";
            this.txtRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtRate.Properties.NullText = "0";
            this.txtRate.Properties.NullValuePrompt = "0";
            this.txtRate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtRate.Size = new System.Drawing.Size(59, 22);
            this.txtRate.TabIndex = 7;
            this.txtRate.EditValueChanged += new System.EventHandler(this.txtRate_EditValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1042, 27);
            this.btnAdd.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnAdd.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(53, 19);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "&Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbItemLevelTax
            // 
            this.cmbItemLevelTax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbItemLevelTax.Location = new System.Drawing.Point(476, 25);
            this.cmbItemLevelTax.Margin = new System.Windows.Forms.Padding(1);
            this.cmbItemLevelTax.Name = "cmbItemLevelTax";
            this.cmbItemLevelTax.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbItemLevelTax.Properties.Appearance.Options.UseFont = true;
            this.cmbItemLevelTax.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbItemLevelTax.Properties.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.cmbItemLevelTax.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbItemLevelTax.Properties.NullText = "";
            this.cmbItemLevelTax.Properties.PopupSizeable = false;
            this.cmbItemLevelTax.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbItemLevelTax.Size = new System.Drawing.Size(92, 22);
            this.cmbItemLevelTax.TabIndex = 15;
            this.cmbItemLevelTax.Leave += new System.EventHandler(this.cmbItemLevelTax_Leave);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Controls.Add(this.PnlShippingDetails);
            this.panel5.Controls.Add(this.ChkPrintAfterSave);
            this.panel5.Controls.Add(this.txtRemark);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Location = new System.Drawing.Point(-1, 429);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1001, 197);
            this.panel5.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.txtTotal, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNetInvoiceAmt, 2, 12);
            this.tableLayoutPanel1.Controls.Add(this.txtOth1AddAmt, 2, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtT_DiscountAmt, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtT_PackingAmt, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtT_FreightAmt, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtT_SGSTAmt, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtT_CGSTAmt, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtT_IGSTAmt, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label16, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.lblOth1Add, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.lbl_aft_disc, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lbl_aft_Packing, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lbl_aft_freight, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.lblT_SGST, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblT_CGST, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblT_IGST, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtOth1AddPer, 1, 11);
            this.tableLayoutPanel1.Controls.Add(this.txtT_DiscountPer, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.txtT_PackingPer, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.txtT_bf_FreightAmt, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtT_bf_AddAmt, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtT_bf_DiscAmt, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.bTextBox_numeric4, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtT_FreightPer, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.txtT_SGSTPer, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtT_CGSTPer, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.txtT_IGSTPer, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtT_bf_freightPer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtT_bf_AddPer, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtT_bf_DiscPer, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_bf_freight, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_bf_add, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_bf_discount, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblTotal_TaxableAmt, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(729, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 13;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(268, 194);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // txtTotal
            // 
            this.txtTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTotal.Location = new System.Drawing.Point(168, 1);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(1);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtTotal.Properties.Mask.EditMask = "n";
            this.txtTotal.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTotal.Properties.NullText = "0";
            this.txtTotal.Properties.NullValuePrompt = "0";
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(1, 1);
            this.label9.Margin = new System.Windows.Forms.Padding(1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 22);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNetInvoiceAmt
            // 
            this.txtNetInvoiceAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNetInvoiceAmt.Location = new System.Drawing.Point(168, 289);
            this.txtNetInvoiceAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtNetInvoiceAmt.Name = "txtNetInvoiceAmt";
            this.txtNetInvoiceAmt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetInvoiceAmt.Properties.Appearance.Options.UseFont = true;
            this.txtNetInvoiceAmt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtNetInvoiceAmt.Properties.Mask.EditMask = "n";
            this.txtNetInvoiceAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNetInvoiceAmt.Properties.NullText = "0";
            this.txtNetInvoiceAmt.Properties.NullValuePrompt = "0";
            this.txtNetInvoiceAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNetInvoiceAmt.Size = new System.Drawing.Size(100, 22);
            this.txtNetInvoiceAmt.TabIndex = 35;
            // 
            // txtOth1AddAmt
            // 
            this.txtOth1AddAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOth1AddAmt.Location = new System.Drawing.Point(168, 265);
            this.txtOth1AddAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtOth1AddAmt.Name = "txtOth1AddAmt";
            this.txtOth1AddAmt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOth1AddAmt.Properties.Appearance.Options.UseFont = true;
            this.txtOth1AddAmt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtOth1AddAmt.Properties.Mask.EditMask = "n";
            this.txtOth1AddAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtOth1AddAmt.Properties.NullText = "0";
            this.txtOth1AddAmt.Properties.NullValuePrompt = "0";
            this.txtOth1AddAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOth1AddAmt.Size = new System.Drawing.Size(100, 22);
            this.txtOth1AddAmt.TabIndex = 33;
            this.txtOth1AddAmt.Visible = false;
            this.txtOth1AddAmt.EditValueChanged += new System.EventHandler(this.txtOth1AddAmt_EditValueChanged);
            // 
            // txtT_DiscountAmt
            // 
            this.txtT_DiscountAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_DiscountAmt.Location = new System.Drawing.Point(168, 241);
            this.txtT_DiscountAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_DiscountAmt.Name = "txtT_DiscountAmt";
            this.txtT_DiscountAmt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_DiscountAmt.Properties.Appearance.Options.UseFont = true;
            this.txtT_DiscountAmt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_DiscountAmt.Properties.Mask.EditMask = "n";
            this.txtT_DiscountAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_DiscountAmt.Properties.NullText = "0";
            this.txtT_DiscountAmt.Properties.NullValuePrompt = "0";
            this.txtT_DiscountAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_DiscountAmt.Size = new System.Drawing.Size(100, 22);
            this.txtT_DiscountAmt.TabIndex = 30;
            this.txtT_DiscountAmt.EditValueChanged += new System.EventHandler(this.txtT_DiscountAmt_EditValueChanged);
            // 
            // txtT_PackingAmt
            // 
            this.txtT_PackingAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_PackingAmt.Location = new System.Drawing.Point(168, 217);
            this.txtT_PackingAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_PackingAmt.Name = "txtT_PackingAmt";
            this.txtT_PackingAmt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_PackingAmt.Properties.Appearance.Options.UseFont = true;
            this.txtT_PackingAmt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_PackingAmt.Properties.Mask.EditMask = "n";
            this.txtT_PackingAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_PackingAmt.Properties.NullText = "0";
            this.txtT_PackingAmt.Properties.NullValuePrompt = "0";
            this.txtT_PackingAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_PackingAmt.Size = new System.Drawing.Size(100, 22);
            this.txtT_PackingAmt.TabIndex = 27;
            this.txtT_PackingAmt.EditValueChanged += new System.EventHandler(this.txtT_PackingAmt_EditValueChanged);
            // 
            // txtT_FreightAmt
            // 
            this.txtT_FreightAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_FreightAmt.Location = new System.Drawing.Point(168, 193);
            this.txtT_FreightAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_FreightAmt.Name = "txtT_FreightAmt";
            this.txtT_FreightAmt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_FreightAmt.Properties.Appearance.Options.UseFont = true;
            this.txtT_FreightAmt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_FreightAmt.Properties.Mask.EditMask = "n";
            this.txtT_FreightAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_FreightAmt.Properties.NullText = "0";
            this.txtT_FreightAmt.Properties.NullValuePrompt = "0";
            this.txtT_FreightAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_FreightAmt.Size = new System.Drawing.Size(100, 22);
            this.txtT_FreightAmt.TabIndex = 24;
            this.txtT_FreightAmt.EditValueChanged += new System.EventHandler(this.txtT_FreightAmt_EditValueChanged);
            // 
            // txtT_SGSTAmt
            // 
            this.txtT_SGSTAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_SGSTAmt.Location = new System.Drawing.Point(168, 169);
            this.txtT_SGSTAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_SGSTAmt.Name = "txtT_SGSTAmt";
            this.txtT_SGSTAmt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_SGSTAmt.Properties.Appearance.Options.UseFont = true;
            this.txtT_SGSTAmt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_SGSTAmt.Properties.Mask.EditMask = "n";
            this.txtT_SGSTAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_SGSTAmt.Properties.NullText = "0";
            this.txtT_SGSTAmt.Properties.NullValuePrompt = "0";
            this.txtT_SGSTAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_SGSTAmt.Size = new System.Drawing.Size(100, 22);
            this.txtT_SGSTAmt.TabIndex = 21;
            // 
            // txtT_CGSTAmt
            // 
            this.txtT_CGSTAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_CGSTAmt.Location = new System.Drawing.Point(168, 145);
            this.txtT_CGSTAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_CGSTAmt.Name = "txtT_CGSTAmt";
            this.txtT_CGSTAmt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_CGSTAmt.Properties.Appearance.Options.UseFont = true;
            this.txtT_CGSTAmt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_CGSTAmt.Properties.Mask.EditMask = "n";
            this.txtT_CGSTAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_CGSTAmt.Properties.NullText = "0";
            this.txtT_CGSTAmt.Properties.NullValuePrompt = "0";
            this.txtT_CGSTAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_CGSTAmt.Size = new System.Drawing.Size(100, 22);
            this.txtT_CGSTAmt.TabIndex = 18;
            // 
            // txtT_IGSTAmt
            // 
            this.txtT_IGSTAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_IGSTAmt.Location = new System.Drawing.Point(168, 121);
            this.txtT_IGSTAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_IGSTAmt.Name = "txtT_IGSTAmt";
            this.txtT_IGSTAmt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_IGSTAmt.Properties.Appearance.Options.UseFont = true;
            this.txtT_IGSTAmt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_IGSTAmt.Properties.Mask.EditMask = "n";
            this.txtT_IGSTAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_IGSTAmt.Properties.NullText = "0";
            this.txtT_IGSTAmt.Properties.NullValuePrompt = "0";
            this.txtT_IGSTAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_IGSTAmt.Size = new System.Drawing.Size(100, 22);
            this.txtT_IGSTAmt.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(1, 289);
            this.label16.Margin = new System.Windows.Forms.Padding(1);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 22);
            this.label16.TabIndex = 34;
            this.label16.Text = "Net Invoice Amount";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblOth1Add
            // 
            this.lblOth1Add.AutoSize = true;
            this.lblOth1Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOth1Add.ForeColor = System.Drawing.Color.Black;
            this.lblOth1Add.Location = new System.Drawing.Point(1, 265);
            this.lblOth1Add.Margin = new System.Windows.Forms.Padding(1);
            this.lblOth1Add.Name = "lblOth1Add";
            this.lblOth1Add.Size = new System.Drawing.Size(118, 22);
            this.lblOth1Add.TabIndex = 31;
            this.lblOth1Add.Text = "TCS";
            this.lblOth1Add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOth1Add.Visible = false;
            // 
            // lbl_aft_disc
            // 
            this.lbl_aft_disc.AutoSize = true;
            this.lbl_aft_disc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_aft_disc.ForeColor = System.Drawing.Color.Black;
            this.lbl_aft_disc.Location = new System.Drawing.Point(1, 241);
            this.lbl_aft_disc.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_aft_disc.Name = "lbl_aft_disc";
            this.lbl_aft_disc.Size = new System.Drawing.Size(118, 22);
            this.lbl_aft_disc.TabIndex = 28;
            this.lbl_aft_disc.Text = "Discount";
            this.lbl_aft_disc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_aft_Packing
            // 
            this.lbl_aft_Packing.AutoSize = true;
            this.lbl_aft_Packing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_aft_Packing.ForeColor = System.Drawing.Color.Black;
            this.lbl_aft_Packing.Location = new System.Drawing.Point(1, 217);
            this.lbl_aft_Packing.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_aft_Packing.Name = "lbl_aft_Packing";
            this.lbl_aft_Packing.Size = new System.Drawing.Size(118, 22);
            this.lbl_aft_Packing.TabIndex = 25;
            this.lbl_aft_Packing.Text = "Packing Forward";
            this.lbl_aft_Packing.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_aft_freight
            // 
            this.lbl_aft_freight.AutoSize = true;
            this.lbl_aft_freight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_aft_freight.ForeColor = System.Drawing.Color.Black;
            this.lbl_aft_freight.Location = new System.Drawing.Point(1, 193);
            this.lbl_aft_freight.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_aft_freight.Name = "lbl_aft_freight";
            this.lbl_aft_freight.Size = new System.Drawing.Size(118, 22);
            this.lbl_aft_freight.TabIndex = 22;
            this.lbl_aft_freight.Text = "Freight";
            this.lbl_aft_freight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblT_SGST
            // 
            this.lblT_SGST.AutoSize = true;
            this.lblT_SGST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblT_SGST.ForeColor = System.Drawing.Color.Black;
            this.lblT_SGST.Location = new System.Drawing.Point(1, 169);
            this.lblT_SGST.Margin = new System.Windows.Forms.Padding(1);
            this.lblT_SGST.Name = "lblT_SGST";
            this.lblT_SGST.Size = new System.Drawing.Size(118, 22);
            this.lblT_SGST.TabIndex = 19;
            this.lblT_SGST.Text = "SGST";
            this.lblT_SGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblT_CGST
            // 
            this.lblT_CGST.AutoSize = true;
            this.lblT_CGST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblT_CGST.ForeColor = System.Drawing.Color.Black;
            this.lblT_CGST.Location = new System.Drawing.Point(1, 145);
            this.lblT_CGST.Margin = new System.Windows.Forms.Padding(1);
            this.lblT_CGST.Name = "lblT_CGST";
            this.lblT_CGST.Size = new System.Drawing.Size(118, 22);
            this.lblT_CGST.TabIndex = 16;
            this.lblT_CGST.Text = "CGST";
            this.lblT_CGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblT_IGST
            // 
            this.lblT_IGST.AutoSize = true;
            this.lblT_IGST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblT_IGST.ForeColor = System.Drawing.Color.Black;
            this.lblT_IGST.Location = new System.Drawing.Point(1, 121);
            this.lblT_IGST.Margin = new System.Windows.Forms.Padding(1);
            this.lblT_IGST.Name = "lblT_IGST";
            this.lblT_IGST.Size = new System.Drawing.Size(118, 22);
            this.lblT_IGST.TabIndex = 13;
            this.lblT_IGST.Text = "IGST";
            this.lblT_IGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOth1AddPer
            // 
            this.txtOth1AddPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOth1AddPer.Location = new System.Drawing.Point(121, 265);
            this.txtOth1AddPer.Margin = new System.Windows.Forms.Padding(1);
            this.txtOth1AddPer.Name = "txtOth1AddPer";
            this.txtOth1AddPer.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOth1AddPer.Properties.Appearance.Options.UseFont = true;
            this.txtOth1AddPer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtOth1AddPer.Properties.Mask.EditMask = "n";
            this.txtOth1AddPer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtOth1AddPer.Properties.NullText = "0";
            this.txtOth1AddPer.Properties.NullValuePrompt = "0";
            this.txtOth1AddPer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOth1AddPer.Size = new System.Drawing.Size(45, 22);
            this.txtOth1AddPer.TabIndex = 32;
            this.txtOth1AddPer.Visible = false;
            this.txtOth1AddPer.EditValueChanged += new System.EventHandler(this.txtOth1AddPer_EditValueChanged);
            // 
            // txtT_DiscountPer
            // 
            this.txtT_DiscountPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_DiscountPer.Location = new System.Drawing.Point(121, 241);
            this.txtT_DiscountPer.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_DiscountPer.Name = "txtT_DiscountPer";
            this.txtT_DiscountPer.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_DiscountPer.Properties.Appearance.Options.UseFont = true;
            this.txtT_DiscountPer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_DiscountPer.Properties.Mask.EditMask = "n";
            this.txtT_DiscountPer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_DiscountPer.Properties.NullText = "0";
            this.txtT_DiscountPer.Properties.NullValuePrompt = "0";
            this.txtT_DiscountPer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_DiscountPer.Size = new System.Drawing.Size(45, 22);
            this.txtT_DiscountPer.TabIndex = 29;
            this.txtT_DiscountPer.EditValueChanged += new System.EventHandler(this.txtT_DiscountPer_EditValueChanged);
            // 
            // txtT_PackingPer
            // 
            this.txtT_PackingPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_PackingPer.Location = new System.Drawing.Point(121, 217);
            this.txtT_PackingPer.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_PackingPer.Name = "txtT_PackingPer";
            this.txtT_PackingPer.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_PackingPer.Properties.Appearance.Options.UseFont = true;
            this.txtT_PackingPer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_PackingPer.Properties.Mask.EditMask = "n";
            this.txtT_PackingPer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_PackingPer.Properties.NullText = "0";
            this.txtT_PackingPer.Properties.NullValuePrompt = "0";
            this.txtT_PackingPer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_PackingPer.Size = new System.Drawing.Size(45, 22);
            this.txtT_PackingPer.TabIndex = 26;
            this.txtT_PackingPer.EditValueChanged += new System.EventHandler(this.txtT_PackingPer_EditValueChanged);
            // 
            // txtT_bf_FreightAmt
            // 
            this.txtT_bf_FreightAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_bf_FreightAmt.Location = new System.Drawing.Point(168, 25);
            this.txtT_bf_FreightAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_bf_FreightAmt.Name = "txtT_bf_FreightAmt";
            this.txtT_bf_FreightAmt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_bf_FreightAmt.Properties.Appearance.Options.UseFont = true;
            this.txtT_bf_FreightAmt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_bf_FreightAmt.Properties.Mask.EditMask = "n";
            this.txtT_bf_FreightAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_bf_FreightAmt.Properties.NullText = "0";
            this.txtT_bf_FreightAmt.Properties.NullValuePrompt = "0";
            this.txtT_bf_FreightAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_bf_FreightAmt.Size = new System.Drawing.Size(100, 22);
            this.txtT_bf_FreightAmt.TabIndex = 4;
            this.txtT_bf_FreightAmt.EditValueChanged += new System.EventHandler(this.txtT_bf_FreightAmt_EditValueChanged);
            // 
            // txtT_bf_AddAmt
            // 
            this.txtT_bf_AddAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_bf_AddAmt.Location = new System.Drawing.Point(168, 49);
            this.txtT_bf_AddAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_bf_AddAmt.Name = "txtT_bf_AddAmt";
            this.txtT_bf_AddAmt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_bf_AddAmt.Properties.Appearance.Options.UseFont = true;
            this.txtT_bf_AddAmt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_bf_AddAmt.Properties.Mask.EditMask = "n";
            this.txtT_bf_AddAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_bf_AddAmt.Properties.NullText = "0";
            this.txtT_bf_AddAmt.Properties.NullValuePrompt = "0";
            this.txtT_bf_AddAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_bf_AddAmt.Size = new System.Drawing.Size(100, 22);
            this.txtT_bf_AddAmt.TabIndex = 7;
            this.txtT_bf_AddAmt.EditValueChanged += new System.EventHandler(this.txtT_bf_AddAmt_EditValueChanged);
            // 
            // txtT_bf_DiscAmt
            // 
            this.txtT_bf_DiscAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_bf_DiscAmt.Location = new System.Drawing.Point(168, 73);
            this.txtT_bf_DiscAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_bf_DiscAmt.Name = "txtT_bf_DiscAmt";
            this.txtT_bf_DiscAmt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_bf_DiscAmt.Properties.Appearance.Options.UseFont = true;
            this.txtT_bf_DiscAmt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_bf_DiscAmt.Properties.Mask.EditMask = "n";
            this.txtT_bf_DiscAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_bf_DiscAmt.Properties.NullText = "0";
            this.txtT_bf_DiscAmt.Properties.NullValuePrompt = "0";
            this.txtT_bf_DiscAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_bf_DiscAmt.Size = new System.Drawing.Size(100, 22);
            this.txtT_bf_DiscAmt.TabIndex = 10;
            this.txtT_bf_DiscAmt.EditValueChanged += new System.EventHandler(this.txtT_bf_DiscAmt_EditValueChanged);
            // 
            // bTextBox_numeric4
            // 
            this.bTextBox_numeric4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTextBox_numeric4.Location = new System.Drawing.Point(168, 97);
            this.bTextBox_numeric4.Margin = new System.Windows.Forms.Padding(1);
            this.bTextBox_numeric4.Name = "bTextBox_numeric4";
            this.bTextBox_numeric4.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTextBox_numeric4.Properties.Appearance.Options.UseFont = true;
            this.bTextBox_numeric4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.bTextBox_numeric4.Properties.Mask.EditMask = "n";
            this.bTextBox_numeric4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.bTextBox_numeric4.Properties.NullText = "0";
            this.bTextBox_numeric4.Properties.NullValuePrompt = "0";
            this.bTextBox_numeric4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bTextBox_numeric4.Size = new System.Drawing.Size(100, 22);
            this.bTextBox_numeric4.TabIndex = 12;
            this.bTextBox_numeric4.Visible = false;
            // 
            // txtT_FreightPer
            // 
            this.txtT_FreightPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_FreightPer.Location = new System.Drawing.Point(121, 193);
            this.txtT_FreightPer.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_FreightPer.Name = "txtT_FreightPer";
            this.txtT_FreightPer.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_FreightPer.Properties.Appearance.Options.UseFont = true;
            this.txtT_FreightPer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_FreightPer.Properties.Mask.EditMask = "n";
            this.txtT_FreightPer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_FreightPer.Properties.NullText = "0";
            this.txtT_FreightPer.Properties.NullValuePrompt = "0";
            this.txtT_FreightPer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_FreightPer.Size = new System.Drawing.Size(45, 22);
            this.txtT_FreightPer.TabIndex = 23;
            this.txtT_FreightPer.EditValueChanged += new System.EventHandler(this.txtT_FreightPer_EditValueChanged);
            // 
            // txtT_SGSTPer
            // 
            this.txtT_SGSTPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_SGSTPer.Location = new System.Drawing.Point(121, 169);
            this.txtT_SGSTPer.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_SGSTPer.Name = "txtT_SGSTPer";
            this.txtT_SGSTPer.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_SGSTPer.Properties.Appearance.Options.UseFont = true;
            this.txtT_SGSTPer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_SGSTPer.Properties.Mask.EditMask = "n";
            this.txtT_SGSTPer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_SGSTPer.Properties.NullText = "0";
            this.txtT_SGSTPer.Properties.NullValuePrompt = "0";
            this.txtT_SGSTPer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_SGSTPer.Size = new System.Drawing.Size(45, 22);
            this.txtT_SGSTPer.TabIndex = 20;
            // 
            // txtT_CGSTPer
            // 
            this.txtT_CGSTPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_CGSTPer.Location = new System.Drawing.Point(121, 145);
            this.txtT_CGSTPer.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_CGSTPer.Name = "txtT_CGSTPer";
            this.txtT_CGSTPer.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_CGSTPer.Properties.Appearance.Options.UseFont = true;
            this.txtT_CGSTPer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_CGSTPer.Properties.Mask.EditMask = "n";
            this.txtT_CGSTPer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_CGSTPer.Properties.NullText = "0";
            this.txtT_CGSTPer.Properties.NullValuePrompt = "0";
            this.txtT_CGSTPer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_CGSTPer.Size = new System.Drawing.Size(45, 22);
            this.txtT_CGSTPer.TabIndex = 17;
            this.txtT_CGSTPer.EditValueChanged += new System.EventHandler(this.txtT_CGSTPer_EditValueChanged);
            // 
            // txtT_IGSTPer
            // 
            this.txtT_IGSTPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_IGSTPer.Location = new System.Drawing.Point(121, 121);
            this.txtT_IGSTPer.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_IGSTPer.Name = "txtT_IGSTPer";
            this.txtT_IGSTPer.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_IGSTPer.Properties.Appearance.Options.UseFont = true;
            this.txtT_IGSTPer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_IGSTPer.Properties.Mask.EditMask = "n";
            this.txtT_IGSTPer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_IGSTPer.Properties.NullText = "0";
            this.txtT_IGSTPer.Properties.NullValuePrompt = "0";
            this.txtT_IGSTPer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_IGSTPer.Size = new System.Drawing.Size(45, 22);
            this.txtT_IGSTPer.TabIndex = 14;
            this.txtT_IGSTPer.EditValueChanged += new System.EventHandler(this.txtT_IGSTPer_EditValueChanged);
            // 
            // txtT_bf_freightPer
            // 
            this.txtT_bf_freightPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_bf_freightPer.Location = new System.Drawing.Point(121, 25);
            this.txtT_bf_freightPer.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_bf_freightPer.Name = "txtT_bf_freightPer";
            this.txtT_bf_freightPer.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_bf_freightPer.Properties.Appearance.Options.UseFont = true;
            this.txtT_bf_freightPer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_bf_freightPer.Properties.Mask.EditMask = "n";
            this.txtT_bf_freightPer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_bf_freightPer.Properties.NullText = "0";
            this.txtT_bf_freightPer.Properties.NullValuePrompt = "0";
            this.txtT_bf_freightPer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_bf_freightPer.Size = new System.Drawing.Size(45, 22);
            this.txtT_bf_freightPer.TabIndex = 3;
            this.txtT_bf_freightPer.EditValueChanged += new System.EventHandler(this.txtT_bf_freightPer_EditValueChanged);
            // 
            // txtT_bf_AddPer
            // 
            this.txtT_bf_AddPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_bf_AddPer.Location = new System.Drawing.Point(121, 49);
            this.txtT_bf_AddPer.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_bf_AddPer.Name = "txtT_bf_AddPer";
            this.txtT_bf_AddPer.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_bf_AddPer.Properties.Appearance.Options.UseFont = true;
            this.txtT_bf_AddPer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_bf_AddPer.Properties.Mask.EditMask = "n";
            this.txtT_bf_AddPer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_bf_AddPer.Properties.NullText = "0";
            this.txtT_bf_AddPer.Properties.NullValuePrompt = "0";
            this.txtT_bf_AddPer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_bf_AddPer.Size = new System.Drawing.Size(45, 22);
            this.txtT_bf_AddPer.TabIndex = 6;
            this.txtT_bf_AddPer.EditValueChanged += new System.EventHandler(this.txtT_bf_AddPer_EditValueChanged);
            // 
            // txtT_bf_DiscPer
            // 
            this.txtT_bf_DiscPer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtT_bf_DiscPer.Location = new System.Drawing.Point(121, 73);
            this.txtT_bf_DiscPer.Margin = new System.Windows.Forms.Padding(1);
            this.txtT_bf_DiscPer.Name = "txtT_bf_DiscPer";
            this.txtT_bf_DiscPer.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtT_bf_DiscPer.Properties.Appearance.Options.UseFont = true;
            this.txtT_bf_DiscPer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtT_bf_DiscPer.Properties.Mask.EditMask = "n";
            this.txtT_bf_DiscPer.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtT_bf_DiscPer.Properties.NullText = "0";
            this.txtT_bf_DiscPer.Properties.NullValuePrompt = "0";
            this.txtT_bf_DiscPer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtT_bf_DiscPer.Size = new System.Drawing.Size(45, 22);
            this.txtT_bf_DiscPer.TabIndex = 9;
            this.txtT_bf_DiscPer.EditValueChanged += new System.EventHandler(this.txtT_bf_DiscPer_EditValueChanged);
            // 
            // lbl_bf_freight
            // 
            this.lbl_bf_freight.AutoSize = true;
            this.lbl_bf_freight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_bf_freight.ForeColor = System.Drawing.Color.Black;
            this.lbl_bf_freight.Location = new System.Drawing.Point(1, 25);
            this.lbl_bf_freight.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_bf_freight.Name = "lbl_bf_freight";
            this.lbl_bf_freight.Size = new System.Drawing.Size(118, 22);
            this.lbl_bf_freight.TabIndex = 2;
            this.lbl_bf_freight.Text = "Freight";
            this.lbl_bf_freight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_bf_add
            // 
            this.lbl_bf_add.AutoSize = true;
            this.lbl_bf_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_bf_add.ForeColor = System.Drawing.Color.Black;
            this.lbl_bf_add.Location = new System.Drawing.Point(1, 49);
            this.lbl_bf_add.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_bf_add.Name = "lbl_bf_add";
            this.lbl_bf_add.Size = new System.Drawing.Size(118, 22);
            this.lbl_bf_add.TabIndex = 5;
            this.lbl_bf_add.Text = "Additional";
            this.lbl_bf_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_bf_discount
            // 
            this.lbl_bf_discount.AutoSize = true;
            this.lbl_bf_discount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_bf_discount.ForeColor = System.Drawing.Color.Black;
            this.lbl_bf_discount.Location = new System.Drawing.Point(1, 73);
            this.lbl_bf_discount.Margin = new System.Windows.Forms.Padding(1);
            this.lbl_bf_discount.Name = "lbl_bf_discount";
            this.lbl_bf_discount.Size = new System.Drawing.Size(118, 22);
            this.lbl_bf_discount.TabIndex = 8;
            this.lbl_bf_discount.Text = "Tax Befor Discount";
            this.lbl_bf_discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal_TaxableAmt
            // 
            this.lblTotal_TaxableAmt.AutoSize = true;
            this.lblTotal_TaxableAmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotal_TaxableAmt.ForeColor = System.Drawing.Color.Black;
            this.lblTotal_TaxableAmt.Location = new System.Drawing.Point(1, 97);
            this.lblTotal_TaxableAmt.Margin = new System.Windows.Forms.Padding(1);
            this.lblTotal_TaxableAmt.Name = "lblTotal_TaxableAmt";
            this.lblTotal_TaxableAmt.Size = new System.Drawing.Size(118, 22);
            this.lblTotal_TaxableAmt.TabIndex = 11;
            this.lblTotal_TaxableAmt.Text = "Taxable Amount";
            this.lblTotal_TaxableAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotal_TaxableAmt.Visible = false;
            // 
            // PnlShippingDetails
            // 
            this.PnlShippingDetails.Controls.Add(this.label25);
            this.PnlShippingDetails.Controls.Add(this.txtTransporterName);
            this.PnlShippingDetails.Controls.Add(this.label24);
            this.PnlShippingDetails.Controls.Add(this.txtVehicleNo);
            this.PnlShippingDetails.Controls.Add(this.label22);
            this.PnlShippingDetails.Controls.Add(this.txtLrNo);
            this.PnlShippingDetails.Controls.Add(this.txtOrderNo);
            this.PnlShippingDetails.Controls.Add(this.label21);
            this.PnlShippingDetails.Controls.Add(this.label10);
            this.PnlShippingDetails.Controls.Add(this.dtpChallanDate);
            this.PnlShippingDetails.Controls.Add(this.label11);
            this.PnlShippingDetails.Controls.Add(this.label12);
            this.PnlShippingDetails.Controls.Add(this.txtChallanNo);
            this.PnlShippingDetails.Controls.Add(this.dtpOrderDate);
            this.PnlShippingDetails.Location = new System.Drawing.Point(74, 85);
            this.PnlShippingDetails.Name = "PnlShippingDetails";
            this.PnlShippingDetails.Size = new System.Drawing.Size(642, 78);
            this.PnlShippingDetails.TabIndex = 34;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(341, 36);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(106, 14);
            this.label25.TabIndex = 39;
            this.label25.Text = "Transporter Name";
            // 
            // txtTransporterName
            // 
            this.txtTransporterName.Location = new System.Drawing.Point(447, 33);
            this.txtTransporterName.Name = "txtTransporterName";
            this.txtTransporterName.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransporterName.Properties.Appearance.Options.UseFont = true;
            this.txtTransporterName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtTransporterName.Size = new System.Drawing.Size(183, 22);
            this.txtTransporterName.TabIndex = 38;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(479, 6);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(65, 14);
            this.label24.TabIndex = 37;
            this.label24.Text = "Vehicle No";
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Location = new System.Drawing.Point(546, 3);
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleNo.Properties.Appearance.Options.UseFont = true;
            this.txtVehicleNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtVehicleNo.Size = new System.Drawing.Size(84, 22);
            this.txtVehicleNo.TabIndex = 36;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(341, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(39, 14);
            this.label22.TabIndex = 35;
            this.label22.Text = "LR No";
            // 
            // txtLrNo
            // 
            this.txtLrNo.Location = new System.Drawing.Point(391, 3);
            this.txtLrNo.Name = "txtLrNo";
            this.txtLrNo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLrNo.Properties.Appearance.Options.UseFont = true;
            this.txtLrNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtLrNo.Size = new System.Drawing.Size(84, 22);
            this.txtLrNo.TabIndex = 34;
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Location = new System.Drawing.Point(76, 3);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderNo.Properties.Appearance.Options.UseFont = true;
            this.txtOrderNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtOrderNo.Size = new System.Drawing.Size(84, 22);
            this.txtOrderNo.TabIndex = 26;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(166, 38);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(74, 14);
            this.label21.TabIndex = 33;
            this.label21.Text = "Challan Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(5, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 14);
            this.label10.TabIndex = 27;
            this.label10.Text = "Order No";
            // 
            // dtpChallanDate
            // 
            this.dtpChallanDate.EditValue = null;
            this.dtpChallanDate.Location = new System.Drawing.Point(242, 34);
            this.dtpChallanDate.Name = "dtpChallanDate";
            this.dtpChallanDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.dtpChallanDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dtpChallanDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpChallanDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpChallanDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpChallanDate.Size = new System.Drawing.Size(84, 22);
            this.dtpChallanDate.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(166, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 14);
            this.label11.TabIndex = 29;
            this.label11.Text = "Challan No";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(5, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 14);
            this.label12.TabIndex = 31;
            this.label12.Text = "Order Date";
            // 
            // txtChallanNo
            // 
            this.txtChallanNo.Location = new System.Drawing.Point(242, 3);
            this.txtChallanNo.Name = "txtChallanNo";
            this.txtChallanNo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChallanNo.Properties.Appearance.Options.UseFont = true;
            this.txtChallanNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtChallanNo.Size = new System.Drawing.Size(84, 22);
            this.txtChallanNo.TabIndex = 27;
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.EditValue = null;
            this.dtpOrderDate.Location = new System.Drawing.Point(76, 34);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dtpOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpOrderDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpOrderDate.Size = new System.Drawing.Size(84, 22);
            this.dtpOrderDate.TabIndex = 28;
            // 
            // ChkPrintAfterSave
            // 
            this.ChkPrintAfterSave.AutoSize = true;
            this.ChkPrintAfterSave.Checked = true;
            this.ChkPrintAfterSave.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkPrintAfterSave.Location = new System.Drawing.Point(81, 169);
            this.ChkPrintAfterSave.Name = "ChkPrintAfterSave";
            this.ChkPrintAfterSave.Size = new System.Drawing.Size(113, 18);
            this.ChkPrintAfterSave.TabIndex = 28;
            this.ChkPrintAfterSave.Text = "Print After Save";
            this.ChkPrintAfterSave.UseVisualStyleBackColor = true;
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(74, 6);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(318, 70);
            this.txtRemark.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(5, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 14);
            this.label17.TabIndex = 0;
            this.label17.Text = "Remark";
            // 
            // panl
            // 
            this.panl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panl.Controls.Add(this.txtHSNCode);
            this.panl.Controls.Add(this.cmbGSTType);
            this.panl.Controls.Add(this.LkpCustomerName);
            this.panl.Controls.Add(this.txtItemName);
            this.panl.Controls.Add(this.slkp_ItemName);
            this.panl.Controls.Add(this.pnlDueDate);
            this.panl.Controls.Add(this.txtAddress);
            this.panl.Controls.Add(this.label8);
            this.panl.Controls.Add(this.label2);
            this.panl.Controls.Add(this.txtCustomerName);
            this.panl.Location = new System.Drawing.Point(-1, 34);
            this.panl.Name = "panl";
            this.panl.Size = new System.Drawing.Size(1001, 81);
            this.panl.TabIndex = 1;
            // 
            // txtHSNCode
            // 
            this.txtHSNCode.Location = new System.Drawing.Point(739, 53);
            this.txtHSNCode.Name = "txtHSNCode";
            this.txtHSNCode.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSNCode.Properties.Appearance.Options.UseFont = true;
            this.txtHSNCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtHSNCode.Size = new System.Drawing.Size(70, 22);
            this.txtHSNCode.TabIndex = 7;
            this.txtHSNCode.Visible = false;
            // 
            // cmbGSTType
            // 
            this.cmbGSTType.Enabled = false;
            this.cmbGSTType.Location = new System.Drawing.Point(419, 35);
            this.cmbGSTType.Name = "cmbGSTType";
            this.cmbGSTType.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGSTType.Properties.Appearance.Options.UseFont = true;
            this.cmbGSTType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbGSTType.Properties.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.cmbGSTType.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbGSTType.Size = new System.Drawing.Size(92, 22);
            this.cmbGSTType.TabIndex = 4;
            // 
            // LkpCustomerName
            // 
            this.LkpCustomerName.Location = new System.Drawing.Point(103, 6);
            this.LkpCustomerName.Margin = new System.Windows.Forms.Padding(1);
            this.LkpCustomerName.Name = "LkpCustomerName";
            this.LkpCustomerName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.LkpCustomerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LkpCustomerName.Properties.View = this.gridView2;
            this.LkpCustomerName.Size = new System.Drawing.Size(310, 22);
            this.LkpCustomerName.TabIndex = 1;
            this.LkpCustomerName.Leave += new System.EventHandler(this.LkpCustomerName_Leave);
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(739, 30);
            this.txtItemName.Margin = new System.Windows.Forms.Padding(1);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Properties.Appearance.Options.UseFont = true;
            this.txtItemName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtItemName.Size = new System.Drawing.Size(261, 22);
            this.txtItemName.TabIndex = 0;
            this.txtItemName.Visible = false;
            this.txtItemName.Validated += new System.EventHandler(this.txtItemName_Validated);
            // 
            // slkp_ItemName
            // 
            this.slkp_ItemName.Location = new System.Drawing.Point(739, 7);
            this.slkp_ItemName.Margin = new System.Windows.Forms.Padding(1);
            this.slkp_ItemName.Name = "slkp_ItemName";
            this.slkp_ItemName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.slkp_ItemName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.slkp_ItemName.Properties.View = this.gridView1;
            this.slkp_ItemName.Size = new System.Drawing.Size(156, 22);
            this.slkp_ItemName.TabIndex = 0;
            this.slkp_ItemName.Visible = false;
            this.slkp_ItemName.Leave += new System.EventHandler(this.slkp_ItemName_Leave);
            this.slkp_ItemName.Validated += new System.EventHandler(this.slkp_ItemName_Validated);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // pnlDueDate
            // 
            this.pnlDueDate.Controls.Add(this.dtpInvDueDate);
            this.pnlDueDate.Controls.Add(this.label7);
            this.pnlDueDate.Controls.Add(this.txtCreditDays);
            this.pnlDueDate.Controls.Add(this.label6);
            this.pnlDueDate.Location = new System.Drawing.Point(523, 4);
            this.pnlDueDate.Name = "pnlDueDate";
            this.pnlDueDate.Size = new System.Drawing.Size(200, 70);
            this.pnlDueDate.TabIndex = 6;
            // 
            // dtpInvDueDate
            // 
            this.dtpInvDueDate.EditValue = null;
            this.dtpInvDueDate.Location = new System.Drawing.Point(81, 31);
            this.dtpInvDueDate.Name = "dtpInvDueDate";
            this.dtpInvDueDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dtpInvDueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpInvDueDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpInvDueDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpInvDueDate.Size = new System.Drawing.Size(100, 22);
            this.dtpInvDueDate.TabIndex = 3;
            this.dtpInvDueDate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpInvDueDate_KeyDown);
            this.dtpInvDueDate.Validated += new System.EventHandler(this.dtpInvDueDate_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(7, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 14);
            this.label7.TabIndex = 2;
            this.label7.Text = "Due Date";
            // 
            // txtCreditDays
            // 
            this.txtCreditDays.Location = new System.Drawing.Point(81, 3);
            this.txtCreditDays.Name = "txtCreditDays";
            this.txtCreditDays.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreditDays.Properties.Appearance.Options.UseFont = true;
            this.txtCreditDays.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCreditDays.Size = new System.Drawing.Size(55, 22);
            this.txtCreditDays.TabIndex = 1;
            this.txtCreditDays.Validated += new System.EventHandler(this.txtCreditDays_Validated);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 14);
            this.label6.TabIndex = 0;
            this.label6.Text = "Credit Days";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(103, 34);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(310, 39);
            this.txtAddress.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 14);
            this.label8.TabIndex = 0;
            this.label8.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(103, 6);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Properties.Appearance.Options.UseFont = true;
            this.txtCustomerName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCustomerName.Size = new System.Drawing.Size(408, 22);
            this.txtCustomerName.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.dtpInvDate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtInvoiceNo);
            this.panel2.Controls.Add(this.lblTotalLevelTax);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.cmbInvoiceType);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbTotalLevelTax);
            this.panel2.Controls.Add(this.cmbBook);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1001, 36);
            this.panel2.TabIndex = 0;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(181, 10);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(34, 14);
            this.label26.TabIndex = 9;
            this.label26.Text = "Book";
            // 
            // dtpInvDate
            // 
            this.dtpInvDate.EditValue = null;
            this.dtpInvDate.Location = new System.Drawing.Point(600, 6);
            this.dtpInvDate.Name = "dtpInvDate";
            this.dtpInvDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dtpInvDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpInvDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpInvDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtpInvDate.Size = new System.Drawing.Size(100, 22);
            this.dtpInvDate.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(518, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Invoice Date";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Location = new System.Drawing.Point(442, 6);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Properties.Appearance.Options.UseFont = true;
            this.txtInvoiceNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtInvoiceNo.Size = new System.Drawing.Size(70, 22);
            this.txtInvoiceNo.TabIndex = 4;
            // 
            // lblTotalLevelTax
            // 
            this.lblTotalLevelTax.AutoSize = true;
            this.lblTotalLevelTax.ForeColor = System.Drawing.Color.Black;
            this.lblTotalLevelTax.Location = new System.Drawing.Point(749, 10);
            this.lblTotalLevelTax.Name = "lblTotalLevelTax";
            this.lblTotalLevelTax.Size = new System.Drawing.Size(27, 14);
            this.lblTotalLevelTax.TabIndex = 7;
            this.lblTotalLevelTax.Text = "Tax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(371, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Invoice No";
            // 
            // cmbInvoiceType
            // 
            this.cmbInvoiceType.Location = new System.Drawing.Point(87, 6);
            this.cmbInvoiceType.Name = "cmbInvoiceType";
            this.cmbInvoiceType.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbInvoiceType.Properties.Appearance.Options.UseFont = true;
            this.cmbInvoiceType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbInvoiceType.Properties.Items.AddRange(new object[] {
            "Credit",
            "Cash"});
            this.cmbInvoiceType.Properties.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.cmbInvoiceType.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbInvoiceType.Size = new System.Drawing.Size(89, 22);
            this.cmbInvoiceType.TabIndex = 2;
            this.cmbInvoiceType.Leave += new System.EventHandler(this.cmbInvoiceType_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice Type";
            // 
            // cmbTotalLevelTax
            // 
            this.cmbTotalLevelTax.Location = new System.Drawing.Point(782, 6);
            this.cmbTotalLevelTax.Name = "cmbTotalLevelTax";
            this.cmbTotalLevelTax.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTotalLevelTax.Properties.Appearance.Options.UseFont = true;
            this.cmbTotalLevelTax.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbTotalLevelTax.Properties.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.cmbTotalLevelTax.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbTotalLevelTax.Properties.NullText = "";
            this.cmbTotalLevelTax.Properties.PopupSizeable = false;
            this.cmbTotalLevelTax.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cmbTotalLevelTax.Size = new System.Drawing.Size(155, 22);
            this.cmbTotalLevelTax.TabIndex = 8;
            this.cmbTotalLevelTax.Leave += new System.EventHandler(this.cmbTotalLevelTax_Leave);
            // 
            // cmbBook
            // 
            this.cmbBook.Location = new System.Drawing.Point(221, 6);
            this.cmbBook.Name = "cmbBook";
            this.cmbBook.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBook.Properties.Appearance.Options.UseFont = true;
            this.cmbBook.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBook.Properties.LookAndFeel.SkinName = "Office 2016 Colorful";
            this.cmbBook.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbBook.Properties.NullText = "";
            this.cmbBook.Properties.PopupSizeable = false;
            this.cmbBook.Properties.View = this.searchLookUpEdit1View;
            this.cmbBook.Size = new System.Drawing.Size(144, 22);
            this.cmbBook.TabIndex = 3;
            this.cmbBook.Leave += new System.EventHandler(this.cmbBook_Leave);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnList);
            this.panelControl1.Controls.Add(this.btnQuit);
            this.panelControl1.Location = new System.Drawing.Point(-1, 625);
            this.panelControl1.LookAndFeel.SkinName = "Office 2010 Silver";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1001, 39);
            this.panelControl1.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(918, 7);
            this.btnSave.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnSave.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(90, 7);
            this.btnList.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnList.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(75, 23);
            this.btnList.TabIndex = 2;
            this.btnList.Text = "&List ( F8 )";
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(9, 7);
            this.btnQuit.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.btnQuit.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(75, 23);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "&Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // FrmInvoiceMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 671);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmInvoiceMst";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Invoice Entry";
            this.Activated += new System.EventHandler(this.FrmCustomerMst_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCustomerMst_FormClosing);
            this.Load += new System.EventHandler(this.FrmCompanyMst_Load);
            this.Shown += new System.EventHandler(this.FrmInvoiceMst_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCompanyMst_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlitemDescription)).EndInit();
            this.pnlitemDescription.ResumeLayout(false);
            this.pnlitemDescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtitemdesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmbUnit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSGSTAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSGSTPer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCGSTAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCGSTPer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIGSTAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIGSTPer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTaxableAMt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscPer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbItemLevelTax.Properties)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNetInvoiceAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOth1AddAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_DiscountAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_PackingAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_FreightAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_SGSTAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_CGSTAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_IGSTAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOth1AddPer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_DiscountPer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_PackingPer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_bf_FreightAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_bf_AddAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_bf_DiscAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTextBox_numeric4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_FreightPer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_SGSTPer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_CGSTPer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_IGSTPer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_bf_freightPer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_bf_AddPer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtT_bf_DiscPer.Properties)).EndInit();
            this.PnlShippingDetails.ResumeLayout(false);
            this.PnlShippingDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransporterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVehicleNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLrNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpChallanDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpChallanDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChallanNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            this.panl.ResumeLayout(false);
            this.panl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHSNCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbGSTType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LkpCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slkp_ItemName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.pnlDueDate.ResumeLayout(false);
            this.pnlDueDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpInvDueDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpInvDueDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreditDays.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomerName.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpInvDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpInvDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInvoiceNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbInvoiceType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbTotalLevelTax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBook.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnQuit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnList;
        private System.Windows.Forms.Label lblTotalLevelTax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private BControls.bComboBox_dx cmbInvoiceType;
        private System.Windows.Forms.Label label4;
        private BControls.bTextBox_text txtInvoiceNo;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.DateEdit dtpInvDate;
        private System.Windows.Forms.Panel panl;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.MemoEdit txtAddress;
        private BControls.bTextBox_text txtCustomerName;
        private System.Windows.Forms.Panel pnlDueDate;
        private BControls.bTextBox_text txtCreditDays;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.DateEdit dtpInvDueDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label9;
        private BControls.bTextBox_numeric txtTotal;
        private BControls.bTextBox_numeric txtT_IGSTAmt;
        private BControls.bTextBox_numeric txtT_IGSTPer;
        private System.Windows.Forms.Label lblT_CGST;
        private System.Windows.Forms.Label lblT_SGST;
        private System.Windows.Forms.Label lbl_aft_freight;
        private BControls.bTextBox_numeric txtT_CGSTPer;
        private BControls.bTextBox_numeric txtT_CGSTAmt;
        private BControls.bTextBox_numeric txtT_SGSTPer;
        private BControls.bTextBox_numeric txtT_SGSTAmt;
        private System.Windows.Forms.Label lbl_aft_Packing;
        private BControls.bTextBox_numeric txtT_FreightPer;
        private BControls.bTextBox_numeric txtT_FreightAmt;
        private System.Windows.Forms.Label lblT_IGST;
        private BControls.bTextBox_numeric txtT_PackingPer;
        private BControls.bTextBox_numeric txtT_PackingAmt;
        private System.Windows.Forms.Label lbl_aft_disc;
        private BControls.bTextBox_numeric txtT_DiscountPer;
        private BControls.bTextBox_numeric txtT_DiscountAmt;
        private BControls.bTextBox_numeric txtNetInvoiceAmt;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private BControls.bTextBox_text txtQty;
        private BControls.bTextBox_text txtRate;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label lblSGSTAmt;
        private System.Windows.Forms.Label lblSGSTPer;
        private System.Windows.Forms.Label lblCGSTAmt;
        private System.Windows.Forms.Label lblCGSTPer;
        private System.Windows.Forms.Label lblIGSTAmt;
        private System.Windows.Forms.Label lblIGSTPer;
        private System.Windows.Forms.Label lblItemLevelTax;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label LblDiscAmt;
        private System.Windows.Forms.Label LblDiscPer;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label3;
        private BControls.bTextBox_text txtItemAmount;
        private BControls.bTextBox_text txtSGSTAmt;
        private BControls.bTextBox_text txtSGSTPer;
        private BControls.bTextBox_text txtCGSTAmt;
        private BControls.bTextBox_text txtCGSTPer;
        private BControls.bTextBox_text txtIGSTAmt;
        private BControls.bTextBox_text txtIGSTPer;
        private BControls.bTextBox_text txtDiscAmt;
        private BControls.bTextBox_text txtDiscPer;
        private BControls.bTextBox_text txtTaxableAMt;
        private BControls.bComboBox_dx CmbUnit;
        private BControls.bTextBox_text txtItemName;
        private DevExpress.XtraEditors.SearchLookUpEdit slkp_ItemName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit LkpCustomerName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private BControls.bComboBox_dx cmbGSTType;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private System.Windows.Forms.DataGridView dgvItems;
        private DevExpress.XtraEditors.LookUpEdit cmbTotalLevelTax;
        private DevExpress.XtraEditors.LookUpEdit cmbItemLevelTax;
        private System.Windows.Forms.CheckBox ChkPrintAfterSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Srno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSNCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxableAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGSTPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGSTPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGSTPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private BControls.bTextBox_text txtChallanNo;
        private System.Windows.Forms.Label label11;
        private BControls.bTextBox_text txtOrderNo;
        private System.Windows.Forms.Label label10;
        private BControls.bTextBox_text txtHSNCode;
        private DevExpress.XtraEditors.DateEdit dtpOrderDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label21;
        private DevExpress.XtraEditors.DateEdit dtpChallanDate;
        private System.Windows.Forms.Panel PnlShippingDetails;
        private System.Windows.Forms.Label label22;
        private BControls.bTextBox_text txtLrNo;
        private System.Windows.Forms.Label label25;
        private BControls.bTextBox_text txtTransporterName;
        private System.Windows.Forms.Label label24;
        private BControls.bTextBox_text txtVehicleNo;
        private System.Windows.Forms.Label label26;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbBook;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblOth1Add;
        private BControls.bTextBox_numeric txtOth1AddPer;
        private BControls.bTextBox_numeric txtOth1AddAmt;
        private DevExpress.XtraEditors.PanelControl pnlitemDescription;
        private DevExpress.XtraEditors.MemoEdit txtitemdesc;
        private System.Windows.Forms.Label label27;
        private BControls.bTextBox_numeric txtT_bf_FreightAmt;
        private BControls.bTextBox_numeric txtT_bf_AddAmt;
        private BControls.bTextBox_numeric txtT_bf_DiscAmt;
        private BControls.bTextBox_numeric bTextBox_numeric4;
        private BControls.bTextBox_numeric txtT_bf_freightPer;
        private BControls.bTextBox_numeric txtT_bf_AddPer;
        private BControls.bTextBox_numeric txtT_bf_DiscPer;
        private System.Windows.Forms.Label lbl_bf_freight;
        private System.Windows.Forms.Label lbl_bf_add;
        private System.Windows.Forms.Label lbl_bf_discount;
        private System.Windows.Forms.Label lblTotal_TaxableAmt;

    }
}