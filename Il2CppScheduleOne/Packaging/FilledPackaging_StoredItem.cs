using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using UnityEngine;

namespace Il2CppScheduleOne.Packaging
{
	// Token: 0x02000561 RID: 1377
	public class FilledPackaging_StoredItem : StoredItem
	{
		// Token: 0x060078DB RID: 30939 RVA: 0x0020A078 File Offset: 0x00208278
		// Note: this type is marked as 'beforefieldinit'.
		static FilledPackaging_StoredItem()
		{
			Il2CppClassPointerStore<FilledPackaging_StoredItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Packaging", "FilledPackaging_StoredItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FilledPackaging_StoredItem>.NativeClassPtr);
			FilledPackaging_StoredItem.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FilledPackaging_StoredItem>.NativeClassPtr, "Visuals");
			FilledPackaging_StoredItem.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackaging_StoredItem>.NativeClassPtr, 100678451);
			FilledPackaging_StoredItem.NativeMethodInfoPtr_CreateGhostModel_Public_Virtual_GameObject_ItemInstance_Transform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackaging_StoredItem>.NativeClassPtr, 100678452);
			FilledPackaging_StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FilledPackaging_StoredItem>.NativeClassPtr, 100678453);
		}

		// Token: 0x060078DC RID: 30940 RVA: 0x0020A0F8 File Offset: 0x002082F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232582, XrefRangeEnd = 232586, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilledPackaging_StoredItem.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078DD RID: 30941 RVA: 0x0020A174 File Offset: 0x00208374
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232586, XrefRangeEnd = 232592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override GameObject CreateGhostModel(ItemInstance _item, Transform parent)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(parent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FilledPackaging_StoredItem.NativeMethodInfoPtr_CreateGhostModel_Public_Virtual_GameObject_ItemInstance_Transform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060078DE RID: 30942 RVA: 0x0020A1E4 File Offset: 0x002083E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 232592, XrefRangeEnd = 232593, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FilledPackaging_StoredItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FilledPackaging_StoredItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FilledPackaging_StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060078DF RID: 30943 RVA: 0x000395CE File Offset: 0x000377CE
		public FilledPackaging_StoredItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700248B RID: 9355
		// (get) Token: 0x060078E0 RID: 30944 RVA: 0x0020A220 File Offset: 0x00208420
		// (set) Token: 0x060078E1 RID: 30945 RVA: 0x000395D7 File Offset: 0x000377D7
		public unsafe FilledPackagingVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackaging_StoredItem.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FilledPackagingVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FilledPackaging_StoredItem.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400524D RID: 21069
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x0400524E RID: 21070
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x0400524F RID: 21071
		private static readonly IntPtr NativeMethodInfoPtr_CreateGhostModel_Public_Virtual_GameObject_ItemInstance_Transform_0;

		// Token: 0x04005250 RID: 21072
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
