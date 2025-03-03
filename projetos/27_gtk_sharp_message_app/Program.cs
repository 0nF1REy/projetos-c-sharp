using System;
using Gtk;

class Program
{
    static void Main()
    {
        Console.Clear();
        Application.Init();
        Window window = new Window("Meu App GTK#");
        window.SetDefaultSize(400, 300);
        window.DeleteEvent += delegate { Application.Quit(); };

        Button button = new Button("C# é dahora!");
        button.Clicked += (sender, e) => 
        {
            MessageDialog dialog = new MessageDialog(
                window,
                DialogFlags.Modal,
                MessageType.Info,
                ButtonsType.Ok,
                "C# é dahora!"
            );
            dialog.Run();
            dialog.Destroy();
        };

        // Adicionando botão à janela
        window.Add(button);
        window.ShowAll();

        Application.Run();
    }
}
