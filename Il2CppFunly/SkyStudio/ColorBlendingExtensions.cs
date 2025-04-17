using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000E8 RID: 232
	public static class ColorBlendingExtensions : Il2CppSystem.Object
	{
		// Token: 0x0600124B RID: 4683 RVA: 0x0000B15A File Offset: 0x0000935A
		// Note: this type is marked as 'beforefieldinit'.
		static ColorBlendingExtensions()
		{
			Il2CppClassPointerStore<ColorBlendingExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ColorBlendingExtensions");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorBlendingExtensions>.NativeClassPtr);
			ColorBlendingExtensions.NativeMethodInfoPtr_Clear_Public_Static_Color_Color_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorBlendingExtensions>.NativeClassPtr, 100665393);
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x000A9FA4 File Offset: 0x000A81A4
		[CallerCount(0)]
		public unsafe static Color Clear(this Color color)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref color;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorBlendingExtensions.NativeMethodInfoPtr_Clear_Public_Static_Color_Color_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x0000B193 File Offset: 0x00009393
		public ColorBlendingExtensions(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C27 RID: 3111
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Static_Color_Color_0;
	}
}
