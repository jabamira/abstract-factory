namespace abstr_Fabric
{
    partial class main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Shape_comboBox = new ComboBox();
            panel1 = new Panel();
            Draw_btn = new Button();
            Size_textBox = new TextBox();
            Size_label = new Label();
            Color_label = new Label();
            Color_comboBox = new ComboBox();
            Shape_label = new Label();
            Y_trackBar = new TrackBar();
            X_trackBar = new TrackBar();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Y_trackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)X_trackBar).BeginInit();
            SuspendLayout();
            // 
            // Shape_comboBox
            // 
            Shape_comboBox.FormattingEnabled = true;
            Shape_comboBox.Location = new Point(208, 27);
            Shape_comboBox.Name = "Shape_comboBox";
            Shape_comboBox.Size = new Size(121, 23);
            Shape_comboBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(Draw_btn);
            panel1.Controls.Add(Size_textBox);
            panel1.Controls.Add(Size_label);
            panel1.Controls.Add(Color_label);
            panel1.Controls.Add(Color_comboBox);
            panel1.Controls.Add(Shape_label);
            panel1.Controls.Add(Shape_comboBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 79);
            panel1.TabIndex = 1;
            // 
            // Draw_btn
            // 
            Draw_btn.Location = new Point(628, 13);
            Draw_btn.Name = "Draw_btn";
            Draw_btn.Size = new Size(83, 49);
            Draw_btn.TabIndex = 7;
            Draw_btn.Text = "Draw";
            Draw_btn.UseVisualStyleBackColor = true;
            Draw_btn.Click += Draw_btn_Click;
            // 
            // Size_textBox
            // 
            Size_textBox.Location = new Point(476, 27);
            Size_textBox.Name = "Size_textBox";
            Size_textBox.Size = new Size(100, 23);
            Size_textBox.TabIndex = 6;
            Size_textBox.TextChanged += Size_textBox_TextChanged;
            // 
            // Size_label
            // 
            Size_label.AutoSize = true;
            Size_label.Location = new Point(476, 9);
            Size_label.Name = "Size_label";
            Size_label.Size = new Size(27, 15);
            Size_label.TabIndex = 5;
            Size_label.Text = "Size";
            // 
            // Color_label
            // 
            Color_label.AutoSize = true;
            Color_label.Location = new Point(335, 9);
            Color_label.Name = "Color_label";
            Color_label.Size = new Size(36, 15);
            Color_label.TabIndex = 3;
            Color_label.Text = "Color";
            // 
            // Color_comboBox
            // 
            Color_comboBox.FormattingEnabled = true;
            Color_comboBox.Location = new Point(335, 27);
            Color_comboBox.Name = "Color_comboBox";
            Color_comboBox.Size = new Size(121, 23);
            Color_comboBox.TabIndex = 2;
            // 
            // Shape_label
            // 
            Shape_label.AutoSize = true;
            Shape_label.Location = new Point(208, 9);
            Shape_label.Name = "Shape_label";
            Shape_label.Size = new Size(39, 15);
            Shape_label.TabIndex = 1;
            Shape_label.Text = "Shape";
            // 
            // Y_trackBar
            // 
            Y_trackBar.Location = new Point(39, 85);
            Y_trackBar.Maximum = 550;
            Y_trackBar.Minimum = 230;
            Y_trackBar.Name = "Y_trackBar";
            Y_trackBar.Orientation = Orientation.Vertical;
            Y_trackBar.RightToLeft = RightToLeft.Yes;
            Y_trackBar.Size = new Size(45, 302);
            Y_trackBar.TabIndex = 5;
            Y_trackBar.Value = 230;
            // 
            // X_trackBar
            // 
            X_trackBar.Location = new Point(69, 393);
            X_trackBar.Maximum = 770;
            X_trackBar.Minimum = 85;
            X_trackBar.Name = "X_trackBar";
            X_trackBar.Size = new Size(731, 45);
            X_trackBar.SmallChange = 50;
            X_trackBar.TabIndex = 4;
            X_trackBar.Value = 85;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 372);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 4;
            label3.Text = "Y";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 423);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 6;
            label4.Text = "X";
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Y_trackBar);
            Controls.Add(panel1);
            Controls.Add(X_trackBar);
            Name = "main";
            Text = "Main";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Y_trackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)X_trackBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox Shape_comboBox;
        private Panel panel1;
        private Label Shape_label;
        private TrackBar X_trackBar;
        private Label Color_label;
        private ComboBox Color_comboBox;
        private TrackBar Y_trackBar;
        private Label label3;
        private Label label4;
        private Label Size_label;
        private TextBox Size_textBox;
        private Button Draw_btn;
    }
}
