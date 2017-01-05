namespace ASFRedeemer
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "dfg",
            "sdf"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_redeem_type_3 = new System.Windows.Forms.RadioButton();
            this.comboBox_botname = new System.Windows.Forms.ComboBox();
            this.radioButton_redeem_type_2 = new System.Windows.Forms.RadioButton();
            this.checkBox_botname = new System.Windows.Forms.CheckBox();
            this.radioButton_redeem_type_1 = new System.Windows.Forms.RadioButton();
            this.button_redeem = new System.Windows.Forms.Button();
            this.richTextBox_keys = new System.Windows.Forms.RichTextBox();
            this.richTextBox_result = new System.Windows.Forms.RichTextBox();
            this.label_keys = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.label_found_keys = new System.Windows.Forms.Label();
            this.label_redeem_OK = new System.Windows.Forms.Label();
            this.textBox_search_in_result = new System.Windows.Forms.TextBox();
            this.label_redeem_AlreadyOwned = new System.Windows.Forms.Label();
            this.label_redeem_DuplicatedKey = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.radioButton_redeem_type_3);
            this.groupBox1.Controls.Add(this.comboBox_botname);
            this.groupBox1.Controls.Add(this.radioButton_redeem_type_2);
            this.groupBox1.Controls.Add(this.checkBox_botname);
            this.groupBox1.Controls.Add(this.radioButton_redeem_type_1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Redeem Type";
            // 
            // radioButton_redeem_type_3
            // 
            this.radioButton_redeem_type_3.AutoSize = true;
            this.radioButton_redeem_type_3.Location = new System.Drawing.Point(150, 19);
            this.radioButton_redeem_type_3.Name = "radioButton_redeem_type_3";
            this.radioButton_redeem_type_3.Size = new System.Drawing.Size(69, 17);
            this.radioButton_redeem_type_3.TabIndex = 2;
            this.radioButton_redeem_type_3.Tag = "redeem&";
            this.radioButton_redeem_type_3.Text = "!redeem&&";
            this.radioButton_redeem_type_3.UseVisualStyleBackColor = true;
            // 
            // comboBox_botname
            // 
            this.comboBox_botname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_botname.FormattingEnabled = true;
            this.comboBox_botname.Location = new System.Drawing.Point(66, 42);
            this.comboBox_botname.Name = "comboBox_botname";
            this.comboBox_botname.Size = new System.Drawing.Size(153, 21);
            this.comboBox_botname.TabIndex = 5;
            // 
            // radioButton_redeem_type_2
            // 
            this.radioButton_redeem_type_2.AutoSize = true;
            this.radioButton_redeem_type_2.Location = new System.Drawing.Point(75, 19);
            this.radioButton_redeem_type_2.Name = "radioButton_redeem_type_2";
            this.radioButton_redeem_type_2.Size = new System.Drawing.Size(69, 17);
            this.radioButton_redeem_type_2.TabIndex = 1;
            this.radioButton_redeem_type_2.Tag = "redeem^";
            this.radioButton_redeem_type_2.Text = "!redeem^";
            this.radioButton_redeem_type_2.UseVisualStyleBackColor = true;
            // 
            // checkBox_botname
            // 
            this.checkBox_botname.AutoSize = true;
            this.checkBox_botname.Location = new System.Drawing.Point(6, 44);
            this.checkBox_botname.Name = "checkBox_botname";
            this.checkBox_botname.Size = new System.Drawing.Size(54, 17);
            this.checkBox_botname.TabIndex = 4;
            this.checkBox_botname.Text = "<Bot>";
            this.checkBox_botname.UseVisualStyleBackColor = true;
            // 
            // radioButton_redeem_type_1
            // 
            this.radioButton_redeem_type_1.AutoSize = true;
            this.radioButton_redeem_type_1.Checked = true;
            this.radioButton_redeem_type_1.Location = new System.Drawing.Point(6, 19);
            this.radioButton_redeem_type_1.Name = "radioButton_redeem_type_1";
            this.radioButton_redeem_type_1.Size = new System.Drawing.Size(63, 17);
            this.radioButton_redeem_type_1.TabIndex = 0;
            this.radioButton_redeem_type_1.TabStop = true;
            this.radioButton_redeem_type_1.Tag = "redeem";
            this.radioButton_redeem_type_1.Text = "!redeem";
            this.radioButton_redeem_type_1.UseVisualStyleBackColor = true;
            // 
            // button_redeem
            // 
            this.button_redeem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_redeem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_redeem.ForeColor = System.Drawing.Color.Blue;
            this.button_redeem.Location = new System.Drawing.Point(243, 12);
            this.button_redeem.Name = "button_redeem";
            this.button_redeem.Size = new System.Drawing.Size(141, 82);
            this.button_redeem.TabIndex = 1;
            this.button_redeem.Text = "Redeem";
            this.button_redeem.UseVisualStyleBackColor = true;
            this.button_redeem.Click += new System.EventHandler(this.button_redeem_Click);
            // 
            // richTextBox_keys
            // 
            this.richTextBox_keys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_keys.Location = new System.Drawing.Point(12, 129);
            this.richTextBox_keys.Name = "richTextBox_keys";
            this.richTextBox_keys.Size = new System.Drawing.Size(225, 96);
            this.richTextBox_keys.TabIndex = 2;
            this.richTextBox_keys.Text = "";
            this.richTextBox_keys.TextChanged += new System.EventHandler(this.richTextBox_keys_TextChanged);
            // 
            // richTextBox_result
            // 
            this.richTextBox_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox_result.Location = new System.Drawing.Point(12, 257);
            this.richTextBox_result.Name = "richTextBox_result";
            this.richTextBox_result.Size = new System.Drawing.Size(225, 157);
            this.richTextBox_result.TabIndex = 3;
            this.richTextBox_result.Text = "";
            // 
            // label_keys
            // 
            this.label_keys.AutoSize = true;
            this.label_keys.Location = new System.Drawing.Point(12, 113);
            this.label_keys.Name = "label_keys";
            this.label_keys.Size = new System.Drawing.Size(33, 13);
            this.label_keys.TabIndex = 6;
            this.label_keys.Text = "Keys:";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(9, 241);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(40, 13);
            this.label_result.TabIndex = 7;
            this.label_result.Text = "Result:";
            // 
            // label_found_keys
            // 
            this.label_found_keys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_found_keys.AutoSize = true;
            this.label_found_keys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_found_keys.Location = new System.Drawing.Point(243, 132);
            this.label_found_keys.Name = "label_found_keys";
            this.label_found_keys.Size = new System.Drawing.Size(87, 13);
            this.label_found_keys.TabIndex = 8;
            this.label_found_keys.Text = "Found keys: 0";
            // 
            // label_redeem_OK
            // 
            this.label_redeem_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_redeem_OK.AutoSize = true;
            this.label_redeem_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_redeem_OK.ForeColor = System.Drawing.Color.Green;
            this.label_redeem_OK.Location = new System.Drawing.Point(243, 260);
            this.label_redeem_OK.Name = "label_redeem_OK";
            this.label_redeem_OK.Size = new System.Drawing.Size(44, 13);
            this.label_redeem_OK.TabIndex = 9;
            this.label_redeem_OK.Text = "OK: ...";
            // 
            // textBox_search_in_result
            // 
            this.textBox_search_in_result.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_search_in_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_search_in_result.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBox_search_in_result.Location = new System.Drawing.Point(78, 231);
            this.textBox_search_in_result.Name = "textBox_search_in_result";
            this.textBox_search_in_result.Size = new System.Drawing.Size(159, 20);
            this.textBox_search_in_result.TabIndex = 10;
            this.textBox_search_in_result.Text = "Search...";
            this.textBox_search_in_result.Visible = false;
            // 
            // label_redeem_AlreadyOwned
            // 
            this.label_redeem_AlreadyOwned.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_redeem_AlreadyOwned.AutoSize = true;
            this.label_redeem_AlreadyOwned.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_redeem_AlreadyOwned.ForeColor = System.Drawing.Color.Blue;
            this.label_redeem_AlreadyOwned.Location = new System.Drawing.Point(243, 273);
            this.label_redeem_AlreadyOwned.Name = "label_redeem_AlreadyOwned";
            this.label_redeem_AlreadyOwned.Size = new System.Drawing.Size(108, 13);
            this.label_redeem_AlreadyOwned.TabIndex = 11;
            this.label_redeem_AlreadyOwned.Text = "AlreadyOwned: ...";
            // 
            // label_redeem_DuplicatedKey
            // 
            this.label_redeem_DuplicatedKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_redeem_DuplicatedKey.AutoSize = true;
            this.label_redeem_DuplicatedKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_redeem_DuplicatedKey.ForeColor = System.Drawing.Color.Red;
            this.label_redeem_DuplicatedKey.Location = new System.Drawing.Point(243, 286);
            this.label_redeem_DuplicatedKey.Name = "label_redeem_DuplicatedKey";
            this.label_redeem_DuplicatedKey.Size = new System.Drawing.Size(109, 13);
            this.label_redeem_DuplicatedKey.TabIndex = 12;
            this.label_redeem_DuplicatedKey.Text = "DuplicatedKey: ...";
            // 
            // listView1
            // 
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(243, 317);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 13;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 426);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label_redeem_DuplicatedKey);
            this.Controls.Add(this.label_redeem_AlreadyOwned);
            this.Controls.Add(this.textBox_search_in_result);
            this.Controls.Add(this.label_redeem_OK);
            this.Controls.Add(this.label_found_keys);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_keys);
            this.Controls.Add(this.richTextBox_result);
            this.Controls.Add(this.richTextBox_keys);
            this.Controls.Add(this.button_redeem);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ASF Redeemer by Shmurdik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_redeem_type_3;
        private System.Windows.Forms.RadioButton radioButton_redeem_type_2;
        private System.Windows.Forms.RadioButton radioButton_redeem_type_1;
        private System.Windows.Forms.ComboBox comboBox_botname;
        private System.Windows.Forms.CheckBox checkBox_botname;
        private System.Windows.Forms.Button button_redeem;
        private System.Windows.Forms.RichTextBox richTextBox_keys;
        private System.Windows.Forms.RichTextBox richTextBox_result;
        private System.Windows.Forms.Label label_keys;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Label label_found_keys;
        private System.Windows.Forms.Label label_redeem_OK;
        private System.Windows.Forms.TextBox textBox_search_in_result;
        private System.Windows.Forms.Label label_redeem_AlreadyOwned;
        private System.Windows.Forms.Label label_redeem_DuplicatedKey;
        private System.Windows.Forms.ListView listView1;
    }
}

