/** Copyright (c) 2017 Samsung Electronics Co., Ltd.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
* http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/
// This File has been auto-generated by SWIG and then modified using DALi Ruby Scripts
//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.9
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace NUI {

using System;
using System.Runtime.InteropServices;


public class Slider : View {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal Slider(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.Slider_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Slider obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Slider() {
    DisposeQueue.Instance.Add(this);
  }

  public override void Dispose() {
    if (!Stage.IsInstalled()) {
      DisposeQueue.Instance.Add(this);
      return;
    }

    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_Slider(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }



public class ValueChangedEventArgs : EventArgs
{
   private Slider _slider;
   private float _slideValue;

   public Slider Slider
   {
      get
      {
         return _slider;
      }
      set
      {
         _slider = value;
      }
   }

   public float SlideValue
   {
      get
      {
         return _slideValue;
      }
      set
      {
         _slideValue = value;
      }
   }
}

public class SlidingFinishedEventArgs : EventArgs
{
   private Slider _slider;
   private float _slideValue;

   public Slider Slider
   {
      get
      {
         return _slider;
      }
      set
      {
         _slider = value;
      }
   }

   public float SlideValue
   {
      get
      {
         return _slideValue;
      }
      set
      {
         _slideValue = value;
      }
   }
}

public class MarkReachedEventArgs : EventArgs
{
   private Slider _slider;
   private int _slideValue;

   public Slider Slider
   {
      get
      {
         return _slider;
      }
      set
      {
         _slider = value;
      }
   }

   public int SlideValue
   {
      get
      {
         return _slideValue;
      }
      set
      {
         _slideValue = value;
      }
   }
}


  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate bool ValueChangedCallbackDelegate(IntPtr slider, float slideValue);
  private EventHandlerWithReturnType<object,ValueChangedEventArgs,bool> _sliderValueChangedEventHandler;
  private ValueChangedCallbackDelegate _sliderValueChangedCallbackDelegate;

  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate bool SlidingFinishedCallbackDelegate(IntPtr slider, float slideValue);
  private EventHandlerWithReturnType<object,SlidingFinishedEventArgs,bool> _sliderSlidingFinishedEventHandler;
  private SlidingFinishedCallbackDelegate _sliderSlidingFinishedCallbackDelegate;

  [UnmanagedFunctionPointer(CallingConvention.StdCall)]
  private delegate bool MarkReachedCallbackDelegate(IntPtr slider, int slideValue);
  private EventHandlerWithReturnType<object,MarkReachedEventArgs,bool> _sliderMarkReachedEventHandler;
  private MarkReachedCallbackDelegate _sliderMarkReachedCallbackDelegate;

  public event EventHandlerWithReturnType<object,ValueChangedEventArgs,bool> ValueChanged
  {
     add
     {
        lock(this)
        {
           // Restricted to only one listener
           if (_sliderValueChangedEventHandler == null)
           {
              _sliderValueChangedEventHandler += value;

              _sliderValueChangedCallbackDelegate = new ValueChangedCallbackDelegate(OnValueChanged);
              this.ValueChangedSignal().Connect(_sliderValueChangedCallbackDelegate);
           }
        }
     }

     remove
     {
        lock(this)
        {
           if (_sliderValueChangedEventHandler != null)
           {
              this.ValueChangedSignal().Disconnect(_sliderValueChangedCallbackDelegate);
           }

           _sliderValueChangedEventHandler -= value;
        }
     }
  }

  // Callback for Slider ValueChanged signal
  private bool OnValueChanged(IntPtr slider, float slideValue)
  {
     ValueChangedEventArgs e = new ValueChangedEventArgs();

     // Populate all members of "e" (ValueChangedEventArgs) with real page
     e.Slider = Slider.GetSliderFromPtr( slider );
     e.SlideValue = slideValue;

     if (_sliderValueChangedEventHandler != null)
     {
        //here we send all page to user event handlers
      return _sliderValueChangedEventHandler(this, e);
     }
     return false;
  }

  public event EventHandlerWithReturnType<object,SlidingFinishedEventArgs,bool> SlidingFinished
  {
     add
     {
        lock(this)
        {
           // Restricted to only one listener
           if (_sliderSlidingFinishedEventHandler == null)
           {
              _sliderSlidingFinishedEventHandler += value;

              _sliderSlidingFinishedCallbackDelegate = new SlidingFinishedCallbackDelegate(OnSlidingFinished);
              this.SlidingFinishedSignal().Connect(_sliderSlidingFinishedCallbackDelegate);
           }
        }
     }

     remove
     {
        lock(this)
        {
           if (_sliderSlidingFinishedEventHandler != null)
           {
              this.SlidingFinishedSignal().Disconnect(_sliderSlidingFinishedCallbackDelegate);
           }

           _sliderSlidingFinishedEventHandler -= value;
        }
     }
  }

  // Callback for Slider SlidingFinished signal
  private bool OnSlidingFinished(IntPtr slider, float slideValue)
  {
     SlidingFinishedEventArgs e = new SlidingFinishedEventArgs();

     // Populate all members of "e" (SlidingFinishedEventArgs) with real page
     e.Slider = Slider.GetSliderFromPtr( slider );
     e.SlideValue = slideValue;

     if (_sliderSlidingFinishedEventHandler != null)
     {
        //here we send all page to user event handlers
      return _sliderSlidingFinishedEventHandler(this, e);
     }
     return false;
  }

  public event EventHandlerWithReturnType<object,MarkReachedEventArgs,bool> MarkReached
  {
     add
     {
        lock(this)
        {
           // Restricted to only one listener
           if (_sliderMarkReachedEventHandler == null)
           {
              _sliderMarkReachedEventHandler += value;

              _sliderMarkReachedCallbackDelegate = new MarkReachedCallbackDelegate(OnMarkReached);
              this.MarkReachedSignal().Connect(_sliderMarkReachedCallbackDelegate);
           }
        }
     }

     remove
     {
        lock(this)
        {
           if (_sliderMarkReachedEventHandler != null)
           {
              this.MarkReachedSignal().Disconnect(_sliderMarkReachedCallbackDelegate);
           }

           _sliderMarkReachedEventHandler -= value;
        }
     }
  }

  // Callback for Slider MarkReached signal
  private bool OnMarkReached(IntPtr slider, int slideValue)
  {
     MarkReachedEventArgs e = new MarkReachedEventArgs();

     // Populate all members of "e" (MarkReachedEventArgs) with real page
     e.Slider = Slider.GetSliderFromPtr( slider );
     e.SlideValue = slideValue;

     if (_sliderMarkReachedEventHandler != null)
     {
        //here we send all page to user event handlers
      return _sliderMarkReachedEventHandler(this, e);
     }
     return false;
  }

  public static Slider GetSliderFromPtr(global::System.IntPtr cPtr) {
    Slider ret = new Slider(cPtr, false);
   if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }


  public class Property : global::System.IDisposable {
    private global::System.Runtime.InteropServices.HandleRef swigCPtr;
    protected bool swigCMemOwn;
  
    internal Property(global::System.IntPtr cPtr, bool cMemoryOwn) {
      swigCMemOwn = cMemoryOwn;
      swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
    }
  
    internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Property obj) {
      return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
    }
  
    ~Property() {
      Dispose();
    }
  
    public virtual void Dispose() {
      lock(this) {
        if (swigCPtr.Handle != global::System.IntPtr.Zero) {
          if (swigCMemOwn) {
            swigCMemOwn = false;
            NDalicPINVOKE.delete_Slider_Property(swigCPtr);
          }
          swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
        }
        global::System.GC.SuppressFinalize(this);
      }
    }
  
    public Property() : this(NDalicPINVOKE.new_Slider_Property(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    }
  
    public static readonly int LOWER_BOUND = NDalicPINVOKE.Slider_Property_LOWER_BOUND_get();
    public static readonly int UPPER_BOUND = NDalicPINVOKE.Slider_Property_UPPER_BOUND_get();
    public static readonly int VALUE = NDalicPINVOKE.Slider_Property_VALUE_get();
    public static readonly int TRACK_VISUAL = NDalicPINVOKE.Slider_Property_TRACK_VISUAL_get();
    public static readonly int HANDLE_VISUAL = NDalicPINVOKE.Slider_Property_HANDLE_VISUAL_get();
    public static readonly int PROGRESS_VISUAL = NDalicPINVOKE.Slider_Property_PROGRESS_VISUAL_get();
    public static readonly int POPUP_VISUAL = NDalicPINVOKE.Slider_Property_POPUP_VISUAL_get();
    public static readonly int POPUP_ARROW_VISUAL = NDalicPINVOKE.Slider_Property_POPUP_ARROW_VISUAL_get();
    public static readonly int DISABLED_COLOR = NDalicPINVOKE.Slider_Property_DISABLED_COLOR_get();
    public static readonly int VALUE_PRECISION = NDalicPINVOKE.Slider_Property_VALUE_PRECISION_get();
    public static readonly int SHOW_POPUP = NDalicPINVOKE.Slider_Property_SHOW_POPUP_get();
    public static readonly int SHOW_VALUE = NDalicPINVOKE.Slider_Property_SHOW_VALUE_get();
    public static readonly int MARKS = NDalicPINVOKE.Slider_Property_MARKS_get();
    public static readonly int SNAP_TO_MARKS = NDalicPINVOKE.Slider_Property_SNAP_TO_MARKS_get();
    public static readonly int MARK_TOLERANCE = NDalicPINVOKE.Slider_Property_MARK_TOLERANCE_get();
  
  }

  public Slider () : this (NDalicPINVOKE.Slider_New(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  public Slider(Slider handle) : this(NDalicPINVOKE.new_Slider__SWIG_1(Slider.getCPtr(handle)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  public Slider Assign(Slider handle) {
    Slider ret = new Slider(NDalicPINVOKE.Slider_Assign(swigCPtr, Slider.getCPtr(handle)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public new static Slider DownCast(BaseHandle handle) {
    Slider ret = new Slider(NDalicPINVOKE.Slider_DownCast(BaseHandle.getCPtr(handle)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SliderValueChangedSignal ValueChangedSignal() {
    SliderValueChangedSignal ret = new SliderValueChangedSignal(NDalicPINVOKE.Slider_ValueChangedSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SliderValueChangedSignal SlidingFinishedSignal() {
    SliderValueChangedSignal ret = new SliderValueChangedSignal(NDalicPINVOKE.Slider_SlidingFinishedSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SliderMarkReachedSignal MarkReachedSignal() {
    SliderMarkReachedSignal ret = new SliderMarkReachedSignal(NDalicPINVOKE.Slider_MarkReachedSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public enum PropertyRange {
    PROPERTY_START_INDEX = PropertyRanges.PROPERTY_REGISTRATION_START_INDEX,
    PROPERTY_END_INDEX = View.PropertyRange.PROPERTY_START_INDEX+1000
  }

  public float LowerBound
  {
    get
    {
      float temp = 0.0f;
      GetProperty( Slider.Property.LOWER_BOUND).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Slider.Property.LOWER_BOUND, new NUI.Property.Value( value ) );
    }
  }
  public float UpperBound
  {
    get
    {
      float temp = 0.0f;
      GetProperty( Slider.Property.UPPER_BOUND).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Slider.Property.UPPER_BOUND, new NUI.Property.Value( value ) );
    }
  }
  public float Value
  {
    get
    {
      float temp = 0.0f;
      GetProperty( Slider.Property.VALUE).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Slider.Property.VALUE, new NUI.Property.Value( value ) );
    }
  }
  public NUI.Property.Map TrackVisual
  {
    get
    {
      NUI.Property.Map temp = new NUI.Property.Map();
      GetProperty( Slider.Property.TRACK_VISUAL).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Slider.Property.TRACK_VISUAL, new NUI.Property.Value( value ) );
    }
  }
  public NUI.Property.Map HandleVisual
  {
    get
    {
      NUI.Property.Map temp = new NUI.Property.Map();
      GetProperty( Slider.Property.HANDLE_VISUAL).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Slider.Property.HANDLE_VISUAL, new NUI.Property.Value( value ) );
    }
  }
  public NUI.Property.Map ProgressVisual
  {
    get
    {
      NUI.Property.Map temp = new NUI.Property.Map();
      GetProperty( Slider.Property.PROGRESS_VISUAL).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Slider.Property.PROGRESS_VISUAL, new NUI.Property.Value( value ) );
    }
  }
  public NUI.Property.Map PopupVisual
  {
    get
    {
      NUI.Property.Map temp = new NUI.Property.Map();
      GetProperty( Slider.Property.POPUP_VISUAL).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Slider.Property.POPUP_VISUAL, new NUI.Property.Value( value ) );
    }
  }
  public NUI.Property.Map PopupArrowVisual
  {
    get
    {
      NUI.Property.Map temp = new NUI.Property.Map();
      GetProperty( Slider.Property.POPUP_ARROW_VISUAL).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Slider.Property.POPUP_ARROW_VISUAL, new NUI.Property.Value( value ) );
    }
  }
  public Vector4 DisabledColor
  {
    get
    {
      Vector4 temp = new Vector4(0.0f,0.0f,0.0f,0.0f);
      GetProperty( Slider.Property.DISABLED_COLOR).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Slider.Property.DISABLED_COLOR, new NUI.Property.Value( value ) );
    }
  }
  public int ValuePrecision
  {
    get
    {
      int temp = 0;
      GetProperty( Slider.Property.VALUE_PRECISION).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Slider.Property.VALUE_PRECISION, new NUI.Property.Value( value ) );
    }
  }
  public bool ShowPopup
  {
    get
    {
      bool temp = false;
      GetProperty( Slider.Property.SHOW_POPUP).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Slider.Property.SHOW_POPUP, new NUI.Property.Value( value ) );
    }
  }
  public bool ShowValue
  {
    get
    {
      bool temp = false;
      GetProperty( Slider.Property.SHOW_VALUE).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Slider.Property.SHOW_VALUE, new NUI.Property.Value( value ) );
    }
  }
  public NUI.Property.Array Marks
  {
    get
    {
      NUI.Property.Array temp = new NUI.Property.Array();
      GetProperty( Slider.Property.MARKS).Get(  temp );
      return temp;
    }
    set
    {
      SetProperty( Slider.Property.MARKS, new NUI.Property.Value( value ) );
    }
  }
  public bool SnapToMarks
  {
    get
    {
      bool temp = false;
      GetProperty( Slider.Property.SNAP_TO_MARKS).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Slider.Property.SNAP_TO_MARKS, new NUI.Property.Value( value ) );
    }
  }
  public float MarkTolerance
  {
    get
    {
      float temp = 0.0f;
      GetProperty( Slider.Property.MARK_TOLERANCE).Get( ref temp );
      return temp;
    }
    set
    {
      SetProperty( Slider.Property.MARK_TOLERANCE, new NUI.Property.Value( value ) );
    }
  }

}

}
