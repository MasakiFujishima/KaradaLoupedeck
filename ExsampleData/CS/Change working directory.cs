namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Change_working_directory : PluginDynamicCommand
    {
        public Change_working_directory()
        : base(displayName: "Change working directory", description: "Change working directory", groupName: "Console")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Console.png")));
                bitmapBuilder.DrawText("Change working directory", color: new BitmapColor(4,0,1));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyH, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
