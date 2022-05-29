namespace ML.RecommendDemo
{
    partial class frmDemoRecommend
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDemoRecommend));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoadCustomer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTestRatio = new System.Windows.Forms.TextBox();
            this.rad1 = new System.Windows.Forms.RadioButton();
            this.rad2 = new System.Windows.Forms.RadioButton();
            this.rad3 = new System.Windows.Forms.RadioButton();
            this.rad4 = new System.Windows.Forms.RadioButton();
            this.rad5 = new System.Windows.Forms.RadioButton();
            this.btnImportDataset = new System.Windows.Forms.Button();
            this.lblImportDatasetMessage = new System.Windows.Forms.Label();
            this.btnBuildModel = new System.Windows.Forms.Button();
            this.lblBuildModelMessage = new System.Windows.Forms.Label();
            this.btnEvaluateModel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSquared = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMAE = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMSE = new System.Windows.Forms.TextBox();
            this.txtRMSE = new System.Windows.Forms.TextBox();
            this.btnSaveModel = new System.Windows.Forms.Button();
            this.lblSaveModelMessage = new System.Windows.Forms.Label();
            this.cboModel = new System.Windows.Forms.ComboBox();
            this.btnLoadModel = new System.Windows.Forms.Button();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnPredict = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.txtRank = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIterator = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoadRating = new System.Windows.Forms.Button();
            this.btnLoadProduct = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblLoadModelMessage = new System.Windows.Forms.Label();
            this.txtExpectedScore = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dataset:";
            // 
            // btnLoadCustomer
            // 
            this.btnLoadCustomer.Image = global::ML.RecommendDemo.Properties.Resources.ic_customer;
            this.btnLoadCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadCustomer.Location = new System.Drawing.Point(74, 20);
            this.btnLoadCustomer.Name = "btnLoadCustomer";
            this.btnLoadCustomer.Size = new System.Drawing.Size(109, 25);
            this.btnLoadCustomer.TabIndex = 2;
            this.btnLoadCustomer.Text = "Load Customer";
            this.btnLoadCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadCustomer.UseVisualStyleBackColor = true;
            this.btnLoadCustomer.Click += new System.EventHandler(this.btnLoadCustomer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Test Ratio:";
            // 
            // txtTestRatio
            // 
            this.txtTestRatio.Location = new System.Drawing.Point(352, 78);
            this.txtTestRatio.Name = "txtTestRatio";
            this.txtTestRatio.Size = new System.Drawing.Size(70, 23);
            this.txtTestRatio.TabIndex = 4;
            this.txtTestRatio.Text = "0.2";
            // 
            // rad1
            // 
            this.rad1.AutoSize = true;
            this.rad1.Location = new System.Drawing.Point(86, 82);
            this.rad1.Name = "rad1";
            this.rad1.Size = new System.Drawing.Size(40, 19);
            this.rad1.TabIndex = 5;
            this.rad1.Text = "0.1";
            this.rad1.UseVisualStyleBackColor = true;
            this.rad1.CheckedChanged += new System.EventHandler(this.rad1_CheckedChanged);
            // 
            // rad2
            // 
            this.rad2.AutoSize = true;
            this.rad2.Checked = true;
            this.rad2.Location = new System.Drawing.Point(141, 82);
            this.rad2.Name = "rad2";
            this.rad2.Size = new System.Drawing.Size(40, 19);
            this.rad2.TabIndex = 5;
            this.rad2.TabStop = true;
            this.rad2.Text = "0.2";
            this.rad2.UseVisualStyleBackColor = true;
            this.rad2.CheckedChanged += new System.EventHandler(this.rad2_CheckedChanged);
            // 
            // rad3
            // 
            this.rad3.AutoSize = true;
            this.rad3.Location = new System.Drawing.Point(192, 82);
            this.rad3.Name = "rad3";
            this.rad3.Size = new System.Drawing.Size(40, 19);
            this.rad3.TabIndex = 5;
            this.rad3.Text = "0.3";
            this.rad3.UseVisualStyleBackColor = true;
            this.rad3.CheckedChanged += new System.EventHandler(this.rad3_CheckedChanged);
            // 
            // rad4
            // 
            this.rad4.AutoSize = true;
            this.rad4.Location = new System.Drawing.Point(240, 82);
            this.rad4.Name = "rad4";
            this.rad4.Size = new System.Drawing.Size(40, 19);
            this.rad4.TabIndex = 5;
            this.rad4.Text = "0.4";
            this.rad4.UseVisualStyleBackColor = true;
            this.rad4.CheckedChanged += new System.EventHandler(this.rad4_CheckedChanged);
            // 
            // rad5
            // 
            this.rad5.AutoSize = true;
            this.rad5.Location = new System.Drawing.Point(295, 82);
            this.rad5.Name = "rad5";
            this.rad5.Size = new System.Drawing.Size(40, 19);
            this.rad5.TabIndex = 5;
            this.rad5.Text = "0.5";
            this.rad5.UseVisualStyleBackColor = true;
            this.rad5.CheckedChanged += new System.EventHandler(this.rad5_CheckedChanged);
            // 
            // btnImportDataset
            // 
            this.btnImportDataset.Image = global::ML.RecommendDemo.Properties.Resources.ic_import;
            this.btnImportDataset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportDataset.Location = new System.Drawing.Point(76, 108);
            this.btnImportDataset.Name = "btnImportDataset";
            this.btnImportDataset.Size = new System.Drawing.Size(346, 25);
            this.btnImportDataset.TabIndex = 6;
            this.btnImportDataset.Text = "1. Import && split dataset for train and test set";
            this.btnImportDataset.UseVisualStyleBackColor = true;
            this.btnImportDataset.Click += new System.EventHandler(this.btnImportDataset_Click);
            // 
            // lblImportDatasetMessage
            // 
            this.lblImportDatasetMessage.AutoSize = true;
            this.lblImportDatasetMessage.Location = new System.Drawing.Point(73, 138);
            this.lblImportDatasetMessage.Name = "lblImportDatasetMessage";
            this.lblImportDatasetMessage.Size = new System.Drawing.Size(0, 15);
            this.lblImportDatasetMessage.TabIndex = 7;
            // 
            // btnBuildModel
            // 
            this.btnBuildModel.Image = global::ML.RecommendDemo.Properties.Resources.ic_build;
            this.btnBuildModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuildModel.Location = new System.Drawing.Point(76, 158);
            this.btnBuildModel.Name = "btnBuildModel";
            this.btnBuildModel.Size = new System.Drawing.Size(137, 25);
            this.btnBuildModel.TabIndex = 6;
            this.btnBuildModel.Text = "2. Build Model";
            this.btnBuildModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuildModel.UseVisualStyleBackColor = true;
            this.btnBuildModel.Click += new System.EventHandler(this.btnBuildModel_Click);
            // 
            // lblBuildModelMessage
            // 
            this.lblBuildModelMessage.AutoSize = true;
            this.lblBuildModelMessage.Location = new System.Drawing.Point(73, 186);
            this.lblBuildModelMessage.Name = "lblBuildModelMessage";
            this.lblBuildModelMessage.Size = new System.Drawing.Size(0, 15);
            this.lblBuildModelMessage.TabIndex = 7;
            // 
            // btnEvaluateModel
            // 
            this.btnEvaluateModel.Image = global::ML.RecommendDemo.Properties.Resources.ic_verify1;
            this.btnEvaluateModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEvaluateModel.Location = new System.Drawing.Point(76, 205);
            this.btnEvaluateModel.Name = "btnEvaluateModel";
            this.btnEvaluateModel.Size = new System.Drawing.Size(346, 25);
            this.btnEvaluateModel.TabIndex = 6;
            this.btnEvaluateModel.Text = "3. Evaluate model";
            this.btnEvaluateModel.UseVisualStyleBackColor = true;
            this.btnEvaluateModel.Click += new System.EventHandler(this.btnEvaluateModel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "R-Squared:";
            // 
            // txtSquared
            // 
            this.txtSquared.Location = new System.Drawing.Point(146, 236);
            this.txtSquared.Name = "txtSquared";
            this.txtSquared.Size = new System.Drawing.Size(88, 23);
            this.txtSquared.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(278, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "MAE:";
            // 
            // txtMAE
            // 
            this.txtMAE.Location = new System.Drawing.Point(334, 236);
            this.txtMAE.Name = "txtMAE";
            this.txtMAE.Size = new System.Drawing.Size(88, 23);
            this.txtMAE.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "MSE:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "RMSE:";
            // 
            // txtMSE
            // 
            this.txtMSE.Location = new System.Drawing.Point(146, 266);
            this.txtMSE.Name = "txtMSE";
            this.txtMSE.Size = new System.Drawing.Size(88, 23);
            this.txtMSE.TabIndex = 8;
            // 
            // txtRMSE
            // 
            this.txtRMSE.Location = new System.Drawing.Point(334, 266);
            this.txtRMSE.Name = "txtRMSE";
            this.txtRMSE.Size = new System.Drawing.Size(88, 23);
            this.txtRMSE.TabIndex = 8;
            // 
            // btnSaveModel
            // 
            this.btnSaveModel.Image = global::ML.RecommendDemo.Properties.Resources.ic_save;
            this.btnSaveModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveModel.Location = new System.Drawing.Point(76, 293);
            this.btnSaveModel.Name = "btnSaveModel";
            this.btnSaveModel.Size = new System.Drawing.Size(346, 25);
            this.btnSaveModel.TabIndex = 6;
            this.btnSaveModel.Text = "4. Save Model";
            this.btnSaveModel.UseVisualStyleBackColor = true;
            this.btnSaveModel.Click += new System.EventHandler(this.btnSaveModel_Click);
            // 
            // lblSaveModelMessage
            // 
            this.lblSaveModelMessage.AutoSize = true;
            this.lblSaveModelMessage.Location = new System.Drawing.Point(73, 320);
            this.lblSaveModelMessage.Name = "lblSaveModelMessage";
            this.lblSaveModelMessage.Size = new System.Drawing.Size(0, 15);
            this.lblSaveModelMessage.TabIndex = 7;
            // 
            // cboModel
            // 
            this.cboModel.FormattingEnabled = true;
            this.cboModel.Location = new System.Drawing.Point(186, 26);
            this.cboModel.Name = "cboModel";
            this.cboModel.Size = new System.Drawing.Size(227, 23);
            this.cboModel.TabIndex = 9;
            // 
            // btnLoadModel
            // 
            this.btnLoadModel.Image = global::ML.RecommendDemo.Properties.Resources.ic_load;
            this.btnLoadModel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadModel.Location = new System.Drawing.Point(73, 26);
            this.btnLoadModel.Name = "btnLoadModel";
            this.btnLoadModel.Size = new System.Drawing.Size(107, 25);
            this.btnLoadModel.TabIndex = 6;
            this.btnLoadModel.Text = "5. Load Model";
            this.btnLoadModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadModel.UseVisualStyleBackColor = true;
            this.btnLoadModel.Click += new System.EventHandler(this.btnLoadModel_Click);
            // 
            // cboProduct
            // 
            this.cboProduct.FormattingEnabled = true;
            this.cboProduct.Location = new System.Drawing.Point(117, 118);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(296, 23);
            this.cboProduct.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "Product:";
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(117, 80);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(296, 23);
            this.cboCustomer.TabIndex = 20;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 15);
            this.label12.TabIndex = 18;
            this.label12.Text = "Customer:";
            // 
            // btnPredict
            // 
            this.btnPredict.Image = global::ML.RecommendDemo.Properties.Resources.ic_predict;
            this.btnPredict.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPredict.Location = new System.Drawing.Point(247, 150);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(99, 25);
            this.btnPredict.TabIndex = 6;
            this.btnPredict.Text = "6. Recommend";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(26, 180);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(370, 45);
            this.lblResult.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.txtRank);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIterator);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnLoadRating);
            this.groupBox1.Controls.Add(this.btnLoadProduct);
            this.groupBox1.Controls.Add(this.btnLoadCustomer);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTestRatio);
            this.groupBox1.Controls.Add(this.rad1);
            this.groupBox1.Controls.Add(this.txtRMSE);
            this.groupBox1.Controls.Add(this.lblSaveModelMessage);
            this.groupBox1.Controls.Add(this.rad2);
            this.groupBox1.Controls.Add(this.txtMAE);
            this.groupBox1.Controls.Add(this.rad3);
            this.groupBox1.Controls.Add(this.txtMSE);
            this.groupBox1.Controls.Add(this.rad4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.rad5);
            this.groupBox1.Controls.Add(this.txtSquared);
            this.groupBox1.Controls.Add(this.btnImportDataset);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnBuildModel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSaveModel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnEvaluateModel);
            this.groupBox1.Controls.Add(this.lblImportDatasetMessage);
            this.groupBox1.Controls.Add(this.lblBuildModelMessage);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 345);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phase 1: Build Model";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "MM/dd/yyyy";
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(336, 50);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(86, 23);
            this.dtpTo.TabIndex = 12;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CustomFormat = "MM/dd/yyyy";
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(224, 51);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(86, 23);
            this.dtpFrom.TabIndex = 12;
            // 
            // txtRank
            // 
            this.txtRank.Location = new System.Drawing.Point(378, 158);
            this.txtRank.Name = "txtRank";
            this.txtRank.Size = new System.Drawing.Size(44, 23);
            this.txtRank.TabIndex = 11;
            this.txtRank.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rank:";
            // 
            // txtIterator
            // 
            this.txtIterator.Location = new System.Drawing.Point(274, 158);
            this.txtIterator.Name = "txtIterator";
            this.txtIterator.Size = new System.Drawing.Size(44, 23);
            this.txtIterator.TabIndex = 11;
            this.txtIterator.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Iterator:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ML.RecommendDemo.Properties.Resources.ic_number4;
            this.pictureBox4.Location = new System.Drawing.Point(37, 295);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(27, 23);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ML.RecommendDemo.Properties.Resources.ic_number3;
            this.pictureBox3.Location = new System.Drawing.Point(38, 208);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 23);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ML.RecommendDemo.Properties.Resources.ic_number2;
            this.pictureBox2.Location = new System.Drawing.Point(38, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 23);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ML.RecommendDemo.Properties.Resources.ic_number1;
            this.pictureBox1.Location = new System.Drawing.Point(37, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 23);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoadRating
            // 
            this.btnLoadRating.Image = global::ML.RecommendDemo.Properties.Resources.ic_rating;
            this.btnLoadRating.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadRating.Location = new System.Drawing.Point(74, 51);
            this.btnLoadRating.Name = "btnLoadRating";
            this.btnLoadRating.Size = new System.Drawing.Size(109, 25);
            this.btnLoadRating.TabIndex = 2;
            this.btnLoadRating.Text = "Load Rating";
            this.btnLoadRating.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadRating.UseVisualStyleBackColor = true;
            this.btnLoadRating.Click += new System.EventHandler(this.btnLoadRating_Click);
            // 
            // btnLoadProduct
            // 
            this.btnLoadProduct.Image = global::ML.RecommendDemo.Properties.Resources.ic_product;
            this.btnLoadProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadProduct.Location = new System.Drawing.Point(189, 20);
            this.btnLoadProduct.Name = "btnLoadProduct";
            this.btnLoadProduct.Size = new System.Drawing.Size(103, 25);
            this.btnLoadProduct.TabIndex = 2;
            this.btnLoadProduct.Text = "Load Product";
            this.btnLoadProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoadProduct.UseVisualStyleBackColor = true;
            this.btnLoadProduct.Click += new System.EventHandler(this.btnLoadProduct_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(312, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 15);
            this.label13.TabIndex = 3;
            this.label13.Text = "To:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 15);
            this.label10.TabIndex = 3;
            this.label10.Text = "From:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox2.Controls.Add(this.pictureBox6);
            this.groupBox2.Controls.Add(this.pictureBox5);
            this.groupBox2.Controls.Add(this.btnLoadModel);
            this.groupBox2.Controls.Add(this.btnPredict);
            this.groupBox2.Controls.Add(this.cboProduct);
            this.groupBox2.Controls.Add(this.lblResult);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboModel);
            this.groupBox2.Controls.Add(this.cboCustomer);
            this.groupBox2.Controls.Add(this.lblLoadModelMessage);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtExpectedScore);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(3, 353);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 228);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phase 2: Use Model";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ML.RecommendDemo.Properties.Resources.ic_number6;
            this.pictureBox6.Location = new System.Drawing.Point(214, 152);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(27, 23);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ML.RecommendDemo.Properties.Resources.ic_number5;
            this.pictureBox5.Location = new System.Drawing.Point(35, 26);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(27, 23);
            this.pictureBox5.TabIndex = 9;
            this.pictureBox5.TabStop = false;
            // 
            // lblLoadModelMessage
            // 
            this.lblLoadModelMessage.AutoSize = true;
            this.lblLoadModelMessage.Location = new System.Drawing.Point(101, 56);
            this.lblLoadModelMessage.Name = "lblLoadModelMessage";
            this.lblLoadModelMessage.Size = new System.Drawing.Size(0, 15);
            this.lblLoadModelMessage.TabIndex = 7;
            // 
            // txtExpectedScore
            // 
            this.txtExpectedScore.Location = new System.Drawing.Point(117, 150);
            this.txtExpectedScore.Name = "txtExpectedScore";
            this.txtExpectedScore.Size = new System.Drawing.Size(88, 23);
            this.txtExpectedScore.TabIndex = 8;
            this.txtExpectedScore.Text = "3.5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 7;
            this.label9.Text = "Expected Score:";
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Image = global::ML.RecommendDemo.Properties.Resources.ic_more;
            this.btnAdvanced.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdvanced.Location = new System.Drawing.Point(163, 584);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(104, 25);
            this.btnAdvanced.TabIndex = 23;
            this.btnAdvanced.Text = "Advanced";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Json Format |*.json";
            // 
            // frmDemoRecommend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(437, 613);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDemoRecommend";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ML.Recommend - KMOU - Data Science Lab - 407";
            this.Load += new System.EventHandler(this.frmDemoRecommend_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button btnLoadCustomer;
        private Label label2;
        private TextBox txtTestRatio;
        private RadioButton rad1;
        private RadioButton rad2;
        private RadioButton rad3;
        private RadioButton rad4;
        private RadioButton rad5;
        private Button btnImportDataset;
        private Label lblImportDatasetMessage;
        private Button btnBuildModel;
        private Label lblBuildModelMessage;
        private Button btnEvaluateModel;
        private Label label5;
        private TextBox txtSquared;
        private Label label6;
        private TextBox txtMAE;
        private Label label7;
        private Label label8;
        private TextBox txtMSE;
        private TextBox txtRMSE;
        private Button btnSaveModel;
        private Label lblSaveModelMessage;
        private ComboBox cboModel;
        private Button btnLoadModel;
        private ComboBox cboProduct;
        private Label label11;
        private ComboBox cboCustomer;
        private Label label12;
        private Button btnPredict;
        private Label lblResult;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnAdvanced;
        private Label lblLoadModelMessage;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Button btnLoadProduct;
        private Button btnLoadRating;
        private OpenFileDialog openFileDialog1;
        private Label label3;
        private TextBox txtIterator;
        private TextBox txtRank;
        private Label label4;
        private TextBox txtExpectedScore;
        private Label label9;
        private Label label10;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Label label13;
    }
}