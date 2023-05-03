namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Interrupt_currently_executing_command : PluginDynamicCommand
    {
        public Interrupt_currently_executing_command()
        : base(displayName: "Interrupt currently executing command", description: "Interrupt currently executing command", groupName: "Console")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Console.png")));
                bitmapBuilder.DrawText("Interrupt currently executing command", color: new BitmapColor(4,0,1));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(Esc, );
        }
    }
}
