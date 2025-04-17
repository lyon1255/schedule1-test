using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppFunly.SkyStudio
{
	// Token: 0x020000FB RID: 251
	[Serializable]
	public class SpherePointKeyframeGroup : KeyframeGroup<SpherePointKeyframe>
	{
		// Token: 0x06001322 RID: 4898 RVA: 0x000AD944 File Offset: 0x000ABB44
		// Note: this type is marked as 'beforefieldinit'.
		static SpherePointKeyframeGroup()
		{
			Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Funly.SkyStudio", "SpherePointKeyframeGroup");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr);
			SpherePointKeyframeGroup.NativeFieldInfoPtr_MinHorizontalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr, "MinHorizontalRotation");
			SpherePointKeyframeGroup.NativeFieldInfoPtr_MaxHorizontalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr, "MaxHorizontalRotation");
			SpherePointKeyframeGroup.NativeFieldInfoPtr_MinVerticalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr, "MinVerticalRotation");
			SpherePointKeyframeGroup.NativeFieldInfoPtr_MaxVerticalRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr, "MaxVerticalRotation");
			SpherePointKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr, 100665503);
			SpherePointKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_SpherePointKeyframe_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr, 100665504);
			SpherePointKeyframeGroup.NativeMethodInfoPtr_SpherePointForTime_Public_SpherePoint_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr, 100665505);
		}

		// Token: 0x06001323 RID: 4899 RVA: 0x000ADA00 File Offset: 0x000ABC00
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90202, XrefRangeEnd = 90205, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePointKeyframeGroup(string name) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePointKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001324 RID: 4900 RVA: 0x000ADA4C File Offset: 0x000ABC4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 90205, XrefRangeEnd = 90211, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePointKeyframeGroup(string name, SpherePointKeyframe keyframe) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpherePointKeyframeGroup>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(keyframe);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePointKeyframeGroup.NativeMethodInfoPtr__ctor_Public_Void_String_SpherePointKeyframe_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001325 RID: 4901 RVA: 0x000ADAAC File Offset: 0x000ABCAC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 90237, RefRangeEnd = 90239, XrefRangeStart = 90211, XrefRangeEnd = 90237, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpherePoint SpherePointForTime(float time)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref time;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpherePointKeyframeGroup.NativeMethodInfoPtr_SpherePointForTime_Public_SpherePoint_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SpherePoint>(intPtr3) : null;
		}

		// Token: 0x06001326 RID: 4902 RVA: 0x0000B67B File Offset: 0x0000987B
		public SpherePointKeyframeGroup(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001327 RID: 4903 RVA: 0x000ADAF8 File Offset: 0x000ABCF8
		// (set) Token: 0x06001328 RID: 4904 RVA: 0x0000B684 File Offset: 0x00009884
		public unsafe static float MinHorizontalRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpherePointKeyframeGroup.NativeFieldInfoPtr_MinHorizontalRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpherePointKeyframeGroup.NativeFieldInfoPtr_MinHorizontalRotation, (void*)(&value));
			}
		}

		// Token: 0x17000677 RID: 1655
		// (get) Token: 0x06001329 RID: 4905 RVA: 0x000ADB14 File Offset: 0x000ABD14
		// (set) Token: 0x0600132A RID: 4906 RVA: 0x0000B692 File Offset: 0x00009892
		public unsafe static float MaxHorizontalRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpherePointKeyframeGroup.NativeFieldInfoPtr_MaxHorizontalRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpherePointKeyframeGroup.NativeFieldInfoPtr_MaxHorizontalRotation, (void*)(&value));
			}
		}

		// Token: 0x17000678 RID: 1656
		// (get) Token: 0x0600132B RID: 4907 RVA: 0x000ADB30 File Offset: 0x000ABD30
		// (set) Token: 0x0600132C RID: 4908 RVA: 0x0000B6A0 File Offset: 0x000098A0
		public unsafe static float MinVerticalRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpherePointKeyframeGroup.NativeFieldInfoPtr_MinVerticalRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpherePointKeyframeGroup.NativeFieldInfoPtr_MinVerticalRotation, (void*)(&value));
			}
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x0600132D RID: 4909 RVA: 0x000ADB4C File Offset: 0x000ABD4C
		// (set) Token: 0x0600132E RID: 4910 RVA: 0x0000B6AE File Offset: 0x000098AE
		public unsafe static float MaxVerticalRotation
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(SpherePointKeyframeGroup.NativeFieldInfoPtr_MaxVerticalRotation, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(SpherePointKeyframeGroup.NativeFieldInfoPtr_MaxVerticalRotation, (void*)(&value));
			}
		}

		// Token: 0x04000CBC RID: 3260
		private static readonly IntPtr NativeFieldInfoPtr_MinHorizontalRotation;

		// Token: 0x04000CBD RID: 3261
		private static readonly IntPtr NativeFieldInfoPtr_MaxHorizontalRotation;

		// Token: 0x04000CBE RID: 3262
		private static readonly IntPtr NativeFieldInfoPtr_MinVerticalRotation;

		// Token: 0x04000CBF RID: 3263
		private static readonly IntPtr NativeFieldInfoPtr_MaxVerticalRotation;

		// Token: 0x04000CC0 RID: 3264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x04000CC1 RID: 3265
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_SpherePointKeyframe_0;

		// Token: 0x04000CC2 RID: 3266
		private static readonly IntPtr NativeMethodInfoPtr_SpherePointForTime_Public_SpherePoint_Single_0;
	}
}
