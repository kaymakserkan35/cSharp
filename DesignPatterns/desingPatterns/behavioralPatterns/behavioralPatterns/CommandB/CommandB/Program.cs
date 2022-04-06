using System;

namespace CommandB
{
    class Program
    {
        static void Main(string[] args)
        {
            Application application = new Application();
            application.editor.text = "dfagjasdkflaskdgjaposdkfa";
            application.editor.GetSelection(2, 5);
            application.CopyButtonUI()
            

        }
    }
}
