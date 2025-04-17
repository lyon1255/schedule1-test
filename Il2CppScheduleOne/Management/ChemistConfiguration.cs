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
	// Token: 0x02000385 RID: 901
	public class ChemistConfiguration : EntityConfiguration
	{
		// Token: 0x060046A1 RID: 18081 RVA: 0x0015B2FC File Offset: 0x001594FC
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistConfiguration()
		{
			Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ChemistConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr);
			ChemistConfiguration.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "Bed");
			ChemistConfiguration.NativeFieldInfoPtr_Stations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "Stations");
			ChemistConfiguration.NativeFieldInfoPtr_ChemStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "ChemStations");
			ChemistConfiguration.NativeFieldInfoPtr_LabOvens = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "LabOvens");
			ChemistConfiguration.NativeFieldInfoPtr_Cauldrons = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "Cauldrons");
			ChemistConfiguration.NativeFieldInfoPtr_MixStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "MixStations");
			ChemistConfiguration.NativeFieldInfoPtr__chemist_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "<chemist>k__BackingField");
			ChemistConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, "<bedItem>k__BackingField");
			ChemistConfiguration.NativeMethodInfoPtr_get_TotalStations_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672019);
			ChemistConfiguration.NativeMethodInfoPtr_get_chemist_Public_get_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672020);
			ChemistConfiguration.NativeMethodInfoPtr_set_chemist_Protected_set_Void_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672021);
			ChemistConfiguration.NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672022);
			ChemistConfiguration.NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672023);
			ChemistConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Chemist_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672024);
			ChemistConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672025);
			ChemistConfiguration.NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672026);
			ChemistConfiguration.NativeMethodInfoPtr_AssignedStationsChanged_Public_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672027);
			ChemistConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672028);
			ChemistConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672029);
			ChemistConfiguration.NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672030);
			ChemistConfiguration.NativeMethodInfoPtr___ctor_b__16_0_Private_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr, 100672031);
		}

		// Token: 0x1700153C RID: 5436
		// (get) Token: 0x060046A2 RID: 18082 RVA: 0x0015B4D0 File Offset: 0x001596D0
		public unsafe int TotalStations
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 159470, RefRangeEnd = 159472, XrefRangeStart = 159466, XrefRangeEnd = 159470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_get_TotalStations_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700153D RID: 5437
		// (get) Token: 0x060046A3 RID: 18083 RVA: 0x0015B50C File Offset: 0x0015970C
		// (set) Token: 0x060046A4 RID: 18084 RVA: 0x0015B54C File Offset: 0x0015974C
		public unsafe Chemist chemist
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 22950, RefRangeEnd = 22967, XrefRangeStart = 22950, XrefRangeEnd = 22967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_get_chemist_Public_get_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_set_chemist_Protected_set_Void_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x060046A5 RID: 18085 RVA: 0x0015B590 File Offset: 0x00159790
		// (set) Token: 0x060046A6 RID: 18086 RVA: 0x0015B5D0 File Offset: 0x001597D0
		public unsafe BedItem bedItem
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 22967, RefRangeEnd = 22968, XrefRangeStart = 22967, XrefRangeEnd = 22968, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BedItem>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046A7 RID: 18087 RVA: 0x0015B614 File Offset: 0x00159814
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 159610, RefRangeEnd = 159611, XrefRangeStart = 159472, XrefRangeEnd = 159610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Chemist _chemist) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_chemist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Chemist_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046A8 RID: 18088 RVA: 0x0015B684 File Offset: 0x00159884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159611, XrefRangeEnd = 159712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046A9 RID: 18089 RVA: 0x0015B6C0 File Offset: 0x001598C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159712, XrefRangeEnd = 159739, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsStationValid(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060046AA RID: 18090 RVA: 0x0015B728 File Offset: 0x00159928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159739, XrefRangeEnd = 159940, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignedStationsChanged(List<BuildableItem> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_AssignedStationsChanged_Public_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046AB RID: 18091 RVA: 0x0015B76C File Offset: 0x0015996C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159940, XrefRangeEnd = 159947, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x0015B7B4 File Offset: 0x001599B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159947, XrefRangeEnd = 159954, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060046AD RID: 18093 RVA: 0x0015B7F8 File Offset: 0x001599F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 159954, XrefRangeEnd = 159972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BedChanged(BuildableItem newItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x0015B83C File Offset: 0x00159A3C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__16_0(List<BuildableItem> <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfiguration.NativeMethodInfoPtr___ctor_b__16_0_Private_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046AF RID: 18095 RVA: 0x000223EF File Offset: 0x000205EF
		public ChemistConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001534 RID: 5428
		// (get) Token: 0x060046B0 RID: 18096 RVA: 0x0015B880 File Offset: 0x00159A80
		// (set) Token: 0x060046B1 RID: 18097 RVA: 0x000223F8 File Offset: 0x000205F8
		public unsafe ObjectField Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001535 RID: 5429
		// (get) Token: 0x060046B2 RID: 18098 RVA: 0x0015B8B0 File Offset: 0x00159AB0
		// (set) Token: 0x060046B3 RID: 18099 RVA: 0x00022417 File Offset: 0x00020617
		public unsafe ObjectListField Stations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Stations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Stations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001536 RID: 5430
		// (get) Token: 0x060046B4 RID: 18100 RVA: 0x0015B8E0 File Offset: 0x00159AE0
		// (set) Token: 0x060046B5 RID: 18101 RVA: 0x00022436 File Offset: 0x00020636
		public unsafe List<ChemistryStation> ChemStations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_ChemStations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ChemistryStation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_ChemStations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001537 RID: 5431
		// (get) Token: 0x060046B6 RID: 18102 RVA: 0x0015B910 File Offset: 0x00159B10
		// (set) Token: 0x060046B7 RID: 18103 RVA: 0x00022455 File Offset: 0x00020655
		public unsafe List<LabOven> LabOvens
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_LabOvens);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<LabOven>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_LabOvens), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001538 RID: 5432
		// (get) Token: 0x060046B8 RID: 18104 RVA: 0x0015B940 File Offset: 0x00159B40
		// (set) Token: 0x060046B9 RID: 18105 RVA: 0x00022474 File Offset: 0x00020674
		public unsafe List<Cauldron> Cauldrons
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Cauldrons);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Cauldron>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_Cauldrons), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001539 RID: 5433
		// (get) Token: 0x060046BA RID: 18106 RVA: 0x0015B970 File Offset: 0x00159B70
		// (set) Token: 0x060046BB RID: 18107 RVA: 0x00022493 File Offset: 0x00020693
		public unsafe List<MixingStation> MixStations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_MixStations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<MixingStation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr_MixStations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700153A RID: 5434
		// (get) Token: 0x060046BC RID: 18108 RVA: 0x0015B9A0 File Offset: 0x00159BA0
		// (set) Token: 0x060046BD RID: 18109 RVA: 0x000224B2 File Offset: 0x000206B2
		public unsafe Chemist _chemist_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr__chemist_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Chemist>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr__chemist_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700153B RID: 5435
		// (get) Token: 0x060046BE RID: 18110 RVA: 0x0015B9D0 File Offset: 0x00159BD0
		// (set) Token: 0x060046BF RID: 18111 RVA: 0x000224D1 File Offset: 0x000206D1
		public unsafe BedItem _bedItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BedItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F80 RID: 12160
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x04002F81 RID: 12161
		private static readonly IntPtr NativeFieldInfoPtr_Stations;

		// Token: 0x04002F82 RID: 12162
		private static readonly IntPtr NativeFieldInfoPtr_ChemStations;

		// Token: 0x04002F83 RID: 12163
		private static readonly IntPtr NativeFieldInfoPtr_LabOvens;

		// Token: 0x04002F84 RID: 12164
		private static readonly IntPtr NativeFieldInfoPtr_Cauldrons;

		// Token: 0x04002F85 RID: 12165
		private static readonly IntPtr NativeFieldInfoPtr_MixStations;

		// Token: 0x04002F86 RID: 12166
		private static readonly IntPtr NativeFieldInfoPtr__chemist_k__BackingField;

		// Token: 0x04002F87 RID: 12167
		private static readonly IntPtr NativeFieldInfoPtr__bedItem_k__BackingField;

		// Token: 0x04002F88 RID: 12168
		private static readonly IntPtr NativeMethodInfoPtr_get_TotalStations_Public_get_Int32_0;

		// Token: 0x04002F89 RID: 12169
		private static readonly IntPtr NativeMethodInfoPtr_get_chemist_Public_get_Chemist_0;

		// Token: 0x04002F8A RID: 12170
		private static readonly IntPtr NativeMethodInfoPtr_set_chemist_Protected_set_Void_Chemist_0;

		// Token: 0x04002F8B RID: 12171
		private static readonly IntPtr NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0;

		// Token: 0x04002F8C RID: 12172
		private static readonly IntPtr NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0;

		// Token: 0x04002F8D RID: 12173
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Chemist_0;

		// Token: 0x04002F8E RID: 12174
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x04002F8F RID: 12175
		private static readonly IntPtr NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0;

		// Token: 0x04002F90 RID: 12176
		private static readonly IntPtr NativeMethodInfoPtr_AssignedStationsChanged_Public_Void_List_1_BuildableItem_0;

		// Token: 0x04002F91 RID: 12177
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04002F92 RID: 12178
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04002F93 RID: 12179
		private static readonly IntPtr NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0;

		// Token: 0x04002F94 RID: 12180
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__16_0_Private_Void_List_1_BuildableItem_0;
	}
}
