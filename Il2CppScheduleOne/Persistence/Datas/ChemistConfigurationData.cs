using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000275 RID: 629
	[Serializable]
	public class ChemistConfigurationData : SaveData
	{
		// Token: 0x06002F84 RID: 12164 RVA: 0x00107D00 File Offset: 0x00105F00
		// Note: this type is marked as 'beforefieldinit'.
		static ChemistConfigurationData()
		{
			Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ChemistConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr);
			ChemistConfigurationData.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr, "Bed");
			ChemistConfigurationData.NativeFieldInfoPtr_Stations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr, "Stations");
			ChemistConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr, 100668777);
		}

		// Token: 0x06002F85 RID: 12165 RVA: 0x00107D6C File Offset: 0x00105F6C
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 130629, RefRangeEnd = 130638, XrefRangeStart = 130626, XrefRangeEnd = 130629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChemistConfigurationData(ObjectFieldData bed, ObjectListFieldData stations) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChemistConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stations);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChemistConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F86 RID: 12166 RVA: 0x0001929A File Offset: 0x0001749A
		public ChemistConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F84 RID: 3972
		// (get) Token: 0x06002F87 RID: 12167 RVA: 0x00107DCC File Offset: 0x00105FCC
		// (set) Token: 0x06002F88 RID: 12168 RVA: 0x000192A3 File Offset: 0x000174A3
		public unsafe ObjectFieldData Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigurationData.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigurationData.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06002F89 RID: 12169 RVA: 0x00107DFC File Offset: 0x00105FFC
		// (set) Token: 0x06002F8A RID: 12170 RVA: 0x000192C2 File Offset: 0x000174C2
		public unsafe ObjectListFieldData Stations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigurationData.NativeFieldInfoPtr_Stations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChemistConfigurationData.NativeFieldInfoPtr_Stations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F4B RID: 8011
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x04001F4C RID: 8012
		private static readonly IntPtr NativeFieldInfoPtr_Stations;

		// Token: 0x04001F4D RID: 8013
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0;
	}
}
