using FormBotoncito;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormBotoncito
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            //INSTANCIAR LOS COMPONENTES
            Form1 form1 = new Form1();
            Button boton1 = new Button();

            //PROPIEDADES DE LOS COMPONENTES
            boton1.Text = "HOLA!";
            form1.BackColor = Color.Pink;  
            boton1.BackColor = Color.Pink;
            boton1.ForeColor = Color.White;  
            boton1.Width = 150;
            boton1.Height = 75;
            boton1.Font = new Font("Arial", 12, FontStyle.Bold);
            boton1.Top = (form1.Height - boton1.Width) / 2;
            boton1.Left = (form1.Width - boton1.Width) / 2;

            
            //MOSTRAR LOS COMPONENTES
            form1.Show();
            form1.Controls.Add(boton1);
            Application.Run(form1); 
        }
    }
}
