using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ApplePong {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page {
        public MainPage() {
            this.InitializeComponent();

        }

        private void LeftPaddle_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e) {
            leftPaddleDragTranslation.Y += e.Delta.Translation.Y*(Field.ActualHeight/FieldViewBox.ActualHeight);

            if (leftPaddleDragTranslation.Y > (Field.ActualHeight/2) - (LeftPaddle.Height/2)) {
                leftPaddleDragTranslation.Y -= e.Delta.Translation.Y * (Field.ActualHeight / FieldViewBox.ActualHeight);
            }
        }

        private void RightPaddle_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e) {
            var pos = rightPaddleDragTranslation.Y + e.Delta.Translation.Y*(Field.ActualHeight/FieldViewBox.ActualHeight);

            if (Math.Abs(pos) < (Field.ActualHeight/2) - (LeftPaddle.Height/2)) {
                rightPaddleDragTranslation.Y = pos;
            }
        }


    }
}
