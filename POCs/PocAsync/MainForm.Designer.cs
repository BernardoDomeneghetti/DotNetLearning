namespace PocAsync
{
    partial class MainForm
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
            this.gpbxConsole = new System.Windows.Forms.GroupBox();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnVerifyAsyncV2 = new System.Windows.Forms.Button();
            this.btnVerifyAsync = new System.Windows.Forms.Button();
            this.btnVerifyDumbAsync = new System.Windows.Forms.Button();
            this.btnVerifySycn = new System.Windows.Forms.Button();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbxConsole
            // 
            this.gpbxConsole.Location = new System.Drawing.Point(240, 12);
            this.gpbxConsole.Name = "gpbxConsole";
            this.gpbxConsole.Size = new System.Drawing.Size(545, 276);
            this.gpbxConsole.TabIndex = 3;
            this.gpbxConsole.TabStop = false;
            this.gpbxConsole.Text = "Console";
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnCancel);
            this.pnlControls.Controls.Add(this.btnVerifyAsyncV2);
            this.pnlControls.Controls.Add(this.btnVerifyAsync);
            this.pnlControls.Controls.Add(this.btnVerifyDumbAsync);
            this.pnlControls.Controls.Add(this.btnVerifySycn);
            this.pnlControls.Location = new System.Drawing.Point(9, 9);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(225, 276);
            this.pnlControls.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(3, 234);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(219, 39);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnVerifyAsyncV2
            // 
            this.btnVerifyAsyncV2.Location = new System.Drawing.Point(3, 138);
            this.btnVerifyAsyncV2.Name = "btnVerifyAsyncV2";
            this.btnVerifyAsyncV2.Size = new System.Drawing.Size(219, 39);
            this.btnVerifyAsyncV2.TabIndex = 4;
            this.btnVerifyAsyncV2.Text = "Verifica Assíncrono V2";
            this.btnVerifyAsyncV2.UseVisualStyleBackColor = true;
            // 
            // btnVerifyAsync
            // 
            this.btnVerifyAsync.Location = new System.Drawing.Point(3, 93);
            this.btnVerifyAsync.Name = "btnVerifyAsync";
            this.btnVerifyAsync.Size = new System.Drawing.Size(219, 39);
            this.btnVerifyAsync.TabIndex = 3;
            this.btnVerifyAsync.Text = "Verifica Assíncrono";
            this.btnVerifyAsync.UseVisualStyleBackColor = true;
            // 
            // btnVerifyDumbAsync
            // 
            this.btnVerifyDumbAsync.Location = new System.Drawing.Point(3, 48);
            this.btnVerifyDumbAsync.Name = "btnVerifyDumbAsync";
            this.btnVerifyDumbAsync.Size = new System.Drawing.Size(219, 39);
            this.btnVerifyDumbAsync.TabIndex = 2;
            this.btnVerifyDumbAsync.Text = "Verifica Assíncrono Burro";
            this.btnVerifyDumbAsync.UseVisualStyleBackColor = true;
            // 
            // btnVerifySycn
            // 
            this.btnVerifySycn.Location = new System.Drawing.Point(3, 3);
            this.btnVerifySycn.Name = "btnVerifySycn";
            this.btnVerifySycn.Size = new System.Drawing.Size(219, 39);
            this.btnVerifySycn.TabIndex = 1;
            this.btnVerifySycn.Text = "Verifica Síncrono";
            this.btnVerifySycn.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 338);
            this.Controls.Add(this.gpbxConsole);
            this.Controls.Add(this.pnlControls);
            this.Name = "MainForm";
            this.Text = "Proof of Concept - Async";
            this.pnlControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gpbxConsole;
        private Panel pnlControls;
        private Button btnCancel;
        private Button btnVerifyAsyncV2;
        private Button btnVerifyAsync;
        private Button btnVerifyDumbAsync;
        private Button btnVerifySycn;
    }
}