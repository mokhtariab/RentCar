namespace RentCarPrj
{
    partial class SelectPerson_frm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectPerson_frm));
            this.panelEx_Users = new DevComponents.DotNetBar.PanelEx();
            this.btnNew = new DevComponents.DotNetBar.ButtonX();
            this.textBoxName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.textBoxOther = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.dataGridView_SelectPerson = new System.Windows.Forms.DataGridView();
            this.CCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelEx_Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SelectPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEx_Users
            // 
            this.panelEx_Users.CanvasColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelEx_Users.Controls.Add(this.btnNew);
            this.panelEx_Users.Controls.Add(this.textBoxName);
            this.panelEx_Users.Controls.Add(this.textBoxOther);
            this.panelEx_Users.Controls.Add(this.dataGridView_SelectPerson);
            this.panelEx_Users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx_Users.Location = new System.Drawing.Point(0, 0);
            this.panelEx_Users.Margin = new System.Windows.Forms.Padding(0);
            this.panelEx_Users.Name = "panelEx_Users";
            this.panelEx_Users.Padding = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.panelEx_Users.ShowFocusRectangle = true;
            this.panelEx_Users.Size = new System.Drawing.Size(381, 488);
            this.panelEx_Users.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx_Users.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.panelEx_Users.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.CustomizeText;
            this.panelEx_Users.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx_Users.Style.BorderColor.Color = System.Drawing.Color.Olive;
            this.panelEx_Users.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx_Users.Style.GradientAngle = 90;
            this.panelEx_Users.TabIndex = 3;
            // 
            // btnNew
            // 
            this.btnNew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnNew.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnNew.Location = new System.Drawing.Point(10, 11);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(33, 21);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "جدید";
            this.btnNew.Tooltip = "جدید";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.textBoxName.Border.Class = "TextBoxBorder";
            this.textBoxName.ForeColor = System.Drawing.Color.Black;
            this.textBoxName.Location = new System.Drawing.Point(201, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(142, 21);
            this.textBoxName.TabIndex = 14;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBox_Code_TextChanged);
            // 
            // textBoxOther
            // 
            this.textBoxOther.BackColor = System.Drawing.Color.Azure;
            // 
            // 
            // 
            this.textBoxOther.Border.Class = "TextBoxBorder";
            this.textBoxOther.ForeColor = System.Drawing.Color.Black;
            this.textBoxOther.Location = new System.Drawing.Point(53, 12);
            this.textBoxOther.Name = "textBoxOther";
            this.textBoxOther.Size = new System.Drawing.Size(142, 21);
            this.textBoxOther.TabIndex = 13;
            this.textBoxOther.TextChanged += new System.EventHandler(this.textBox_Code_TextChanged);
            // 
            // dataGridView_SelectPerson
            // 
            this.dataGridView_SelectPerson.AllowUserToAddRows = false;
            this.dataGridView_SelectPerson.AllowUserToDeleteRows = false;
            this.dataGridView_SelectPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_SelectPerson.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_SelectPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_SelectPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SelectPerson.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CCode,
            this.CName,
            this.Other});
            this.dataGridView_SelectPerson.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_SelectPerson.Location = new System.Drawing.Point(27, 41);
            this.dataGridView_SelectPerson.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_SelectPerson.Name = "dataGridView_SelectPerson";
            this.dataGridView_SelectPerson.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView_SelectPerson.RowHeadersVisible = false;
            this.dataGridView_SelectPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_SelectPerson.Size = new System.Drawing.Size(327, 422);
            this.dataGridView_SelectPerson.TabIndex = 10;
            this.dataGridView_SelectPerson.DoubleClick += new System.EventHandler(this.dataGridView_SelectPerson_DoubleClick);
            this.dataGridView_SelectPerson.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_SelectPerson_KeyPress);
            // 
            // CCode
            // 
            this.CCode.DataPropertyName = "Code";
            this.CCode.HeaderText = "Code";
            this.CCode.Name = "CCode";
            this.CCode.Visible = false;
            // 
            // CName
            // 
            this.CName.DataPropertyName = "Name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CName.DefaultCellStyle = dataGridViewCellStyle2;
            this.CName.HeaderText = "نام";
            this.CName.Name = "CName";
            this.CName.Width = 152;
            // 
            // Other
            // 
            this.Other.DataPropertyName = "Other";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Other.DefaultCellStyle = dataGridViewCellStyle3;
            this.Other.HeaderText = "موبایل";
            this.Other.Name = "Other";
            this.Other.Width = 151;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            this.errorProvider.RightToLeft = true;
            // 
            // SelectPerson_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 488);
            this.Controls.Add(this.panelEx_Users);
            this.Font = new System.Drawing.Font("Tahoma", 8.150944F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "SelectPerson_frm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowInTaskbar = false;
            this.Text = "انتخاب";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SelectPerson_frm_Load);
            this.panelEx_Users.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SelectPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.PanelEx panelEx_Users;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxName;
        private DevComponents.DotNetBar.Controls.TextBoxX textBoxOther;
        private System.Windows.Forms.DataGridView dataGridView_SelectPerson;
        private DevComponents.DotNetBar.ButtonX btnNew;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other;
    }
}