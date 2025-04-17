using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000232 RID: 562
	public class PropertiesLoader : Loader
	{
		// Token: 0x06002DEC RID: 11756 RVA: 0x00102860 File Offset: 0x00100A60
		// Note: this type is marked as 'beforefieldinit'.
		static PropertiesLoader()
		{
			Il2CppClassPointerStore<PropertiesLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "PropertiesLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertiesLoader>.NativeClassPtr);
			PropertiesLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesLoader>.NativeClassPtr, 100668569);
			PropertiesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertiesLoader>.NativeClassPtr, 100668570);
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x001028B8 File Offset: 0x00100AB8
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PropertiesLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PropertiesLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertiesLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x001028F4 File Offset: 0x00100AF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127716, XrefRangeEnd = 127731, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PropertiesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DEF RID: 11759 RVA: 0x0001889B File Offset: 0x00016A9B
		public PropertiesLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E75 RID: 7797
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E76 RID: 7798
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
