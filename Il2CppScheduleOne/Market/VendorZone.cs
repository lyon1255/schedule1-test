using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Market
{
	// Token: 0x0200037F RID: 895
	public class VendorZone : MonoBehaviour
	{
		// Token: 0x060045EC RID: 17900 RVA: 0x00157DC8 File Offset: 0x00155FC8
		// Note: this type is marked as 'beforefieldinit'.
		static VendorZone()
		{
			Il2CppClassPointerStore<VendorZone>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Market", "VendorZone");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VendorZone>.NativeClassPtr);
			VendorZone.NativeFieldInfoPtr_zoneCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, "zoneCollider");
			VendorZone.NativeFieldInfoPtr_doors = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, "doors");
			VendorZone.NativeFieldInfoPtr_openTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, "openTime");
			VendorZone.NativeFieldInfoPtr_closeTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, "closeTime");
			VendorZone.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100671892);
			VendorZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100671893);
			VendorZone.NativeMethodInfoPtr_MinPassed_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100671894);
			VendorZone.NativeMethodInfoPtr_IsPlayerWithinVendorZone_Private_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100671895);
			VendorZone.NativeMethodInfoPtr_SetDoorsActive_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100671896);
			VendorZone.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VendorZone>.NativeClassPtr, 100671897);
		}

		// Token: 0x17001519 RID: 5401
		// (get) Token: 0x060045ED RID: 17901 RVA: 0x00157EC0 File Offset: 0x001560C0
		public unsafe bool isOpen
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157714, XrefRangeEnd = 157720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendorZone.NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060045EE RID: 17902 RVA: 0x00157EFC File Offset: 0x001560FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157720, XrefRangeEnd = 157738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VendorZone.NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045EF RID: 17903 RVA: 0x00157F38 File Offset: 0x00156138
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157738, XrefRangeEnd = 157752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void MinPassed()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendorZone.NativeMethodInfoPtr_MinPassed_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F0 RID: 17904 RVA: 0x00157F6C File Offset: 0x0015616C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157752, XrefRangeEnd = 157760, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayerWithinVendorZone()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendorZone.NativeMethodInfoPtr_IsPlayerWithinVendorZone_Private_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060045F1 RID: 17905 RVA: 0x00157FA8 File Offset: 0x001561A8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 157766, RefRangeEnd = 157767, XrefRangeStart = 157760, XrefRangeEnd = 157766, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetDoorsActive(bool a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref a;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendorZone.NativeMethodInfoPtr_SetDoorsActive_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F2 RID: 17906 RVA: 0x00157FE8 File Offset: 0x001561E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 157767, XrefRangeEnd = 157775, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VendorZone() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VendorZone>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VendorZone.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060045F3 RID: 17907 RVA: 0x00022100 File Offset: 0x00020300
		public VendorZone(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001515 RID: 5397
		// (get) Token: 0x060045F4 RID: 17908 RVA: 0x00158024 File Offset: 0x00156224
		// (set) Token: 0x060045F5 RID: 17909 RVA: 0x00022109 File Offset: 0x00020309
		public unsafe BoxCollider zoneCollider
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_zoneCollider);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BoxCollider>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_zoneCollider), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001516 RID: 5398
		// (get) Token: 0x060045F6 RID: 17910 RVA: 0x00158054 File Offset: 0x00156254
		// (set) Token: 0x060045F7 RID: 17911 RVA: 0x00022128 File Offset: 0x00020328
		public unsafe List<GameObject> doors
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_doors);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<GameObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_doors), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001517 RID: 5399
		// (get) Token: 0x060045F8 RID: 17912 RVA: 0x00158084 File Offset: 0x00156284
		// (set) Token: 0x060045F9 RID: 17913 RVA: 0x00022147 File Offset: 0x00020347
		public unsafe int openTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_openTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_openTime)) = value;
			}
		}

		// Token: 0x17001518 RID: 5400
		// (get) Token: 0x060045FA RID: 17914 RVA: 0x001580AC File Offset: 0x001562AC
		// (set) Token: 0x060045FB RID: 17915 RVA: 0x00022162 File Offset: 0x00020362
		public unsafe int closeTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_closeTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(VendorZone.NativeFieldInfoPtr_closeTime)) = value;
			}
		}

		// Token: 0x04002EEE RID: 12014
		private static readonly IntPtr NativeFieldInfoPtr_zoneCollider;

		// Token: 0x04002EEF RID: 12015
		private static readonly IntPtr NativeFieldInfoPtr_doors;

		// Token: 0x04002EF0 RID: 12016
		private static readonly IntPtr NativeFieldInfoPtr_openTime;

		// Token: 0x04002EF1 RID: 12017
		private static readonly IntPtr NativeFieldInfoPtr_closeTime;

		// Token: 0x04002EF2 RID: 12018
		private static readonly IntPtr NativeMethodInfoPtr_get_isOpen_Public_get_Boolean_0;

		// Token: 0x04002EF3 RID: 12019
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_New_Void_0;

		// Token: 0x04002EF4 RID: 12020
		private static readonly IntPtr NativeMethodInfoPtr_MinPassed_Private_Void_0;

		// Token: 0x04002EF5 RID: 12021
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayerWithinVendorZone_Private_Boolean_0;

		// Token: 0x04002EF6 RID: 12022
		private static readonly IntPtr NativeMethodInfoPtr_SetDoorsActive_Private_Void_Boolean_0;

		// Token: 0x04002EF7 RID: 12023
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
