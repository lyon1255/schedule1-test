using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace Il2CppScheduleOne.AvatarFramework
{
	// Token: 0x020005F9 RID: 1529
	public class Hair : Accessory
	{
		// Token: 0x060086D4 RID: 34516 RVA: 0x0023A14C File Offset: 0x0023834C
		// Note: this type is marked as 'beforefieldinit'.
		static Hair()
		{
			Il2CppClassPointerStore<Hair>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.AvatarFramework", "Hair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Hair>.NativeClassPtr);
			Hair.NativeFieldInfoPtr__BlockedByHat_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hair>.NativeClassPtr, "<BlockedByHat>k__BackingField");
			Hair.NativeFieldInfoPtr_hairToHide = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Hair>.NativeClassPtr, "hairToHide");
			Hair.NativeMethodInfoPtr_get_BlockedByHat_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680129);
			Hair.NativeMethodInfoPtr_set_BlockedByHat_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680130);
			Hair.NativeMethodInfoPtr_SetBlockedByHat_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680131);
			Hair.NativeMethodInfoPtr_BlockHair_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680132);
			Hair.NativeMethodInfoPtr_UnBlockHair_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680133);
			Hair.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Hair>.NativeClassPtr, 100680134);
		}

		// Token: 0x170028FC RID: 10492
		// (get) Token: 0x060086D5 RID: 34517 RVA: 0x0023A21C File Offset: 0x0023841C
		// (set) Token: 0x060086D6 RID: 34518 RVA: 0x0023A258 File Offset: 0x00238458
		public unsafe bool BlockedByHat
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hair.NativeMethodInfoPtr_get_BlockedByHat_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hair.NativeMethodInfoPtr_set_BlockedByHat_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060086D7 RID: 34519 RVA: 0x0023A298 File Offset: 0x00238498
		[CallerCount(0)]
		public unsafe void SetBlockedByHat(bool blocked)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref blocked;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hair.NativeMethodInfoPtr_SetBlockedByHat_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086D8 RID: 34520 RVA: 0x0023A2D8 File Offset: 0x002384D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250960, XrefRangeEnd = 250962, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void BlockHair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hair.NativeMethodInfoPtr_BlockHair_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086D9 RID: 34521 RVA: 0x0023A314 File Offset: 0x00238514
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 250962, XrefRangeEnd = 250964, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void UnBlockHair()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Hair.NativeMethodInfoPtr_UnBlockHair_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086DA RID: 34522 RVA: 0x0023A350 File Offset: 0x00238550
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 248882, RefRangeEnd = 248883, XrefRangeStart = 248882, XrefRangeEnd = 248883, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Hair() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Hair>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Hair.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060086DB RID: 34523 RVA: 0x0004022C File Offset: 0x0003E42C
		public Hair(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170028FA RID: 10490
		// (get) Token: 0x060086DC RID: 34524 RVA: 0x0023A38C File Offset: 0x0023858C
		// (set) Token: 0x060086DD RID: 34525 RVA: 0x00040235 File Offset: 0x0003E435
		public unsafe bool _BlockedByHat_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hair.NativeFieldInfoPtr__BlockedByHat_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hair.NativeFieldInfoPtr__BlockedByHat_k__BackingField)) = value;
			}
		}

		// Token: 0x170028FB RID: 10491
		// (get) Token: 0x060086DE RID: 34526 RVA: 0x0023A3B4 File Offset: 0x002385B4
		// (set) Token: 0x060086DF RID: 34527 RVA: 0x00040250 File Offset: 0x0003E450
		public unsafe Il2CppReferenceArray<GameObject> hairToHide
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hair.NativeFieldInfoPtr_hairToHide);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Hair.NativeFieldInfoPtr_hairToHide), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04005BC1 RID: 23489
		private static readonly IntPtr NativeFieldInfoPtr__BlockedByHat_k__BackingField;

		// Token: 0x04005BC2 RID: 23490
		private static readonly IntPtr NativeFieldInfoPtr_hairToHide;

		// Token: 0x04005BC3 RID: 23491
		private static readonly IntPtr NativeMethodInfoPtr_get_BlockedByHat_Public_get_Boolean_0;

		// Token: 0x04005BC4 RID: 23492
		private static readonly IntPtr NativeMethodInfoPtr_set_BlockedByHat_Protected_set_Void_Boolean_0;

		// Token: 0x04005BC5 RID: 23493
		private static readonly IntPtr NativeMethodInfoPtr_SetBlockedByHat_Public_Void_Boolean_0;

		// Token: 0x04005BC6 RID: 23494
		private static readonly IntPtr NativeMethodInfoPtr_BlockHair_Protected_Virtual_New_Void_0;

		// Token: 0x04005BC7 RID: 23495
		private static readonly IntPtr NativeMethodInfoPtr_UnBlockHair_Protected_Virtual_New_Void_0;

		// Token: 0x04005BC8 RID: 23496
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
