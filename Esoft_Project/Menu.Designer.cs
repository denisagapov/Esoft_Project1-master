namespace Esoft_Project
{
    partial class Menu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.buttonOpenAgents = new System.Windows.Forms.Button();
            this.buttonOpenRealEstates = new System.Windows.Forms.Button();
            this.buttonOpenClients = new System.Windows.Forms.Button();
            this.buttonOpenDeals = new System.Windows.Forms.Button();
            this.buttonOpenSupplySet = new System.Windows.Forms.Button();
            this.buttonOpenDemands = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = global::Esoft_Project.Properties.Resources.logo;
            this.Logo.Location = new System.Drawing.Point(8, 31);
            this.Logo.Margin = new System.Windows.Forms.Padding(15);
            this.Logo.Name = "Logo";
            this.Logo.Padding = new System.Windows.Forms.Padding(10);
            this.Logo.Size = new System.Drawing.Size(264, 124);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // buttonOpenAgents
            // 
            this.buttonOpenAgents.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOpenAgents.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonOpenAgents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenAgents.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenAgents.Location = new System.Drawing.Point(6, 249);
            this.buttonOpenAgents.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenAgents.Name = "buttonOpenAgents";
            this.buttonOpenAgents.Padding = new System.Windows.Forms.Padding(10);
            this.buttonOpenAgents.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenAgents.TabIndex = 1;
            this.buttonOpenAgents.TabStop = false;
            this.buttonOpenAgents.Text = "Риелторы";
            this.buttonOpenAgents.UseVisualStyleBackColor = false;
            this.buttonOpenAgents.Click += new System.EventHandler(this.buttonOpenAgents_Click);
            // 
            // buttonOpenRealEstates
            // 
            this.buttonOpenRealEstates.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOpenRealEstates.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonOpenRealEstates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenRealEstates.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenRealEstates.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonOpenRealEstates.Location = new System.Drawing.Point(7, 312);
            this.buttonOpenRealEstates.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenRealEstates.Name = "buttonOpenRealEstates";
            this.buttonOpenRealEstates.Padding = new System.Windows.Forms.Padding(10);
            this.buttonOpenRealEstates.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenRealEstates.TabIndex = 1;
            this.buttonOpenRealEstates.TabStop = false;
            this.buttonOpenRealEstates.Text = "Объекты недвижимости";
            this.buttonOpenRealEstates.UseVisualStyleBackColor = false;
            this.buttonOpenRealEstates.Click += new System.EventHandler(this.buttonOpenRealEstates_Click);
            // 
            // buttonOpenClients
            // 
            this.buttonOpenClients.BackColor = System.Drawing.SystemColors.Control;
            this.buttonOpenClients.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonOpenClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenClients.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenClients.ForeColor = System.Drawing.SystemColors.Desktop;
            this.buttonOpenClients.Location = new System.Drawing.Point(7, 185);
            this.buttonOpenClients.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenClients.Name = "buttonOpenClients";
            this.buttonOpenClients.Padding = new System.Windows.Forms.Padding(10);
            this.buttonOpenClients.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenClients.TabIndex = 1;
            this.buttonOpenClients.TabStop = false;
            this.buttonOpenClients.Text = "Клиенты";
            this.buttonOpenClients.UseVisualStyleBackColor = false;
            this.buttonOpenClients.Click += new System.EventHandler(this.buttonOpenClients_Click);
            // 
            // buttonOpenDeals
            // 
            this.buttonOpenDeals.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonOpenDeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenDeals.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenDeals.Location = new System.Drawing.Point(7, 500);
            this.buttonOpenDeals.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenDeals.Name = "buttonOpenDeals";
            this.buttonOpenDeals.Padding = new System.Windows.Forms.Padding(10);
            this.buttonOpenDeals.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenDeals.TabIndex = 1;
            this.buttonOpenDeals.TabStop = false;
            this.buttonOpenDeals.Text = "Сделки";
            this.buttonOpenDeals.UseVisualStyleBackColor = true;
            this.buttonOpenDeals.Click += new System.EventHandler(this.buttonOpenDeals_Click);
            // 
            // buttonOpenSupplySet
            // 
            this.buttonOpenSupplySet.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonOpenSupplySet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenSupplySet.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenSupplySet.Location = new System.Drawing.Point(7, 375);
            this.buttonOpenSupplySet.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenSupplySet.Name = "buttonOpenSupplySet";
            this.buttonOpenSupplySet.Padding = new System.Windows.Forms.Padding(10);
            this.buttonOpenSupplySet.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenSupplySet.TabIndex = 1;
            this.buttonOpenSupplySet.TabStop = false;
            this.buttonOpenSupplySet.Text = "Предложения";
            this.buttonOpenSupplySet.UseVisualStyleBackColor = true;
            this.buttonOpenSupplySet.Click += new System.EventHandler(this.buttonOpenSupplySet_Click);
            // 
            // buttonOpenDemands
            // 
            this.buttonOpenDemands.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.buttonOpenDemands.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenDemands.Font = new System.Drawing.Font("Roboto Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOpenDemands.Location = new System.Drawing.Point(6, 439);
            this.buttonOpenDemands.Margin = new System.Windows.Forms.Padding(15);
            this.buttonOpenDemands.Name = "buttonOpenDemands";
            this.buttonOpenDemands.Padding = new System.Windows.Forms.Padding(10);
            this.buttonOpenDemands.Size = new System.Drawing.Size(265, 48);
            this.buttonOpenDemands.TabIndex = 1;
            this.buttonOpenDemands.TabStop = false;
            this.buttonOpenDemands.Text = "Потребности";
            this.buttonOpenDemands.UseVisualStyleBackColor = true;
            this.buttonOpenDemands.Click += new System.EventHandler(this.buttonOpenDemands_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Location = new System.Drawing.Point(5, 9);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(44, 13);
            this.labelHello.TabIndex = 2;
            this.labelHello.Text = "Привет";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 562);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonOpenDemands);
            this.Controls.Add(this.buttonOpenSupplySet);
            this.Controls.Add(this.buttonOpenDeals);
            this.Controls.Add(this.buttonOpenClients);
            this.Controls.Add(this.buttonOpenRealEstates);
            this.Controls.Add(this.buttonOpenAgents);
            this.Controls.Add(this.Logo);
            this.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Esoft";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button buttonOpenAgents;
        private System.Windows.Forms.Button buttonOpenRealEstates;
        private System.Windows.Forms.Button buttonOpenClients;
        private System.Windows.Forms.Button buttonOpenDeals;
        private System.Windows.Forms.Button buttonOpenSupplySet;
        private System.Windows.Forms.Button buttonOpenDemands;
        private System.Windows.Forms.Label labelHello;
    }
}

