namespace F010
{
    partial class QueriesFromProducts
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonQueryRefresh = new System.Windows.Forms.Button();
            this.listViewBasic = new System.Windows.Forms.ListView();
            this.comboBoxQueries = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBoxInputParameter = new System.Windows.Forms.TextBox();
            this.labelProductOrderCountToMeasure = new System.Windows.Forms.Label();
            this.checkBoxCSharpWay = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(12, 256);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Kilépés";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonQueryRefresh
            // 
            this.buttonQueryRefresh.Location = new System.Drawing.Point(617, 256);
            this.buttonQueryRefresh.Name = "buttonQueryRefresh";
            this.buttonQueryRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonQueryRefresh.TabIndex = 0;
            this.buttonQueryRefresh.Text = "Frissítés";
            this.buttonQueryRefresh.UseVisualStyleBackColor = true;
            this.buttonQueryRefresh.Click += new System.EventHandler(this.buttonQuery_Click);
            // 
            // listViewBasic
            // 
            this.listViewBasic.HideSelection = false;
            this.listViewBasic.Location = new System.Drawing.Point(12, 48);
            this.listViewBasic.Name = "listViewBasic";
            this.listViewBasic.Size = new System.Drawing.Size(680, 198);
            this.listViewBasic.TabIndex = 2;
            this.listViewBasic.UseCompatibleStateImageBehavior = false;
            this.listViewBasic.View = System.Windows.Forms.View.Details;
            // 
            // comboBoxQueries
            // 
            this.comboBoxQueries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxQueries.FormattingEnabled = true;
            this.comboBoxQueries.Location = new System.Drawing.Point(12, 12);
            this.comboBoxQueries.Name = "comboBoxQueries";
            this.comboBoxQueries.Size = new System.Drawing.Size(341, 21);
            this.comboBoxQueries.TabIndex = 3;
            this.comboBoxQueries.SelectedIndexChanged += new System.EventHandler(this.comboBoxQueries_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(363, 14);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Átlagárral számolva";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBoxInputParameter
            // 
            this.textBoxInputParameter.Location = new System.Drawing.Point(574, 12);
            this.textBoxInputParameter.Name = "textBoxInputParameter";
            this.textBoxInputParameter.Size = new System.Drawing.Size(42, 20);
            this.textBoxInputParameter.TabIndex = 6;
            // 
            // labelProductOrderCountToMeasure
            // 
            this.labelProductOrderCountToMeasure.AutoSize = true;
            this.labelProductOrderCountToMeasure.Location = new System.Drawing.Point(482, 15);
            this.labelProductOrderCountToMeasure.Name = "labelProductOrderCountToMeasure";
            this.labelProductOrderCountToMeasure.Size = new System.Drawing.Size(90, 13);
            this.labelProductOrderCountToMeasure.TabIndex = 7;
            this.labelProductOrderCountToMeasure.Text = "Viszonyítási szám";
            // 
            // checkBoxCSharpWay
            // 
            this.checkBoxCSharpWay.AutoSize = true;
            this.checkBoxCSharpWay.Location = new System.Drawing.Point(629, 14);
            this.checkBoxCSharpWay.Name = "checkBoxCSharpWay";
            this.checkBoxCSharpWay.Size = new System.Drawing.Size(63, 17);
            this.checkBoxCSharpWay.TabIndex = 9;
            this.checkBoxCSharpWay.Text = "C# mód";
            this.checkBoxCSharpWay.UseVisualStyleBackColor = true;
            // 
            // QueriesFromProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 291);
            this.Controls.Add(this.checkBoxCSharpWay);
            this.Controls.Add(this.labelProductOrderCountToMeasure);
            this.Controls.Add(this.textBoxInputParameter);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBoxQueries);
            this.Controls.Add(this.listViewBasic);
            this.Controls.Add(this.buttonQueryRefresh);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "QueriesFromProducts";
            this.Text = "Queries From Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonQueryRefresh;
        private System.Windows.Forms.ListView listViewBasic;
        private System.Windows.Forms.ComboBox comboBoxQueries;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxInputParameter;
        private System.Windows.Forms.Label labelProductOrderCountToMeasure;
        private System.Windows.Forms.CheckBox checkBoxCSharpWay;
    }
}

