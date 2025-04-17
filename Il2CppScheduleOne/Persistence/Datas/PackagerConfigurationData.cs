using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000280 RID: 640
	[Serializable]
	public class PackagerConfigurationData : SaveData
	{
		// Token: 0x06002FC5 RID: 12229 RVA: 0x001087B0 File Offset: 0x001069B0
		// Note: this type is marked as 'beforefieldinit'.
		static PackagerConfigurationData()
		{
			Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "PackagerConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr);
			PackagerConfigurationData.NativeFieldInfoPtr_Bed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr, "Bed");
			PackagerConfigurationData.NativeFieldInfoPtr_Stations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr, "Stations");
			PackagerConfigurationData.NativeFieldInfoPtr_Routes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr, "Routes");
			PackagerConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_RouteListData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr, 100668788);
		}

		// Token: 0x06002FC6 RID: 12230 RVA: 0x00108830 File Offset: 0x00106A30
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 130624, RefRangeEnd = 130626, XrefRangeStart = 130624, XrefRangeEnd = 130626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PackagerConfigurationData(ObjectFieldData bed, ObjectListFieldData stations, RouteListData routes) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PackagerConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(bed);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stations);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(routes);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PackagerConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_RouteListData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FC7 RID: 12231 RVA: 0x000194E9 File Offset: 0x000176E9
		public PackagerConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06002FC8 RID: 12232 RVA: 0x001088A0 File Offset: 0x00106AA0
		// (set) Token: 0x06002FC9 RID: 12233 RVA: 0x000194F2 File Offset: 0x000176F2
		public unsafe ObjectFieldData Bed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Bed);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Bed), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06002FCA RID: 12234 RVA: 0x001088D0 File Offset: 0x00106AD0
		// (set) Token: 0x06002FCB RID: 12235 RVA: 0x00019511 File Offset: 0x00017711
		public unsafe ObjectListFieldData Stations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Stations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectListFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Stations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06002FCC RID: 12236 RVA: 0x00108900 File Offset: 0x00106B00
		// (set) Token: 0x06002FCD RID: 12237 RVA: 0x00019530 File Offset: 0x00017730
		public unsafe RouteListData Routes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Routes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RouteListData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PackagerConfigurationData.NativeFieldInfoPtr_Routes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F66 RID: 8038
		private static readonly IntPtr NativeFieldInfoPtr_Bed;

		// Token: 0x04001F67 RID: 8039
		private static readonly IntPtr NativeFieldInfoPtr_Stations;

		// Token: 0x04001F68 RID: 8040
		private static readonly IntPtr NativeFieldInfoPtr_Routes;

		// Token: 0x04001F69 RID: 8041
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_ObjectListFieldData_RouteListData_0;
	}
}
