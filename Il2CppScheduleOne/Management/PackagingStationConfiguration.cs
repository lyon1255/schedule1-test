using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x0200038D RID: 909
	public class PackagingStationConfiguration : EntityConfiguration
	{
		// Token: 0x0600477C RID: 18300 RVA: 0x0015E92C File Offset: 0x0015CB2C
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStationConfiguration()
		{
			Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "PackagingStationConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr);
			PackagingStationConfiguration.NativeFieldInfoPtr__Station_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, "<Station>k__BackingField");
			PackagingStationConfiguration.NativeFieldInfoPtr_AssignedPackager = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, "AssignedPackager");
			PackagingStationConfiguration.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, "Destination");
			PackagingStationConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, "<DestinationRoute>k__BackingField");
			PackagingStationConfiguration.NativeMethodInfoPtr_get_Station_Public_get_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, 100672134);
			PackagingStationConfiguration.NativeMethodInfoPtr_set_Station_Protected_set_Void_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, 100672135);
			PackagingStationConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, 100672136);
			PackagingStationConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, 100672137);
			PackagingStationConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_PackagingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, 100672138);
			PackagingStationConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, 100672139);
			PackagingStationConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, 100672140);
			PackagingStationConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, 100672141);
			PackagingStationConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, 100672142);
			PackagingStationConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, 100672143);
			PackagingStationConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, 100672144);
			PackagingStationConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, 100672145);
			PackagingStationConfiguration.NativeMethodInfoPtr___ctor_b__10_0_Private_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, 100672146);
			PackagingStationConfiguration.NativeMethodInfoPtr___ctor_b__10_1_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr, 100672147);
		}

		// Token: 0x17001578 RID: 5496
		// (get) Token: 0x0600477D RID: 18301 RVA: 0x0015EAC4 File Offset: 0x0015CCC4
		// (set) Token: 0x0600477E RID: 18302 RVA: 0x0015EB04 File Offset: 0x0015CD04
		public unsafe PackagingStation Station
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationConfiguration.NativeMethodInfoPtr_get_Station_Public_get_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationConfiguration.NativeMethodInfoPtr_set_Station_Protected_set_Void_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x0600477F RID: 18303 RVA: 0x0015EB48 File Offset: 0x0015CD48
		// (set) Token: 0x06004780 RID: 18304 RVA: 0x0015EB88 File Offset: 0x0015CD88
		public unsafe TransitRoute DestinationRoute
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<TransitRoute>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004781 RID: 18305 RVA: 0x0015EBCC File Offset: 0x0015CDCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 161047, RefRangeEnd = 161048, XrefRangeStart = 160996, XrefRangeEnd = 161047, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStationConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, PackagingStation station) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_PackagingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004782 RID: 18306 RVA: 0x0015EC3C File Offset: 0x0015CE3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004783 RID: 18307 RVA: 0x0015EC78 File Offset: 0x0015CE78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161048, XrefRangeEnd = 161057, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestinationChanged(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004784 RID: 18308 RVA: 0x0015ECBC File Offset: 0x0015CEBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161057, XrefRangeEnd = 161074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DestinationFilter(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PackagingStationConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004785 RID: 18309 RVA: 0x0015ED24 File Offset: 0x0015CF24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004786 RID: 18310 RVA: 0x0015ED60 File Offset: 0x0015CF60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deselected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004787 RID: 18311 RVA: 0x0015ED9C File Offset: 0x0015CF9C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161074, XrefRangeEnd = 161078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004788 RID: 18312 RVA: 0x0015EDE4 File Offset: 0x0015CFE4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161078, XrefRangeEnd = 161084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagingStationConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004789 RID: 18313 RVA: 0x0015EE28 File Offset: 0x0015D028
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__10_0(NPC <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationConfiguration.NativeMethodInfoPtr___ctor_b__10_0_Private_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600478A RID: 18314 RVA: 0x0015EE6C File Offset: 0x0015D06C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__10_1(BuildableItem <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationConfiguration.NativeMethodInfoPtr___ctor_b__10_1_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600478B RID: 18315 RVA: 0x00022987 File Offset: 0x00020B87
		public PackagingStationConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001574 RID: 5492
		// (get) Token: 0x0600478C RID: 18316 RVA: 0x0015EEB0 File Offset: 0x0015D0B0
		// (set) Token: 0x0600478D RID: 18317 RVA: 0x00022990 File Offset: 0x00020B90
		public unsafe PackagingStation _Station_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfiguration.NativeFieldInfoPtr__Station_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PackagingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfiguration.NativeFieldInfoPtr__Station_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001575 RID: 5493
		// (get) Token: 0x0600478E RID: 18318 RVA: 0x0015EEE0 File Offset: 0x0015D0E0
		// (set) Token: 0x0600478F RID: 18319 RVA: 0x000229AF File Offset: 0x00020BAF
		public unsafe NPCField AssignedPackager
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfiguration.NativeFieldInfoPtr_AssignedPackager);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfiguration.NativeFieldInfoPtr_AssignedPackager), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001576 RID: 5494
		// (get) Token: 0x06004790 RID: 18320 RVA: 0x0015EF10 File Offset: 0x0015D110
		// (set) Token: 0x06004791 RID: 18321 RVA: 0x000229CE File Offset: 0x00020BCE
		public unsafe ObjectField Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfiguration.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfiguration.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001577 RID: 5495
		// (get) Token: 0x06004792 RID: 18322 RVA: 0x0015EF40 File Offset: 0x0015D140
		// (set) Token: 0x06004793 RID: 18323 RVA: 0x000229ED File Offset: 0x00020BED
		public unsafe TransitRoute _DestinationRoute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400301F RID: 12319
		private static readonly IntPtr NativeFieldInfoPtr__Station_k__BackingField;

		// Token: 0x04003020 RID: 12320
		private static readonly IntPtr NativeFieldInfoPtr_AssignedPackager;

		// Token: 0x04003021 RID: 12321
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04003022 RID: 12322
		private static readonly IntPtr NativeFieldInfoPtr__DestinationRoute_k__BackingField;

		// Token: 0x04003023 RID: 12323
		private static readonly IntPtr NativeMethodInfoPtr_get_Station_Public_get_PackagingStation_0;

		// Token: 0x04003024 RID: 12324
		private static readonly IntPtr NativeMethodInfoPtr_set_Station_Protected_set_Void_PackagingStation_0;

		// Token: 0x04003025 RID: 12325
		private static readonly IntPtr NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0;

		// Token: 0x04003026 RID: 12326
		private static readonly IntPtr NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0;

		// Token: 0x04003027 RID: 12327
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_PackagingStation_0;

		// Token: 0x04003028 RID: 12328
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x04003029 RID: 12329
		private static readonly IntPtr NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0;

		// Token: 0x0400302A RID: 12330
		private static readonly IntPtr NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0;

		// Token: 0x0400302B RID: 12331
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Public_Virtual_Void_0;

		// Token: 0x0400302C RID: 12332
		private static readonly IntPtr NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0;

		// Token: 0x0400302D RID: 12333
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x0400302E RID: 12334
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x0400302F RID: 12335
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__10_0_Private_Void_NPC_0;

		// Token: 0x04003030 RID: 12336
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__10_1_Private_Void_BuildableItem_0;
	}
}
