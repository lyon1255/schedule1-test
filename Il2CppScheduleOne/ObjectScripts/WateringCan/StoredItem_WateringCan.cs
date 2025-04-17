using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.Storage;
using UnityEngine;

namespace Il2CppScheduleOne.ObjectScripts.WateringCan
{
	// Token: 0x0200075A RID: 1882
	public class StoredItem_WateringCan : StoredItem
	{
		// Token: 0x0600B32D RID: 45869 RVA: 0x002CB248 File Offset: 0x002C9448
		// Note: this type is marked as 'beforefieldinit'.
		static StoredItem_WateringCan()
		{
			Il2CppClassPointerStore<StoredItem_WateringCan>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.ObjectScripts.WateringCan", "StoredItem_WateringCan");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StoredItem_WateringCan>.NativeClassPtr);
			StoredItem_WateringCan.NativeFieldInfoPtr_Visuals = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StoredItem_WateringCan>.NativeClassPtr, "Visuals");
			StoredItem_WateringCan.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_WateringCan>.NativeClassPtr, 100685400);
			StoredItem_WateringCan.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StoredItem_WateringCan>.NativeClassPtr, 100685401);
		}

		// Token: 0x0600B32E RID: 45870 RVA: 0x002CB2B4 File Offset: 0x002C94B4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 308363, XrefRangeEnd = 308366, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void InitializeStoredItem(StorableItemInstance _item, StorageGrid grid, Vector2 _originCoordinate, float _rotation)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(_item);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _originCoordinate;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref _rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), StoredItem_WateringCan.NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B32F RID: 45871 RVA: 0x002CB330 File Offset: 0x002C9530
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StoredItem_WateringCan() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StoredItem_WateringCan>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StoredItem_WateringCan.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B330 RID: 45872 RVA: 0x00057CB5 File Offset: 0x00055EB5
		public StoredItem_WateringCan(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700378D RID: 14221
		// (get) Token: 0x0600B331 RID: 45873 RVA: 0x002CB36C File Offset: 0x002C956C
		// (set) Token: 0x0600B332 RID: 45874 RVA: 0x00057CBE File Offset: 0x00055EBE
		public unsafe WateringCanVisuals Visuals
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_WateringCan.NativeFieldInfoPtr_Visuals);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WateringCanVisuals>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StoredItem_WateringCan.NativeFieldInfoPtr_Visuals), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040078E5 RID: 30949
		private static readonly IntPtr NativeFieldInfoPtr_Visuals;

		// Token: 0x040078E6 RID: 30950
		private static readonly IntPtr NativeMethodInfoPtr_InitializeStoredItem_Public_Virtual_Void_StorableItemInstance_StorageGrid_Vector2_Single_0;

		// Token: 0x040078E7 RID: 30951
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
