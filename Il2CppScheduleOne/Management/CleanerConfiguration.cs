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
	// Token: 0x02000387 RID: 903
	public class CleanerConfiguration : EntityConfiguration
	{
		// Token: 0x060046DB RID: 18139 RVA: 0x0015C0E0 File Offset: 0x0015A2E0
		// Note: this type is marked as 'beforefieldinit'.
		static CleanerConfiguration()
		{
			Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "CleanerConfiguration");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr);
			CleanerConfiguration.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, "Bed");
			CleanerConfiguration.NativeFieldInfoPtr_Bins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, "Bins");
			CleanerConfiguration.NativeFieldInfoPtr__cleaner_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, "<cleaner>k__BackingField");
			CleanerConfiguration.NativeFieldInfoPtr__binItems_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, "<binItems>k__BackingField");
			CleanerConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, "<bedItem>k__BackingField");
			CleanerConfiguration.NativeMethodInfoPtr_get_cleaner_Public_get_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672047);
			CleanerConfiguration.NativeMethodInfoPtr_set_cleaner_Protected_set_Void_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672048);
			CleanerConfiguration.NativeMethodInfoPtr_get_binItems_Public_get_List_1_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672049);
			CleanerConfiguration.NativeMethodInfoPtr_set_binItems_Private_set_Void_List_1_TrashContainerItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672050);
			CleanerConfiguration.NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672051);
			CleanerConfiguration.NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672052);
			CleanerConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Cleaner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672053);
			CleanerConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672054);
			CleanerConfiguration.NativeMethodInfoPtr_IsObjValid_Private_Boolean_BuildableItem_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672055);
			CleanerConfiguration.NativeMethodInfoPtr_AssignedBinsChanged_Public_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672056);
			CleanerConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672057);
			CleanerConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672058);
			CleanerConfiguration.NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672059);
			CleanerConfiguration.NativeMethodInfoPtr___ctor_b__14_0_Private_Void_List_1_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr, 100672060);
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x060046DC RID: 18140 RVA: 0x0015C28C File Offset: 0x0015A48C
		// (set) Token: 0x060046DD RID: 18141 RVA: 0x0015C2CC File Offset: 0x0015A4CC
		public unsafe Cleaner cleaner
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_get_cleaner_Public_get_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_set_cleaner_Protected_set_Void_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x060046DE RID: 18142 RVA: 0x0015C310 File Offset: 0x0015A510
		// (set) Token: 0x060046DF RID: 18143 RVA: 0x0015C350 File Offset: 0x0015A550
		public unsafe List<TrashContainerItem> binItems
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 16596, RefRangeEnd = 16597, XrefRangeStart = 16596, XrefRangeEnd = 16597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_get_binItems_Public_get_List_1_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<TrashContainerItem>>(intPtr3) : null;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 38372, RefRangeEnd = 38373, XrefRangeStart = 38372, XrefRangeEnd = 38373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_set_binItems_Private_set_Void_List_1_TrashContainerItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x060046E0 RID: 18144 RVA: 0x0015C394 File Offset: 0x0015A594
		// (set) Token: 0x060046E1 RID: 18145 RVA: 0x0015C3D4 File Offset: 0x0015A5D4
		public unsafe BedItem bedItem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x0015C418 File Offset: 0x0015A618
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 160179, RefRangeEnd = 160180, XrefRangeStart = 160102, XrefRangeEnd = 160179, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanerConfiguration(ConfigurationReplicator replicator, IConfigurable configurable, Cleaner _cleaner) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerConfiguration>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(replicator);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(configurable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(_cleaner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Cleaner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x0015C488 File Offset: 0x0015A688
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160180, XrefRangeEnd = 160182, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Destroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerConfiguration.NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x0015C4C4 File Offset: 0x0015A6C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160182, XrefRangeEnd = 160194, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsObjValid(BuildableItem obj, out string reason)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr = 0;
			ptr2 = &intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_IsObjValid_Private_Boolean_BuildableItem_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			reason = IL2CPP.Il2CppStringToManaged(intPtr);
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x060046E5 RID: 18149 RVA: 0x0015C52C File Offset: 0x0015A72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160194, XrefRangeEnd = 160225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AssignedBinsChanged(List<BuildableItem> objects)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(objects);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_AssignedBinsChanged_Public_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x0015C570 File Offset: 0x0015A770
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160225, XrefRangeEnd = 160230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool ShouldSave()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerConfiguration.NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060046E7 RID: 18151 RVA: 0x0015C5B8 File Offset: 0x0015A7B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160230, XrefRangeEnd = 160237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetSaveString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CleanerConfiguration.NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x0015C5FC File Offset: 0x0015A7FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 160237, XrefRangeEnd = 160255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void BedChanged(BuildableItem newItem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(newItem);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x0015C640 File Offset: 0x0015A840
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 141788, RefRangeEnd = 141792, XrefRangeStart = 141788, XrefRangeEnd = 141792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void __ctor_b__14_0(List<BuildableItem> <p0>)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfiguration.NativeMethodInfoPtr___ctor_b__14_0_Private_Void_List_1_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046EA RID: 18154 RVA: 0x00022594 File Offset: 0x00020794
		public CleanerConfiguration(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x060046EB RID: 18155 RVA: 0x0015C684 File Offset: 0x0015A884
		// (set) Token: 0x060046EC RID: 18156 RVA: 0x0002259D File Offset: 0x0002079D
		public unsafe ObjectField Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x060046ED RID: 18157 RVA: 0x0015C6B4 File Offset: 0x0015A8B4
		// (set) Token: 0x060046EE RID: 18158 RVA: 0x000225BC File Offset: 0x000207BC
		public unsafe ObjectListField Bins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr_Bins);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListField>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr_Bins), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x060046EF RID: 18159 RVA: 0x0015C6E4 File Offset: 0x0015A8E4
		// (set) Token: 0x060046F0 RID: 18160 RVA: 0x000225DB File Offset: 0x000207DB
		public unsafe Cleaner _cleaner_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr__cleaner_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Cleaner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr__cleaner_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x060046F1 RID: 18161 RVA: 0x0015C714 File Offset: 0x0015A914
		// (set) Token: 0x060046F2 RID: 18162 RVA: 0x000225FA File Offset: 0x000207FA
		public unsafe List<TrashContainerItem> _binItems_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr__binItems_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<TrashContainerItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr__binItems_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x060046F3 RID: 18163 RVA: 0x0015C744 File Offset: 0x0015A944
		// (set) Token: 0x060046F4 RID: 18164 RVA: 0x00022619 File Offset: 0x00020819
		public unsafe BedItem _bedItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BedItem>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfiguration.NativeFieldInfoPtr__bedItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002FA9 RID: 12201
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x04002FAA RID: 12202
		private static readonly IntPtr NativeFieldInfoPtr_Bins;

		// Token: 0x04002FAB RID: 12203
		private static readonly IntPtr NativeFieldInfoPtr__cleaner_k__BackingField;

		// Token: 0x04002FAC RID: 12204
		private static readonly IntPtr NativeFieldInfoPtr__binItems_k__BackingField;

		// Token: 0x04002FAD RID: 12205
		private static readonly IntPtr NativeFieldInfoPtr__bedItem_k__BackingField;

		// Token: 0x04002FAE RID: 12206
		private static readonly IntPtr NativeMethodInfoPtr_get_cleaner_Public_get_Cleaner_0;

		// Token: 0x04002FAF RID: 12207
		private static readonly IntPtr NativeMethodInfoPtr_set_cleaner_Protected_set_Void_Cleaner_0;

		// Token: 0x04002FB0 RID: 12208
		private static readonly IntPtr NativeMethodInfoPtr_get_binItems_Public_get_List_1_TrashContainerItem_0;

		// Token: 0x04002FB1 RID: 12209
		private static readonly IntPtr NativeMethodInfoPtr_set_binItems_Private_set_Void_List_1_TrashContainerItem_0;

		// Token: 0x04002FB2 RID: 12210
		private static readonly IntPtr NativeMethodInfoPtr_get_bedItem_Public_get_BedItem_0;

		// Token: 0x04002FB3 RID: 12211
		private static readonly IntPtr NativeMethodInfoPtr_set_bedItem_Private_set_Void_BedItem_0;

		// Token: 0x04002FB4 RID: 12212
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConfigurationReplicator_IConfigurable_Cleaner_0;

		// Token: 0x04002FB5 RID: 12213
		private static readonly IntPtr NativeMethodInfoPtr_Destroy_Public_Virtual_Void_0;

		// Token: 0x04002FB6 RID: 12214
		private static readonly IntPtr NativeMethodInfoPtr_IsObjValid_Private_Boolean_BuildableItem_byref_String_0;

		// Token: 0x04002FB7 RID: 12215
		private static readonly IntPtr NativeMethodInfoPtr_AssignedBinsChanged_Public_Void_List_1_BuildableItem_0;

		// Token: 0x04002FB8 RID: 12216
		private static readonly IntPtr NativeMethodInfoPtr_ShouldSave_Public_Virtual_Boolean_0;

		// Token: 0x04002FB9 RID: 12217
		private static readonly IntPtr NativeMethodInfoPtr_GetSaveString_Public_Virtual_String_0;

		// Token: 0x04002FBA RID: 12218
		private static readonly IntPtr NativeMethodInfoPtr_BedChanged_Private_Void_BuildableItem_0;

		// Token: 0x04002FBB RID: 12219
		private static readonly IntPtr NativeMethodInfoPtr___ctor_b__14_0_Private_Void_List_1_BuildableItem_0;
	}
}
