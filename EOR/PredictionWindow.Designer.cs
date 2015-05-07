namespace EOR
{
    partial class PredictionWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PredictionWindow));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblMilidarcy = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.txtOilSaturation = new System.Windows.Forms.TextBox();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.txtPermeability = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.lblPermeability = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.lblDepth = new System.Windows.Forms.Label();
            this.lblSaturation = new System.Windows.Forms.Label();
            this.txtPorosity = new System.Windows.Forms.TextBox();
            this.lblPorosity = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtViscosity = new System.Windows.Forms.TextBox();
            this.txtGravity = new System.Windows.Forms.TextBox();
            this.lblViscosity = new System.Windows.Forms.Label();
            this.lblGravity = new System.Windows.Forms.Label();
            this.lblSteam = new System.Windows.Forms.Label();
            this.lblPolymer = new System.Windows.Forms.Label();
            this.lblInSitu = new System.Windows.Forms.Label();
            this.lblHydroCarbon = new System.Windows.Forms.Label();
            this.lblCo2Miscible = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtinstanthelp = new System.Windows.Forms.TextBox();
            this.lblHelp = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsteamEconomic = new System.Windows.Forms.Button();
            this.btnCo2Economic = new System.Windows.Forms.Button();
            this.btnHydroEconomic = new System.Windows.Forms.Button();
            this.btnInsituEconomic = new System.Windows.Forms.Button();
            this.btnPolymerEconomic = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.lblMilidarcy);
            this.groupBox1.Controls.Add(this.lblPercent);
            this.groupBox1.Controls.Add(this.txtOilSaturation);
            this.groupBox1.Controls.Add(this.txtDepth);
            this.groupBox1.Controls.Add(this.txtPermeability);
            this.groupBox1.Controls.Add(this.txtTemp);
            this.groupBox1.Controls.Add(this.lblPermeability);
            this.groupBox1.Controls.Add(this.lblTemperature);
            this.groupBox1.Controls.Add(this.lblDepth);
            this.groupBox1.Controls.Add(this.lblSaturation);
            this.groupBox1.Controls.Add(this.txtPorosity);
            this.groupBox1.Controls.Add(this.lblPorosity);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Petrel Input";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(267, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "% of OOIP";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ft",
            "m"});
            this.comboBox2.Location = new System.Drawing.Point(273, 138);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(43, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.MouseEnter += new System.EventHandler(this.comboBox2_MouseEnter);
            this.comboBox2.MouseLeave += new System.EventHandler(this.comboBox2_MouseLeave);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "˚F",
            "˚K",
            "˚C"});
            this.comboBox1.Location = new System.Drawing.Point(273, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(43, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.MouseEnter += new System.EventHandler(this.comboBox1_MouseEnter);
            this.comboBox1.MouseLeave += new System.EventHandler(this.comboBox1_MouseLeave);
            // 
            // lblMilidarcy
            // 
            this.lblMilidarcy.AutoSize = true;
            this.lblMilidarcy.BackColor = System.Drawing.SystemColors.Control;
            this.lblMilidarcy.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMilidarcy.Location = new System.Drawing.Point(276, 67);
            this.lblMilidarcy.Name = "lblMilidarcy";
            this.lblMilidarcy.Size = new System.Drawing.Size(21, 13);
            this.lblMilidarcy.TabIndex = 11;
            this.lblMilidarcy.Text = "md";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.BackColor = System.Drawing.SystemColors.Control;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.Location = new System.Drawing.Point(277, 31);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(15, 13);
            this.lblPercent.TabIndex = 10;
            this.lblPercent.Text = "%";
            // 
            // txtOilSaturation
            // 
            this.txtOilSaturation.Location = new System.Drawing.Point(147, 174);
            this.txtOilSaturation.Name = "txtOilSaturation";
            this.txtOilSaturation.Size = new System.Drawing.Size(114, 20);
            this.txtOilSaturation.TabIndex = 9;
            this.txtOilSaturation.MouseEnter += new System.EventHandler(this.txtOilSaturation_MouseEnter);
            this.txtOilSaturation.MouseLeave += new System.EventHandler(this.txtOilSaturation_MouseLeave);
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(147, 138);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(114, 20);
            this.txtDepth.TabIndex = 8;
            this.txtDepth.MouseEnter += new System.EventHandler(this.txtDepth_MouseEnter);
            this.txtDepth.MouseLeave += new System.EventHandler(this.txtDepth_MouseLeave);
            // 
            // txtPermeability
            // 
            this.txtPermeability.Location = new System.Drawing.Point(147, 64);
            this.txtPermeability.Name = "txtPermeability";
            this.txtPermeability.Size = new System.Drawing.Size(114, 20);
            this.txtPermeability.TabIndex = 7;
            this.txtPermeability.MouseEnter += new System.EventHandler(this.txtPermeability_MouseEnter);
            this.txtPermeability.MouseLeave += new System.EventHandler(this.txtPermeability_MouseLeave);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(147, 102);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(114, 20);
            this.txtTemp.TabIndex = 6;
            this.txtTemp.MouseEnter += new System.EventHandler(this.txtTemp_MouseEnter);
            this.txtTemp.MouseLeave += new System.EventHandler(this.txtTemp_MouseLeave);
            // 
            // lblPermeability
            // 
            this.lblPermeability.AutoSize = true;
            this.lblPermeability.Location = new System.Drawing.Point(15, 64);
            this.lblPermeability.Name = "lblPermeability";
            this.lblPermeability.Size = new System.Drawing.Size(63, 13);
            this.lblPermeability.TabIndex = 5;
            this.lblPermeability.Text = "Permeability";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Location = new System.Drawing.Point(15, 102);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(67, 13);
            this.lblTemperature.TabIndex = 4;
            this.lblTemperature.Text = "Temperature";
            // 
            // lblDepth
            // 
            this.lblDepth.AutoSize = true;
            this.lblDepth.Location = new System.Drawing.Point(15, 138);
            this.lblDepth.Name = "lblDepth";
            this.lblDepth.Size = new System.Drawing.Size(84, 13);
            this.lblDepth.TabIndex = 3;
            this.lblDepth.Text = "Reservoir Depth";
            // 
            // lblSaturation
            // 
            this.lblSaturation.AutoSize = true;
            this.lblSaturation.Location = new System.Drawing.Point(15, 174);
            this.lblSaturation.Name = "lblSaturation";
            this.lblSaturation.Size = new System.Drawing.Size(97, 13);
            this.lblSaturation.TabIndex = 2;
            this.lblSaturation.Text = "Initial Oil Saturation";
            // 
            // txtPorosity
            // 
            this.txtPorosity.Location = new System.Drawing.Point(147, 28);
            this.txtPorosity.Name = "txtPorosity";
            this.txtPorosity.Size = new System.Drawing.Size(114, 20);
            this.txtPorosity.TabIndex = 1;
            this.txtPorosity.MouseEnter += new System.EventHandler(this.txtPorosity_MouseEnter);
            this.txtPorosity.MouseLeave += new System.EventHandler(this.txtPorosity_MouseLeave);
            // 
            // lblPorosity
            // 
            this.lblPorosity.AutoSize = true;
            this.lblPorosity.Location = new System.Drawing.Point(15, 28);
            this.lblPorosity.Name = "lblPorosity";
            this.lblPorosity.Size = new System.Drawing.Size(44, 13);
            this.lblPorosity.TabIndex = 0;
            this.lblPorosity.Text = "Porosity";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtViscosity);
            this.groupBox2.Controls.Add(this.txtGravity);
            this.groupBox2.Controls.Add(this.lblViscosity);
            this.groupBox2.Controls.Add(this.lblGravity);
            this.groupBox2.Location = new System.Drawing.Point(13, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 96);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Input";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(276, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "cp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(275, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "˚API";
            // 
            // txtViscosity
            // 
            this.txtViscosity.Location = new System.Drawing.Point(146, 63);
            this.txtViscosity.Name = "txtViscosity";
            this.txtViscosity.Size = new System.Drawing.Size(114, 20);
            this.txtViscosity.TabIndex = 11;
            this.txtViscosity.MouseEnter += new System.EventHandler(this.txtViscosity_MouseEnter);
            this.txtViscosity.MouseLeave += new System.EventHandler(this.txtViscosity_MouseLeave);
            // 
            // txtGravity
            // 
            this.txtGravity.Location = new System.Drawing.Point(146, 27);
            this.txtGravity.Name = "txtGravity";
            this.txtGravity.Size = new System.Drawing.Size(114, 20);
            this.txtGravity.TabIndex = 10;
            this.txtGravity.MouseEnter += new System.EventHandler(this.txtGravity_MouseEnter);
            this.txtGravity.MouseLeave += new System.EventHandler(this.txtGravity_MouseLeave);
            // 
            // lblViscosity
            // 
            this.lblViscosity.AutoSize = true;
            this.lblViscosity.Location = new System.Drawing.Point(6, 63);
            this.lblViscosity.Name = "lblViscosity";
            this.lblViscosity.Size = new System.Drawing.Size(63, 13);
            this.lblViscosity.TabIndex = 4;
            this.lblViscosity.Text = "Oil Viscosity";
            // 
            // lblGravity
            // 
            this.lblGravity.AutoSize = true;
            this.lblGravity.Location = new System.Drawing.Point(6, 30);
            this.lblGravity.Name = "lblGravity";
            this.lblGravity.Size = new System.Drawing.Size(58, 13);
            this.lblGravity.TabIndex = 3;
            this.lblGravity.Text = "Oil Gravity ";
            // 
            // lblSteam
            // 
            this.lblSteam.BackColor = System.Drawing.SystemColors.Control;
            this.lblSteam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSteam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSteam.Location = new System.Drawing.Point(20, 29);
            this.lblSteam.Name = "lblSteam";
            this.lblSteam.Size = new System.Drawing.Size(211, 31);
            this.lblSteam.TabIndex = 2;
            this.lblSteam.Text = "Steam";
            // 
            // lblPolymer
            // 
            this.lblPolymer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPolymer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolymer.Location = new System.Drawing.Point(20, 272);
            this.lblPolymer.Name = "lblPolymer";
            this.lblPolymer.Size = new System.Drawing.Size(211, 31);
            this.lblPolymer.TabIndex = 3;
            this.lblPolymer.Text = "Polymer Flooding";
            // 
            // lblInSitu
            // 
            this.lblInSitu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInSitu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInSitu.Location = new System.Drawing.Point(20, 206);
            this.lblInSitu.Name = "lblInSitu";
            this.lblInSitu.Size = new System.Drawing.Size(211, 31);
            this.lblInSitu.TabIndex = 4;
            this.lblInSitu.Text = "In-Situ Combustion";
            // 
            // lblHydroCarbon
            // 
            this.lblHydroCarbon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHydroCarbon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHydroCarbon.Location = new System.Drawing.Point(20, 148);
            this.lblHydroCarbon.Name = "lblHydroCarbon";
            this.lblHydroCarbon.Size = new System.Drawing.Size(211, 31);
            this.lblHydroCarbon.TabIndex = 5;
            this.lblHydroCarbon.Text = "HydroCarbon Miscible";
            // 
            // lblCo2Miscible
            // 
            this.lblCo2Miscible.BackColor = System.Drawing.SystemColors.Control;
            this.lblCo2Miscible.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCo2Miscible.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCo2Miscible.Location = new System.Drawing.Point(20, 84);
            this.lblCo2Miscible.Name = "lblCo2Miscible";
            this.lblCo2Miscible.Size = new System.Drawing.Size(211, 31);
            this.lblCo2Miscible.TabIndex = 6;
            this.lblCo2Miscible.Text = "CO2 Miscible";
            // 
            // btnApply
            // 
            this.btnApply.Image = ((System.Drawing.Image)(resources.GetObject("btnApply.Image")));
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(307, 349);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(98, 31);
            this.btnApply.TabIndex = 13;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            this.btnApply.MouseEnter += new System.EventHandler(this.btnApply_MouseEnter);
            this.btnApply.MouseLeave += new System.EventHandler(this.btnApply_MouseLeave);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCo2Miscible);
            this.groupBox3.Controls.Add(this.lblHydroCarbon);
            this.groupBox3.Controls.Add(this.lblInSitu);
            this.groupBox3.Controls.Add(this.lblPolymer);
            this.groupBox3.Controls.Add(this.lblSteam);
            this.groupBox3.Location = new System.Drawing.Point(359, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 322);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generated Output";
            // 
            // txtinstanthelp
            // 
            this.txtinstanthelp.BackColor = System.Drawing.Color.White;
            this.txtinstanthelp.ForeColor = System.Drawing.Color.Green;
            this.txtinstanthelp.Location = new System.Drawing.Point(13, 382);
            this.txtinstanthelp.Multiline = true;
            this.txtinstanthelp.Name = "txtinstanthelp";
            this.txtinstanthelp.ReadOnly = true;
            this.txtinstanthelp.Size = new System.Drawing.Size(269, 106);
            this.txtinstanthelp.TabIndex = 15;
            // 
            // lblHelp
            // 
            this.lblHelp.AutoSize = true;
            this.lblHelp.Location = new System.Drawing.Point(9, 358);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(64, 13);
            this.lblHelp.TabIndex = 16;
            this.lblHelp.Text = "Instant Help";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(307, 401);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(247, 87);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Colors Help";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Output Rejected";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Output Selected";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(23, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            // 
            // btnsteamEconomic
            // 
            this.btnsteamEconomic.Enabled = false;
            this.btnsteamEconomic.Image = ((System.Drawing.Image)(resources.GetObject("btnsteamEconomic.Image")));
            this.btnsteamEconomic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsteamEconomic.Location = new System.Drawing.Point(623, 40);
            this.btnsteamEconomic.Name = "btnsteamEconomic";
            this.btnsteamEconomic.Size = new System.Drawing.Size(120, 33);
            this.btnsteamEconomic.TabIndex = 18;
            this.btnsteamEconomic.Text = "Economic";
            this.btnsteamEconomic.UseVisualStyleBackColor = true;
            this.btnsteamEconomic.Click += new System.EventHandler(this.btnsteamEconomic_Click);
            // 
            // btnCo2Economic
            // 
            this.btnCo2Economic.Enabled = false;
            this.btnCo2Economic.Image = ((System.Drawing.Image)(resources.GetObject("btnCo2Economic.Image")));
            this.btnCo2Economic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCo2Economic.Location = new System.Drawing.Point(623, 95);
            this.btnCo2Economic.Name = "btnCo2Economic";
            this.btnCo2Economic.Size = new System.Drawing.Size(120, 33);
            this.btnCo2Economic.TabIndex = 19;
            this.btnCo2Economic.Text = "Economic";
            this.btnCo2Economic.UseVisualStyleBackColor = true;
            this.btnCo2Economic.Click += new System.EventHandler(this.btnCo2Economic_Click);
            // 
            // btnHydroEconomic
            // 
            this.btnHydroEconomic.Enabled = false;
            this.btnHydroEconomic.Image = ((System.Drawing.Image)(resources.GetObject("btnHydroEconomic.Image")));
            this.btnHydroEconomic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHydroEconomic.Location = new System.Drawing.Point(623, 158);
            this.btnHydroEconomic.Name = "btnHydroEconomic";
            this.btnHydroEconomic.Size = new System.Drawing.Size(120, 33);
            this.btnHydroEconomic.TabIndex = 20;
            this.btnHydroEconomic.Text = "Economic";
            this.btnHydroEconomic.UseVisualStyleBackColor = true;
            this.btnHydroEconomic.Click += new System.EventHandler(this.btnHydroEconomic_Click);
            // 
            // btnInsituEconomic
            // 
            this.btnInsituEconomic.Enabled = false;
            this.btnInsituEconomic.Image = ((System.Drawing.Image)(resources.GetObject("btnInsituEconomic.Image")));
            this.btnInsituEconomic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInsituEconomic.Location = new System.Drawing.Point(623, 218);
            this.btnInsituEconomic.Name = "btnInsituEconomic";
            this.btnInsituEconomic.Size = new System.Drawing.Size(120, 33);
            this.btnInsituEconomic.TabIndex = 21;
            this.btnInsituEconomic.Text = "Economic";
            this.btnInsituEconomic.UseVisualStyleBackColor = true;
            this.btnInsituEconomic.Click += new System.EventHandler(this.btnInsituEconomic_Click);
            // 
            // btnPolymerEconomic
            // 
            this.btnPolymerEconomic.Enabled = false;
            this.btnPolymerEconomic.Image = ((System.Drawing.Image)(resources.GetObject("btnPolymerEconomic.Image")));
            this.btnPolymerEconomic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPolymerEconomic.Location = new System.Drawing.Point(623, 281);
            this.btnPolymerEconomic.Name = "btnPolymerEconomic";
            this.btnPolymerEconomic.Size = new System.Drawing.Size(120, 33);
            this.btnPolymerEconomic.TabIndex = 22;
            this.btnPolymerEconomic.Text = "Economic";
            this.btnPolymerEconomic.UseVisualStyleBackColor = true;
            this.btnPolymerEconomic.Click += new System.EventHandler(this.btnPolymerEconomic_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(431, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 31);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // PredictionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 500);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPolymerEconomic);
            this.Controls.Add(this.btnInsituEconomic);
            this.Controls.Add(this.btnHydroEconomic);
            this.Controls.Add(this.btnCo2Economic);
            this.Controls.Add(this.btnsteamEconomic);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.txtinstanthelp);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PredictionWindow";
            this.Text = "Prediction Window";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPorosity;
        private System.Windows.Forms.Label lblPorosity;
        private System.Windows.Forms.TextBox txtOilSaturation;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.TextBox txtPermeability;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label lblPermeability;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Label lblDepth;
        private System.Windows.Forms.Label lblSaturation;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtViscosity;
        private System.Windows.Forms.TextBox txtGravity;
        private System.Windows.Forms.Label lblViscosity;
        private System.Windows.Forms.Label lblGravity;
        private System.Windows.Forms.Label lblSteam;
        private System.Windows.Forms.Label lblPolymer;
        private System.Windows.Forms.Label lblInSitu;
        private System.Windows.Forms.Label lblHydroCarbon;
        private System.Windows.Forms.Label lblCo2Miscible;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtinstanthelp;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsteamEconomic;
        private System.Windows.Forms.Button btnCo2Economic;
        private System.Windows.Forms.Button btnHydroEconomic;
        private System.Windows.Forms.Button btnInsituEconomic;
        private System.Windows.Forms.Button btnPolymerEconomic;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMilidarcy;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
    }
}