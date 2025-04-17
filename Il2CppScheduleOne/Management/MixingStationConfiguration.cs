using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x0200038B RID: 907
	public class MixingStationConfiguration : EntityConfiguration
	{
		// Token: 0x06004743 RID: 18243 RVA: 0x0015DB38 File Offset: 0x0015BD38
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationConfiguration()
		{
			Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "MixingStationConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr);
			MixingStationConfiguration.NativeFieldInfoPtr__station_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, "<station>k__BackingField");
			MixingStationConfiguration.NativeFieldInfoPtr_AssignedChemist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, "AssignedChemist");
			MixingStationConfiguration.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, "Destination");
			MixingStationConfiguration.NativeFieldInfoPtr_StartThrehold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, "StartThrehold");
			MixingStationConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, "<DestinationRoute>k__BackingField");
			MixingStationConfiguration.NativeMethodInfoPtr_get_station_Public_get_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, 100672105);
			MixingStationConfiguration.NativeMethodInfoPtr_set_station_Protected_set_Void_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, 100672106);
			MixingStationConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, 100672107);
			MixingStationConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, 100672108);
			MixingStationConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_MixingStation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, 100672109);
			MixingStationConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, 100672110);
			MixingStationConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, 100672111);
			MixingStationConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, 100672112);
			MixingStationConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, 100672113);
			MixingStationConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, 100672114);
			MixingStationConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, 100672115);
			MixingStationConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, 100672116);
			MixingStationConfiguration.NativeMethodInfoPtr___ctor_b__11_0_Private_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, 100672117);
			MixingStationConfiguration.NativeMethodInfoPtr___ctor_b__11_1_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, 100672118);
			MixingStationConfiguration.NativeMethodInfoPtr___ctor_b__11_2_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr, 100672119);
		}

		// Token: 0x17001568 RID: 5480
		// (get) Token: 0x06004744 RID: 18244 RVA: 0x0015DCF8 File Offset: 0x0015BEF8
		// (set) Token: 0x06004745 RID: 18245 RVA: 0x0015DD38 File Offset: 0x0015BF38
		public unsafe MixingStation station
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationConfiguration.NativeMethodInfoPtr_get_station_Public_get_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationConfiguration.NativeMethodInfoPtr_set_station_Protected_set_Void_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001569 RID: 5481
		// (get) Token: 0x06004746 RID: 18246 RVA: 0x0015DD7C File Offset: 0x0015BF7C
		// (set) Token: 0x06004747 RID: 18247 RVA: 0x0015DDBC File Offset: 0x0015BFBC
		public unsafe TransitRoute DestinationRoute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004748 RID: 18248 RVA: 0x0015DE00 File Offset: 0x0015C000
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160589, RefRangeEnd = 160590, XrefRangeStart = 160513, XrefRangeEnd = 160589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, MixingStation station) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(station);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_MixingStation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004749 RID: 18249 RVA: 0x0015DE70 File Offset: 0x0015C070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600474A RID: 18250 RVA: 0x0015DEAC File Offset: 0x0015C0AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160590, XrefRangeEnd = 160599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestinationChanged(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600474B RID: 18251 RVA: 0x0015DEF0 File Offset: 0x0015C0F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160599, XrefRangeEnd = 160616, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DestinationFilter(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(MixingStationConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x0600474C RID: 18252 RVA: 0x0015DF58 File Offset: 0x0015C158
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600474D RID: 18253 RVA: 0x0015DF94 File Offset: 0x0015C194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deselected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600474E RID: 18254 RVA: 0x0015DFD0 File Offset: 0x0015C1D0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160616, XrefRangeEnd = 160620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600474F RID: 18255 RVA: 0x0015E018 File Offset: 0x0015C218
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160620, XrefRangeEnd = 160630, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MixingStationConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004750 RID: 18256 RVA: 0x0015E05C File Offset: 0x0015C25C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__11_0(NPC <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationConfiguration.NativeMethodInfoPtr___ctor_b__11_0_Private_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004751 RID: 18257 RVA: 0x0015E0A0 File Offset: 0x0015C2A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__11_1(BuildableItem <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationConfiguration.NativeMethodInfoPtr___ctor_b__11_1_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004752 RID: 18258 RVA: 0x0015E0E4 File Offset: 0x0015C2E4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__11_2(float <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationConfiguration.NativeMethodInfoPtr___ctor_b__11_2_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004753 RID: 18259 RVA: 0x00022801 File Offset: 0x00020A01
		public MixingStationConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001563 RID: 5475
		// (get) Token: 0x06004754 RID: 18260 RVA: 0x0015E124 File Offset: 0x0015C324
		// (set) Token: 0x06004755 RID: 18261 RVA: 0x0002280A File Offset: 0x00020A0A
		public unsafe MixingStation _station_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfiguration.NativeFieldInfoPtr__station_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MixingStation>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfiguration.NativeFieldInfoPtr__station_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001564 RID: 5476
		// (get) Token: 0x06004756 RID: 18262 RVA: 0x0015E154 File Offset: 0x0015C354
		// (set) Token: 0x06004757 RID: 18263 RVA: 0x00022829 File Offset: 0x00020A29
		public unsafe NPCField AssignedChemist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfiguration.NativeFieldInfoPtr_AssignedChemist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfiguration.NativeFieldInfoPtr_AssignedChemist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001565 RID: 5477
		// (get) Token: 0x06004758 RID: 18264 RVA: 0x0015E184 File Offset: 0x0015C384
		// (set) Token: 0x06004759 RID: 18265 RVA: 0x00022848 File Offset: 0x00020A48
		public unsafe ObjectField Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfiguration.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfiguration.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001566 RID: 5478
		// (get) Token: 0x0600475A RID: 18266 RVA: 0x0015E1B4 File Offset: 0x0015C3B4
		// (set) Token: 0x0600475B RID: 18267 RVA: 0x00022867 File Offset: 0x00020A67
		public unsafe NumberField StartThrehold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfiguration.NativeFieldInfoPtr_StartThrehold);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfiguration.NativeFieldInfoPtr_StartThrehold), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001567 RID: 5479
		// (get) Token: 0x0600475C RID: 18268 RVA: 0x0015E1E4 File Offset: 0x0015C3E4
		// (set) Token: 0x0600475D RID: 18269 RVA: 0x00022886 File Offset: 0x00020A86
		public unsafe TransitRoute _DestinationRoute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002FF6 RID: 12278
		private static readonly IntPtr NativeFieldInfoPtr__station_k__BackingField;

		// Token: 0x04002FF7 RID: 12279
		private static readonly IntPtr NativeFieldInfoPtr_AssignedChemist;

		// Token: 0x04002FF8 RID: 12280
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04002FF9 RID: 12281
		private static readonly IntPtr NativeFieldInfoPtr_StartThrehold;

		// Token: 0x04002FFA RID: 12282
		private static readonly IntPtr NativeFieldInfoPtr__DestinationRoute_k__BackingField;

		// Token: 0x04002FFB RID: 12283
		private static readonly IntPtr NativeMethodInfoPtr_get_station_Public_get_MixingStation_0;

		// Token: 0x04002FFC RID: 12284
		private static readonly IntPtr NativeMethodInfoPtr_set_station_Protected_set_Void_MixingStation_0;

		// Token: 0x04002FFD RID: 12285
		private static readonly IntPtr NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0;

		// Token: 0x04002FFE RID: 12286
		private static readonly IntPtr NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0;

		// Token: 0x04002FFF RID: 12287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_MixingStation_0;

		// Token: 0x04003000 RID: 12288
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x04003001 RID: 12289
		private static readonly IntPtr NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0;

		// Token: 0x04003002 RID: 12290
		private static readonly IntPtr NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0;

		// Token: 0x04003003 RID: 12291
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Public_Virtual_Void_0;

		// Token: 0x04003004 RID: 12292
		private static readonly IntPtr NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0;

		// Token: 0x04003005 RID: 12293
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04003006 RID: 12294
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04003007 RID: 12295
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__11_0_Private_Void_NPC_0;

		// Token: 0x04003008 RID: 12296
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__11_1_Private_Void_BuildableItem_0;

		// Token: 0x04003009 RID: 12297
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__11_2_Private_Void_Single_0;
	}
}
