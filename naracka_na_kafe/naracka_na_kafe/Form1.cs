using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace naracka_na_kafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            numIce.Text = "0";
            numFreddo.Text = "0";
            numCoffee.Text = "0";
            numNestle.Text = "0";
            numIrish.Text = "0";
            numStrawberry.Text = "0";
            numCream.Text = "0";
            numEspresso.Text = "0";
            numHot.Text = "0";
            numCappuccino.Text = "0";
            numVanilla.Text = "0";
            numNutella.Text = "0";
            numMacchiato.Text = "0";
            numRum.Text = "0";
            numChocolate.Text = "0";
            numNescafe.Text = "0";
            lblDrinks.Text = "0";
            lblCakes.Text = "0";
            lblService.Text = "5";
            
            lblTotal.Text = "0";

            chkIce.Checked = false;
            chkFreddo.Checked = false;
            chkCoffee.Checked = false;
            chkMacchiato.Checked = false;
            chkEspresso.Checked = false;
            chkCappuccino.Checked = false;
            chkNescafe.Checked = false;
            chkIrish.Checked = false;
            chkNestle.Checked = false;
            chkNutella.Checked = false;
            chkVanilla.Checked = false;
            chkStrawberry.Checked = false;
            chkRum.Checked = false;
            chkCream.Checked = false;
            chkChocolate.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToLongDateString();
            timer1.Start();


            numIce.Text = "0";
            numFreddo.Text = "0";
            numCoffee.Text = "0";
            numNestle.Text = "0";
            numIrish.Text = "0";
            numStrawberry.Text = "0";
            numCream.Text = "0";
            numEspresso.Text = "0";
            numHot.Text = "0";
            numCappuccino.Text = "0";
            numVanilla.Text = "0";
            numNutella.Text = "0";
            numMacchiato.Text = "0";
            numRum.Text = "0";
            numChocolate.Text = "0";
            numNescafe.Text = "0";
            lblDrinks.Text = "0";
            lblCakes.Text = "0";
            lblService.Text = "2";

            numMacchiato.Enabled = false;
            numEspresso.Enabled = false;
            numCappuccino.Enabled = false;
            numNescafe.Enabled = false;
            numIrish.Enabled = false;
            numIce.Enabled = false;
            numFreddo.Enabled = false;
            numHot.Enabled = false;
            numCream.Enabled = false;
            numChocolate.Enabled = false;
            numCoffee.Enabled = false;
            numNestle.Enabled = false;
            numNutella.Enabled = false;
            numVanilla.Enabled = false;
            numStrawberry.Enabled = false;
            numRum.Enabled = false;


            chkIce.Checked = false;
            chkFreddo.Checked = false;
            chkCoffee.Checked = false;
            chkMacchiato.Checked = false;
            chkEspresso.Checked = false;
            chkCappuccino.Checked = false;
            chkNescafe.Checked = false;
            chkIrish.Checked = false;
            chkNestle.Checked = false;
            chkNutella.Checked = false;
            chkVanilla.Checked = false;
            chkStrawberry.Checked = false;
            chkRum.Checked = false;
            chkCream.Checked = false;
            chkChocolate.Checked = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkMacchiato_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMacchiato.Checked == true)
            {
                numMacchiato.Enabled = true;

            }

            if (chkMacchiato.Checked == false)
            {

                numMacchiato.Enabled = false;
                numMacchiato.Text = "0";
            }

        }

        private void numMacchiato_Click(object sender, EventArgs e)
        {
            numMacchiato.Text = "";
            numMacchiato.Focus();
        }



        private void chkCappuccino_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkCappuccino.Checked == true)
            {
                numCappuccino.Enabled = true;
            }
            if (chkCappuccino.Checked == false)
            {
                numCappuccino.Enabled = false;
                numCappuccino.Text = "0";
            }
        }

        private void numCappuccino_Click(object sender, EventArgs e)
        {
            numCappuccino.Text = "";
            numCappuccino.Focus();
        }

        private void chkNescafe_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNescafe.Checked == true)
            {
                numNescafe.Enabled = true;
            }
            if (chkNescafe.Checked == false)
            {
                numNescafe.Enabled = false;
                numNescafe.Text = "0";
            }
        }

        private void numNescafe_Click(object sender, EventArgs e)
        {
            numNescafe.Text = "";
            numNescafe.Focus();
        }

        private void chkIrish_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIrish.Checked == true)
            {
                numIrish.Enabled = true;
            }
            if (chkIrish.Checked == false)
            {
                numIrish.Enabled = false;
                numIrish.Text = "0";
            }
        }

        private void numIrish_Click(object sender, EventArgs e)
        {
            numIrish.Text = "";
            numIrish.Focus();
        }

        private void chkIce_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIce.Checked == true)
            {
                numIce.Enabled = true;
            }
            if (chkIce.Checked == false)
            {
                numIce.Enabled = false;
                numIce.Text = "0";
            }
        }

        private void numIce_Click(object sender, EventArgs e)
        {
            numIce.Text = "";
            numIce.Focus();
        }

        private void chkFreddo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFreddo.Checked == true)
            {
                numFreddo.Enabled = true;
            }
            if (chkFreddo.Checked == false)
            {
                numFreddo.Enabled = false;
                numFreddo.Text = "0";
            }
        }

        private void numFreddo_Click(object sender, EventArgs e)
        {
            numFreddo.Text = "";
            numFreddo.Focus();
        }

        private void chkHot_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHot.Checked == true)
            {
                numHot.Enabled = true;
            }
            if (chkHot.Checked == false)
            {
                numHot.Enabled = false;
                numHot.Text = "0";
            }
        }

        private void numHot_Click(object sender, EventArgs e)
        {
            numHot.Text = "";
            numHot.Focus();
        }

        private void chkCream_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCream.Checked == true)
            {
                numCream.Enabled = true;
            }
            if (chkCream.Checked == false)
            {
                numCream.Enabled = false;
                numCream.Text = "0";

            }
        }

        private void numCream_Click(object sender, EventArgs e)
        {
            numCream.Text = "";
            numCream.Focus();
        }

        private void chkChocolate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChocolate.Checked == true)
            {
                numChocolate.Enabled = true;
            }
            if (chkChocolate.Checked == false)
            {
                numChocolate.Enabled = false;
                numChocolate.Text = "0";

            }

        }

        private void numChocolate_Click(object sender, EventArgs e)
        {
            numChocolate.Text = "";
            numChocolate.Focus();

        }

        private void chkCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCoffee.Checked == true)
            {
                numCoffee.Enabled = true;
            }
            if (chkCoffee.Checked == false)
            {
                numCoffee.Enabled = false;
                numCoffee.Text = "0";
            }
        }

        private void numCoffee_Click(object sender, EventArgs e)
        {
            numCoffee.Text = "";
            numCoffee.Focus();
        }

        private void chkNestle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNestle.Checked == true)
            {
                numNestle.Enabled = true;
            }
            if (chkNestle.Checked == false)
            {
                numNestle.Enabled = false;
                numNestle.Text = "0";
            }
        }

        private void numNestle_Click(object sender, EventArgs e)
        {
            numNestle.Text = "";
            numNestle.Focus();
        }

        private void chkNutella_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNutella.Checked == true)
            {
                numNutella.Enabled = true;
            }
            if (chkNutella.Checked == false)
            {
                numNutella.Enabled = false;
                numNutella.Text = "0";
            }
        }

        private void numNutella_Click(object sender, EventArgs e)
        {
            numNutella.Text = "";
            numNutella.Focus();
        }

        private void chkVanilla_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVanilla.Checked == true)
            {
                numVanilla.Enabled = true;
            }
            if (chkVanilla.Checked == false)
            {
                numVanilla.Enabled = false;
                numVanilla.Text = "0";
            }
        }

        private void numVanilla_Click(object sender, EventArgs e)
        {
            numVanilla.Text = "";
            numVanilla.Focus();

        }

        private void chkStrawberry_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStrawberry.Checked == true)
            {
                numStrawberry.Enabled = true;
            }
            if (chkStrawberry.Checked == false)
            {
                numStrawberry.Enabled = false;
                numStrawberry.Text = "0";
            }
        }

        private void numStrawberry_Click(object sender, EventArgs e)
        {
            numStrawberry.Text = "";
            numStrawberry.Focus();
        }

        private void chkRum_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRum.Checked == true)
            {
                numRum.Enabled = true;
            }
            if (chkRum.Checked == false)
            {
                numRum.Enabled = false;
                numRum.Text = "0";
            }
        }

        private void numRum_Click(object sender, EventArgs e)
        {
            numRum.Text = "";
            numRum.Focus();
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            rtlReceipt.Clear();
           
            rtlReceipt.AppendText("\t\t" + "COFFEE AND CAKES SHOP" + Environment.NewLine);
            rtlReceipt.AppendText("*************************************************************************" + Environment.NewLine + Environment.NewLine);
            rtlReceipt.AppendText("Macchiato \t\t\t" + numMacchiato.Text + Environment.NewLine);
            rtlReceipt.AppendText("Espresso \t\t\t\t" + numEspresso.Text + Environment.NewLine);
            rtlReceipt.AppendText("Cappuccino \t\t\t" + numCappuccino.Text + Environment.NewLine);
            rtlReceipt.AppendText("Nescafe \t\t\t\t" + numNescafe.Text + Environment.NewLine);
            rtlReceipt.AppendText("Irish Coffee \t\t\t" + numIrish.Text + Environment.NewLine);
            rtlReceipt.AppendText("Ice Coffee \t\t\t" + numIce.Text + Environment.NewLine);
            rtlReceipt.AppendText("Espresso Freddo \t\t\t" + numFreddo.Text + Environment.NewLine);
            rtlReceipt.AppendText("Hot Chocolate \t\t\t" + numHot.Text + Environment.NewLine);
            rtlReceipt.AppendText("--------------------------------------------------------------------------------" + Environment.NewLine + Environment.NewLine);
            rtlReceipt.AppendText("Cream Cake \t\t\t" + numCream.Text + Environment.NewLine);
            rtlReceipt.AppendText("Chocolate Cake \t\t\t" + numChocolate.Text + Environment.NewLine);
            rtlReceipt.AppendText("Coffee Cake \t\t\t" + numCoffee.Text + Environment.NewLine);
            rtlReceipt.AppendText("Nestle Cake \t\t\t" + numNestle.Text + Environment.NewLine);
            rtlReceipt.AppendText("Nutella Cake \t\t\t" + numNutella.Text + Environment.NewLine);
            rtlReceipt.AppendText("Vanilla cake \t\t\t" + numVanilla.Text + Environment.NewLine);
            rtlReceipt.AppendText("Strawberry Cake \t\t\t" + numStrawberry.Text + Environment.NewLine);
            rtlReceipt.AppendText("Rum Cake \t\t\t" + numRum.Text + Environment.NewLine);
            rtlReceipt.AppendText("---------------------------------------------------------------------------------" + Environment.NewLine);
            
            
            rtlReceipt.AppendText("Total Cost \t\t\t" + lblTotal.Text + Environment.NewLine);
            rtlReceipt.AppendText("---------------------------------------------------------------------------------" + Environment.NewLine);
            rtlReceipt.AppendText(lblTime.Text + "\t\t" + lblDate.Text);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtlReceipt.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, 120, 120);
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            rtlReceipt.Clear();
        }

        private void cutToolStripButton_Click(object sender, EventArgs e)
        {
            rtlReceipt.Cut();

        }

        private void copyToolStripButton_Click(object sender, EventArgs e)
        {
            rtlReceipt.Copy();
        }

        private void pasteToolStripButton_Click(object sender, EventArgs e)
        {
            rtlReceipt.Paste();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            //this code will open text files

            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                rtlReceipt.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            //this code will save text files

            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = "Notepad text";

            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All files(*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName))
                    sw.WriteLine(rtlReceipt.Text);
            }
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            
            double macchiato, espres, capp, nescafe, iCaffe, icCaffe, eFreddo, hotC;  
            double cream, cCake, coffee, nestle, nutella, vanilla, strawberry, rum;

            //coffee
            macchiato = 50; espres = 60; capp = 80; nescafe = 80; iCaffe = 100; icCaffe = 80; eFreddo = 80; hotC = 90;
            double macchiato_Coff = Convert.ToDouble(numMacchiato.Text);
            double espres_Coff = Convert.ToDouble(numEspresso.Text);
            double capp_Coff = Convert.ToDouble(numCappuccino.Text);
            double nes = Convert.ToDouble(numNescafe.Text);
            double ice = Convert.ToDouble(numIce.Text);
            double irish_Coff = Convert.ToDouble(numIrish.Text);
            double freddo = Convert.ToDouble(numFreddo.Text);
            double hot = Convert.ToDouble(numHot.Text);

            //cakes
            cream = 60; cCake = 70; coffee = 50; nestle = 80; nutella = 90; vanilla = 60; strawberry = 50; rum = 70;
            double cream_c = Convert.ToDouble(numCream.Text);
            double chocolate = Convert.ToDouble(numChocolate.Text);
            double coffee_cake = Convert.ToDouble(numCoffee.Text);
            double nestle_c = Convert.ToDouble(numNestle.Text);
            double nutella_c = Convert.ToDouble(numNutella.Text);
            double vanilla_c = Convert.ToDouble(numVanilla.Text);
            double starw = Convert.ToDouble(numStrawberry.Text);
            double rum_c = Convert.ToDouble(numRum.Text);


            Cafe eat_in_cafe = new Cafe(macchiato_Coff, espres_Coff, capp_Coff, nes, ice, irish_Coff, freddo, hot,
                cream_c, chocolate, coffee_cake, nestle_c, nutella_c, vanilla_c, starw, rum_c);

            double cost_of_drinks = (macchiato_Coff * macchiato) + (espres_Coff * espres) + (capp_Coff * capp) + (nes * nescafe)
                + (ice * icCaffe) + (irish_Coff * iCaffe) + (freddo * eFreddo) + (hot * hotC);
            lblDrinks.Text = Convert.ToString(cost_of_drinks);


            double cost_of_cakes = (cream_c * cream) + (chocolate * cCake) + (coffee_cake * coffee) + (nestle_c * nestle) + (nutella_c * nutella)
                + (vanilla_c * vanilla) + (starw * strawberry) + (rum_c * rum);
            lblCakes.Text = Convert.ToString(cost_of_cakes);

            double service_charge = Convert.ToDouble(lblService.Text);
            


            
            
            
            lblTotal.Text = Convert.ToString(cost_of_cakes + cost_of_drinks + service_charge);

            lblCakes.Text = String.Format("{0:N0}", cost_of_cakes);
            lblDrinks.Text = String.Format( "{0:N0}", cost_of_drinks);
            lblService.Text = String.Format( "{0:N0}", service_charge);
            
           
            lblTotal.Text = String.Format("{0:N0}", cost_of_cakes + cost_of_drinks + service_charge);

                
        }

        private void chkEspresso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEspresso.Checked == true)
            {
                numEspresso.Enabled = true;
            }
            if (chkEspresso.Checked == false)
            {
                numEspresso.Enabled = false;
                numEspresso.Text = "0";
            }
        }

        private void numEspresso_Click(object sender, EventArgs e)
        {
            numEspresso.Text = "";
            numEspresso.Focus();
        }

     

       

       

        
       
        

      
        
       
    }
}
    