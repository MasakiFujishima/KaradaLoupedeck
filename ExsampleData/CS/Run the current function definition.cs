namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Run_the_current_function_definition : PluginDynamicCommand
    {
        public Run_the_current_function_definition()
        : base(displayName: "Run the current function definition", description: "Run the current function definition", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Run the current function definition", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyF, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
