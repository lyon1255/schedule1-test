using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000298 RID: 664
	[Serializable]
	public class GridItemData : BuildableItemData
	{
		// Token: 0x060030AA RID: 12458 RVA: 0x0010B044 File Offset: 0x00109244
		// Note: this type is marked as 'beforefieldinit'.
		static GridItemData()
		{
			Il2CppClassPointerStore<GridItemData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "GridItemData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GridItemData>.NativeClassPtr);
			GridItemData.NativeFieldInfoPtr_GridGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItemData>.NativeClassPtr, "GridGUID");
			GridItemData.NativeFieldInfoPtr_OriginCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItemData>.NativeClassPtr, "OriginCoordinate");
			GridItemData.NativeFieldInfoPtr_Rotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GridItemData>.NativeClassPtr, "Rotation");
			GridItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GridItemData>.NativeClassPtr, 100668813);
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x0010B0C4 File Offset: 0x001092C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130909, RefRangeEnd = 130910, XrefRangeStart = 130903, XrefRangeEnd = 130909, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GridItemData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GridItemData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GridItemData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030AC RID: 12460 RVA: 0x00019EAF File Offset: 0x000180AF
		public GridItemData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FE2 RID: 4066
		// (get) Token: 0x060030AD RID: 12461 RVA: 0x0010B15C File Offset: 0x0010935C
		// (set) Token: 0x060030AE RID: 12462 RVA: 0x00019EB8 File Offset: 0x000180B8
		public unsafe string GridGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_GridGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_GridGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FE3 RID: 4067
		// (get) Token: 0x060030AF RID: 12463 RVA: 0x0010B184 File Offset: 0x00109384
		// (set) Token: 0x060030B0 RID: 12464 RVA: 0x00019ED7 File Offset: 0x000180D7
		public unsafe Vector2 OriginCoordinate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_OriginCoordinate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_OriginCoordinate)) = value;
			}
		}

		// Token: 0x17000FE4 RID: 4068
		// (get) Token: 0x060030B1 RID: 12465 RVA: 0x0010B1AC File Offset: 0x001093AC
		// (set) Token: 0x060030B2 RID: 12466 RVA: 0x00019EF2 File Offset: 0x000180F2
		public unsafe int Rotation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_Rotation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GridItemData.NativeFieldInfoPtr_Rotation)) = value;
			}
		}

		// Token: 0x04001FCD RID: 8141
		private static readonly IntPtr NativeFieldInfoPtr_GridGUID;

		// Token: 0x04001FCE RID: 8142
		private static readonly IntPtr NativeFieldInfoPtr_OriginCoordinate;

		// Token: 0x04001FCF RID: 8143
		private static readonly IntPtr NativeFieldInfoPtr_Rotation;

		// Token: 0x04001FD0 RID: 8144
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_0;
	}
}
