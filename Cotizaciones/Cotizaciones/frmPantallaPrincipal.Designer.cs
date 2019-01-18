﻿namespace Cotizaciones
{
    partial class frmPantallaPrincipal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.msMenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearSoicitudToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSolicitudes = new System.Windows.Forms.ToolStripMenuItem();
            this.chaGrafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.msMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chaGrafica)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenuPrincipal
            // 
            this.msMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(77)))), ((int)(((byte)(122)))));
            this.msMenuPrincipal.Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msMenuPrincipal.ImageScalingSize = new System.Drawing.Size(19, 19);
            this.msMenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem,
            this.crearSoicitudToolStripMenuItem,
            this.toolSolicitudes});
            this.msMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msMenuPrincipal.Name = "msMenuPrincipal";
            this.msMenuPrincipal.Size = new System.Drawing.Size(800, 24);
            this.msMenuPrincipal.TabIndex = 0;
            this.msMenuPrincipal.Text = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // crearSoicitudToolStripMenuItem
            // 
            this.crearSoicitudToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.crearSoicitudToolStripMenuItem.Name = "crearSoicitudToolStripMenuItem";
            this.crearSoicitudToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.crearSoicitudToolStripMenuItem.Text = "Crear Solicitud";
            this.crearSoicitudToolStripMenuItem.Click += new System.EventHandler(this.crearSoicitudToolStripMenuItem_Click);
            // 
            // toolSolicitudes
            // 
            this.toolSolicitudes.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolSolicitudes.Font = new System.Drawing.Font("Segoe UI Semibold", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolSolicitudes.ForeColor = System.Drawing.Color.White;
            this.toolSolicitudes.Name = "toolSolicitudes";
            this.toolSolicitudes.Size = new System.Drawing.Size(95, 20);
            this.toolSolicitudes.Text = "Solicitudes (0)";
            // 
            // chaGrafica
            // 
            chartArea1.BackColor = System.Drawing.Color.DarkTurquoise;
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.TopBottom;
            chartArea1.Name = "ChartArea1";
            this.chaGrafica.ChartAreas.Add(chartArea1);
            this.chaGrafica.Location = new System.Drawing.Point(111, 89);
            this.chaGrafica.Margin = new System.Windows.Forms.Padding(2);
            this.chaGrafica.Name = "chaGrafica";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chaGrafica.Series.Add(series1);
            this.chaGrafica.Size = new System.Drawing.Size(582, 279);
            this.chaGrafica.SuppressExceptions = true;
            this.chaGrafica.TabIndex = 1;
            this.chaGrafica.Text = "Proceso";
            this.chaGrafica.Click += new System.EventHandler(this.chaGrafica_Click);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Segoe UI", 18.15652F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.Location = new System.Drawing.Point(294, 43);
            this.lblBienvenido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(269, 35);
            this.lblBienvenido.TabIndex = 2;
            this.lblBienvenido.Text = "Bienvenido: ____________";
            // 
            // frmPantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.chaGrafica);
            this.Controls.Add(this.msMenuPrincipal);
            this.MainMenuStrip = this.msMenuPrincipal;
            this.Name = "frmPantallaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPantallaPrincipal_FormClosing);
            this.msMenuPrincipal.ResumeLayout(false);
            this.msMenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chaGrafica)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearSoicitudToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolSolicitudes;
        private System.Windows.Forms.DataVisualization.Charting.Chart chaGrafica;
        private System.Windows.Forms.Label lblBienvenido;
    }
}