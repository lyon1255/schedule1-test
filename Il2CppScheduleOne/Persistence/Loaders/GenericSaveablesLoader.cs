using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000228 RID: 552
	public class GenericSaveablesLoader : Loader
	{
		// Token: 0x06002DC1 RID: 11713 RVA: 0x00101DF8 File Offset: 0x000FFFF8
		// Note: this type is marked as 'beforefieldinit'.
		static GenericSaveablesLoader()
		{
			Il2CppClassPointerStore<GenericSaveablesLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "GenericSaveablesLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GenericSaveablesLoader>.NativeClassPtr);
			GenericSaveablesLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesLoader>.NativeClassPtr, 100668537);
			GenericSaveablesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GenericSaveablesLoader>.NativeClassPtr, 100668538);
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x00101E50 File Offset: 0x00100050
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GenericSaveablesLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GenericSaveablesLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GenericSaveablesLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x00101E8C File Offset: 0x0010008C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127306, XrefRangeEnd = 127323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), GenericSaveablesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x00018841 File Offset: 0x00016A41
		public GenericSaveablesLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E5E RID: 7774
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E5F RID: 7775
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
