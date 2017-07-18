using System.Windows.Forms;
namespace MainForm
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
        public class OverideListBox : CheckedListBox
        {
            public OverideListBox()
            {
                ItemHeight = 21;
            }
            public override int ItemHeight { get; set; }
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AbilityGrp = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.conScore = new System.Windows.Forms.NumericUpDown();
            this.chaLabel = new System.Windows.Forms.Label();
            this.chaScore = new System.Windows.Forms.NumericUpDown();
            this.wisLabel = new System.Windows.Forms.Label();
            this.dexScore = new System.Windows.Forms.NumericUpDown();
            this.intScore = new System.Windows.Forms.NumericUpDown();
            this.strLabel = new System.Windows.Forms.Label();
            this.wisScore = new System.Windows.Forms.NumericUpDown();
            this.strScore = new System.Windows.Forms.NumericUpDown();
            this.dexLabel = new System.Windows.Forms.Label();
            this.intLabel = new System.Windows.Forms.Label();
            this.conLabel = new System.Windows.Forms.Label();
            this.conModLbl = new System.Windows.Forms.Label();
            this.chaModTot = new System.Windows.Forms.TextBox();
            this.dexModLbl = new System.Windows.Forms.Label();
            this.IntModLbl = new System.Windows.Forms.Label();
            this.wisModTot = new System.Windows.Forms.TextBox();
            this.strModLbl = new System.Windows.Forms.Label();
            this.wisModLbl = new System.Windows.Forms.Label();
            this.intModTot = new System.Windows.Forms.TextBox();
            this.chaModLbl = new System.Windows.Forms.Label();
            this.strModTot = new System.Windows.Forms.TextBox();
            this.conModTot = new System.Windows.Forms.TextBox();
            this.dexModTot = new System.Windows.Forms.TextBox();
            this.AbilityModGroup = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label164 = new System.Windows.Forms.Label();
            this.label163 = new System.Windows.Forms.Label();
            this.label162 = new System.Windows.Forms.Label();
            this.label161 = new System.Windows.Forms.Label();
            this.label160 = new System.Windows.Forms.Label();
            this.label159 = new System.Windows.Forms.Label();
            this.characterDetailsGrp = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ClassLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.RaceCombo = new System.Windows.Forms.ComboBox();
            this.RaceLbl = new System.Windows.Forms.Label();
            this.AlignLbl = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.ClassCombo = new System.Windows.Forms.ComboBox();
            this.GenderLbl = new System.Windows.Forms.Label();
            this.GenderCombo = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TraitsGrp = new System.Windows.Forms.GroupBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.TraitsList = new System.Windows.Forms.ListView();
            this.Trait = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DetailsCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.moveSpdLbl = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.CombatStatesGrp = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label46 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label45 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label165 = new System.Windows.Forms.Label();
            this.label166 = new System.Windows.Forms.Label();
            this.label167 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label168 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label169 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label170 = new System.Windows.Forms.Label();
            this.DamageTaken = new System.Windows.Forms.TextBox();
            this.MHpTb = new System.Windows.Forms.TextBox();
            this.CurrentHP = new System.Windows.Forms.TextBox();
            this.label120 = new System.Windows.Forms.Label();
            this.MHPLbl = new System.Windows.Forms.Label();
            this.label119 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label52 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label63 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.AttBonus = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.ClassSkillsGrp = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.skillList1 = new MainFormPreviewCtls.SkillList();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CombatPreview = new MainFormPreviewCtls.CombatPreview();
            this.inventoryPreview1 = new MainFormPreviewCtls.InventoryPreview();
            this.AbilityGrp.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.intScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisScore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.strScore)).BeginInit();
            this.AbilityModGroup.SuspendLayout();
            this.panel5.SuspendLayout();
            this.characterDetailsGrp.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.TraitsGrp.SuspendLayout();
            this.panel19.SuspendLayout();
            this.CombatStatesGrp.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel18.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ClassSkillsGrp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AbilityGrp
            // 
            this.AbilityGrp.AutoSize = true;
            this.AbilityGrp.Controls.Add(this.panel4);
            this.AbilityGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbilityGrp.Location = new System.Drawing.Point(7, 145);
            this.AbilityGrp.Name = "AbilityGrp";
            this.AbilityGrp.Size = new System.Drawing.Size(169, 208);
            this.AbilityGrp.TabIndex = 0;
            this.AbilityGrp.TabStop = false;
            this.AbilityGrp.Text = "Ablity Score";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.conScore);
            this.panel4.Controls.Add(this.chaLabel);
            this.panel4.Controls.Add(this.chaScore);
            this.panel4.Controls.Add(this.wisLabel);
            this.panel4.Controls.Add(this.dexScore);
            this.panel4.Controls.Add(this.intScore);
            this.panel4.Controls.Add(this.strLabel);
            this.panel4.Controls.Add(this.wisScore);
            this.panel4.Controls.Add(this.strScore);
            this.panel4.Controls.Add(this.dexLabel);
            this.panel4.Controls.Add(this.intLabel);
            this.panel4.Controls.Add(this.conLabel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(163, 183);
            this.panel4.TabIndex = 0;
            // 
            // conScore
            // 
            this.conScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.conScore.Location = new System.Drawing.Point(101, 68);
            this.conScore.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.conScore.Name = "conScore";
            this.conScore.Size = new System.Drawing.Size(39, 23);
            this.conScore.TabIndex = 2;
            this.conScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.conScore.ValueChanged += new System.EventHandler(this.conScore_ValueChanged);
            // 
            // chaLabel
            // 
            this.chaLabel.AutoSize = true;
            this.chaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chaLabel.Location = new System.Drawing.Point(31, 149);
            this.chaLabel.Name = "chaLabel";
            this.chaLabel.Size = new System.Drawing.Size(67, 17);
            this.chaLabel.TabIndex = 10;
            this.chaLabel.Text = "Charisma";
            this.chaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chaScore
            // 
            this.chaScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chaScore.Location = new System.Drawing.Point(101, 146);
            this.chaScore.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.chaScore.Name = "chaScore";
            this.chaScore.Size = new System.Drawing.Size(39, 23);
            this.chaScore.TabIndex = 5;
            this.chaScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chaScore.ValueChanged += new System.EventHandler(this.chaScore_ValueChanged);
            // 
            // wisLabel
            // 
            this.wisLabel.AutoSize = true;
            this.wisLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.wisLabel.Location = new System.Drawing.Point(40, 123);
            this.wisLabel.Name = "wisLabel";
            this.wisLabel.Size = new System.Drawing.Size(58, 17);
            this.wisLabel.TabIndex = 9;
            this.wisLabel.Text = "Wisdom";
            this.wisLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dexScore
            // 
            this.dexScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dexScore.Location = new System.Drawing.Point(101, 42);
            this.dexScore.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.dexScore.Name = "dexScore";
            this.dexScore.Size = new System.Drawing.Size(39, 23);
            this.dexScore.TabIndex = 1;
            this.dexScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dexScore.ValueChanged += new System.EventHandler(this.dexScore_ValueChanged);
            // 
            // intScore
            // 
            this.intScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.intScore.Location = new System.Drawing.Point(101, 94);
            this.intScore.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.intScore.Name = "intScore";
            this.intScore.Size = new System.Drawing.Size(39, 23);
            this.intScore.TabIndex = 3;
            this.intScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.intScore.ValueChanged += new System.EventHandler(this.intScore_ValueChanged);
            // 
            // strLabel
            // 
            this.strLabel.AutoSize = true;
            this.strLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.strLabel.Location = new System.Drawing.Point(36, 19);
            this.strLabel.Name = "strLabel";
            this.strLabel.Size = new System.Drawing.Size(62, 17);
            this.strLabel.TabIndex = 1;
            this.strLabel.Text = "Strength";
            this.strLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wisScore
            // 
            this.wisScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.wisScore.Location = new System.Drawing.Point(101, 120);
            this.wisScore.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.wisScore.Name = "wisScore";
            this.wisScore.Size = new System.Drawing.Size(39, 23);
            this.wisScore.TabIndex = 4;
            this.wisScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wisScore.ValueChanged += new System.EventHandler(this.wisScore_ValueChanged);
            // 
            // strScore
            // 
            this.strScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.strScore.Location = new System.Drawing.Point(101, 16);
            this.strScore.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.strScore.Name = "strScore";
            this.strScore.Size = new System.Drawing.Size(39, 23);
            this.strScore.TabIndex = 0;
            this.strScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.strScore.ValueChanged += new System.EventHandler(this.strScore_ValueChanged);
            // 
            // dexLabel
            // 
            this.dexLabel.AutoSize = true;
            this.dexLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dexLabel.Location = new System.Drawing.Point(35, 45);
            this.dexLabel.Name = "dexLabel";
            this.dexLabel.Size = new System.Drawing.Size(63, 17);
            this.dexLabel.TabIndex = 6;
            this.dexLabel.Text = "Dexterity";
            this.dexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // intLabel
            // 
            this.intLabel.AutoSize = true;
            this.intLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.intLabel.Location = new System.Drawing.Point(19, 97);
            this.intLabel.Name = "intLabel";
            this.intLabel.Size = new System.Drawing.Size(79, 17);
            this.intLabel.TabIndex = 8;
            this.intLabel.Text = "Intelligence";
            this.intLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // conLabel
            // 
            this.conLabel.AutoSize = true;
            this.conLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.conLabel.Location = new System.Drawing.Point(16, 71);
            this.conLabel.Name = "conLabel";
            this.conLabel.Size = new System.Drawing.Size(82, 17);
            this.conLabel.TabIndex = 7;
            this.conLabel.Text = "Constitution";
            this.conLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // conModLbl
            // 
            this.conModLbl.AutoSize = true;
            this.conModLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.conModLbl.Location = new System.Drawing.Point(37, 70);
            this.conModLbl.Name = "conModLbl";
            this.conModLbl.Size = new System.Drawing.Size(38, 17);
            this.conModLbl.TabIndex = 13;
            this.conModLbl.Text = "CON";
            this.conModLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chaModTot
            // 
            this.chaModTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaModTot.Location = new System.Drawing.Point(12, 146);
            this.chaModTot.Name = "chaModTot";
            this.chaModTot.ReadOnly = true;
            this.chaModTot.Size = new System.Drawing.Size(22, 22);
            this.chaModTot.TabIndex = 27;
            this.chaModTot.TabStop = false;
            this.chaModTot.Text = "-5";
            this.chaModTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dexModLbl
            // 
            this.dexModLbl.AutoSize = true;
            this.dexModLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dexModLbl.Location = new System.Drawing.Point(37, 44);
            this.dexModLbl.Name = "dexModLbl";
            this.dexModLbl.Size = new System.Drawing.Size(36, 17);
            this.dexModLbl.TabIndex = 12;
            this.dexModLbl.Text = "DEX";
            this.dexModLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IntModLbl
            // 
            this.IntModLbl.AutoSize = true;
            this.IntModLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.IntModLbl.Location = new System.Drawing.Point(37, 96);
            this.IntModLbl.Name = "IntModLbl";
            this.IntModLbl.Size = new System.Drawing.Size(30, 17);
            this.IntModLbl.TabIndex = 14;
            this.IntModLbl.Text = "INT";
            this.IntModLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wisModTot
            // 
            this.wisModTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wisModTot.Location = new System.Drawing.Point(12, 120);
            this.wisModTot.Name = "wisModTot";
            this.wisModTot.ReadOnly = true;
            this.wisModTot.Size = new System.Drawing.Size(22, 22);
            this.wisModTot.TabIndex = 25;
            this.wisModTot.TabStop = false;
            this.wisModTot.Text = "-5";
            this.wisModTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // strModLbl
            // 
            this.strModLbl.AutoSize = true;
            this.strModLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.strModLbl.Location = new System.Drawing.Point(37, 18);
            this.strModLbl.Name = "strModLbl";
            this.strModLbl.Size = new System.Drawing.Size(36, 17);
            this.strModLbl.TabIndex = 11;
            this.strModLbl.Text = "STR";
            this.strModLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wisModLbl
            // 
            this.wisModLbl.AutoSize = true;
            this.wisModLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.wisModLbl.Location = new System.Drawing.Point(37, 122);
            this.wisModLbl.Name = "wisModLbl";
            this.wisModLbl.Size = new System.Drawing.Size(33, 17);
            this.wisModLbl.TabIndex = 15;
            this.wisModLbl.Text = "WIS";
            this.wisModLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // intModTot
            // 
            this.intModTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intModTot.Location = new System.Drawing.Point(12, 94);
            this.intModTot.Name = "intModTot";
            this.intModTot.ReadOnly = true;
            this.intModTot.Size = new System.Drawing.Size(22, 22);
            this.intModTot.TabIndex = 23;
            this.intModTot.TabStop = false;
            this.intModTot.Text = "-5";
            this.intModTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chaModLbl
            // 
            this.chaModLbl.AutoSize = true;
            this.chaModLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chaModLbl.Location = new System.Drawing.Point(37, 148);
            this.chaModLbl.Name = "chaModLbl";
            this.chaModLbl.Size = new System.Drawing.Size(36, 17);
            this.chaModLbl.TabIndex = 16;
            this.chaModLbl.Text = "CHA";
            this.chaModLbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // strModTot
            // 
            this.strModTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strModTot.Location = new System.Drawing.Point(12, 16);
            this.strModTot.Name = "strModTot";
            this.strModTot.ReadOnly = true;
            this.strModTot.Size = new System.Drawing.Size(22, 22);
            this.strModTot.TabIndex = 17;
            this.strModTot.TabStop = false;
            this.strModTot.Text = "-5";
            this.strModTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // conModTot
            // 
            this.conModTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conModTot.Location = new System.Drawing.Point(12, 68);
            this.conModTot.Name = "conModTot";
            this.conModTot.ReadOnly = true;
            this.conModTot.Size = new System.Drawing.Size(22, 22);
            this.conModTot.TabIndex = 21;
            this.conModTot.TabStop = false;
            this.conModTot.Text = "-5";
            this.conModTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dexModTot
            // 
            this.dexModTot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dexModTot.Location = new System.Drawing.Point(12, 42);
            this.dexModTot.Name = "dexModTot";
            this.dexModTot.ReadOnly = true;
            this.dexModTot.Size = new System.Drawing.Size(22, 22);
            this.dexModTot.TabIndex = 19;
            this.dexModTot.TabStop = false;
            this.dexModTot.Text = "-5";
            this.dexModTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AbilityModGroup
            // 
            this.AbilityModGroup.AutoSize = true;
            this.AbilityModGroup.Controls.Add(this.panel5);
            this.AbilityModGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.AbilityModGroup.Location = new System.Drawing.Point(185, 145);
            this.AbilityModGroup.Name = "AbilityModGroup";
            this.AbilityModGroup.Size = new System.Drawing.Size(172, 208);
            this.AbilityModGroup.TabIndex = 1;
            this.AbilityModGroup.TabStop = false;
            this.AbilityModGroup.Text = "Ability Modifiers";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label164);
            this.panel5.Controls.Add(this.label163);
            this.panel5.Controls.Add(this.label162);
            this.panel5.Controls.Add(this.label161);
            this.panel5.Controls.Add(this.label160);
            this.panel5.Controls.Add(this.label159);
            this.panel5.Controls.Add(this.chaModTot);
            this.panel5.Controls.Add(this.strModTot);
            this.panel5.Controls.Add(this.conModLbl);
            this.panel5.Controls.Add(this.dexModTot);
            this.panel5.Controls.Add(this.conModTot);
            this.panel5.Controls.Add(this.intModTot);
            this.panel5.Controls.Add(this.dexModLbl);
            this.panel5.Controls.Add(this.wisModTot);
            this.panel5.Controls.Add(this.chaModLbl);
            this.panel5.Controls.Add(this.wisModLbl);
            this.panel5.Controls.Add(this.strModLbl);
            this.panel5.Controls.Add(this.IntModLbl);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(166, 183);
            this.panel5.TabIndex = 0;
            // 
            // label164
            // 
            this.label164.AutoSize = true;
            this.label164.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label164.Location = new System.Drawing.Point(79, 148);
            this.label164.Name = "label164";
            this.label164.Size = new System.Drawing.Size(58, 17);
            this.label164.TabIndex = 33;
            this.label164.Text = "Modifier";
            // 
            // label163
            // 
            this.label163.AutoSize = true;
            this.label163.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label163.Location = new System.Drawing.Point(79, 122);
            this.label163.Name = "label163";
            this.label163.Size = new System.Drawing.Size(58, 17);
            this.label163.TabIndex = 32;
            this.label163.Text = "Modifier";
            // 
            // label162
            // 
            this.label162.AutoSize = true;
            this.label162.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label162.Location = new System.Drawing.Point(79, 96);
            this.label162.Name = "label162";
            this.label162.Size = new System.Drawing.Size(58, 17);
            this.label162.TabIndex = 31;
            this.label162.Text = "Modifier";
            // 
            // label161
            // 
            this.label161.AutoSize = true;
            this.label161.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label161.Location = new System.Drawing.Point(79, 70);
            this.label161.Name = "label161";
            this.label161.Size = new System.Drawing.Size(58, 17);
            this.label161.TabIndex = 30;
            this.label161.Text = "Modifier";
            // 
            // label160
            // 
            this.label160.AutoSize = true;
            this.label160.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label160.Location = new System.Drawing.Point(79, 44);
            this.label160.Name = "label160";
            this.label160.Size = new System.Drawing.Size(58, 17);
            this.label160.TabIndex = 29;
            this.label160.Text = "Modifier";
            // 
            // label159
            // 
            this.label159.AutoSize = true;
            this.label159.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label159.Location = new System.Drawing.Point(79, 19);
            this.label159.Name = "label159";
            this.label159.Size = new System.Drawing.Size(58, 17);
            this.label159.TabIndex = 28;
            this.label159.Text = "Modifier";
            // 
            // characterDetailsGrp
            // 
            this.characterDetailsGrp.AutoSize = true;
            this.characterDetailsGrp.Controls.Add(this.panel3);
            this.characterDetailsGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.characterDetailsGrp.Location = new System.Drawing.Point(7, 22);
            this.characterDetailsGrp.Name = "characterDetailsGrp";
            this.characterDetailsGrp.Size = new System.Drawing.Size(350, 120);
            this.characterDetailsGrp.TabIndex = 2;
            this.characterDetailsGrp.TabStop = false;
            this.characterDetailsGrp.Text = "Character Details";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.comboBox2);
            this.panel3.Controls.Add(this.ClassLbl);
            this.panel3.Controls.Add(this.NameLbl);
            this.panel3.Controls.Add(this.RaceCombo);
            this.panel3.Controls.Add(this.RaceLbl);
            this.panel3.Controls.Add(this.AlignLbl);
            this.panel3.Controls.Add(this.NameTb);
            this.panel3.Controls.Add(this.ClassCombo);
            this.panel3.Controls.Add(this.GenderLbl);
            this.panel3.Controls.Add(this.GenderCombo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(344, 95);
            this.panel3.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Lawful good",
            "Lawful neutral",
            "Lawful evil",
            "Neutral good",
            "Neutral",
            "Neutral evil",
            "Chaotic good",
            "Chaotic neutral",
            "Chaotic evil"});
            this.comboBox2.Location = new System.Drawing.Point(81, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 24);
            this.comboBox2.TabIndex = 10;
            // 
            // ClassLbl
            // 
            this.ClassLbl.AutoSize = true;
            this.ClassLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ClassLbl.Location = new System.Drawing.Point(187, 36);
            this.ClassLbl.Name = "ClassLbl";
            this.ClassLbl.Size = new System.Drawing.Size(46, 17);
            this.ClassLbl.TabIndex = 9;
            this.ClassLbl.Text = "Class:";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameLbl.Location = new System.Drawing.Point(29, 8);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(49, 17);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Name:";
            // 
            // RaceCombo
            // 
            this.RaceCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RaceCombo.FormattingEnabled = true;
            this.RaceCombo.Items.AddRange(new object[] {
            "Dwarf",
            "Elf",
            "Gnome",
            "Half Elf",
            "Half Orc",
            "Halfling",
            "Human"});
            this.RaceCombo.Location = new System.Drawing.Point(236, 63);
            this.RaceCombo.Name = "RaceCombo";
            this.RaceCombo.Size = new System.Drawing.Size(100, 24);
            this.RaceCombo.TabIndex = 6;
            this.RaceCombo.SelectedIndexChanged += new System.EventHandler(this.RaceCombo_SelectedIndexChanged);
            // 
            // RaceLbl
            // 
            this.RaceLbl.AutoSize = true;
            this.RaceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RaceLbl.Location = new System.Drawing.Point(188, 66);
            this.RaceLbl.Name = "RaceLbl";
            this.RaceLbl.Size = new System.Drawing.Size(45, 17);
            this.RaceLbl.TabIndex = 8;
            this.RaceLbl.Text = "Race:";
            // 
            // AlignLbl
            // 
            this.AlignLbl.AutoSize = true;
            this.AlignLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.AlignLbl.Location = new System.Drawing.Point(4, 37);
            this.AlignLbl.Name = "AlignLbl";
            this.AlignLbl.Size = new System.Drawing.Size(74, 17);
            this.AlignLbl.TabIndex = 3;
            this.AlignLbl.Text = "Alignment:";
            // 
            // NameTb
            // 
            this.NameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.NameTb.Location = new System.Drawing.Point(81, 5);
            this.NameTb.Name = "NameTb";
            this.NameTb.Size = new System.Drawing.Size(255, 23);
            this.NameTb.TabIndex = 0;
            // 
            // ClassCombo
            // 
            this.ClassCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ClassCombo.FormattingEnabled = true;
            this.ClassCombo.Items.AddRange(new object[] {
            "Wizard",
            "Witch",
            "Summoner",
            "Sorcerer",
            "Rogue",
            "Ranger",
            "Paladin",
            "Oracle",
            "Monk",
            "Magus",
            "Inquisitor",
            "Gunslinger",
            "Fighter",
            "Druid",
            "Cleric",
            "Cavalier",
            "Bard",
            "Barbarian",
            "Alcamist"});
            this.ClassCombo.Location = new System.Drawing.Point(236, 33);
            this.ClassCombo.Name = "ClassCombo";
            this.ClassCombo.Size = new System.Drawing.Size(100, 24);
            this.ClassCombo.TabIndex = 7;
            this.ClassCombo.SelectedIndexChanged += new System.EventHandler(this.ClassCombo_SelectedIndexChanged);
            // 
            // GenderLbl
            // 
            this.GenderLbl.AutoSize = true;
            this.GenderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GenderLbl.Location = new System.Drawing.Point(18, 66);
            this.GenderLbl.Name = "GenderLbl";
            this.GenderLbl.Size = new System.Drawing.Size(60, 17);
            this.GenderLbl.TabIndex = 4;
            this.GenderLbl.Text = "Gender:";
            // 
            // GenderCombo
            // 
            this.GenderCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.GenderCombo.FormattingEnabled = true;
            this.GenderCombo.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderCombo.Location = new System.Drawing.Point(81, 63);
            this.GenderCombo.Name = "GenderCombo";
            this.GenderCombo.Size = new System.Drawing.Size(100, 24);
            this.GenderCombo.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(175, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelingToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // levelingToolStripMenuItem
            // 
            this.levelingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slowToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.fastToolStripMenuItem});
            this.levelingToolStripMenuItem.Name = "levelingToolStripMenuItem";
            this.levelingToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.levelingToolStripMenuItem.Text = "Leveling";
            // 
            // slowToolStripMenuItem
            // 
            this.slowToolStripMenuItem.Name = "slowToolStripMenuItem";
            this.slowToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.slowToolStripMenuItem.Text = "Slow";
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            // 
            // fastToolStripMenuItem
            // 
            this.fastToolStripMenuItem.Name = "fastToolStripMenuItem";
            this.fastToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.fastToolStripMenuItem.Text = "Fast";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // TraitsGrp
            // 
            this.TraitsGrp.AutoSize = true;
            this.TraitsGrp.Controls.Add(this.panel19);
            this.TraitsGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TraitsGrp.Location = new System.Drawing.Point(368, 23);
            this.TraitsGrp.Name = "TraitsGrp";
            this.TraitsGrp.Size = new System.Drawing.Size(429, 331);
            this.TraitsGrp.TabIndex = 17;
            this.TraitsGrp.TabStop = false;
            this.TraitsGrp.Text = "Traits";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.button3);
            this.panel19.Controls.Add(this.TraitsList);
            this.panel19.Controls.Add(this.moveSpdLbl);
            this.panel19.Controls.Add(this.button4);
            this.panel19.Controls.Add(this.button5);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(3, 22);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(423, 306);
            this.panel19.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.button3.Location = new System.Drawing.Point(343, 60);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "View";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // TraitsList
            // 
            this.TraitsList.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.TraitsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TraitsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Trait,
            this.DetailsCol});
            this.TraitsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.TraitsList.FullRowSelect = true;
            this.TraitsList.GridLines = true;
            this.TraitsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.TraitsList.Location = new System.Drawing.Point(2, 89);
            this.TraitsList.Name = "TraitsList";
            this.TraitsList.Size = new System.Drawing.Size(419, 214);
            this.TraitsList.TabIndex = 32;
            this.TraitsList.UseCompatibleStateImageBehavior = false;
            this.TraitsList.View = System.Windows.Forms.View.Details;
            // 
            // Trait
            // 
            this.Trait.Text = "Trait";
            this.Trait.Width = 102;
            // 
            // DetailsCol
            // 
            this.DetailsCol.Text = "Detail\'s";
            this.DetailsCol.Width = 287;
            // 
            // moveSpdLbl
            // 
            this.moveSpdLbl.AutoSize = true;
            this.moveSpdLbl.Location = new System.Drawing.Point(7, 7);
            this.moveSpdLbl.Name = "moveSpdLbl";
            this.moveSpdLbl.Size = new System.Drawing.Size(138, 20);
            this.moveSpdLbl.TabIndex = 0;
            this.moveSpdLbl.Text = "Movement Speed:";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.button4.Location = new System.Drawing.Point(343, 33);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(72, 23);
            this.button4.TabIndex = 33;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.button5.Location = new System.Drawing.Point(343, 6);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 23);
            this.button5.TabIndex = 31;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // CombatStatesGrp
            // 
            this.CombatStatesGrp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CombatStatesGrp.Controls.Add(this.panel8);
            this.CombatStatesGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CombatStatesGrp.Location = new System.Drawing.Point(7, 359);
            this.CombatStatesGrp.Name = "CombatStatesGrp";
            this.CombatStatesGrp.Size = new System.Drawing.Size(350, 393);
            this.CombatStatesGrp.TabIndex = 21;
            this.CombatStatesGrp.TabStop = false;
            this.CombatStatesGrp.Text = "Combat Stat\'s";
            // 
            // panel8
            // 
            this.panel8.AutoScroll = true;
            this.panel8.Controls.Add(this.panel7);
            this.panel8.Controls.Add(this.panel18);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 22);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(344, 368);
            this.panel8.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tableLayoutPanel1);
            this.panel7.Controls.Add(this.DamageTaken);
            this.panel7.Controls.Add(this.MHpTb);
            this.panel7.Controls.Add(this.CurrentHP);
            this.panel7.Controls.Add(this.label120);
            this.panel7.Controls.Add(this.MHPLbl);
            this.panel7.Controls.Add(this.label119);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(338, 148);
            this.panel7.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel17, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel16, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel15, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel14, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel13, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel12, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label12, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label165, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label166, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label167, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel9, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel10, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel11, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 33);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(338, 112);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.textBox15);
            this.panel17.Controls.Add(this.label47);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(270, 77);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(65, 32);
            this.panel17.TabIndex = 35;
            // 
            // textBox15
            // 
            this.textBox15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox15.Location = new System.Drawing.Point(20, 8);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(23, 23);
            this.textBox15.TabIndex = 13;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label47.Location = new System.Drawing.Point(21, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(22, 9);
            this.label47.TabIndex = 39;
            this.label47.Text = "Total";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.textBox18);
            this.panel16.Controls.Add(this.label48);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(270, 40);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(65, 31);
            this.panel16.TabIndex = 35;
            // 
            // textBox18
            // 
            this.textBox18.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox18.Location = new System.Drawing.Point(20, 7);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(23, 23);
            this.textBox18.TabIndex = 19;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label48.Location = new System.Drawing.Point(21, -1);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(22, 9);
            this.label48.TabIndex = 38;
            this.label48.Text = "Total";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.textBox17);
            this.panel15.Controls.Add(this.label49);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(270, 3);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(65, 31);
            this.panel15.TabIndex = 35;
            // 
            // textBox17
            // 
            this.textBox17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox17.Location = new System.Drawing.Point(20, 7);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(23, 23);
            this.textBox17.TabIndex = 18;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.75F);
            this.label49.Location = new System.Drawing.Point(21, -1);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(22, 9);
            this.label49.TabIndex = 37;
            this.label49.Text = "Total";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label46);
            this.panel14.Controls.Add(this.textBox14);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(170, 77);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(61, 32);
            this.panel14.TabIndex = 35;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.5F);
            this.label46.Location = new System.Drawing.Point(14, 1);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(32, 7);
            this.label46.TabIndex = 36;
            this.label46.Text = "DEX MOD";
            // 
            // textBox14
            // 
            this.textBox14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox14.Location = new System.Drawing.Point(19, 8);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(23, 23);
            this.textBox14.TabIndex = 12;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.label45);
            this.panel13.Controls.Add(this.textBox19);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(170, 40);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(61, 31);
            this.panel13.TabIndex = 35;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.5F);
            this.label45.Location = new System.Drawing.Point(14, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(32, 7);
            this.label45.TabIndex = 35;
            this.label45.Text = "STR MOD";
            // 
            // textBox19
            // 
            this.textBox19.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox19.Location = new System.Drawing.Point(19, 7);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(23, 23);
            this.textBox19.TabIndex = 20;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label44);
            this.panel12.Controls.Add(this.textBox16);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(170, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(61, 31);
            this.panel12.TabIndex = 34;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.5F);
            this.label44.Location = new System.Drawing.Point(14, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(32, 7);
            this.label44.TabIndex = 34;
            this.label44.Text = "DEX MOD";
            // 
            // textBox16
            // 
            this.textBox16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox16.Location = new System.Drawing.Point(19, 7);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(23, 23);
            this.textBox16.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(237, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 37);
            this.label12.TabIndex = 17;
            this.label12.Text = "=";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label10.Location = new System.Drawing.Point(237, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 37);
            this.label10.TabIndex = 15;
            this.label10.Text = "=";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label8.Location = new System.Drawing.Point(3, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 37);
            this.label8.TabIndex = 1;
            this.label8.Text = "Melee Attack";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label9.Location = new System.Drawing.Point(3, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 38);
            this.label9.TabIndex = 2;
            this.label9.Text = "Ranged Attack";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "Initiative";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label165
            // 
            this.label165.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label165.AutoSize = true;
            this.label165.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label165.Location = new System.Drawing.Point(137, 0);
            this.label165.Name = "label165";
            this.label165.Size = new System.Drawing.Size(27, 37);
            this.label165.TabIndex = 9;
            this.label165.Text = "+";
            this.label165.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label166
            // 
            this.label166.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label166.AutoSize = true;
            this.label166.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label166.Location = new System.Drawing.Point(137, 37);
            this.label166.Name = "label166";
            this.label166.Size = new System.Drawing.Size(27, 37);
            this.label166.TabIndex = 10;
            this.label166.Text = "+";
            this.label166.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label167
            // 
            this.label167.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label167.AutoSize = true;
            this.label167.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label167.Location = new System.Drawing.Point(137, 74);
            this.label167.Name = "label167";
            this.label167.Size = new System.Drawing.Size(27, 38);
            this.label167.TabIndex = 11;
            this.label167.Text = "+";
            this.label167.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label11.Location = new System.Drawing.Point(237, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 38);
            this.label11.TabIndex = 16;
            this.label11.Text = "=";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.textBox10);
            this.panel9.Controls.Add(this.label168);
            this.panel9.Location = new System.Drawing.Point(70, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(61, 31);
            this.panel9.TabIndex = 21;
            // 
            // textBox10
            // 
            this.textBox10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox10.Location = new System.Drawing.Point(19, 8);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(23, 23);
            this.textBox10.TabIndex = 6;
            // 
            // label168
            // 
            this.label168.AutoSize = true;
            this.label168.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.75F);
            this.label168.Location = new System.Drawing.Point(-3, -1);
            this.label168.Name = "label168";
            this.label168.Size = new System.Drawing.Size(67, 9);
            this.label168.TabIndex = 33;
            this.label168.Text = "Improved Initiative";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.textBox12);
            this.panel10.Controls.Add(this.label169);
            this.panel10.Location = new System.Drawing.Point(70, 40);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(61, 31);
            this.panel10.TabIndex = 22;
            // 
            // textBox12
            // 
            this.textBox12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox12.Location = new System.Drawing.Point(19, 8);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(23, 23);
            this.textBox12.TabIndex = 7;
            // 
            // label169
            // 
            this.label169.AutoSize = true;
            this.label169.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label169.Location = new System.Drawing.Point(5, 0);
            this.label169.Name = "label169";
            this.label169.Size = new System.Drawing.Size(49, 9);
            this.label169.TabIndex = 34;
            this.label169.Text = "Attack Bonus";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.textBox13);
            this.panel11.Controls.Add(this.label170);
            this.panel11.Location = new System.Drawing.Point(70, 77);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(61, 32);
            this.panel11.TabIndex = 23;
            // 
            // textBox13
            // 
            this.textBox13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBox13.Location = new System.Drawing.Point(19, 9);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(23, 23);
            this.textBox13.TabIndex = 8;
            // 
            // label170
            // 
            this.label170.AutoSize = true;
            this.label170.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label170.Location = new System.Drawing.Point(6, 1);
            this.label170.Name = "label170";
            this.label170.Size = new System.Drawing.Size(49, 9);
            this.label170.TabIndex = 36;
            this.label170.Text = "Attack Bonus";
            // 
            // DamageTaken
            // 
            this.DamageTaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.DamageTaken.Location = new System.Drawing.Point(76, 5);
            this.DamageTaken.Margin = new System.Windows.Forms.Padding(2);
            this.DamageTaken.Name = "DamageTaken";
            this.DamageTaken.Size = new System.Drawing.Size(34, 23);
            this.DamageTaken.TabIndex = 30;
            this.DamageTaken.Text = "0";
            this.DamageTaken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MHpTb
            // 
            this.MHpTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MHpTb.Location = new System.Drawing.Point(294, 5);
            this.MHpTb.Margin = new System.Windows.Forms.Padding(2);
            this.MHpTb.Name = "MHpTb";
            this.MHpTb.Size = new System.Drawing.Size(34, 23);
            this.MHpTb.TabIndex = 27;
            this.MHpTb.Text = "0";
            this.MHpTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CurrentHP
            // 
            this.CurrentHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CurrentHP.Location = new System.Drawing.Point(196, 5);
            this.CurrentHP.Margin = new System.Windows.Forms.Padding(2);
            this.CurrentHP.Name = "CurrentHP";
            this.CurrentHP.ReadOnly = true;
            this.CurrentHP.Size = new System.Drawing.Size(34, 23);
            this.CurrentHP.TabIndex = 29;
            this.CurrentHP.Text = "0";
            this.CurrentHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label120
            // 
            this.label120.AutoSize = true;
            this.label120.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label120.Location = new System.Drawing.Point(12, 8);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(65, 17);
            this.label120.TabIndex = 31;
            this.label120.Text = "Damage:";
            // 
            // MHPLbl
            // 
            this.MHPLbl.AutoSize = true;
            this.MHPLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MHPLbl.Location = new System.Drawing.Point(235, 8);
            this.MHPLbl.Name = "MHPLbl";
            this.MHPLbl.Size = new System.Drawing.Size(60, 17);
            this.MHPLbl.TabIndex = 26;
            this.MHPLbl.Text = "Max HP:";
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label119.Location = new System.Drawing.Point(115, 8);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(82, 17);
            this.label119.TabIndex = 28;
            this.label119.Text = "Current HP:";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.label52);
            this.panel18.Controls.Add(this.tableLayoutPanel3);
            this.panel18.Controls.Add(this.label50);
            this.panel18.Controls.Add(this.tableLayoutPanel2);
            this.panel18.Location = new System.Drawing.Point(3, 154);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(338, 206);
            this.panel18.TabIndex = 33;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(2, 91);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(60, 16);
            this.label52.TabIndex = 0;
            this.label52.Text = "Weapon";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 6;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.25301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.46988F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.95181F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.56627F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.37349F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.78313F));
            this.tableLayoutPanel3.Controls.Add(this.label53, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.label54, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.label55, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label56, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label57, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label58, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox24, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox25, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox26, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox27, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox28, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox29, 5, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 106);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(332, 68);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // label53
            // 
            this.label53.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label53.Location = new System.Drawing.Point(264, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(65, 34);
            this.label53.TabIndex = 11;
            this.label53.Text = "Ammunition";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label54
            // 
            this.label54.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label54.Location = new System.Drawing.Point(203, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(55, 34);
            this.label54.TabIndex = 10;
            this.label54.Text = "Damage\r\nIncrement";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label55
            // 
            this.label55.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label55.Location = new System.Drawing.Point(148, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(49, 34);
            this.label55.TabIndex = 9;
            this.label55.Text = "Damage\r\nType";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label56
            // 
            this.label56.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label56.Location = new System.Drawing.Point(105, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(37, 34);
            this.label56.TabIndex = 8;
            this.label56.Text = "Critical\r\nThreat";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label57
            // 
            this.label57.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label57.Location = new System.Drawing.Point(47, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(52, 34);
            this.label57.TabIndex = 7;
            this.label57.Text = "Damage";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label58
            // 
            this.label58.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label58.Location = new System.Drawing.Point(3, 0);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(38, 34);
            this.label58.TabIndex = 4;
            this.label58.Text = "Attack\r\nBonus";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(3, 37);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(38, 26);
            this.textBox24.TabIndex = 12;
            // 
            // textBox25
            // 
            this.textBox25.Location = new System.Drawing.Point(47, 37);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(52, 26);
            this.textBox25.TabIndex = 13;
            // 
            // textBox26
            // 
            this.textBox26.Location = new System.Drawing.Point(105, 37);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(37, 26);
            this.textBox26.TabIndex = 14;
            // 
            // textBox27
            // 
            this.textBox27.Location = new System.Drawing.Point(148, 37);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(49, 26);
            this.textBox27.TabIndex = 15;
            // 
            // textBox28
            // 
            this.textBox28.Location = new System.Drawing.Point(203, 37);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(55, 26);
            this.textBox28.TabIndex = 16;
            // 
            // textBox29
            // 
            this.textBox29.Location = new System.Drawing.Point(264, 37);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(65, 26);
            this.textBox29.TabIndex = 17;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(2, 3);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(60, 16);
            this.label50.TabIndex = 0;
            this.label50.Text = "Weapon";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.25301F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.46988F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.95181F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.56627F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.37349F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.78313F));
            this.tableLayoutPanel2.Controls.Add(this.label63, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label62, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label61, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label60, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label59, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.AttBonus, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox7, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox11, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox20, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox21, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox22, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox23, 5, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 15);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(332, 68);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label63
            // 
            this.label63.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label63.Location = new System.Drawing.Point(264, 0);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(65, 34);
            this.label63.TabIndex = 11;
            this.label63.Text = "Ammunition";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label62
            // 
            this.label62.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label62.Location = new System.Drawing.Point(203, 0);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(55, 34);
            this.label62.TabIndex = 10;
            this.label62.Text = "Damage\r\nIncrement";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label61
            // 
            this.label61.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label61.Location = new System.Drawing.Point(148, 0);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(49, 34);
            this.label61.TabIndex = 9;
            this.label61.Text = "Damage\r\nType";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label60
            // 
            this.label60.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label60.Location = new System.Drawing.Point(105, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(37, 34);
            this.label60.TabIndex = 8;
            this.label60.Text = "Critical\r\nThreat";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label59
            // 
            this.label59.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.label59.Location = new System.Drawing.Point(47, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(52, 34);
            this.label59.TabIndex = 7;
            this.label59.Text = "Damage";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AttBonus
            // 
            this.AttBonus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AttBonus.AutoSize = true;
            this.AttBonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.AttBonus.Location = new System.Drawing.Point(3, 0);
            this.AttBonus.Name = "AttBonus";
            this.AttBonus.Size = new System.Drawing.Size(38, 34);
            this.AttBonus.TabIndex = 4;
            this.AttBonus.Text = "Attack\r\nBonus";
            this.AttBonus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(3, 37);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(38, 26);
            this.textBox7.TabIndex = 12;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(47, 37);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(52, 26);
            this.textBox11.TabIndex = 13;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(105, 37);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(37, 26);
            this.textBox20.TabIndex = 14;
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(148, 37);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(49, 26);
            this.textBox21.TabIndex = 15;
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(203, 37);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(55, 26);
            this.textBox22.TabIndex = 16;
            // 
            // textBox23
            // 
            this.textBox23.Location = new System.Drawing.Point(264, 37);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(65, 26);
            this.textBox23.TabIndex = 17;
            // 
            // ClassSkillsGrp
            // 
            this.ClassSkillsGrp.Controls.Add(this.panel1);
            this.ClassSkillsGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ClassSkillsGrp.Location = new System.Drawing.Point(368, 360);
            this.ClassSkillsGrp.Name = "ClassSkillsGrp";
            this.ClassSkillsGrp.Size = new System.Drawing.Size(429, 392);
            this.ClassSkillsGrp.TabIndex = 23;
            this.ClassSkillsGrp.TabStop = false;
            this.ClassSkillsGrp.Text = "Class Skills";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.skillList1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 367);
            this.panel1.TabIndex = 0;
            // 
            // skillList1
            // 
            this.skillList1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.skillList1.Location = new System.Drawing.Point(1, -1);
            this.skillList1.Name = "skillList1";
            this.skillList1.Size = new System.Drawing.Size(421, 367);
            this.skillList1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inventoryPreview1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox2.Location = new System.Drawing.Point(803, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 392);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Inventory";
            // 
            // CombatPreview
            // 
            this.CombatPreview.AutoSize = true;
            this.CombatPreview.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CombatPreview.Location = new System.Drawing.Point(802, 21);
            this.CombatPreview.Name = "CombatPreview";
            this.CombatPreview.Size = new System.Drawing.Size(376, 333);
            this.CombatPreview.TabIndex = 26;
            this.CombatPreview.TotalEXPProp = 0;
            // 
            // inventoryPreview1
            // 
            this.inventoryPreview1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.inventoryPreview1.Location = new System.Drawing.Point(7, 24);
            this.inventoryPreview1.Margin = new System.Windows.Forms.Padding(4);
            this.inventoryPreview1.Name = "inventoryPreview1";
            this.inventoryPreview1.Size = new System.Drawing.Size(360, 357);
            this.inventoryPreview1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.CombatPreview);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ClassSkillsGrp);
            this.Controls.Add(this.CombatStatesGrp);
            this.Controls.Add(this.TraitsGrp);
            this.Controls.Add(this.characterDetailsGrp);
            this.Controls.Add(this.AbilityModGroup);
            this.Controls.Add(this.AbilityGrp);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "Pathfinder Character Sheet";
            this.Load += new System.EventHandler(this.OnLoad);
            this.AbilityGrp.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chaScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dexScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.intScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wisScore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.strScore)).EndInit();
            this.AbilityModGroup.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.characterDetailsGrp.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.TraitsGrp.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.CombatStatesGrp.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ClassSkillsGrp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox AbilityGrp;
        private System.Windows.Forms.Label strLabel;
        private System.Windows.Forms.NumericUpDown chaScore;
        private System.Windows.Forms.NumericUpDown wisScore;
        private System.Windows.Forms.NumericUpDown intScore;
        private System.Windows.Forms.NumericUpDown conScore;
        private System.Windows.Forms.NumericUpDown dexScore;
        private System.Windows.Forms.NumericUpDown strScore;
        private System.Windows.Forms.Label chaLabel;
        private System.Windows.Forms.Label wisLabel;
        private System.Windows.Forms.Label intLabel;
        private System.Windows.Forms.Label conLabel;
        private System.Windows.Forms.Label dexLabel;
        private System.Windows.Forms.GroupBox AbilityModGroup;
        private System.Windows.Forms.TextBox chaModTot;
        private System.Windows.Forms.TextBox wisModTot;
        private System.Windows.Forms.TextBox intModTot;
        private System.Windows.Forms.TextBox conModTot;
        private System.Windows.Forms.TextBox dexModTot;
        private System.Windows.Forms.TextBox strModTot;
        private System.Windows.Forms.Label chaModLbl;
        private System.Windows.Forms.Label wisModLbl;
        private System.Windows.Forms.Label IntModLbl;
        private System.Windows.Forms.Label conModLbl;
        private System.Windows.Forms.Label dexModLbl;
        private System.Windows.Forms.Label strModLbl;
        private System.Windows.Forms.GroupBox characterDetailsGrp;
        private System.Windows.Forms.Label AlignLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTb;
        private System.Windows.Forms.ComboBox GenderCombo;
        private System.Windows.Forms.Label GenderLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label ClassLbl;
        private System.Windows.Forms.Label RaceLbl;
        private System.Windows.Forms.ComboBox ClassCombo;
        private System.Windows.Forms.ComboBox RaceCombo;
        private System.Windows.Forms.GroupBox TraitsGrp;
        private System.Windows.Forms.Label moveSpdLbl;
        private Panel panel4;
        private Panel panel5;
        private Panel panel3;
        private Label label164;
        private Label label163;
        private Label label162;
        private Label label161;
        private Label label160;
        private Label label159;
        private GroupBox CombatStatesGrp;
        private Panel panel8;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label8;
        private Label label9;
        private Label label7;
        private Label label120;
        private Label MHPLbl;
        private TextBox DamageTaken;
        private TextBox MHpTb;
        private TextBox CurrentHP;
        private Label label119;
        private TextBox textBox19;
        private TextBox textBox18;
        private TextBox textBox17;
        private Label label12;
        private Label label10;
        private Label label165;
        private Label label166;
        private Label label167;
        private TextBox textBox14;
        private TextBox textBox16;
        private TextBox textBox15;
        private Label label11;
        private Panel panel10;
        private TextBox textBox12;
        private Label label169;
        private Panel panel11;
        private TextBox textBox13;
        private Label label170;
        private ComboBox comboBox2;
        private Panel panel17;
        private Panel panel16;
        private Panel panel15;
        private Panel panel14;
        private Label label46;
        private Panel panel13;
        private Label label45;
        private Panel panel12;
        private Label label44;
        private Panel panel9;
        private TextBox textBox10;
        private Label label168;
        private Panel panel18;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label53;
        private Label label54;
        private Label label55;
        private Label label56;
        private Label label57;
        private Label label58;
        private TextBox textBox24;
        private TextBox textBox25;
        private TextBox textBox26;
        private TextBox textBox27;
        private TextBox textBox28;
        private TextBox textBox29;
        private Label label52;
        private Label label50;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label63;
        private Label label62;
        private Label label61;
        private Label label60;
        private Label label59;
        private Label AttBonus;
        private TextBox textBox7;
        private TextBox textBox11;
        private TextBox textBox20;
        private TextBox textBox21;
        private TextBox textBox22;
        private TextBox textBox23;
        private Label label47;
        private Label label48;
        private Label label49;
        private Panel panel7;
        private Panel panel19;
        private Button button3;
        private ListView TraitsList;
        private Button button4;
        private Button button5;
        private ColumnHeader Trait;
        private ColumnHeader DetailsCol;
        private GroupBox ClassSkillsGrp;
        private GroupBox groupBox2;
        private MainFormPreviewCtls.CombatPreview  CombatPreview;
        private Panel panel1;
        private MainFormPreviewCtls.SkillList skillList1;
        private MainFormPreviewCtls.InventoryPreview inventoryPreview1;
    }
}

