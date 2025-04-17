using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000223 RID: 547
	public class BusinessesLoader : Loader
	{
		// Token: 0x06002DAC RID: 11692 RVA: 0x0010192C File Offset: 0x000FFB2C
		// Note: this type is marked as 'beforefieldinit'.
		static BusinessesLoader()
		{
			Il2CppClassPointerStore<BusinessesLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "BusinessesLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BusinessesLoader>.NativeClassPtr);
			BusinessesLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessesLoader>.NativeClassPtr, 100668526);
			BusinessesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BusinessesLoader>.NativeClassPtr, 100668527);
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x00101984 File Offset: 0x000FFB84
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BusinessesLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BusinessesLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BusinessesLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x001019C0 File Offset: 0x000FFBC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127169, XrefRangeEnd = 127184, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BusinessesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x00018814 File Offset: 0x00016A14
		public BusinessesLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E53 RID: 7763
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E54 RID: 7764
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
