using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000F7 RID: 247
	[Serializable]
	public class ColorKeyframeGroup : KeyframeGroup<ColorKeyframe>
	{
		// Token: 0x060012E6 RID: 4838 RVA: 0x000AC4D4 File Offset: 0x000AA6D4
		// Note: this type is marked as 'beforefieldinit'.
		static ColorKeyframeGroup()
		{
			Il2CppClassPointerStore<ColorKeyframeGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "ColorKeyframeGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColorKeyframeGroup>.NativeClassPtr);
			ColorKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorKeyframeGroup>.NativeClassPtr, 100665461);
			ColorKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_ColorKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorKeyframeGroup>.NativeClassPtr, 100665462);
			ColorKeyframeGroup.NativeMethodInfoPtr_ColorForTime_Public_Color_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColorKeyframeGroup>.NativeClassPtr, 100665463);
		}

		// Token: 0x060012E7 RID: 4839 RVA: 0x000AC540 File Offset: 0x000AA740
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90012, XrefRangeEnd = 90015, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorKeyframeGroup(string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorKeyframeGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E8 RID: 4840 RVA: 0x000AC58C File Offset: 0x000AA78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90015, XrefRangeEnd = 90021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ColorKeyframeGroup(string name, ColorKeyframe frame) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColorKeyframeGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(frame);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_ColorKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E9 RID: 4841 RVA: 0x000AC5EC File Offset: 0x000AA7EC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 90042, RefRangeEnd = 90050, XrefRangeStart = 90021, XrefRangeEnd = 90042, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Color ColorForTime(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ColorKeyframeGroup.NativeMethodInfoPtr_ColorForTime_Public_Color_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012EA RID: 4842 RVA: 0x0000B5C4 File Offset: 0x000097C4
		public ColorKeyframeGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C8D RID: 3213
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C8E RID: 3214
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_ColorKeyframe_0;

		// Token: 0x04000C8F RID: 3215
		private static readonly IntPtr NativeMethodInfoPtr_ColorForTime_Public_Color_Single_0;
	}
}
