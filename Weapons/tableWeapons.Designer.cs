
namespace Weapons
{
    partial class tableWeapons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tableWeapons));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCategory = new System.Windows.Forms.Button();
            this.buttonEZRadius = new System.Windows.Forms.Button();
            this.buttonType = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.addWeapons = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.buttondeleteWeapons = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonSummary = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 32);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Weapons type table";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(473, -4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            this.button1.Paint += new System.Windows.Forms.PaintEventHandler(this.button1_Paint);
            // 
            // buttonCategory
            // 
            this.buttonCategory.Location = new System.Drawing.Point(215, 66);
            this.buttonCategory.Name = "buttonCategory";
            this.buttonCategory.Size = new System.Drawing.Size(115, 50);
            this.buttonCategory.TabIndex = 2;
            this.buttonCategory.Text = "Category";
            this.buttonCategory.UseVisualStyleBackColor = true;
            this.buttonCategory.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonCategory_Paint);
            // 
            // buttonEZRadius
            // 
            this.buttonEZRadius.Location = new System.Drawing.Point(351, 66);
            this.buttonEZRadius.Name = "buttonEZRadius";
            this.buttonEZRadius.Size = new System.Drawing.Size(115, 50);
            this.buttonEZRadius.TabIndex = 3;
            this.buttonEZRadius.Text = "EZ Radius";
            this.buttonEZRadius.UseVisualStyleBackColor = true;
            this.buttonEZRadius.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonEZRadius_Paint);
            // 
            // buttonType
            // 
            this.buttonType.Location = new System.Drawing.Point(79, 66);
            this.buttonType.Name = "buttonType";
            this.buttonType.Size = new System.Drawing.Size(115, 50);
            this.buttonType.TabIndex = 4;
            this.buttonType.Text = "Type";
            this.buttonType.UseVisualStyleBackColor = true;
            this.buttonType.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonType_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(509, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(79, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 191);
            this.panel2.TabIndex = 6;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(215, 320);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(105, 45);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // addWeapons
            // 
            this.addWeapons.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addWeapons.FlatAppearance.BorderSize = 3;
            this.addWeapons.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addWeapons.Location = new System.Drawing.Point(36, 113);
            this.addWeapons.Name = "addWeapons";
            this.addWeapons.Size = new System.Drawing.Size(37, 30);
            this.addWeapons.TabIndex = 8;
            this.addWeapons.Text = "1";
            this.addWeapons.UseVisualStyleBackColor = true;
            this.addWeapons.Paint += new System.Windows.Forms.PaintEventHandler(this.addWeapons_Paint);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "end.jpg");
            // 
            // buttondeleteWeapons
            // 
            this.buttondeleteWeapons.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttondeleteWeapons.FlatAppearance.BorderSize = 3;
            this.buttondeleteWeapons.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttondeleteWeapons.Location = new System.Drawing.Point(36, 140);
            this.buttondeleteWeapons.Name = "buttondeleteWeapons";
            this.buttondeleteWeapons.Size = new System.Drawing.Size(37, 30);
            this.buttondeleteWeapons.TabIndex = 9;
            this.buttondeleteWeapons.Text = "2";
            this.buttondeleteWeapons.UseVisualStyleBackColor = true;
            this.buttondeleteWeapons.Paint += new System.Windows.Forms.PaintEventHandler(this.buttondeleteWeapons_Paint);
            // 
            // buttonModify
            // 
            this.buttonModify.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonModify.FlatAppearance.BorderSize = 3;
            this.buttonModify.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModify.Location = new System.Drawing.Point(36, 165);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(37, 30);
            this.buttonModify.TabIndex = 10;
            this.buttonModify.Text = "3";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonModify_Paint);
            // 
            // buttonView
            // 
            this.buttonView.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonView.FlatAppearance.BorderSize = 3;
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonView.Location = new System.Drawing.Point(36, 192);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(37, 30);
            this.buttonView.TabIndex = 11;
            this.buttonView.Text = "4";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonView_Paint);
            // 
            // buttonSummary
            // 
            this.buttonSummary.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSummary.FlatAppearance.BorderSize = 3;
            this.buttonSummary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSummary.Location = new System.Drawing.Point(36, 219);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(37, 30);
            this.buttonSummary.TabIndex = 12;
            this.buttonSummary.Text = "5";
            this.buttonSummary.UseVisualStyleBackColor = true;
            this.buttonSummary.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonSummary_Paint);
            // 
            // buttonPrint
            // 
            this.buttonPrint.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonPrint.FlatAppearance.BorderSize = 3;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPrint.Location = new System.Drawing.Point(36, 246);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(37, 30);
            this.buttonPrint.TabIndex = 13;
            this.buttonPrint.Text = "6";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Paint += new System.Windows.Forms.PaintEventHandler(this.buttonPrint_Paint);
            // 
            // tableWeapons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(509, 377);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonSummary);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttondeleteWeapons);
            this.Controls.Add(this.addWeapons);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonType);
            this.Controls.Add(this.buttonEZRadius);
            this.Controls.Add(this.buttonCategory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "tableWeapons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weapons type table";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCategory;
        private System.Windows.Forms.Button buttonEZRadius;
        private System.Windows.Forms.Button buttonType;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button addWeapons;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button buttondeleteWeapons;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonSummary;
        private System.Windows.Forms.Button buttonPrint;
    }
}

