using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x02000104 RID: 260
	[Serializable]
	public class SpherePointKeyframe : BaseKeyframe
	{
		// Token: 0x06001362 RID: 4962 RVA: 0x000AE738 File Offset: 0x000AC938
		// Note: this type is marked as 'beforefieldinit'.
		static SpherePointKeyframe()
		{
			Il2CppClassPointerStore<SpherePointKeyframe>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SpherePointKeyframe");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpherePointKeyframe>.NativeClassPtr);
			SpherePointKeyframe.NativeFieldInfoPtr_spherePoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePointKeyframe>.NativeClassPtr, "spherePoint");
			SpherePointKeyframe.NativeMethodInfoPtr__ctor_Public_Void_SpherePoint_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePointKeyframe>.NativeClassPtr, 100665531);
			SpherePointKeyframe.NativeMethodInfoPtr__ctor_Public_Void_SpherePointKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePointKeyframe>.NativeClassPtr, 100665532);
		}

		// Token: 0x06001363 RID: 4963 RVA: 0x000AE7A4 File Offset: 0x000AC9A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90291, XrefRangeEnd = 90306, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePointKeyframe(SpherePoint spherePoint, float time) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpherePointKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(spherePoint);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePointKeyframe.NativeMethodInfoPtr__ctor_Public_Void_SpherePoint_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001364 RID: 4964 RVA: 0x000AE800 File Offset: 0x000ACA00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90306, XrefRangeEnd = 90315, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePointKeyframe(SpherePointKeyframe keyframe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpherePointKeyframe>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(keyframe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePointKeyframe.NativeMethodInfoPtr__ctor_Public_Void_SpherePointKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001365 RID: 4965 RVA: 0x0000B7B3 File Offset: 0x000099B3
		public SpherePointKeyframe(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001366 RID: 4966 RVA: 0x000AE84C File Offset: 0x000ACA4C
		// (set) Token: 0x06001367 RID: 4967 RVA: 0x0000B7BC File Offset: 0x000099BC
		public unsafe SpherePoint spherePoint
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpherePointKeyframe.NativeFieldInfoPtr_spherePoint);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SpherePoint>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpherePointKeyframe.NativeFieldInfoPtr_spherePoint), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000CEB RID: 3307
		private static readonly IntPtr NativeFieldInfoPtr_spherePoint;

		// Token: 0x04000CEC RID: 3308
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SpherePoint_Single_0;

		// Token: 0x04000CED RID: 3309
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_SpherePointKeyframe_0;
	}
}
