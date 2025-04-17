using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000FE RID: 254
	[Serializable]
	public class BoolKeyframe : BaseKeyframe
	{
		// Token: 0x06001347 RID: 4935 RVA: 0x000AE0DC File Offset: 0x000AC2DC
		// Note: this type is marked as 'beforefieldinit'.
		static BoolKeyframe()
		{
			Il2CppClassPointerStore<BoolKeyframe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "BoolKeyframe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BoolKeyframe>.NativeClassPtr);
			BoolKeyframe.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BoolKeyframe>.NativeClassPtr, "value");
			BoolKeyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolKeyframe>.NativeClassPtr, 100665518);
			BoolKeyframe.NativeMethodInfoPtr__ctor_Public_Void_BoolKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BoolKeyframe>.NativeClassPtr, 100665519);
		}

		// Token: 0x06001348 RID: 4936 RVA: 0x000AE148 File Offset: 0x000AC348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90267, XrefRangeEnd = 90271, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolKeyframe(float time, bool value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolKeyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x000AE1A0 File Offset: 0x000AC3A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90271, XrefRangeEnd = 90275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BoolKeyframe(BoolKeyframe keyframe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BoolKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyframe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BoolKeyframe.NativeMethodInfoPtr__ctor_Public_Void_BoolKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x0000B73E File Offset: 0x0000993E
		public BoolKeyframe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000682 RID: 1666
		// (get) Token: 0x0600134B RID: 4939 RVA: 0x000AE1EC File Offset: 0x000AC3EC
		// (set) Token: 0x0600134C RID: 4940 RVA: 0x0000B747 File Offset: 0x00009947
		public unsafe bool value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolKeyframe.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BoolKeyframe.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x04000CD3 RID: 3283
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000CD4 RID: 3284
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Boolean_0;

		// Token: 0x04000CD5 RID: 3285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_BoolKeyframe_0;
	}
}
