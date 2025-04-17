using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000274 RID: 628
	[Serializable]
	public class CauldronConfigurationData : SaveData
	{
		// Token: 0x06002F7F RID: 12159 RVA: 0x00107C2C File Offset: 0x00105E2C
		// Note: this type is marked as 'beforefieldinit'.
		static CauldronConfigurationData()
		{
			Il2CppClassPointerStore<CauldronConfigurationData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "CauldronConfigurationData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CauldronConfigurationData>.NativeClassPtr);
			CauldronConfigurationData.NativeFieldInfoPtr_Destination = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CauldronConfigurationData>.NativeClassPtr, "Destination");
			CauldronConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CauldronConfigurationData>.NativeClassPtr, 100668776);
		}

		// Token: 0x06002F80 RID: 12160 RVA: 0x00107C84 File Offset: 0x00105E84
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130391, RefRangeEnd = 130397, XrefRangeStart = 130391, XrefRangeEnd = 130397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CauldronConfigurationData(ObjectFieldData destination) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CauldronConfigurationData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(destination);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CauldronConfigurationData.NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002F81 RID: 12161 RVA: 0x00019272 File Offset: 0x00017472
		public CauldronConfigurationData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F83 RID: 3971
		// (get) Token: 0x06002F82 RID: 12162 RVA: 0x00107CD0 File Offset: 0x00105ED0
		// (set) Token: 0x06002F83 RID: 12163 RVA: 0x0001927B File Offset: 0x0001747B
		public unsafe ObjectFieldData Destination
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfigurationData.NativeFieldInfoPtr_Destination);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectFieldData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CauldronConfigurationData.NativeFieldInfoPtr_Destination), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F49 RID: 8009
		private static readonly IntPtr NativeFieldInfoPtr_Destination;

		// Token: 0x04001F4A RID: 8010
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ObjectFieldData_0;
	}
}
