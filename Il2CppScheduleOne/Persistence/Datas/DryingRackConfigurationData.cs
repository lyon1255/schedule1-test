using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000278 RID: 632
	[Serializable]
	public class DryingRackConfigurationData : SaveData
	{
		// Token: 0x06002F99 RID: 12185 RVA: 0x00108084 File Offset: 0x00106284
		// Note: this type is marked as 'beforefieldinit'.
		static DryingRackConfigurationData()
		{
			Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "DryingRackConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr);
			DryingRackConfigurationData.NativeFieldInfoPtr_TargetQuality = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr, "TargetQuality");
			DryingRackConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr, "Destination");
			DryingRackConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_QualityFieldData_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr, 100668780);
		}

		// Token: 0x06002F9A RID: 12186 RVA: 0x001080F0 File Offset: 0x001062F0
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 130629, RefRangeEnd = 130638, XrefRangeStart = 130629, XrefRangeEnd = 130638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DryingRackConfigurationData(QualityFieldData targetquality, ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DryingRackConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetquality);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DryingRackConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_QualityFieldData_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F9B RID: 12187 RVA: 0x0001936F File Offset: 0x0001756F
		public DryingRackConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06002F9C RID: 12188 RVA: 0x00108150 File Offset: 0x00106350
		// (set) Token: 0x06002F9D RID: 12189 RVA: 0x00019378 File Offset: 0x00017578
		public unsafe QualityFieldData TargetQuality
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_TargetQuality);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<QualityFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_TargetQuality), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000F8B RID: 3979
		// (get) Token: 0x06002F9E RID: 12190 RVA: 0x00108180 File Offset: 0x00106380
		// (set) Token: 0x06002F9F RID: 12191 RVA: 0x00019397 File Offset: 0x00017597
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DryingRackConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F54 RID: 8020
		private static readonly IntPtr NativeFieldInfoPtr_TargetQuality;

		// Token: 0x04001F55 RID: 8021
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001F56 RID: 8022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_QualityFieldData_ObjectFieldData_0;
	}
}
