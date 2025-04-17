﻿using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.PlayerTasks.Tasks
{
	// Token: 0x02000211 RID: 529
	public class PourIntoPotTask : Task
	{
		// Token: 0x06002C0A RID: 11274 RVA: 0x000FBEC0 File Offset: 0x000FA0C0
		// Note: this type is marked as 'beforefieldinit'.
		static PourIntoPotTask()
		{
			Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.PlayerTasks.Tasks", "PourIntoPotTask");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr);
			PourIntoPotTask.NativeFieldInfoPtr__TaskName_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, "<TaskName>k__BackingField");
			PourIntoPotTask.NativeFieldInfoPtr_pot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, "pot");
			PourIntoPotTask.NativeFieldInfoPtr_item = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, "item");
			PourIntoPotTask.NativeFieldInfoPtr_pourable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, "pourable");
			PourIntoPotTask.NativeFieldInfoPtr__UseCoverage_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, "<UseCoverage>k__BackingField");
			PourIntoPotTask.NativeFieldInfoPtr__FailOnEmpty_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, "<FailOnEmpty>k__BackingField");
			PourIntoPotTask.NativeFieldInfoPtr__CameraPosition_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, "<CameraPosition>k__BackingField");
			PourIntoPotTask.NativeFieldInfoPtr_removeItemAfterInitialPour = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, "removeItemAfterInitialPour");
			PourIntoPotTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668252);
			PourIntoPotTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668253);
			PourIntoPotTask.NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668254);
			PourIntoPotTask.NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668255);
			PourIntoPotTask.NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_New_get_ECameraPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668256);
			PourIntoPotTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668257);
			PourIntoPotTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668258);
			PourIntoPotTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668259);
			PourIntoPotTask.NativeMethodInfoPtr_OnInitialPour_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668260);
			PourIntoPotTask.NativeMethodInfoPtr_RemoveItem_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668261);
			PourIntoPotTask.NativeMethodInfoPtr_FullyCovered_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr, 100668262);
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06002C0B RID: 11275 RVA: 0x000FC06C File Offset: 0x000FA26C
		// (set) Token: 0x06002C0C RID: 11276 RVA: 0x000FC0B0 File Offset: 0x000FA2B0
		public unsafe override string TaskName
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourIntoPotTask.NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourIntoPotTask.NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06002C0D RID: 11277 RVA: 0x000FC100 File Offset: 0x000FA300
		public unsafe virtual bool UseCoverage
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourIntoPotTask.NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06002C0E RID: 11278 RVA: 0x000FC148 File Offset: 0x000FA348
		public unsafe virtual bool FailOnEmpty
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourIntoPotTask.NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06002C0F RID: 11279 RVA: 0x000FC190 File Offset: 0x000FA390
		public unsafe virtual Pot.ECameraPosition CameraPosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourIntoPotTask.NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_New_get_ECameraPosition_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C10 RID: 11280 RVA: 0x000FC1D8 File Offset: 0x000FA3D8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 123362, RefRangeEnd = 123367, XrefRangeStart = 123255, XrefRangeEnd = 123362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PourIntoPotTask(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PourIntoPotTask>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_pot);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_itemInstance);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_pourablePrefab);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourIntoPotTask.NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C11 RID: 11281 RVA: 0x000FC248 File Offset: 0x000FA448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123367, XrefRangeEnd = 123368, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourIntoPotTask.NativeMethodInfoPtr_Update_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C12 RID: 11282 RVA: 0x000FC284 File Offset: 0x000FA484
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 123414, RefRangeEnd = 123417, XrefRangeStart = 123368, XrefRangeEnd = 123414, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StopTask()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourIntoPotTask.NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C13 RID: 11283 RVA: 0x000FC2C0 File Offset: 0x000FA4C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123417, XrefRangeEnd = 123418, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void OnInitialPour()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourIntoPotTask.NativeMethodInfoPtr_OnInitialPour_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C14 RID: 11284 RVA: 0x000FC2F4 File Offset: 0x000FA4F4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 123443, RefRangeEnd = 123445, XrefRangeStart = 123418, XrefRangeEnd = 123443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PourIntoPotTask.NativeMethodInfoPtr_RemoveItem_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C15 RID: 11285 RVA: 0x000FC328 File Offset: 0x000FA528
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void FullyCovered()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PourIntoPotTask.NativeMethodInfoPtr_FullyCovered_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C16 RID: 11286 RVA: 0x00017CEF File Offset: 0x00015EEF
		public PourIntoPotTask(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06002C17 RID: 11287 RVA: 0x000FC364 File Offset: 0x000FA564
		// (set) Token: 0x06002C18 RID: 11288 RVA: 0x00017CF8 File Offset: 0x00015EF8
		public new unsafe string _TaskName_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr__TaskName_k__BackingField);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr__TaskName_k__BackingField), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x000FC38C File Offset: 0x000FA58C
		// (set) Token: 0x06002C1A RID: 11290 RVA: 0x00017D17 File Offset: 0x00015F17
		public unsafe Pot pot
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr_pot);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pot>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr_pot), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA7 RID: 3751
		// (get) Token: 0x06002C1B RID: 11291 RVA: 0x000FC3BC File Offset: 0x000FA5BC
		// (set) Token: 0x06002C1C RID: 11292 RVA: 0x00017D36 File Offset: 0x00015F36
		public unsafe ItemInstance item
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr_item);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr_item), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA8 RID: 3752
		// (get) Token: 0x06002C1D RID: 11293 RVA: 0x000FC3EC File Offset: 0x000FA5EC
		// (set) Token: 0x06002C1E RID: 11294 RVA: 0x00017D55 File Offset: 0x00015F55
		public unsafe Pourable pourable
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr_pourable);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Pourable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr_pourable), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EA9 RID: 3753
		// (get) Token: 0x06002C1F RID: 11295 RVA: 0x000FC41C File Offset: 0x000FA61C
		// (set) Token: 0x06002C20 RID: 11296 RVA: 0x00017D74 File Offset: 0x00015F74
		public unsafe bool _UseCoverage_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr__UseCoverage_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr__UseCoverage_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EAA RID: 3754
		// (get) Token: 0x06002C21 RID: 11297 RVA: 0x000FC444 File Offset: 0x000FA644
		// (set) Token: 0x06002C22 RID: 11298 RVA: 0x00017D8F File Offset: 0x00015F8F
		public unsafe bool _FailOnEmpty_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr__FailOnEmpty_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr__FailOnEmpty_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06002C23 RID: 11299 RVA: 0x000FC46C File Offset: 0x000FA66C
		// (set) Token: 0x06002C24 RID: 11300 RVA: 0x00017DAA File Offset: 0x00015FAA
		public unsafe Pot.ECameraPosition _CameraPosition_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr__CameraPosition_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr__CameraPosition_k__BackingField)) = value;
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06002C25 RID: 11301 RVA: 0x000FC494 File Offset: 0x000FA694
		// (set) Token: 0x06002C26 RID: 11302 RVA: 0x00017DC5 File Offset: 0x00015FC5
		public unsafe bool removeItemAfterInitialPour
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr_removeItemAfterInitialPour);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PourIntoPotTask.NativeFieldInfoPtr_removeItemAfterInitialPour)) = value;
			}
		}

		// Token: 0x04001D36 RID: 7478
		private static readonly IntPtr NativeFieldInfoPtr__TaskName_k__BackingField;

		// Token: 0x04001D37 RID: 7479
		private static readonly IntPtr NativeFieldInfoPtr_pot;

		// Token: 0x04001D38 RID: 7480
		private static readonly IntPtr NativeFieldInfoPtr_item;

		// Token: 0x04001D39 RID: 7481
		private static readonly IntPtr NativeFieldInfoPtr_pourable;

		// Token: 0x04001D3A RID: 7482
		private static readonly IntPtr NativeFieldInfoPtr__UseCoverage_k__BackingField;

		// Token: 0x04001D3B RID: 7483
		private static readonly IntPtr NativeFieldInfoPtr__FailOnEmpty_k__BackingField;

		// Token: 0x04001D3C RID: 7484
		private static readonly IntPtr NativeFieldInfoPtr__CameraPosition_k__BackingField;

		// Token: 0x04001D3D RID: 7485
		private static readonly IntPtr NativeFieldInfoPtr_removeItemAfterInitialPour;

		// Token: 0x04001D3E RID: 7486
		private static readonly IntPtr NativeMethodInfoPtr_get_TaskName_Public_Virtual_get_String_0;

		// Token: 0x04001D3F RID: 7487
		private static readonly IntPtr NativeMethodInfoPtr_set_TaskName_Protected_Virtual_set_Void_String_0;

		// Token: 0x04001D40 RID: 7488
		private static readonly IntPtr NativeMethodInfoPtr_get_UseCoverage_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04001D41 RID: 7489
		private static readonly IntPtr NativeMethodInfoPtr_get_FailOnEmpty_Protected_Virtual_New_get_Boolean_0;

		// Token: 0x04001D42 RID: 7490
		private static readonly IntPtr NativeMethodInfoPtr_get_CameraPosition_Protected_Virtual_New_get_ECameraPosition_0;

		// Token: 0x04001D43 RID: 7491
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Pot_ItemInstance_Pourable_0;

		// Token: 0x04001D44 RID: 7492
		private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Virtual_Void_0;

		// Token: 0x04001D45 RID: 7493
		private static readonly IntPtr NativeMethodInfoPtr_StopTask_Public_Virtual_Void_0;

		// Token: 0x04001D46 RID: 7494
		private static readonly IntPtr NativeMethodInfoPtr_OnInitialPour_Private_Void_0;

		// Token: 0x04001D47 RID: 7495
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Protected_Void_0;

		// Token: 0x04001D48 RID: 7496
		private static readonly IntPtr NativeMethodInfoPtr_FullyCovered_Protected_Virtual_New_Void_0;
	}
}
