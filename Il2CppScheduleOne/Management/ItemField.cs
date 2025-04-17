using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;

namespace Il2CppScheduleOne.Management
{
	// Token: 0x02000392 RID: 914
	public class ItemField : ConfigField
	{
		// Token: 0x060047C3 RID: 18371 RVA: 0x0015FA38 File Offset: 0x0015DC38
		// Note: this type is marked as 'beforefieldinit'.
		static ItemField()
		{
			Il2CppClassPointerStore<ItemField>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Management", "ItemField");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ItemField>.NativeClassPtr);
			ItemField.NativeFieldInfoPtr__SelectedItem_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemField>.NativeClassPtr, "<SelectedItem>k__BackingField");
			ItemField.NativeFieldInfoPtr_CanSelectNone = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemField>.NativeClassPtr, "CanSelectNone");
			ItemField.NativeFieldInfoPtr_Options = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemField>.NativeClassPtr, "Options");
			ItemField.NativeFieldInfoPtr_onItemChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ItemField>.NativeClassPtr, "onItemChanged");
			ItemField.NativeMethodInfoPtr_get_SelectedItem_Public_get_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672171);
			ItemField.NativeMethodInfoPtr_set_SelectedItem_Protected_set_Void_ItemDefinition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672172);
			ItemField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672173);
			ItemField.NativeMethodInfoPtr_SetItem_Public_Void_ItemDefinition_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672174);
			ItemField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672175);
			ItemField.NativeMethodInfoPtr_GetData_Public_ItemFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672176);
			ItemField.NativeMethodInfoPtr_Load_Public_Void_ItemFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ItemField>.NativeClassPtr, 100672177);
		}

		// Token: 0x1700158A RID: 5514
		// (get) Token: 0x060047C4 RID: 18372 RVA: 0x0015FB44 File Offset: 0x0015DD44
		// (set) Token: 0x060047C5 RID: 18373 RVA: 0x0015FB84 File Offset: 0x0015DD84
		public unsafe ItemDefinition SelectedItem
		{
			[CallerCount(14)]
			[CachedScanResults(RefRangeStart = 2430, RefRangeEnd = 2444, XrefRangeStart = 2430, XrefRangeEnd = 2444, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_get_SelectedItem_Public_get_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr3) : null;
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_set_SelectedItem_Protected_set_Void_ItemDefinition_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060047C6 RID: 18374 RVA: 0x0015FBC8 File Offset: 0x0015DDC8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 161328, RefRangeEnd = 161332, XrefRangeStart = 161313, XrefRangeEnd = 161328, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemField(EntityConfiguration parentConfig) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ItemField>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(parentConfig);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047C7 RID: 18375 RVA: 0x0015FC14 File Offset: 0x0015DE14
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 161337, RefRangeEnd = 161339, XrefRangeStart = 161332, XrefRangeEnd = 161337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetItem(ItemDefinition item, bool network)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref network;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_SetItem_Public_Void_ItemDefinition_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047C8 RID: 18376 RVA: 0x0015FC64 File Offset: 0x0015DE64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 161339, XrefRangeEnd = 161343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsValueDefault()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ItemField.NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060047C9 RID: 18377 RVA: 0x0015FCAC File Offset: 0x0015DEAC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 161354, RefRangeEnd = 161358, XrefRangeStart = 161343, XrefRangeEnd = 161354, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ItemFieldData GetData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_GetData_Public_ItemFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemFieldData>(intPtr3) : null;
		}

		// Token: 0x060047CA RID: 18378 RVA: 0x0015FCEC File Offset: 0x0015DEEC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 161365, RefRangeEnd = 161369, XrefRangeStart = 161358, XrefRangeEnd = 161365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Load(ItemFieldData data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ItemField.NativeMethodInfoPtr_Load_Public_Void_ItemFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060047CB RID: 18379 RVA: 0x00022B77 File Offset: 0x00020D77
		public ItemField(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001586 RID: 5510
		// (get) Token: 0x060047CC RID: 18380 RVA: 0x0015FD30 File Offset: 0x0015DF30
		// (set) Token: 0x060047CD RID: 18381 RVA: 0x00022B80 File Offset: 0x00020D80
		public unsafe ItemDefinition _SelectedItem_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr__SelectedItem_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemDefinition>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr__SelectedItem_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001587 RID: 5511
		// (get) Token: 0x060047CE RID: 18382 RVA: 0x0015FD60 File Offset: 0x0015DF60
		// (set) Token: 0x060047CF RID: 18383 RVA: 0x00022B9F File Offset: 0x00020D9F
		public unsafe bool CanSelectNone
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_CanSelectNone);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_CanSelectNone)) = value;
			}
		}

		// Token: 0x17001588 RID: 5512
		// (get) Token: 0x060047D0 RID: 18384 RVA: 0x0015FD88 File Offset: 0x0015DF88
		// (set) Token: 0x060047D1 RID: 18385 RVA: 0x00022BBA File Offset: 0x00020DBA
		public unsafe List<ItemDefinition> Options
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_Options);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_Options), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001589 RID: 5513
		// (get) Token: 0x060047D2 RID: 18386 RVA: 0x0015FDB8 File Offset: 0x0015DFB8
		// (set) Token: 0x060047D3 RID: 18387 RVA: 0x00022BD9 File Offset: 0x00020DD9
		public unsafe UnityEvent<ItemDefinition> onItemChanged
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_onItemChanged);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent<ItemDefinition>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ItemField.NativeFieldInfoPtr_onItemChanged), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400305E RID: 12382
		private static readonly IntPtr NativeFieldInfoPtr__SelectedItem_k__BackingField;

		// Token: 0x0400305F RID: 12383
		private static readonly IntPtr NativeFieldInfoPtr_CanSelectNone;

		// Token: 0x04003060 RID: 12384
		private static readonly IntPtr NativeFieldInfoPtr_Options;

		// Token: 0x04003061 RID: 12385
		private static readonly IntPtr NativeFieldInfoPtr_onItemChanged;

		// Token: 0x04003062 RID: 12386
		private static readonly IntPtr NativeMethodInfoPtr_get_SelectedItem_Public_get_ItemDefinition_0;

		// Token: 0x04003063 RID: 12387
		private static readonly IntPtr NativeMethodInfoPtr_set_SelectedItem_Protected_set_Void_ItemDefinition_0;

		// Token: 0x04003064 RID: 12388
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityConfiguration_0;

		// Token: 0x04003065 RID: 12389
		private static readonly IntPtr NativeMethodInfoPtr_SetItem_Public_Void_ItemDefinition_Boolean_0;

		// Token: 0x04003066 RID: 12390
		private static readonly IntPtr NativeMethodInfoPtr_IsValueDefault_Public_Virtual_Boolean_0;

		// Token: 0x04003067 RID: 12391
		private static readonly IntPtr NativeMethodInfoPtr_GetData_Public_ItemFieldData_0;

		// Token: 0x04003068 RID: 12392
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Void_ItemFieldData_0;
	}
}
