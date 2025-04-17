using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027C RID: 636
	[Serializable]
	public class NPCFieldData : Object
	{
		// Token: 0x06002FB1 RID: 12209 RVA: 0x0010847C File Offset: 0x0010667C
		// Note: this type is marked as 'beforefieldinit'.
		static NPCFieldData()
		{
			Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "NPCFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr);
			NPCFieldData.NativeFieldInfoPtr_NPCGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr, "NPCGuid");
			NPCFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr, 100668784);
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x001084D4 File Offset: 0x001066D4
		[CallerCount(177)]
		[CachedScanResults(RefRangeStart = 17915, RefRangeEnd = 18092, XrefRangeStart = 17915, XrefRangeEnd = 18092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCFieldData(string npcGuid) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(npcGuid);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x0001944D File Offset: 0x0001764D
		public NPCFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06002FB4 RID: 12212 RVA: 0x00108520 File Offset: 0x00106720
		// (set) Token: 0x06002FB5 RID: 12213 RVA: 0x00019456 File Offset: 0x00017656
		public unsafe string NPCGuid
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldData.NativeFieldInfoPtr_NPCGuid);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCFieldData.NativeFieldInfoPtr_NPCGuid), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001F5E RID: 8030
		private static readonly IntPtr NativeFieldInfoPtr_NPCGuid;

		// Token: 0x04001F5F RID: 8031
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
