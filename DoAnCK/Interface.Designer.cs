
namespace DoAnCK
{
    partial class Interface
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
            this.panelAnimation = new MetroFramework.Controls.MetroPanel();
            this.btnBuble = new MetroFramework.Controls.MetroRadioButton();
            this.btnMerge = new MetroFramework.Controls.MetroRadioButton();
            this.btnRadix = new MetroFramework.Controls.MetroRadioButton();
            this.tbSortData = new MetroFramework.Controls.MetroTextBox();
            this.btnRandom = new MetroFramework.Controls.MetroButton();
            this.btnSort = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnStop = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // panelAnimation
            // 
            this.panelAnimation.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.panelAnimation.HorizontalScrollbarBarColor = true;
            this.panelAnimation.HorizontalScrollbarHighlightOnWheel = false;
            this.panelAnimation.HorizontalScrollbarSize = 10;
            this.panelAnimation.Location = new System.Drawing.Point(21, 67);
            this.panelAnimation.Name = "panelAnimation";
            this.panelAnimation.Size = new System.Drawing.Size(1024, 457);
            this.panelAnimation.TabIndex = 1;
            this.panelAnimation.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.panelAnimation.VerticalScrollbarBarColor = true;
            this.panelAnimation.VerticalScrollbarHighlightOnWheel = false;
            this.panelAnimation.VerticalScrollbarSize = 10;
            // 
            // btnBuble
            // 
            this.btnBuble.AutoSize = true;
            this.btnBuble.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.btnBuble.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.btnBuble.Location = new System.Drawing.Point(261, 30);
            this.btnBuble.Name = "btnBuble";
            this.btnBuble.Size = new System.Drawing.Size(97, 20);
            this.btnBuble.TabIndex = 1;
            this.btnBuble.TabStop = true;
            this.btnBuble.Text = "Buble sort";
            this.btnBuble.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnBuble.UseVisualStyleBackColor = true;
            // 
            // btnMerge
            // 
            this.btnMerge.AutoSize = true;
            this.btnMerge.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.btnMerge.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.btnMerge.Location = new System.Drawing.Point(470, 30);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(102, 20);
            this.btnMerge.TabIndex = 2;
            this.btnMerge.TabStop = true;
            this.btnMerge.Text = "Merge sort";
            this.btnMerge.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnMerge.UseVisualStyleBackColor = true;
            // 
            // btnRadix
            // 
            this.btnRadix.AutoSize = true;
            this.btnRadix.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.btnRadix.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.btnRadix.Location = new System.Drawing.Point(710, 30);
            this.btnRadix.Name = "btnRadix";
            this.btnRadix.Size = new System.Drawing.Size(96, 20);
            this.btnRadix.TabIndex = 3;
            this.btnRadix.TabStop = true;
            this.btnRadix.Text = "Radix sort";
            this.btnRadix.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRadix.UseVisualStyleBackColor = true;
            // 
            // tbSortData
            // 
            this.tbSortData.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbSortData.Location = new System.Drawing.Point(21, 553);
            this.tbSortData.Name = "tbSortData";
            this.tbSortData.Size = new System.Drawing.Size(230, 23);
            this.tbSortData.TabIndex = 3;
            this.tbSortData.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tbSortData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbSortData_KeyDown);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(283, 553);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(75, 23);
            this.btnRandom.TabIndex = 4;
            this.btnRandom.Text = "Random";
            this.btnRandom.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(388, 553);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort";
            this.btnSort.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(670, 553);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(395, 20);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "Nhóm 18 - Nguyễn Minh Khang, Nguyễn Văn Sơn Tùng";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(497, 553);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 600);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.tbSortData);
            this.Controls.Add(this.btnRadix);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.btnBuble);
            this.Controls.Add(this.panelAnimation);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Interface";
            this.Padding = new System.Windows.Forms.Padding(18, 64, 18, 21);
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Thuật toán sắp xếp";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Interface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panelAnimation;
        private MetroFramework.Controls.MetroRadioButton btnBuble;
        private MetroFramework.Controls.MetroRadioButton btnMerge;
        private MetroFramework.Controls.MetroRadioButton btnRadix;
        private MetroFramework.Controls.MetroTextBox tbSortData;
        private MetroFramework.Controls.MetroButton btnRandom;
        private MetroFramework.Controls.MetroButton btnSort;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel[] lbCol = new MetroFramework.Controls.MetroLabel[MAXCOLUMN];
        private MetroFramework.Controls.MetroButton btnStop;
    }
}

