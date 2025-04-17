using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000F6 RID: 246
	[Serializable]
	public class BoolKeyframeGroup : KeyframeGroup<BoolKeyframe>
	{
		// Token: 0x060012E1 RID: 4833 RVA: 0x000AC370 File Offset: 0x000AA570
		// Note: this type is marked as 'beforefieldinit'.
		static BoolKeyframeGroup()
		{
			Il2CppClassPointerStore<BoolKeyframeGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BoolKeyframeGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolKeyframeGroup>.NativeClassPtr);
			BoolKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolKeyframeGroup>.NativeClassPtr, 100665458);
			BoolKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_BoolKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolKeyframeGroup>.NativeClassPtr, 100665459);
			BoolKeyframeGroup.NativeMethodInfoPtr_BoolForTime_Public_Boolean_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolKeyframeGroup>.NativeClassPtr, 100665460);
		}

		// Token: 0x060012E2 RID: 4834 RVA: 0x000AC3DC File Offset: 0x000AA5DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89990, XrefRangeEnd = 89993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolKeyframeGroup(string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolKeyframeGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x000AC428 File Offset: 0x000AA628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 89993, XrefRangeEnd = 89999, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolKeyframeGroup(string name, BoolKeyframe keyframe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolKeyframeGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyframe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_BoolKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060012E4 RID: 4836 RVA: 0x000AC488 File Offset: 0x000AA688
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 90011, RefRangeEnd = 90012, XrefRangeStart = 89999, XrefRangeEnd = 90011, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool BoolForTime(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolKeyframeGroup.NativeMethodInfoPtr_BoolForTime_Public_Boolean_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060012E5 RID: 4837 RVA: 0x0000B5BB File Offset: 0x000097BB
		public BoolKeyframeGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000C8A RID: 3210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000C8B RID: 3211
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_BoolKeyframe_0;

		// Token: 0x04000C8C RID: 3212
		private static readonly IntPtr NativeMethodInfoPtr_BoolForTime_Public_Boolean_Single_0;
	}
}
