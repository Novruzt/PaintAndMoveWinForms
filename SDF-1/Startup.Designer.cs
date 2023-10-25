namespace SDF_1
{
    partial class Startup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            labelSize = new Label();
            textBoxSize = new TextBox();
            textBoxGuide = new TextBox();
            LabelComponent = new Label();
            textBoxInput = new TextBox();
            BtnCreate = new Button();
            labelFigureType = new Label();
            comboBoxItemType = new ComboBox();
            textBoxSpeed = new TextBox();
            labelSpeed = new Label();
            SuspendLayout();
            // 
            // labelSize
            // 
            labelSize.AutoSize = true;
            labelSize.Location = new Point(19, 189);
            labelSize.Name = "labelSize";
            labelSize.Size = new Size(199, 20);
            labelSize.TabIndex = 17;
            labelSize.Text = "Area and Perimeter of Figure";
            // 
            // textBoxSize
            // 
            textBoxSize.BackColor = SystemColors.HotTrack;
            textBoxSize.ForeColor = SystemColors.InactiveBorder;
            textBoxSize.Location = new Point(255, 169);
            textBoxSize.Multiline = true;
            textBoxSize.Name = "textBoxSize";
            textBoxSize.ReadOnly = true;
            textBoxSize.Size = new Size(359, 123);
            textBoxSize.TabIndex = 15;
            textBoxSize.Text = "Area and Perimeter will be seen after figure is created properly.";
            // 
            // textBoxGuide
            // 
            textBoxGuide.BackColor = SystemColors.HotTrack;
            textBoxGuide.ForeColor = SystemColors.InactiveBorder;
            textBoxGuide.Location = new Point(5, 298);
            textBoxGuide.Multiline = true;
            textBoxGuide.Name = "textBoxGuide";
            textBoxGuide.ReadOnly = true;
            textBoxGuide.Size = new Size(446, 352);
            textBoxGuide.TabIndex = 16;
            textBoxGuide.Text = resources.GetString("textBoxGuide.Text");
            // 
            // LabelComponent
            // 
            LabelComponent.AutoSize = true;
            LabelComponent.Location = new Point(24, 65);
            LabelComponent.Name = "LabelComponent";
            LabelComponent.Size = new Size(194, 20);
            LabelComponent.TabIndex = 14;
            LabelComponent.Text = "Initalize Figure Components";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(255, 65);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(359, 27);
            textBoxInput.TabIndex = 13;
            // 
            // BtnCreate
            // 
            BtnCreate.Location = new Point(327, 665);
            BtnCreate.Name = "BtnCreate";
            BtnCreate.Size = new Size(94, 29);
            BtnCreate.TabIndex = 12;
            BtnCreate.Text = "Create Figure";
            BtnCreate.UseVisualStyleBackColor = true;
            BtnCreate.Click += BtnCreate_Click;
            // 
            // labelFigureType
            // 
            labelFigureType.AutoSize = true;
            labelFigureType.Location = new Point(24, 9);
            labelFigureType.Name = "labelFigureType";
            labelFigureType.Size = new Size(138, 20);
            labelFigureType.TabIndex = 11;
            labelFigureType.Text = "Choose Figure Type";
            // 
            // comboBoxItemType
            // 
            comboBoxItemType.FormattingEnabled = true;
            comboBoxItemType.Location = new Point(255, 9);
            comboBoxItemType.Name = "comboBoxItemType";
            comboBoxItemType.Size = new Size(359, 28);
            comboBoxItemType.TabIndex = 10;
            // 
            // textBoxSpeed
            // 
            textBoxSpeed.Location = new Point(255, 118);
            textBoxSpeed.Name = "textBoxSpeed";
            textBoxSpeed.Size = new Size(359, 27);
            textBoxSpeed.TabIndex = 19;
            // 
            // labelSpeed
            // 
            labelSpeed.AutoSize = true;
            labelSpeed.Location = new Point(24, 121);
            labelSpeed.Name = "labelSpeed";
            labelSpeed.Size = new Size(114, 20);
            labelSpeed.TabIndex = 18;
            labelSpeed.Text = "Speed of Figure";
            // 
            // Startup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1031, 695);
            Controls.Add(labelSize);
            Controls.Add(textBoxSize);
            Controls.Add(textBoxGuide);
            Controls.Add(LabelComponent);
            Controls.Add(textBoxInput);
            Controls.Add(BtnCreate);
            Controls.Add(labelFigureType);
            Controls.Add(comboBoxItemType);
            Controls.Add(textBoxSpeed);
            Controls.Add(labelSpeed);
            MaximizeBox = false;
            Name = "Startup";
            Text = "Startup";
            Load += Startup_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSize;
        private TextBox textBoxSize;
        private TextBox textBoxGuide;
        private Label LabelComponent;
        private TextBox textBoxInput;
        private Button BtnCreate;
        private Label labelFigureType;
        private ComboBox comboBoxItemType;
        private TextBox textBoxSpeed;
        private Label labelSpeed;
    }
}