using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x0200011A RID: 282
	public class ColorHelper : Il2CppSystem.Object
	{
		// Token: 0x06001856 RID: 6230 RVA: 0x000BC52C File Offset: 0x000BA72C
		// Note: this type is marked as 'beforefieldinit'.
		static ColorHelper()
		{
			Il2CppClassPointerStore<ColorHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ColorHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorHelper>.NativeClassPtr);
			ColorHelper.NativeMethodInfoPtr_ColorWithHex_Public_Static_Color_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorHelper>.NativeClassPtr, 100665889);
			ColorHelper.NativeMethodInfoPtr_ColorWithHexAlpha_Public_Static_Color_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorHelper>.NativeClassPtr, 100665890);
			ColorHelper.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorHelper>.NativeClassPtr, 100665891);
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x000BC598 File Offset: 0x000BA798
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 95264, RefRangeEnd = 95270, XrefRangeStart = 95264, XrefRangeEnd = 95264, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Color ColorWithHex(uint hex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorHelper.NativeMethodInfoPtr_ColorWithHex_Public_Static_Color_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x000BC5D8 File Offset: 0x000BA7D8
		[CallerCount(0)]
		public unsafe static Color ColorWithHexAlpha(uint hex)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref hex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorHelper.NativeMethodInfoPtr_ColorWithHexAlpha_Public_Static_Color_UInt32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x000BC618 File Offset: 0x000BA818
		[CallerCount(2259)]
		[CachedScanResults(RefRangeStart = 14, RefRangeEnd = 2273, XrefRangeStart = 14, XrefRangeEnd = 2273, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorHelper() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorHelper>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorHelper.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x0000DFC6 File Offset: 0x0000C1C6
		public ColorHelper(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04001000 RID: 4096
		private static readonly IntPtr NativeMethodInfoPtr_ColorWithHex_Public_Static_Color_UInt32_0;

		// Token: 0x04001001 RID: 4097
		private static readonly IntPtr NativeMethodInfoPtr_ColorWithHexAlpha_Public_Static_Color_UInt32_0;

		// Token: 0x04001002 RID: 4098
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
