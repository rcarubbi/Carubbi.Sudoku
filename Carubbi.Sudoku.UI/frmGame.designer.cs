using System.ComponentModel;
using System.Windows.Forms;

namespace Carubbi.Sudoku.UI
{
    partial class FrmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components;

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
            this.pnlQuadrant1 = new System.Windows.Forms.Panel();
            this.txtCell9 = new System.Windows.Forms.TextBox();
            this.txtCell6 = new System.Windows.Forms.TextBox();
            this.txtCell3 = new System.Windows.Forms.TextBox();
            this.txtCell8 = new System.Windows.Forms.TextBox();
            this.txtCell5 = new System.Windows.Forms.TextBox();
            this.txtCell2 = new System.Windows.Forms.TextBox();
            this.txtCell7 = new System.Windows.Forms.TextBox();
            this.txtCell4 = new System.Windows.Forms.TextBox();
            this.txtCell1 = new System.Windows.Forms.TextBox();
            this.pnlQuadrant2 = new System.Windows.Forms.Panel();
            this.txtCell18 = new System.Windows.Forms.TextBox();
            this.txtCell15 = new System.Windows.Forms.TextBox();
            this.txtCell12 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.txtCell14 = new System.Windows.Forms.TextBox();
            this.txtCell11 = new System.Windows.Forms.TextBox();
            this.txtCell16 = new System.Windows.Forms.TextBox();
            this.txtCell13 = new System.Windows.Forms.TextBox();
            this.txtCell10 = new System.Windows.Forms.TextBox();
            this.pnlQuadrant3 = new System.Windows.Forms.Panel();
            this.txtCell27 = new System.Windows.Forms.TextBox();
            this.txtCell24 = new System.Windows.Forms.TextBox();
            this.txtCell21 = new System.Windows.Forms.TextBox();
            this.txtCell26 = new System.Windows.Forms.TextBox();
            this.txtCell23 = new System.Windows.Forms.TextBox();
            this.txtCell20 = new System.Windows.Forms.TextBox();
            this.txtCell25 = new System.Windows.Forms.TextBox();
            this.txtCell22 = new System.Windows.Forms.TextBox();
            this.txtCell19 = new System.Windows.Forms.TextBox();
            this.pnlQuadrant4 = new System.Windows.Forms.Panel();
            this.txtCell36 = new System.Windows.Forms.TextBox();
            this.txtCell33 = new System.Windows.Forms.TextBox();
            this.txtCell30 = new System.Windows.Forms.TextBox();
            this.txtCell35 = new System.Windows.Forms.TextBox();
            this.txtCell32 = new System.Windows.Forms.TextBox();
            this.txtCell29 = new System.Windows.Forms.TextBox();
            this.txtCell34 = new System.Windows.Forms.TextBox();
            this.txtCell31 = new System.Windows.Forms.TextBox();
            this.txtCell28 = new System.Windows.Forms.TextBox();
            this.pnlQuadrant5 = new System.Windows.Forms.Panel();
            this.txtCell45 = new System.Windows.Forms.TextBox();
            this.txtCell42 = new System.Windows.Forms.TextBox();
            this.txtCell39 = new System.Windows.Forms.TextBox();
            this.txtCell44 = new System.Windows.Forms.TextBox();
            this.txtCell41 = new System.Windows.Forms.TextBox();
            this.txtCell38 = new System.Windows.Forms.TextBox();
            this.txtCell43 = new System.Windows.Forms.TextBox();
            this.txtCell40 = new System.Windows.Forms.TextBox();
            this.txtCell37 = new System.Windows.Forms.TextBox();
            this.pnlQuadrant6 = new System.Windows.Forms.Panel();
            this.txtCell54 = new System.Windows.Forms.TextBox();
            this.txtCell51 = new System.Windows.Forms.TextBox();
            this.txtCell48 = new System.Windows.Forms.TextBox();
            this.txtCell53 = new System.Windows.Forms.TextBox();
            this.txtCell50 = new System.Windows.Forms.TextBox();
            this.txtCell47 = new System.Windows.Forms.TextBox();
            this.txtCell52 = new System.Windows.Forms.TextBox();
            this.txtCell49 = new System.Windows.Forms.TextBox();
            this.txtCell46 = new System.Windows.Forms.TextBox();
            this.pnlQuadrant7 = new System.Windows.Forms.Panel();
            this.txtCell63 = new System.Windows.Forms.TextBox();
            this.txtCell60 = new System.Windows.Forms.TextBox();
            this.txtCell57 = new System.Windows.Forms.TextBox();
            this.txtCell62 = new System.Windows.Forms.TextBox();
            this.txtCell59 = new System.Windows.Forms.TextBox();
            this.txtCell56 = new System.Windows.Forms.TextBox();
            this.txtCell61 = new System.Windows.Forms.TextBox();
            this.txtCell58 = new System.Windows.Forms.TextBox();
            this.txtCell55 = new System.Windows.Forms.TextBox();
            this.pnlQuadrant8 = new System.Windows.Forms.Panel();
            this.txtCell72 = new System.Windows.Forms.TextBox();
            this.txtCell69 = new System.Windows.Forms.TextBox();
            this.txtCell66 = new System.Windows.Forms.TextBox();
            this.txtCell71 = new System.Windows.Forms.TextBox();
            this.txtCell68 = new System.Windows.Forms.TextBox();
            this.txtCell65 = new System.Windows.Forms.TextBox();
            this.txtCell70 = new System.Windows.Forms.TextBox();
            this.txtCell67 = new System.Windows.Forms.TextBox();
            this.txtCell64 = new System.Windows.Forms.TextBox();
            this.pnlQuadrant9 = new System.Windows.Forms.Panel();
            this.txtCell81 = new System.Windows.Forms.TextBox();
            this.txtCell78 = new System.Windows.Forms.TextBox();
            this.txtCell75 = new System.Windows.Forms.TextBox();
            this.txtCell80 = new System.Windows.Forms.TextBox();
            this.txtCell77 = new System.Windows.Forms.TextBox();
            this.txtCell74 = new System.Windows.Forms.TextBox();
            this.txtCell79 = new System.Windows.Forms.TextBox();
            this.txtCell76 = new System.Windows.Forms.TextBox();
            this.txtCell73 = new System.Windows.Forms.TextBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblAnimationSeconds = new System.Windows.Forms.Label();
            this.txtAnimationSeconds = new System.Windows.Forms.NumericUpDown();
            this.lblSolutions = new System.Windows.Forms.Label();
            this.txtSolutionsNumber = new System.Windows.Forms.TextBox();
            this.lblSearchFor = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.pnlQuadrant1.SuspendLayout();
            this.pnlQuadrant2.SuspendLayout();
            this.pnlQuadrant3.SuspendLayout();
            this.pnlQuadrant4.SuspendLayout();
            this.pnlQuadrant5.SuspendLayout();
            this.pnlQuadrant6.SuspendLayout();
            this.pnlQuadrant7.SuspendLayout();
            this.pnlQuadrant8.SuspendLayout();
            this.pnlQuadrant9.SuspendLayout();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnimationSeconds)).BeginInit();
            this.pnlResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlQuadrant1
            // 
            this.pnlQuadrant1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuadrant1.Controls.Add(this.txtCell9);
            this.pnlQuadrant1.Controls.Add(this.txtCell6);
            this.pnlQuadrant1.Controls.Add(this.txtCell3);
            this.pnlQuadrant1.Controls.Add(this.txtCell8);
            this.pnlQuadrant1.Controls.Add(this.txtCell5);
            this.pnlQuadrant1.Controls.Add(this.txtCell2);
            this.pnlQuadrant1.Controls.Add(this.txtCell7);
            this.pnlQuadrant1.Controls.Add(this.txtCell4);
            this.pnlQuadrant1.Controls.Add(this.txtCell1);
            this.pnlQuadrant1.Location = new System.Drawing.Point(12, 12);
            this.pnlQuadrant1.Name = "pnlQuadrant1";
            this.pnlQuadrant1.Size = new System.Drawing.Size(149, 140);
            this.pnlQuadrant1.TabIndex = 0;
            // 
            // txtCell9
            // 
            this.txtCell9.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell9.Location = new System.Drawing.Point(100, 94);
            this.txtCell9.Multiline = true;
            this.txtCell9.Name = "txtCell9";
            this.txtCell9.Size = new System.Drawing.Size(44, 38);
            this.txtCell9.TabIndex = 8;
            this.txtCell9.Tag = "3;3";
            this.txtCell9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell6
            // 
            this.txtCell6.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell6.Location = new System.Drawing.Point(100, 51);
            this.txtCell6.Multiline = true;
            this.txtCell6.Name = "txtCell6";
            this.txtCell6.Size = new System.Drawing.Size(44, 38);
            this.txtCell6.TabIndex = 5;
            this.txtCell6.Tag = "2;3";
            this.txtCell6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell3
            // 
            this.txtCell3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell3.Location = new System.Drawing.Point(100, 8);
            this.txtCell3.Multiline = true;
            this.txtCell3.Name = "txtCell3";
            this.txtCell3.Size = new System.Drawing.Size(44, 38);
            this.txtCell3.TabIndex = 2;
            this.txtCell3.Tag = "1;3";
            this.txtCell3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell8
            // 
            this.txtCell8.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell8.Location = new System.Drawing.Point(52, 94);
            this.txtCell8.Multiline = true;
            this.txtCell8.Name = "txtCell8";
            this.txtCell8.Size = new System.Drawing.Size(44, 38);
            this.txtCell8.TabIndex = 7;
            this.txtCell8.Tag = "3;2";
            this.txtCell8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell5
            // 
            this.txtCell5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell5.Location = new System.Drawing.Point(52, 51);
            this.txtCell5.Multiline = true;
            this.txtCell5.Name = "txtCell5";
            this.txtCell5.Size = new System.Drawing.Size(44, 38);
            this.txtCell5.TabIndex = 4;
            this.txtCell5.Tag = "2;2";
            this.txtCell5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell2
            // 
            this.txtCell2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell2.Location = new System.Drawing.Point(52, 8);
            this.txtCell2.Multiline = true;
            this.txtCell2.Name = "txtCell2";
            this.txtCell2.Size = new System.Drawing.Size(44, 38);
            this.txtCell2.TabIndex = 1;
            this.txtCell2.Tag = "1;2";
            this.txtCell2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell7
            // 
            this.txtCell7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell7.Location = new System.Drawing.Point(4, 94);
            this.txtCell7.Multiline = true;
            this.txtCell7.Name = "txtCell7";
            this.txtCell7.Size = new System.Drawing.Size(44, 38);
            this.txtCell7.TabIndex = 6;
            this.txtCell7.Tag = "3;1";
            this.txtCell7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell4
            // 
            this.txtCell4.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell4.Location = new System.Drawing.Point(4, 51);
            this.txtCell4.Multiline = true;
            this.txtCell4.Name = "txtCell4";
            this.txtCell4.Size = new System.Drawing.Size(44, 38);
            this.txtCell4.TabIndex = 3;
            this.txtCell4.Tag = "2;1";
            this.txtCell4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell1
            // 
            this.txtCell1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell1.Location = new System.Drawing.Point(4, 8);
            this.txtCell1.Multiline = true;
            this.txtCell1.Name = "txtCell1";
            this.txtCell1.Size = new System.Drawing.Size(44, 38);
            this.txtCell1.TabIndex = 0;
            this.txtCell1.Tag = "1;1";
            this.txtCell1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlQuadrant2
            // 
            this.pnlQuadrant2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuadrant2.Controls.Add(this.txtCell18);
            this.pnlQuadrant2.Controls.Add(this.txtCell15);
            this.pnlQuadrant2.Controls.Add(this.txtCell12);
            this.pnlQuadrant2.Controls.Add(this.textBox17);
            this.pnlQuadrant2.Controls.Add(this.txtCell14);
            this.pnlQuadrant2.Controls.Add(this.txtCell11);
            this.pnlQuadrant2.Controls.Add(this.txtCell16);
            this.pnlQuadrant2.Controls.Add(this.txtCell13);
            this.pnlQuadrant2.Controls.Add(this.txtCell10);
            this.pnlQuadrant2.Location = new System.Drawing.Point(169, 12);
            this.pnlQuadrant2.Name = "pnlQuadrant2";
            this.pnlQuadrant2.Size = new System.Drawing.Size(149, 140);
            this.pnlQuadrant2.TabIndex = 1;
            // 
            // txtCell18
            // 
            this.txtCell18.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell18.Location = new System.Drawing.Point(100, 94);
            this.txtCell18.Multiline = true;
            this.txtCell18.Name = "txtCell18";
            this.txtCell18.Size = new System.Drawing.Size(44, 38);
            this.txtCell18.TabIndex = 17;
            this.txtCell18.Tag = "3;6";
            this.txtCell18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell15
            // 
            this.txtCell15.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell15.Location = new System.Drawing.Point(100, 51);
            this.txtCell15.Multiline = true;
            this.txtCell15.Name = "txtCell15";
            this.txtCell15.Size = new System.Drawing.Size(44, 38);
            this.txtCell15.TabIndex = 14;
            this.txtCell15.Tag = "2;6";
            this.txtCell15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell12
            // 
            this.txtCell12.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell12.Location = new System.Drawing.Point(100, 8);
            this.txtCell12.Multiline = true;
            this.txtCell12.Name = "txtCell12";
            this.txtCell12.Size = new System.Drawing.Size(44, 38);
            this.txtCell12.TabIndex = 11;
            this.txtCell12.Tag = "1;6";
            this.txtCell12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox17
            // 
            this.textBox17.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.Location = new System.Drawing.Point(52, 94);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(44, 38);
            this.textBox17.TabIndex = 16;
            this.textBox17.Tag = "3;5";
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell14
            // 
            this.txtCell14.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell14.Location = new System.Drawing.Point(52, 51);
            this.txtCell14.Multiline = true;
            this.txtCell14.Name = "txtCell14";
            this.txtCell14.Size = new System.Drawing.Size(44, 38);
            this.txtCell14.TabIndex = 13;
            this.txtCell14.Tag = "2;5";
            this.txtCell14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell11
            // 
            this.txtCell11.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell11.Location = new System.Drawing.Point(52, 8);
            this.txtCell11.Multiline = true;
            this.txtCell11.Name = "txtCell11";
            this.txtCell11.Size = new System.Drawing.Size(44, 38);
            this.txtCell11.TabIndex = 10;
            this.txtCell11.Tag = "1;5";
            this.txtCell11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell16
            // 
            this.txtCell16.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell16.Location = new System.Drawing.Point(4, 94);
            this.txtCell16.Multiline = true;
            this.txtCell16.Name = "txtCell16";
            this.txtCell16.Size = new System.Drawing.Size(44, 38);
            this.txtCell16.TabIndex = 15;
            this.txtCell16.Tag = "3;4";
            this.txtCell16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell13
            // 
            this.txtCell13.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell13.Location = new System.Drawing.Point(4, 51);
            this.txtCell13.Multiline = true;
            this.txtCell13.Name = "txtCell13";
            this.txtCell13.Size = new System.Drawing.Size(44, 38);
            this.txtCell13.TabIndex = 12;
            this.txtCell13.Tag = "2;4";
            this.txtCell13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell10
            // 
            this.txtCell10.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell10.Location = new System.Drawing.Point(4, 8);
            this.txtCell10.Multiline = true;
            this.txtCell10.Name = "txtCell10";
            this.txtCell10.Size = new System.Drawing.Size(44, 38);
            this.txtCell10.TabIndex = 9;
            this.txtCell10.Tag = "1;4";
            this.txtCell10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlQuadrant3
            // 
            this.pnlQuadrant3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuadrant3.Controls.Add(this.txtCell27);
            this.pnlQuadrant3.Controls.Add(this.txtCell24);
            this.pnlQuadrant3.Controls.Add(this.txtCell21);
            this.pnlQuadrant3.Controls.Add(this.txtCell26);
            this.pnlQuadrant3.Controls.Add(this.txtCell23);
            this.pnlQuadrant3.Controls.Add(this.txtCell20);
            this.pnlQuadrant3.Controls.Add(this.txtCell25);
            this.pnlQuadrant3.Controls.Add(this.txtCell22);
            this.pnlQuadrant3.Controls.Add(this.txtCell19);
            this.pnlQuadrant3.Location = new System.Drawing.Point(326, 12);
            this.pnlQuadrant3.Name = "pnlQuadrant3";
            this.pnlQuadrant3.Size = new System.Drawing.Size(149, 140);
            this.pnlQuadrant3.TabIndex = 2;
            // 
            // txtCell27
            // 
            this.txtCell27.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell27.Location = new System.Drawing.Point(100, 94);
            this.txtCell27.Multiline = true;
            this.txtCell27.Name = "txtCell27";
            this.txtCell27.Size = new System.Drawing.Size(44, 38);
            this.txtCell27.TabIndex = 26;
            this.txtCell27.Tag = "3;9";
            this.txtCell27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell24
            // 
            this.txtCell24.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell24.Location = new System.Drawing.Point(100, 51);
            this.txtCell24.Multiline = true;
            this.txtCell24.Name = "txtCell24";
            this.txtCell24.Size = new System.Drawing.Size(44, 38);
            this.txtCell24.TabIndex = 23;
            this.txtCell24.Tag = "2;9";
            this.txtCell24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell21
            // 
            this.txtCell21.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell21.Location = new System.Drawing.Point(100, 8);
            this.txtCell21.Multiline = true;
            this.txtCell21.Name = "txtCell21";
            this.txtCell21.Size = new System.Drawing.Size(44, 38);
            this.txtCell21.TabIndex = 20;
            this.txtCell21.Tag = "1;9";
            this.txtCell21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell26
            // 
            this.txtCell26.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell26.Location = new System.Drawing.Point(52, 94);
            this.txtCell26.Multiline = true;
            this.txtCell26.Name = "txtCell26";
            this.txtCell26.Size = new System.Drawing.Size(44, 38);
            this.txtCell26.TabIndex = 25;
            this.txtCell26.Tag = "3;8";
            this.txtCell26.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell23
            // 
            this.txtCell23.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell23.Location = new System.Drawing.Point(52, 51);
            this.txtCell23.Multiline = true;
            this.txtCell23.Name = "txtCell23";
            this.txtCell23.Size = new System.Drawing.Size(44, 38);
            this.txtCell23.TabIndex = 22;
            this.txtCell23.Tag = "2;8";
            this.txtCell23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell20
            // 
            this.txtCell20.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell20.Location = new System.Drawing.Point(52, 8);
            this.txtCell20.Multiline = true;
            this.txtCell20.Name = "txtCell20";
            this.txtCell20.Size = new System.Drawing.Size(44, 38);
            this.txtCell20.TabIndex = 19;
            this.txtCell20.Tag = "1;8";
            this.txtCell20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell25
            // 
            this.txtCell25.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell25.Location = new System.Drawing.Point(4, 94);
            this.txtCell25.Multiline = true;
            this.txtCell25.Name = "txtCell25";
            this.txtCell25.Size = new System.Drawing.Size(44, 38);
            this.txtCell25.TabIndex = 24;
            this.txtCell25.Tag = "3;7";
            this.txtCell25.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell22
            // 
            this.txtCell22.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell22.Location = new System.Drawing.Point(4, 51);
            this.txtCell22.Multiline = true;
            this.txtCell22.Name = "txtCell22";
            this.txtCell22.Size = new System.Drawing.Size(44, 38);
            this.txtCell22.TabIndex = 21;
            this.txtCell22.Tag = "2;7";
            this.txtCell22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell19
            // 
            this.txtCell19.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell19.Location = new System.Drawing.Point(4, 8);
            this.txtCell19.Multiline = true;
            this.txtCell19.Name = "txtCell19";
            this.txtCell19.Size = new System.Drawing.Size(44, 38);
            this.txtCell19.TabIndex = 18;
            this.txtCell19.Tag = "1;7";
            this.txtCell19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlQuadrant4
            // 
            this.pnlQuadrant4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuadrant4.Controls.Add(this.txtCell36);
            this.pnlQuadrant4.Controls.Add(this.txtCell33);
            this.pnlQuadrant4.Controls.Add(this.txtCell30);
            this.pnlQuadrant4.Controls.Add(this.txtCell35);
            this.pnlQuadrant4.Controls.Add(this.txtCell32);
            this.pnlQuadrant4.Controls.Add(this.txtCell29);
            this.pnlQuadrant4.Controls.Add(this.txtCell34);
            this.pnlQuadrant4.Controls.Add(this.txtCell31);
            this.pnlQuadrant4.Controls.Add(this.txtCell28);
            this.pnlQuadrant4.Location = new System.Drawing.Point(12, 161);
            this.pnlQuadrant4.Name = "pnlQuadrant4";
            this.pnlQuadrant4.Size = new System.Drawing.Size(149, 140);
            this.pnlQuadrant4.TabIndex = 3;
            // 
            // txtCell36
            // 
            this.txtCell36.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell36.Location = new System.Drawing.Point(100, 92);
            this.txtCell36.Multiline = true;
            this.txtCell36.Name = "txtCell36";
            this.txtCell36.Size = new System.Drawing.Size(44, 38);
            this.txtCell36.TabIndex = 35;
            this.txtCell36.Tag = "6;3";
            this.txtCell36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell33
            // 
            this.txtCell33.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell33.Location = new System.Drawing.Point(100, 50);
            this.txtCell33.Multiline = true;
            this.txtCell33.Name = "txtCell33";
            this.txtCell33.Size = new System.Drawing.Size(44, 38);
            this.txtCell33.TabIndex = 32;
            this.txtCell33.Tag = "5;3";
            this.txtCell33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell30
            // 
            this.txtCell30.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell30.Location = new System.Drawing.Point(100, 8);
            this.txtCell30.Multiline = true;
            this.txtCell30.Name = "txtCell30";
            this.txtCell30.Size = new System.Drawing.Size(44, 38);
            this.txtCell30.TabIndex = 29;
            this.txtCell30.Tag = "4;3";
            this.txtCell30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell35
            // 
            this.txtCell35.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell35.Location = new System.Drawing.Point(52, 92);
            this.txtCell35.Multiline = true;
            this.txtCell35.Name = "txtCell35";
            this.txtCell35.Size = new System.Drawing.Size(44, 38);
            this.txtCell35.TabIndex = 34;
            this.txtCell35.Tag = "6;2";
            this.txtCell35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell32
            // 
            this.txtCell32.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell32.Location = new System.Drawing.Point(52, 50);
            this.txtCell32.Multiline = true;
            this.txtCell32.Name = "txtCell32";
            this.txtCell32.Size = new System.Drawing.Size(44, 38);
            this.txtCell32.TabIndex = 31;
            this.txtCell32.Tag = "5;2";
            this.txtCell32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell29
            // 
            this.txtCell29.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell29.Location = new System.Drawing.Point(52, 8);
            this.txtCell29.Multiline = true;
            this.txtCell29.Name = "txtCell29";
            this.txtCell29.Size = new System.Drawing.Size(44, 38);
            this.txtCell29.TabIndex = 28;
            this.txtCell29.Tag = "4;2";
            this.txtCell29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell34
            // 
            this.txtCell34.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell34.Location = new System.Drawing.Point(4, 92);
            this.txtCell34.Multiline = true;
            this.txtCell34.Name = "txtCell34";
            this.txtCell34.Size = new System.Drawing.Size(44, 38);
            this.txtCell34.TabIndex = 33;
            this.txtCell34.Tag = "6;1";
            this.txtCell34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell31
            // 
            this.txtCell31.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell31.Location = new System.Drawing.Point(4, 50);
            this.txtCell31.Multiline = true;
            this.txtCell31.Name = "txtCell31";
            this.txtCell31.Size = new System.Drawing.Size(44, 38);
            this.txtCell31.TabIndex = 30;
            this.txtCell31.Tag = "5;1";
            this.txtCell31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell28
            // 
            this.txtCell28.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell28.Location = new System.Drawing.Point(4, 8);
            this.txtCell28.Multiline = true;
            this.txtCell28.Name = "txtCell28";
            this.txtCell28.Size = new System.Drawing.Size(44, 38);
            this.txtCell28.TabIndex = 27;
            this.txtCell28.Tag = "4;1";
            this.txtCell28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlQuadrant5
            // 
            this.pnlQuadrant5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuadrant5.Controls.Add(this.txtCell45);
            this.pnlQuadrant5.Controls.Add(this.txtCell42);
            this.pnlQuadrant5.Controls.Add(this.txtCell39);
            this.pnlQuadrant5.Controls.Add(this.txtCell44);
            this.pnlQuadrant5.Controls.Add(this.txtCell41);
            this.pnlQuadrant5.Controls.Add(this.txtCell38);
            this.pnlQuadrant5.Controls.Add(this.txtCell43);
            this.pnlQuadrant5.Controls.Add(this.txtCell40);
            this.pnlQuadrant5.Controls.Add(this.txtCell37);
            this.pnlQuadrant5.Location = new System.Drawing.Point(169, 161);
            this.pnlQuadrant5.Name = "pnlQuadrant5";
            this.pnlQuadrant5.Size = new System.Drawing.Size(149, 140);
            this.pnlQuadrant5.TabIndex = 4;
            // 
            // txtCell45
            // 
            this.txtCell45.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell45.Location = new System.Drawing.Point(100, 92);
            this.txtCell45.Multiline = true;
            this.txtCell45.Name = "txtCell45";
            this.txtCell45.Size = new System.Drawing.Size(44, 38);
            this.txtCell45.TabIndex = 44;
            this.txtCell45.Tag = "6;6";
            this.txtCell45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell42
            // 
            this.txtCell42.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell42.Location = new System.Drawing.Point(100, 50);
            this.txtCell42.Multiline = true;
            this.txtCell42.Name = "txtCell42";
            this.txtCell42.Size = new System.Drawing.Size(44, 38);
            this.txtCell42.TabIndex = 41;
            this.txtCell42.Tag = "5;6";
            this.txtCell42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell39
            // 
            this.txtCell39.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell39.Location = new System.Drawing.Point(100, 8);
            this.txtCell39.Multiline = true;
            this.txtCell39.Name = "txtCell39";
            this.txtCell39.Size = new System.Drawing.Size(44, 38);
            this.txtCell39.TabIndex = 38;
            this.txtCell39.Tag = "4;6";
            this.txtCell39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell44
            // 
            this.txtCell44.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell44.Location = new System.Drawing.Point(52, 92);
            this.txtCell44.Multiline = true;
            this.txtCell44.Name = "txtCell44";
            this.txtCell44.Size = new System.Drawing.Size(44, 38);
            this.txtCell44.TabIndex = 43;
            this.txtCell44.Tag = "6;5";
            this.txtCell44.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell41
            // 
            this.txtCell41.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell41.Location = new System.Drawing.Point(52, 50);
            this.txtCell41.Multiline = true;
            this.txtCell41.Name = "txtCell41";
            this.txtCell41.Size = new System.Drawing.Size(44, 38);
            this.txtCell41.TabIndex = 40;
            this.txtCell41.Tag = "5;5";
            this.txtCell41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell38
            // 
            this.txtCell38.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell38.Location = new System.Drawing.Point(52, 8);
            this.txtCell38.Multiline = true;
            this.txtCell38.Name = "txtCell38";
            this.txtCell38.Size = new System.Drawing.Size(44, 38);
            this.txtCell38.TabIndex = 37;
            this.txtCell38.Tag = "4;5";
            this.txtCell38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell43
            // 
            this.txtCell43.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell43.Location = new System.Drawing.Point(4, 92);
            this.txtCell43.Multiline = true;
            this.txtCell43.Name = "txtCell43";
            this.txtCell43.Size = new System.Drawing.Size(44, 38);
            this.txtCell43.TabIndex = 42;
            this.txtCell43.Tag = "6;4";
            this.txtCell43.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell40
            // 
            this.txtCell40.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell40.Location = new System.Drawing.Point(4, 50);
            this.txtCell40.Multiline = true;
            this.txtCell40.Name = "txtCell40";
            this.txtCell40.Size = new System.Drawing.Size(44, 38);
            this.txtCell40.TabIndex = 39;
            this.txtCell40.Tag = "5;4";
            this.txtCell40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell37
            // 
            this.txtCell37.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell37.Location = new System.Drawing.Point(4, 8);
            this.txtCell37.Multiline = true;
            this.txtCell37.Name = "txtCell37";
            this.txtCell37.Size = new System.Drawing.Size(44, 38);
            this.txtCell37.TabIndex = 36;
            this.txtCell37.Tag = "4;4";
            this.txtCell37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlQuadrant6
            // 
            this.pnlQuadrant6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuadrant6.Controls.Add(this.txtCell54);
            this.pnlQuadrant6.Controls.Add(this.txtCell51);
            this.pnlQuadrant6.Controls.Add(this.txtCell48);
            this.pnlQuadrant6.Controls.Add(this.txtCell53);
            this.pnlQuadrant6.Controls.Add(this.txtCell50);
            this.pnlQuadrant6.Controls.Add(this.txtCell47);
            this.pnlQuadrant6.Controls.Add(this.txtCell52);
            this.pnlQuadrant6.Controls.Add(this.txtCell49);
            this.pnlQuadrant6.Controls.Add(this.txtCell46);
            this.pnlQuadrant6.Location = new System.Drawing.Point(326, 161);
            this.pnlQuadrant6.Name = "pnlQuadrant6";
            this.pnlQuadrant6.Size = new System.Drawing.Size(149, 140);
            this.pnlQuadrant6.TabIndex = 5;
            // 
            // txtCell54
            // 
            this.txtCell54.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell54.Location = new System.Drawing.Point(100, 92);
            this.txtCell54.Multiline = true;
            this.txtCell54.Name = "txtCell54";
            this.txtCell54.Size = new System.Drawing.Size(44, 38);
            this.txtCell54.TabIndex = 53;
            this.txtCell54.Tag = "6;9";
            this.txtCell54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell51
            // 
            this.txtCell51.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell51.Location = new System.Drawing.Point(100, 50);
            this.txtCell51.Multiline = true;
            this.txtCell51.Name = "txtCell51";
            this.txtCell51.Size = new System.Drawing.Size(44, 38);
            this.txtCell51.TabIndex = 50;
            this.txtCell51.Tag = "5;9";
            this.txtCell51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell48
            // 
            this.txtCell48.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell48.Location = new System.Drawing.Point(100, 8);
            this.txtCell48.Multiline = true;
            this.txtCell48.Name = "txtCell48";
            this.txtCell48.Size = new System.Drawing.Size(44, 38);
            this.txtCell48.TabIndex = 47;
            this.txtCell48.Tag = "4;9";
            this.txtCell48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell53
            // 
            this.txtCell53.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell53.Location = new System.Drawing.Point(52, 92);
            this.txtCell53.Multiline = true;
            this.txtCell53.Name = "txtCell53";
            this.txtCell53.Size = new System.Drawing.Size(44, 38);
            this.txtCell53.TabIndex = 52;
            this.txtCell53.Tag = "6;8";
            this.txtCell53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell50
            // 
            this.txtCell50.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell50.Location = new System.Drawing.Point(52, 50);
            this.txtCell50.Multiline = true;
            this.txtCell50.Name = "txtCell50";
            this.txtCell50.Size = new System.Drawing.Size(44, 38);
            this.txtCell50.TabIndex = 49;
            this.txtCell50.Tag = "5;8";
            this.txtCell50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell47
            // 
            this.txtCell47.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell47.Location = new System.Drawing.Point(52, 8);
            this.txtCell47.Multiline = true;
            this.txtCell47.Name = "txtCell47";
            this.txtCell47.Size = new System.Drawing.Size(44, 38);
            this.txtCell47.TabIndex = 46;
            this.txtCell47.Tag = "4;8";
            this.txtCell47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell52
            // 
            this.txtCell52.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell52.Location = new System.Drawing.Point(4, 92);
            this.txtCell52.Multiline = true;
            this.txtCell52.Name = "txtCell52";
            this.txtCell52.Size = new System.Drawing.Size(44, 38);
            this.txtCell52.TabIndex = 51;
            this.txtCell52.Tag = "6;7";
            this.txtCell52.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell49
            // 
            this.txtCell49.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell49.Location = new System.Drawing.Point(4, 50);
            this.txtCell49.Multiline = true;
            this.txtCell49.Name = "txtCell49";
            this.txtCell49.Size = new System.Drawing.Size(44, 38);
            this.txtCell49.TabIndex = 48;
            this.txtCell49.Tag = "5;7";
            this.txtCell49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell46
            // 
            this.txtCell46.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell46.Location = new System.Drawing.Point(4, 8);
            this.txtCell46.Multiline = true;
            this.txtCell46.Name = "txtCell46";
            this.txtCell46.Size = new System.Drawing.Size(44, 38);
            this.txtCell46.TabIndex = 45;
            this.txtCell46.Tag = "4;7";
            this.txtCell46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlQuadrant7
            // 
            this.pnlQuadrant7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuadrant7.Controls.Add(this.txtCell63);
            this.pnlQuadrant7.Controls.Add(this.txtCell60);
            this.pnlQuadrant7.Controls.Add(this.txtCell57);
            this.pnlQuadrant7.Controls.Add(this.txtCell62);
            this.pnlQuadrant7.Controls.Add(this.txtCell59);
            this.pnlQuadrant7.Controls.Add(this.txtCell56);
            this.pnlQuadrant7.Controls.Add(this.txtCell61);
            this.pnlQuadrant7.Controls.Add(this.txtCell58);
            this.pnlQuadrant7.Controls.Add(this.txtCell55);
            this.pnlQuadrant7.Location = new System.Drawing.Point(12, 311);
            this.pnlQuadrant7.Name = "pnlQuadrant7";
            this.pnlQuadrant7.Size = new System.Drawing.Size(149, 140);
            this.pnlQuadrant7.TabIndex = 6;
            // 
            // txtCell63
            // 
            this.txtCell63.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell63.Location = new System.Drawing.Point(100, 90);
            this.txtCell63.Multiline = true;
            this.txtCell63.Name = "txtCell63";
            this.txtCell63.Size = new System.Drawing.Size(44, 38);
            this.txtCell63.TabIndex = 62;
            this.txtCell63.Tag = "9;3";
            this.txtCell63.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell60
            // 
            this.txtCell60.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell60.Location = new System.Drawing.Point(100, 48);
            this.txtCell60.Multiline = true;
            this.txtCell60.Name = "txtCell60";
            this.txtCell60.Size = new System.Drawing.Size(44, 38);
            this.txtCell60.TabIndex = 59;
            this.txtCell60.Tag = "8;3";
            this.txtCell60.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell57
            // 
            this.txtCell57.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell57.Location = new System.Drawing.Point(100, 7);
            this.txtCell57.Multiline = true;
            this.txtCell57.Name = "txtCell57";
            this.txtCell57.Size = new System.Drawing.Size(44, 38);
            this.txtCell57.TabIndex = 56;
            this.txtCell57.Tag = "7;3";
            this.txtCell57.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell62
            // 
            this.txtCell62.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell62.Location = new System.Drawing.Point(52, 90);
            this.txtCell62.Multiline = true;
            this.txtCell62.Name = "txtCell62";
            this.txtCell62.Size = new System.Drawing.Size(44, 38);
            this.txtCell62.TabIndex = 61;
            this.txtCell62.Tag = "9;2";
            this.txtCell62.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell59
            // 
            this.txtCell59.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell59.Location = new System.Drawing.Point(52, 48);
            this.txtCell59.Multiline = true;
            this.txtCell59.Name = "txtCell59";
            this.txtCell59.Size = new System.Drawing.Size(44, 38);
            this.txtCell59.TabIndex = 58;
            this.txtCell59.Tag = "8;2";
            this.txtCell59.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell56
            // 
            this.txtCell56.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell56.Location = new System.Drawing.Point(52, 7);
            this.txtCell56.Multiline = true;
            this.txtCell56.Name = "txtCell56";
            this.txtCell56.Size = new System.Drawing.Size(44, 38);
            this.txtCell56.TabIndex = 55;
            this.txtCell56.Tag = "7;2";
            this.txtCell56.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell61
            // 
            this.txtCell61.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell61.Location = new System.Drawing.Point(4, 90);
            this.txtCell61.Multiline = true;
            this.txtCell61.Name = "txtCell61";
            this.txtCell61.Size = new System.Drawing.Size(44, 38);
            this.txtCell61.TabIndex = 60;
            this.txtCell61.Tag = "9;1";
            this.txtCell61.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell58
            // 
            this.txtCell58.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell58.Location = new System.Drawing.Point(4, 48);
            this.txtCell58.Multiline = true;
            this.txtCell58.Name = "txtCell58";
            this.txtCell58.Size = new System.Drawing.Size(44, 38);
            this.txtCell58.TabIndex = 57;
            this.txtCell58.Tag = "8;1";
            this.txtCell58.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell55
            // 
            this.txtCell55.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell55.Location = new System.Drawing.Point(4, 7);
            this.txtCell55.Multiline = true;
            this.txtCell55.Name = "txtCell55";
            this.txtCell55.Size = new System.Drawing.Size(44, 38);
            this.txtCell55.TabIndex = 54;
            this.txtCell55.Tag = "7;1";
            this.txtCell55.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlQuadrant8
            // 
            this.pnlQuadrant8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuadrant8.Controls.Add(this.txtCell72);
            this.pnlQuadrant8.Controls.Add(this.txtCell69);
            this.pnlQuadrant8.Controls.Add(this.txtCell66);
            this.pnlQuadrant8.Controls.Add(this.txtCell71);
            this.pnlQuadrant8.Controls.Add(this.txtCell68);
            this.pnlQuadrant8.Controls.Add(this.txtCell65);
            this.pnlQuadrant8.Controls.Add(this.txtCell70);
            this.pnlQuadrant8.Controls.Add(this.txtCell67);
            this.pnlQuadrant8.Controls.Add(this.txtCell64);
            this.pnlQuadrant8.Location = new System.Drawing.Point(169, 311);
            this.pnlQuadrant8.Name = "pnlQuadrant8";
            this.pnlQuadrant8.Size = new System.Drawing.Size(149, 140);
            this.pnlQuadrant8.TabIndex = 7;
            // 
            // txtCell72
            // 
            this.txtCell72.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell72.Location = new System.Drawing.Point(100, 90);
            this.txtCell72.Multiline = true;
            this.txtCell72.Name = "txtCell72";
            this.txtCell72.Size = new System.Drawing.Size(44, 38);
            this.txtCell72.TabIndex = 71;
            this.txtCell72.Tag = "9;6";
            this.txtCell72.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell69
            // 
            this.txtCell69.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell69.Location = new System.Drawing.Point(100, 48);
            this.txtCell69.Multiline = true;
            this.txtCell69.Name = "txtCell69";
            this.txtCell69.Size = new System.Drawing.Size(44, 38);
            this.txtCell69.TabIndex = 68;
            this.txtCell69.Tag = "8;6";
            this.txtCell69.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell66
            // 
            this.txtCell66.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell66.Location = new System.Drawing.Point(100, 7);
            this.txtCell66.Multiline = true;
            this.txtCell66.Name = "txtCell66";
            this.txtCell66.Size = new System.Drawing.Size(44, 38);
            this.txtCell66.TabIndex = 65;
            this.txtCell66.Tag = "7;6";
            this.txtCell66.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell71
            // 
            this.txtCell71.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell71.Location = new System.Drawing.Point(52, 90);
            this.txtCell71.Multiline = true;
            this.txtCell71.Name = "txtCell71";
            this.txtCell71.Size = new System.Drawing.Size(44, 38);
            this.txtCell71.TabIndex = 70;
            this.txtCell71.Tag = "9;5";
            this.txtCell71.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell68
            // 
            this.txtCell68.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell68.Location = new System.Drawing.Point(52, 48);
            this.txtCell68.Multiline = true;
            this.txtCell68.Name = "txtCell68";
            this.txtCell68.Size = new System.Drawing.Size(44, 38);
            this.txtCell68.TabIndex = 67;
            this.txtCell68.Tag = "8;5";
            this.txtCell68.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell65
            // 
            this.txtCell65.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell65.Location = new System.Drawing.Point(52, 7);
            this.txtCell65.Multiline = true;
            this.txtCell65.Name = "txtCell65";
            this.txtCell65.Size = new System.Drawing.Size(44, 38);
            this.txtCell65.TabIndex = 64;
            this.txtCell65.Tag = "7;5";
            this.txtCell65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell70
            // 
            this.txtCell70.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell70.Location = new System.Drawing.Point(4, 90);
            this.txtCell70.Multiline = true;
            this.txtCell70.Name = "txtCell70";
            this.txtCell70.Size = new System.Drawing.Size(44, 38);
            this.txtCell70.TabIndex = 69;
            this.txtCell70.Tag = "9;4";
            this.txtCell70.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell67
            // 
            this.txtCell67.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell67.Location = new System.Drawing.Point(4, 48);
            this.txtCell67.Multiline = true;
            this.txtCell67.Name = "txtCell67";
            this.txtCell67.Size = new System.Drawing.Size(44, 38);
            this.txtCell67.TabIndex = 66;
            this.txtCell67.Tag = "8;4";
            this.txtCell67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell64
            // 
            this.txtCell64.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell64.Location = new System.Drawing.Point(4, 7);
            this.txtCell64.Multiline = true;
            this.txtCell64.Name = "txtCell64";
            this.txtCell64.Size = new System.Drawing.Size(44, 38);
            this.txtCell64.TabIndex = 63;
            this.txtCell64.Tag = "7;4";
            this.txtCell64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlQuadrant9
            // 
            this.pnlQuadrant9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlQuadrant9.Controls.Add(this.txtCell81);
            this.pnlQuadrant9.Controls.Add(this.txtCell78);
            this.pnlQuadrant9.Controls.Add(this.txtCell75);
            this.pnlQuadrant9.Controls.Add(this.txtCell80);
            this.pnlQuadrant9.Controls.Add(this.txtCell77);
            this.pnlQuadrant9.Controls.Add(this.txtCell74);
            this.pnlQuadrant9.Controls.Add(this.txtCell79);
            this.pnlQuadrant9.Controls.Add(this.txtCell76);
            this.pnlQuadrant9.Controls.Add(this.txtCell73);
            this.pnlQuadrant9.Location = new System.Drawing.Point(326, 311);
            this.pnlQuadrant9.Name = "pnlQuadrant9";
            this.pnlQuadrant9.Size = new System.Drawing.Size(149, 140);
            this.pnlQuadrant9.TabIndex = 8;
            // 
            // txtCell81
            // 
            this.txtCell81.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell81.Location = new System.Drawing.Point(100, 90);
            this.txtCell81.Multiline = true;
            this.txtCell81.Name = "txtCell81";
            this.txtCell81.Size = new System.Drawing.Size(44, 38);
            this.txtCell81.TabIndex = 80;
            this.txtCell81.Tag = "9;9";
            this.txtCell81.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell78
            // 
            this.txtCell78.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell78.Location = new System.Drawing.Point(100, 48);
            this.txtCell78.Multiline = true;
            this.txtCell78.Name = "txtCell78";
            this.txtCell78.Size = new System.Drawing.Size(44, 38);
            this.txtCell78.TabIndex = 77;
            this.txtCell78.Tag = "8;9";
            this.txtCell78.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell75
            // 
            this.txtCell75.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell75.Location = new System.Drawing.Point(100, 7);
            this.txtCell75.Multiline = true;
            this.txtCell75.Name = "txtCell75";
            this.txtCell75.Size = new System.Drawing.Size(44, 38);
            this.txtCell75.TabIndex = 74;
            this.txtCell75.Tag = "7;9";
            this.txtCell75.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell80
            // 
            this.txtCell80.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell80.Location = new System.Drawing.Point(52, 90);
            this.txtCell80.Multiline = true;
            this.txtCell80.Name = "txtCell80";
            this.txtCell80.Size = new System.Drawing.Size(44, 38);
            this.txtCell80.TabIndex = 79;
            this.txtCell80.Tag = "9;8";
            this.txtCell80.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell77
            // 
            this.txtCell77.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell77.Location = new System.Drawing.Point(52, 48);
            this.txtCell77.Multiline = true;
            this.txtCell77.Name = "txtCell77";
            this.txtCell77.Size = new System.Drawing.Size(44, 38);
            this.txtCell77.TabIndex = 76;
            this.txtCell77.Tag = "8;8";
            this.txtCell77.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell74
            // 
            this.txtCell74.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell74.Location = new System.Drawing.Point(52, 7);
            this.txtCell74.Multiline = true;
            this.txtCell74.Name = "txtCell74";
            this.txtCell74.Size = new System.Drawing.Size(44, 38);
            this.txtCell74.TabIndex = 73;
            this.txtCell74.Tag = "7;8";
            this.txtCell74.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell79
            // 
            this.txtCell79.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell79.Location = new System.Drawing.Point(4, 90);
            this.txtCell79.Multiline = true;
            this.txtCell79.Name = "txtCell79";
            this.txtCell79.Size = new System.Drawing.Size(44, 38);
            this.txtCell79.TabIndex = 78;
            this.txtCell79.Tag = "9;7";
            this.txtCell79.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell76
            // 
            this.txtCell76.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell76.Location = new System.Drawing.Point(4, 48);
            this.txtCell76.Multiline = true;
            this.txtCell76.Name = "txtCell76";
            this.txtCell76.Size = new System.Drawing.Size(44, 38);
            this.txtCell76.TabIndex = 75;
            this.txtCell76.Tag = "8;7";
            this.txtCell76.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCell73
            // 
            this.txtCell73.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCell73.Location = new System.Drawing.Point(4, 7);
            this.txtCell73.Multiline = true;
            this.txtCell73.Name = "txtCell73";
            this.txtCell73.Size = new System.Drawing.Size(44, 38);
            this.txtCell73.TabIndex = 72;
            this.txtCell73.Tag = "7;7";
            this.txtCell73.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlControls
            // 
            this.pnlControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlControls.Controls.Add(this.btnClear);
            this.pnlControls.Controls.Add(this.lblAnimationSeconds);
            this.pnlControls.Controls.Add(this.txtAnimationSeconds);
            this.pnlControls.Controls.Add(this.lblSolutions);
            this.pnlControls.Controls.Add(this.txtSolutionsNumber);
            this.pnlControls.Controls.Add(this.lblSearchFor);
            this.pnlControls.Controls.Add(this.btnExit);
            this.pnlControls.Controls.Add(this.btnSolve);
            this.pnlControls.Controls.Add(this.btnNew);
            this.pnlControls.Location = new System.Drawing.Point(12, 457);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(463, 57);
            this.pnlControls.TabIndex = 9;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(86, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 89;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblAnimationSeconds
            // 
            this.lblAnimationSeconds.AutoSize = true;
            this.lblAnimationSeconds.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimationSeconds.Location = new System.Drawing.Point(168, 34);
            this.lblAnimationSeconds.Name = "lblAnimationSeconds";
            this.lblAnimationSeconds.Size = new System.Drawing.Size(138, 13);
            this.lblAnimationSeconds.TabIndex = 88;
            this.lblAnimationSeconds.Text = "Tempo de animação";
            // 
            // txtAnimationSeconds
            // 
            this.txtAnimationSeconds.Location = new System.Drawing.Point(344, 32);
            this.txtAnimationSeconds.Name = "txtAnimationSeconds";
            this.txtAnimationSeconds.Size = new System.Drawing.Size(33, 20);
            this.txtAnimationSeconds.TabIndex = 87;
            // 
            // lblSolutions
            // 
            this.lblSolutions.AutoSize = true;
            this.lblSolutions.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSolutions.Location = new System.Drawing.Point(312, 10);
            this.lblSolutions.Name = "lblSolutions";
            this.lblSolutions.Size = new System.Drawing.Size(65, 13);
            this.lblSolutions.TabIndex = 86;
            this.lblSolutions.Text = "Soluções";
            // 
            // txtSolutionsNumber
            // 
            this.txtSolutionsNumber.Location = new System.Drawing.Point(263, 7);
            this.txtSolutionsNumber.Name = "txtSolutionsNumber";
            this.txtSolutionsNumber.Size = new System.Drawing.Size(43, 20);
            this.txtSolutionsNumber.TabIndex = 85;
            this.txtSolutionsNumber.Text = "1";
            // 
            // lblSearchFor
            // 
            this.lblSearchFor.AutoSize = true;
            this.lblSearchFor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchFor.Location = new System.Drawing.Point(167, 10);
            this.lblSearchFor.Name = "lblSearchFor";
            this.lblSearchFor.Size = new System.Drawing.Size(90, 13);
            this.lblSearchFor.TabIndex = 84;
            this.lblSearchFor.Text = "Procurar por";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(86, 29);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 83;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSolve
            // 
            this.btnSolve.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(5, 29);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 23);
            this.btnSolve.TabIndex = 82;
            this.btnSolve.Text = "Resolver";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(5, 5);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 81;
            this.btnNew.Text = "Novo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lstResults
            // 
            this.lstResults.DisplayMember = "Number";
            this.lstResults.FormattingEnabled = true;
            this.lstResults.Location = new System.Drawing.Point(12, 8);
            this.lstResults.Name = "lstResults";
            this.lstResults.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstResults.Size = new System.Drawing.Size(330, 420);
            this.lstResults.TabIndex = 10;
            // 
            // pnlResults
            // 
            this.pnlResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlResults.Controls.Add(this.btnAbrir);
            this.pnlResults.Controls.Add(this.lstResults);
            this.pnlResults.Location = new System.Drawing.Point(495, 12);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(359, 502);
            this.pnlResults.TabIndex = 27;
            // 
            // btnAbrir
            // 
            this.btnAbrir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrir.Location = new System.Drawing.Point(267, 450);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 90;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFechar.Location = new System.Drawing.Point(400, 456);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 91;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Visible = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 521);
            this.ControlBox = false;
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlQuadrant9);
            this.Controls.Add(this.pnlQuadrant8);
            this.Controls.Add(this.pnlQuadrant7);
            this.Controls.Add(this.pnlQuadrant6);
            this.Controls.Add(this.pnlQuadrant5);
            this.Controls.Add(this.pnlQuadrant4);
            this.Controls.Add(this.pnlQuadrant3);
            this.Controls.Add(this.pnlQuadrant2);
            this.Controls.Add(this.pnlQuadrant1);
            this.Controls.Add(this.pnlResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmGame";
            this.Text = "Carubbi\'s Sudoku 1.0";
            this.pnlQuadrant1.ResumeLayout(false);
            this.pnlQuadrant1.PerformLayout();
            this.pnlQuadrant2.ResumeLayout(false);
            this.pnlQuadrant2.PerformLayout();
            this.pnlQuadrant3.ResumeLayout(false);
            this.pnlQuadrant3.PerformLayout();
            this.pnlQuadrant4.ResumeLayout(false);
            this.pnlQuadrant4.PerformLayout();
            this.pnlQuadrant5.ResumeLayout(false);
            this.pnlQuadrant5.PerformLayout();
            this.pnlQuadrant6.ResumeLayout(false);
            this.pnlQuadrant6.PerformLayout();
            this.pnlQuadrant7.ResumeLayout(false);
            this.pnlQuadrant7.PerformLayout();
            this.pnlQuadrant8.ResumeLayout(false);
            this.pnlQuadrant8.PerformLayout();
            this.pnlQuadrant9.ResumeLayout(false);
            this.pnlQuadrant9.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAnimationSeconds)).EndInit();
            this.pnlResults.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlQuadrant1;
        private TextBox txtCell9;
        private TextBox txtCell6;
        private TextBox txtCell3;
        private TextBox txtCell8;
        private TextBox txtCell5;
        private TextBox txtCell2;
        private TextBox txtCell7;
        private TextBox txtCell4;
        private TextBox txtCell1;
        private Panel pnlQuadrant2;
        private TextBox txtCell18;
        private TextBox txtCell15;
        private TextBox txtCell12;
        private TextBox textBox17;
        private TextBox txtCell14;
        private TextBox txtCell11;
        private TextBox txtCell16;
        private TextBox txtCell13;
        private TextBox txtCell10;
        private Panel pnlQuadrant3;
        private TextBox txtCell27;
        private TextBox txtCell24;
        private TextBox txtCell21;
        private TextBox txtCell26;
        private TextBox txtCell23;
        private TextBox txtCell20;
        private TextBox txtCell25;
        private TextBox txtCell22;
        private TextBox txtCell19;
        private Panel pnlQuadrant4;
        private TextBox txtCell36;
        private TextBox txtCell33;
        private TextBox txtCell30;
        private TextBox txtCell35;
        private TextBox txtCell32;
        private TextBox txtCell29;
        private TextBox txtCell34;
        private TextBox txtCell31;
        private TextBox txtCell28;
        private Panel pnlQuadrant5;
        private TextBox txtCell45;
        private TextBox txtCell42;
        private TextBox txtCell39;
        private TextBox txtCell44;
        private TextBox txtCell41;
        private TextBox txtCell38;
        private TextBox txtCell43;
        private TextBox txtCell40;
        private TextBox txtCell37;
        private Panel pnlQuadrant6;
        private TextBox txtCell54;
        private TextBox txtCell51;
        private TextBox txtCell48;
        private TextBox txtCell53;
        private TextBox txtCell50;
        private TextBox txtCell47;
        private TextBox txtCell52;
        private TextBox txtCell49;
        private TextBox txtCell46;
        private Panel pnlQuadrant7;
        private TextBox txtCell63;
        private TextBox txtCell60;
        private TextBox txtCell57;
        private TextBox txtCell62;
        private TextBox txtCell59;
        private TextBox txtCell56;
        private TextBox txtCell61;
        private TextBox txtCell58;
        private TextBox txtCell55;
        private Panel pnlQuadrant8;
        private TextBox txtCell72;
        private TextBox txtCell69;
        private TextBox txtCell66;
        private TextBox txtCell71;
        private TextBox txtCell68;
        private TextBox txtCell65;
        private TextBox txtCell70;
        private TextBox txtCell67;
        private TextBox txtCell64;
        private Panel pnlQuadrant9;
        private TextBox txtCell81;
        private TextBox txtCell78;
        private TextBox txtCell75;
        private TextBox txtCell80;
        private TextBox txtCell77;
        private TextBox txtCell74;
        private TextBox txtCell79;
        private TextBox txtCell76;
        private TextBox txtCell73;
        private Panel pnlControls;
        private Label lblSolutions;
        private TextBox txtSolutionsNumber;
        private Label lblSearchFor;
        private Button btnExit;
        private Button btnSolve;
        private Button btnNew;
        private NumericUpDown txtAnimationSeconds;
        private Label lblAnimationSeconds;
        private Button btnClear;
        private ListBox lstResults;
        private Panel pnlResults;
        private Button btnAbrir;
        private Button btnFechar;
    }
}

