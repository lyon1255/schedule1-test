using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppScheduleOne.Persistence.Loaders
{
	// Token: 0x0200022F RID: 559
	public class PlayerLoader : Loader
	{
		// Token: 0x06002DE0 RID: 11744 RVA: 0x001025B4 File Offset: 0x001007B4
		// Note: this type is marked as 'beforefieldinit'.
		static PlayerLoader()
		{
			Il2CppClassPointerStore<PlayerLoader>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "ScheduleOne.Persistence.Loaders", "PlayerLoader");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayerLoader>.NativeClassPtr);
			PlayerLoader.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoader>.NativeClassPtr, 100668554);
			PlayerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayerLoader>.NativeClassPtr, 100668555);
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x0010260C File Offset: 0x0010080C
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlayerLoader() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlayerLoader>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayerLoader.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x00102648 File Offset: 0x00100848
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 127503, XrefRangeEnd = 127525, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Load(string mainPath)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(mainPath);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PlayerLoader.NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002DE3 RID: 11747 RVA: 0x00018880 File Offset: 0x00016A80
		public PlayerLoader(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001E6F RID: 7791
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04001E70 RID: 7792
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Virtual_Void_String_0;
	}
}
