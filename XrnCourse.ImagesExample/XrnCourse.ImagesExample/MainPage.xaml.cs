using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XrnCourse.ImagesExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var embeddedImage = new Image { Aspect = Aspect.AspectFill };
            //get the image by ResourceID
            embeddedImage.Source = ImageSource.FromResource("XrnCourse.ImagesExample.images.glider.png");
            //configure absolute layout 
            AbsoluteLayout.SetLayoutBounds(embeddedImage, new Rectangle(.5, .5, 512, 109));
            AbsoluteLayout.SetLayoutFlags(embeddedImage, AbsoluteLayoutFlags.PositionProportional);
            //add image to layout
            absLayout.Children.Add(embeddedImage);
        }
    }
}
