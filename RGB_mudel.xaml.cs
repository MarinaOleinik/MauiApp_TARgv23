

namespace MauiApp_TARgv23;

public partial class RGB_mudel : ContentPage
{       Label lbl;
        Slider sl_r,sl_g, sl_b;
        BoxView rb, gb, bb, rgbb;
        AbsoluteLayout abs;
        int r=0,g=0,b = 0;
	public RGB_mudel(int k)
	{   
        lbl = new Label
            {
                Text = "RGB mudel",
                FontFamily="Lobster Regular 400",
                FontAttributes= FontAttributes.Bold,
                HorizontalTextAlignment=TextAlignment.Center,
                FontSize=24
                
            };
        rb = new BoxView
            {
                Color = Color.FromRgb(255, g, b),
                CornerRadius = 20,
                BackgroundColor = Color.FromRgba(0, 0, 0, 0)
            };
        gb = new BoxView
            {
                Color = Color.FromRgb(r, 255, b),
                CornerRadius = 20,
                BackgroundColor = Color.FromRgba(0, 0, 0, 0)
            };
        bb = new BoxView
            {
                Color = Color.FromRgb(r, g, 255),
                CornerRadius = 20,
                BackgroundColor = Color.FromRgba(0, 0, 0, 0)
            };
        rgbb = new BoxView
        {
            Color = Color.FromRgb(r, g, b),
            CornerRadius = 20,
            BackgroundColor = Color.FromRgba(0, 0, 0, 0)
        };
        sl_r = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 25,
                MinimumTrackColor = Color.FromRgb(55, 55, 55),
                MaximumTrackColor = Color.FromRgb(0, 0, 0),
                ThumbColor = Color.FromRgb(155, 155, 155),
            };
        sl_r.ValueChanged += RGB_mudeli_varvid;
        sl_g = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 25,
                MinimumTrackColor = Color.FromRgb(55, 55, 55),
                MaximumTrackColor = Color.FromRgb(0, 0, 0),
                ThumbColor = Color.FromRgb(155, 155, 155),
            };
        sl_g.ValueChanged += RGB_mudeli_varvid;
        sl_b = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 25,
                MinimumTrackColor = Color.FromRgb(55, 55, 55),
                MaximumTrackColor = Color.FromRgb(0, 0, 0),
                ThumbColor = Color.FromRgb(155, 155, 155),
            };
        sl_b.ValueChanged += RGB_mudeli_varvid;
        abs = new AbsoluteLayout { Children = { lbl,rb,gb,bb, sl_r, sl_g,sl_b,rgbb } };
        AbsoluteLayout.SetLayoutBounds(lbl, new Rect(20, 10, 300, 50));
        AbsoluteLayout.SetLayoutBounds(rb, new Rect(20, 100, 100, 100));
        AbsoluteLayout.SetLayoutBounds(gb, new Rect(120, 100, 100, 100));
        AbsoluteLayout.SetLayoutBounds(bb, new Rect(220, 100, 100, 100));
        
        AbsoluteLayout.SetLayoutBounds(sl_r, new Rect(20, 250, 300, 50));
        AbsoluteLayout.SetLayoutBounds(sl_g, new Rect(20, 300, 300, 50));
        AbsoluteLayout.SetLayoutBounds(sl_b, new Rect(20, 350, 300, 50));

        AbsoluteLayout.SetLayoutBounds(rgbb, new Rect(20, 400, 300, 300));
        Content = abs;
    }

    private void RGB_mudeli_varvid(object? sender, ValueChangedEventArgs e)
    {
        rb.Color = Color.FromRgb((int)sl_r.Value, 0, 0);
        gb.Color = Color.FromRgb(0, (int)sl_g.Value, 0);
        bb.Color = Color.FromRgb(0, 0, (int)sl_b.Value);
        rgbb.Color = Color.FromRgb((int)sl_r.Value, (int)sl_g.Value, (int)sl_b.Value);
        lbl.TextColor = rgbb.Color;
    }
}