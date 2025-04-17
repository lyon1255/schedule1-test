using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000237 RID: 567
	public class ShopManagerLoader : Loader
	{
		// Token: 0x06002E00 RID: 11776 RVA: 0x00102CD4 File Offset: 0x00100ED4
		// Note: this type is marked as 'beforefieldinit'.
		static ShopManagerLoader()
		{
			Il2CppClassPointerStore<ShopManagerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "ShopManagerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShopManagerLoader>.NativeClassPtr);
			ShopManagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopManagerLoader>.NativeClassPtr, 100668583);
			ShopManagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShopManagerLoader>.NativeClassPtr, 100668584);
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x00102D2C File Offset: 0x00100F2C
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ShopManagerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShopManagerLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShopManagerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x00102D68 File Offset: 0x00100F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128014, XrefRangeEnd = 128032, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ShopManagerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x000188C8 File Offset: 0x00016AC8
		public ShopManagerLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E7F RID: 7807
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E80 RID: 7808
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
