using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppVLB
{
	// Token: 0x020000A6 RID: 166
	public class PlatformHelper : Il2CppSystem.Object
	{
		// Token: 0x06000B50 RID: 2896 RVA: 0x0009460C File Offset: 0x0009280C
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformHelper()
		{
			Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "PlatformHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr);
			PlatformHelper.NativeMethodInfoPtr_GetCurrentPlatformSuffix_Public_Static_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, 100664638);
			PlatformHelper.NativeMethodInfoPtr_GetPlatformSuffix_Private_Static_String_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, 100664639);
			PlatformHelper.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr, 100664640);
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00094678 File Offset: 0x00092878
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 82736, RefRangeEnd = 82738, XrefRangeStart = 82729, XrefRangeEnd = 82736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetCurrentPlatformSuffix()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformHelper.NativeMethodInfoPtr_GetCurrentPlatformSuffix_Public_Static_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x000946A4 File Offset: 0x000928A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82738, XrefRangeEnd = 82741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetPlatformSuffix(RuntimePlatform platform)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref platform;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformHelper.NativeMethodInfoPtr_GetPlatformSuffix_Private_Static_String_RuntimePlatform_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x000946DC File Offset: 0x000928DC
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PlatformHelper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformHelper.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00007BA5 File Offset: 0x00005DA5
		public PlatformHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x0400078B RID: 1931
		private static readonly IntPtr NativeMethodInfoPtr_GetCurrentPlatformSuffix_Public_Static_String_0;

		// Token: 0x0400078C RID: 1932
		private static readonly IntPtr NativeMethodInfoPtr_GetPlatformSuffix_Private_Static_String_RuntimePlatform_0;

		// Token: 0x0400078D RID: 1933
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
