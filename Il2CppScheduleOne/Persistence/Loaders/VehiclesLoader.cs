using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x0200023D RID: 573
	public class VehiclesLoader : Loader
	{
		// Token: 0x06002E18 RID: 11800 RVA: 0x0010322C File Offset: 0x0010142C
		// Note: this type is marked as 'beforefieldinit'.
		static VehiclesLoader()
		{
			Il2CppClassPointerStore<VehiclesLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "VehiclesLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VehiclesLoader>.NativeClassPtr);
			VehiclesLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclesLoader>.NativeClassPtr, 100668595);
			VehiclesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VehiclesLoader>.NativeClassPtr, 100668596);
		}

		// Token: 0x06002E19 RID: 11801 RVA: 0x00103284 File Offset: 0x00101484
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VehiclesLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VehiclesLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VehiclesLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x001032C0 File Offset: 0x001014C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 128243, XrefRangeEnd = 128258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), VehiclesLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x000188FE File Offset: 0x00016AFE
		public VehiclesLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E8B RID: 7819
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E8C RID: 7820
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
