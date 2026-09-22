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
        WeaponSkillPanel = new Panel();
        WeaponSkillValueLabel = new Label();
        WeaponSkillNameLabel = new Label();
        radioButton4 = new RadioButton();
        radioButton3 = new RadioButton();
        radioButton2 = new RadioButton();
        radioButton1 = new RadioButton();
        panel1 = new Panel();
        tabPage2 = new TabPage();
        BalliticSkillPanel = new Panel();
        BallisticSkillValueLabel = new Label();
        BalliticSkillNameLabel = new Label();
        radioButton5 = new RadioButton();
        radioButton6 = new RadioButton();
        radioButton7 = new RadioButton();
        radioButton8 = new RadioButton();
        StrenghtPanel = new Panel();
        StrenghtValueLabel = new Label();
        StrenghtNameLabel = new Label();
        radioButton9 = new RadioButton();
        radioButton10 = new RadioButton();
        radioButton11 = new RadioButton();
        radioButton12 = new RadioButton();
        ToughnessPanel = new Panel();
        ToughnessValueLabel = new Label();
        ToughnessNameLabel = new Label();
        radioButton13 = new RadioButton();
        radioButton14 = new RadioButton();
        radioButton15 = new RadioButton();
        radioButton16 = new RadioButton();
        AgilityPanel = new Panel();
        AgilityValueLabel = new Label();
        AgilityNameLabel = new Label();
        radioButton17 = new RadioButton();
        radioButton18 = new RadioButton();
        radioButton19 = new RadioButton();
        radioButton20 = new RadioButton();
        IntelligencePanel = new Panel();
        IntelligenceValueLabel = new Label();
        IntelligenceNameLabel = new Label();
        radioButton21 = new RadioButton();
        radioButton22 = new RadioButton();
        radioButton23 = new RadioButton();
        radioButton24 = new RadioButton();
        PerceptionPanel = new Panel();
        PerceptionValueLabel = new Label();
        PerceptionNameLabel = new Label();
        radioButton25 = new RadioButton();
        radioButton26 = new RadioButton();
        radioButton27 = new RadioButton();
        radioButton28 = new RadioButton();
        WillPowerPanel = new Panel();
        WillpowerValueLabel = new Label();
        WillpowerNameLabel = new Label();
        radioButton29 = new RadioButton();
        radioButton30 = new RadioButton();
        radioButton31 = new RadioButton();
        radioButton32 = new RadioButton();
        FellowshipPanel = new Panel();
        FellowShipValueLabel = new Label();
        FellowshipNameLabel = new Label();
        radioButton33 = new RadioButton();
        radioButton34 = new RadioButton();
        radioButton35 = new RadioButton();
        radioButton36 = new RadioButton();
        SkillTabControl.SuspendLayout();
        tabPage1.SuspendLayout();
        WeaponSkillPanel.SuspendLayout();
        BalliticSkillPanel.SuspendLayout();
        StrenghtPanel.SuspendLayout();
        ToughnessPanel.SuspendLayout();
        AgilityPanel.SuspendLayout();
        IntelligencePanel.SuspendLayout();
        PerceptionPanel.SuspendLayout();
        WillPowerPanel.SuspendLayout();
        FellowshipPanel.SuspendLayout();
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
        tabPage1.Controls.Add(FellowshipPanel);
        tabPage1.Controls.Add(WillPowerPanel);
        tabPage1.Controls.Add(PerceptionPanel);
        tabPage1.Controls.Add(IntelligencePanel);
        tabPage1.Controls.Add(AgilityPanel);
        tabPage1.Controls.Add(ToughnessPanel);
        tabPage1.Controls.Add(StrenghtPanel);
        tabPage1.Controls.Add(BalliticSkillPanel);
        tabPage1.Controls.Add(WeaponSkillPanel);
        tabPage1.Controls.Add(panel1);
        tabPage1.Location = new Point(4, 24);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(641, 603);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "Персонаж";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // WeaponSkillPanel
        // 
        WeaponSkillPanel.Controls.Add(WeaponSkillValueLabel);
        WeaponSkillPanel.Controls.Add(WeaponSkillNameLabel);
        WeaponSkillPanel.Controls.Add(radioButton4);
        WeaponSkillPanel.Controls.Add(radioButton3);
        WeaponSkillPanel.Controls.Add(radioButton2);
        WeaponSkillPanel.Controls.Add(radioButton1);
        WeaponSkillPanel.Location = new Point(45, 66);
        WeaponSkillPanel.Name = "WeaponSkillPanel";
        WeaponSkillPanel.Size = new Size(57, 58);
        WeaponSkillPanel.TabIndex = 1;
        // 
        // WeaponSkillValueLabel
        // 
        WeaponSkillValueLabel.AutoSize = true;
        WeaponSkillValueLabel.Font = new Font("Segoe UI", 10F);
        WeaponSkillValueLabel.Location = new Point(16, 20);
        WeaponSkillValueLabel.Name = "WeaponSkillValueLabel";
        WeaponSkillValueLabel.Size = new Size(25, 19);
        WeaponSkillValueLabel.TabIndex = 5;
        WeaponSkillValueLabel.Text = "50";
        // 
        // WeaponSkillNameLabel
        // 
        WeaponSkillNameLabel.AutoSize = true;
        WeaponSkillNameLabel.Font = new Font("Segoe UI", 5F);
        WeaponSkillNameLabel.Location = new Point(3, 0);
        WeaponSkillNameLabel.Name = "WeaponSkillNameLabel";
        WeaponSkillNameLabel.Size = new Size(45, 20);
        WeaponSkillNameLabel.TabIndex = 5;
        WeaponSkillNameLabel.Text = "Навык \r\nрукопашной";
        WeaponSkillNameLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // radioButton4
        // 
        radioButton4.AutoSize = true;
        radioButton4.Location = new Point(40, 42);
        radioButton4.Name = "radioButton4";
        radioButton4.Size = new Size(14, 13);
        radioButton4.TabIndex = 3;
        radioButton4.TabStop = true;
        radioButton4.UseVisualStyleBackColor = true;
        // 
        // radioButton3
        // 
        radioButton3.AutoSize = true;
        radioButton3.Location = new Point(27, 42);
        radioButton3.Name = "radioButton3";
        radioButton3.Size = new Size(14, 13);
        radioButton3.TabIndex = 2;
        radioButton3.TabStop = true;
        radioButton3.UseVisualStyleBackColor = true;
        // 
        // radioButton2
        // 
        radioButton2.AutoSize = true;
        radioButton2.Location = new Point(15, 42);
        radioButton2.Name = "radioButton2";
        radioButton2.Size = new Size(14, 13);
        radioButton2.TabIndex = 1;
        radioButton2.TabStop = true;
        radioButton2.UseVisualStyleBackColor = true;
        // 
        // radioButton1
        // 
        radioButton1.AutoSize = true;
        radioButton1.Location = new Point(3, 42);
        radioButton1.Name = "radioButton1";
        radioButton1.Size = new Size(14, 13);
        radioButton1.TabIndex = 0;
        radioButton1.TabStop = true;
        radioButton1.UseVisualStyleBackColor = true;
        // 
        // panel1
        // 
        panel1.Location = new Point(6, 127);
        panel1.Name = "panel1";
        panel1.Size = new Size(200, 390);
        panel1.TabIndex = 0;
        // 
        // tabPage2
        // 
        tabPage2.Location = new Point(4, 24);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(641, 603);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "Снаряжение";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // BalliticSkillPanel
        // 
        BalliticSkillPanel.Controls.Add(BallisticSkillValueLabel);
        BalliticSkillPanel.Controls.Add(BalliticSkillNameLabel);
        BalliticSkillPanel.Controls.Add(radioButton5);
        BalliticSkillPanel.Controls.Add(radioButton6);
        BalliticSkillPanel.Controls.Add(radioButton7);
        BalliticSkillPanel.Controls.Add(radioButton8);
        BalliticSkillPanel.Location = new Point(105, 66);
        BalliticSkillPanel.Name = "BalliticSkillPanel";
        BalliticSkillPanel.Size = new Size(57, 58);
        BalliticSkillPanel.TabIndex = 6;
        // 
        // BallisticSkillValueLabel
        // 
        BallisticSkillValueLabel.AutoSize = true;
        BallisticSkillValueLabel.Font = new Font("Segoe UI", 10F);
        BallisticSkillValueLabel.Location = new Point(15, 20);
        BallisticSkillValueLabel.Name = "BallisticSkillValueLabel";
        BallisticSkillValueLabel.Size = new Size(25, 19);
        BallisticSkillValueLabel.TabIndex = 5;
        BallisticSkillValueLabel.Text = "50";
        // 
        // BalliticSkillNameLabel
        // 
        BalliticSkillNameLabel.AutoSize = true;
        BalliticSkillNameLabel.Font = new Font("Segoe UI", 5F);
        BalliticSkillNameLabel.Location = new Point(10, 0);
        BalliticSkillNameLabel.Name = "BalliticSkillNameLabel";
        BalliticSkillNameLabel.Size = new Size(36, 20);
        BalliticSkillNameLabel.TabIndex = 5;
        BalliticSkillNameLabel.Text = "Навык \r\nстрельбы";
        BalliticSkillNameLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // radioButton5
        // 
        radioButton5.AutoSize = true;
        radioButton5.Location = new Point(40, 42);
        radioButton5.Name = "radioButton5";
        radioButton5.Size = new Size(14, 13);
        radioButton5.TabIndex = 3;
        radioButton5.TabStop = true;
        radioButton5.UseVisualStyleBackColor = true;
        // 
        // radioButton6
        // 
        radioButton6.AutoSize = true;
        radioButton6.Location = new Point(27, 42);
        radioButton6.Name = "radioButton6";
        radioButton6.Size = new Size(14, 13);
        radioButton6.TabIndex = 2;
        radioButton6.TabStop = true;
        radioButton6.UseVisualStyleBackColor = true;
        // 
        // radioButton7
        // 
        radioButton7.AutoSize = true;
        radioButton7.Location = new Point(15, 42);
        radioButton7.Name = "radioButton7";
        radioButton7.Size = new Size(14, 13);
        radioButton7.TabIndex = 1;
        radioButton7.TabStop = true;
        radioButton7.UseVisualStyleBackColor = true;
        // 
        // radioButton8
        // 
        radioButton8.AutoSize = true;
        radioButton8.Location = new Point(3, 42);
        radioButton8.Name = "radioButton8";
        radioButton8.Size = new Size(14, 13);
        radioButton8.TabIndex = 0;
        radioButton8.TabStop = true;
        radioButton8.UseVisualStyleBackColor = true;
        // 
        // StrenghtPanel
        // 
        StrenghtPanel.Controls.Add(StrenghtValueLabel);
        StrenghtPanel.Controls.Add(StrenghtNameLabel);
        StrenghtPanel.Controls.Add(radioButton9);
        StrenghtPanel.Controls.Add(radioButton10);
        StrenghtPanel.Controls.Add(radioButton11);
        StrenghtPanel.Controls.Add(radioButton12);
        StrenghtPanel.Location = new Point(168, 66);
        StrenghtPanel.Name = "StrenghtPanel";
        StrenghtPanel.Size = new Size(57, 58);
        StrenghtPanel.TabIndex = 7;
        // 
        // StrenghtValueLabel
        // 
        StrenghtValueLabel.AutoSize = true;
        StrenghtValueLabel.Font = new Font("Segoe UI", 10F);
        StrenghtValueLabel.Location = new Point(15, 20);
        StrenghtValueLabel.Name = "StrenghtValueLabel";
        StrenghtValueLabel.Size = new Size(25, 19);
        StrenghtValueLabel.TabIndex = 5;
        StrenghtValueLabel.Text = "50";
        // 
        // StrenghtNameLabel
        // 
        StrenghtNameLabel.AutoSize = true;
        StrenghtNameLabel.Font = new Font("Segoe UI", 5F);
        StrenghtNameLabel.Location = new Point(15, 7);
        StrenghtNameLabel.Name = "StrenghtNameLabel";
        StrenghtNameLabel.Size = new Size(21, 10);
        StrenghtNameLabel.TabIndex = 5;
        StrenghtNameLabel.Text = "Сила";
        StrenghtNameLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // radioButton9
        // 
        radioButton9.AutoSize = true;
        radioButton9.Location = new Point(40, 42);
        radioButton9.Name = "radioButton9";
        radioButton9.Size = new Size(14, 13);
        radioButton9.TabIndex = 3;
        radioButton9.TabStop = true;
        radioButton9.UseVisualStyleBackColor = true;
        // 
        // radioButton10
        // 
        radioButton10.AutoSize = true;
        radioButton10.Location = new Point(27, 42);
        radioButton10.Name = "radioButton10";
        radioButton10.Size = new Size(14, 13);
        radioButton10.TabIndex = 2;
        radioButton10.TabStop = true;
        radioButton10.UseVisualStyleBackColor = true;
        // 
        // radioButton11
        // 
        radioButton11.AutoSize = true;
        radioButton11.Location = new Point(15, 42);
        radioButton11.Name = "radioButton11";
        radioButton11.Size = new Size(14, 13);
        radioButton11.TabIndex = 1;
        radioButton11.TabStop = true;
        radioButton11.UseVisualStyleBackColor = true;
        // 
        // radioButton12
        // 
        radioButton12.AutoSize = true;
        radioButton12.Location = new Point(3, 42);
        radioButton12.Name = "radioButton12";
        radioButton12.Size = new Size(14, 13);
        radioButton12.TabIndex = 0;
        radioButton12.TabStop = true;
        radioButton12.UseVisualStyleBackColor = true;
        // 
        // ToughnessPanel
        // 
        ToughnessPanel.Controls.Add(ToughnessValueLabel);
        ToughnessPanel.Controls.Add(ToughnessNameLabel);
        ToughnessPanel.Controls.Add(radioButton13);
        ToughnessPanel.Controls.Add(radioButton14);
        ToughnessPanel.Controls.Add(radioButton15);
        ToughnessPanel.Controls.Add(radioButton16);
        ToughnessPanel.Location = new Point(228, 66);
        ToughnessPanel.Name = "ToughnessPanel";
        ToughnessPanel.Size = new Size(57, 58);
        ToughnessPanel.TabIndex = 8;
        // 
        // ToughnessValueLabel
        // 
        ToughnessValueLabel.AutoSize = true;
        ToughnessValueLabel.Font = new Font("Segoe UI", 10F);
        ToughnessValueLabel.Location = new Point(15, 20);
        ToughnessValueLabel.Name = "ToughnessValueLabel";
        ToughnessValueLabel.Size = new Size(25, 19);
        ToughnessValueLabel.TabIndex = 5;
        ToughnessValueLabel.Text = "50";
        // 
        // ToughnessNameLabel
        // 
        ToughnessNameLabel.AutoSize = true;
        ToughnessNameLabel.Font = new Font("Segoe UI", 5F);
        ToughnessNameLabel.Location = new Point(3, 7);
        ToughnessNameLabel.Name = "ToughnessNameLabel";
        ToughnessNameLabel.Size = new Size(51, 10);
        ToughnessNameLabel.TabIndex = 5;
        ToughnessNameLabel.Text = "Выносливость";
        ToughnessNameLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // radioButton13
        // 
        radioButton13.AutoSize = true;
        radioButton13.Location = new Point(40, 42);
        radioButton13.Name = "radioButton13";
        radioButton13.Size = new Size(14, 13);
        radioButton13.TabIndex = 3;
        radioButton13.TabStop = true;
        radioButton13.UseVisualStyleBackColor = true;
        // 
        // radioButton14
        // 
        radioButton14.AutoSize = true;
        radioButton14.Location = new Point(27, 42);
        radioButton14.Name = "radioButton14";
        radioButton14.Size = new Size(14, 13);
        radioButton14.TabIndex = 2;
        radioButton14.TabStop = true;
        radioButton14.UseVisualStyleBackColor = true;
        // 
        // radioButton15
        // 
        radioButton15.AutoSize = true;
        radioButton15.Location = new Point(15, 42);
        radioButton15.Name = "radioButton15";
        radioButton15.Size = new Size(14, 13);
        radioButton15.TabIndex = 1;
        radioButton15.TabStop = true;
        radioButton15.UseVisualStyleBackColor = true;
        // 
        // radioButton16
        // 
        radioButton16.AutoSize = true;
        radioButton16.Location = new Point(3, 42);
        radioButton16.Name = "radioButton16";
        radioButton16.Size = new Size(14, 13);
        radioButton16.TabIndex = 0;
        radioButton16.TabStop = true;
        radioButton16.UseVisualStyleBackColor = true;
        // 
        // AgilityPanel
        // 
        AgilityPanel.Controls.Add(AgilityValueLabel);
        AgilityPanel.Controls.Add(AgilityNameLabel);
        AgilityPanel.Controls.Add(radioButton17);
        AgilityPanel.Controls.Add(radioButton18);
        AgilityPanel.Controls.Add(radioButton19);
        AgilityPanel.Controls.Add(radioButton20);
        AgilityPanel.Location = new Point(288, 66);
        AgilityPanel.Name = "AgilityPanel";
        AgilityPanel.Size = new Size(57, 58);
        AgilityPanel.TabIndex = 9;
        // 
        // AgilityValueLabel
        // 
        AgilityValueLabel.AutoSize = true;
        AgilityValueLabel.Font = new Font("Segoe UI", 10F);
        AgilityValueLabel.Location = new Point(15, 20);
        AgilityValueLabel.Name = "AgilityValueLabel";
        AgilityValueLabel.Size = new Size(25, 19);
        AgilityValueLabel.TabIndex = 5;
        AgilityValueLabel.Text = "50";
        // 
        // AgilityNameLabel
        // 
        AgilityNameLabel.AutoSize = true;
        AgilityNameLabel.Font = new Font("Segoe UI", 5F);
        AgilityNameLabel.Location = new Point(9, 7);
        AgilityNameLabel.Name = "AgilityNameLabel";
        AgilityNameLabel.Size = new Size(35, 10);
        AgilityNameLabel.TabIndex = 5;
        AgilityNameLabel.Text = "Ловкость";
        AgilityNameLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // radioButton17
        // 
        radioButton17.AutoSize = true;
        radioButton17.Location = new Point(40, 42);
        radioButton17.Name = "radioButton17";
        radioButton17.Size = new Size(14, 13);
        radioButton17.TabIndex = 3;
        radioButton17.TabStop = true;
        radioButton17.UseVisualStyleBackColor = true;
        // 
        // radioButton18
        // 
        radioButton18.AutoSize = true;
        radioButton18.Location = new Point(27, 42);
        radioButton18.Name = "radioButton18";
        radioButton18.Size = new Size(14, 13);
        radioButton18.TabIndex = 2;
        radioButton18.TabStop = true;
        radioButton18.UseVisualStyleBackColor = true;
        // 
        // radioButton19
        // 
        radioButton19.AutoSize = true;
        radioButton19.Location = new Point(15, 42);
        radioButton19.Name = "radioButton19";
        radioButton19.Size = new Size(14, 13);
        radioButton19.TabIndex = 1;
        radioButton19.TabStop = true;
        radioButton19.UseVisualStyleBackColor = true;
        // 
        // radioButton20
        // 
        radioButton20.AutoSize = true;
        radioButton20.Location = new Point(3, 42);
        radioButton20.Name = "radioButton20";
        radioButton20.Size = new Size(14, 13);
        radioButton20.TabIndex = 0;
        radioButton20.TabStop = true;
        radioButton20.UseVisualStyleBackColor = true;
        // 
        // IntelligencePanel
        // 
        IntelligencePanel.Controls.Add(IntelligenceValueLabel);
        IntelligencePanel.Controls.Add(IntelligenceNameLabel);
        IntelligencePanel.Controls.Add(radioButton21);
        IntelligencePanel.Controls.Add(radioButton22);
        IntelligencePanel.Controls.Add(radioButton23);
        IntelligencePanel.Controls.Add(radioButton24);
        IntelligencePanel.Location = new Point(348, 66);
        IntelligencePanel.Name = "IntelligencePanel";
        IntelligencePanel.Size = new Size(57, 58);
        IntelligencePanel.TabIndex = 10;
        // 
        // IntelligenceValueLabel
        // 
        IntelligenceValueLabel.AutoSize = true;
        IntelligenceValueLabel.Font = new Font("Segoe UI", 10F);
        IntelligenceValueLabel.Location = new Point(15, 20);
        IntelligenceValueLabel.Name = "IntelligenceValueLabel";
        IntelligenceValueLabel.Size = new Size(25, 19);
        IntelligenceValueLabel.TabIndex = 5;
        IntelligenceValueLabel.Text = "50";
        // 
        // IntelligenceNameLabel
        // 
        IntelligenceNameLabel.AutoSize = true;
        IntelligenceNameLabel.Font = new Font("Segoe UI", 5F);
        IntelligenceNameLabel.Location = new Point(9, 7);
        IntelligenceNameLabel.Name = "IntelligenceNameLabel";
        IntelligenceNameLabel.Size = new Size(39, 10);
        IntelligenceNameLabel.TabIndex = 5;
        IntelligenceNameLabel.Text = "Интеллект";
        IntelligenceNameLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // radioButton21
        // 
        radioButton21.AutoSize = true;
        radioButton21.Location = new Point(40, 42);
        radioButton21.Name = "radioButton21";
        radioButton21.Size = new Size(14, 13);
        radioButton21.TabIndex = 3;
        radioButton21.TabStop = true;
        radioButton21.UseVisualStyleBackColor = true;
        // 
        // radioButton22
        // 
        radioButton22.AutoSize = true;
        radioButton22.Location = new Point(27, 42);
        radioButton22.Name = "radioButton22";
        radioButton22.Size = new Size(14, 13);
        radioButton22.TabIndex = 2;
        radioButton22.TabStop = true;
        radioButton22.UseVisualStyleBackColor = true;
        // 
        // radioButton23
        // 
        radioButton23.AutoSize = true;
        radioButton23.Location = new Point(15, 42);
        radioButton23.Name = "radioButton23";
        radioButton23.Size = new Size(14, 13);
        radioButton23.TabIndex = 1;
        radioButton23.TabStop = true;
        radioButton23.UseVisualStyleBackColor = true;
        // 
        // radioButton24
        // 
        radioButton24.AutoSize = true;
        radioButton24.Location = new Point(3, 42);
        radioButton24.Name = "radioButton24";
        radioButton24.Size = new Size(14, 13);
        radioButton24.TabIndex = 0;
        radioButton24.TabStop = true;
        radioButton24.UseVisualStyleBackColor = true;
        // 
        // PerceptionPanel
        // 
        PerceptionPanel.Controls.Add(PerceptionValueLabel);
        PerceptionPanel.Controls.Add(PerceptionNameLabel);
        PerceptionPanel.Controls.Add(radioButton25);
        PerceptionPanel.Controls.Add(radioButton26);
        PerceptionPanel.Controls.Add(radioButton27);
        PerceptionPanel.Controls.Add(radioButton28);
        PerceptionPanel.Location = new Point(408, 66);
        PerceptionPanel.Name = "PerceptionPanel";
        PerceptionPanel.Size = new Size(57, 58);
        PerceptionPanel.TabIndex = 11;
        // 
        // PerceptionValueLabel
        // 
        PerceptionValueLabel.AutoSize = true;
        PerceptionValueLabel.Font = new Font("Segoe UI", 10F);
        PerceptionValueLabel.Location = new Point(15, 20);
        PerceptionValueLabel.Name = "PerceptionValueLabel";
        PerceptionValueLabel.Size = new Size(25, 19);
        PerceptionValueLabel.TabIndex = 5;
        PerceptionValueLabel.Text = "50";
        // 
        // PerceptionNameLabel
        // 
        PerceptionNameLabel.AutoSize = true;
        PerceptionNameLabel.Font = new Font("Segoe UI", 5F);
        PerceptionNameLabel.Location = new Point(9, 7);
        PerceptionNameLabel.Name = "PerceptionNameLabel";
        PerceptionNameLabel.Size = new Size(43, 10);
        PerceptionNameLabel.TabIndex = 5;
        PerceptionNameLabel.Text = "Восприятие";
        PerceptionNameLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // radioButton25
        // 
        radioButton25.AutoSize = true;
        radioButton25.Location = new Point(40, 42);
        radioButton25.Name = "radioButton25";
        radioButton25.Size = new Size(14, 13);
        radioButton25.TabIndex = 3;
        radioButton25.TabStop = true;
        radioButton25.UseVisualStyleBackColor = true;
        // 
        // radioButton26
        // 
        radioButton26.AutoSize = true;
        radioButton26.Location = new Point(27, 42);
        radioButton26.Name = "radioButton26";
        radioButton26.Size = new Size(14, 13);
        radioButton26.TabIndex = 2;
        radioButton26.TabStop = true;
        radioButton26.UseVisualStyleBackColor = true;
        // 
        // radioButton27
        // 
        radioButton27.AutoSize = true;
        radioButton27.Location = new Point(15, 42);
        radioButton27.Name = "radioButton27";
        radioButton27.Size = new Size(14, 13);
        radioButton27.TabIndex = 1;
        radioButton27.TabStop = true;
        radioButton27.UseVisualStyleBackColor = true;
        // 
        // radioButton28
        // 
        radioButton28.AutoSize = true;
        radioButton28.Location = new Point(3, 42);
        radioButton28.Name = "radioButton28";
        radioButton28.Size = new Size(14, 13);
        radioButton28.TabIndex = 0;
        radioButton28.TabStop = true;
        radioButton28.UseVisualStyleBackColor = true;
        // 
        // WillPowerPanel
        // 
        WillPowerPanel.Controls.Add(WillpowerValueLabel);
        WillPowerPanel.Controls.Add(WillpowerNameLabel);
        WillPowerPanel.Controls.Add(radioButton29);
        WillPowerPanel.Controls.Add(radioButton30);
        WillPowerPanel.Controls.Add(radioButton31);
        WillPowerPanel.Controls.Add(radioButton32);
        WillPowerPanel.Location = new Point(468, 66);
        WillPowerPanel.Name = "WillPowerPanel";
        WillPowerPanel.Size = new Size(57, 58);
        WillPowerPanel.TabIndex = 12;
        // 
        // WillpowerValueLabel
        // 
        WillpowerValueLabel.AutoSize = true;
        WillpowerValueLabel.Font = new Font("Segoe UI", 10F);
        WillpowerValueLabel.Location = new Point(15, 20);
        WillpowerValueLabel.Name = "WillpowerValueLabel";
        WillpowerValueLabel.Size = new Size(25, 19);
        WillpowerValueLabel.TabIndex = 5;
        WillpowerValueLabel.Text = "50";
        // 
        // WillpowerNameLabel
        // 
        WillpowerNameLabel.AutoSize = true;
        WillpowerNameLabel.Font = new Font("Segoe UI", 5F);
        WillpowerNameLabel.Location = new Point(15, 0);
        WillpowerNameLabel.Name = "WillpowerNameLabel";
        WillpowerNameLabel.Size = new Size(23, 20);
        WillpowerNameLabel.TabIndex = 5;
        WillpowerNameLabel.Text = "Сила\r\n воли";
        WillpowerNameLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // radioButton29
        // 
        radioButton29.AutoSize = true;
        radioButton29.Location = new Point(40, 42);
        radioButton29.Name = "radioButton29";
        radioButton29.Size = new Size(14, 13);
        radioButton29.TabIndex = 3;
        radioButton29.TabStop = true;
        radioButton29.UseVisualStyleBackColor = true;
        // 
        // radioButton30
        // 
        radioButton30.AutoSize = true;
        radioButton30.Location = new Point(27, 42);
        radioButton30.Name = "radioButton30";
        radioButton30.Size = new Size(14, 13);
        radioButton30.TabIndex = 2;
        radioButton30.TabStop = true;
        radioButton30.UseVisualStyleBackColor = true;
        // 
        // radioButton31
        // 
        radioButton31.AutoSize = true;
        radioButton31.Location = new Point(15, 42);
        radioButton31.Name = "radioButton31";
        radioButton31.Size = new Size(14, 13);
        radioButton31.TabIndex = 1;
        radioButton31.TabStop = true;
        radioButton31.UseVisualStyleBackColor = true;
        // 
        // radioButton32
        // 
        radioButton32.AutoSize = true;
        radioButton32.Location = new Point(3, 42);
        radioButton32.Name = "radioButton32";
        radioButton32.Size = new Size(14, 13);
        radioButton32.TabIndex = 0;
        radioButton32.TabStop = true;
        radioButton32.UseVisualStyleBackColor = true;
        // 
        // FellowshipPanel
        // 
        FellowshipPanel.Controls.Add(FellowShipValueLabel);
        FellowshipPanel.Controls.Add(FellowshipNameLabel);
        FellowshipPanel.Controls.Add(radioButton33);
        FellowshipPanel.Controls.Add(radioButton34);
        FellowshipPanel.Controls.Add(radioButton35);
        FellowshipPanel.Controls.Add(radioButton36);
        FellowshipPanel.Location = new Point(528, 66);
        FellowshipPanel.Name = "FellowshipPanel";
        FellowshipPanel.Size = new Size(57, 58);
        FellowshipPanel.TabIndex = 13;
        // 
        // FellowShipValueLabel
        // 
        FellowShipValueLabel.AutoSize = true;
        FellowShipValueLabel.Font = new Font("Segoe UI", 10F);
        FellowShipValueLabel.Location = new Point(15, 20);
        FellowShipValueLabel.Name = "FellowShipValueLabel";
        FellowShipValueLabel.Size = new Size(25, 19);
        FellowShipValueLabel.TabIndex = 5;
        FellowShipValueLabel.Text = "50";
        // 
        // FellowshipNameLabel
        // 
        FellowshipNameLabel.AutoSize = true;
        FellowshipNameLabel.Font = new Font("Segoe UI", 5F);
        FellowshipNameLabel.Location = new Point(2, 11);
        FellowshipNameLabel.Name = "FellowshipNameLabel";
        FellowshipNameLabel.Size = new Size(53, 10);
        FellowshipNameLabel.TabIndex = 5;
        FellowshipNameLabel.Text = "Товарищество";
        FellowshipNameLabel.TextAlign = ContentAlignment.TopCenter;
        // 
        // radioButton33
        // 
        radioButton33.AutoSize = true;
        radioButton33.Location = new Point(40, 42);
        radioButton33.Name = "radioButton33";
        radioButton33.Size = new Size(14, 13);
        radioButton33.TabIndex = 3;
        radioButton33.TabStop = true;
        radioButton33.UseVisualStyleBackColor = true;
        // 
        // radioButton34
        // 
        radioButton34.AutoSize = true;
        radioButton34.Location = new Point(27, 42);
        radioButton34.Name = "radioButton34";
        radioButton34.Size = new Size(14, 13);
        radioButton34.TabIndex = 2;
        radioButton34.TabStop = true;
        radioButton34.UseVisualStyleBackColor = true;
        // 
        // radioButton35
        // 
        radioButton35.AutoSize = true;
        radioButton35.Location = new Point(15, 42);
        radioButton35.Name = "radioButton35";
        radioButton35.Size = new Size(14, 13);
        radioButton35.TabIndex = 1;
        radioButton35.TabStop = true;
        radioButton35.UseVisualStyleBackColor = true;
        // 
        // radioButton36
        // 
        radioButton36.AutoSize = true;
        radioButton36.Location = new Point(3, 42);
        radioButton36.Name = "radioButton36";
        radioButton36.Size = new Size(14, 13);
        radioButton36.TabIndex = 0;
        radioButton36.TabStop = true;
        radioButton36.UseVisualStyleBackColor = true;
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
        WeaponSkillPanel.ResumeLayout(false);
        WeaponSkillPanel.PerformLayout();
        BalliticSkillPanel.ResumeLayout(false);
        BalliticSkillPanel.PerformLayout();
        StrenghtPanel.ResumeLayout(false);
        StrenghtPanel.PerformLayout();
        ToughnessPanel.ResumeLayout(false);
        ToughnessPanel.PerformLayout();
        AgilityPanel.ResumeLayout(false);
        AgilityPanel.PerformLayout();
        IntelligencePanel.ResumeLayout(false);
        IntelligencePanel.PerformLayout();
        PerceptionPanel.ResumeLayout(false);
        PerceptionPanel.PerformLayout();
        WillPowerPanel.ResumeLayout(false);
        WillPowerPanel.PerformLayout();
        FellowshipPanel.ResumeLayout(false);
        FellowshipPanel.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private TabControl SkillTabControl;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private Panel panel1;
    private Panel WeaponSkillPanel;
    private RadioButton radioButton4;
    private RadioButton radioButton3;
    private RadioButton radioButton2;
    private RadioButton radioButton1;
    private Label WeaponSkillNameLabel;
    private Panel BalliticSkillPanel;
    private Label BalliticSkillNameLabel;
    private RadioButton radioButton5;
    private RadioButton radioButton6;
    private RadioButton radioButton7;
    private RadioButton radioButton8;
    private Panel StrenghtPanel;
    private Label StrenghtNameLabel;
    private RadioButton radioButton9;
    private RadioButton radioButton10;
    private RadioButton radioButton11;
    private RadioButton radioButton12;
    private Panel IntelligencePanel;
    private Label IntelligenceNameLabel;
    private RadioButton radioButton21;
    private RadioButton radioButton22;
    private RadioButton radioButton23;
    private RadioButton radioButton24;
    private Panel AgilityPanel;
    private Label AgilityNameLabel;
    private RadioButton radioButton17;
    private RadioButton radioButton18;
    private RadioButton radioButton19;
    private RadioButton radioButton20;
    private Panel ToughnessPanel;
    private Label ToughnessNameLabel;
    private RadioButton radioButton13;
    private RadioButton radioButton14;
    private RadioButton radioButton15;
    private RadioButton radioButton16;
    private Panel FellowshipPanel;
    private Label FellowshipNameLabel;
    private RadioButton radioButton33;
    private RadioButton radioButton34;
    private RadioButton radioButton35;
    private RadioButton radioButton36;
    private Panel WillPowerPanel;
    private Label WillpowerNameLabel;
    private RadioButton radioButton29;
    private RadioButton radioButton30;
    private RadioButton radioButton31;
    private RadioButton radioButton32;
    private Panel PerceptionPanel;
    private Label PerceptionNameLabel;
    private RadioButton radioButton25;
    private RadioButton radioButton26;
    private RadioButton radioButton27;
    private RadioButton radioButton28;
    public Label WeaponSkillValueLabel;
    public Label BallisticSkillValueLabel;
    public Label StrenghtValueLabel;
    public Label IntelligenceValueLabel;
    public Label AgilityValueLabel;
    public Label ToughnessValueLabel;
    public Label FellowShipValueLabel;
    public Label WillpowerValueLabel;
    public Label PerceptionValueLabel;
}