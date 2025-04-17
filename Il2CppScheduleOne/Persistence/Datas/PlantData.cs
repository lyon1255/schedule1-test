using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x020002A7 RID: 679
	[Serializable]
	public class PlantData : SaveData
	{
		// Token: 0x0600311F RID: 12575 RVA: 0x0010C784 File Offset: 0x0010A984
		// Note: this type is marked as 'beforefieldinit'.
		static PlantData()
		{
			Il2CppClassPointerStore<PlantData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PlantData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlantData>.NativeClassPtr);
			PlantData.NativeFieldInfoPtr_SeedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "SeedID");
			PlantData.NativeFieldInfoPtr_GrowthProgress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "GrowthProgress");
			PlantData.NativeFieldInfoPtr_YieldLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "YieldLevel");
			PlantData.NativeFieldInfoPtr_QualityLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "QualityLevel");
			PlantData.NativeFieldInfoPtr_ActiveBuds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlantData>.NativeClassPtr, "ActiveBuds");
			PlantData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Single_Il2CppStructArray_1_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlantData>.NativeClassPtr, 100668828);
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x0010C82C File Offset: 0x0010AA2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 130983, RefRangeEnd = 130984, XrefRangeStart = 130980, XrefRangeEnd = 130983, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlantData(string seedID, float growthProgress, float yieldLevel, float qualityLevel, Il2CppStructArray<int> activeBuds) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlantData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(seedID);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref growthProgress;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref yieldLevel;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref qualityLevel;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(activeBuds);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlantData.NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Single_Il2CppStructArray_1_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x0001A356 File Offset: 0x00018556
		public PlantData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001006 RID: 4102
		// (get) Token: 0x06003122 RID: 12578 RVA: 0x0010C8B4 File Offset: 0x0010AAB4
		// (set) Token: 0x06003123 RID: 12579 RVA: 0x0001A35F File Offset: 0x0001855F
		public unsafe string SeedID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_SeedID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_SeedID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17001007 RID: 4103
		// (get) Token: 0x06003124 RID: 12580 RVA: 0x0010C8DC File Offset: 0x0010AADC
		// (set) Token: 0x06003125 RID: 12581 RVA: 0x0001A37E File Offset: 0x0001857E
		public unsafe float GrowthProgress
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_GrowthProgress);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_GrowthProgress)) = value;
			}
		}

		// Token: 0x17001008 RID: 4104
		// (get) Token: 0x06003126 RID: 12582 RVA: 0x0010C904 File Offset: 0x0010AB04
		// (set) Token: 0x06003127 RID: 12583 RVA: 0x0001A399 File Offset: 0x00018599
		public unsafe float YieldLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_YieldLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_YieldLevel)) = value;
			}
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x06003128 RID: 12584 RVA: 0x0010C92C File Offset: 0x0010AB2C
		// (set) Token: 0x06003129 RID: 12585 RVA: 0x0001A3B4 File Offset: 0x000185B4
		public unsafe float QualityLevel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_QualityLevel);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_QualityLevel)) = value;
			}
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x0600312A RID: 12586 RVA: 0x0010C954 File Offset: 0x0010AB54
		// (set) Token: 0x0600312B RID: 12587 RVA: 0x0001A3CF File Offset: 0x000185CF
		public unsafe Il2CppStructArray<int> ActiveBuds
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_ActiveBuds);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PlantData.NativeFieldInfoPtr_ActiveBuds), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002000 RID: 8192
		private static readonly IntPtr NativeFieldInfoPtr_SeedID;

		// Token: 0x04002001 RID: 8193
		private static readonly IntPtr NativeFieldInfoPtr_GrowthProgress;

		// Token: 0x04002002 RID: 8194
		private static readonly IntPtr NativeFieldInfoPtr_YieldLevel;

		// Token: 0x04002003 RID: 8195
		private static readonly IntPtr NativeFieldInfoPtr_QualityLevel;

		// Token: 0x04002004 RID: 8196
		private static readonly IntPtr NativeFieldInfoPtr_ActiveBuds;

		// Token: 0x04002005 RID: 8197
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Single_Single_Single_Il2CppStructArray_1_Int32_0;
	}
}
