using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.ObjectScripts;
using Il2CppScheduleOne.StationFramework;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000386 RID: 902
	public class ChemistryStationConfiguration : EntityConfiguration
	{
		// Token: 0x060046C0 RID: 18112 RVA: 0x0015BA00 File Offset: 0x00159C00
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationConfiguration()
		{
			Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ChemistryStationConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr);
			ChemistryStationConfiguration.NativeFieldInfoPtr__Station_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, "<Station>k__BackingField");
			ChemistryStationConfiguration.NativeFieldInfoPtr_AssignedChemist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, "AssignedChemist");
			ChemistryStationConfiguration.NativeFieldInfoPtr_Recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, "Recipe");
			ChemistryStationConfiguration.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, "Destination");
			ChemistryStationConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, "<DestinationRoute>k__BackingField");
			ChemistryStationConfiguration.NativeMethodInfoPtr_get_Station_Public_get_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, 100672032);
			ChemistryStationConfiguration.NativeMethodInfoPtr_set_Station_Protected_set_Void_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, 100672033);
			ChemistryStationConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, 100672034);
			ChemistryStationConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, 100672035);
			ChemistryStationConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_ChemistryStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, 100672036);
			ChemistryStationConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, 100672037);
			ChemistryStationConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, 100672038);
			ChemistryStationConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, 100672039);
			ChemistryStationConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, 100672040);
			ChemistryStationConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, 100672041);
			ChemistryStationConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, 100672042);
			ChemistryStationConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, 100672043);
			ChemistryStationConfiguration.NativeMethodInfoPtr___ctor_b__11_0_Private_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, 100672044);
			ChemistryStationConfiguration.NativeMethodInfoPtr___ctor_b__11_1_Private_Void_StationRecipe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, 100672045);
			ChemistryStationConfiguration.NativeMethodInfoPtr___ctor_b__11_2_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr, 100672046);
		}

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x060046C1 RID: 18113 RVA: 0x0015BBC0 File Offset: 0x00159DC0
		// (set) Token: 0x060046C2 RID: 18114 RVA: 0x0015BC00 File Offset: 0x00159E00
		public unsafe ChemistryStation Station
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationConfiguration.NativeMethodInfoPtr_get_Station_Public_get_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationConfiguration.NativeMethodInfoPtr_set_Station_Protected_set_Void_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001545 RID: 5445
		// (get) Token: 0x060046C3 RID: 18115 RVA: 0x0015BC44 File Offset: 0x00159E44
		// (set) Token: 0x060046C4 RID: 18116 RVA: 0x0015BC84 File Offset: 0x00159E84
		public unsafe TransitRoute DestinationRoute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TransitRoute>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046C5 RID: 18117 RVA: 0x0015BCC8 File Offset: 0x00159EC8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160049, RefRangeEnd = 160050, XrefRangeStart = 159972, XrefRangeEnd = 160049, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, ChemistryStation station) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_ChemistryStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046C6 RID: 18118 RVA: 0x0015BD38 File Offset: 0x00159F38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160050, XrefRangeEnd = 160052, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046C7 RID: 18119 RVA: 0x0015BD74 File Offset: 0x00159F74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160052, XrefRangeEnd = 160061, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestinationChanged(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046C8 RID: 18120 RVA: 0x0015BDB8 File Offset: 0x00159FB8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160061, XrefRangeEnd = 160078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DestinationFilter(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ChemistryStationConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060046C9 RID: 18121 RVA: 0x0015BE20 File Offset: 0x0015A020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160078, XrefRangeEnd = 160079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046CA RID: 18122 RVA: 0x0015BE5C File Offset: 0x0015A05C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160079, XrefRangeEnd = 160080, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deselected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046CB RID: 18123 RVA: 0x0015BE98 File Offset: 0x0015A098
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160080, XrefRangeEnd = 160084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060046CC RID: 18124 RVA: 0x0015BEE0 File Offset: 0x0015A0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160084, XrefRangeEnd = 160102, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ChemistryStationConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060046CD RID: 18125 RVA: 0x0015BF24 File Offset: 0x0015A124
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__11_0(NPC <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationConfiguration.NativeMethodInfoPtr___ctor_b__11_0_Private_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046CE RID: 18126 RVA: 0x0015BF68 File Offset: 0x0015A168
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__11_1(StationRecipe <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationConfiguration.NativeMethodInfoPtr___ctor_b__11_1_Private_Void_StationRecipe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046CF RID: 18127 RVA: 0x0015BFAC File Offset: 0x0015A1AC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__11_2(BuildableItem <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationConfiguration.NativeMethodInfoPtr___ctor_b__11_2_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x000224F0 File Offset: 0x000206F0
		public ChemistryStationConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x060046D1 RID: 18129 RVA: 0x0015BFF0 File Offset: 0x0015A1F0
		// (set) Token: 0x060046D2 RID: 18130 RVA: 0x000224F9 File Offset: 0x000206F9
		public unsafe ChemistryStation _Station_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfiguration.NativeFieldInfoPtr__Station_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChemistryStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfiguration.NativeFieldInfoPtr__Station_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x060046D3 RID: 18131 RVA: 0x0015C020 File Offset: 0x0015A220
		// (set) Token: 0x060046D4 RID: 18132 RVA: 0x00022518 File Offset: 0x00020718
		public unsafe NPCField AssignedChemist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfiguration.NativeFieldInfoPtr_AssignedChemist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfiguration.NativeFieldInfoPtr_AssignedChemist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x060046D5 RID: 18133 RVA: 0x0015C050 File Offset: 0x0015A250
		// (set) Token: 0x060046D6 RID: 18134 RVA: 0x00022537 File Offset: 0x00020737
		public unsafe StationRecipeField Recipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfiguration.NativeFieldInfoPtr_Recipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfiguration.NativeFieldInfoPtr_Recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x060046D7 RID: 18135 RVA: 0x0015C080 File Offset: 0x0015A280
		// (set) Token: 0x060046D8 RID: 18136 RVA: 0x00022556 File Offset: 0x00020756
		public unsafe ObjectField Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfiguration.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfiguration.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x060046D9 RID: 18137 RVA: 0x0015C0B0 File Offset: 0x0015A2B0
		// (set) Token: 0x060046DA RID: 18138 RVA: 0x00022575 File Offset: 0x00020775
		public unsafe TransitRoute _DestinationRoute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002F95 RID: 12181
		private static readonly IntPtr NativeFieldInfoPtr__Station_k__BackingField;

		// Token: 0x04002F96 RID: 12182
		private static readonly IntPtr NativeFieldInfoPtr_AssignedChemist;

		// Token: 0x04002F97 RID: 12183
		private static readonly IntPtr NativeFieldInfoPtr_Recipe;

		// Token: 0x04002F98 RID: 12184
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04002F99 RID: 12185
		private static readonly IntPtr NativeFieldInfoPtr__DestinationRoute_k__BackingField;

		// Token: 0x04002F9A RID: 12186
		private static readonly IntPtr NativeMethodInfoPtr_get_Station_Public_get_ChemistryStation_0;

		// Token: 0x04002F9B RID: 12187
		private static readonly IntPtr NativeMethodInfoPtr_set_Station_Protected_set_Void_ChemistryStation_0;

		// Token: 0x04002F9C RID: 12188
		private static readonly IntPtr NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0;

		// Token: 0x04002F9D RID: 12189
		private static readonly IntPtr NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0;

		// Token: 0x04002F9E RID: 12190
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_ChemistryStation_0;

		// Token: 0x04002F9F RID: 12191
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x04002FA0 RID: 12192
		private static readonly IntPtr NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0;

		// Token: 0x04002FA1 RID: 12193
		private static readonly IntPtr NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0;

		// Token: 0x04002FA2 RID: 12194
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Public_Virtual_Void_0;

		// Token: 0x04002FA3 RID: 12195
		private static readonly IntPtr NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0;

		// Token: 0x04002FA4 RID: 12196
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04002FA5 RID: 12197
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04002FA6 RID: 12198
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__11_0_Private_Void_NPC_0;

		// Token: 0x04002FA7 RID: 12199
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__11_1_Private_Void_StationRecipe_0;

		// Token: 0x04002FA8 RID: 12200
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__11_2_Private_Void_BuildableItem_0;
	}
}
