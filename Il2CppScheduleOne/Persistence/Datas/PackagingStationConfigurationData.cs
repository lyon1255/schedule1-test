using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000281 RID: 641
	[Serializable]
	public class PackagingStationConfigurationData : SaveData
	{
		// Token: 0x06002FCE RID: 12238 RVA: 0x00108930 File Offset: 0x00106B30
		// Note: this type is marked as 'beforefieldinit'.
		static PackagingStationConfigurationData()
		{
			Il2CppClassPointerStore<PackagingStationConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PackagingStationConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagingStationConfigurationData>.NativeClassPtr);
			PackagingStationConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagingStationConfigurationData>.NativeClassPtr, "Destination");
			PackagingStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagingStationConfigurationData>.NativeClassPtr, 100668789);
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x00108988 File Offset: 0x00106B88
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130391, RefRangeEnd = 130397, XrefRangeStart = 130391, XrefRangeEnd = 130397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagingStationConfigurationData(ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagingStationConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagingStationConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x0001954F File Offset: 0x0001774F
		public PackagingStationConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06002FD1 RID: 12241 RVA: 0x001089D4 File Offset: 0x00106BD4
		// (set) Token: 0x06002FD2 RID: 12242 RVA: 0x00019558 File Offset: 0x00017758
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagingStationConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F6A RID: 8042
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001F6B RID: 8043
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0;
	}
}
