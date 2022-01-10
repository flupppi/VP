using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.data;

public class ComboboxExample : System.Windows.Forms.Form
{

    // contains shape list (circle, square, ellipse, pie)
    private System.Windows.Forms.Combobox imageComboBox;
    // Die Combobox wird im System angelegt und darauf sind Events angemeldet
    // Wenn jetzt über die UI eines dieser Events aufgerufen wird wird die daran angemeldete Funktion
    // ausgeführt. Was darin passiert können wir jetzt unten definieren.

    [STAThread]
    static void Main()
    {
        Application.Run( new ComboBoxTest());
    }

    // get selected index, draw shape
    // Die combobox wurde imageComboBox benanntd und hat ein Event Selected Index Changed
    private void imageComboBox_SelectedIndexChanged( object sender, System.EventArgs e)
    {
        // Die Methode Empfängt ein Event vom System und hat einen sender von dem dieses objekt entstammt ist.
        // create graphics object, 
        Graphics myGraphics = base.CreateGraphics();

        // create Pen using color DarkRed
        Pen myPen = new Pen(Color.DarkRed);

        // create SolidBrush using color DarkRed
        SolidBrush mySolidBrush = new SolidBrush(Color.DarkRed);

        myGraphics.Clear(Color.White);
    
        // find index, draw proper shape
        switch( imageComboBox.SelectedIndex)
        {
            case 0:
                myGraphics.DrawEllipse(myPen, 50, 50, 150, 150);
                break;
            case 1:
                myGraphics.DrawRectangle(myPen, 50, 50, 150, 150);
                break;
            case 2:
                myGraphics.DrawEllipse(myPen, 50, 95, 150, 115);
                break;
            case 3:
                myGraphics.DrawPie(myPen, 50, 50, 150, 150, 0, 45);
                break;
            case 4:
                myGraphics.FillEllipse(mySolidBrush, 50, 50, 150, 150);
                break;
            case 5:
                myGraphics.FillRectangle(mySolidBrush, 50, 50, 150, 150);
                break;
            case 6:
                myGraphics.FillEllipse(mySolidBrush, 50, 95, 150, 115);
                break;
            case 7:
                myGraphics.FillPie(mySolidBrush, 50, 50, 150, 150, 0, 45);
                break;
            
        }
        
        
    }

}