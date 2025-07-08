using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressBarTest;

public partial class CustomProgressBar : ContentView
{
    public static readonly BindableProperty ValueProperty = BindableProperty.Create(nameof(Value), typeof(double), typeof(ProgressBar), 0.0);
    public static readonly BindableProperty CustomLabelProperty = BindableProperty.Create(nameof(CustomLabel), typeof(string), typeof(ProgressBar), null);

    public CustomProgressBar()
    {
        InitializeComponent();
    }

    public double Value
    {
        get
        {
            return (double)GetValue(ValueProperty);
        }
        set
        {
            SetValue(ValueProperty, value);
            UpdateWidth();
        }
    }
    
    public string CustomLabel
    {
        get
        {
            return (string)GetValue(CustomLabelProperty);
        }
        set
        {
            SetValue(CustomLabelProperty, value);
            UpdateWidth();
        }
    }

    protected override void OnPropertyChanged(string propertyName = null)
    {
        base.OnPropertyChanged(propertyName);
        
        Debug.WriteLine($"ProgressBar OnPropertyChanged name {propertyName}");
        if (propertyName == null) return;

        if (propertyName == "Value")
        {
            UpdateWidth();
        }

        if (propertyName == "Width")
        {
            UpdateWidth();
        }
        
        if (propertyName == "CustomLabel")
        {
            UpdateWidth();
        }
    }

    void UpdateWidth()
    {            
        Debug.WriteLine($"UpdateWidth start");
        if (LblValue != null)
        {
            if (!string.IsNullOrEmpty(CustomLabel))
            {
                LblValue.Text = CustomLabel;
            }
            else
            {
                LblValue.Text = Value.ToString("##0.0") + "%";
            }    
        }

        if (ProgBar != null)
        {
            Debug.WriteLine($"Width {this.Width} Height {this.Height} Value:{Value}");
            if (this.Width > 0)
            {
                ProgBar.WidthRequest = this.Width * Value / 100;
                Debug.WriteLine($"UpdateWidth end Width {ProgBar.WidthRequest}");
                Debug.WriteLine($"Progbar Width {ProgBar.Width} ProgBar height:{ProgBar.Height}");    
            }
            else
            {
                Debug.WriteLine($"Invalid Width skip {this.Width}");
            }    
        }
    }
    
    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();
        Debug.WriteLine($"OnBindingContextChanged ProgressBar Width {this.Width} Height {this.Height} Value:{Value}");
    }

    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        Debug.WriteLine($"OnSizeAllocated ProgressBar Width {this.Width} Height {this.Height} Value:{Value}");
    }

    protected override Size ArrangeOverride(Rect bounds)
    {
        Debug.WriteLine($"ArrangeOverride ProgressBar Width {this.Width} Height {this.Height} Value:{Value}");
        return base.ArrangeOverride(bounds);
        
    }

    protected override Size MeasureOverride(double widthConstraint, double heightConstraint)
    {
        Debug.WriteLine($"MeasureOverride ProgressBar Width {this.Width} Height {this.Height} Value:{Value}");
        return base.MeasureOverride(widthConstraint, heightConstraint);
    }
}