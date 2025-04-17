using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppVLB
{
	// Token: 0x020000B7 RID: 183
	public static class Version : Object
	{
		// Token: 0x06000D97 RID: 3479 RVA: 0x0009C5D8 File Offset: 0x0009A7D8
		// Note: this type is marked as 'beforefieldinit'.
		static Version()
		{
			Il2CppClassPointerStore<Version>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "Version");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Version>.NativeClassPtr);
			Version.NativeFieldInfoPtr_Current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Version>.NativeClassPtr, "Current");
			Version.NativeMethodInfoPtr_get_CurrentAsString_Public_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100664979);
			Version.NativeMethodInfoPtr_GetVersionAsString_Private_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Version>.NativeClassPtr, 100664980);
		}

		// Token: 0x17000475 RID: 1141
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x0009C644 File Offset: 0x0009A844
		public unsafe static string CurrentAsString
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85000, XrefRangeEnd = 85010, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_get_CurrentAsString_Public_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x0009C670 File Offset: 0x0009A870
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 85010, XrefRangeEnd = 85020, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetVersionAsString(int version)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref version;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Version.NativeMethodInfoPtr_GetVersionAsString_Private_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x000088E4 File Offset: 0x00006AE4
		public Version(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000474 RID: 1140
		// (get) Token: 0x06000D9B RID: 3483 RVA: 0x0009C6A8 File Offset: 0x0009A8A8
		// (set) Token: 0x06000D9C RID: 3484 RVA: 0x000088ED File Offset: 0x00006AED
		public unsafe static int Current
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(Version.NativeFieldInfoPtr_Current, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Version.NativeFieldInfoPtr_Current, (void*)(&value));
			}
		}

		// Token: 0x0400092F RID: 2351
		private static readonly IntPtr NativeFieldInfoPtr_Current;

		// Token: 0x04000930 RID: 2352
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentAsString_Public_Static_get_String_0;

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeMethodInfoPtr_GetVersionAsString_Private_Static_String_Int32_0;
	}
}
