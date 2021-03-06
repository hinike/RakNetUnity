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

public class PluginInterface2 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PluginInterface2(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PluginInterface2 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PluginInterface2() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.CSharp_RakNet_delete_PluginInterface2(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PluginInterface2() : this(RakNetPINVOKE.CSharp_RakNet_new_PluginInterface2(), true) {
  }

  public virtual bool UsesReliabilityLayer() {
    bool ret = RakNetPINVOKE.CSharp_RakNet_PluginInterface2_UsesReliabilityLayer(swigCPtr);
    return ret;
  }

  public virtual void OnReliabilityLayerNotification(string errorMessage, uint bitsUsed, SystemAddress remoteSystemAddress, bool isError) {
    RakNetPINVOKE.CSharp_RakNet_PluginInterface2_OnReliabilityLayerNotification(swigCPtr, errorMessage, bitsUsed, SystemAddress.getCPtr(remoteSystemAddress), isError);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public RakPeerInterface GetRakPeerInterface() {
    global::System.IntPtr cPtr = RakNetPINVOKE.CSharp_RakNet_PluginInterface2_GetRakPeerInterface(swigCPtr);
    RakPeerInterface ret = (cPtr == global::System.IntPtr.Zero) ? null : new RakPeerInterface(cPtr, false);
    return ret;
  }

  public RakNetGUID GetMyGUIDUnified() {
    RakNetGUID ret = new RakNetGUID(RakNetPINVOKE.CSharp_RakNet_PluginInterface2_GetMyGUIDUnified(swigCPtr), true);
    return ret;
  }

  public void SetTCPInterface(SWIGTYPE_p_RakNet__TCPInterface ptr) {
    RakNetPINVOKE.CSharp_RakNet_PluginInterface2_SetTCPInterface(swigCPtr, SWIGTYPE_p_RakNet__TCPInterface.getCPtr(ptr));
  }

}

}
