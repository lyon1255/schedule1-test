using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppScheduleOne.ItemFramework;
using Il2CppScheduleOne.Tiles;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000296 RID: 662
	public class ChemistryStationData : GridItemData
	{
		// Token: 0x06003090 RID: 12432 RVA: 0x0010AB60 File Offset: 0x00108D60
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationData()
		{
			Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ChemistryStationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr);
			ChemistryStationData.NativeFieldInfoPtr_InputContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "InputContents");
			ChemistryStationData.NativeFieldInfoPtr_OutputContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "OutputContents");
			ChemistryStationData.NativeFieldInfoPtr_CurrentRecipeID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "CurrentRecipeID");
			ChemistryStationData.NativeFieldInfoPtr_ProductQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "ProductQuality");
			ChemistryStationData.NativeFieldInfoPtr_StartLiquidColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "StartLiquidColor");
			ChemistryStationData.NativeFieldInfoPtr_LiquidLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "LiquidLevel");
			ChemistryStationData.NativeFieldInfoPtr_CurrentTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, "CurrentTime");
			ChemistryStationData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_EQuality_Color_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr, 100668811);
		}

		// Token: 0x06003091 RID: 12433 RVA: 0x0010AC30 File Offset: 0x00108E30
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130891, RefRangeEnd = 130892, XrefRangeStart = 130882, XrefRangeEnd = 130891, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationData(Guid guid, ItemInstance item, int loadOrder, Grid grid, Vector2 originCoordinate, int rotation, ItemSet inputContents, ItemSet outputContents, string currentRecipeID, EQuality productQuality, Color startLiquidColor, float liquidLevel, int currentTime) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)13) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref guid;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(item);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadOrder;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(grid);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref originCoordinate;
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rotation;
			ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(inputContents);
			ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(outputContents);
			ptr[checked(unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(currentRecipeID);
			ptr[checked(unchecked((UIntPtr)9) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref productQuality;
			ptr[checked(unchecked((UIntPtr)10) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref startLiquidColor;
			ptr[checked(unchecked((UIntPtr)11) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref liquidLevel;
			ptr[checked(unchecked((UIntPtr)12) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref currentTime;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationData.NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_EQuality_Color_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003092 RID: 12434 RVA: 0x00019D77 File Offset: 0x00017F77
		public ChemistryStationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FD8 RID: 4056
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x0010AD3C File Offset: 0x00108F3C
		// (set) Token: 0x06003094 RID: 12436 RVA: 0x00019D80 File Offset: 0x00017F80
		public unsafe ItemSet InputContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_InputContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_InputContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FD9 RID: 4057
		// (get) Token: 0x06003095 RID: 12437 RVA: 0x0010AD6C File Offset: 0x00108F6C
		// (set) Token: 0x06003096 RID: 12438 RVA: 0x00019D9F File Offset: 0x00017F9F
		public unsafe ItemSet OutputContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_OutputContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ItemSet>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_OutputContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000FDA RID: 4058
		// (get) Token: 0x06003097 RID: 12439 RVA: 0x0010AD9C File Offset: 0x00108F9C
		// (set) Token: 0x06003098 RID: 12440 RVA: 0x00019DBE File Offset: 0x00017FBE
		public unsafe string CurrentRecipeID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_CurrentRecipeID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_CurrentRecipeID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FDB RID: 4059
		// (get) Token: 0x06003099 RID: 12441 RVA: 0x0010ADC4 File Offset: 0x00108FC4
		// (set) Token: 0x0600309A RID: 12442 RVA: 0x00019DDD File Offset: 0x00017FDD
		public unsafe EQuality ProductQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_ProductQuality);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_ProductQuality)) = value;
			}
		}

		// Token: 0x17000FDC RID: 4060
		// (get) Token: 0x0600309B RID: 12443 RVA: 0x0010ADEC File Offset: 0x00108FEC
		// (set) Token: 0x0600309C RID: 12444 RVA: 0x00019DF8 File Offset: 0x00017FF8
		public unsafe Color StartLiquidColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_StartLiquidColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_StartLiquidColor)) = value;
			}
		}

		// Token: 0x17000FDD RID: 4061
		// (get) Token: 0x0600309D RID: 12445 RVA: 0x0010AE14 File Offset: 0x00109014
		// (set) Token: 0x0600309E RID: 12446 RVA: 0x00019E13 File Offset: 0x00018013
		public unsafe float LiquidLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_LiquidLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_LiquidLevel)) = value;
			}
		}

		// Token: 0x17000FDE RID: 4062
		// (get) Token: 0x0600309F RID: 12447 RVA: 0x0010AE3C File Offset: 0x0010903C
		// (set) Token: 0x060030A0 RID: 12448 RVA: 0x00019E2E File Offset: 0x0001802E
		public unsafe int CurrentTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_CurrentTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationData.NativeFieldInfoPtr_CurrentTime)) = value;
			}
		}

		// Token: 0x04001FC1 RID: 8129
		private static readonly IntPtr NativeFieldInfoPtr_InputContents;

		// Token: 0x04001FC2 RID: 8130
		private static readonly IntPtr NativeFieldInfoPtr_OutputContents;

		// Token: 0x04001FC3 RID: 8131
		private static readonly IntPtr NativeFieldInfoPtr_CurrentRecipeID;

		// Token: 0x04001FC4 RID: 8132
		private static readonly IntPtr NativeFieldInfoPtr_ProductQuality;

		// Token: 0x04001FC5 RID: 8133
		private static readonly IntPtr NativeFieldInfoPtr_StartLiquidColor;

		// Token: 0x04001FC6 RID: 8134
		private static readonly IntPtr NativeFieldInfoPtr_LiquidLevel;

		// Token: 0x04001FC7 RID: 8135
		private static readonly IntPtr NativeFieldInfoPtr_CurrentTime;

		// Token: 0x04001FC8 RID: 8136
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Guid_ItemInstance_Int32_Grid_Vector2_Int32_ItemSet_ItemSet_String_EQuality_Color_Single_Int32_0;
	}
}
