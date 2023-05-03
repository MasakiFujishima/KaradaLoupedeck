namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Run_the_current_code_section : PluginDynamicCommand
    {
        public Run_the_current_code_section()
        : base(displayName: "Run the current code section", description: "Run the current code section", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Run the current code section", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyT, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
