using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000276 RID: 630
	[Serializable]
	public class ChemistryStationConfigurationData : SaveData
	{
		// Token: 0x06002F8B RID: 12171 RVA: 0x00107E2C File Offset: 0x0010602C
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistryStationConfigurationData()
		{
			Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ChemistryStationConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr);
			ChemistryStationConfigurationData.NativeFieldInfoPtr_Recipe = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr, "Recipe");
			ChemistryStationConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr, "Destination");
			ChemistryStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StationRecipeFieldData_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr, 100668778);
		}

		// Token: 0x06002F8C RID: 12172 RVA: 0x00107E98 File Offset: 0x00106098
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 130629, RefRangeEnd = 130638, XrefRangeStart = 130629, XrefRangeEnd = 130638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistryStationConfigurationData(StationRecipeFieldData recipe, ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistryStationConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(recipe);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistryStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_StationRecipeFieldData_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F8D RID: 12173 RVA: 0x000192E1 File Offset: 0x000174E1
		public ChemistryStationConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F86 RID: 3974
		// (get) Token: 0x06002F8E RID: 12174 RVA: 0x00107EF8 File Offset: 0x001060F8
		// (set) Token: 0x06002F8F RID: 12175 RVA: 0x000192EA File Offset: 0x000174EA
		public unsafe StationRecipeFieldData Recipe
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigurationData.NativeFieldInfoPtr_Recipe);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StationRecipeFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigurationData.NativeFieldInfoPtr_Recipe), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F87 RID: 3975
		// (get) Token: 0x06002F90 RID: 12176 RVA: 0x00107F28 File Offset: 0x00106128
		// (set) Token: 0x06002F91 RID: 12177 RVA: 0x00019309 File Offset: 0x00017509
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistryStationConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F4E RID: 8014
		private static readonly IntPtr NativeFieldInfoPtr_Recipe;

		// Token: 0x04001F4F RID: 8015
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001F50 RID: 8016
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_StationRecipeFieldData_ObjectFieldData_0;
	}
}
