using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppFishNet.Serializing.Generated
{
	// Token: 0x0200079E RID: 1950
	[StructLayout(3, CharSet = 4)]
	public static class GeneratedComparers___Internal : Object
	{
		// Token: 0x0600B85E RID: 47198 RVA: 0x0005A79D File Offset: 0x0005899D
		// Note: this type is marked as 'beforefieldinit'.
		static GeneratedComparers___Internal()
		{
			Il2CppClassPointerStore<GeneratedComparers___Internal>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "FishNet.Serializing.Generated", "GeneratedComparers___Internal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GeneratedComparers___Internal>.NativeClassPtr);
			GeneratedComparers___Internal.NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GeneratedComparers___Internal>.NativeClassPtr, 100685958);
		}

		// Token: 0x0600B85F RID: 47199 RVA: 0x002DBB10 File Offset: 0x002D9D10
		[CallerCount(13604)]
		[CachedScanResults(RefRangeStart = 2449, RefRangeEnd = 16053, XrefRangeStart = 2449, XrefRangeEnd = 16053, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void InitializeOnce()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GeneratedComparers___Internal.NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600B860 RID: 47200 RVA: 0x0005A7D6 File Offset: 0x000589D6
		public GeneratedComparers___Internal(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04007C33 RID: 31795
		private static readonly IntPtr NativeMethodInfoPtr_InitializeOnce_Private_Static_Void_0;
	}
}
