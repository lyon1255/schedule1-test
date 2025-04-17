using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200029E RID: 670
	public class PotData : GridItemData
	{
		// Token: 0x060030E0 RID: 12512 RVA: 0x0010BAF8 File Offset: 0x00109CF8
		// Note: this type is marked as 'beforefieldinit'.
		static PotData()
		{
			Il2CppClassPointerStore<PotData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PotData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PotData>.NativeClassPtr);
			PotData.NativeFieldInfoPtr_SoilID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotData>.NativeClassPtr, "SoilID");
			PotData.NativeFieldInfoPtr_SoilLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotData>.NativeClassPtr, "SoilLevel");
			PotData.NativeFieldInfoPtr_RemainingSoilUses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotData>.NativeClassPtr, "RemainingSoilUses");
			PotData.NativeFieldInfoPtr_WaterLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotData>.NativeClassPtr, "WaterLevel");
			PotData.NativeFieldInfoPtr_AppliedAdditives = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotData>.NativeClassPtr, "AppliedAdditives");
			PotData.NativeFieldInfoPtr_PlantData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PotData>.NativeClassPtr, "PlantData");
			PotData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_Single_Int32_Single_Il2CppStringArray_PlantData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PotData>.NativeClassPtr, 100668819);
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x0010BBB4 File Offset: 0x00109DB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130952, RefRangeEnd = 130953, XrefRangeStart = 130942, XrefRangeEnd = 130952, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PotData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, string soilID, float soilLevel, int remainingSoilUses, float waterLevel, Il2CppStringArray appliedAdditives, PlantData plantData) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PotData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(soilID);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref soilLevel;
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref remainingSoilUses;
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waterLevel;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(appliedAdditives);
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(plantData);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PotData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_Single_Int32_Single_Il2CppStringArray_PlantData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x0001A0FB File Offset: 0x000182FB
		public PotData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FF4 RID: 4084
		// (get) Token: 0x060030E3 RID: 12515 RVA: 0x0010BCB4 File Offset: 0x00109EB4
		// (set) Token: 0x060030E4 RID: 12516 RVA: 0x0001A104 File Offset: 0x00018304
		public unsafe string SoilID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_SoilID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_SoilID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FF5 RID: 4085
		// (get) Token: 0x060030E5 RID: 12517 RVA: 0x0010BCDC File Offset: 0x00109EDC
		// (set) Token: 0x060030E6 RID: 12518 RVA: 0x0001A123 File Offset: 0x00018323
		public unsafe float SoilLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_SoilLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_SoilLevel)) = value;
			}
		}

		// Token: 0x17000FF6 RID: 4086
		// (get) Token: 0x060030E7 RID: 12519 RVA: 0x0010BD04 File Offset: 0x00109F04
		// (set) Token: 0x060030E8 RID: 12520 RVA: 0x0001A13E File Offset: 0x0001833E
		public unsafe int RemainingSoilUses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_RemainingSoilUses);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_RemainingSoilUses)) = value;
			}
		}

		// Token: 0x17000FF7 RID: 4087
		// (get) Token: 0x060030E9 RID: 12521 RVA: 0x0010BD2C File Offset: 0x00109F2C
		// (set) Token: 0x060030EA RID: 12522 RVA: 0x0001A159 File Offset: 0x00018359
		public unsafe float WaterLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_WaterLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_WaterLevel)) = value;
			}
		}

		// Token: 0x17000FF8 RID: 4088
		// (get) Token: 0x060030EB RID: 12523 RVA: 0x0010BD54 File Offset: 0x00109F54
		// (set) Token: 0x060030EC RID: 12524 RVA: 0x0001A174 File Offset: 0x00018374
		public unsafe Il2CppStringArray AppliedAdditives
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_AppliedAdditives);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_AppliedAdditives), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FF9 RID: 4089
		// (get) Token: 0x060030ED RID: 12525 RVA: 0x0010BD84 File Offset: 0x00109F84
		// (set) Token: 0x060030EE RID: 12526 RVA: 0x0001A193 File Offset: 0x00018393
		public unsafe PlantData PlantData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_PlantData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlantData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PotData.NativeFieldInfoPtr_PlantData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001FE5 RID: 8165
		private static readonly IntPtr NativeFieldInfoPtr_SoilID;

		// Token: 0x04001FE6 RID: 8166
		private static readonly IntPtr NativeFieldInfoPtr_SoilLevel;

		// Token: 0x04001FE7 RID: 8167
		private static readonly IntPtr NativeFieldInfoPtr_RemainingSoilUses;

		// Token: 0x04001FE8 RID: 8168
		private static readonly IntPtr NativeFieldInfoPtr_WaterLevel;

		// Token: 0x04001FE9 RID: 8169
		private static readonly IntPtr NativeFieldInfoPtr_AppliedAdditives;

		// Token: 0x04001FEA RID: 8170
		private static readonly IntPtr NativeFieldInfoPtr_PlantData;

		// Token: 0x04001FEB RID: 8171
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_String_Single_Int32_Single_Il2CppStringArray_PlantData_0;
	}
}
