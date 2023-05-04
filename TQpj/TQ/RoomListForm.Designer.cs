namespace TQ
{
    partial class RoomListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.roomlist = new System.Windows.Forms.Label();
            this.makebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.pnum,
            this.btn});
            this.dataGridView1.Location = new System.Drawing.Point(11, 88);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(983, 484);
            this.dataGridView1.TabIndex = 6;
            // 
            // name
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("나눔고딕", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name.DefaultCellStyle = dataGridViewCellStyle2;
            this.name.FillWeight = 164.6164F;
            this.name.HeaderText = "방 이름";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // pnum
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pnum.DefaultCellStyle = dataGridViewCellStyle3;
            this.pnum.FillWeight = 74.46986F;
            this.pnum.HeaderText = "접속 인원";
            this.pnum.MinimumWidth = 6;
            this.pnum.Name = "pnum";
            // 
            // btn
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("나눔고딕", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn.DefaultCellStyle = dataGridViewCellStyle4;
            this.btn.FillWeight = 60.9137F;
            this.btn.HeaderText = "버튼";
            this.btn.MinimumWidth = 6;
            this.btn.Name = "btn";
            this.btn.Text = "입장하기";
            // 
            // roomlist
            // 
            this.roomlist.AutoSize = true;
            this.roomlist.Font = new System.Drawing.Font("나눔고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.roomlist.Location = new System.Drawing.Point(12, 25);
            this.roomlist.Name = "roomlist";
            this.roomlist.Size = new System.Drawing.Size(261, 38);
            this.roomlist.TabIndex = 7;
            this.roomlist.Text = "현재 게임 방 목록";
            // 
            // makebtn
            // 
            this.makebtn.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.makebtn.Location = new System.Drawing.Point(847, 20);
            this.makebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.makebtn.Name = "makebtn";
            this.makebtn.Size = new System.Drawing.Size(147, 52);
            this.makebtn.TabIndex = 8;
            this.makebtn.Text = "방만들기";
            this.makebtn.UseVisualStyleBackColor = true;
            // 
            // RoomListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 583);
            this.Controls.Add(this.makebtn);
            this.Controls.Add(this.roomlist);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RoomListForm";
            this.Text = "RoomListForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnum;
        private System.Windows.Forms.DataGridViewButtonColumn btn;
        private System.Windows.Forms.Label roomlist;
        private System.Windows.Forms.Button makebtn;
    }
}