namespace WhiteBoard
{
    partial class WhiteBoard
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

        /// <summary>
        /// Adds the ink canvas to the form.
        /// </summary>
        private void InitializeCanvas()
        {
            // Initialize the canvas,
            canvas = new System.Windows.Controls.InkCanvas();

            // Create a host to hold the canvas.
            var host = new System.Windows.Forms.Integration.ElementHost();

            // Add the canvas to the host.
            host.Child = canvas;

            // Add the host to the drawing panel.
            drawingPanel.Controls.Add(host);

            // Set the host's size and anchor it.
            host.Size = drawingPanel.Size;
            host.Anchor = drawingPanel.Anchor;

            // Define event listeners for the Stylus's button presses.
            canvas.StylusButtonDown += Canvas_StylusButtonDown;
            canvas.StylusButtonUp += Canvas_StylusButtonUp;

            // Define event listeners for touch in order to prevent touch input from editing ink.
            canvas.PreviewTouchDown += Canvas_PreviewTouchDown;
            canvas.PreviewTouchUp += Canvas_PreviewTouchUp;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhiteBoard));
            this.drawingPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.eraseButton = new System.Windows.Forms.Button();
            this.eraseStrokesButton = new System.Windows.Forms.Button();
            this.blackButton = new System.Windows.Forms.Button();
            this.redButton = new System.Windows.Forms.Button();
            this.greenButton = new System.Windows.Forms.Button();
            this.BlueButton = new System.Windows.Forms.Button();
            this.chooseColorButton = new System.Windows.Forms.Button();
            this.strokeWidthPanel = new System.Windows.Forms.Panel();
            this.strokeWidthBar = new System.Windows.Forms.TrackBar();
            this.touchDisabledPanel = new System.Windows.Forms.Panel();
            this.touchDisabledBox = new System.Windows.Forms.CheckBox();
            this.fullScreenToggleButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.strokeWidthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strokeWidthBar)).BeginInit();
            this.touchDisabledPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawingPanel
            // 
            this.drawingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.drawingPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.drawingPanel.Location = new System.Drawing.Point(0, 137);
            this.drawingPanel.Name = "drawingPanel";
            this.drawingPanel.Size = new System.Drawing.Size(1912, 645);
            this.drawingPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Controls.Add(this.ClearButton);
            this.flowLayoutPanel1.Controls.Add(this.eraseButton);
            this.flowLayoutPanel1.Controls.Add(this.eraseStrokesButton);
            this.flowLayoutPanel1.Controls.Add(this.blackButton);
            this.flowLayoutPanel1.Controls.Add(this.redButton);
            this.flowLayoutPanel1.Controls.Add(this.greenButton);
            this.flowLayoutPanel1.Controls.Add(this.BlueButton);
            this.flowLayoutPanel1.Controls.Add(this.chooseColorButton);
            this.flowLayoutPanel1.Controls.Add(this.strokeWidthPanel);
            this.flowLayoutPanel1.Controls.Add(this.touchDisabledPanel);
            this.flowLayoutPanel1.Controls.Add(this.fullScreenToggleButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1912, 138);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.White;
            this.ClearButton.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(3, 3);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(138, 128);
            this.ClearButton.TabIndex = 0;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // eraseButton
            // 
            this.eraseButton.BackColor = System.Drawing.Color.White;
            this.eraseButton.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eraseButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.eraseButton.Location = new System.Drawing.Point(147, 3);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(138, 128);
            this.eraseButton.TabIndex = 5;
            this.eraseButton.Text = "Erase";
            this.eraseButton.UseVisualStyleBackColor = false;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // eraseStrokesButton
            // 
            this.eraseStrokesButton.BackColor = System.Drawing.Color.White;
            this.eraseStrokesButton.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eraseStrokesButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.eraseStrokesButton.Location = new System.Drawing.Point(291, 3);
            this.eraseStrokesButton.Name = "eraseStrokesButton";
            this.eraseStrokesButton.Size = new System.Drawing.Size(138, 128);
            this.eraseStrokesButton.TabIndex = 6;
            this.eraseStrokesButton.Text = "Erase Strokes";
            this.eraseStrokesButton.UseVisualStyleBackColor = false;
            this.eraseStrokesButton.Click += new System.EventHandler(this.eraseStrokesButton_Click);
            // 
            // blackButton
            // 
            this.blackButton.BackColor = System.Drawing.Color.Black;
            this.blackButton.Location = new System.Drawing.Point(435, 3);
            this.blackButton.Name = "blackButton";
            this.blackButton.Size = new System.Drawing.Size(147, 128);
            this.blackButton.TabIndex = 4;
            this.blackButton.UseVisualStyleBackColor = false;
            this.blackButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.blackButton_MouseClick);
            // 
            // redButton
            // 
            this.redButton.BackColor = System.Drawing.Color.Red;
            this.redButton.Location = new System.Drawing.Point(588, 3);
            this.redButton.Name = "redButton";
            this.redButton.Size = new System.Drawing.Size(147, 128);
            this.redButton.TabIndex = 1;
            this.redButton.UseVisualStyleBackColor = false;
            this.redButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.redButton_MouseClick);
            // 
            // greenButton
            // 
            this.greenButton.BackColor = System.Drawing.Color.Green;
            this.greenButton.Location = new System.Drawing.Point(741, 3);
            this.greenButton.Name = "greenButton";
            this.greenButton.Size = new System.Drawing.Size(147, 128);
            this.greenButton.TabIndex = 2;
            this.greenButton.UseVisualStyleBackColor = false;
            this.greenButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.greenButton_MouseClick);
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.Blue;
            this.BlueButton.Location = new System.Drawing.Point(894, 3);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(147, 128);
            this.BlueButton.TabIndex = 10;
            this.BlueButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.blueButton_MouseClick);
            // 
            // chooseColorButton
            // 
            this.chooseColorButton.BackColor = System.Drawing.Color.White;
            this.chooseColorButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseColorButton.Location = new System.Drawing.Point(1047, 3);
            this.chooseColorButton.Name = "chooseColorButton";
            this.chooseColorButton.Size = new System.Drawing.Size(147, 128);
            this.chooseColorButton.TabIndex = 3;
            this.chooseColorButton.Text = "...";
            this.chooseColorButton.UseVisualStyleBackColor = false;
            this.chooseColorButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chooseColorButton_MouseClick);
            // 
            // strokeWidthPanel
            // 
            this.strokeWidthPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.strokeWidthPanel.Controls.Add(this.strokeWidthBar);
            this.strokeWidthPanel.Location = new System.Drawing.Point(1200, 3);
            this.strokeWidthPanel.Name = "strokeWidthPanel";
            this.strokeWidthPanel.Size = new System.Drawing.Size(364, 128);
            this.strokeWidthPanel.TabIndex = 7;
            // 
            // strokeWidthBar
            // 
            this.strokeWidthBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.strokeWidthBar.Location = new System.Drawing.Point(3, 44);
            this.strokeWidthBar.Maximum = 20;
            this.strokeWidthBar.Minimum = 1;
            this.strokeWidthBar.Name = "strokeWidthBar";
            this.strokeWidthBar.Size = new System.Drawing.Size(358, 69);
            this.strokeWidthBar.TabIndex = 0;
            this.strokeWidthBar.Value = 1;
            this.strokeWidthBar.Scroll += new System.EventHandler(this.strokeWidthBar_Scroll);
            // 
            // touchDisabledPanel
            // 
            this.touchDisabledPanel.Controls.Add(this.touchDisabledBox);
            this.touchDisabledPanel.Location = new System.Drawing.Point(1570, 3);
            this.touchDisabledPanel.Name = "touchDisabledPanel";
            this.touchDisabledPanel.Size = new System.Drawing.Size(174, 128);
            this.touchDisabledPanel.TabIndex = 9;
            // 
            // touchDisabledBox
            // 
            this.touchDisabledBox.AutoSize = true;
            this.touchDisabledBox.Checked = true;
            this.touchDisabledBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.touchDisabledBox.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.touchDisabledBox.Location = new System.Drawing.Point(14, 53);
            this.touchDisabledBox.Name = "touchDisabledBox";
            this.touchDisabledBox.Size = new System.Drawing.Size(156, 25);
            this.touchDisabledBox.TabIndex = 0;
            this.touchDisabledBox.Text = "Touch Disabled";
            this.touchDisabledBox.UseVisualStyleBackColor = true;
            // 
            // fullScreenToggleButton
            // 
            this.fullScreenToggleButton.BackColor = System.Drawing.Color.White;
            this.fullScreenToggleButton.Font = new System.Drawing.Font("Segoe UI Black", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullScreenToggleButton.Location = new System.Drawing.Point(1750, 3);
            this.fullScreenToggleButton.Name = "fullScreenToggleButton";
            this.fullScreenToggleButton.Size = new System.Drawing.Size(151, 128);
            this.fullScreenToggleButton.TabIndex = 8;
            this.fullScreenToggleButton.Text = "Full Screen";
            this.fullScreenToggleButton.UseVisualStyleBackColor = false;
            this.fullScreenToggleButton.Click += new System.EventHandler(this.fullScreenToggleButton_Click);
            // 
            // WhiteBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1912, 781);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.drawingPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WhiteBoard";
            this.Text = "WhiteBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanel1.ResumeLayout(false);
            this.strokeWidthPanel.ResumeLayout(false);
            this.strokeWidthPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.strokeWidthBar)).EndInit();
            this.touchDisabledPanel.ResumeLayout(false);
            this.touchDisabledPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Controls.InkCanvas canvas;
        private System.Windows.Forms.Panel drawingPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button redButton;
        private System.Windows.Forms.Button greenButton;
        private System.Windows.Forms.Button chooseColorButton;
        private System.Windows.Forms.Button blackButton;
        private System.Windows.Forms.Button eraseButton;
        private System.Windows.Forms.Button eraseStrokesButton;
        private System.Windows.Forms.Panel strokeWidthPanel;
        private System.Windows.Forms.TrackBar strokeWidthBar;
        private System.Windows.Forms.Button fullScreenToggleButton;
        private System.Windows.Forms.Panel touchDisabledPanel;
        private System.Windows.Forms.CheckBox touchDisabledBox;
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

