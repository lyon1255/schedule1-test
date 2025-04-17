using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000075 RID: 117
	public class PostProcessingProfile : ScriptableObject
	{
		// Token: 0x0600083E RID: 2110 RVA: 0x00089CDC File Offset: 0x00087EDC
		// Note: this type is marked as 'beforefieldinit'.
		static PostProcessingProfile()
		{
			Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "PostProcessingProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr);
			PostProcessingProfile.NativeFieldInfoPtr_debugViews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr, "debugViews");
			PostProcessingProfile.NativeFieldInfoPtr_fog = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr, "fog");
			PostProcessingProfile.NativeFieldInfoPtr_antialiasing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr, "antialiasing");
			PostProcessingProfile.NativeFieldInfoPtr_ambientOcclusion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr, "ambientOcclusion");
			PostProcessingProfile.NativeFieldInfoPtr_screenSpaceReflection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr, "screenSpaceReflection");
			PostProcessingProfile.NativeFieldInfoPtr_depthOfField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr, "depthOfField");
			PostProcessingProfile.NativeFieldInfoPtr_motionBlur = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr, "motionBlur");
			PostProcessingProfile.NativeFieldInfoPtr_eyeAdaptation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr, "eyeAdaptation");
			PostProcessingProfile.NativeFieldInfoPtr_bloom = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr, "bloom");
			PostProcessingProfile.NativeFieldInfoPtr_colorGrading = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr, "colorGrading");
			PostProcessingProfile.NativeFieldInfoPtr_userLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr, "userLut");
			PostProcessingProfile.NativeFieldInfoPtr_chromaticAberration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr, "chromaticAberration");
			PostProcessingProfile.NativeFieldInfoPtr_grain = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr, "grain");
			PostProcessingProfile.NativeFieldInfoPtr_vignette = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr, "vignette");
			PostProcessingProfile.NativeFieldInfoPtr_dithering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr, "dithering");
			PostProcessingProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr, 100664185);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00089E4C File Offset: 0x0008804C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 78821, XrefRangeEnd = 78908, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PostProcessingProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PostProcessingProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PostProcessingProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00006705 File Offset: 0x00004905
		public PostProcessingProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x00089E88 File Offset: 0x00088088
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x0000670E File Offset: 0x0000490E
		public unsafe BuiltinDebugViewsModel debugViews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_debugViews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BuiltinDebugViewsModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_debugViews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x00089EB8 File Offset: 0x000880B8
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x0000672D File Offset: 0x0000492D
		public unsafe FogModel fog
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_fog);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FogModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_fog), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x00089EE8 File Offset: 0x000880E8
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x0000674C File Offset: 0x0000494C
		public unsafe AntialiasingModel antialiasing
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_antialiasing);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AntialiasingModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_antialiasing), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x00089F18 File Offset: 0x00088118
		// (set) Token: 0x06000848 RID: 2120 RVA: 0x0000676B File Offset: 0x0000496B
		public unsafe AmbientOcclusionModel ambientOcclusion
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_ambientOcclusion);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AmbientOcclusionModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_ambientOcclusion), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00089F48 File Offset: 0x00088148
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x0000678A File Offset: 0x0000498A
		public unsafe ScreenSpaceReflectionModel screenSpaceReflection
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_screenSpaceReflection);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScreenSpaceReflectionModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_screenSpaceReflection), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x00089F78 File Offset: 0x00088178
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x000067A9 File Offset: 0x000049A9
		public unsafe DepthOfFieldModel depthOfField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_depthOfField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DepthOfFieldModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_depthOfField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00089FA8 File Offset: 0x000881A8
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x000067C8 File Offset: 0x000049C8
		public unsafe MotionBlurModel motionBlur
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_motionBlur);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MotionBlurModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_motionBlur), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600084F RID: 2127 RVA: 0x00089FD8 File Offset: 0x000881D8
		// (set) Token: 0x06000850 RID: 2128 RVA: 0x000067E7 File Offset: 0x000049E7
		public unsafe EyeAdaptationModel eyeAdaptation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_eyeAdaptation);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EyeAdaptationModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_eyeAdaptation), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000851 RID: 2129 RVA: 0x0008A008 File Offset: 0x00088208
		// (set) Token: 0x06000852 RID: 2130 RVA: 0x00006806 File Offset: 0x00004A06
		public unsafe BloomModel bloom
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_bloom);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<BloomModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_bloom), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x0008A038 File Offset: 0x00088238
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x00006825 File Offset: 0x00004A25
		public unsafe ColorGradingModel colorGrading
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_colorGrading);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ColorGradingModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_colorGrading), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x0008A068 File Offset: 0x00088268
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x00006844 File Offset: 0x00004A44
		public unsafe UserLutModel userLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_userLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UserLutModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_userLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x0008A098 File Offset: 0x00088298
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x00006863 File Offset: 0x00004A63
		public unsafe ChromaticAberrationModel chromaticAberration
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_chromaticAberration);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChromaticAberrationModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_chromaticAberration), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x0008A0C8 File Offset: 0x000882C8
		// (set) Token: 0x0600085A RID: 2138 RVA: 0x00006882 File Offset: 0x00004A82
		public unsafe GrainModel grain
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_grain);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GrainModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_grain), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x0600085B RID: 2139 RVA: 0x0008A0F8 File Offset: 0x000882F8
		// (set) Token: 0x0600085C RID: 2140 RVA: 0x000068A1 File Offset: 0x00004AA1
		public unsafe VignetteModel vignette
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_vignette);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<VignetteModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_vignette), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x0008A128 File Offset: 0x00088328
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x000068C0 File Offset: 0x00004AC0
		public unsafe DitheringModel dithering
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_dithering);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DitheringModel>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(PostProcessingProfile.NativeFieldInfoPtr_dithering), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000505 RID: 1285
		private static readonly IntPtr NativeFieldInfoPtr_debugViews;

		// Token: 0x04000506 RID: 1286
		private static readonly IntPtr NativeFieldInfoPtr_fog;

		// Token: 0x04000507 RID: 1287
		private static readonly IntPtr NativeFieldInfoPtr_antialiasing;

		// Token: 0x04000508 RID: 1288
		private static readonly IntPtr NativeFieldInfoPtr_ambientOcclusion;

		// Token: 0x04000509 RID: 1289
		private static readonly IntPtr NativeFieldInfoPtr_screenSpaceReflection;

		// Token: 0x0400050A RID: 1290
		private static readonly IntPtr NativeFieldInfoPtr_depthOfField;

		// Token: 0x0400050B RID: 1291
		private static readonly IntPtr NativeFieldInfoPtr_motionBlur;

		// Token: 0x0400050C RID: 1292
		private static readonly IntPtr NativeFieldInfoPtr_eyeAdaptation;

		// Token: 0x0400050D RID: 1293
		private static readonly IntPtr NativeFieldInfoPtr_bloom;

		// Token: 0x0400050E RID: 1294
		private static readonly IntPtr NativeFieldInfoPtr_colorGrading;

		// Token: 0x0400050F RID: 1295
		private static readonly IntPtr NativeFieldInfoPtr_userLut;

		// Token: 0x04000510 RID: 1296
		private static readonly IntPtr NativeFieldInfoPtr_chromaticAberration;

		// Token: 0x04000511 RID: 1297
		private static readonly IntPtr NativeFieldInfoPtr_grain;

		// Token: 0x04000512 RID: 1298
		private static readonly IntPtr NativeFieldInfoPtr_vignette;

		// Token: 0x04000513 RID: 1299
		private static readonly IntPtr NativeFieldInfoPtr_dithering;

		// Token: 0x04000514 RID: 1300
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
