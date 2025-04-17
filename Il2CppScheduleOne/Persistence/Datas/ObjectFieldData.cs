using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppScheduleOne.Persistence.Datas
{
	// Token: 0x0200027E RID: 638
	[Serializable]
	public class ObjectFieldData : Object
	{
		// Token: 0x06002FBB RID: 12219 RVA: 0x00108610 File Offset: 0x00106810
		// Note: this type is marked as 'beforefieldinit'.
		static ObjectFieldData()
		{
			Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Datas", "ObjectFieldData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr);
			ObjectFieldData.NativeFieldInfoPtr_ObjectGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr, "ObjectGUID");
			ObjectFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr, 100668786);
		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x00108668 File Offset: 0x00106868
		[CallerCount(177)]
		[CachedScanResults(RefRangeStart = 17915, RefRangeEnd = 18092, XrefRangeStart = 17915, XrefRangeEnd = 18092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ObjectFieldData(string objectGUID) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ObjectFieldData>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(objectGUID);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ObjectFieldData.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x00019499 File Offset: 0x00017699
		public ObjectFieldData(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06002FBE RID: 12222 RVA: 0x001086B4 File Offset: 0x001068B4
		// (set) Token: 0x06002FBF RID: 12223 RVA: 0x000194A2 File Offset: 0x000176A2
		public unsafe string ObjectGUID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldData.NativeFieldInfoPtr_ObjectGUID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ObjectFieldData.NativeFieldInfoPtr_ObjectGUID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x04001F62 RID: 8034
		private static readonly IntPtr NativeFieldInfoPtr_ObjectGUID;

		// Token: 0x04001F63 RID: 8035
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
	}
}
