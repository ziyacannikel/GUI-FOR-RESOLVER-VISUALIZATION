using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public  string dataout;         //gönderilecek datat için
        public  int frequency=200;      //karşıdan gelecek
        private  float angle;            //gerçek zamanlı açı bilgisi
        private  double v_ref=10 ;       //default olarak değer bulunsun diye hataya engel olmak için
        private  double v_sin=10 ;       //default olarak değer bulunsun diye hataya engel olmak için
        private  double v_cos =10 ;      //default olarak değer bulunsun diye hataya engel olmak için

        Boolean kontrol = true;         //lüzumsuz yere grefik çizimine engel olmak için
        float eski_konum;               //grafik eski konumunu tutmak için

        Boolean menu_kontrol = false;   //doğru menüde değilken boş yere sin-cos çizmesin diye 

        Boolean graph_sin_kontrol = true;
        double graph_last_sin;

        Boolean graph_cos_kontrol = true;
        double graph_last_cos;

        Boolean graph_ref_kontrol = true;
        double graph_last_ref;

        Boolean graph_fre_kontrol = true;
        int graph_last_fre;


        public Form1()
        {
            InitializeComponent();
        }

        public double getValue(string name) //bu sınıftaki private değerleri diğer sınıfa alabilmek için
        {
            if (name == "v_ref")
            {
                return v_ref;
            }
            else if (name == "v_sin")
            {
                return v_sin;
            }
            else if (name == "v_cos")
            {
                return v_cos;
            }
            else
            {
                return 0;
            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            

            sidePanel.Height = button5.Height;              //home konumunda başlaması için (yandaki kırmızı çizgi)
            sidePanel.Top = button5.Top;                    //home konumunda başlaması için (yandaki kırmızı çizgi)
            userControl11.Hide();                           //başlangıçta grafik gözükmesin diye

            string[] ports = SerialPort.GetPortNames();     //aktif portların isimlerini al
            comboBox1.Items.AddRange(ports);                // combo boxa aktif portları ekle

            /// BAŞLANGIÇTA PORTLARI DOĞRUDAN ÇALIŞTIRIP BAĞLANMAK İÇİN COMBOBOX'A PORT İSMİNİ AL///
            try
            {
                comboBox1.Text = ports[0];  
            }
            catch
            {
                MessageBox.Show("There is no active COM port");
            }
            /////////////////////////////////////////////////////////////
            /// TRACK BAR AYARLARI İÇİN
            trackBar1.Minimum = 200;
            trackBar1.Maximum = 2000;
            trackBar1.TickFrequency = 100;
          
            trackBar2.Maximum = 24;
            trackBar2.Minimum = 4;

            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            /////////////////////////////////////////////////////////////
            /// AKTİF PORTU ÇALIŞTIRMAK İÇİN
            /// 
          
            if (!serialPort1.IsOpen)
            {
                try
                {
                    
                    button3_Click(sender, e);
                    label15.ForeColor = System.Drawing.Color.Green;
                    label15.Text = "ON";
                }
                catch  {   }

            }
            

            ////////////////////////////////////////////////////////////
        }
        ///FONKSİ
        ///YON VERİ GELDİĞİNDE (serialPort1_DataReceived) TARAFINDAN ÇAĞIRILIYOR  
        

        private void verial(object sender, EventArgs e) 
        {
             /*
             -)GELEN VERİ WRİTELİNE ŞEKLİNDE YAZILACAK
             -)GELEN VERİDE SAYININ BAŞINDA NE İLE ALAKLI OLDUĞUNU BELİRTECEK KARAKTERLER OLCAAK
             -)V=REFERANS SİNYALİ SEVİYESİ (Vpp)
             -)S=RESOLVER SİNÜS SARGISI SİNYALİ (Vpp)
             -)C=RESOLVER COSİNÜS SARGISI SİNYALİ (Vpp)
             -)F=SİNYAL FREKANSI (Hz)
             -)A=AÇI BİLGİSİ (DERECE)
             */
            
            string buffer =  serialPort1.ReadLine();      //VERİ GELDİĞİNDE İLK BUNUN İÇİNE GELİYOR
            buffer =buffer.Replace('.', ',');              //FAZLASIYLA MÜHİM KARŞIDAKİ DOUBLE FORMATI '.' BURDA ','
            int index = buffer.IndexOf("v");              //GELEN VERİDE "v" VARMI DİYE BAKIYOR(V=REFERANS VOLTAJI)
            if (index != -1)                              //YOKSA -1 DÖNDÜRÜYOR VARSA BAŞKA MUHABBETLERİ VAR 
            {
                buffer = buffer.Trim('v');                //V HARFİNİ KESİYOR
                v_ref = double.Parse(buffer);             //string -> double
                if (v_ref < 0 || v_ref > 26)
                { v_ref = 4; }
                label8.Text = v_ref.ToString();                     //ana formdaki uygulanan sinyal voltajını gösteriyor
                if (menu_kontrol)                         //default olarak false eğer user kontrol açılırsa true olur 
                {                                         //boşa grafik çizmemek için
                    userControl11.label1.Text = label8.Text;
                    userControl11.progressBar2.Value = (int)v_ref ;            //DİĞER SAYFADAKİ PROGRESS BARIN DEĞERİ
                    grafik_kontrol(frequency, v_ref , "Ref");

                    
                    
                    /*user control içinde public void fonksiyon grafik çizer voltaj (tepe-tepe)/2 girilmeli
                     içerde sinüsü bu katsayıyla çarpıyor*/

                }

            }


            index = buffer.IndexOf("s");
            if (index != -1)
            {
                buffer = buffer.Trim('s');
                v_sin = double.Parse(buffer);
                if (v_sin < 0 || v_sin > 26)
                { v_sin = 4; }
                if (menu_kontrol)
                {
                    userControl11.label2.Text = v_sin.ToString();
                    userControl11.progressBar3.Value = (int)v_sin ;
                    grafik_kontrol(frequency, v_sin, "Sin");
                }
                

            }

           
            /*FREKANS OLDUĞUNDA 3 TANE GRAFİKTE DEĞİŞMELİ O YÜZDEN HEPSİ VAR*/
            index = buffer.IndexOf("f");
            if (index != -1)
            {
                buffer = buffer.Trim('f');
                frequency = Int16.Parse(buffer);
                if (frequency > 2000 || frequency<200)
                {
                    frequency = 400;
                }
               

                label3.Text = frequency.ToString();
               
                if(menu_kontrol)
                {
                    userControl11.label4.Text = frequency.ToString();
                    userControl11.progressBar1.Value = frequency;

                    if (graph_fre_kontrol)
                    {
                        graph_last_fre = frequency - 9;
                        graph_fre_kontrol = false;
                    }
                    if (graph_last_fre + 10 < frequency || frequency + 10 < graph_last_fre)
                    {
                        graph_last_fre = frequency;
                        userControl11.sin_graph(frequency, v_ref / 2, "Ref");
                        userControl11.sin_graph(frequency, v_sin/ 2, "Sin");
                        userControl11.sin_graph(frequency, v_cos / 2, "Cos");
                    }
                 
                }

            }

            index = buffer.IndexOf("c");
            if (index != -1)
            {
                buffer = buffer.Trim('c');
                v_cos = double.Parse(buffer);
                if (v_cos < 0 || v_cos > 26)
                { v_cos = 4; }
                if (menu_kontrol)
                {
                    userControl11.label3.Text = v_cos.ToString();
                    userControl11.progressBar4.Value = (int)v_cos;
                    grafik_kontrol(frequency, v_cos, "Cos");
                }
            }

            index = buffer.IndexOf("a");
            if (index != -1)
            {
                buffer = buffer.Trim('a');
            
                angle = (float)(double.Parse(buffer));
                angle = angle % 360;
                if (kontrol)                                         //ilk girişi sağlayıp bir daha girmesin diye
                {
                    eski_konum = angle - 2;                          // 1 derecelik fark yeterli olduğu için 2 dedim
                    kontrol = false;
                }
                label12.Text = angle.ToString();                     //position label
                if (eski_konum+1<angle || angle+1<eski_konum )       //önceki konumla aralarında +- en az 1 derece olmalı
                {
                    grafik_ciz();                                    //BU CLASSDAKİ PASTA GRAFİK ÇİZME FONKSİYONU
                                                                     //ANGLE ZATEN PUBLİC FLOAT OLDUĞU İÇİN DEĞER ALMIYOR DÖNDÜRMÜYOR
                }
                
                
            }
          
        }
       
        private void grafik_kontrol(int frekans,double tepe,string name)          // GRAFİKLERİ SON ÇİZİLENLE KARŞILATIRIR
        {                                                                         // YTERLİ DEĞİŞİM VARSA ÇİZİME MÜSADE EDER
            if (name == "Sin")
            {
                if (graph_sin_kontrol)
                {
                    graph_last_sin = tepe - 0.9; 
                    graph_sin_kontrol = false;
                }
                if(graph_last_sin+1<tepe || tepe+1<graph_last_sin)
                {
                    graph_last_sin = tepe;
                    userControl11.sin_graph(frekans, tepe/2, "Sin");
                }
            }
            else if (name == "Cos")
            {
                 if (graph_cos_kontrol)
                    {
                         graph_last_cos = tepe - 0.9;
                         graph_cos_kontrol = false;
                    }
                    if (graph_last_cos + 1 < tepe || tepe+1<graph_last_cos)
                    {
                        graph_last_cos = tepe;
                        userControl11.sin_graph(frequency, tepe/2, "Cos");
                    }

            }
            else if (name == "Ref")
            {
                if (graph_ref_kontrol)
                {
                    graph_last_ref = tepe - 0.9; 
                    graph_ref_kontrol = false;
                }
                if (graph_last_ref + 1< tepe || tepe + 1<graph_last_ref  )
                {
                    graph_last_ref = tepe;
                    userControl11.sin_graph(frekans, tepe/2, "Ref");
                }
            }
            

        }

        private void grafik_ciz() //input almıyor global "angle" floatı kullanıyor
        {
            //4 DERECEYE 356 DERECELİK İKİ DİLİM OLUŞTURUR
            //AÇI 1 DERECEDEN FAZLA DEĞİŞTİĞİDE ÇAĞRILIR SADECE verial() kullanıyor
            eski_konum = angle;//son yeri tutmak için
            Pen p = new Pen(Color.DarkKhaki, 1);
            Pen p2 = new Pen(Color.DarkKhaki, 4);
            Graphics pasta = this.CreateGraphics();
            Rectangle alan = new Rectangle(label1.Location.X + label3.Size.Width + 180, 45, 270, 270);
            Brush b1 = new SolidBrush(Color.DarkKhaki);
            Brush b2 = new SolidBrush(Color.FromArgb(63, 66, 90));

            pasta.Clear(Color.FromArgb(34,36,49));
            pasta.DrawPie(p, alan, angle - 2, 4);
            pasta.FillPie(b1, alan, -angle - 2, 4);
            pasta.DrawPie(p2, alan, -angle + 2, 356);
            pasta.FillPie(b2, alan, -angle + 2, 356);
            

        }
        private void button1_Click(object sender, EventArgs e)
            /*FREKANS ATAMASI YAPAR*/
        {
            int d1 = 400; //FREKANS DEFAULT DEĞER

            //İNT SAYI DIŞI BİŞEY YAZILIRSA KABUL ETMEZ HATA MESAJI OLUŞTURUR   
            try
            {
                d1 = int.Parse(textBox1.Text);
                if (d1 > 199 && d1 < 2001) //200 İLE 2000 ARASI DIŞINDA VERİ YAZILMASIN DİYE
                {
                    //AKSİ HALİNDE ZİNCİRLEME HATA OLUŞUR
                    //YAZILIRSA DEFAULT 400 ATAANIR
                    
                    trackBar1.Value = d1;
                    label1.Text = d1.ToString();
                }
                else
                {
                    d1 = 400;
                    trackBar1.Value = d1;
                    label1.Text = d1.ToString();
                }
                if (serialPort1.IsOpen)//PORT AÇIKSA VERİNİN BAŞINA 'f' KOYUP GÖNDERİR
                {
                    if (d1 < 1000)
                    {
                        dataout = "f0" + d1.ToString() + "#";
                        char[] add = dataout.ToCharArray();

                        for (int i = 0; i < add.Length; i++)
                        {
                            serialPort1.Write(add[i].ToString());
                            for (int j = 0; j < 900000; j++)
                            {//karşı taraf daha yavaş çalışıyor veriyi yakalayabilmesi için 
                            }

                        }

                    }
                    else
                    {
                        dataout = "f" + d1.ToString() + "#";
                        char[] add = dataout.ToCharArray();
                        for (int i = 0; i < add.Length; i++)
                        {
                            serialPort1.Write(add[i].ToString());
                            for (int j = 0; j < 900000; j++)
                            {//karşı taraf daha yavaş çalışıyor veriyi yakalayabilmesi için 
                            }


                        }
                    }
                   
                  
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void button2_Click(object sender, EventArgs e)
            //voltaj değeri gönderir
        {
            int d1 = 4; //voltaj tepe tepe değeri default trackbar için
            try
            {
                d1 = int.Parse(textBox2.Text);
                
                if (d1 >= 4 && d1 <= 24)
                {
                    trackBar2.Value = d1;
                    label9.Text = d1.ToString();
                }
                else
                {
                    d1 = 4;
                    trackBar2.Value = d1;
                    label9.Text = d1.ToString();
                }

                if (serialPort1.IsOpen)
                {
                    if (d1 < 10)
                    {
                        dataout = "v0" + d1.ToString() + "#";
                        char[] add = dataout.ToCharArray();

                        for (int i = 0; i < add.Length; i++)
                        {
                            serialPort1.Write(add[i].ToString());
                            for (int j = 0; j < 900000; j++)
                            {//karşı taraf daha yavaş çalışıyor veriyi yakalayabilmesi için 
                            }

                        }
                    }
                    else
                    {
                        dataout = "v" + d1.ToString() + "#";
                        char[] add = dataout.ToCharArray();

                        for (int i = 0; i < add.Length; i++)
                        {
                            serialPort1.Write(add[i].ToString());
                            for (int j = 0; j < 900000; j++)
                            {//karşı taraf daha yavaş çalışıyor veriyi yakalayabilmesi için 
                            }

                        }
                    }
                    
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        //seri portu açar
        {
            if (!serialPort1.IsOpen)//açık değilse aç ve gir
            {
                
                try
                {
                    /*haberleşme parametreleri*/
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = Parity.None;
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.Open();

                    progressBar1.Value = 100;
                    label15.ForeColor = System.Drawing.Color.Green;
                    label15.Text = "ON";
                    comboBox1.Enabled = false;
                    comboBox2.Enabled = false;
                    button3.Enabled = false;
                    serialPort1.DiscardInBuffer();


                }

                catch (Exception hata)
                {
                    MessageBox.Show(hata.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }

        }
        private void button4_Click(object sender, EventArgs e)
        //seri portu kapatır
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardInBuffer();
                serialPort1.Close();
                progressBar1.Value = 0;
                label15.ForeColor = System.Drawing.Color.Red;
                label15.Text = "OFF";
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;


            }
            button3.Enabled = true;
        }
        private void button5_Click_1(object sender, EventArgs e)
        //home butonu
        {
            menu_kontrol = false;
            userControl11.Hide();//2.sayfa gizlenir
            sidePanel.Height = button5.Height; //home konumunda başlaması için
            sidePanel.Top = button5.Top;
            

        }
        private void button6_Click(object sender, EventArgs e)
        //grafik butonu
        {
            menu_kontrol = true;
            sidePanel.Height = button6.Height;
            sidePanel.Top = button6.Top;
            userControl11.Show();//grafik moduna geçmesi için

          
            /*byte[] buf = System.Text.Encoding.UTF8.GetBytes("asdc");
            //label11.Text = (buf.Length).ToString();
            label11.Text = (buf[0]).ToString();
            serialPort1.Write(buf, 0, buf.Length);*/
            
        }
        private void button7_Click(object sender, EventArgs e)
        //formu kapatır
        {
           // serialPort1.Close();
            this.Close();
            Application.Exit();
        }
       
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //frekans değişimini sağlayan track bar
            //değişim olunca button 1 çağrılır işi o yapar
            int d1 = trackBar1.Value;
            label1.Text = d1.ToString();
            textBox1.Text = d1.ToString();
            button1_Click(sender, e);
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            //voltaj değişimini sağlayan track bar
            //değişim olunca button 2 çağrılır işi o yapar
            int d1 = trackBar2.Value;
            label9.Text = d1.ToString();
            textBox2.Text = d1.ToString();
            button2_Click(sender, e);

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            //textboxa değer atanıp enter a basılınca button2 çağrılır
            if (e.KeyCode == Keys.Enter)
            {
                button2_Click(sender, e);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //textboxa değer atanıp enter a basılınca button1 çağrılır
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);

            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new EventHandler(txt_yaz));// datayı alabilmek için 

        }
        int sayar = 0;
        string[] buffer = new string[400];
 
        private void txt_yaz(object sender, EventArgs e)
        {
  
            if (sayar < 400)
            {
                buffer[sayar] = serialPort1.ReadLine();


                if (sayar == 399)
                {
                    
                    int k = 0;
                    for (int i = 0; i < 400; i++)
                    {
                        int index = buffer[i].IndexOf("f");
                       
                        if (index != -1)
                        {
                            buffer[i] = buffer[i].Trim('f');
                           
                        }

                    }


                    System.IO.File.WriteAllLines(@"c:\DENEME\DENEME1.txt", buffer);
                    MessageBox.Show("bitti la");
                }



                sayar++;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.DiscardInBuffer();
            }
           
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
