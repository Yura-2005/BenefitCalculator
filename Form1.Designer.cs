namespace BenefitCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblFamilyMembers;
        private System.Windows.Forms.TextBox txtFamilyMembers;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblElectricity;
        private System.Windows.Forms.TextBox txtElectricity;
        private System.Windows.Forms.Label lblGas;
        private System.Windows.Forms.TextBox txtGas;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.TextBox txtWater;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblResult;

        private void InitializeComponent()
        {
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblFamilyMembers = new System.Windows.Forms.Label();
            this.txtFamilyMembers = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblElectricity = new System.Windows.Forms.Label();
            this.txtElectricity = new System.Windows.Forms.TextBox();
            this.lblGas = new System.Windows.Forms.Label();
            this.txtGas = new System.Windows.Forms.TextBox();
            this.lblWater = new System.Windows.Forms.Label();
            this.txtWater = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblCategory
            this.lblCategory.Text = "Категорія пільговика:";
            this.lblCategory.Location = new System.Drawing.Point(10, 10);
            this.lblCategory.AutoSize = true;

            // cmbCategory
            this.cmbCategory.Items.AddRange(new object[] { "Одинокий інвалід", "Особа з інвалідністю (50%)", "Ветеран УПА (75%)" });
            this.cmbCategory.Location = new System.Drawing.Point(200, 10);

            // lblFamilyMembers
            this.lblFamilyMembers.Text = "Кількість членів сім'ї:";
            this.lblFamilyMembers.Location = new System.Drawing.Point(10, 40);
            this.txtFamilyMembers.Location = new System.Drawing.Point(200, 40);
            this.lblFamilyMembers.AutoSize = true;

            // lblArea
            this.lblArea.Text = "Площа житла (м²):";
            this.lblArea.Location = new System.Drawing.Point(10, 70);
            this.txtArea.Location = new System.Drawing.Point(200, 70);
            this.lblArea.AutoSize = true;

            // lblElectricity
            this.lblElectricity.Text = "Витрати електроенергії (кВт):";
            this.lblElectricity.Location = new System.Drawing.Point(10, 100);
            this.txtElectricity.Location = new System.Drawing.Point(200, 100);
            this.lblElectricity.AutoSize = true;

            // lblGas
            this.lblGas.Text = "Витрати газу (м³):";
            this.lblGas.Location = new System.Drawing.Point(10, 130);
            this.txtGas.Location = new System.Drawing.Point(200, 130);
            this.lblGas.AutoSize = true;

            // lblWater
            this.lblWater.Text = "Витрати води (м³):";
            this.lblWater.Location = new System.Drawing.Point(10, 160);
            this.txtWater.Location = new System.Drawing.Point(200, 160);
            this.lblWater.AutoSize = true;

            // btnCalculate
            this.btnCalculate.Text = "Розрахувати";
            this.btnCalculate.Location = new System.Drawing.Point(10, 200);
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // btnClear
            this.btnClear.Text = "Очистити";
            this.btnClear.Location = new System.Drawing.Point(150, 200);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // lblResult
            this.lblResult.Location = new System.Drawing.Point(10, 240);
            this.lblResult.Size = new System.Drawing.Size(280, 30);

            // Form1
            this.ClientSize = new System.Drawing.Size(350,300);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblFamilyMembers);
            this.Controls.Add(this.txtFamilyMembers);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.lblElectricity);
            this.Controls.Add(this.txtElectricity);
            this.Controls.Add(this.lblGas);
            this.Controls.Add(this.txtGas);
            this.Controls.Add(this.lblWater);
            this.Controls.Add(this.txtWater);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblResult);
            this.Text = "Розрахунок пільг";
            this.ResumeLayout(false);
        }
    }
}
