using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ScriptableObjects;
using UnityEngine;

namespace Il2CppScheduleOne.Tools
{
	// Token: 0x02000544 RID: 1348
	public class PhoneCallUtility : MonoBehaviour
	{
		// Token: 0x06007758 RID: 30552 RVA: 0x00205D14 File Offset: 0x00203F14
		// Note: this type is marked as 'beforefieldinit'.
		static PhoneCallUtility()
		{
			Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Tools", "PhoneCallUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr);
			PhoneCallUtility.NativeMethodInfoPtr_PromptCall_Public_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678330);
			PhoneCallUtility.NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678331);
			PhoneCallUtility.NativeMethodInfoPtr_SetQueuedCall_Public_Void_PhoneCallData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678332);
			PhoneCallUtility.NativeMethodInfoPtr_ClearCall_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678333);
			PhoneCallUtility.NativeMethodInfoPtr_SetPhoneOpenable_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678334);
			PhoneCallUtility.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr, 100678335);
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x00205DBC File Offset: 0x00203FBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231552, XrefRangeEnd = 231558, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PromptCall(PhoneCallData callData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_PromptCall_Public_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x00205E00 File Offset: 0x00204000
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231558, XrefRangeEnd = 231564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void StartCall(PhoneCallData callData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600775B RID: 30555 RVA: 0x00205E44 File Offset: 0x00204044
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231564, XrefRangeEnd = 231570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetQueuedCall(PhoneCallData callData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(callData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_SetQueuedCall_Public_Void_PhoneCallData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600775C RID: 30556 RVA: 0x00205E88 File Offset: 0x00204088
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 231570, XrefRangeEnd = 231576, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearCall()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_ClearCall_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600775D RID: 30557 RVA: 0x00205EBC File Offset: 0x002040BC
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetPhoneOpenable(bool openable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref openable;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr_SetPhoneOpenable_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600775E RID: 30558 RVA: 0x00205EFC File Offset: 0x002040FC
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PhoneCallUtility() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhoneCallUtility>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhoneCallUtility.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x0003885B File Offset: 0x00036A5B
		public PhoneCallUtility(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04005173 RID: 20851
		private static readonly IntPtr NativeMethodInfoPtr_PromptCall_Public_Void_PhoneCallData_0;

		// Token: 0x04005174 RID: 20852
		private static readonly IntPtr NativeMethodInfoPtr_StartCall_Public_Void_PhoneCallData_0;

		// Token: 0x04005175 RID: 20853
		private static readonly IntPtr NativeMethodInfoPtr_SetQueuedCall_Public_Void_PhoneCallData_0;

		// Token: 0x04005176 RID: 20854
		private static readonly IntPtr NativeMethodInfoPtr_ClearCall_Public_Void_0;

		// Token: 0x04005177 RID: 20855
		private static readonly IntPtr NativeMethodInfoPtr_SetPhoneOpenable_Public_Void_Boolean_0;

		// Token: 0x04005178 RID: 20856
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
