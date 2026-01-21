namespace AssettoCorsaConfigHelper
{
    partial class ConfigHelperForm
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
            findDirectoryButton = new Button();
            directoryTextBox = new TextBox();
            contentDirectoryGroupBox = new GroupBox();
            carEntryListGroupBox = new GroupBox();
            copyCarSelectionButton = new Button();
            carSelectionTextBox = new TextBox();
            carSelectionLabel = new Label();
            carLabel = new Label();
            carSkinLabel = new Label();
            carSkinComboBox = new ComboBox();
            carComboBox = new ComboBox();
            clearEntryListButton = new Button();
            copyEntryListButton = new Button();
            addEntryButton = new Button();
            entryListTextBox = new TextBox();
            contentDirectoryGroupBox.SuspendLayout();
            carEntryListGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // findDirectoryButton
            // 
            findDirectoryButton.Location = new Point(609, 22);
            findDirectoryButton.Name = "findDirectoryButton";
            findDirectoryButton.Size = new Size(75, 23);
            findDirectoryButton.TabIndex = 0;
            findDirectoryButton.Text = "Find...";
            findDirectoryButton.UseVisualStyleBackColor = true;
            // 
            // directoryTextBox
            // 
            directoryTextBox.Location = new Point(11, 22);
            directoryTextBox.Name = "directoryTextBox";
            directoryTextBox.ReadOnly = true;
            directoryTextBox.Size = new Size(592, 23);
            directoryTextBox.TabIndex = 1;
            // 
            // contentDirectoryGroupBox
            // 
            contentDirectoryGroupBox.Controls.Add(directoryTextBox);
            contentDirectoryGroupBox.Controls.Add(findDirectoryButton);
            contentDirectoryGroupBox.Location = new Point(12, 12);
            contentDirectoryGroupBox.Name = "contentDirectoryGroupBox";
            contentDirectoryGroupBox.Size = new Size(696, 61);
            contentDirectoryGroupBox.TabIndex = 2;
            contentDirectoryGroupBox.TabStop = false;
            contentDirectoryGroupBox.Text = "Content Directory";
            // 
            // carEntryListGroupBox
            // 
            carEntryListGroupBox.Controls.Add(copyCarSelectionButton);
            carEntryListGroupBox.Controls.Add(carSelectionTextBox);
            carEntryListGroupBox.Controls.Add(carSelectionLabel);
            carEntryListGroupBox.Controls.Add(carLabel);
            carEntryListGroupBox.Controls.Add(carSkinLabel);
            carEntryListGroupBox.Controls.Add(carSkinComboBox);
            carEntryListGroupBox.Controls.Add(carComboBox);
            carEntryListGroupBox.Controls.Add(clearEntryListButton);
            carEntryListGroupBox.Controls.Add(copyEntryListButton);
            carEntryListGroupBox.Controls.Add(addEntryButton);
            carEntryListGroupBox.Controls.Add(entryListTextBox);
            carEntryListGroupBox.Location = new Point(12, 79);
            carEntryListGroupBox.Name = "carEntryListGroupBox";
            carEntryListGroupBox.Size = new Size(696, 326);
            carEntryListGroupBox.TabIndex = 3;
            carEntryListGroupBox.TabStop = false;
            carEntryListGroupBox.Text = "Car Entry List";
            // 
            // copyCarSelectionButton
            // 
            copyCarSelectionButton.Location = new Point(545, 286);
            copyCarSelectionButton.Name = "copyCarSelectionButton";
            copyCarSelectionButton.Size = new Size(139, 23);
            copyCarSelectionButton.TabIndex = 10;
            copyCarSelectionButton.Text = "Copy To Clipboard";
            copyCarSelectionButton.UseVisualStyleBackColor = true;
            // 
            // carSelectionTextBox
            // 
            carSelectionTextBox.Location = new Point(96, 286);
            carSelectionTextBox.Name = "carSelectionTextBox";
            carSelectionTextBox.ReadOnly = true;
            carSelectionTextBox.Size = new Size(443, 23);
            carSelectionTextBox.TabIndex = 9;
            // 
            // carSelectionLabel
            // 
            carSelectionLabel.AutoSize = true;
            carSelectionLabel.Location = new Point(11, 289);
            carSelectionLabel.Name = "carSelectionLabel";
            carSelectionLabel.Size = new Size(79, 15);
            carSelectionLabel.TabIndex = 8;
            carSelectionLabel.Text = "Car Selection:";
            // 
            // carLabel
            // 
            carLabel.AutoSize = true;
            carLabel.Location = new Point(11, 26);
            carLabel.Name = "carLabel";
            carLabel.Size = new Size(28, 15);
            carLabel.TabIndex = 7;
            carLabel.Text = "Car:";
            // 
            // carSkinLabel
            // 
            carSkinLabel.AutoSize = true;
            carSkinLabel.Location = new Point(373, 26);
            carSkinLabel.Name = "carSkinLabel";
            carSkinLabel.Size = new Size(32, 15);
            carSkinLabel.TabIndex = 6;
            carSkinLabel.Text = "Skin:";
            // 
            // carSkinComboBox
            // 
            carSkinComboBox.FormattingEnabled = true;
            carSkinComboBox.Location = new Point(411, 22);
            carSkinComboBox.Name = "carSkinComboBox";
            carSkinComboBox.Size = new Size(192, 23);
            carSkinComboBox.TabIndex = 5;
            // 
            // carComboBox
            // 
            carComboBox.FormattingEnabled = true;
            carComboBox.Location = new Point(45, 23);
            carComboBox.Name = "carComboBox";
            carComboBox.Size = new Size(322, 23);
            carComboBox.TabIndex = 4;
            // 
            // clearEntryListButton
            // 
            clearEntryListButton.Location = new Point(464, 256);
            clearEntryListButton.Name = "clearEntryListButton";
            clearEntryListButton.Size = new Size(75, 23);
            clearEntryListButton.TabIndex = 3;
            clearEntryListButton.Text = "Clear";
            clearEntryListButton.UseVisualStyleBackColor = true;
            // 
            // copyEntryListButton
            // 
            copyEntryListButton.Location = new Point(545, 256);
            copyEntryListButton.Name = "copyEntryListButton";
            copyEntryListButton.Size = new Size(139, 23);
            copyEntryListButton.TabIndex = 2;
            copyEntryListButton.Text = "Copy To Clipboard";
            copyEntryListButton.UseVisualStyleBackColor = true;
            // 
            // addEntryButton
            // 
            addEntryButton.Location = new Point(609, 23);
            addEntryButton.Name = "addEntryButton";
            addEntryButton.Size = new Size(75, 23);
            addEntryButton.TabIndex = 1;
            addEntryButton.Text = "Add Entry";
            addEntryButton.UseVisualStyleBackColor = true;
            // 
            // entryListTextBox
            // 
            entryListTextBox.Location = new Point(11, 58);
            entryListTextBox.Multiline = true;
            entryListTextBox.Name = "entryListTextBox";
            entryListTextBox.ReadOnly = true;
            entryListTextBox.ScrollBars = ScrollBars.Vertical;
            entryListTextBox.Size = new Size(673, 192);
            entryListTextBox.TabIndex = 0;
            // 
            // ConfigHelperForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 416);
            Controls.Add(carEntryListGroupBox);
            Controls.Add(contentDirectoryGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ConfigHelperForm";
            Text = "AC Entry List Generator";
            contentDirectoryGroupBox.ResumeLayout(false);
            contentDirectoryGroupBox.PerformLayout();
            carEntryListGroupBox.ResumeLayout(false);
            carEntryListGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button findDirectoryButton;
        private TextBox directoryTextBox;
        private GroupBox contentDirectoryGroupBox;
        private GroupBox carEntryListGroupBox;
        private Button clearEntryListButton;
        private Button copyEntryListButton;
        private Button addEntryButton;
        private TextBox entryListTextBox;
        private Label carLabel;
        private Label carSkinLabel;
        private ComboBox carSkinComboBox;
        private ComboBox carComboBox;
        private TextBox carSelectionTextBox;
        private Label carSelectionLabel;
        private Button copyCarSelectionButton;
    }
}
