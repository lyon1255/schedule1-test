using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x02000289 RID: 649
	public class NPCData : SaveData
	{
		// Token: 0x06003015 RID: 12309 RVA: 0x001094AC File Offset: 0x001076AC
		// Note: this type is marked as 'beforefieldinit'.
		static NPCData()
		{
			Il2CppClassPointerStore<NPCData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "NPCData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NPCData>.NativeClassPtr);
			NPCData.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NPCData>.NativeClassPtr, "ID");
			NPCData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NPCData>.NativeClassPtr, 100668798);
		}

		// Token: 0x06003016 RID: 12310 RVA: 0x00109504 File Offset: 0x00107704
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 130391, RefRangeEnd = 130397, XrefRangeStart = 130391, XrefRangeEnd = 130397, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NPCData(string id) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NPCData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NPCData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003017 RID: 12311 RVA: 0x0001983C File Offset: 0x00017A3C
		public NPCData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06003018 RID: 12312 RVA: 0x00109550 File Offset: 0x00107750
		// (set) Token: 0x06003019 RID: 12313 RVA: 0x00019845 File Offset: 0x00017A45
		public unsafe string ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr_ID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NPCData.NativeFieldInfoPtr_ID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001F8A RID: 8074
		private static readonly IntPtr NativeFieldInfoPtr_ID;

		// Token: 0x04001F8B RID: 8075
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
