using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000231 RID: 561
	public class ProductManagerLoader : Loader
	{
		// Token: 0x06002DE8 RID: 11752 RVA: 0x0010277C File Offset: 0x0010097C
		// Note: this type is marked as 'beforefieldinit'.
		static ProductManagerLoader()
		{
			Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "ProductManagerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr);
			ProductManagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr, 100668567);
			ProductManagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr, 100668568);
		}

		// Token: 0x06002DE9 RID: 11753 RVA: 0x001027D4 File Offset: 0x001009D4
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProductManagerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProductManagerLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ProductManagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DEA RID: 11754 RVA: 0x00102810 File Offset: 0x00100A10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127584, XrefRangeEnd = 127716, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ProductManagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x00018892 File Offset: 0x00016A92
		public ProductManagerLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E73 RID: 7795
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E74 RID: 7796
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
