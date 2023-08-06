using System;
using Gtk;

public partial class MainWindow : Gtk.Window
{
    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
    }

    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnSaveBtnClicked(object sender, EventArgs e)
    {
        this.messageEntry.Text = "Save button pushed";
    }

    protected void OnClearBtnClicked(object sender, EventArgs e)
    {
        this.firstEntry.Text = "";
        this.lastEntry.Text = "";
        this.salaryEntry.Text = "";
        this.messageEntry.Text = "Transaction cancelled";
    }
}
