using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Storage.Pickers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using MetadataExtractor;
using MetadataExtractor.Formats.Exif;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SnapRename
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.AppWindow.Resize(new Windows.Graphics.SizeInt32(600, 750));
            this.AppWindow.SetIcon("Assets/logo.ico");
        }

        private async void DropZone_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var picker = new FileOpenPicker();
            var hwnd = WinRT.Interop.WindowNative.GetWindowHandle(this);
            WinRT.Interop.InitializeWithWindow.Initialize(picker, hwnd);
            picker.FileTypeFilter.Add(".jpg");
            picker.FileTypeFilter.Add(".png");
            picker.FileTypeFilter.Add(".cr2");
            picker.FileTypeFilter.Add(".nef");
            var files = await picker.PickMultipleFilesAsync();
            if (files != null && files.Count > 0)
            {
                foreach (var file in files)
                {
                    var date = GetDateTaken(file.Path);
                    FileList.Items.Add(new PhotoFile
                    {
                        OldName = file.Name,
                        FullPath = file.Path,
                        DateTaken = date,
                        NewName = date.HasValue ? date.Value.ToString("yyyy-MM-dd") : "no EXIF"
                    });
                }
            }
        }
        private DateTime? GetDateTaken(string path)
        {
            var directories = ImageMetadataReader.ReadMetadata(path);
            var subIfd = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();
            var date = subIfd?.GetDateTime(ExifDirectoryBase.TagDateTimeOriginal);
            return date;
        }
    }
}
