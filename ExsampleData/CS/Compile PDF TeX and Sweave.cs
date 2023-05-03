namespace Loupedeck.KG_RStudioPlugin
{
    using System;
    public class Compile_PDF_TeX_and_Sweave : PluginDynamicCommand
    {
        public Compile_PDF_TeX_and_Sweave()
        : base(displayName: "Compile PDF TeX and Sweave", description: "Compile PDF TeX and Sweave", groupName: "Source")
        {
        }
        protected override BitmapImage GetCommandImage(String actionParameter, PluginImageSize imageSize)
        {
            using (var bitmapBuilder = new BitmapBuilder(imageSize))

            {

                bitmapBuilder.SetBackgroundImage(EmbeddedResources.ReadImage(EmbeddedResources.FindFile("Source.png")));
                bitmapBuilder.DrawText("Compile PDF TeX and Sweave", color: new BitmapColor(68,13,43));
                return bitmapBuilder.ToImage();

            }
        }
        protected override void RunCommand(String actionParameter)
        {
            this.Plugin.ClientApplication.SendKeyboardShortcut(KeyK, ModifierKey.Ctrl | ModifierKey.Shift);
        }
    }
}
