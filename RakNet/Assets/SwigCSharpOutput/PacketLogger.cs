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

public class PacketLogger : PluginInterface2 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal PacketLogger(global::System.IntPtr cPtr, bool cMemoryOwn) : base(RakNetPINVOKE.CSharp_RakNet_PacketLogger_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PacketLogger obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PacketLogger() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          RakNetPINVOKE.CSharp_RakNet_delete_PacketLogger(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public virtual void FormatLine(ref string preInitializedStringBigEnoughToFitResult, string dir, string type, uint packet, uint frame, byte messageIdentifier, uint bitLen, ulong time, SystemAddress local, SystemAddress remote, uint splitPacketId, uint splitPacketIndex, uint splitPacketCount, uint orderingIndex) {
	preInitializedStringBigEnoughToFitResult=FormatLineHelper( preInitializedStringBigEnoughToFitResult, dir, type,  packet, frame,  messageIdentifier, bitLen,  time, local,  remote, splitPacketId,  splitPacketIndex, splitPacketCount,  orderingIndex);
  }

  public virtual void FormatLine(ref string preInitializedStringBigEnoughToFitResult, string dir, string type, uint packet, uint frame, string idToPrint, uint bitLen, ulong time, SystemAddress local, SystemAddress remote, uint splitPacketId, uint splitPacketIndex, uint splitPacketCount, uint orderingIndex) {
  	preInitializedStringBigEnoughToFitResult=FormatLineHelper( preInitializedStringBigEnoughToFitResult,  dir, type,  packet, frame,  idToPrint, bitLen,  time, local,  remote, splitPacketId,  splitPacketIndex, splitPacketCount,  orderingIndex);
  }

  public static PacketLogger GetInstance() {
    global::System.IntPtr cPtr = RakNetPINVOKE.CSharp_RakNet_PacketLogger_GetInstance();
    PacketLogger ret = (cPtr == global::System.IntPtr.Zero) ? null : new PacketLogger(cPtr, false);
    return ret;
  }

  public static void DestroyInstance(PacketLogger i) {
    RakNetPINVOKE.CSharp_RakNet_PacketLogger_DestroyInstance(PacketLogger.getCPtr(i));
  }

  public PacketLogger() : this(RakNetPINVOKE.CSharp_RakNet_new_PacketLogger(), true) {
  }

  public override void OnReliabilityLayerNotification(string errorMessage, uint bitsUsed, SystemAddress remoteSystemAddress, bool isError) {
    RakNetPINVOKE.CSharp_RakNet_PacketLogger_OnReliabilityLayerNotification(swigCPtr, errorMessage, bitsUsed, SystemAddress.getCPtr(remoteSystemAddress), isError);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void LogHeader() {
    RakNetPINVOKE.CSharp_RakNet_PacketLogger_LogHeader(swigCPtr);
  }

  public virtual void WriteLog(string str) {
    RakNetPINVOKE.CSharp_RakNet_PacketLogger_WriteLog(swigCPtr, str);
  }

  public virtual void WriteMiscellaneous(string type, string msg) {
    RakNetPINVOKE.CSharp_RakNet_PacketLogger_WriteMiscellaneous(swigCPtr, type, msg);
  }

  public virtual void SetPrintID(bool print) {
    RakNetPINVOKE.CSharp_RakNet_PacketLogger_SetPrintID(swigCPtr, print);
  }

  public virtual void SetPrintAcks(bool print) {
    RakNetPINVOKE.CSharp_RakNet_PacketLogger_SetPrintAcks(swigCPtr, print);
  }

  public virtual void SetPrefix(string _prefix) {
    RakNetPINVOKE.CSharp_RakNet_PacketLogger_SetPrefix(swigCPtr, _prefix);
  }

  public virtual void SetSuffix(string _suffix) {
    RakNetPINVOKE.CSharp_RakNet_PacketLogger_SetSuffix(swigCPtr, _suffix);
  }

  public static string BaseIDTOString(byte Id) {
    string ret = RakNetPINVOKE.CSharp_RakNet_PacketLogger_BaseIDTOString(Id);
    return ret;
  }

  public void SetLogDirectMessages(bool send) {
    RakNetPINVOKE.CSharp_RakNet_PacketLogger_SetLogDirectMessages(swigCPtr, send);
  }

  private string FormatLineHelper(string into, string dir, string type, uint packet, uint frame, byte messageIdentifier, uint bitLen, ulong time, SystemAddress local, SystemAddress remote, uint splitPacketId, uint splitPacketIndex, uint splitPacketCount, uint orderingIndex) {
    string ret = RakNetPINVOKE.CSharp_RakNet_PacketLogger_FormatLineHelper__SWIG_0(swigCPtr, into, dir, type, packet, frame, messageIdentifier, bitLen, time, SystemAddress.getCPtr(local), SystemAddress.getCPtr(remote), splitPacketId, splitPacketIndex, splitPacketCount, orderingIndex);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private string FormatLineHelper(string into, string dir, string type, uint packet, uint frame, string idToPrint, uint bitLen, ulong time, SystemAddress local, SystemAddress remote, uint splitPacketId, uint splitPacketIndex, uint splitPacketCount, uint orderingIndex) {
    string ret = RakNetPINVOKE.CSharp_RakNet_PacketLogger_FormatLineHelper__SWIG_1(swigCPtr, into, dir, type, packet, frame, idToPrint, bitLen, time, SystemAddress.getCPtr(local), SystemAddress.getCPtr(remote), splitPacketId, splitPacketIndex, splitPacketCount, orderingIndex);
    if (RakNetPINVOKE.SWIGPendingException.Pending) throw RakNetPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}