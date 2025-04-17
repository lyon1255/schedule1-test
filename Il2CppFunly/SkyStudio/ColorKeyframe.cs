using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000FF RID: 255
	[Serializable]
	public class ColorKeyframe : BaseKeyframe
	{
		// Token: 0x0600134D RID: 4941 RVA: 0x000AE214 File Offset: 0x000AC414
		// Note: this type is marked as 'beforefieldinit'.
		static ColorKeyframe()
		{
			Il2CppClassPointerStore<ColorKeyframe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ColorKeyframe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorKeyframe>.NativeClassPtr);
			ColorKeyframe.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColorKeyframe>.NativeClassPtr, "color");
			ColorKeyframe.NativeMethodInfoPtr__ctor_Public_Void_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorKeyframe>.NativeClassPtr, 100665520);
			ColorKeyframe.NativeMethodInfoPtr__ctor_Public_Void_ColorKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorKeyframe>.NativeClassPtr, 100665521);
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x000AE280 File Offset: 0x000AC480
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90275, XrefRangeEnd = 90279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorKeyframe(Color c, float time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref c;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorKeyframe.NativeMethodInfoPtr__ctor_Public_Void_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x000AE2D8 File Offset: 0x000AC4D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90279, XrefRangeEnd = 90283, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorKeyframe(ColorKeyframe keyframe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyframe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorKeyframe.NativeMethodInfoPtr__ctor_Public_Void_ColorKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x0000B762 File Offset: 0x00009962
		public ColorKeyframe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000683 RID: 1667
		// (get) Token: 0x06001351 RID: 4945 RVA: 0x000AE324 File Offset: 0x000AC524
		// (set) Token: 0x06001352 RID: 4946 RVA: 0x0000B76B File Offset: 0x0000996B
		public unsafe Color color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorKeyframe.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ColorKeyframe.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x04000CD6 RID: 3286
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04000CD7 RID: 3287
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Color_Single_0;

		// Token: 0x04000CD8 RID: 3288
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ColorKeyframe_0;
	}
}
