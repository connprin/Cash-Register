using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Cash_Register
{
    public partial class Form1 : Form
    {
        //global variables
        double OnePounder = 6.25;
        double Milkshake = 1.99;
        double Quadruple = 3.50;
        double tax = 0.13;

        double OnePounderAmount;
        double MilkshakeAmount;
        double QuadrupleAmount;

        double cost;
        double taxcost;
        double totalcost;

        double tendered;
        double change;


        public Form1()
        {
            InitializeComponent();
        }

        private void LabelQuadruple_Click(object sender, EventArgs e)
        {

        }

        private void LabelOnePounder_Click(object sender, EventArgs e)
        {

        }

        private void LabelTax_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            labelErrorMessage.Visible = false;
            //calculate subtotal, tax, total
            try
            {
                labelSubtotal.Visible = true;
                labelTax.Visible = true;
                labelTotal.Visible = true;


                OnePounderAmount = Convert.ToInt32(textOnePounder.Text);
                MilkshakeAmount = Convert.ToInt32(textMilkshake.Text);
                QuadrupleAmount = Convert.ToInt32(textQuadruple.Text);
                double Quadrupletotal = Quadruple * QuadrupleAmount;
                double Milkshaketotal = Milkshake * MilkshakeAmount;
                double Onepoundertotal = OnePounder * OnePounderAmount;
                double cost = Onepoundertotal + Milkshaketotal + Quadrupletotal;
                double taxcost = cost * tax;
                double totalcost = taxcost + cost;

                labelSubtotal.Text = $" {cost.ToString("$0.00")}";
                labelTax.Text = $" {taxcost.ToString("$0.00")}";
                labelTotal.Text = $" {totalcost.ToString("$0.00")}";


            }
            catch
            {
                labelErrorMessage.Text = $"Please input numbers.";
                labelErrorMessage.Visible = true;
                
            }

        }

        private void LabelSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCalculateChange_Click(object sender, EventArgs e)
        {
            //calculate change
            try
            {
                labelChange.Visible = true;

                OnePounderAmount = Convert.ToInt32(textOnePounder.Text);
                MilkshakeAmount = Convert.ToInt32(textMilkshake.Text);
                QuadrupleAmount = Convert.ToInt32(textQuadruple.Text);
                double Quadrupletotal = Quadruple * QuadrupleAmount;
                double Milkshaketotal = Milkshake * MilkshakeAmount;
                double Onepoundertotal = OnePounder * OnePounderAmount;
                double cost = Onepoundertotal + Milkshaketotal + Quadrupletotal;
                double taxcost = cost * tax;
                double totalcost = taxcost + cost;
                double tendered;
                tendered = Convert.ToDouble(textTendered.Text);
                double change = tendered - totalcost;
                labelChange.Text = $" {change.ToString("$0.00")}";
            }
            catch
            { //error message when non numeric values are put in
                labelErrorMessage.Text = $"Please input numbers.";
                
            }
        }


           

        private void ButtonReceipt_Click(object sender, EventArgs e)
        {
            //print receipt
            OnePounderAmount = Convert.ToInt32(textOnePounder.Text);
            MilkshakeAmount = Convert.ToInt32(textMilkshake.Text);
            QuadrupleAmount = Convert.ToInt32(textQuadruple.Text);
            double Quadrupletotal = Quadruple * QuadrupleAmount;
            double Milkshaketotal = Milkshake * MilkshakeAmount;
            double Onepoundertotal = OnePounder * OnePounderAmount;
            double cost = Onepoundertotal + Milkshaketotal + Quadrupletotal;
            double taxcost = cost * tax;
            double totalcost = taxcost + cost;
            double tendered;
            tendered = Convert.ToDouble(textTendered.Text);
            double change = tendered - totalcost;

            //receipt
            SoundPlayer Player = new SoundPlayer(Properties.Resources.receiptMachine);
            Player.Play();
            labelReceiptTitle.Text = $"Burgville";
            labelReceiptTitle.Visible = true;
            Thread.Sleep(250);
            Player.Stop();
            Refresh();
            Player.Play();
            labelOrderNumber.Text = $"Order Number 100";
            labelOrderNumber.Visible = true;
            Thread.Sleep(250);
            Player.Stop();
            Refresh();
            Player.Play();
            labelReceiptDate.Text = $"January 20,2021";
            labelReceiptDate.Visible = true;
            Thread.Sleep(500);
            Player.Stop();
            Refresh();
            Player.Play();
            labelQuadrupleReceipt.Text = $"Quadruple Patty Burger           x{QuadrupleAmount}  {Quadrupletotal.ToString("$0.00")}";
            labelQuadrupleReceipt.Visible = true;
            Thread.Sleep(500);
            Player.Stop();
            Refresh();
            Player.Play();
            labelOnepounderReceipt.Text = $"The One Pounder                   x{OnePounderAmount}  {Onepoundertotal.ToString("$0.00")}";
            labelOnepounderReceipt.Visible = true;
            Thread.Sleep(500);
            Player.Stop();
            Refresh();
            Player.Play();
            labelMilkshakeReceipt.Text = $"Milkshake                               x{MilkshakeAmount}  {Milkshaketotal.ToString("$0.00")}";
            labelMilkshakeReceipt.Visible = true;
            Thread.Sleep(500);
            Player.Stop();
            Refresh();
            Player.Play();
            labelSubtotalReceipt.Text = $"Subtotal                                      {cost.ToString("$0.00")}";
            labelSubtotalReceipt.Visible = true;
            Thread.Sleep(500);
            Player.Stop();
            Refresh();
            Player.Play();
            labelTaxReceipt.Text = $"Tax                                               {taxcost.ToString("$0.00")}";
            labelTaxReceipt.Visible = true;
            Thread.Sleep(500);
            Player.Stop();
            Refresh();
            Player.Play();
            labelTotalReceipt.Text = $"Total                                            {totalcost.ToString("$0.00")}";
            labelTotalReceipt.Visible = true;
            Thread.Sleep(500);
            Player.Stop();
            Refresh();
            Player.Play();
            labelTenderedReceipt.Text = $"Tendered                                      {tendered.ToString("$0.00")}";
            labelTenderedReceipt.Visible = true;
            Thread.Sleep(500);
            Player.Stop();
            Refresh();
            Player.Play();
            labelChangeReceipt.Text = $"Change                                          {change.ToString("$0.00")}";
            labelChangeReceipt.Visible = true; 
            Thread.Sleep(500);
            Player.Stop();
            Refresh();
            Player.Play();
            labelGoodbye.Text = $"Thank you, have a nice day!";
            labelGoodbye.Visible = true;
            Thread.Sleep(500);
            Player.Stop();
            Refresh();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonReset_Click(object sender, EventArgs e)
        { //reset button (new order)

            labelReceiptTitle.Visible = false;
            labelOrderNumber.Visible = false;
            labelReceiptDate.Visible = false;
            labelQuadrupleReceipt.Visible = false;
            labelOnepounderReceipt.Visible = false;
            labelMilkshakeReceipt.Visible = false;
            labelSubtotalReceipt.Visible = false;
            labelTaxReceipt.Visible = false;
            labelTotalReceipt.Visible = false;
            labelTenderedReceipt.Visible = false;
            labelChangeReceipt.Visible = false;
            labelSubtotal.Visible = false;
            labelTax.Visible = false;
            labelTotal.Visible = false;
            labelChange.Visible = false;
            labelGoodbye.Visible = false;
        }

        private void LabelErrorMessage_Click(object sender, EventArgs e)
        {
            
        }

        private void LabelGoodbye_Click(object sender, EventArgs e)
        {

        }
    }
}
           
            




