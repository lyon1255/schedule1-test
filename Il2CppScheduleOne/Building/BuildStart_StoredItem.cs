using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Storage;
using UnityEngine;

namespace Il2CppScheduleOne.Building
{
	// Token: 0x020004B7 RID: 1207
	public class BuildStart_StoredItem : BuildStart_Base
	{
		// Token: 0x060069F6 RID: 27126 RVA: 0x001DA0E8 File Offset: 0x001D82E8
		// Note: this type is marked as 'beforefieldinit'.
		static BuildStart_StoredItem()
		{
			Il2CppClassPointerStore<BuildStart_StoredItem>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Building", "BuildStart_StoredItem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildStart_StoredItem>.NativeClassPtr);
			BuildStart_StoredItem.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_StoredItem>.NativeClassPtr, 100676756);
			BuildStart_StoredItem.NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_GameObject_StorableItemInstance_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_StoredItem>.NativeClassPtr, 100676757);
			BuildStart_StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildStart_StoredItem>.NativeClassPtr, 100676758);
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x001DA154 File Offset: 0x001D8354
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213455, XrefRangeEnd = 213489, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void StartBuilding(ItemInstance itemInstance)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(itemInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_StoredItem.NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x001DA1A4 File Offset: 0x001D83A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 213489, XrefRangeEnd = 213518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual GameObject CreateGhostModel(StorableItemInstance item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BuildStart_StoredItem.NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_GameObject_StorableItemInstance_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<GameObject>(intPtr3) : null;
		}

		// Token: 0x060069F9 RID: 27129 RVA: 0x001DA200 File Offset: 0x001D8400
		[CallerCount(218)]
		[CachedScanResults(RefRangeStart = 16377, RefRangeEnd = 16595, XrefRangeStart = 16377, XrefRangeEnd = 16595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BuildStart_StoredItem() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BuildStart_StoredItem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BuildStart_StoredItem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060069FA RID: 27130 RVA: 0x00032100 File Offset: 0x00030300
		public BuildStart_StoredItem(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04004892 RID: 18578
		private static readonly IntPtr NativeMethodInfoPtr_StartBuilding_Public_Virtual_Void_ItemInstance_0;

		// Token: 0x04004893 RID: 18579
		private static readonly IntPtr NativeMethodInfoPtr_CreateGhostModel_Protected_Virtual_New_GameObject_StorableItemInstance_0;

		// Token: 0x04004894 RID: 18580
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
