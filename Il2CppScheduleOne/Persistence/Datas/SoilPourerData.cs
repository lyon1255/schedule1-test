using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A0 RID: 672
	public class SoilPourerData : GridItemData
	{
		// Token: 0x060030F6 RID: 12534 RVA: 0x0010BF00 File Offset: 0x0010A100
		// Note: this type is marked as 'beforefieldinit'.
		static SoilPourerData()
		{
			Il2CppClassPointerStore<SoilPourerData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "SoilPourerData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoilPourerData>.NativeClassPtr);
			SoilPourerData.NativeFieldInfoPtr_SoilID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoilPourerData>.NativeClassPtr, "SoilID");
			SoilPourerData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoilPourerData>.NativeClassPtr, 100668821);
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x0010BF58 File Offset: 0x0010A158
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 130862, RefRangeEnd = 130867, XrefRangeStart = 130862, XrefRangeEnd = 130867, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoilPourerData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, string soilID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoilPourerData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(soilID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoilPourerData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x0001A1F5 File Offset: 0x000183F5
		public SoilPourerData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FFC RID: 4092
		// (get) Token: 0x060030F9 RID: 12537 RVA: 0x0010C004 File Offset: 0x0010A204
		// (set) Token: 0x060030FA RID: 12538 RVA: 0x0001A1FE File Offset: 0x000183FE
		public unsafe string SoilID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourerData.NativeFieldInfoPtr_SoilID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoilPourerData.NativeFieldInfoPtr_SoilID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001FEF RID: 8175
		private static readonly IntPtr NativeFieldInfoPtr_SoilID;

		// Token: 0x04001FF0 RID: 8176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_0;
	}
}
