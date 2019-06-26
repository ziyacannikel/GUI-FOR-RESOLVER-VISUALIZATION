using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class UserControl1 : UserControl
    {
       
        public UserControl1()
        {


            InitializeComponent();
            label1.Text = "10";
            label2.Text = "10";
            label3.Text = "10";
            label4.Text = "400";

            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;
            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;
            chart.AxisX.Minimum = 0;
            chart.AxisX.Maximum = 10;
            chart.AxisY.Minimum = -14;
            chart.AxisY.Maximum = 14;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 2;
            chart.AxisX.IsMarginVisible = false;
            chart.BackColor = Color.Black;
            chart.AxisX.MajorGrid.LineColor = Color.DarkKhaki;
            chart.AxisY.MajorGrid.LineColor = Color.DarkKhaki;
            chart.AxisX.LineColor= Color.DarkKhaki;
            chart.AxisX2.LineColor = Color.DarkKhaki;
            chart.AxisY.LineColor= Color.DarkKhaki;
            chart.AxisY2.LineColor = Color.DarkKhaki;
            chart1.Titles.Add("RESOLVER SIGNALS");


            sin_graph(278, 7, "Cos");
            sin_graph(278, 7, "Sin");
            sin_graph(278, 9, "Ref");




        }

        private void UserControl1_Load(object sender, EventArgs e)
        {


        }

        public void sin_graph(int frekans,double tepe,string name)
        {



            for(int j = 0; j < 1; j++) { //en aşağı kadar gidiyor (aşağıda break var onun için döngü )
            if(graph_control(name)==false)
                {
                    break;
                }
            foreach (var series in chart1.Series)
            {
                chart1.Series[name].Points.Clear();
                
            }

            if (frekans < 100 || frekans>2500)
            {
                frekans = 100;
            }

            if(tepe<0 || tepe > 14)
            {
                tepe = 5;
            }

            double artıs = (Math.PI * 2)/(50 / (frekans / 120));
            double kontrol=0;
            double y_point ;
            if(name!= "Cos")
            {
                for (float i = 0F; i < 10; i += 0.2F)
                {
                    y_point = (Math.Sin(kontrol) * tepe);
                    chart1.Series[name].Points.AddXY(i, y_point);
                    kontrol = kontrol + artıs;
                }
            }
            else
            {
                kontrol = Math.PI / 2;
                for (float i = 0F; i < 10; i += 0.2F)
                {
                    y_point = (Math.Sin(kontrol) * tepe);
                    chart1.Series[name].Points.AddXY(i, y_point);
                    kontrol = kontrol + artıs;
                }
            }


            }///en büyük for için 

        }
        public void graph_adjust()
        {
          
            
            if (checkBox1.CheckState == CheckState.Checked)
            {
                sin_graph(Convert.ToInt16(label4.Text), Convert.ToDouble(label1.Text)/2, "Ref");
            }
            else
            {
                foreach (var series in chart1.Series)
                {
                   chart1.Series["Ref"].Points.Clear();

                }
            }
            if (checkBox2.CheckState == CheckState.Checked)
            {
                sin_graph(Convert.ToInt16(label4.Text), Convert.ToDouble(label2.Text)/2, "Sin");
            }
            else
            {
                foreach (var series in chart1.Series)
                {
                    chart1.Series["Sin"].Points.Clear();

                }
            }
            if (checkBox3.CheckState == CheckState.Checked)
            {
                sin_graph(Convert.ToInt16(label4.Text), Convert.ToDouble(label3.Text)/2, "Cos");
            }
            else
            {
                foreach (var series in chart1.Series)
                {
                    chart1.Series["Cos"].Points.Clear();

                }
            }


        }

        private  Boolean graph_control(string name)
        {
            Boolean onay = false;
            if (name == "Ref")
            {
                if (checkBox1.CheckState == CheckState.Checked)
                {
                    onay = true;
                }
                else
                {
                    onay = false;
                }
            }

            else if (name == "Sin")
            {
                if (checkBox2.CheckState == CheckState.Checked)
                {
                    onay = true;
                }
                else
                {
                    onay = false;
                }
            }
            else
            {
                if (checkBox3.CheckState == CheckState.Checked)
                {
                    onay = true;
                }
                else
                {
                    onay = false;
                }
            }
            
            return onay;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            graph_adjust();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            graph_adjust();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            graph_adjust();
        }
    }
}
