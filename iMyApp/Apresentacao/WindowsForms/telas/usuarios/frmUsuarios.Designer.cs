namespace WindowsForms.telas.usuarios
{
    partial class frmUsuarios
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
            txtFrom = new TextBox();
            txtTo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtSubject = new TextBox();
            label4 = new Label();
            txtMessage = new TextBox();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(22, 40);
            txtFrom.Name = "txtFrom";
            txtFrom.PlaceholderText = "txtFrom";
            txtFrom.Size = new Size(142, 23);
            txtFrom.TabIndex = 0;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(24, 88);
            txtTo.Name = "txtTo";
            txtTo.PlaceholderText = "txtTo";
            txtTo.Size = new Size(244, 23);
            txtTo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 22);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 2;
            label1.Text = "DE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 70);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 3;
            label2.Text = "PARA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 125);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 5;
            label3.Text = "ASSUNTO";
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(23, 142);
            txtSubject.Name = "txtSubject";
            txtSubject.PlaceholderText = "txtSubject";
            txtSubject.Size = new Size(381, 23);
            txtSubject.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 180);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 6;
            label4.Text = "MENSAGEM";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(23, 198);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.PlaceholderText = "txtMessage";
            txtMessage.Size = new Size(381, 118);
            txtMessage.TabIndex = 7;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(24, 342);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(75, 23);
            btnEnviar.TabIndex = 8;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // frmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnviar);
            Controls.Add(txtMessage);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSubject);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Name = "frmUsuarios";
            Text = "frmUsuarios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFrom;
        private TextBox txtTo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtSubject;
        private Label label4;
        private TextBox txtMessage;
        private Button btnEnviar;
    }
}