namespace Reverse_It
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbTitle = new System.Windows.Forms.Label();
            this.lblTitlePartTwo = new System.Windows.Forms.Label();
            this.lblNineNumbers = new System.Windows.Forms.Label();
            this.tbInputNumber = new System.Windows.Forms.TextBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.lblTooltipInfo = new System.Windows.Forms.Label();
            this.ttGameInfo = new System.Windows.Forms.ToolTip(this.components);
            this.btnRandomiseNumbers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTitle.AutoSize = true;
            this.lbTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbTitle.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(180, 19);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Order me like this!";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitlePartTwo
            // 
            this.lblTitlePartTwo.AutoSize = true;
            this.lblTitlePartTwo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitlePartTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitlePartTwo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePartTwo.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitlePartTwo.Location = new System.Drawing.Point(192, 9);
            this.lblTitlePartTwo.Name = "lblTitlePartTwo";
            this.lblTitlePartTwo.Size = new System.Drawing.Size(198, 19);
            this.lblTitlePartTwo.TabIndex = 1;
            this.lblTitlePartTwo.Text = "[ 1-2-3-4-5-6-7-8-9 ]";
            // 
            // lblNineNumbers
            // 
            this.lblNineNumbers.AutoSize = true;
            this.lblNineNumbers.BackColor = System.Drawing.Color.Transparent;
            this.lblNineNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNineNumbers.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNineNumbers.ForeColor = System.Drawing.Color.Crimson;
            this.lblNineNumbers.Location = new System.Drawing.Point(62, 43);
            this.lblNineNumbers.Name = "lblNineNumbers";
            this.lblNineNumbers.Size = new System.Drawing.Size(262, 24);
            this.lblNineNumbers.TabIndex = 2;
            this.lblNineNumbers.Text = "[ 1-2-3-4-5-6-7-8-9 ]";
            // 
            // tbInputNumber
            // 
            this.tbInputNumber.Location = new System.Drawing.Point(166, 82);
            this.tbInputNumber.Name = "tbInputNumber";
            this.tbInputNumber.Size = new System.Drawing.Size(49, 33);
            this.tbInputNumber.TabIndex = 3;
            this.tbInputNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCreateOrder.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateOrder.FlatAppearance.BorderSize = 3;
            this.btnCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateOrder.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnCreateOrder.Location = new System.Drawing.Point(141, 132);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(97, 77);
            this.btnCreateOrder.TabIndex = 4;
            this.btnCreateOrder.Text = "create order";
            this.btnCreateOrder.UseVisualStyleBackColor = false;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // lblTooltipInfo
            // 
            this.lblTooltipInfo.AutoSize = true;
            this.lblTooltipInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblTooltipInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTooltipInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTooltipInfo.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTooltipInfo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTooltipInfo.Location = new System.Drawing.Point(230, 85);
            this.lblTooltipInfo.Name = "lblTooltipInfo";
            this.lblTooltipInfo.Size = new System.Drawing.Size(24, 26);
            this.lblTooltipInfo.TabIndex = 5;
            this.lblTooltipInfo.Text = "?";
            this.lblTooltipInfo.MouseHover += new System.EventHandler(this.lblTooltipInfo_MouseHover);
            // 
            // btnRandomiseNumbers
            // 
            this.btnRandomiseNumbers.BackColor = System.Drawing.Color.Maroon;
            this.btnRandomiseNumbers.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRandomiseNumbers.FlatAppearance.BorderSize = 3;
            this.btnRandomiseNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandomiseNumbers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRandomiseNumbers.Location = new System.Drawing.Point(16, 132);
            this.btnRandomiseNumbers.Name = "btnRandomiseNumbers";
            this.btnRandomiseNumbers.Size = new System.Drawing.Size(97, 77);
            this.btnRandomiseNumbers.TabIndex = 6;
            this.btnRandomiseNumbers.Text = "create chaos";
            this.btnRandomiseNumbers.UseVisualStyleBackColor = false;
            this.btnRandomiseNumbers.Click += new System.EventHandler(this.btnRandomiseNumbers_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.btnCreateOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 221);
            this.Controls.Add(this.btnRandomiseNumbers);
            this.Controls.Add(this.lblTooltipInfo);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.tbInputNumber);
            this.Controls.Add(this.lblNineNumbers);
            this.Controls.Add(this.lblTitlePartTwo);
            this.Controls.Add(this.lbTitle);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Moonbeam", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order in the Universe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lblTitlePartTwo;
        private System.Windows.Forms.Label lblNineNumbers;
        private System.Windows.Forms.TextBox tbInputNumber;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Label lblTooltipInfo;
        private System.Windows.Forms.ToolTip ttGameInfo;
        private System.Windows.Forms.Button btnRandomiseNumbers;
    }
}

