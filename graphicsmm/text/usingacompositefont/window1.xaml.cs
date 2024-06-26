//This is a list of commonly used namespaces for a window.
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Data;

namespace UsingACompositeFont
{
    /// <summary>
    /// Demonstrates composite font usage.
    /// </summary>

    public partial class Window1 : Window
    {
      
        private void WindowLoaded(object sender, EventArgs e) {
			useCompositeFontExample();
		}

		// Shows how to use a composite font in code.
		private void useCompositeFontExample()
		{
			try
			{
				TextPanel t = new TextPanel();
				
				// Because we don't know where the sample ends up getting installed on
				// your machine, a FileInfo is used to find the absolute
				// path of the composite font file.
				System.IO.FileInfo f = new System.IO.FileInfo("SampleCompositeFont.CompositeFont");
				
				// Set the FontFamily of the TextPanel.
				t.FontFamily = f.FullName + "#My UI Font";

				// If the composite font file were located in the Windows\Fonts
				// directory, the following would work:
				//		t.FontFamily = "My UI Font";
				t.FontSize = new FontSize(16, FontSizeType.Point);
				t.TextContent = "Hello world, 多介面.";
				mainPanel.Children.Add(t);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message + "\n"  + ex.StackTrace);
			}
		}

    }
}