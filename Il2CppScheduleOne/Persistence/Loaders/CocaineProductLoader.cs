using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x02000225 RID: 549
	public class CocaineProductLoader : Loader
	{
		// Token: 0x06002DB4 RID: 11700 RVA: 0x00101AF4 File Offset: 0x000FFCF4
		// Note: this type is marked as 'beforefieldinit'.
		static CocaineProductLoader()
		{
			Il2CppClassPointerStore<CocaineProductLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "CocaineProductLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CocaineProductLoader>.NativeClassPtr);
			CocaineProductLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineProductLoader>.NativeClassPtr, 100668530);
			CocaineProductLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CocaineProductLoader>.NativeClassPtr, 100668531);
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x00101B4C File Offset: 0x000FFD4C
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CocaineProductLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CocaineProductLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CocaineProductLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x00101B88 File Offset: 0x000FFD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127208, XrefRangeEnd = 127225, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CocaineProductLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x00018826 File Offset: 0x00016A26
		public CocaineProductLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E57 RID: 7767
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E58 RID: 7768
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
