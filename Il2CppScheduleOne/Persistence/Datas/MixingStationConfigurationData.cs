using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027B RID: 635
	[Serializable]
	public class MixingStationConfigurationData : SaveData
	{
		// Token: 0x06002FAA RID: 12202 RVA: 0x00108350 File Offset: 0x00106550
		// Note: this type is marked as 'beforefieldinit'.
		static MixingStationConfigurationData()
		{
			Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "MixingStationConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr);
			MixingStationConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr, "Destination");
			MixingStationConfigurationData.NativeFieldInfoPtr_Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr, "Threshold");
			MixingStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_NumberFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr, 100668783);
		}

		// Token: 0x06002FAB RID: 12203 RVA: 0x001083BC File Offset: 0x001065BC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 130629, RefRangeEnd = 130638, XrefRangeStart = 130629, XrefRangeEnd = 130638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MixingStationConfigurationData(ObjectFieldData destination, NumberFieldData threshold) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MixingStationConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(threshold);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MixingStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_NumberFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FAC RID: 12204 RVA: 0x00019406 File Offset: 0x00017606
		public MixingStationConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F8E RID: 3982
		// (get) Token: 0x06002FAD RID: 12205 RVA: 0x0010841C File Offset: 0x0010661C
		// (set) Token: 0x06002FAE RID: 12206 RVA: 0x0001940F File Offset: 0x0001760F
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06002FAF RID: 12207 RVA: 0x0010844C File Offset: 0x0010664C
		// (set) Token: 0x06002FB0 RID: 12208 RVA: 0x0001942E File Offset: 0x0001762E
		public unsafe NumberFieldData Threshold
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigurationData.NativeFieldInfoPtr_Threshold);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<NumberFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MixingStationConfigurationData.NativeFieldInfoPtr_Threshold), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F5B RID: 8027
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001F5C RID: 8028
		private static readonly IntPtr NativeFieldInfoPtr_Threshold;

		// Token: 0x04001F5D RID: 8029
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_NumberFieldData_0;
	}
}
