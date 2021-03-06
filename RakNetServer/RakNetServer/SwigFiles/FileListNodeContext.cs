//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace RakNet {

public class FileListNodeContext : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FileListNodeContext(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FileListNodeContext obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FileListNodeContext() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.CSharp_RakNet_delete_FileListNodeContext(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FileListNodeContext() : this(RakNetPINVOKE.CSharp_RakNet_new_FileListNodeContext__SWIG_0(), true) {
  }

  public FileListNodeContext(byte o, uint f1, uint f2, uint f3) : this(RakNetPINVOKE.CSharp_RakNet_new_FileListNodeContext__SWIG_1(o, f1, f2, f3), true) {
  }

  public byte op {
    set {
      RakNetPINVOKE.CSharp_RakNet_FileListNodeContext_op_set(swigCPtr, value);
    } 
    get {
      byte ret = RakNetPINVOKE.CSharp_RakNet_FileListNodeContext_op_get(swigCPtr);
      return ret;
    } 
  }

  public uint flnc_extraData1 {
    set {
      RakNetPINVOKE.CSharp_RakNet_FileListNodeContext_flnc_extraData1_set(swigCPtr, value);
    } 
    get {
      uint ret = RakNetPINVOKE.CSharp_RakNet_FileListNodeContext_flnc_extraData1_get(swigCPtr);
      return ret;
    } 
  }

  public uint flnc_extraData2 {
    set {
      RakNetPINVOKE.CSharp_RakNet_FileListNodeContext_flnc_extraData2_set(swigCPtr, value);
    } 
    get {
      uint ret = RakNetPINVOKE.CSharp_RakNet_FileListNodeContext_flnc_extraData2_get(swigCPtr);
      return ret;
    } 
  }

  public uint flnc_extraData3 {
    set {
      RakNetPINVOKE.CSharp_RakNet_FileListNodeContext_flnc_extraData3_set(swigCPtr, value);
    } 
    get {
      uint ret = RakNetPINVOKE.CSharp_RakNet_FileListNodeContext_flnc_extraData3_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_void dataPtr {
    set {
      RakNetPINVOKE.CSharp_RakNet_FileListNodeContext_dataPtr_set(swigCPtr, SWIGTYPE_p_void.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = RakNetPINVOKE.CSharp_RakNet_FileListNodeContext_dataPtr_get(swigCPtr);
      SWIGTYPE_p_void ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_void(cPtr, false);
      return ret;
    } 
  }

  public uint dataLength {
    set {
      RakNetPINVOKE.CSharp_RakNet_FileListNodeContext_dataLength_set(swigCPtr, value);
    } 
    get {
      uint ret = RakNetPINVOKE.CSharp_RakNet_FileListNodeContext_dataLength_get(swigCPtr);
      return ret;
    } 
  }

}

}
