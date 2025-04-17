using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Interaction;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004BB RID: 1211
	public class BuildUpdate_Cash : BuildUpdate_StoredItem
	{
		// Token: 0x06006A08 RID: 27144 RVA: 0x001DA530 File Offset: 0x001D8730
		// Note: this type is marked as 'beforefieldinit'.
		static BuildUpdate_Cash()
		{
			Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildUpdate_Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr);
			BuildUpdate_Cash.NativeFieldInfoPtr_amountIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, "amountIndex");
			BuildUpdate_Cash.NativeFieldInfoPtr_bills = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, "bills");
			BuildUpdate_Cash.NativeFieldInfoPtr_amountLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, "amountLabel");
			BuildUpdate_Cash.NativeMethodInfoPtr_get_placeAmount_Private_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676766);
			BuildUpdate_Cash.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676767);
			BuildUpdate_Cash.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676768);
			BuildUpdate_Cash.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676769);
			BuildUpdate_Cash.NativeMethodInfoPtr_UpdateLabel_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676770);
			BuildUpdate_Cash.NativeMethodInfoPtr_RefreshGhostModelAppearance_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676771);
			BuildUpdate_Cash.NativeMethodInfoPtr_Place_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676772);
			BuildUpdate_Cash.NativeMethodInfoPtr_PostPlace_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676773);
			BuildUpdate_Cash.NativeMethodInfoPtr_Stop_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676774);
			BuildUpdate_Cash.NativeMethodInfoPtr_GetRelevantCashBalane_Public_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676775);
			BuildUpdate_Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr, 100676776);
		}

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x06006A09 RID: 27145 RVA: 0x001DA678 File Offset: 0x001D8878
		public unsafe float placeAmount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 213627, RefRangeEnd = 213630, XrefRangeStart = 213623, XrefRangeEnd = 213627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr_get_placeAmount_Private_get_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06006A0A RID: 27146 RVA: 0x001DA6B4 File Offset: 0x001D88B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213630, XrefRangeEnd = 213652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A0B RID: 27147 RVA: 0x001DA6E8 File Offset: 0x001D88E8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213652, XrefRangeEnd = 213671, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Cash.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A0C RID: 27148 RVA: 0x001DA724 File Offset: 0x001D8924
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213671, XrefRangeEnd = 213706, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void LateUpdate()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Cash.NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A0D RID: 27149 RVA: 0x001DA760 File Offset: 0x001D8960
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 213724, RefRangeEnd = 213725, XrefRangeStart = 213706, XrefRangeEnd = 213724, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateLabel()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr_UpdateLabel_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A0E RID: 27150 RVA: 0x001DA794 File Offset: 0x001D8994
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 213741, RefRangeEnd = 213745, XrefRangeStart = 213725, XrefRangeEnd = 213741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RefreshGhostModelAppearance()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr_RefreshGhostModelAppearance_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A0F RID: 27151 RVA: 0x001DA7C8 File Offset: 0x001D89C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213745, XrefRangeEnd = 213782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Place()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Cash.NativeMethodInfoPtr_Place_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A10 RID: 27152 RVA: 0x001DA804 File Offset: 0x001D8A04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213782, XrefRangeEnd = 213791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PostPlace()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Cash.NativeMethodInfoPtr_PostPlace_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A11 RID: 27153 RVA: 0x001DA840 File Offset: 0x001D8A40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213791, XrefRangeEnd = 213793, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Stop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildUpdate_Cash.NativeMethodInfoPtr_Stop_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A12 RID: 27154 RVA: 0x001DA87C File Offset: 0x001D8A7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 213799, RefRangeEnd = 213801, XrefRangeStart = 213793, XrefRangeEnd = 213799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float GetRelevantCashBalane()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr_GetRelevantCashBalane_Public_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06006A13 RID: 27155 RVA: 0x001DA8B8 File Offset: 0x001D8AB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213801, XrefRangeEnd = 213811, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildUpdate_Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildUpdate_Cash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildUpdate_Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006A14 RID: 27156 RVA: 0x00032124 File Offset: 0x00030324
		public BuildUpdate_Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x06006A15 RID: 27157 RVA: 0x001DA8F4 File Offset: 0x001D8AF4
		// (set) Token: 0x06006A16 RID: 27158 RVA: 0x0003212D File Offset: 0x0003032D
		public unsafe int amountIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_amountIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_amountIndex)) = value;
			}
		}

		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x06006A17 RID: 27159 RVA: 0x001DA91C File Offset: 0x001D8B1C
		// (set) Token: 0x06006A18 RID: 27160 RVA: 0x00032148 File Offset: 0x00030348
		public unsafe List<Transform> bills
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_bills);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_bills), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x06006A19 RID: 27161 RVA: 0x001DA94C File Offset: 0x001D8B4C
		// (set) Token: 0x06006A1A RID: 27162 RVA: 0x00032167 File Offset: 0x00030367
		public unsafe WorldSpaceLabel amountLabel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_amountLabel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WorldSpaceLabel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BuildUpdate_Cash.NativeFieldInfoPtr_amountLabel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400489C RID: 18588
		private static readonly IntPtr NativeFieldInfoPtr_amountIndex;

		// Token: 0x0400489D RID: 18589
		private static readonly IntPtr NativeFieldInfoPtr_bills;

		// Token: 0x0400489E RID: 18590
		private static readonly IntPtr NativeFieldInfoPtr_amountLabel;

		// Token: 0x0400489F RID: 18591
		private static readonly IntPtr NativeMethodInfoPtr_get_placeAmount_Private_get_Single_0;

		// Token: 0x040048A0 RID: 18592
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x040048A1 RID: 18593
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x040048A2 RID: 18594
		private static readonly IntPtr NativeMethodInfoPtr_LateUpdate_Protected_Virtual_Void_0;

		// Token: 0x040048A3 RID: 18595
		private static readonly IntPtr NativeMethodInfoPtr_UpdateLabel_Private_Void_0;

		// Token: 0x040048A4 RID: 18596
		private static readonly IntPtr NativeMethodInfoPtr_RefreshGhostModelAppearance_Private_Void_0;

		// Token: 0x040048A5 RID: 18597
		private static readonly IntPtr NativeMethodInfoPtr_Place_Protected_Virtual_Void_0;

		// Token: 0x040048A6 RID: 18598
		private static readonly IntPtr NativeMethodInfoPtr_PostPlace_Protected_Virtual_Void_0;

		// Token: 0x040048A7 RID: 18599
		private static readonly IntPtr NativeMethodInfoPtr_Stop_Public_Virtual_Void_0;

		// Token: 0x040048A8 RID: 18600
		private static readonly IntPtr NativeMethodInfoPtr_GetRelevantCashBalane_Public_Single_0;

		// Token: 0x040048A9 RID: 18601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
