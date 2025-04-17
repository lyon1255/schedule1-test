using System;
using Il2CppFishNet.Connection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000389 RID: 905
	public class EntityConfiguration : Object
	{
		// Token: 0x06004710 RID: 18192 RVA: 0x0015CE50 File Offset: 0x0015B050
		// Note: this type is marked as 'beforefieldinit'.
		static EntityConfiguration()
		{
			Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "EntityConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr);
			EntityConfiguration.NativeFieldInfoPtr__Replicator_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "<Replicator>k__BackingField");
			EntityConfiguration.NativeFieldInfoPtr__Configurable_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "<Configurable>k__BackingField");
			EntityConfiguration.NativeFieldInfoPtr_Fields = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "Fields");
			EntityConfiguration.NativeFieldInfoPtr_onChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "onChanged");
			EntityConfiguration.NativeFieldInfoPtr__IsSelected_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, "<IsSelected>k__BackingField");
			EntityConfiguration.NativeMethodInfoPtr_get_Replicator_Public_get_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672076);
			EntityConfiguration.NativeMethodInfoPtr_set_Replicator_Protected_set_Void_ConfigurationReplicator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672077);
			EntityConfiguration.NativeMethodInfoPtr_get_Configurable_Public_get_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672078);
			EntityConfiguration.NativeMethodInfoPtr_set_Configurable_Protected_set_Void_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672079);
			EntityConfiguration.NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672080);
			EntityConfiguration.NativeMethodInfoPtr_set_IsSelected_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672081);
			EntityConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672082);
			EntityConfiguration.NativeMethodInfoPtr_InvokeChanged_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672083);
			EntityConfiguration.NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672084);
			EntityConfiguration.NativeMethodInfoPtr_ReplicateAllFields_Public_Void_NetworkConnection_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672085);
			EntityConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672086);
			EntityConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672087);
			EntityConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672088);
			EntityConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672089);
			EntityConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr, 100672090);
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06004711 RID: 18193 RVA: 0x0015D010 File Offset: 0x0015B210
		// (set) Token: 0x06004712 RID: 18194 RVA: 0x0015D050 File Offset: 0x0015B250
		public unsafe ConfigurationReplicator Replicator
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 17383, RefRangeEnd = 17393, XrefRangeStart = 17383, XrefRangeEnd = 17393, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_get_Replicator_Public_get_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr3) : null;
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 29994, RefRangeEnd = 29996, XrefRangeStart = 29994, XrefRangeEnd = 29996, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_set_Replicator_Protected_set_Void_ConfigurationReplicator_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x06004713 RID: 18195 RVA: 0x0015D094 File Offset: 0x0015B294
		// (set) Token: 0x06004714 RID: 18196 RVA: 0x0015D0D4 File Offset: 0x0015B2D4
		public unsafe IConfigurable Configurable
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_get_Configurable_Public_get_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_set_Configurable_Protected_set_Void_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x06004715 RID: 18197 RVA: 0x0015D118 File Offset: 0x0015B318
		// (set) Token: 0x06004716 RID: 18198 RVA: 0x0015D154 File Offset: 0x0015B354
		public unsafe bool IsSelected
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_set_IsSelected_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004717 RID: 18199 RVA: 0x0015D194 File Offset: 0x0015B394
		[CallerCount(12)]
		[CachedScanResults(RefRangeStart = 160388, RefRangeEnd = 160400, XrefRangeStart = 160371, XrefRangeEnd = 160388, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityConfiguration(ConfigurationReplicator replicator, IConfigurable configurable) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004718 RID: 18200 RVA: 0x0015D1F4 File Offset: 0x0015B3F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void InvokeChanged()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_InvokeChanged_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004719 RID: 18201 RVA: 0x0015D228 File Offset: 0x0015B428
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160400, XrefRangeEnd = 160402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateField(ConfigField field, NetworkConnection conn = null)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(field);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(conn);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600471A RID: 18202 RVA: 0x0015D27C File Offset: 0x0015B47C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160402, XrefRangeEnd = 160417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReplicateAllFields(NetworkConnection conn = null, bool replicateDefaults = true)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(conn);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref replicateDefaults;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityConfiguration.NativeMethodInfoPtr_ReplicateAllFields_Public_Void_NetworkConnection_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600471B RID: 18203 RVA: 0x0015D2CC File Offset: 0x0015B4CC
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600471C RID: 18204 RVA: 0x0015D308 File Offset: 0x0015B508
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 77278, RefRangeEnd = 77287, XrefRangeStart = 77278, XrefRangeEnd = 77287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Selected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600471D RID: 18205 RVA: 0x0015D344 File Offset: 0x0015B544
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 160417, RefRangeEnd = 160430, XrefRangeStart = 160417, XrefRangeEnd = 160417, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Deselected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600471E RID: 18206 RVA: 0x0015D380 File Offset: 0x0015B580
		[CallerCount(183)]
		[CachedScanResults(RefRangeStart = 35949, RefRangeEnd = 36132, XrefRangeStart = 35949, XrefRangeEnd = 36132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600471F RID: 18207 RVA: 0x0015D3C8 File Offset: 0x0015B5C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160430, XrefRangeEnd = 160432, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), EntityConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06004720 RID: 18208 RVA: 0x000226DC File Offset: 0x000208DC
		public EntityConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001555 RID: 5461
		// (get) Token: 0x06004721 RID: 18209 RVA: 0x0015D40C File Offset: 0x0015B60C
		// (set) Token: 0x06004722 RID: 18210 RVA: 0x000226E5 File Offset: 0x000208E5
		public unsafe ConfigurationReplicator _Replicator_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Replicator_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConfigurationReplicator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Replicator_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001556 RID: 5462
		// (get) Token: 0x06004723 RID: 18211 RVA: 0x0015D43C File Offset: 0x0015B63C
		// (set) Token: 0x06004724 RID: 18212 RVA: 0x00022704 File Offset: 0x00020904
		public unsafe IConfigurable _Configurable_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Configurable_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IConfigurable>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__Configurable_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001557 RID: 5463
		// (get) Token: 0x06004725 RID: 18213 RVA: 0x0015D46C File Offset: 0x0015B66C
		// (set) Token: 0x06004726 RID: 18214 RVA: 0x00022723 File Offset: 0x00020923
		public unsafe List<ConfigField> Fields
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr_Fields);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ConfigField>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr_Fields), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001558 RID: 5464
		// (get) Token: 0x06004727 RID: 18215 RVA: 0x0015D49C File Offset: 0x0015B69C
		// (set) Token: 0x06004728 RID: 18216 RVA: 0x00022742 File Offset: 0x00020942
		public unsafe UnityEvent onChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr_onChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr_onChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06004729 RID: 18217 RVA: 0x0015D4CC File Offset: 0x0015B6CC
		// (set) Token: 0x0600472A RID: 18218 RVA: 0x00022761 File Offset: 0x00020961
		public unsafe bool _IsSelected_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__IsSelected_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EntityConfiguration.NativeFieldInfoPtr__IsSelected_k__BackingField)) = value;
			}
		}

		// Token: 0x04002FD0 RID: 12240
		private static readonly IntPtr NativeFieldInfoPtr__Replicator_k__BackingField;

		// Token: 0x04002FD1 RID: 12241
		private static readonly IntPtr NativeFieldInfoPtr__Configurable_k__BackingField;

		// Token: 0x04002FD2 RID: 12242
		private static readonly IntPtr NativeFieldInfoPtr_Fields;

		// Token: 0x04002FD3 RID: 12243
		private static readonly IntPtr NativeFieldInfoPtr_onChanged;

		// Token: 0x04002FD4 RID: 12244
		private static readonly IntPtr NativeFieldInfoPtr__IsSelected_k__BackingField;

		// Token: 0x04002FD5 RID: 12245
		private static readonly IntPtr NativeMethodInfoPtr_get_Replicator_Public_get_ConfigurationReplicator_0;

		// Token: 0x04002FD6 RID: 12246
		private static readonly IntPtr NativeMethodInfoPtr_set_Replicator_Protected_set_Void_ConfigurationReplicator_0;

		// Token: 0x04002FD7 RID: 12247
		private static readonly IntPtr NativeMethodInfoPtr_get_Configurable_Public_get_IConfigurable_0;

		// Token: 0x04002FD8 RID: 12248
		private static readonly IntPtr NativeMethodInfoPtr_set_Configurable_Protected_set_Void_IConfigurable_0;

		// Token: 0x04002FD9 RID: 12249
		private static readonly IntPtr NativeMethodInfoPtr_get_IsSelected_Public_get_Boolean_0;

		// Token: 0x04002FDA RID: 12250
		private static readonly IntPtr NativeMethodInfoPtr_set_IsSelected_Protected_set_Void_Boolean_0;

		// Token: 0x04002FDB RID: 12251
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_0;

		// Token: 0x04002FDC RID: 12252
		private static readonly IntPtr NativeMethodInfoPtr_InvokeChanged_Protected_Void_0;

		// Token: 0x04002FDD RID: 12253
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateField_Public_Void_ConfigField_NetworkConnection_0;

		// Token: 0x04002FDE RID: 12254
		private static readonly IntPtr NativeMethodInfoPtr_ReplicateAllFields_Public_Void_NetworkConnection_Boolean_0;

		// Token: 0x04002FDF RID: 12255
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_New_Void_0;

		// Token: 0x04002FE0 RID: 12256
		private static readonly IntPtr NativeMethodInfoPtr_Selected_Public_Virtual_New_Void_0;

		// Token: 0x04002FE1 RID: 12257
		private static readonly IntPtr NativeMethodInfoPtr_Deselected_Public_Virtual_New_Void_0;

		// Token: 0x04002FE2 RID: 12258
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_New_Boolean_0;

		// Token: 0x04002FE3 RID: 12259
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_New_String_0;
	}
}
