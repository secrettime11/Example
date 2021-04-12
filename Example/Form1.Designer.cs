namespace Example
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_run = new Sunny.UI.UIButton();
            this.dp_date = new Sunny.UI.UIDatePicker();
            this.dgv_data = new Sunny.UI.UIDataGridView();
            this.gp_strategy = new Sunny.UI.UIGroupBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.txt_turnover = new Sunny.UI.UITextBox();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).BeginInit();
            this.gp_strategy.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_run
            // 
            this.btn_run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_run.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btn_run.Location = new System.Drawing.Point(12, 279);
            this.btn_run.MinimumSize = new System.Drawing.Size(1, 1);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(151, 35);
            this.btn_run.TabIndex = 0;
            this.btn_run.Text = "Run";
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // dp_date
            // 
            this.dp_date.FillColor = System.Drawing.Color.White;
            this.dp_date.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dp_date.Location = new System.Drawing.Point(13, 14);
            this.dp_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dp_date.MaxLength = 10;
            this.dp_date.MinimumSize = new System.Drawing.Size(63, 0);
            this.dp_date.Name = "dp_date";
            this.dp_date.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dp_date.Size = new System.Drawing.Size(150, 29);
            this.dp_date.SymbolDropDown = 61555;
            this.dp_date.SymbolNormal = 61555;
            this.dp_date.TabIndex = 1;
            this.dp_date.Text = "2021-04-11";
            this.dp_date.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dp_date.Value = new System.DateTime(2021, 4, 11, 0, 53, 52, 878);
            // 
            // dgv_data
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dgv_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_data.BackgroundColor = System.Drawing.Color.White;
            this.dgv_data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_data.EnableHeadersVisualStyles = false;
            this.dgv_data.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.dgv_data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.dgv_data.Location = new System.Drawing.Point(182, 14);
            this.dgv_data.Name = "dgv_data";
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgv_data.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_data.RowTemplate.Height = 29;
            this.dgv_data.SelectedIndex = -1;
            this.dgv_data.ShowGridLine = true;
            this.dgv_data.Size = new System.Drawing.Size(594, 300);
            this.dgv_data.TabIndex = 2;
            // 
            // gp_strategy
            // 
            this.gp_strategy.Controls.Add(this.uiLabel5);
            this.gp_strategy.Controls.Add(this.uiLabel4);
            this.gp_strategy.Controls.Add(this.uiLabel3);
            this.gp_strategy.Controls.Add(this.uiLabel2);
            this.gp_strategy.Controls.Add(this.txt_turnover);
            this.gp_strategy.Controls.Add(this.uiLabel1);
            this.gp_strategy.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.gp_strategy.Location = new System.Drawing.Point(13, 53);
            this.gp_strategy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gp_strategy.MinimumSize = new System.Drawing.Size(1, 1);
            this.gp_strategy.Name = "gp_strategy";
            this.gp_strategy.Padding = new System.Windows.Forms.Padding(0, 32, 0, 0);
            this.gp_strategy.Size = new System.Drawing.Size(150, 218);
            this.gp_strategy.TabIndex = 3;
            this.gp_strategy.Text = "Strategy";
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel3.Location = new System.Drawing.Point(56, 149);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(35, 23);
            this.uiLabel3.TabIndex = 9;
            this.uiLabel3.Text = "▼";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel2.Location = new System.Drawing.Point(56, 81);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(35, 23);
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "▼";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_turnover
            // 
            this.txt_turnover.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_turnover.DoubleValue = 10D;
            this.txt_turnover.FillColor = System.Drawing.Color.White;
            this.txt_turnover.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.txt_turnover.IntValue = 10;
            this.txt_turnover.Location = new System.Drawing.Point(86, 41);
            this.txt_turnover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_turnover.Maximum = 2147483647D;
            this.txt_turnover.Minimum = -2147483648D;
            this.txt_turnover.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_turnover.Name = "txt_turnover";
            this.txt_turnover.Padding = new System.Windows.Forms.Padding(5);
            this.txt_turnover.Size = new System.Drawing.Size(40, 29);
            this.txt_turnover.TabIndex = 5;
            this.txt_turnover.Text = "10";
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel1.Location = new System.Drawing.Point(17, 46);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(62, 23);
            this.uiLabel1.TabIndex = 4;
            this.uiLabel1.Text = "周轉 >";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel4.Location = new System.Drawing.Point(42, 112);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(62, 23);
            this.uiLabel4.TabIndex = 10;
            this.uiLabel4.Text = "收盤跌";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel5
            // 
            this.uiLabel5.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.uiLabel5.Location = new System.Drawing.Point(34, 181);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(84, 23);
            this.uiLabel5.TabIndex = 11;
            this.uiLabel5.Text = "法人買超";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 327);
            this.Controls.Add(this.gp_strategy);
            this.Controls.Add(this.dgv_data);
            this.Controls.Add(this.dp_date);
            this.Controls.Add(this.btn_run);
            this.Name = "Form1";
            this.Text = "Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_data)).EndInit();
            this.gp_strategy.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton btn_run;
        private Sunny.UI.UIDatePicker dp_date;
        private Sunny.UI.UIDataGridView dgv_data;
        private Sunny.UI.UIGroupBox gp_strategy;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txt_turnover;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
    }
}

