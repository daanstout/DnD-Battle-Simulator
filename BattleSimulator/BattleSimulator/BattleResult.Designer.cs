namespace BattleSimulator {
    partial class BattleResult {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.alliedUnitLabel = new System.Windows.Forms.Label();
            this.enemyUnitLabel = new System.Windows.Forms.Label();
            this.damageLabel = new System.Windows.Forms.Label();
            this.attackRollLabel = new System.Windows.Forms.Label();
            this.alliedUnitAttackRoll = new System.Windows.Forms.TextBox();
            this.enemyUnitAttackRoll = new System.Windows.Forms.TextBox();
            this.enemyUnitDamageTextbox = new System.Windows.Forms.TextBox();
            this.alliedUnitDamageTextbox = new System.Windows.Forms.TextBox();
            this.enemyUnitDamageDieTextbox = new System.Windows.Forms.TextBox();
            this.alliedUnitDamageDieTextbox = new System.Windows.Forms.TextBox();
            this.damageDieLabel = new System.Windows.Forms.Label();
            this.enemyUnitArmorClassTextbox = new System.Windows.Forms.TextBox();
            this.alliedUnitArmorClassTextbox = new System.Windows.Forms.TextBox();
            this.armorClassLabel = new System.Windows.Forms.Label();
            this.enemyUnitDamageModifierTextbox = new System.Windows.Forms.TextBox();
            this.alliedUnitDamageModifierTextbox = new System.Windows.Forms.TextBox();
            this.damageModifierLabel = new System.Windows.Forms.Label();
            this.enemyUnitToHitTextbox = new System.Windows.Forms.TextBox();
            this.alliedUnitToHitTextbox = new System.Windows.Forms.TextBox();
            this.toHitLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // alliedUnitLabel
            // 
            this.alliedUnitLabel.AutoSize = true;
            this.alliedUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.alliedUnitLabel.Location = new System.Drawing.Point(139, 9);
            this.alliedUnitLabel.Name = "alliedUnitLabel";
            this.alliedUnitLabel.Size = new System.Drawing.Size(71, 17);
            this.alliedUnitLabel.TabIndex = 8;
            this.alliedUnitLabel.Text = "Allied Unit";
            // 
            // enemyUnitLabel
            // 
            this.enemyUnitLabel.AutoSize = true;
            this.enemyUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enemyUnitLabel.Location = new System.Drawing.Point(239, 9);
            this.enemyUnitLabel.Name = "enemyUnitLabel";
            this.enemyUnitLabel.Size = new System.Drawing.Size(80, 17);
            this.enemyUnitLabel.TabIndex = 9;
            this.enemyUnitLabel.Text = "Enemy Unit";
            // 
            // damageLabel
            // 
            this.damageLabel.AutoSize = true;
            this.damageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.damageLabel.Location = new System.Drawing.Point(10, 60);
            this.damageLabel.Name = "damageLabel";
            this.damageLabel.Size = new System.Drawing.Size(103, 17);
            this.damageLabel.TabIndex = 10;
            this.damageLabel.Text = "Damage Done:";
            // 
            // attackRollLabel
            // 
            this.attackRollLabel.AutoSize = true;
            this.attackRollLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.attackRollLabel.Location = new System.Drawing.Point(10, 30);
            this.attackRollLabel.Name = "attackRollLabel";
            this.attackRollLabel.Size = new System.Drawing.Size(79, 17);
            this.attackRollLabel.TabIndex = 11;
            this.attackRollLabel.Text = "Attack Roll:";
            // 
            // alliedUnitAttackRoll
            // 
            this.alliedUnitAttackRoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.alliedUnitAttackRoll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alliedUnitAttackRoll.Enabled = false;
            this.alliedUnitAttackRoll.ForeColor = System.Drawing.Color.White;
            this.alliedUnitAttackRoll.Location = new System.Drawing.Point(138, 30);
            this.alliedUnitAttackRoll.Name = "alliedUnitAttackRoll";
            this.alliedUnitAttackRoll.Size = new System.Drawing.Size(72, 20);
            this.alliedUnitAttackRoll.TabIndex = 12;
            this.alliedUnitAttackRoll.TabStop = false;
            // 
            // enemyUnitAttackRoll
            // 
            this.enemyUnitAttackRoll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.enemyUnitAttackRoll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyUnitAttackRoll.Enabled = false;
            this.enemyUnitAttackRoll.ForeColor = System.Drawing.Color.White;
            this.enemyUnitAttackRoll.Location = new System.Drawing.Point(242, 30);
            this.enemyUnitAttackRoll.Name = "enemyUnitAttackRoll";
            this.enemyUnitAttackRoll.Size = new System.Drawing.Size(72, 20);
            this.enemyUnitAttackRoll.TabIndex = 13;
            this.enemyUnitAttackRoll.TabStop = false;
            // 
            // enemyUnitDamageTextbox
            // 
            this.enemyUnitDamageTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.enemyUnitDamageTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyUnitDamageTextbox.Enabled = false;
            this.enemyUnitDamageTextbox.ForeColor = System.Drawing.Color.White;
            this.enemyUnitDamageTextbox.Location = new System.Drawing.Point(242, 60);
            this.enemyUnitDamageTextbox.Name = "enemyUnitDamageTextbox";
            this.enemyUnitDamageTextbox.Size = new System.Drawing.Size(72, 20);
            this.enemyUnitDamageTextbox.TabIndex = 15;
            this.enemyUnitDamageTextbox.TabStop = false;
            // 
            // alliedUnitDamageTextbox
            // 
            this.alliedUnitDamageTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.alliedUnitDamageTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alliedUnitDamageTextbox.Enabled = false;
            this.alliedUnitDamageTextbox.ForeColor = System.Drawing.Color.White;
            this.alliedUnitDamageTextbox.Location = new System.Drawing.Point(138, 60);
            this.alliedUnitDamageTextbox.Name = "alliedUnitDamageTextbox";
            this.alliedUnitDamageTextbox.Size = new System.Drawing.Size(72, 20);
            this.alliedUnitDamageTextbox.TabIndex = 14;
            this.alliedUnitDamageTextbox.TabStop = false;
            // 
            // enemyUnitDamageDieTextbox
            // 
            this.enemyUnitDamageDieTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.enemyUnitDamageDieTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyUnitDamageDieTextbox.Enabled = false;
            this.enemyUnitDamageDieTextbox.ForeColor = System.Drawing.Color.White;
            this.enemyUnitDamageDieTextbox.Location = new System.Drawing.Point(242, 90);
            this.enemyUnitDamageDieTextbox.Name = "enemyUnitDamageDieTextbox";
            this.enemyUnitDamageDieTextbox.Size = new System.Drawing.Size(72, 20);
            this.enemyUnitDamageDieTextbox.TabIndex = 18;
            this.enemyUnitDamageDieTextbox.TabStop = false;
            // 
            // alliedUnitDamageDieTextbox
            // 
            this.alliedUnitDamageDieTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.alliedUnitDamageDieTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alliedUnitDamageDieTextbox.Enabled = false;
            this.alliedUnitDamageDieTextbox.ForeColor = System.Drawing.Color.White;
            this.alliedUnitDamageDieTextbox.Location = new System.Drawing.Point(138, 90);
            this.alliedUnitDamageDieTextbox.Name = "alliedUnitDamageDieTextbox";
            this.alliedUnitDamageDieTextbox.Size = new System.Drawing.Size(72, 20);
            this.alliedUnitDamageDieTextbox.TabIndex = 17;
            this.alliedUnitDamageDieTextbox.TabStop = false;
            // 
            // damageDieLabel
            // 
            this.damageDieLabel.AutoSize = true;
            this.damageDieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.damageDieLabel.Location = new System.Drawing.Point(10, 90);
            this.damageDieLabel.Name = "damageDieLabel";
            this.damageDieLabel.Size = new System.Drawing.Size(97, 17);
            this.damageDieLabel.TabIndex = 16;
            this.damageDieLabel.Text = "Damage Dice:";
            // 
            // enemyUnitArmorClassTextbox
            // 
            this.enemyUnitArmorClassTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.enemyUnitArmorClassTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyUnitArmorClassTextbox.Enabled = false;
            this.enemyUnitArmorClassTextbox.ForeColor = System.Drawing.Color.White;
            this.enemyUnitArmorClassTextbox.Location = new System.Drawing.Point(242, 120);
            this.enemyUnitArmorClassTextbox.Name = "enemyUnitArmorClassTextbox";
            this.enemyUnitArmorClassTextbox.Size = new System.Drawing.Size(72, 20);
            this.enemyUnitArmorClassTextbox.TabIndex = 21;
            this.enemyUnitArmorClassTextbox.TabStop = false;
            // 
            // alliedUnitArmorClassTextbox
            // 
            this.alliedUnitArmorClassTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.alliedUnitArmorClassTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alliedUnitArmorClassTextbox.Enabled = false;
            this.alliedUnitArmorClassTextbox.ForeColor = System.Drawing.Color.White;
            this.alliedUnitArmorClassTextbox.Location = new System.Drawing.Point(138, 120);
            this.alliedUnitArmorClassTextbox.Name = "alliedUnitArmorClassTextbox";
            this.alliedUnitArmorClassTextbox.Size = new System.Drawing.Size(72, 20);
            this.alliedUnitArmorClassTextbox.TabIndex = 20;
            this.alliedUnitArmorClassTextbox.TabStop = false;
            // 
            // armorClassLabel
            // 
            this.armorClassLabel.AutoSize = true;
            this.armorClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.armorClassLabel.Location = new System.Drawing.Point(10, 120);
            this.armorClassLabel.Name = "armorClassLabel";
            this.armorClassLabel.Size = new System.Drawing.Size(84, 17);
            this.armorClassLabel.TabIndex = 19;
            this.armorClassLabel.Text = "Armor Class";
            // 
            // enemyUnitDamageModifierTextbox
            // 
            this.enemyUnitDamageModifierTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.enemyUnitDamageModifierTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyUnitDamageModifierTextbox.Enabled = false;
            this.enemyUnitDamageModifierTextbox.ForeColor = System.Drawing.Color.White;
            this.enemyUnitDamageModifierTextbox.Location = new System.Drawing.Point(242, 150);
            this.enemyUnitDamageModifierTextbox.Name = "enemyUnitDamageModifierTextbox";
            this.enemyUnitDamageModifierTextbox.Size = new System.Drawing.Size(72, 20);
            this.enemyUnitDamageModifierTextbox.TabIndex = 24;
            this.enemyUnitDamageModifierTextbox.TabStop = false;
            // 
            // alliedUnitDamageModifierTextbox
            // 
            this.alliedUnitDamageModifierTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.alliedUnitDamageModifierTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alliedUnitDamageModifierTextbox.Enabled = false;
            this.alliedUnitDamageModifierTextbox.ForeColor = System.Drawing.Color.White;
            this.alliedUnitDamageModifierTextbox.Location = new System.Drawing.Point(138, 150);
            this.alliedUnitDamageModifierTextbox.Name = "alliedUnitDamageModifierTextbox";
            this.alliedUnitDamageModifierTextbox.Size = new System.Drawing.Size(72, 20);
            this.alliedUnitDamageModifierTextbox.TabIndex = 23;
            this.alliedUnitDamageModifierTextbox.TabStop = false;
            // 
            // damageModifierLabel
            // 
            this.damageModifierLabel.AutoSize = true;
            this.damageModifierLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.damageModifierLabel.Location = new System.Drawing.Point(10, 150);
            this.damageModifierLabel.Name = "damageModifierLabel";
            this.damageModifierLabel.Size = new System.Drawing.Size(119, 17);
            this.damageModifierLabel.TabIndex = 22;
            this.damageModifierLabel.Text = "Damage Modifier:";
            // 
            // enemyUnitToHitTextbox
            // 
            this.enemyUnitToHitTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.enemyUnitToHitTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.enemyUnitToHitTextbox.Enabled = false;
            this.enemyUnitToHitTextbox.ForeColor = System.Drawing.Color.White;
            this.enemyUnitToHitTextbox.Location = new System.Drawing.Point(242, 180);
            this.enemyUnitToHitTextbox.Name = "enemyUnitToHitTextbox";
            this.enemyUnitToHitTextbox.Size = new System.Drawing.Size(72, 20);
            this.enemyUnitToHitTextbox.TabIndex = 27;
            this.enemyUnitToHitTextbox.TabStop = false;
            // 
            // alliedUnitToHitTextbox
            // 
            this.alliedUnitToHitTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.alliedUnitToHitTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alliedUnitToHitTextbox.Enabled = false;
            this.alliedUnitToHitTextbox.ForeColor = System.Drawing.Color.White;
            this.alliedUnitToHitTextbox.Location = new System.Drawing.Point(138, 180);
            this.alliedUnitToHitTextbox.Name = "alliedUnitToHitTextbox";
            this.alliedUnitToHitTextbox.Size = new System.Drawing.Size(72, 20);
            this.alliedUnitToHitTextbox.TabIndex = 26;
            this.alliedUnitToHitTextbox.TabStop = false;
            // 
            // toHitLabel
            // 
            this.toHitLabel.AutoSize = true;
            this.toHitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.toHitLabel.Location = new System.Drawing.Point(10, 180);
            this.toHitLabel.Name = "toHitLabel";
            this.toHitLabel.Size = new System.Drawing.Size(94, 17);
            this.toHitLabel.TabIndex = 25;
            this.toHitLabel.Text = "To Hit Bonus:";
            // 
            // closeButton
            // 
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(135, 208);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 28;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BattleResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(331, 243);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.enemyUnitToHitTextbox);
            this.Controls.Add(this.alliedUnitToHitTextbox);
            this.Controls.Add(this.toHitLabel);
            this.Controls.Add(this.enemyUnitDamageModifierTextbox);
            this.Controls.Add(this.alliedUnitDamageModifierTextbox);
            this.Controls.Add(this.damageModifierLabel);
            this.Controls.Add(this.enemyUnitArmorClassTextbox);
            this.Controls.Add(this.alliedUnitArmorClassTextbox);
            this.Controls.Add(this.armorClassLabel);
            this.Controls.Add(this.enemyUnitDamageDieTextbox);
            this.Controls.Add(this.alliedUnitDamageDieTextbox);
            this.Controls.Add(this.damageDieLabel);
            this.Controls.Add(this.enemyUnitDamageTextbox);
            this.Controls.Add(this.alliedUnitDamageTextbox);
            this.Controls.Add(this.enemyUnitAttackRoll);
            this.Controls.Add(this.alliedUnitAttackRoll);
            this.Controls.Add(this.attackRollLabel);
            this.Controls.Add(this.damageLabel);
            this.Controls.Add(this.enemyUnitLabel);
            this.Controls.Add(this.alliedUnitLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BattleResult";
            this.Text = "BattleResult";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label alliedUnitLabel;
        private System.Windows.Forms.Label enemyUnitLabel;
        private System.Windows.Forms.Label damageLabel;
        private System.Windows.Forms.Label attackRollLabel;
        private System.Windows.Forms.TextBox alliedUnitAttackRoll;
        private System.Windows.Forms.TextBox enemyUnitAttackRoll;
        private System.Windows.Forms.TextBox enemyUnitDamageTextbox;
        private System.Windows.Forms.TextBox alliedUnitDamageTextbox;
        private System.Windows.Forms.TextBox enemyUnitDamageDieTextbox;
        private System.Windows.Forms.TextBox alliedUnitDamageDieTextbox;
        private System.Windows.Forms.Label damageDieLabel;
        private System.Windows.Forms.TextBox enemyUnitArmorClassTextbox;
        private System.Windows.Forms.TextBox alliedUnitArmorClassTextbox;
        private System.Windows.Forms.Label armorClassLabel;
        private System.Windows.Forms.TextBox enemyUnitDamageModifierTextbox;
        private System.Windows.Forms.TextBox alliedUnitDamageModifierTextbox;
        private System.Windows.Forms.Label damageModifierLabel;
        private System.Windows.Forms.TextBox enemyUnitToHitTextbox;
        private System.Windows.Forms.TextBox alliedUnitToHitTextbox;
        private System.Windows.Forms.Label toHitLabel;
        private System.Windows.Forms.Button closeButton;
    }
}