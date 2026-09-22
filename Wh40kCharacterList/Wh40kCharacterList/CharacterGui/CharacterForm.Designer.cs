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
        SkillTabControl.SuspendLayout();
        tabPage1.SuspendLayout();
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
        ResumeLayout(false);
    }

    #endregion

    private TabControl SkillTabControl;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Panel panel1;
}