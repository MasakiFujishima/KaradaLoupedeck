namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Run_the_next_Sweave_Rmd_chunk : PluginDynamicCommand
    {
        public Run_the_next_Sweave_Rmd_chunk()
        : base(displayName: "Run the next Sweave Rmd chunk", description: "Run the next Sweave Rmd chunk", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Run the next Sweave Rmd chunk", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyN, ModifierKey.Ctrl | ModifierKey.Alt);
        }
    }
}
