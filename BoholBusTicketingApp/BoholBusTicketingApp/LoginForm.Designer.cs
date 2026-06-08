namespace BoholBusTicketingApp
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.subtitleLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Form
            this.ClientSize = new System.Drawing.Size(450, 500);
            this.Name = "LoginForm";
            this.Text = "Login - Bohol Bus Ticketing";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // titleLabel
            this.titleLabel.Location = new System.Drawing.Point(30, 80);
            this.titleLabel.Size = new System.Drawing.Size(390, 50);
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // subtitleLabel
            this.subtitleLabel.Location = new System.Drawing.Point(30, 130);
            this.subtitleLabel.Size = new System.Drawing.Size(390, 30);
            this.subtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // usernameLabel
            this.usernameLabel.Location = new System.Drawing.Point(30, 180);
            this.usernameLabel.Size = new System.Drawing.Size(390, 20);
            this.usernameLabel.Text = "Username";

            // usernameTextBox
            this.usernameTextBox.Location = new System.Drawing.Point(30, 205);
            this.usernameTextBox.Size = new System.Drawing.Size(390, 35);
            this.usernameTextBox.TabIndex = 0;

            // passwordLabel
            this.passwordLabel.Location = new System.Drawing.Point(30, 250);
            this.passwordLabel.Size = new System.Drawing.Size(390, 20);
            this.passwordLabel.Text = "Password";

            // passwordTextBox
            this.passwordTextBox.Location = new System.Drawing.Point(30, 275);
            this.passwordTextBox.Size = new System.Drawing.Size(390, 35);
            this.passwordTextBox.TabIndex = 1;

            // loginButton
            this.loginButton.Location = new System.Drawing.Point(30, 340);
            this.loginButton.Size = new System.Drawing.Size(185, 45);
            this.loginButton.TabIndex = 2;
            this.loginButton.UseVisualStyleBackColor = true;

            // exitButton
            this.exitButton.Location = new System.Drawing.Point(235, 340);
            this.exitButton.Size = new System.Drawing.Size(185, 45);
            this.exitButton.TabIndex = 3;
            this.exitButton.UseVisualStyleBackColor = true;

            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label subtitleLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
    }
}
