using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027A RID: 634
	[Serializable]
	public class LabOvenConfigurationData : SaveData
	{
		// Token: 0x06002FA5 RID: 12197 RVA: 0x0010827C File Offset: 0x0010647C
		// Note: this type is marked as 'beforefieldinit'.
		static LabOvenConfigurationData()
		{
			Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "LabOvenConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr);
			LabOvenConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr, "Destination");
			LabOvenConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr, 100668782);
		}

		// Token: 0x06002FA6 RID: 12198 RVA: 0x001082D4 File Offset: 0x001064D4
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130391, RefRangeEnd = 130397, XrefRangeStart = 130391, XrefRangeEnd = 130397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe LabOvenConfigurationData(ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LabOvenConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LabOvenConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FA7 RID: 12199 RVA: 0x000193DE File Offset: 0x000175DE
		public LabOvenConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F8D RID: 3981
		// (get) Token: 0x06002FA8 RID: 12200 RVA: 0x00108320 File Offset: 0x00106520
		// (set) Token: 0x06002FA9 RID: 12201 RVA: 0x000193E7 File Offset: 0x000175E7
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(LabOvenConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F59 RID: 8025
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001F5A RID: 8026
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0;
	}
}
