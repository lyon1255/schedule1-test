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
	// Token: 0x0200038C RID: 908
	public class PackagerConfiguration : EntityConfiguration
	{
		// Token: 0x0600475E RID: 18270 RVA: 0x0015E214 File Offset: 0x0015C414
		// Note: this type is marked as 'beforefieldinit'.
		static PackagerConfiguration()
		{
			Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "PackagerConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr);
			PackagerConfiguration.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, "Bed");
			PackagerConfiguration.NativeFieldInfoPtr_Stations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, "Stations");
			PackagerConfiguration.NativeFieldInfoPtr_Routes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, "Routes");
			PackagerConfiguration.NativeFieldInfoPtr_AssignedStations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, "AssignedStations");
			PackagerConfiguration.NativeFieldInfoPtr_AssignedBrickPresses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, "AssignedBrickPresses");
			PackagerConfiguration.NativeFieldInfoPtr__packager_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, "<packager>k__BackingField");
			PackagerConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, "<bedItem>k__BackingField");
			PackagerConfiguration.NativeMethodInfoPtr_get_AssignedStationCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, 100672120);
			PackagerConfiguration.NativeMethodInfoPtr_get_packager_Public_get_Packager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, 100672121);
			PackagerConfiguration.NativeMethodInfoPtr_set_packager_Protected_set_Void_Packager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, 100672122);
			PackagerConfiguration.NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, 100672123);
			PackagerConfiguration.NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, 100672124);
			PackagerConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Packager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, 100672125);
			PackagerConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, 100672126);
			PackagerConfiguration.NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, 100672127);
			PackagerConfiguration.NativeMethodInfoPtr_AssignedStationsChanged_Public_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, 100672128);
			PackagerConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, 100672129);
			PackagerConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, 100672130);
			PackagerConfiguration.NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, 100672131);
			PackagerConfiguration.NativeMethodInfoPtr___ctor_b__15_0_Private_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, 100672132);
			PackagerConfiguration.NativeMethodInfoPtr___ctor_b__15_1_Private_Void_List_1_AdvancedTransitRoute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr, 100672133);
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x0600475F RID: 18271 RVA: 0x0015E3E8 File Offset: 0x0015C5E8
		public unsafe int AssignedStationCount
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 160632, RefRangeEnd = 160635, XrefRangeStart = 160630, XrefRangeEnd = 160632, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerConfiguration.NativeMethodInfoPtr_get_AssignedStationCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x06004760 RID: 18272 RVA: 0x0015E424 File Offset: 0x0015C624
		// (set) Token: 0x06004761 RID: 18273 RVA: 0x0015E464 File Offset: 0x0015C664
		public unsafe Packager packager
		{
			[CallerCount(40)]
			[CachedScanResults(RefRangeStart = 47268, RefRangeEnd = 47308, XrefRangeStart = 47268, XrefRangeEnd = 47308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerConfiguration.NativeMethodInfoPtr_get_packager_Public_get_Packager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 158947, RefRangeEnd = 158949, XrefRangeStart = 158947, XrefRangeEnd = 158949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerConfiguration.NativeMethodInfoPtr_set_packager_Protected_set_Void_Packager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17001573 RID: 5491
		// (get) Token: 0x06004762 RID: 18274 RVA: 0x0015E4A8 File Offset: 0x0015C6A8
		// (set) Token: 0x06004763 RID: 18275 RVA: 0x0015E4E8 File Offset: 0x0015C6E8
		public unsafe BedItem bedItem
		{
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 22950, RefRangeEnd = 22967, XrefRangeStart = 22950, XrefRangeEnd = 22967, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerConfiguration.NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerConfiguration.NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004764 RID: 18276 RVA: 0x0015E52C File Offset: 0x0015C72C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160773, RefRangeEnd = 160774, XrefRangeStart = 160635, XrefRangeEnd = 160773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagerConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Packager _botanist) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_botanist);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Packager_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004765 RID: 18277 RVA: 0x0015E59C File Offset: 0x0015C79C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160774, XrefRangeEnd = 160825, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagerConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004766 RID: 18278 RVA: 0x0015E5D8 File Offset: 0x0015C7D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160825, XrefRangeEnd = 160848, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsStationValid(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(PackagerConfiguration.NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06004767 RID: 18279 RVA: 0x0015E640 File Offset: 0x0015C840
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160848, XrefRangeEnd = 160944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignedStationsChanged(List<BuildableItem> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerConfiguration.NativeMethodInfoPtr_AssignedStationsChanged_Public_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004768 RID: 18280 RVA: 0x0015E684 File Offset: 0x0015C884
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160944, XrefRangeEnd = 160949, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagerConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004769 RID: 18281 RVA: 0x0015E6CC File Offset: 0x0015C8CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160949, XrefRangeEnd = 160978, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PackagerConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600476A RID: 18282 RVA: 0x0015E710 File Offset: 0x0015C910
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160978, XrefRangeEnd = 160996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BedChanged(BuildableItem newItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerConfiguration.NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600476B RID: 18283 RVA: 0x0015E754 File Offset: 0x0015C954
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__15_0(List<BuildableItem> <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerConfiguration.NativeMethodInfoPtr___ctor_b__15_0_Private_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600476C RID: 18284 RVA: 0x0015E798 File Offset: 0x0015C998
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__15_1(List<AdvancedTransitRoute> <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerConfiguration.NativeMethodInfoPtr___ctor_b__15_1_Private_Void_List_1_AdvancedTransitRoute_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600476D RID: 18285 RVA: 0x000228A5 File Offset: 0x00020AA5
		public PackagerConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700156A RID: 5482
		// (get) Token: 0x0600476E RID: 18286 RVA: 0x0015E7DC File Offset: 0x0015C9DC
		// (set) Token: 0x0600476F RID: 18287 RVA: 0x000228AE File Offset: 0x00020AAE
		public unsafe ObjectField Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfiguration.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfiguration.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700156B RID: 5483
		// (get) Token: 0x06004770 RID: 18288 RVA: 0x0015E80C File Offset: 0x0015CA0C
		// (set) Token: 0x06004771 RID: 18289 RVA: 0x000228CD File Offset: 0x00020ACD
		public unsafe ObjectListField Stations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfiguration.NativeFieldInfoPtr_Stations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfiguration.NativeFieldInfoPtr_Stations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700156C RID: 5484
		// (get) Token: 0x06004772 RID: 18290 RVA: 0x0015E83C File Offset: 0x0015CA3C
		// (set) Token: 0x06004773 RID: 18291 RVA: 0x000228EC File Offset: 0x00020AEC
		public unsafe RouteListField Routes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfiguration.NativeFieldInfoPtr_Routes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RouteListField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfiguration.NativeFieldInfoPtr_Routes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700156D RID: 5485
		// (get) Token: 0x06004774 RID: 18292 RVA: 0x0015E86C File Offset: 0x0015CA6C
		// (set) Token: 0x06004775 RID: 18293 RVA: 0x0002290B File Offset: 0x00020B0B
		public unsafe List<PackagingStation> AssignedStations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfiguration.NativeFieldInfoPtr_AssignedStations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<PackagingStation>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfiguration.NativeFieldInfoPtr_AssignedStations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x06004776 RID: 18294 RVA: 0x0015E89C File Offset: 0x0015CA9C
		// (set) Token: 0x06004777 RID: 18295 RVA: 0x0002292A File Offset: 0x00020B2A
		public unsafe List<BrickPress> AssignedBrickPresses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfiguration.NativeFieldInfoPtr_AssignedBrickPresses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BrickPress>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfiguration.NativeFieldInfoPtr_AssignedBrickPresses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x06004778 RID: 18296 RVA: 0x0015E8CC File Offset: 0x0015CACC
		// (set) Token: 0x06004779 RID: 18297 RVA: 0x00022949 File Offset: 0x00020B49
		public unsafe Packager _packager_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfiguration.NativeFieldInfoPtr__packager_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Packager>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfiguration.NativeFieldInfoPtr__packager_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x0600477A RID: 18298 RVA: 0x0015E8FC File Offset: 0x0015CAFC
		// (set) Token: 0x0600477B RID: 18299 RVA: 0x00022968 File Offset: 0x00020B68
		public unsafe BedItem _bedItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BedItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400300A RID: 12298
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x0400300B RID: 12299
		private static readonly IntPtr NativeFieldInfoPtr_Stations;

		// Token: 0x0400300C RID: 12300
		private static readonly IntPtr NativeFieldInfoPtr_Routes;

		// Token: 0x0400300D RID: 12301
		private static readonly IntPtr NativeFieldInfoPtr_AssignedStations;

		// Token: 0x0400300E RID: 12302
		private static readonly IntPtr NativeFieldInfoPtr_AssignedBrickPresses;

		// Token: 0x0400300F RID: 12303
		private static readonly IntPtr NativeFieldInfoPtr__packager_k__BackingField;

		// Token: 0x04003010 RID: 12304
		private static readonly IntPtr NativeFieldInfoPtr__bedItem_k__BackingField;

		// Token: 0x04003011 RID: 12305
		private static readonly IntPtr NativeMethodInfoPtr_get_AssignedStationCount_Public_get_Int32_0;

		// Token: 0x04003012 RID: 12306
		private static readonly IntPtr NativeMethodInfoPtr_get_packager_Public_get_Packager_0;

		// Token: 0x04003013 RID: 12307
		private static readonly IntPtr NativeMethodInfoPtr_set_packager_Protected_set_Void_Packager_0;

		// Token: 0x04003014 RID: 12308
		private static readonly IntPtr NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0;

		// Token: 0x04003015 RID: 12309
		private static readonly IntPtr NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0;

		// Token: 0x04003016 RID: 12310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Packager_0;

		// Token: 0x04003017 RID: 12311
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x04003018 RID: 12312
		private static readonly IntPtr NativeMethodInfoPtr_IsStationValid_Private_Boolean_BuildableItem_byref_String_0;

		// Token: 0x04003019 RID: 12313
		private static readonly IntPtr NativeMethodInfoPtr_AssignedStationsChanged_Public_Void_List_1_BuildableItem_0;

		// Token: 0x0400301A RID: 12314
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x0400301B RID: 12315
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x0400301C RID: 12316
		private static readonly IntPtr NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0;

		// Token: 0x0400301D RID: 12317
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__15_0_Private_Void_List_1_BuildableItem_0;

		// Token: 0x0400301E RID: 12318
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__15_1_Private_Void_List_1_AdvancedTransitRoute_0;
	}
}
