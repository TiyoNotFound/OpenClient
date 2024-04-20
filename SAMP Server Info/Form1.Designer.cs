namespace ServerListApp
{
    partial class Form1
    {
        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.Button getServerInfoButton;
        private System.Windows.Forms.Label hostnameLabel;
        private System.Windows.Forms.Label playersLabel;
        private System.Windows.Forms.Label gamemodeLabel;
        private System.Windows.Forms.Label allowedClientsLabel;
        private System.Windows.Forms.Label artworkLabel;
        private System.Windows.Forms.Label lagcompLabel;
        private System.Windows.Forms.Label mapnameLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label weatherLabel;
        private System.Windows.Forms.Label weburlLabel;
        private System.Windows.Forms.Label worldtimeLabel;
        private System.Windows.Forms.TextBox jsonTextBox;

        private void InitializeComponent()
        {
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.getServerInfoButton = new System.Windows.Forms.Button();
            this.hostnameLabel = new System.Windows.Forms.Label();
            this.playersLabel = new System.Windows.Forms.Label();
            this.gamemodeLabel = new System.Windows.Forms.Label();
            this.allowedClientsLabel = new System.Windows.Forms.Label();
            this.artworkLabel = new System.Windows.Forms.Label();
            this.lagcompLabel = new System.Windows.Forms.Label();
            this.mapnameLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.weatherLabel = new System.Windows.Forms.Label();
            this.weburlLabel = new System.Windows.Forms.Label();
            this.worldtimeLabel = new System.Windows.Forms.Label();
            this.jsonTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ipAddressLabel.ForeColor = System.Drawing.Color.Blue;
            this.ipAddressLabel.Location = new System.Drawing.Point(12, 15);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(95, 23);
            this.ipAddressLabel.TabIndex = 0;
            this.ipAddressLabel.Text = "IP Address";
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ipAddressTextBox.Location = new System.Drawing.Point(125, 12);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(200, 30);
            this.ipAddressTextBox.TabIndex = 1;
            // 
            // getServerInfoButton
            // 
            this.getServerInfoButton.BackColor = System.Drawing.Color.Green;
            this.getServerInfoButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.getServerInfoButton.ForeColor = System.Drawing.Color.White;
            this.getServerInfoButton.Location = new System.Drawing.Point(340, 10);
            this.getServerInfoButton.Name = "getServerInfoButton";
            this.getServerInfoButton.Size = new System.Drawing.Size(120, 35);
            this.getServerInfoButton.TabIndex = 2;
            this.getServerInfoButton.Text = "Get Info";
            this.getServerInfoButton.UseVisualStyleBackColor = false;
            this.getServerInfoButton.Click += new System.EventHandler(this.getServerInfoButton_Click);
            // 
            // hostnameLabel
            // 
            this.hostnameLabel.AutoSize = true;
            this.hostnameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hostnameLabel.Location = new System.Drawing.Point(12, 50);
            this.hostnameLabel.Name = "hostnameLabel";
            this.hostnameLabel.Size = new System.Drawing.Size(0, 23);
            this.hostnameLabel.TabIndex = 3;
            // 
            // playersLabel
            // 
            this.playersLabel.AutoSize = true;
            this.playersLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.playersLabel.Location = new System.Drawing.Point(12, 80);
            this.playersLabel.Name = "playersLabel";
            this.playersLabel.Size = new System.Drawing.Size(0, 23);
            this.playersLabel.TabIndex = 4;
            // 
            // gamemodeLabel
            // 
            this.gamemodeLabel.AutoSize = true;
            this.gamemodeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gamemodeLabel.Location = new System.Drawing.Point(12, 110);
            this.gamemodeLabel.Name = "gamemodeLabel";
            this.gamemodeLabel.Size = new System.Drawing.Size(0, 23);
            this.gamemodeLabel.TabIndex = 5;
            // 
            // allowedClientsLabel
            // 
            this.allowedClientsLabel.AutoSize = true;
            this.allowedClientsLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.allowedClientsLabel.Location = new System.Drawing.Point(12, 140);
            this.allowedClientsLabel.Name = "allowedClientsLabel";
            this.allowedClientsLabel.Size = new System.Drawing.Size(0, 23);
            this.allowedClientsLabel.TabIndex = 6;
            // 
            // artworkLabel
            // 
            this.artworkLabel.AutoSize = true;
            this.artworkLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.artworkLabel.Location = new System.Drawing.Point(12, 170);
            this.artworkLabel.Name = "artworkLabel";
            this.artworkLabel.Size = new System.Drawing.Size(0, 23);
            this.artworkLabel.TabIndex = 7;
            // 
            // lagcompLabel
            // 
            this.lagcompLabel.AutoSize = true;
            this.lagcompLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lagcompLabel.Location = new System.Drawing.Point(12, 200);
            this.lagcompLabel.Name = "lagcompLabel";
            this.lagcompLabel.Size = new System.Drawing.Size(0, 23);
            this.lagcompLabel.TabIndex = 8;
            // 
            // mapnameLabel
            // 
            this.mapnameLabel.AutoSize = true;
            this.mapnameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.mapnameLabel.Location = new System.Drawing.Point(12, 230);
            this.mapnameLabel.Name = "mapnameLabel";
            this.mapnameLabel.Size = new System.Drawing.Size(0, 23);
            this.mapnameLabel.TabIndex = 9;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.versionLabel.Location = new System.Drawing.Point(12, 260);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(0, 23);
            this.versionLabel.TabIndex = 10;
            // 
            // weatherLabel
            // 
            this.weatherLabel.AutoSize = true;
            this.weatherLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.weatherLabel.Location = new System.Drawing.Point(12, 290);
            this.weatherLabel.Name = "weatherLabel";
            this.weatherLabel.Size = new System.Drawing.Size(0, 23);
            this.weatherLabel.TabIndex = 11;
            // 
            // weburlLabel
            // 
            this.weburlLabel.AutoSize = true;
            this.weburlLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.weburlLabel.Location = new System.Drawing.Point(12, 320);
            this.weburlLabel.Name = "weburlLabel";
            this.weburlLabel.Size = new System.Drawing.Size(0, 23);
            this.weburlLabel.TabIndex = 12;
            // 
            // worldtimeLabel
            // 
            this.worldtimeLabel.AutoSize = true;
            this.worldtimeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.worldtimeLabel.Location = new System.Drawing.Point(12, 350);
            this.worldtimeLabel.Name = "worldtimeLabel";
            this.worldtimeLabel.Size = new System.Drawing.Size(0, 23);
            this.worldtimeLabel.TabIndex = 13;
            // 
            // jsonTextBox
            // 
            this.jsonTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.jsonTextBox.Location = new System.Drawing.Point(485, 10);
            this.jsonTextBox.Multiline = true;
            this.jsonTextBox.Name = "jsonTextBox";
            this.jsonTextBox.ReadOnly = true;
            this.jsonTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.jsonTextBox.Size = new System.Drawing.Size(400, 420);
            this.jsonTextBox.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 442);
            this.Controls.Add(this.jsonTextBox);
            this.Controls.Add(this.worldtimeLabel);
            this.Controls.Add(this.weburlLabel);
            this.Controls.Add(this.weatherLabel);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.mapnameLabel);
            this.Controls.Add(this.lagcompLabel);
            this.Controls.Add(this.artworkLabel);
            this.Controls.Add(this.allowedClientsLabel);
            this.Controls.Add(this.gamemodeLabel);
            this.Controls.Add(this.playersLabel);
            this.Controls.Add(this.hostnameLabel);
            this.Controls.Add(this.getServerInfoButton);
            this.Controls.Add(this.ipAddressTextBox);
            this.Controls.Add(this.ipAddressLabel);
            this.Name = "Form1";
            this.Text = "Server Info";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
