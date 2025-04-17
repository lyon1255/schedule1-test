using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.NPCs;
using Il2CppScheduleOne.ObjectScripts;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000388 RID: 904
	public class DryingRackConfiguration : EntityConfiguration
	{
		// Token: 0x060046F5 RID: 18165 RVA: 0x0015C774 File Offset: 0x0015A974
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackConfiguration()
		{
			Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "DryingRackConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr);
			DryingRackConfiguration.NativeFieldInfoPtr__Rack_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, "<Rack>k__BackingField");
			DryingRackConfiguration.NativeFieldInfoPtr_AssignedBotanist = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, "AssignedBotanist");
			DryingRackConfiguration.NativeFieldInfoPtr_TargetQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, "TargetQuality");
			DryingRackConfiguration.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, "Destination");
			DryingRackConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, "<DestinationRoute>k__BackingField");
			DryingRackConfiguration.NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100672061);
			DryingRackConfiguration.NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100672062);
			DryingRackConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100672063);
			DryingRackConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100672064);
			DryingRackConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_DryingRack_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100672065);
			DryingRackConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100672066);
			DryingRackConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100672067);
			DryingRackConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100672068);
			DryingRackConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100672069);
			DryingRackConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100672070);
			DryingRackConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100672071);
			DryingRackConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100672072);
			DryingRackConfiguration.NativeMethodInfoPtr___ctor_b__11_0_Private_Void_NPC_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100672073);
			DryingRackConfiguration.NativeMethodInfoPtr___ctor_b__11_1_Private_Void_EQuality_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100672074);
			DryingRackConfiguration.NativeMethodInfoPtr___ctor_b__11_2_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr, 100672075);
		}

		// Token: 0x17001553 RID: 5459
		// (get) Token: 0x060046F6 RID: 18166 RVA: 0x0015C934 File Offset: 0x0015AB34
		// (set) Token: 0x060046F7 RID: 18167 RVA: 0x0015C974 File Offset: 0x0015AB74
		public unsafe DryingRack Rack
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 19662, RefRangeEnd = 19669, XrefRangeStart = 19662, XrefRangeEnd = 19669, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001554 RID: 5460
		// (get) Token: 0x060046F8 RID: 18168 RVA: 0x0015C9B8 File Offset: 0x0015ABB8
		// (set) Token: 0x060046F9 RID: 18169 RVA: 0x0015C9F8 File Offset: 0x0015ABF8
		public unsafe TransitRoute DestinationRoute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046FA RID: 18170 RVA: 0x0015CA3C File Offset: 0x0015AC3C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160330, RefRangeEnd = 160331, XrefRangeStart = 160255, XrefRangeEnd = 160330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, DryingRack rack) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(rack);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_DryingRack_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046FB RID: 18171 RVA: 0x0015CAAC File Offset: 0x0015ACAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046FC RID: 18172 RVA: 0x0015CAE8 File Offset: 0x0015ACE8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160331, XrefRangeEnd = 160340, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestinationChanged(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046FD RID: 18173 RVA: 0x0015CB2C File Offset: 0x0015AD2C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160340, XrefRangeEnd = 160357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool DestinationFilter(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060046FE RID: 18174 RVA: 0x0015CB94 File Offset: 0x0015AD94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046FF RID: 18175 RVA: 0x0015CBD0 File Offset: 0x0015ADD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Deselected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004700 RID: 18176 RVA: 0x0015CC0C File Offset: 0x0015AE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160357, XrefRangeEnd = 160361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004701 RID: 18177 RVA: 0x0015CC54 File Offset: 0x0015AE54
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160361, XrefRangeEnd = 160371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), DryingRackConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004702 RID: 18178 RVA: 0x0015CC98 File Offset: 0x0015AE98
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__11_0(NPC <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr___ctor_b__11_0_Private_Void_NPC_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004703 RID: 18179 RVA: 0x0015CCDC File Offset: 0x0015AEDC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__11_1(EQuality <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref <p0>;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr___ctor_b__11_1_Private_Void_EQuality_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004704 RID: 18180 RVA: 0x0015CD1C File Offset: 0x0015AF1C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__11_2(BuildableItem <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfiguration.NativeMethodInfoPtr___ctor_b__11_2_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004705 RID: 18181 RVA: 0x00022638 File Offset: 0x00020838
		public DryingRackConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06004706 RID: 18182 RVA: 0x0015CD60 File Offset: 0x0015AF60
		// (set) Token: 0x06004707 RID: 18183 RVA: 0x00022641 File Offset: 0x00020841
		public unsafe DryingRack _Rack_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr__Rack_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DryingRack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr__Rack_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06004708 RID: 18184 RVA: 0x0015CD90 File Offset: 0x0015AF90
		// (set) Token: 0x06004709 RID: 18185 RVA: 0x00022660 File Offset: 0x00020860
		public unsafe NPCField AssignedBotanist
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr_AssignedBotanist);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NPCField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr_AssignedBotanist), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001550 RID: 5456
		// (get) Token: 0x0600470A RID: 18186 RVA: 0x0015CDC0 File Offset: 0x0015AFC0
		// (set) Token: 0x0600470B RID: 18187 RVA: 0x0002267F File Offset: 0x0002087F
		public unsafe QualityField TargetQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr_TargetQuality);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr_TargetQuality), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001551 RID: 5457
		// (get) Token: 0x0600470C RID: 18188 RVA: 0x0015CDF0 File Offset: 0x0015AFF0
		// (set) Token: 0x0600470D RID: 18189 RVA: 0x0002269E File Offset: 0x0002089E
		public unsafe ObjectField Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001552 RID: 5458
		// (get) Token: 0x0600470E RID: 18190 RVA: 0x0015CE20 File Offset: 0x0015B020
		// (set) Token: 0x0600470F RID: 18191 RVA: 0x000226BD File Offset: 0x000208BD
		public unsafe TransitRoute _DestinationRoute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TransitRoute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfiguration.NativeFieldInfoPtr__DestinationRoute_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002FBC RID: 12220
		private static readonly IntPtr NativeFieldInfoPtr__Rack_k__BackingField;

		// Token: 0x04002FBD RID: 12221
		private static readonly IntPtr NativeFieldInfoPtr_AssignedBotanist;

		// Token: 0x04002FBE RID: 12222
		private static readonly IntPtr NativeFieldInfoPtr_TargetQuality;

		// Token: 0x04002FBF RID: 12223
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04002FC0 RID: 12224
		private static readonly IntPtr NativeFieldInfoPtr__DestinationRoute_k__BackingField;

		// Token: 0x04002FC1 RID: 12225
		private static readonly IntPtr NativeMethodInfoPtr_get_Rack_Public_get_DryingRack_0;

		// Token: 0x04002FC2 RID: 12226
		private static readonly IntPtr NativeMethodInfoPtr_set_Rack_Protected_set_Void_DryingRack_0;

		// Token: 0x04002FC3 RID: 12227
		private static readonly IntPtr NativeMethodInfoPtr_get_DestinationRoute_Public_get_TransitRoute_0;

		// Token: 0x04002FC4 RID: 12228
		private static readonly IntPtr NativeMethodInfoPtr_set_DestinationRoute_Protected_set_Void_TransitRoute_0;

		// Token: 0x04002FC5 RID: 12229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_DryingRack_0;

		// Token: 0x04002FC6 RID: 12230
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x04002FC7 RID: 12231
		private static readonly IntPtr NativeMethodInfoPtr_DestinationChanged_Private_Void_BuildableItem_0;

		// Token: 0x04002FC8 RID: 12232
		private static readonly IntPtr NativeMethodInfoPtr_DestinationFilter_Public_Boolean_BuildableItem_byref_String_0;

		// Token: 0x04002FC9 RID: 12233
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Public_Virtual_Void_0;

		// Token: 0x04002FCA RID: 12234
		private static readonly IntPtr NativeMethodInfoPtr_Deselected_Public_Virtual_Void_0;

		// Token: 0x04002FCB RID: 12235
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04002FCC RID: 12236
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04002FCD RID: 12237
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__11_0_Private_Void_NPC_0;

		// Token: 0x04002FCE RID: 12238
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__11_1_Private_Void_EQuality_0;

		// Token: 0x04002FCF RID: 12239
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__11_2_Private_Void_BuildableItem_0;
	}
}
