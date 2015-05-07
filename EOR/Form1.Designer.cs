namespace EOR
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbllearningrate = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblpermeability = new System.Windows.Forms.Label();
            this.lblporosity = new System.Windows.Forms.Label();
            this.lbldepth = new System.Windows.Forms.Label();
            this.lbltemp = new System.Windows.Forms.Label();
            this.lblviscosity = new System.Windows.Forms.Label();
            this.lblgravity = new System.Windows.Forms.Label();
            this.lblinput = new System.Windows.Forms.Label();
            this.lnlsaturation = new System.Windows.Forms.Label();
            this.lblerror = new System.Windows.Forms.Label();
            this.lbliteration = new System.Windows.Forms.Label();
            this.lblmomentum = new System.Windows.Forms.Label();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.txtViscosity = new System.Windows.Forms.TextBox();
            this.txtGravity = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtPermeability = new System.Windows.Forms.TextBox();
            this.txtPorosity = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.txtIteration = new System.Windows.Forms.TextBox();
            this.txtMomentum = new System.Windows.Forms.TextBox();
            this.txtOilSaturation = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioco2 = new System.Windows.Forms.RadioButton();
            this.radiopolymer = new System.Windows.Forms.RadioButton();
            this.radioinsitu = new System.Windows.Forms.RadioButton();
            this.radiohydro = new System.Windows.Forms.RadioButton();
            this.radiosteam = new System.Windows.Forms.RadioButton();
            this.txtinstanthelp = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblinstanthelp = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProcess = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbllearningrate
            // 
            this.lbllearningrate.AutoSize = true;
            this.lbllearningrate.Location = new System.Drawing.Point(12, 35);
            this.lbllearningrate.Name = "lbllearningrate";
            this.lbllearningrate.Size = new System.Drawing.Size(74, 13);
            this.lbllearningrate.TabIndex = 0;
            this.lbllearningrate.Text = "Learning Rate";
            // 
            // txtRate
            // 
            this.txtRate.Location = new System.Drawing.Point(92, 32);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(100, 20);
            this.txtRate.TabIndex = 1;
            this.txtRate.MouseEnter += new System.EventHandler(this.txtRate_MouseEnter);
            this.txtRate.MouseLeave += new System.EventHandler(this.txtRate_MouseLeave);
            // 
            // lblpermeability
            // 
            this.lblpermeability.AutoSize = true;
            this.lblpermeability.Location = new System.Drawing.Point(230, 77);
            this.lblpermeability.Name = "lblpermeability";
            this.lblpermeability.Size = new System.Drawing.Size(63, 13);
            this.lblpermeability.TabIndex = 2;
            this.lblpermeability.Text = "Permeability";
            // 
            // lblporosity
            // 
            this.lblporosity.AutoSize = true;
            this.lblporosity.Location = new System.Drawing.Point(230, 49);
            this.lblporosity.Name = "lblporosity";
            this.lblporosity.Size = new System.Drawing.Size(44, 13);
            this.lblporosity.TabIndex = 3;
            this.lblporosity.Text = "Porosity";
            // 
            // lbldepth
            // 
            this.lbldepth.AutoSize = true;
            this.lbldepth.Location = new System.Drawing.Point(230, 144);
            this.lbldepth.Name = "lbldepth";
            this.lbldepth.Size = new System.Drawing.Size(84, 13);
            this.lbldepth.TabIndex = 4;
            this.lbldepth.Text = "Reservoir Depth";
            // 
            // lbltemp
            // 
            this.lbltemp.AutoSize = true;
            this.lbltemp.Location = new System.Drawing.Point(230, 108);
            this.lbltemp.Name = "lbltemp";
            this.lbltemp.Size = new System.Drawing.Size(67, 13);
            this.lbltemp.TabIndex = 5;
            this.lbltemp.Text = "Temperature";
            // 
            // lblviscosity
            // 
            this.lblviscosity.AutoSize = true;
            this.lblviscosity.Location = new System.Drawing.Point(230, 203);
            this.lblviscosity.Name = "lblviscosity";
            this.lblviscosity.Size = new System.Drawing.Size(63, 13);
            this.lblviscosity.TabIndex = 6;
            this.lblviscosity.Text = "Oil Viscosity";
            // 
            // lblgravity
            // 
            this.lblgravity.AutoSize = true;
            this.lblgravity.Location = new System.Drawing.Point(230, 175);
            this.lblgravity.Name = "lblgravity";
            this.lblgravity.Size = new System.Drawing.Size(55, 13);
            this.lblgravity.TabIndex = 7;
            this.lblgravity.Text = "Oil Gravity";
            // 
            // lblinput
            // 
            this.lblinput.AutoSize = true;
            this.lblinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinput.Location = new System.Drawing.Point(274, 9);
            this.lblinput.Name = "lblinput";
            this.lblinput.Size = new System.Drawing.Size(97, 13);
            this.lblinput.TabIndex = 8;
            this.lblinput.Text = "INPUT VALUES";
            // 
            // lnlsaturation
            // 
            this.lnlsaturation.AutoSize = true;
            this.lnlsaturation.Location = new System.Drawing.Point(230, 236);
            this.lnlsaturation.Name = "lnlsaturation";
            this.lnlsaturation.Size = new System.Drawing.Size(97, 13);
            this.lnlsaturation.TabIndex = 9;
            this.lnlsaturation.Text = "Initial Oil Saturation";
            // 
            // lblerror
            // 
            this.lblerror.AutoSize = true;
            this.lblerror.Location = new System.Drawing.Point(12, 123);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(66, 13);
            this.lblerror.TabIndex = 10;
            this.lblerror.Text = "Current Error";
            // 
            // lbliteration
            // 
            this.lbliteration.AutoSize = true;
            this.lbliteration.Location = new System.Drawing.Point(12, 95);
            this.lbliteration.Name = "lbliteration";
            this.lbliteration.Size = new System.Drawing.Size(50, 13);
            this.lbliteration.TabIndex = 11;
            this.lbliteration.Text = "Iterations";
            // 
            // lblmomentum
            // 
            this.lblmomentum.AutoSize = true;
            this.lblmomentum.Location = new System.Drawing.Point(12, 63);
            this.lblmomentum.Name = "lblmomentum";
            this.lblmomentum.Size = new System.Drawing.Size(59, 13);
            this.lblmomentum.TabIndex = 12;
            this.lblmomentum.Text = "Momentum";
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(6, 116);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(100, 20);
            this.txtDepth.TabIndex = 13;
            this.txtDepth.MouseEnter += new System.EventHandler(this.txtDepth_MouseEnter);
            this.txtDepth.MouseLeave += new System.EventHandler(this.txtDepth_MouseLeave);
            // 
            // txtViscosity
            // 
            this.txtViscosity.Location = new System.Drawing.Point(6, 175);
            this.txtViscosity.Name = "txtViscosity";
            this.txtViscosity.Size = new System.Drawing.Size(100, 20);
            this.txtViscosity.TabIndex = 14;
            this.txtViscosity.MouseEnter += new System.EventHandler(this.txtViscosity_MouseEnter);
            this.txtViscosity.MouseLeave += new System.EventHandler(this.txtViscosity_MouseLeave);
            // 
            // txtGravity
            // 
            this.txtGravity.Location = new System.Drawing.Point(6, 147);
            this.txtGravity.Name = "txtGravity";
            this.txtGravity.Size = new System.Drawing.Size(100, 20);
            this.txtGravity.TabIndex = 15;
            this.txtGravity.MouseEnter += new System.EventHandler(this.txtGravity_MouseEnter);
            this.txtGravity.MouseLeave += new System.EventHandler(this.txtGravity_MouseLeave);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(6, 83);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 16;
            this.txtTemp.MouseEnter += new System.EventHandler(this.txtTemp_MouseEnter);
            this.txtTemp.MouseLeave += new System.EventHandler(this.txtTemp_MouseLeave);
            // 
            // txtPermeability
            // 
            this.txtPermeability.Location = new System.Drawing.Point(6, 52);
            this.txtPermeability.Name = "txtPermeability";
            this.txtPermeability.Size = new System.Drawing.Size(100, 20);
            this.txtPermeability.TabIndex = 17;
            this.txtPermeability.MouseEnter += new System.EventHandler(this.txtPermeability_MouseEnter);
            this.txtPermeability.MouseLeave += new System.EventHandler(this.txtPermeability_MouseLeave);
            // 
            // txtPorosity
            // 
            this.txtPorosity.Location = new System.Drawing.Point(6, 21);
            this.txtPorosity.Name = "txtPorosity";
            this.txtPorosity.Size = new System.Drawing.Size(100, 20);
            this.txtPorosity.TabIndex = 18;
            this.txtPorosity.MouseEnter += new System.EventHandler(this.txtPorosity_MouseEnter);
            this.txtPorosity.MouseLeave += new System.EventHandler(this.txtPorosity_MouseLeave);
            // 
            // txtError
            // 
            this.txtError.BackColor = System.Drawing.Color.White;
            this.txtError.Location = new System.Drawing.Point(92, 123);
            this.txtError.Name = "txtError";
            this.txtError.ReadOnly = true;
            this.txtError.Size = new System.Drawing.Size(100, 20);
            this.txtError.TabIndex = 19;
            // 
            // txtIteration
            // 
            this.txtIteration.BackColor = System.Drawing.Color.White;
            this.txtIteration.Location = new System.Drawing.Point(92, 95);
            this.txtIteration.Name = "txtIteration";
            this.txtIteration.ReadOnly = true;
            this.txtIteration.Size = new System.Drawing.Size(100, 20);
            this.txtIteration.TabIndex = 20;
            // 
            // txtMomentum
            // 
            this.txtMomentum.Location = new System.Drawing.Point(92, 63);
            this.txtMomentum.Name = "txtMomentum";
            this.txtMomentum.Size = new System.Drawing.Size(100, 20);
            this.txtMomentum.TabIndex = 21;
            this.txtMomentum.MouseEnter += new System.EventHandler(this.txtMomentum_MouseEnter);
            this.txtMomentum.MouseLeave += new System.EventHandler(this.txtMomentum_MouseLeave);
            // 
            // txtOilSaturation
            // 
            this.txtOilSaturation.Location = new System.Drawing.Point(6, 208);
            this.txtOilSaturation.Name = "txtOilSaturation";
            this.txtOilSaturation.Size = new System.Drawing.Size(100, 20);
            this.txtOilSaturation.TabIndex = 22;
            this.txtOilSaturation.MouseEnter += new System.EventHandler(this.txtOilSaturation_MouseEnter);
            this.txtOilSaturation.MouseLeave += new System.EventHandler(this.txtOilSaturation_MouseLeave);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioco2);
            this.groupBox1.Controls.Add(this.radiopolymer);
            this.groupBox1.Controls.Add(this.radioinsitu);
            this.groupBox1.Controls.Add(this.radiohydro);
            this.groupBox1.Controls.Add(this.radiosteam);
            this.groupBox1.Location = new System.Drawing.Point(528, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(148, 160);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Output";
            // 
            // radioco2
            // 
            this.radioco2.AutoSize = true;
            this.radioco2.Location = new System.Drawing.Point(6, 54);
            this.radioco2.Name = "radioco2";
            this.radioco2.Size = new System.Drawing.Size(87, 17);
            this.radioco2.TabIndex = 4;
            this.radioco2.TabStop = true;
            this.radioco2.Text = "CO2 Miscible";
            this.radioco2.UseVisualStyleBackColor = true;
            // 
            // radiopolymer
            // 
            this.radiopolymer.AutoSize = true;
            this.radiopolymer.Location = new System.Drawing.Point(6, 134);
            this.radiopolymer.Name = "radiopolymer";
            this.radiopolymer.Size = new System.Drawing.Size(105, 17);
            this.radiopolymer.TabIndex = 3;
            this.radiopolymer.TabStop = true;
            this.radiopolymer.Text = "Polymer Flooding";
            this.radiopolymer.UseVisualStyleBackColor = true;
            // 
            // radioinsitu
            // 
            this.radioinsitu.AutoSize = true;
            this.radioinsitu.Location = new System.Drawing.Point(6, 108);
            this.radioinsitu.Name = "radioinsitu";
            this.radioinsitu.Size = new System.Drawing.Size(113, 17);
            this.radioinsitu.TabIndex = 2;
            this.radioinsitu.TabStop = true;
            this.radioinsitu.Text = "In-Situ Combustion";
            this.radioinsitu.UseVisualStyleBackColor = true;
            // 
            // radiohydro
            // 
            this.radiohydro.AutoSize = true;
            this.radiohydro.Location = new System.Drawing.Point(6, 80);
            this.radiohydro.Name = "radiohydro";
            this.radiohydro.Size = new System.Drawing.Size(128, 17);
            this.radiohydro.TabIndex = 1;
            this.radiohydro.TabStop = true;
            this.radiohydro.Text = "HydroCarbon Miscible";
            this.radiohydro.UseVisualStyleBackColor = true;
            // 
            // radiosteam
            // 
            this.radiosteam.AutoSize = true;
            this.radiosteam.Location = new System.Drawing.Point(6, 25);
            this.radiosteam.Name = "radiosteam";
            this.radiosteam.Size = new System.Drawing.Size(55, 17);
            this.radiosteam.TabIndex = 0;
            this.radiosteam.TabStop = true;
            this.radiosteam.Text = "Steam";
            this.radiosteam.UseVisualStyleBackColor = true;
            // 
            // txtinstanthelp
            // 
            this.txtinstanthelp.BackColor = System.Drawing.Color.White;
            this.txtinstanthelp.ForeColor = System.Drawing.Color.Green;
            this.txtinstanthelp.Location = new System.Drawing.Point(12, 197);
            this.txtinstanthelp.Multiline = true;
            this.txtinstanthelp.Name = "txtinstanthelp";
            this.txtinstanthelp.ReadOnly = true;
            this.txtinstanthelp.Size = new System.Drawing.Size(180, 115);
            this.txtinstanthelp.TabIndex = 24;
            // 
            // btnApply
            // 
            this.btnApply.Image = ((System.Drawing.Image)(resources.GetObject("btnApply.Image")));
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(334, 280);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(80, 32);
            this.btnApply.TabIndex = 25;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            this.btnApply.MouseEnter += new System.EventHandler(this.btnApply_MouseEnter);
            this.btnApply.MouseLeave += new System.EventHandler(this.btnApply_MouseLeave);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(433, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 32);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            this.btnCancel.MouseEnter += new System.EventHandler(this.btnCancel_MouseEnter);
            this.btnCancel.MouseLeave += new System.EventHandler(this.btnCancel_MouseLeave);
            // 
            // lblinstanthelp
            // 
            this.lblinstanthelp.AutoSize = true;
            this.lblinstanthelp.Location = new System.Drawing.Point(12, 162);
            this.lblinstanthelp.Name = "lblinstanthelp";
            this.lblinstanthelp.Size = new System.Drawing.Size(64, 13);
            this.lblinstanthelp.TabIndex = 27;
            this.lblinstanthelp.Text = "Instant Help";
            // 
            // btnImport
            // 
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(233, 280);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(81, 32);
            this.btnImport.TabIndex = 28;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            this.btnImport.MouseEnter += new System.EventHandler(this.btnImport_MouseEnter);
            this.btnImport.MouseLeave += new System.EventHandler(this.btnImport_MouseLeave);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(302, 320);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(179, 15);
            this.progressBar1.TabIndex = 30;
            // 
            // lblProcess
            // 
            this.lblProcess.AutoSize = true;
            this.lblProcess.Location = new System.Drawing.Point(248, 320);
            this.lblProcess.Name = "lblProcess";
            this.lblProcess.Size = new System.Drawing.Size(48, 13);
            this.lblProcess.TabIndex = 31;
            this.lblProcess.Text = "Progress";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(119, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "md";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "˚F",
            "˚K",
            "˚C"});
            this.comboBox1.Location = new System.Drawing.Point(122, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(43, 21);
            this.comboBox1.TabIndex = 34;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.MouseEnter += new System.EventHandler(this.comboBox1_MouseEnter);
            this.comboBox1.MouseLeave += new System.EventHandler(this.comboBox1_MouseLeave);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ft",
            "m"});
            this.comboBox2.Location = new System.Drawing.Point(122, 115);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(43, 21);
            this.comboBox2.TabIndex = 35;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.MouseEnter += new System.EventHandler(this.comboBox2_MouseEnter);
            this.comboBox2.MouseLeave += new System.EventHandler(this.comboBox2_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(122, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "cp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(119, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "˚API";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "% of OOIP";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPorosity);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPermeability);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.txtTemp);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.txtDepth);
            this.groupBox2.Controls.Add(this.txtGravity);
            this.groupBox2.Controls.Add(this.txtOilSaturation);
            this.groupBox2.Controls.Add(this.txtViscosity);
            this.groupBox2.Location = new System.Drawing.Point(333, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 236);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 342);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblProcess);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblinstanthelp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.txtinstanthelp);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMomentum);
            this.Controls.Add(this.txtIteration);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.lblmomentum);
            this.Controls.Add(this.lbliteration);
            this.Controls.Add(this.lblerror);
            this.Controls.Add(this.lnlsaturation);
            this.Controls.Add(this.lblinput);
            this.Controls.Add(this.lblgravity);
            this.Controls.Add(this.lblviscosity);
            this.Controls.Add(this.lbltemp);
            this.Controls.Add(this.lbldepth);
            this.Controls.Add(this.lblporosity);
            this.Controls.Add(this.lblpermeability);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.lbllearningrate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "EOR Training";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllearningrate;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblpermeability;
        private System.Windows.Forms.Label lblporosity;
        private System.Windows.Forms.Label lbldepth;
        private System.Windows.Forms.Label lbltemp;
        private System.Windows.Forms.Label lblviscosity;
        private System.Windows.Forms.Label lblgravity;
        private System.Windows.Forms.Label lblinput;
        private System.Windows.Forms.Label lnlsaturation;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lbliteration;
        private System.Windows.Forms.Label lblmomentum;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.TextBox txtViscosity;
        private System.Windows.Forms.TextBox txtGravity;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtPermeability;
        private System.Windows.Forms.TextBox txtPorosity;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.TextBox txtIteration;
        private System.Windows.Forms.TextBox txtMomentum;
        private System.Windows.Forms.TextBox txtOilSaturation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioco2;
        private System.Windows.Forms.RadioButton radiopolymer;
        private System.Windows.Forms.RadioButton radioinsitu;
        private System.Windows.Forms.RadioButton radiohydro;
        private System.Windows.Forms.RadioButton radiosteam;
        private System.Windows.Forms.TextBox txtinstanthelp;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblinstanthelp;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

