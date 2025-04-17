using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000277 RID: 631
	[Serializable]
	public class CleanerConfigurationData : SaveData
	{
		// Token: 0x06002F92 RID: 12178 RVA: 0x00107F58 File Offset: 0x00106158
		// Note: this type is marked as 'beforefieldinit'.
		static CleanerConfigurationData()
		{
			Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CleanerConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr);
			CleanerConfigurationData.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr, "Bed");
			CleanerConfigurationData.NativeFieldInfoPtr_Bins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr, "Bins");
			CleanerConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr, 100668779);
		}

		// Token: 0x06002F93 RID: 12179 RVA: 0x00107FC4 File Offset: 0x001061C4
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 130629, RefRangeEnd = 130638, XrefRangeStart = 130629, XrefRangeEnd = 130638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CleanerConfigurationData(ObjectFieldData bed, ObjectListFieldData bins) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CleanerConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(bins);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CleanerConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F94 RID: 12180 RVA: 0x00019328 File Offset: 0x00017528
		public CleanerConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06002F95 RID: 12181 RVA: 0x00108024 File Offset: 0x00106224
		// (set) Token: 0x06002F96 RID: 12182 RVA: 0x00019331 File Offset: 0x00017531
		public unsafe ObjectFieldData Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigurationData.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigurationData.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06002F97 RID: 12183 RVA: 0x00108054 File Offset: 0x00106254
		// (set) Token: 0x06002F98 RID: 12184 RVA: 0x00019350 File Offset: 0x00017550
		public unsafe ObjectListFieldData Bins
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigurationData.NativeFieldInfoPtr_Bins);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CleanerConfigurationData.NativeFieldInfoPtr_Bins), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F51 RID: 8017
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x04001F52 RID: 8018
		private static readonly IntPtr NativeFieldInfoPtr_Bins;

		// Token: 0x04001F53 RID: 8019
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_0;
	}
}
