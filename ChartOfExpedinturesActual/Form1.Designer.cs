
using System;

namespace ChartOfExpedinturesActual
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.ChartExpedintures = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ChartExpedintures)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartExpedintures
            // 
            this.ChartExpedintures.BackColor = System.Drawing.Color.Ivory;
            chartArea1.Name = "ChartArea1";
            this.ChartExpedintures.ChartAreas.Add(chartArea1);
            legend1.BorderColor = System.Drawing.Color.Blue;
            legend1.BorderWidth = 2;
            legend1.Name = "Legend1";
            this.ChartExpedintures.Legends.Add(legend1);
            this.ChartExpedintures.Location = new System.Drawing.Point(12, 12);
            this.ChartExpedintures.Name = "ChartExpedintures";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.DarkBlue;
            series1.Legend = "Legend1";
            series1.Name = "Eating";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Yellow;
            series2.Legend = "Legend1";
            series2.Name = "Fuel";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Green;
            series3.Legend = "Legend1";
            series3.Name = "Clothes";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.DarkOrange;
            series4.Legend = "Legend1";
            series4.Name = "Learning";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series5.Legend = "Legend1";
            series5.Name = "Bills";
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series6.Legend = "Legend1";
            series6.Name = "Salary";
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.DimGray;
            series7.Legend = "Legend1";
            series7.Name = "Receivables";
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.Black;
            series8.Legend = "Legend1";
            series8.Name = "Other";
            this.ChartExpedintures.Series.Add(series1);
            this.ChartExpedintures.Series.Add(series2);
            this.ChartExpedintures.Series.Add(series3);
            this.ChartExpedintures.Series.Add(series4);
            this.ChartExpedintures.Series.Add(series5);
            this.ChartExpedintures.Series.Add(series6);
            this.ChartExpedintures.Series.Add(series7);
            this.ChartExpedintures.Series.Add(series8);
            this.ChartExpedintures.Size = new System.Drawing.Size(766, 475);
            this.ChartExpedintures.TabIndex = 0;
            this.ChartExpedintures.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.ForeColor = System.Drawing.Color.DarkRed;
            title1.Name = "LastOperations";
            title1.Text = "Last operations";
            this.ChartExpedintures.Titles.Add(title1);
            this.ChartExpedintures.Click += new System.EventHandler(this.ChartExpedintures_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(249)))), ((int)(((byte)(242)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(640, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(116, 32);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Close chart";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(790, 499);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.ChartExpedintures);
            this.Name = "Form1";
            this.Text = "Chart";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartExpedintures)).EndInit();
            this.ResumeLayout(false);

        }

        private void ChartExpedintures_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartExpedintures;
        private System.Windows.Forms.Button btnExit;
    }
}

