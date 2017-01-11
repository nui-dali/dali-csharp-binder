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

public class AsyncImageLoader : BaseHandle {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal AsyncImageLoader(global::System.IntPtr cPtr, bool cMemoryOwn) : base(NDalicPINVOKE.AsyncImageLoader_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(AsyncImageLoader obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~AsyncImageLoader() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          NDalicPINVOKE.delete_AsyncImageLoader(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  internal AsyncImageLoader () : this (NDalicPINVOKE.AsyncImageLoader_New(), true) {
      if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();

  }
  internal AsyncImageLoader(AsyncImageLoader handle) : this(NDalicPINVOKE.new_AsyncImageLoader__SWIG_1(AsyncImageLoader.getCPtr(handle)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  internal AsyncImageLoader Assign(AsyncImageLoader handle) {
    AsyncImageLoader ret = new AsyncImageLoader(NDalicPINVOKE.AsyncImageLoader_Assign(swigCPtr, AsyncImageLoader.getCPtr(handle)), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal static AsyncImageLoader DownCast(BaseHandle handle) {
    AsyncImageLoader ret = new AsyncImageLoader(NDalicPINVOKE.AsyncImageLoader_DownCast(BaseHandle.getCPtr(handle)), true);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal uint Load(string url) {
    uint ret = NDalicPINVOKE.AsyncImageLoader_Load__SWIG_0(swigCPtr, url);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal uint Load(string url, Uint16Pair dimensions) {
    uint ret = NDalicPINVOKE.AsyncImageLoader_Load__SWIG_1(swigCPtr, url, Uint16Pair.getCPtr(dimensions));
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal uint Load(string url, Uint16Pair dimensions, FittingModeType fittingMode, SamplingModeType samplingMode, bool orientationCorrection) {
    uint ret = NDalicPINVOKE.AsyncImageLoader_Load__SWIG_2(swigCPtr, url, Uint16Pair.getCPtr(dimensions), (int)fittingMode, (int)samplingMode, orientationCorrection);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal bool Cancel(uint loadingTaskId) {
    bool ret = NDalicPINVOKE.AsyncImageLoader_Cancel(swigCPtr, loadingTaskId);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal void CancelAll() {
    NDalicPINVOKE.AsyncImageLoader_CancelAll(swigCPtr);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

  internal SWIGTYPE_p_Dali__SignalT_void_fuint32_t_Dali__PixelDataF_t ImageLoadedSignal() {
    SWIGTYPE_p_Dali__SignalT_void_fuint32_t_Dali__PixelDataF_t ret = new SWIGTYPE_p_Dali__SignalT_void_fuint32_t_Dali__PixelDataF_t(NDalicPINVOKE.AsyncImageLoader_ImageLoadedSignal(swigCPtr), false);
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  internal AsyncImageLoader(SWIGTYPE_p_Dali__Toolkit__Internal__AsyncImageLoader impl) : this(NDalicPINVOKE.new_AsyncImageLoader__SWIG_2(SWIGTYPE_p_Dali__Toolkit__Internal__AsyncImageLoader.getCPtr(impl)), true) {
    if (NDalicPINVOKE.SWIGPendingException.Pending) throw NDalicPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
