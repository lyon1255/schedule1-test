using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.EntityFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.UI.Management;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000396 RID: 918
	public class ObjectListField : ConfigField
	{
		// Token: 0x06004810 RID: 18448 RVA: 0x00160B7C File Offset: 0x0015ED7C
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectListField()
		{
			Il2CppClassPointerStore<ObjectListField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ObjectListField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr);
			ObjectListField.NativeFieldInfoPtr_SelectedObjects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "SelectedObjects");
			ObjectListField.NativeFieldInfoPtr_MaxItems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "MaxItems");
			ObjectListField.NativeFieldInfoPtr_objectFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "objectFilter");
			ObjectListField.NativeFieldInfoPtr_TypeRequirements = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "TypeRequirements");
			ObjectListField.NativeFieldInfoPtr_onListChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, "onListChanged");
			ObjectListField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672206);
			ObjectListField.NativeMethodInfoPtr_SetList_Public_Void_List_1_BuildableItem_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672207);
			ObjectListField.NativeMethodInfoPtr_AddItem_Public_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672208);
			ObjectListField.NativeMethodInfoPtr_RemoveItem_Public_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672209);
			ObjectListField.NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_BuildableItem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672210);
			ObjectListField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672211);
			ObjectListField.NativeMethodInfoPtr_GetData_Public_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672212);
			ObjectListField.NativeMethodInfoPtr_Load_Public_Void_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr, 100672213);
		}

		// Token: 0x06004811 RID: 18449 RVA: 0x00160CB0 File Offset: 0x0015EEB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 161604, RefRangeEnd = 161608, XrefRangeStart = 161582, XrefRangeEnd = 161604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectListField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectListField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004812 RID: 18450 RVA: 0x00160CFC File Offset: 0x0015EEFC
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 161668, RefRangeEnd = 161673, XrefRangeStart = 161608, XrefRangeEnd = 161668, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetList(List<BuildableItem> list, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(list);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_SetList_Public_Void_List_1_BuildableItem_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004813 RID: 18451 RVA: 0x00160D4C File Offset: 0x0015EF4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161673, XrefRangeEnd = 161690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddItem(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_AddItem_Public_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004814 RID: 18452 RVA: 0x00160D90 File Offset: 0x0015EF90
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 161703, RefRangeEnd = 161705, XrefRangeStart = 161690, XrefRangeEnd = 161703, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveItem(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_RemoveItem_Public_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004815 RID: 18453 RVA: 0x00160DD4 File Offset: 0x0015EFD4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161705, XrefRangeEnd = 161718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SelectedObjectDestroyed(BuildableItem item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_BuildableItem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004816 RID: 18454 RVA: 0x00160E18 File Offset: 0x0015F018
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161718, XrefRangeEnd = 161719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ObjectListField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004817 RID: 18455 RVA: 0x00160E60 File Offset: 0x0015F060
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 161740, RefRangeEnd = 161744, XrefRangeStart = 161719, XrefRangeEnd = 161740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectListFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_GetData_Public_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ObjectListFieldData>(intPtr3) : null;
		}

		// Token: 0x06004818 RID: 18456 RVA: 0x00160EA0 File Offset: 0x0015F0A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 161773, RefRangeEnd = 161777, XrefRangeStart = 161744, XrefRangeEnd = 161773, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ObjectListFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectListField.NativeMethodInfoPtr_Load_Public_Void_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06004819 RID: 18457 RVA: 0x00022D92 File Offset: 0x00020F92
		public ObjectListField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700159D RID: 5533
		// (get) Token: 0x0600481A RID: 18458 RVA: 0x00160EE4 File Offset: 0x0015F0E4
		// (set) Token: 0x0600481B RID: 18459 RVA: 0x00022D9B File Offset: 0x00020F9B
		public unsafe List<BuildableItem> SelectedObjects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_SelectedObjects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<BuildableItem>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_SelectedObjects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700159E RID: 5534
		// (get) Token: 0x0600481C RID: 18460 RVA: 0x00160F14 File Offset: 0x0015F114
		// (set) Token: 0x0600481D RID: 18461 RVA: 0x00022DBA File Offset: 0x00020FBA
		public unsafe int MaxItems
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_MaxItems);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_MaxItems)) = value;
			}
		}

		// Token: 0x1700159F RID: 5535
		// (get) Token: 0x0600481E RID: 18462 RVA: 0x00160F3C File Offset: 0x0015F13C
		// (set) Token: 0x0600481F RID: 18463 RVA: 0x00022DD5 File Offset: 0x00020FD5
		public unsafe ObjectSelector.ObjectFilter objectFilter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_objectFilter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectSelector.ObjectFilter>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_objectFilter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A0 RID: 5536
		// (get) Token: 0x06004820 RID: 18464 RVA: 0x00160F6C File Offset: 0x0015F16C
		// (set) Token: 0x06004821 RID: 18465 RVA: 0x00022DF4 File Offset: 0x00020FF4
		public unsafe List<Type> TypeRequirements
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_TypeRequirements);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_TypeRequirements), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170015A1 RID: 5537
		// (get) Token: 0x06004822 RID: 18466 RVA: 0x00160F9C File Offset: 0x0015F19C
		// (set) Token: 0x06004823 RID: 18467 RVA: 0x00022E13 File Offset: 0x00021013
		public unsafe UnityEvent<List<BuildableItem>> onListChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_onListChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<List<BuildableItem>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectListField.NativeFieldInfoPtr_onListChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003092 RID: 12434
		private static readonly IntPtr NativeFieldInfoPtr_SelectedObjects;

		// Token: 0x04003093 RID: 12435
		private static readonly IntPtr NativeFieldInfoPtr_MaxItems;

		// Token: 0x04003094 RID: 12436
		private static readonly IntPtr NativeFieldInfoPtr_objectFilter;

		// Token: 0x04003095 RID: 12437
		private static readonly IntPtr NativeFieldInfoPtr_TypeRequirements;

		// Token: 0x04003096 RID: 12438
		private static readonly IntPtr NativeFieldInfoPtr_onListChanged;

		// Token: 0x04003097 RID: 12439
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x04003098 RID: 12440
		private static readonly IntPtr NativeMethodInfoPtr_SetList_Public_Void_List_1_BuildableItem_Boolean_0;

		// Token: 0x04003099 RID: 12441
		private static readonly IntPtr NativeMethodInfoPtr_AddItem_Public_Void_BuildableItem_0;

		// Token: 0x0400309A RID: 12442
		private static readonly IntPtr NativeMethodInfoPtr_RemoveItem_Public_Void_BuildableItem_0;

		// Token: 0x0400309B RID: 12443
		private static readonly IntPtr NativeMethodInfoPtr_SelectedObjectDestroyed_Private_Void_BuildableItem_0;

		// Token: 0x0400309C RID: 12444
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x0400309D RID: 12445
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_ObjectListFieldData_0;

		// Token: 0x0400309E RID: 12446
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_ObjectListFieldData_0;
	}
}
