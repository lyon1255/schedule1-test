using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x0200022B RID: 555
	public class MetadataLoader : Loader
	{
		// Token: 0x06002DD0 RID: 11728 RVA: 0x00102224 File Offset: 0x00100424
		// Note: this type is marked as 'beforefieldinit'.
		static MetadataLoader()
		{
			Il2CppClassPointerStore<MetadataLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "MetadataLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MetadataLoader>.NativeClassPtr);
			MetadataLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataLoader>.NativeClassPtr, 100668546);
			MetadataLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MetadataLoader>.NativeClassPtr, 100668547);
		}

		// Token: 0x06002DD1 RID: 11729 RVA: 0x0010227C File Offset: 0x0010047C
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MetadataLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MetadataLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MetadataLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DD2 RID: 11730 RVA: 0x001022B8 File Offset: 0x001004B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127446, XrefRangeEnd = 127455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MetadataLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x0001885C File Offset: 0x00016A5C
		public MetadataLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E67 RID: 7783
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E68 RID: 7784
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
