using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Persistence
{
	// Token: 0x0200021B RID: 539
	public class LoadEventTransmitter : MonoBehaviour
	{
		// Token: 0x06002CB0 RID: 11440 RVA: 0x000FE754 File Offset: 0x000FC954
		// Note: this type is marked as 'beforefieldinit'.
		static LoadEventTransmitter()
		{
			Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence", "LoadEventTransmitter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr);
			LoadEventTransmitter.NativeFieldInfoPtr_onLoadComplete = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr, "onLoadComplete");
			LoadEventTransmitter.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr, 100668344);
			LoadEventTransmitter.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr, 100668345);
			LoadEventTransmitter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr, 100668346);
		}

		// Token: 0x06002CB1 RID: 11441 RVA: 0x000FE7D4 File Offset: 0x000FC9D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124543, XrefRangeEnd = 124555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadEventTransmitter.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CB2 RID: 11442 RVA: 0x000FE808 File Offset: 0x000FCA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 124555, XrefRangeEnd = 124556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnLoadComplete()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadEventTransmitter.NativeMethodInfoPtr_OnLoadComplete_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CB3 RID: 11443 RVA: 0x000FE83C File Offset: 0x000FCA3C
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LoadEventTransmitter() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LoadEventTransmitter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LoadEventTransmitter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002CB4 RID: 11444 RVA: 0x000180BB File Offset: 0x000162BB
		public LoadEventTransmitter(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06002CB5 RID: 11445 RVA: 0x000FE878 File Offset: 0x000FCA78
		// (set) Token: 0x06002CB6 RID: 11446 RVA: 0x000180C4 File Offset: 0x000162C4
		public unsafe UnityEvent onLoadComplete
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadEventTransmitter.NativeFieldInfoPtr_onLoadComplete);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LoadEventTransmitter.NativeFieldInfoPtr_onLoadComplete), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DAC RID: 7596
		private static readonly IntPtr NativeFieldInfoPtr_onLoadComplete;

		// Token: 0x04001DAD RID: 7597
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x04001DAE RID: 7598
		private static readonly IntPtr NativeMethodInfoPtr_OnLoadComplete_Private_Void_0;

		// Token: 0x04001DAF RID: 7599
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
