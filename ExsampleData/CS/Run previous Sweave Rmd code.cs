namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Run_previous_Sweave_Rmd_code : PluginDynamicCommand
    {
        public Run_previous_Sweave_Rmd_code()
        : base(displayName: "Run previous Sweave Rmd code", description: "Run previous Sweave Rmd code", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Run previous Sweave Rmd code", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyP, ModifierKey.Ctrl | ModifierKey.Shift | ModifierKey.Alt);
        }
    }
}
