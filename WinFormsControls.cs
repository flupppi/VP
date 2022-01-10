using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

public class WinFormsControls : System.Windows.Forms.Form
{

    // display label
    private System.Windows.Forms.Label displayLabel;

    // main menu (contains file and format menu)
    private System.Windows.Forms.MainMenu mainMenu;

    // file menu
    private System.Windows.Forms.MenuItem fileMenuItem;
    private System.Windows.Forms.MenuItem aboutMenuItem;
    private System.Windows.Forms.MenuItem exitMenuItem;
    // format menu
    private System.Windows.Forms.MenuItem formatMenuItem;
    // color submenu
    private System.Windows.Forms.MenuItem colorMenuItem;
    private System.Windows.Forms.MenuItem blackMenuItem;
    private System.Windows.Forms.MenuItem blueMenuItem;
    private System.Windows.Forms.MenuItem redMenuItem;
    private System.Windows.Forms.MenuItem greenMenuItem;

    // font submenu
    private System.Windows.Forms.MenuItem timesMenuItem;
    private System.Windows.Forms.MenuItem courierMenuItem;
    private System.Windows.Forms.MenuItem comicMenuItem;
    private System.Windows.Forms.MenuItem boldMenuItem;
    private System.Windows.Forms.MenuItem italicMenuItem;
    private System.Windows.Forms.MenuItem fontMenuItem;
    private System.Windows.Forms.MenuItem seperatorMenuItem;

    // contains shape list (circle, square, ellipse, pie)
    private System.Windows.Forms.Combobox imageComboBox;
    // Die Combobox wird im System angelegt und darauf sind Events angemeldet
    // Wenn jetzt über die UI eines dieser Events aufgerufen wird wird die daran angemeldete Funktion
    // ausgeführt. Was darin passiert können wir jetzt unten definieren.

    // list of available book titles
    private System.Windows.Forms.CheckedListBox inputCheckedListBox;

    // user selection list
    private System.Windows.Forms.ListBox displayListBox;
    // user input textbox
    private System.Windows.Forms.TextBox inputTextBox;

    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Button removeButton;
    private System.Windows.Forms.Button clearButton;
    private System.Windows.Forms.Button exitButton;

    [STAThread]
    static void Main()
    {
        Application.Run( 
            new WinFormsControls()
            );
    }

    // get selected index, draw shape
    // Die combobox wurde imageComboBox benanntd und hat ein Event Selected Index Changed
    // Die Methode ist Standard für eine Combobox da diese ohne keine funktionalität hätte.
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

    private void inputCheckedListBox_ItemCheck(
        object sender, System.Windows.Forms.ItemCheckEventArgs e )
    {
        // obtain reference of selected item
        string item = inputCheckedListBox.SelectedItem.ToString();

        // if item checked add to listbox
        // otherwise remove from listbox
        if( e.NewValue == CheckState.Checked)
            displayListBox.Items.Add( item );
        else
            displayListBox.Items.Remove( item );
        
    }

    // add new item (text from input box) and clear input box
    private void addButton_Click(object sender, System.EventArgs e )
    {
        displayListBox.Items.Add (inputTextBox.Text);
        inputTextBox.Clear();
    }
    // remove item if one selected
    private void removeButton_Click(object sender, System.EventArgs e)
    {
        // remove only if item selected; -1 would probably mean none is selected
        if (displayListBox.SelectedIndex != -1)
            displayListBox.Items.RemoveAt(
                displayListBox.SelectedIndex
            );
    }

    // clear all items
    private void clearButton_Click(object sender, System.EventArgs e)
    {
        displayListBox.Items.Clear();
    }

    // exit application
    private void exitButton_Click(object sender, System.EventArgs e)
    {
        Application.Exit();
    }

    // display MessageBox
    private void aboutMenuItem_Click( object sender, System.EventArgs e)
    {
        MessageBox.Show(
            "This is an example\nof using menus.",
            "About", MessageBoxButtons.OK,
            MessageBoxIcon.Information);
    }

    // exit program
    private void exitMenuItem_Click(object sender, System.EventArgs e)
    {
        ApplicationException.Exit();
    }

    // reset color
    private void ClearColor()
    {
        // clear all checkmarks
        blackMenuItem.Checked = false;
        blueMenuItem.Checked = false;
        redMenuItem.Checked = false;
        greenMenuItem.Checked = false;
    }

    // update menu state and color display black
    private void blackMenuItem_Click(object sender, System.EventArgs e)
    {
        // reset checkmarks for color menu items
        ClearColor();

        // set color to black
        displayLabel.ForeColor = Color.Black;
        blackMenuItem.Checked = true;
    }
    // update menu state and color display blue
    private void bluekMenuItem_Click(object sender, System.EventArgs e)
    {
        // reset checkmarks for color menu items
        ClearColor();

        // set color to blue
        displayLabel.ForeColor = Color.Red;
        blueMenuItem.Checked = true;
    }
    // update menu state and color display red
    private void redMenuItem_Click(object sender, System.EventArgs e)
    {
        // reset checkmarks for color menu items
        ClearColor();

        // set color to red
        displayLabel.ForeColor = Color.Red;
        redkMenuItem.Checked = true;
    }
    // update menu state and color display green
    private void greenMenuItem_Click(object sender, System.EventArgs e)
    {
        // reset checkmarks for color menu items
        ClearColor();

        // set color to green
        displayLabel.ForeColor = Color.Green;
        greenMenuItem.Checked = true;
    }

    private void ClearFont()
    {
        // clear all checkmarks
        timesMenuItem.Checked = false;
        courierMenuItem.Checked = false;
        comicMenuItem.Checked = false;
    }

    // update menu state and set font to Times
    private void timesMenuItem_Click( object sender, System.EventArgs e)
    {
        // reset checkmarks for font menu items
        ClearFont();

        // set Times New Roman font
        timesMenuItem.Checked = true;
        displayLabel.Font = new Font("Times New Roman", 14, displayLabel.Font.Style);
    }


    // update menu state and set font to Courier
    private void courierMenuItem_Click( object sender, System.EventArgs e)
    {
        // reset checkmarks for font menu items
        ClearFont();

        // set Courier font
        courierMenuItem.Checked = true;
        displayLabel.Font = new Font("Courier New", 14, displayLabel.Font.Style);
    }

    // update menu state and set font to Comic Sans MS
    private void comicMenuItem_Click( object sender, System.EventArgs e)
    {
        // reset checkmarks for font menu items
        ClearFont();

        // set Comic Sans MS font
        comicMenuItem.Checked = true;
        displayLabel.Font = new Font("Comic Sans MS", 14, displayLabel.Font.Style);
    }

    // toggle checkmark and toggle bold style
    private void boldMenuItem_Click(object sender, System.EventArgs e)
    {
        // toggle checkmark
        boldMenuItem.Checked = !boldMenuItem.Checked;

        // use Xor to toggle bold, keep all other styles
        displayLabel.Font  = new Font(
            displayLabel.Font.FontFamily, 14,
            displayLabel.Font.Style ^ FontStyle.Italic
        );
    }
        



}