using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Equipping;
using Il2CppScheduleOne.ItemFramework;
using Il2CppSystem.Collections.Generic;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.Cash
{
	// Token: 0x02000764 RID: 1892
	public class Equippable_Cash : Equippable_Viewmodel
	{
		// Token: 0x0600B3B9 RID: 46009 RVA: 0x002CCBBC File Offset: 0x002CADBC
		// Note: this type is marked as 'beforefieldinit'.
		static Equippable_Cash()
		{
			Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.Cash", "Equippable_Cash");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr);
			Equippable_Cash.NativeFieldInfoPtr_amountIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "amountIndex");
			Equippable_Cash.NativeFieldInfoPtr_Container_Under100 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "Container_Under100");
			Equippable_Cash.NativeFieldInfoPtr_SingleNotes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "SingleNotes");
			Equippable_Cash.NativeFieldInfoPtr_Container_100_300 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "Container_100_300");
			Equippable_Cash.NativeFieldInfoPtr_Under300Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "Under300Stacks");
			Equippable_Cash.NativeFieldInfoPtr_Container_300Plus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "Container_300Plus");
			Equippable_Cash.NativeFieldInfoPtr_PlusStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, "PlusStacks");
			Equippable_Cash.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100685449);
			Equippable_Cash.NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100685450);
			Equippable_Cash.NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100685451);
			Equippable_Cash.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100685452);
			Equippable_Cash.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100685453);
			Equippable_Cash.NativeMethodInfoPtr_UpdateCashVisuals_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100685454);
			Equippable_Cash.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr, 100685455);
		}

		// Token: 0x0600B3BA RID: 46010 RVA: 0x002CCD04 File Offset: 0x002CAF04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308542, XrefRangeEnd = 308547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cash.NativeMethodInfoPtr_Update_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3BB RID: 46011 RVA: 0x002CCD40 File Offset: 0x002CAF40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308547, XrefRangeEnd = 308553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartBuildingStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cash.NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3BC RID: 46012 RVA: 0x002CCD7C File Offset: 0x002CAF7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308553, XrefRangeEnd = 308559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopBuildingStoredItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cash.NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3BD RID: 46013 RVA: 0x002CCDB8 File Offset: 0x002CAFB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308559, XrefRangeEnd = 308575, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Equip(ItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cash.NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3BE RID: 46014 RVA: 0x002CCE08 File Offset: 0x002CB008
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308575, XrefRangeEnd = 308590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Unequip()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Equippable_Cash.NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3BF RID: 46015 RVA: 0x002CCE44 File Offset: 0x002CB044
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308652, RefRangeEnd = 308653, XrefRangeStart = 308590, XrefRangeEnd = 308652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UpdateCashVisuals()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cash.NativeMethodInfoPtr_UpdateCashVisuals_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3C0 RID: 46016 RVA: 0x002CCE78 File Offset: 0x002CB078
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Equippable_Cash() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Equippable_Cash>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Equippable_Cash.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B3C1 RID: 46017 RVA: 0x00058155 File Offset: 0x00056355
		public Equippable_Cash(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x170037B8 RID: 14264
		// (get) Token: 0x0600B3C2 RID: 46018 RVA: 0x002CCEB4 File Offset: 0x002CB0B4
		// (set) Token: 0x0600B3C3 RID: 46019 RVA: 0x0005815E File Offset: 0x0005635E
		public unsafe int amountIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_amountIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_amountIndex)) = value;
			}
		}

		// Token: 0x170037B9 RID: 14265
		// (get) Token: 0x0600B3C4 RID: 46020 RVA: 0x002CCEDC File Offset: 0x002CB0DC
		// (set) Token: 0x0600B3C5 RID: 46021 RVA: 0x00058179 File Offset: 0x00056379
		public unsafe Transform Container_Under100
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_Under100);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_Under100), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037BA RID: 14266
		// (get) Token: 0x0600B3C6 RID: 46022 RVA: 0x002CCF0C File Offset: 0x002CB10C
		// (set) Token: 0x0600B3C7 RID: 46023 RVA: 0x00058198 File Offset: 0x00056398
		public unsafe List<Transform> SingleNotes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_SingleNotes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_SingleNotes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037BB RID: 14267
		// (get) Token: 0x0600B3C8 RID: 46024 RVA: 0x002CCF3C File Offset: 0x002CB13C
		// (set) Token: 0x0600B3C9 RID: 46025 RVA: 0x000581B7 File Offset: 0x000563B7
		public unsafe Transform Container_100_300
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_100_300);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_100_300), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037BC RID: 14268
		// (get) Token: 0x0600B3CA RID: 46026 RVA: 0x002CCF6C File Offset: 0x002CB16C
		// (set) Token: 0x0600B3CB RID: 46027 RVA: 0x000581D6 File Offset: 0x000563D6
		public unsafe List<Transform> Under300Stacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Under300Stacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Under300Stacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037BD RID: 14269
		// (get) Token: 0x0600B3CC RID: 46028 RVA: 0x002CCF9C File Offset: 0x002CB19C
		// (set) Token: 0x0600B3CD RID: 46029 RVA: 0x000581F5 File Offset: 0x000563F5
		public unsafe Transform Container_300Plus
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_300Plus);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Transform>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_Container_300Plus), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170037BE RID: 14270
		// (get) Token: 0x0600B3CE RID: 46030 RVA: 0x002CCFCC File Offset: 0x002CB1CC
		// (set) Token: 0x0600B3CF RID: 46031 RVA: 0x00058214 File Offset: 0x00056414
		public unsafe List<Transform> PlusStacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_PlusStacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Transform>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Equippable_Cash.NativeFieldInfoPtr_PlusStacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04007935 RID: 31029
		private static readonly IntPtr NativeFieldInfoPtr_amountIndex;

		// Token: 0x04007936 RID: 31030
		private static readonly IntPtr NativeFieldInfoPtr_Container_Under100;

		// Token: 0x04007937 RID: 31031
		private static readonly IntPtr NativeFieldInfoPtr_SingleNotes;

		// Token: 0x04007938 RID: 31032
		private static readonly IntPtr NativeFieldInfoPtr_Container_100_300;

		// Token: 0x04007939 RID: 31033
		private static readonly IntPtr NativeFieldInfoPtr_Under300Stacks;

		// Token: 0x0400793A RID: 31034
		private static readonly IntPtr NativeFieldInfoPtr_Container_300Plus;

		// Token: 0x0400793B RID: 31035
		private static readonly IntPtr NativeFieldInfoPtr_PlusStacks;

		// Token: 0x0400793C RID: 31036
		private static readonly IntPtr NativeMethodInfoPtr_Update_Protected_Virtual_Void_0;

		// Token: 0x0400793D RID: 31037
		private static readonly IntPtr NativeMethodInfoPtr_StartBuildingStoredItem_Protected_Virtual_Void_0;

		// Token: 0x0400793E RID: 31038
		private static readonly IntPtr NativeMethodInfoPtr_StopBuildingStoredItem_Protected_Virtual_Void_0;

		// Token: 0x0400793F RID: 31039
		private static readonly IntPtr NativeMethodInfoPtr_Equip_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04007940 RID: 31040
		private static readonly IntPtr NativeMethodInfoPtr_Unequip_Public_Virtual_Void_0;

		// Token: 0x04007941 RID: 31041
		private static readonly IntPtr NativeMethodInfoPtr_UpdateCashVisuals_Private_Void_0;

		// Token: 0x04007942 RID: 31042
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
