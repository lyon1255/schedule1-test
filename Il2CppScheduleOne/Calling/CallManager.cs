using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.DevUtilities;
using Il2CppScheduleOne.ScriptableObjects;

namespace Il2CppScheduleOne.Calling
{
	// Token: 0x020004AC RID: 1196
	public class CallManager : Singleton<CallManager>
	{
		// Token: 0x06006979 RID: 27001 RVA: 0x001D85E4 File Offset: 0x001D67E4
		// Note: this type is marked as 'beforefieldinit'.
		static CallManager()
		{
			Il2CppClassPointerStore<CallManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Calling", "CallManager");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CallManager>.NativeClassPtr);
			CallManager.NativeFieldInfoPtr__QueuedCallData_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CallManager>.NativeClassPtr, "<QueuedCallData>k__BackingField");
			CallManager.NativeMethodInfoPtr_get_QueuedCallData_Public_get_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676697);
			CallManager.NativeMethodInfoPtr_set_QueuedCallData_Private_set_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676698);
			CallManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676699);
			CallManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676700);
			CallManager.NativeMethodInfoPtr_QueueCall_Public_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676701);
			CallManager.NativeMethodInfoPtr_ClearQueuedCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676702);
			CallManager.NativeMethodInfoPtr_CallCompleted_Private_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676703);
			CallManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CallManager>.NativeClassPtr, 100676704);
		}

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x0600697A RID: 27002 RVA: 0x001D86C8 File Offset: 0x001D68C8
		// (set) Token: 0x0600697B RID: 27003 RVA: 0x001D8708 File Offset: 0x001D6908
		public unsafe PhoneCallData QueuedCallData
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19639, RefRangeEnd = 19642, XrefRangeStart = 19639, XrefRangeEnd = 19642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_get_QueuedCallData_Public_get_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr3) : null;
			}
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_set_QueuedCallData_Private_set_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600697C RID: 27004 RVA: 0x001D874C File Offset: 0x001D694C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212762, XrefRangeEnd = 212798, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallManager.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600697D RID: 27005 RVA: 0x001D8788 File Offset: 0x001D6988
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212798, XrefRangeEnd = 212825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CallManager.NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600697E RID: 27006 RVA: 0x001D87C4 File Offset: 0x001D69C4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 19643, RefRangeEnd = 19646, XrefRangeStart = 19643, XrefRangeEnd = 19646, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void QueueCall(PhoneCallData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_QueueCall_Public_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600697F RID: 27007 RVA: 0x001D8808 File Offset: 0x001D6A08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 212826, RefRangeEnd = 212827, XrefRangeStart = 212825, XrefRangeEnd = 212826, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearQueuedCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_ClearQueuedCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006980 RID: 27008 RVA: 0x001D883C File Offset: 0x001D6A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212827, XrefRangeEnd = 212832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CallCompleted(PhoneCallData call)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(call);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr_CallCompleted_Private_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006981 RID: 27009 RVA: 0x001D8880 File Offset: 0x001D6A80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 212832, XrefRangeEnd = 212835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CallManager() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CallManager>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CallManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006982 RID: 27010 RVA: 0x00031D98 File Offset: 0x0002FF98
		public CallManager(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x06006983 RID: 27011 RVA: 0x001D88BC File Offset: 0x001D6ABC
		// (set) Token: 0x06006984 RID: 27012 RVA: 0x00031DA1 File Offset: 0x0002FFA1
		public unsafe PhoneCallData _QueuedCallData_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallManager.NativeFieldInfoPtr__QueuedCallData_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhoneCallData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CallManager.NativeFieldInfoPtr__QueuedCallData_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04004844 RID: 18500
		private static readonly IntPtr NativeFieldInfoPtr__QueuedCallData_k__BackingField;

		// Token: 0x04004845 RID: 18501
		private static readonly IntPtr NativeMethodInfoPtr_get_QueuedCallData_Public_get_PhoneCallData_0;

		// Token: 0x04004846 RID: 18502
		private static readonly IntPtr NativeMethodInfoPtr_set_QueuedCallData_Private_set_Void_PhoneCallData_0;

		// Token: 0x04004847 RID: 18503
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04004848 RID: 18504
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Protected_Virtual_Void_0;

		// Token: 0x04004849 RID: 18505
		private static readonly IntPtr NativeMethodInfoPtr_QueueCall_Public_Void_PhoneCallData_0;

		// Token: 0x0400484A RID: 18506
		private static readonly IntPtr NativeMethodInfoPtr_ClearQueuedCall_Public_Void_0;

		// Token: 0x0400484B RID: 18507
		private static readonly IntPtr NativeMethodInfoPtr_CallCompleted_Private_Void_PhoneCallData_0;

		// Token: 0x0400484C RID: 18508
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
