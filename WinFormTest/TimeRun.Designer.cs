
namespace WinFormTest
{
    partial class TimeRun
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
            this.components = new System.ComponentModel.Container();
            this.labTimer = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labWeek = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labTimer
            // 
            this.labTimer.AutoSize = true;
            this.labTimer.Font = new System.Drawing.Font("新細明體", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTimer.Location = new System.Drawing.Point(186, 146);
            this.labTimer.Name = "labTimer";
            this.labTimer.Size = new System.Drawing.Size(448, 120);
            this.labTimer.TabIndex = 0;
            this.labTimer.Text = "00:00:00";
            this.labTimer.TextChanged += new System.EventHandler(this.labTimer_TextChanged);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labWeek
            // 
            this.labWeek.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labWeek.Location = new System.Drawing.Point(138, 91);
            this.labWeek.Name = "labWeek";
            this.labWeek.Size = new System.Drawing.Size(344, 55);
            this.labWeek.TabIndex = 1;
            this.labWeek.Text = "星期";
            // 
            // TimeRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labWeek);
            this.Controls.Add(this.labTimer);
            this.Name = "TimeRun";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TimeRun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTimer;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labWeek;
    }
}

