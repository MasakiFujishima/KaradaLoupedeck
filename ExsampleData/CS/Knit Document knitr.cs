namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Knit_Document_knitr : PluginDynamicCommand
    {
        public Knit_Document_knitr()
        : base(displayName: "Knit Document knitr", description: "Knit Document knitr", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Knit Document knitr", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyK, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
