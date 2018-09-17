namespace Inv
{
    partial class FrmReceiptEntry
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
            this.txtReceivedAmt = new BControls.bTextBox_numeric();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReceiptAmt = new BControls.bTextBox_numeric();
            this.dgvBills = new System.Windows.Forms.DataGridView();
            this.dtpChqDate = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRefNo = new BControls.bTextBox_text();
            this.LkpCashBankAcc = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.LkpCustomerName = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnList = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            this.dtpRecptDate = new DevExpress.XtraEditors.DateEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReceiptNo = new BControls.bTextBox_text();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OptAgaintBill = new System.Windows.Forms.RadioButton();
            this.OptAdvance = new System.Windows.Forms.RadioButton();
            this.Srno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BillAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecvAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceivedAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptAmt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpChqDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpChqDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRefNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LkpCashBankAcc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LkpCustomerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRecptDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRecptDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptNo.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtReceivedAmt);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtReceiptAmt);
            this.panel1.Controls.Add(this.dgvBills);
            this.panel1.Controls.Add(this.dtpChqDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtRefNo);
            this.panel1.Controls.Add(this.LkpCashBankAcc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LkpCustomerName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.panelControl1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 465);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtReceivedAmt
            // 
            this.txtReceivedAmt.Enabled = false;
            this.txtReceivedAmt.Location = new System.Drawing.Point(539, 395);
            this.txtReceivedAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtReceivedAmt.Name = "txtReceivedAmt";
            this.txtReceivedAmt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceivedAmt.Properties.Appearance.Options.UseFont = true;
            this.txtReceivedAmt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtReceivedAmt.Properties.Mask.EditMask = "n";
            this.txtReceivedAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtReceivedAmt.Properties.NullText = "0";
            this.txtReceivedAmt.Properties.NullValuePrompt = "0";
            this.txtReceivedAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtReceivedAmt.Size = new System.Drawing.Size(100, 22);
            this.txtReceivedAmt.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(422, 398);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 14);
            this.label7.TabIndex = 13;
            this.label7.Text = "Received Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(9, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Receipt Amount";
            // 
            // txtReceiptAmt
            // 
            this.txtReceiptAmt.Location = new System.Drawing.Point(109, 109);
            this.txtReceiptAmt.Margin = new System.Windows.Forms.Padding(1);
            this.txtReceiptAmt.Name = "txtReceiptAmt";
            this.txtReceiptAmt.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptAmt.Properties.Appearance.Options.UseFont = true;
            this.txtReceiptAmt.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtReceiptAmt.Properties.Mask.EditMask = "n";
            this.txtReceiptAmt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtReceiptAmt.Properties.NullText = "0";
            this.txtReceiptAmt.Properties.NullValuePrompt = "0";
            this.txtReceiptAmt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtReceiptAmt.Size = new System.Drawing.Size(100, 22);
            this.txtReceiptAmt.TabIndex = 7;
            this.txtReceiptAmt.EditValueChanged += new System.EventHandler(this.txtReceiptAmt_EditValueChanged);
            // 
            // dgvBills
            // 
            this.dgvBills.AllowUserToAddRows = false;
            this.dgvBills.AllowUserToDeleteRows = false;
            this.dgvBills.AllowUserToOrderColumns = true;
            this.dgvBills.AllowUserToResizeRows = false;
            this.dgvBills.BackgroundColor = System.Drawing.Color.White;
            this.dgvBills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBills.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Srno,
            this.BillNo,
            this.BillDate,
            this.BillAmount,
            this.RecvAmount,
            this.DiscAmount,
            this.DueAmount});
            this.dgvBills.Location = new System.Drawing.Point(-1, 137);
            this.dgvBills.Name = "dgvBills";
            this.dgvBills.RowHeadersVisible = false;
            this.dgvBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBills.Size = new System.Drawing.Size(644, 250);
            this.dgvBills.TabIndex = 12;
            this.dgvBills.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBills_CellValueChanged);
            this.dgvBills.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBills_KeyDown);
            // 
            // dtpChqDate
            // 
            this.dtpChqDate.EditValue = null;
            this.dtpChqDate.Location = new System.Drawing.Point(503, 109);
            this.dtpChqDate.Name = "dtpChqDate";
            this.dtpChqDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dtpChqDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpChqDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpChqDate.Size = new System.Drawing.Size(100, 22);
            this.dtpChqDate.TabIndex = 11;
            this.dtpChqDate.Leave += new System.EventHandler(this.dtpChqDate_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(439, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Chq Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(227, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ref / Chq No";
            // 
            // txtRefNo
            // 
            this.txtRefNo.Location = new System.Drawing.Point(311, 109);
            this.txtRefNo.Name = "txtRefNo";
            this.txtRefNo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefNo.Properties.Appearance.Options.UseFont = true;
            this.txtRefNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtRefNo.Size = new System.Drawing.Size(117, 22);
            this.txtRefNo.TabIndex = 9;
            // 
            // LkpCashBankAcc
            // 
            this.LkpCashBankAcc.Location = new System.Drawing.Point(109, 75);
            this.LkpCashBankAcc.Margin = new System.Windows.Forms.Padding(1);
            this.LkpCashBankAcc.Name = "LkpCashBankAcc";
            this.LkpCashBankAcc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.LkpCashBankAcc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LkpCashBankAcc.Properties.View = this.gridView1;
            this.LkpCashBankAcc.Size = new System.Drawing.Size(310, 22);
            this.LkpCashBankAcc.TabIndex = 5;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cash / Bank";
            // 
            // LkpCustomerName
            // 
            this.LkpCustomerName.Location = new System.Drawing.Point(109, 45);
            this.LkpCustomerName.Margin = new System.Windows.Forms.Padding(1);
            this.LkpCustomerName.Name = "LkpCustomerName";
            this.LkpCustomerName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.LkpCustomerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LkpCustomerName.Properties.View = this.gridView2;
            this.LkpCustomerName.Size = new System.Drawing.Size(310, 22);
            this.LkpCustomerName.TabIndex = 3;
            this.LkpCustomerName.Leave += new System.EventHandler(this.LkpCustomerName_Leave);
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 14);
            this.label8.TabIndex = 2;
            this.label8.Text = "Customer Name";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSave);
            this.panelControl1.Controls.Add(this.btnList);
            this.panelControl1.Controls.Add(this.btnQuit);
            this.panelControl1.Location = new System.Drawing.Point(-1, 425);
            this.panelControl1.LookAndFeel.SkinName = "Office 2010 Silver";
            this.panelControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(644, 39);
            this.panelControl1.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(560, 7);
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
            this.btnList.Location = new System.Drawing.Point(90, 8);
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
            // dtpRecptDate
            // 
            this.dtpRecptDate.EditValue = null;
            this.dtpRecptDate.Location = new System.Drawing.Point(230, 6);
            this.dtpRecptDate.Name = "dtpRecptDate";
            this.dtpRecptDate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            this.dtpRecptDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpRecptDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpRecptDate.Size = new System.Drawing.Size(100, 22);
            this.dtpRecptDate.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(148, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 14);
            this.label5.TabIndex = 2;
            this.label5.Text = "Receipt Date";
            // 
            // txtReceiptNo
            // 
            this.txtReceiptNo.Location = new System.Drawing.Point(72, 6);
            this.txtReceiptNo.Name = "txtReceiptNo";
            this.txtReceiptNo.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptNo.Properties.Appearance.Options.UseFont = true;
            this.txtReceiptNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtReceiptNo.Size = new System.Drawing.Size(70, 22);
            this.txtReceiptNo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(1, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Receipt No";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.OptAgaintBill);
            this.panel2.Controls.Add(this.OptAdvance);
            this.panel2.Controls.Add(this.dtpRecptDate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtReceiptNo);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 36);
            this.panel2.TabIndex = 0;
            // 
            // OptAgaintBill
            // 
            this.OptAgaintBill.AutoSize = true;
            this.OptAgaintBill.Checked = true;
            this.OptAgaintBill.Location = new System.Drawing.Point(405, 7);
            this.OptAgaintBill.Name = "OptAgaintBill";
            this.OptAgaintBill.Size = new System.Drawing.Size(82, 18);
            this.OptAgaintBill.TabIndex = 4;
            this.OptAgaintBill.TabStop = true;
            this.OptAgaintBill.Text = "Against Bill";
            this.OptAgaintBill.UseVisualStyleBackColor = true;
            // 
            // OptAdvance
            // 
            this.OptAdvance.AutoSize = true;
            this.OptAdvance.Location = new System.Drawing.Point(493, 7);
            this.OptAdvance.Name = "OptAdvance";
            this.OptAdvance.Size = new System.Drawing.Size(72, 18);
            this.OptAdvance.TabIndex = 5;
            this.OptAdvance.Text = "Advance";
            this.OptAdvance.UseVisualStyleBackColor = true;
            // 
            // Srno
            // 
            this.Srno.HeaderText = "SrNo";
            this.Srno.Name = "Srno";
            this.Srno.ReadOnly = true;
            this.Srno.Width = 35;
            // 
            // BillNo
            // 
            this.BillNo.HeaderText = "BillNo";
            this.BillNo.Name = "BillNo";
            this.BillNo.ReadOnly = true;
            this.BillNo.Width = 80;
            // 
            // BillDate
            // 
            this.BillDate.HeaderText = "BillDate";
            this.BillDate.Name = "BillDate";
            this.BillDate.ReadOnly = true;
            // 
            // BillAmount
            // 
            this.BillAmount.HeaderText = "BillAmount";
            this.BillAmount.Name = "BillAmount";
            this.BillAmount.ReadOnly = true;
            // 
            // RecvAmount
            // 
            this.RecvAmount.HeaderText = "RecvAmount";
            this.RecvAmount.Name = "RecvAmount";
            // 
            // DiscAmount
            // 
            this.DiscAmount.HeaderText = "DiscAmount";
            this.DiscAmount.Name = "DiscAmount";
            // 
            // DueAmount
            // 
            this.DueAmount.HeaderText = "DueAmount";
            this.DueAmount.Name = "DueAmount";
            this.DueAmount.ReadOnly = true;
            // 
            // FrmReceiptEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 471);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmReceiptEntry";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt Entry";
            this.Load += new System.EventHandler(this.FrmCompanyMst_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCompanyMst_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceivedAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptAmt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpChqDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpChqDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRefNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LkpCashBankAcc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LkpCustomerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpRecptDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRecptDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReceiptNo.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnQuit;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnList;
        private DevExpress.XtraEditors.DateEdit dtpRecptDate;
        private System.Windows.Forms.Label label5;
        private BControls.bTextBox_text txtReceiptNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton OptAgaintBill;
        private System.Windows.Forms.RadioButton OptAdvance;
        private DevExpress.XtraEditors.SearchLookUpEdit LkpCustomerName;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.SearchLookUpEdit LkpCashBankAcc;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit dtpChqDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private BControls.bTextBox_text txtRefNo;
        private System.Windows.Forms.DataGridView dgvBills;
        private BControls.bTextBox_numeric txtReceiptAmt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private BControls.bTextBox_numeric txtReceivedAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Srno;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecvAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueAmount;

    }
}