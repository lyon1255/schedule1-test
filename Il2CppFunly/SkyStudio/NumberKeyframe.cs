using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000103 RID: 259
	[Serializable]
	public class NumberKeyframe : BaseKeyframe
	{
		// Token: 0x0600135C RID: 4956 RVA: 0x000AE600 File Offset: 0x000AC800
		// Note: this type is marked as 'beforefieldinit'.
		static NumberKeyframe()
		{
			Il2CppClassPointerStore<NumberKeyframe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "NumberKeyframe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NumberKeyframe>.NativeClassPtr);
			NumberKeyframe.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NumberKeyframe>.NativeClassPtr, "value");
			NumberKeyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberKeyframe>.NativeClassPtr, 100665529);
			NumberKeyframe.NativeMethodInfoPtr__ctor_Public_Void_NumberKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NumberKeyframe>.NativeClassPtr, 100665530);
		}

		// Token: 0x0600135D RID: 4957 RVA: 0x000AE66C File Offset: 0x000AC86C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90283, XrefRangeEnd = 90287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberKeyframe(float time, float value) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref value;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberKeyframe.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135E RID: 4958 RVA: 0x000AE6C4 File Offset: 0x000AC8C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90287, XrefRangeEnd = 90291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NumberKeyframe(NumberKeyframe keyframe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NumberKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyframe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NumberKeyframe.NativeMethodInfoPtr__ctor_Public_Void_NumberKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600135F RID: 4959 RVA: 0x0000B78F File Offset: 0x0000998F
		public NumberKeyframe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x000AE710 File Offset: 0x000AC910
		// (set) Token: 0x06001361 RID: 4961 RVA: 0x0000B798 File Offset: 0x00009998
		public unsafe float value
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberKeyframe.NativeFieldInfoPtr_value);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NumberKeyframe.NativeFieldInfoPtr_value)) = value;
			}
		}

		// Token: 0x04000CE8 RID: 3304
		private static readonly IntPtr NativeFieldInfoPtr_value;

		// Token: 0x04000CE9 RID: 3305
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;

		// Token: 0x04000CEA RID: 3306
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_NumberKeyframe_0;
	}
}
