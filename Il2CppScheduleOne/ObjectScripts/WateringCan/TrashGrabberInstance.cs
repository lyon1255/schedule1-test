using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Persistence;
using Il2CppScheduleOne.Persistence.Datas;
using Il2CppScheduleOne.Storage;
using Il2CppScheduleOne.Trash;
using Il2CppSystem.Collections.Generic;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x02000759 RID: 1881
	[Serializable]
	public class TrashGrabberInstance : StorableItemInstance
	{
		// Token: 0x0600B31B RID: 45851 RVA: 0x002CAD64 File Offset: 0x002C8F64
		// Note: this type is marked as 'beforefieldinit'.
		static TrashGrabberInstance()
		{
			Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "TrashGrabberInstance");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr);
			TrashGrabberInstance.NativeFieldInfoPtr_TRASH_CAPACITY = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, "TRASH_CAPACITY");
			TrashGrabberInstance.NativeFieldInfoPtr_Content = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, "Content");
			TrashGrabberInstance.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685388);
			TrashGrabberInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685389);
			TrashGrabberInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685390);
			TrashGrabberInstance.NativeMethodInfoPtr_LoadContentData_Public_Void_TrashContentData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685391);
			TrashGrabberInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685392);
			TrashGrabberInstance.NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685393);
			TrashGrabberInstance.NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685394);
			TrashGrabberInstance.NativeMethodInfoPtr_ClearTrash_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685395);
			TrashGrabberInstance.NativeMethodInfoPtr_GetTotalSize_Public_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685396);
			TrashGrabberInstance.NativeMethodInfoPtr_GetTrashIDs_Public_List_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685397);
			TrashGrabberInstance.NativeMethodInfoPtr_GetTrashQuantities_Public_List_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685398);
			TrashGrabberInstance.NativeMethodInfoPtr_GetTrashUshortQuantities_Public_List_1_UInt16_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr, 100685399);
		}

		// Token: 0x0600B31C RID: 45852 RVA: 0x002CAEAC File Offset: 0x002C90AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308239, RefRangeEnd = 308240, XrefRangeStart = 308233, XrefRangeEnd = 308239, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGrabberInstance() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B31D RID: 45853 RVA: 0x002CAEE8 File Offset: 0x002C90E8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 308246, RefRangeEnd = 308249, XrefRangeStart = 308240, XrefRangeEnd = 308246, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TrashGrabberInstance(ItemDefinition definition, int quantity) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrashGrabberInstance>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(definition);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B31E RID: 45854 RVA: 0x002CAF44 File Offset: 0x002C9144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308249, XrefRangeEnd = 308256, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemInstance GetCopy(int overrideQuantity = -1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref overrideQuantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberInstance.NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemInstance>(intPtr3) : null;
		}

		// Token: 0x0600B31F RID: 45855 RVA: 0x002CAF9C File Offset: 0x002C919C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308258, RefRangeEnd = 308259, XrefRangeStart = 308256, XrefRangeEnd = 308258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LoadContentData(TrashContentData content)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(content);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_LoadContentData_Public_Void_TrashContentData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B320 RID: 45856 RVA: 0x002CAFE0 File Offset: 0x002C91E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308259, XrefRangeEnd = 308264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override ItemData GetItemData()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TrashGrabberInstance.NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ItemData>(intPtr3) : null;
		}

		// Token: 0x0600B321 RID: 45857 RVA: 0x002CB02C File Offset: 0x002C922C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308267, RefRangeEnd = 308269, XrefRangeStart = 308264, XrefRangeEnd = 308267, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddTrash(string id, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B322 RID: 45858 RVA: 0x002CB07C File Offset: 0x002C927C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 308272, RefRangeEnd = 308274, XrefRangeStart = 308269, XrefRangeEnd = 308272, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveTrash(string id, int quantity)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref quantity;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B323 RID: 45859 RVA: 0x002CB0CC File Offset: 0x002C92CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308274, XrefRangeEnd = 308277, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ClearTrash()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_ClearTrash_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B324 RID: 45860 RVA: 0x002CB100 File Offset: 0x002C9300
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 308279, RefRangeEnd = 308286, XrefRangeStart = 308277, XrefRangeEnd = 308279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int GetTotalSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_GetTotalSize_Public_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600B325 RID: 45861 RVA: 0x002CB13C File Offset: 0x002C933C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 308311, RefRangeEnd = 308314, XrefRangeStart = 308286, XrefRangeEnd = 308311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<string> GetTrashIDs()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_GetTrashIDs_Public_List_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr3) : null;
		}

		// Token: 0x0600B326 RID: 45862 RVA: 0x002CB17C File Offset: 0x002C937C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308314, XrefRangeEnd = 308338, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<int> GetTrashQuantities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_GetTrashQuantities_Public_List_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<int>>(intPtr3) : null;
		}

		// Token: 0x0600B327 RID: 45863 RVA: 0x002CB1BC File Offset: 0x002C93BC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 308362, RefRangeEnd = 308363, XrefRangeStart = 308338, XrefRangeEnd = 308362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ushort> GetTrashUshortQuantities()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TrashGrabberInstance.NativeMethodInfoPtr_GetTrashUshortQuantities_Public_List_1_UInt16_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ushort>>(intPtr3) : null;
		}

		// Token: 0x0600B328 RID: 45864 RVA: 0x00057C7F File Offset: 0x00055E7F
		public TrashGrabberInstance(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700378B RID: 14219
		// (get) Token: 0x0600B329 RID: 45865 RVA: 0x002CB1FC File Offset: 0x002C93FC
		// (set) Token: 0x0600B32A RID: 45866 RVA: 0x00057C88 File Offset: 0x00055E88
		public unsafe static int TRASH_CAPACITY
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(TrashGrabberInstance.NativeFieldInfoPtr_TRASH_CAPACITY, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TrashGrabberInstance.NativeFieldInfoPtr_TRASH_CAPACITY, (void*)(&value));
			}
		}

		// Token: 0x1700378C RID: 14220
		// (get) Token: 0x0600B32B RID: 45867 RVA: 0x002CB218 File Offset: 0x002C9418
		// (set) Token: 0x0600B32C RID: 45868 RVA: 0x00057C96 File Offset: 0x00055E96
		public unsafe TrashContent Content
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberInstance.NativeFieldInfoPtr_Content);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TrashContent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TrashGrabberInstance.NativeFieldInfoPtr_Content), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040078D7 RID: 30935
		private static readonly IntPtr NativeFieldInfoPtr_TRASH_CAPACITY;

		// Token: 0x040078D8 RID: 30936
		private static readonly IntPtr NativeFieldInfoPtr_Content;

		// Token: 0x040078D9 RID: 30937
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040078DA RID: 30938
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ItemDefinition_Int32_0;

		// Token: 0x040078DB RID: 30939
		private static readonly IntPtr NativeMethodInfoPtr_GetCopy_Public_Virtual_ItemInstance_Int32_0;

		// Token: 0x040078DC RID: 30940
		private static readonly IntPtr NativeMethodInfoPtr_LoadContentData_Public_Void_TrashContentData_0;

		// Token: 0x040078DD RID: 30941
		private static readonly IntPtr NativeMethodInfoPtr_GetItemData_Public_Virtual_ItemData_0;

		// Token: 0x040078DE RID: 30942
		private static readonly IntPtr NativeMethodInfoPtr_AddTrash_Public_Void_String_Int32_0;

		// Token: 0x040078DF RID: 30943
		private static readonly IntPtr NativeMethodInfoPtr_RemoveTrash_Public_Void_String_Int32_0;

		// Token: 0x040078E0 RID: 30944
		private static readonly IntPtr NativeMethodInfoPtr_ClearTrash_Public_Void_0;

		// Token: 0x040078E1 RID: 30945
		private static readonly IntPtr NativeMethodInfoPtr_GetTotalSize_Public_Int32_0;

		// Token: 0x040078E2 RID: 30946
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashIDs_Public_List_1_String_0;

		// Token: 0x040078E3 RID: 30947
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashQuantities_Public_List_1_Int32_0;

		// Token: 0x040078E4 RID: 30948
		private static readonly IntPtr NativeMethodInfoPtr_GetTrashUshortQuantities_Public_List_1_UInt16_0;
	}
}
