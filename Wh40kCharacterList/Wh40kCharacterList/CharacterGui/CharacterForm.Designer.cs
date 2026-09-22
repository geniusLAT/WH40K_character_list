namespace Wh40kCharacterList.CharacterGui;

partial class CharacterForm : Form
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
        SkillTabControl = new TabControl();
        tabPage1 = new TabPage();
        tabPage2 = new TabPage();
        panel1 = new Panel();
        panel2 = new Panel();
        radioButton1 = new RadioButton();
        radioButton2 = new RadioButton();
        radioButton3 = new RadioButton();
        radioButton4 = new RadioButton();
        SkillTabControl.SuspendLayout();
        tabPage1.SuspendLayout();
        panel2.SuspendLayout();
        SuspendLayout();
        // 
        // SkillTabControl
        // 
        SkillTabControl.Controls.Add(tabPage1);
        SkillTabControl.Controls.Add(tabPage2);
        SkillTabControl.Location = new Point(12, 28);
        SkillTabControl.Name = "SkillTabControl";
        SkillTabControl.SelectedIndex = 0;
        SkillTabControl.Size = new Size(649, 631);
        SkillTabControl.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Controls.Add(panel2);
        tabPage1.Controls.Add(panel1);
        tabPage1.Location = new Point(4, 24);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(641, 603);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "tabPage1";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Location = new Point(4, 24);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(641, 603);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "tabPage2";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // panel1
        // 
        panel1.Location = new Point(6, 127);
        panel1.Name = "panel1";
        panel1.Size = new Size(200, 390);
        panel1.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.Controls.Add(radioButton4);
        panel2.Controls.Add(radioButton3);
        panel2.Controls.Add(radioButton2);
        panel2.Controls.Add(radioButton1);
        panel2.Location = new Point(3, 30);
        panel2.Name = "panel2";
        panel2.Size = new Size(57, 46);
        panel2.TabIndex = 1;
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Location = new Point(3, 30);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(14, 13);
        radioButton1.TabIndex = 0;
        radioButton1.TabStop = true;
        radioButton1.UseVisualStyleBackColor = true;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Location = new Point(15, 30);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(14, 13);
        radioButton2.TabIndex = 1;
        radioButton2.TabStop = true;
        radioButton2.UseVisualStyleBackColor = true;
        // 
        // radioButton3
        // 
        radioButton3.AutoSize = true;
        radioButton3.Location = new Point(27, 30);
        radioButton3.Name = "radioButton3";
        radioButton3.Size = new Size(14, 13);
        radioButton3.TabIndex = 2;
        radioButton3.TabStop = true;
        radioButton3.UseVisualStyleBackColor = true;
        // 
        // radioButton4
        // 
        radioButton4.AutoSize = true;
        radioButton4.Location = new Point(40, 30);
        radioButton4.Name = "radioButton4";
        radioButton4.Size = new Size(14, 13);
        radioButton4.TabIndex = 3;
        radioButton4.TabStop = true;
        radioButton4.UseVisualStyleBackColor = true;
        // 
        // CharacterForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 741);
        Controls.Add(SkillTabControl);
        Name = "CharacterForm";
        Text = "CharacterForm";
        SkillTabControl.ResumeLayout(false);
        tabPage1.ResumeLayout(false);
        panel2.ResumeLayout(false);
        panel2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl SkillTabControl;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Panel panel1;
    private Panel panel2;
    private RadioButton radioButton4;
    private RadioButton radioButton3;
    private RadioButton radioButton2;
    private RadioButton radioButton1;
}