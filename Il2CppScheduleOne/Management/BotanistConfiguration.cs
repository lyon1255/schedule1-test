using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Employees;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000382 RID: 898
	public class BotanistConfiguration : EntityConfiguration
	{
		// Token: 0x06004654 RID: 18004 RVA: 0x00159FAC File Offset: 0x001581AC
		// Note: this type is marked as 'beforefieldinit'.
		static BotanistConfiguration()
		{
			Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "BotanistConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr);
			BotanistConfiguration.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "Bed");
			BotanistConfiguration.NativeFieldInfoPtr_Supplies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "Supplies");
			BotanistConfiguration.NativeFieldInfoPtr_AssignedStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "AssignedStations");
			BotanistConfiguration.NativeFieldInfoPtr_AssignedPots = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "AssignedPots");
			BotanistConfiguration.NativeFieldInfoPtr_AssignedRacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "AssignedRacks");
			BotanistConfiguration.NativeFieldInfoPtr__botanist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "<botanist>k__BackingField");
			BotanistConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, "<bedItem>k__BackingField");
			BotanistConfiguration.NativeMethodInfoPtr_get_botanist_Public_get_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671978);
			BotanistConfiguration.NativeMethodInfoPtr_set_botanist_Protected_set_Void_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671979);
			BotanistConfiguration.NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671980);
			BotanistConfiguration.NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671981);
			BotanistConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Botanist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671982);
			BotanistConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671983);
			BotanistConfiguration.NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671984);
			BotanistConfiguration.NativeMethodInfoPtr_AssignedPotsChanged_Public_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671985);
			BotanistConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671986);
			BotanistConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671987);
			BotanistConfiguration.NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671988);
			BotanistConfiguration.NativeMethodInfoPtr___ctor_b__13_0_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671989);
			BotanistConfiguration.NativeMethodInfoPtr___ctor_b__13_1_Private_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr, 100671990);
		}

		// Token: 0x17001526 RID: 5414
		// (get) Token: 0x06004655 RID: 18005 RVA: 0x0015A16C File Offset: 0x0015836C
		// (set) Token: 0x06004656 RID: 18006 RVA: 0x0015A1AC File Offset: 0x001583AC
		public unsafe Botanist botanist
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 47268, RefRangeEnd = 47308, XrefRangeStart = 47268, XrefRangeEnd = 47308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_get_botanist_Public_get_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 158947, RefRangeEnd = 158949, XrefRangeStart = 158946, XrefRangeEnd = 158947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_set_botanist_Protected_set_Void_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001527 RID: 5415
		// (get) Token: 0x06004657 RID: 18007 RVA: 0x0015A1F0 File Offset: 0x001583F0
		// (set) Token: 0x06004658 RID: 18008 RVA: 0x0015A230 File Offset: 0x00158430
		public unsafe BedItem bedItem
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 22950, RefRangeEnd = 22967, XrefRangeStart = 22950, XrefRangeEnd = 22967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BedItem>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 158949, XrefRangeEnd = 158950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x0015A274 File Offset: 0x00158474
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159076, RefRangeEnd = 159077, XrefRangeStart = 158950, XrefRangeEnd = 159076, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BotanistConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Botanist _botanist) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BotanistConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_botanist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Botanist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x0015A2E4 File Offset: 0x001584E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159077, XrefRangeEnd = 159128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x0015A320 File Offset: 0x00158520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159128, XrefRangeEnd = 159175, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsStationValid(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x0015A388 File Offset: 0x00158588
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159175, XrefRangeEnd = 159251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignedPotsChanged(List<BuildableItem> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_AssignedPotsChanged_Public_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x0015A3CC File Offset: 0x001585CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159251, XrefRangeEnd = 159260, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600465E RID: 18014 RVA: 0x0015A414 File Offset: 0x00158614
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159260, XrefRangeEnd = 159268, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BotanistConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x0015A458 File Offset: 0x00158658
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159268, XrefRangeEnd = 159286, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BedChanged(BuildableItem newItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x0015A49C File Offset: 0x0015869C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__13_0(BuildableItem <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr___ctor_b__13_0_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x0015A4E0 File Offset: 0x001586E0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__13_1(List<BuildableItem> <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BotanistConfiguration.NativeMethodInfoPtr___ctor_b__13_1_Private_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x00022203 File Offset: 0x00020403
		public BotanistConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700151F RID: 5407
		// (get) Token: 0x06004663 RID: 18019 RVA: 0x0015A524 File Offset: 0x00158724
		// (set) Token: 0x06004664 RID: 18020 RVA: 0x0002220C File Offset: 0x0002040C
		public unsafe ObjectField Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001520 RID: 5408
		// (get) Token: 0x06004665 RID: 18021 RVA: 0x0015A554 File Offset: 0x00158754
		// (set) Token: 0x06004666 RID: 18022 RVA: 0x0002222B File Offset: 0x0002042B
		public unsafe ObjectField Supplies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_Supplies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_Supplies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001521 RID: 5409
		// (get) Token: 0x06004667 RID: 18023 RVA: 0x0015A584 File Offset: 0x00158784
		// (set) Token: 0x06004668 RID: 18024 RVA: 0x0002224A File Offset: 0x0002044A
		public unsafe ObjectListField AssignedStations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_AssignedStations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_AssignedStations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001522 RID: 5410
		// (get) Token: 0x06004669 RID: 18025 RVA: 0x0015A5B4 File Offset: 0x001587B4
		// (set) Token: 0x0600466A RID: 18026 RVA: 0x00022269 File Offset: 0x00020469
		public unsafe List<Pot> AssignedPots
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_AssignedPots);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Pot>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_AssignedPots), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001523 RID: 5411
		// (get) Token: 0x0600466B RID: 18027 RVA: 0x0015A5E4 File Offset: 0x001587E4
		// (set) Token: 0x0600466C RID: 18028 RVA: 0x00022288 File Offset: 0x00020488
		public unsafe List<DryingRack> AssignedRacks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_AssignedRacks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<DryingRack>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr_AssignedRacks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001524 RID: 5412
		// (get) Token: 0x0600466D RID: 18029 RVA: 0x0015A614 File Offset: 0x00158814
		// (set) Token: 0x0600466E RID: 18030 RVA: 0x000222A7 File Offset: 0x000204A7
		public unsafe Botanist _botanist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__botanist_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Botanist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__botanist_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001525 RID: 5413
		// (get) Token: 0x0600466F RID: 18031 RVA: 0x0015A644 File Offset: 0x00158844
		// (set) Token: 0x06004670 RID: 18032 RVA: 0x000222C6 File Offset: 0x000204C6
		public unsafe BedItem _bedItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BedItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BotanistConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F48 RID: 12104
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x04002F49 RID: 12105
		private static readonly IntPtr NativeFieldInfoPtr_Supplies;

		// Token: 0x04002F4A RID: 12106
		private static readonly IntPtr NativeFieldInfoPtr_AssignedStations;

		// Token: 0x04002F4B RID: 12107
		private static readonly IntPtr NativeFieldInfoPtr_AssignedPots;

		// Token: 0x04002F4C RID: 12108
		private static readonly IntPtr NativeFieldInfoPtr_AssignedRacks;

		// Token: 0x04002F4D RID: 12109
		private static readonly IntPtr NativeFieldInfoPtr__botanist_k__BackingField;

		// Token: 0x04002F4E RID: 12110
		private static readonly IntPtr NativeFieldInfoPtr__bedItem_k__BackingField;

		// Token: 0x04002F4F RID: 12111
		private static readonly IntPtr NativeMethodInfoPtr_get_botanist_Public_get_Botanist_0;

		// Token: 0x04002F50 RID: 12112
		private static readonly IntPtr NativeMethodInfoPtr_set_botanist_Protected_set_Void_Botanist_0;

		// Token: 0x04002F51 RID: 12113
		private static readonly IntPtr NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0;

		// Token: 0x04002F52 RID: 12114
		private static readonly IntPtr NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0;

		// Token: 0x04002F53 RID: 12115
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Botanist_0;

		// Token: 0x04002F54 RID: 12116
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x04002F55 RID: 12117
		private static readonly IntPtr NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0;

		// Token: 0x04002F56 RID: 12118
		private static readonly IntPtr NativeMethodInfoPtr_AssignedPotsChanged_Public_Void_List_1_BuildableItem_0;

		// Token: 0x04002F57 RID: 12119
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04002F58 RID: 12120
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04002F59 RID: 12121
		private static readonly IntPtr NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0;

		// Token: 0x04002F5A RID: 12122
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__13_0_Private_Void_BuildableItem_0;

		// Token: 0x04002F5B RID: 12123
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__13_1_Private_Void_List_1_BuildableItem_0;
	}
}
