using System;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppVLB
{
	// Token: 0x020000B0 RID: 176
	public static class ShaderProperties : Object
	{
		// Token: 0x06000D02 RID: 3330 RVA: 0x0009A500 File Offset: 0x00098700
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderProperties()
		{
			Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "ShaderProperties");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr);
			ShaderProperties.NativeFieldInfoPtr_ConeRadius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ConeRadius");
			ShaderProperties.NativeFieldInfoPtr_ConeGeomProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ConeGeomProps");
			ShaderProperties.NativeFieldInfoPtr_ColorFlat = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ColorFlat");
			ShaderProperties.NativeFieldInfoPtr_DistanceFallOff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "DistanceFallOff");
			ShaderProperties.NativeFieldInfoPtr_NoiseVelocityAndScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "NoiseVelocityAndScale");
			ShaderProperties.NativeFieldInfoPtr_NoiseParam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "NoiseParam");
			ShaderProperties.NativeFieldInfoPtr_ColorGradientMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ColorGradientMatrix");
			ShaderProperties.NativeFieldInfoPtr_LocalToWorldMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "LocalToWorldMatrix");
			ShaderProperties.NativeFieldInfoPtr_WorldToLocalMatrix = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "WorldToLocalMatrix");
			ShaderProperties.NativeFieldInfoPtr_BlendSrcFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "BlendSrcFactor");
			ShaderProperties.NativeFieldInfoPtr_BlendDstFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "BlendDstFactor");
			ShaderProperties.NativeFieldInfoPtr_ZTest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ZTest");
			ShaderProperties.NativeFieldInfoPtr_ParticlesTintColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "ParticlesTintColor");
			ShaderProperties.NativeFieldInfoPtr_HDRPExposureWeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "HDRPExposureWeight");
			ShaderProperties.NativeFieldInfoPtr_GlobalUsesReversedZBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "GlobalUsesReversedZBuffer");
			ShaderProperties.NativeFieldInfoPtr_GlobalNoiseTex3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "GlobalNoiseTex3D");
			ShaderProperties.NativeFieldInfoPtr_GlobalNoiseCustomTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "GlobalNoiseCustomTime");
			ShaderProperties.NativeFieldInfoPtr_GlobalDitheringFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "GlobalDitheringFactor");
			ShaderProperties.NativeFieldInfoPtr_GlobalDitheringNoiseTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "GlobalDitheringNoiseTex");
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00008669 File Offset: 0x00006869
		public ShaderProperties(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x06000D04 RID: 3332 RVA: 0x0009A6AC File Offset: 0x000988AC
		// (set) Token: 0x06000D05 RID: 3333 RVA: 0x00008672 File Offset: 0x00006872
		public unsafe static int ConeRadius
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ConeRadius, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ConeRadius, (void*)(&value));
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x06000D06 RID: 3334 RVA: 0x0009A6C8 File Offset: 0x000988C8
		// (set) Token: 0x06000D07 RID: 3335 RVA: 0x00008680 File Offset: 0x00006880
		public unsafe static int ConeGeomProps
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ConeGeomProps, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ConeGeomProps, (void*)(&value));
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000D08 RID: 3336 RVA: 0x0009A6E4 File Offset: 0x000988E4
		// (set) Token: 0x06000D09 RID: 3337 RVA: 0x0000868E File Offset: 0x0000688E
		public unsafe static int ColorFlat
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ColorFlat, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ColorFlat, (void*)(&value));
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000D0A RID: 3338 RVA: 0x0009A700 File Offset: 0x00098900
		// (set) Token: 0x06000D0B RID: 3339 RVA: 0x0000869C File Offset: 0x0000689C
		public unsafe static int DistanceFallOff
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_DistanceFallOff, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_DistanceFallOff, (void*)(&value));
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000D0C RID: 3340 RVA: 0x0009A71C File Offset: 0x0009891C
		// (set) Token: 0x06000D0D RID: 3341 RVA: 0x000086AA File Offset: 0x000068AA
		public unsafe static int NoiseVelocityAndScale
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_NoiseVelocityAndScale, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_NoiseVelocityAndScale, (void*)(&value));
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000D0E RID: 3342 RVA: 0x0009A738 File Offset: 0x00098938
		// (set) Token: 0x06000D0F RID: 3343 RVA: 0x000086B8 File Offset: 0x000068B8
		public unsafe static int NoiseParam
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_NoiseParam, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_NoiseParam, (void*)(&value));
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x0009A754 File Offset: 0x00098954
		// (set) Token: 0x06000D11 RID: 3345 RVA: 0x000086C6 File Offset: 0x000068C6
		public unsafe static int ColorGradientMatrix
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ColorGradientMatrix, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ColorGradientMatrix, (void*)(&value));
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x0009A770 File Offset: 0x00098970
		// (set) Token: 0x06000D13 RID: 3347 RVA: 0x000086D4 File Offset: 0x000068D4
		public unsafe static int LocalToWorldMatrix
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_LocalToWorldMatrix, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_LocalToWorldMatrix, (void*)(&value));
			}
		}

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06000D14 RID: 3348 RVA: 0x0009A78C File Offset: 0x0009898C
		// (set) Token: 0x06000D15 RID: 3349 RVA: 0x000086E2 File Offset: 0x000068E2
		public unsafe static int WorldToLocalMatrix
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_WorldToLocalMatrix, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_WorldToLocalMatrix, (void*)(&value));
			}
		}

		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06000D16 RID: 3350 RVA: 0x0009A7A8 File Offset: 0x000989A8
		// (set) Token: 0x06000D17 RID: 3351 RVA: 0x000086F0 File Offset: 0x000068F0
		public unsafe static int BlendSrcFactor
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_BlendSrcFactor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_BlendSrcFactor, (void*)(&value));
			}
		}

		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x0009A7C4 File Offset: 0x000989C4
		// (set) Token: 0x06000D19 RID: 3353 RVA: 0x000086FE File Offset: 0x000068FE
		public unsafe static int BlendDstFactor
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_BlendDstFactor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_BlendDstFactor, (void*)(&value));
			}
		}

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x0009A7E0 File Offset: 0x000989E0
		// (set) Token: 0x06000D1B RID: 3355 RVA: 0x0000870C File Offset: 0x0000690C
		public unsafe static int ZTest
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ZTest, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ZTest, (void*)(&value));
			}
		}

		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06000D1C RID: 3356 RVA: 0x0009A7FC File Offset: 0x000989FC
		// (set) Token: 0x06000D1D RID: 3357 RVA: 0x0000871A File Offset: 0x0000691A
		public unsafe static int ParticlesTintColor
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_ParticlesTintColor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_ParticlesTintColor, (void*)(&value));
			}
		}

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x0009A818 File Offset: 0x00098A18
		// (set) Token: 0x06000D1F RID: 3359 RVA: 0x00008728 File Offset: 0x00006928
		public unsafe static int HDRPExposureWeight
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_HDRPExposureWeight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_HDRPExposureWeight, (void*)(&value));
			}
		}

		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06000D20 RID: 3360 RVA: 0x0009A834 File Offset: 0x00098A34
		// (set) Token: 0x06000D21 RID: 3361 RVA: 0x00008736 File Offset: 0x00006936
		public unsafe static int GlobalUsesReversedZBuffer
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_GlobalUsesReversedZBuffer, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_GlobalUsesReversedZBuffer, (void*)(&value));
			}
		}

		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06000D22 RID: 3362 RVA: 0x0009A850 File Offset: 0x00098A50
		// (set) Token: 0x06000D23 RID: 3363 RVA: 0x00008744 File Offset: 0x00006944
		public unsafe static int GlobalNoiseTex3D
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_GlobalNoiseTex3D, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_GlobalNoiseTex3D, (void*)(&value));
			}
		}

		// Token: 0x17000462 RID: 1122
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x0009A86C File Offset: 0x00098A6C
		// (set) Token: 0x06000D25 RID: 3365 RVA: 0x00008752 File Offset: 0x00006952
		public unsafe static int GlobalNoiseCustomTime
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_GlobalNoiseCustomTime, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_GlobalNoiseCustomTime, (void*)(&value));
			}
		}

		// Token: 0x17000463 RID: 1123
		// (get) Token: 0x06000D26 RID: 3366 RVA: 0x0009A888 File Offset: 0x00098A88
		// (set) Token: 0x06000D27 RID: 3367 RVA: 0x00008760 File Offset: 0x00006960
		public unsafe static int GlobalDitheringFactor
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_GlobalDitheringFactor, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_GlobalDitheringFactor, (void*)(&value));
			}
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000D28 RID: 3368 RVA: 0x0009A8A4 File Offset: 0x00098AA4
		// (set) Token: 0x06000D29 RID: 3369 RVA: 0x0000876E File Offset: 0x0000696E
		public unsafe static int GlobalDitheringNoiseTex
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(ShaderProperties.NativeFieldInfoPtr_GlobalDitheringNoiseTex, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderProperties.NativeFieldInfoPtr_GlobalDitheringNoiseTex, (void*)(&value));
			}
		}

		// Token: 0x040008C7 RID: 2247
		private static readonly IntPtr NativeFieldInfoPtr_ConeRadius;

		// Token: 0x040008C8 RID: 2248
		private static readonly IntPtr NativeFieldInfoPtr_ConeGeomProps;

		// Token: 0x040008C9 RID: 2249
		private static readonly IntPtr NativeFieldInfoPtr_ColorFlat;

		// Token: 0x040008CA RID: 2250
		private static readonly IntPtr NativeFieldInfoPtr_DistanceFallOff;

		// Token: 0x040008CB RID: 2251
		private static readonly IntPtr NativeFieldInfoPtr_NoiseVelocityAndScale;

		// Token: 0x040008CC RID: 2252
		private static readonly IntPtr NativeFieldInfoPtr_NoiseParam;

		// Token: 0x040008CD RID: 2253
		private static readonly IntPtr NativeFieldInfoPtr_ColorGradientMatrix;

		// Token: 0x040008CE RID: 2254
		private static readonly IntPtr NativeFieldInfoPtr_LocalToWorldMatrix;

		// Token: 0x040008CF RID: 2255
		private static readonly IntPtr NativeFieldInfoPtr_WorldToLocalMatrix;

		// Token: 0x040008D0 RID: 2256
		private static readonly IntPtr NativeFieldInfoPtr_BlendSrcFactor;

		// Token: 0x040008D1 RID: 2257
		private static readonly IntPtr NativeFieldInfoPtr_BlendDstFactor;

		// Token: 0x040008D2 RID: 2258
		private static readonly IntPtr NativeFieldInfoPtr_ZTest;

		// Token: 0x040008D3 RID: 2259
		private static readonly IntPtr NativeFieldInfoPtr_ParticlesTintColor;

		// Token: 0x040008D4 RID: 2260
		private static readonly IntPtr NativeFieldInfoPtr_HDRPExposureWeight;

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeFieldInfoPtr_GlobalUsesReversedZBuffer;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeFieldInfoPtr_GlobalNoiseTex3D;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeFieldInfoPtr_GlobalNoiseCustomTime;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeFieldInfoPtr_GlobalDitheringFactor;

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeFieldInfoPtr_GlobalDitheringNoiseTex;

		// Token: 0x02000839 RID: 2105
		public static class SD : Object
		{
			// Token: 0x0600BF36 RID: 48950 RVA: 0x002EE29C File Offset: 0x002EC49C
			// Note: this type is marked as 'beforefieldinit'.
			static SD()
			{
				Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "SD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr);
				ShaderProperties.SD.NativeFieldInfoPtr_FadeOutFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "FadeOutFactor");
				ShaderProperties.SD.NativeFieldInfoPtr_ConeSlopeCosSin = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "ConeSlopeCosSin");
				ShaderProperties.SD.NativeFieldInfoPtr_AlphaInside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "AlphaInside");
				ShaderProperties.SD.NativeFieldInfoPtr_AlphaOutside = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "AlphaOutside");
				ShaderProperties.SD.NativeFieldInfoPtr_AttenuationLerpLinearQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "AttenuationLerpLinearQuad");
				ShaderProperties.SD.NativeFieldInfoPtr_DistanceCamClipping = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DistanceCamClipping");
				ShaderProperties.SD.NativeFieldInfoPtr_FresnelPow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "FresnelPow");
				ShaderProperties.SD.NativeFieldInfoPtr_GlareBehind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "GlareBehind");
				ShaderProperties.SD.NativeFieldInfoPtr_GlareFrontal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "GlareFrontal");
				ShaderProperties.SD.NativeFieldInfoPtr_DrawCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DrawCap");
				ShaderProperties.SD.NativeFieldInfoPtr_DepthBlendDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DepthBlendDistance");
				ShaderProperties.SD.NativeFieldInfoPtr_CameraParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "CameraParams");
				ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DynamicOcclusionClippingPlaneWS");
				ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DynamicOcclusionClippingPlaneProps");
				ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DynamicOcclusionDepthTexture");
				ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "DynamicOcclusionDepthProps");
				ShaderProperties.SD.NativeFieldInfoPtr_LocalForwardDirection = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "LocalForwardDirection");
				ShaderProperties.SD.NativeFieldInfoPtr_TiltVector = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "TiltVector");
				ShaderProperties.SD.NativeFieldInfoPtr_AdditionalClippingPlaneWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.SD>.NativeClassPtr, "AdditionalClippingPlaneWS");
			}

			// Token: 0x0600BF37 RID: 48951 RVA: 0x0005D75F File Offset: 0x0005B95F
			public SD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B73 RID: 15219
			// (get) Token: 0x0600BF38 RID: 48952 RVA: 0x002EE444 File Offset: 0x002EC644
			// (set) Token: 0x0600BF39 RID: 48953 RVA: 0x0005D768 File Offset: 0x0005B968
			public unsafe static int FadeOutFactor
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_FadeOutFactor, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_FadeOutFactor, (void*)(&value));
				}
			}

			// Token: 0x17003B74 RID: 15220
			// (get) Token: 0x0600BF3A RID: 48954 RVA: 0x002EE460 File Offset: 0x002EC660
			// (set) Token: 0x0600BF3B RID: 48955 RVA: 0x0005D776 File Offset: 0x0005B976
			public unsafe static int ConeSlopeCosSin
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_ConeSlopeCosSin, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_ConeSlopeCosSin, (void*)(&value));
				}
			}

			// Token: 0x17003B75 RID: 15221
			// (get) Token: 0x0600BF3C RID: 48956 RVA: 0x002EE47C File Offset: 0x002EC67C
			// (set) Token: 0x0600BF3D RID: 48957 RVA: 0x0005D784 File Offset: 0x0005B984
			public unsafe static int AlphaInside
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_AlphaInside, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_AlphaInside, (void*)(&value));
				}
			}

			// Token: 0x17003B76 RID: 15222
			// (get) Token: 0x0600BF3E RID: 48958 RVA: 0x002EE498 File Offset: 0x002EC698
			// (set) Token: 0x0600BF3F RID: 48959 RVA: 0x0005D792 File Offset: 0x0005B992
			public unsafe static int AlphaOutside
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_AlphaOutside, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_AlphaOutside, (void*)(&value));
				}
			}

			// Token: 0x17003B77 RID: 15223
			// (get) Token: 0x0600BF40 RID: 48960 RVA: 0x002EE4B4 File Offset: 0x002EC6B4
			// (set) Token: 0x0600BF41 RID: 48961 RVA: 0x0005D7A0 File Offset: 0x0005B9A0
			public unsafe static int AttenuationLerpLinearQuad
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_AttenuationLerpLinearQuad, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_AttenuationLerpLinearQuad, (void*)(&value));
				}
			}

			// Token: 0x17003B78 RID: 15224
			// (get) Token: 0x0600BF42 RID: 48962 RVA: 0x002EE4D0 File Offset: 0x002EC6D0
			// (set) Token: 0x0600BF43 RID: 48963 RVA: 0x0005D7AE File Offset: 0x0005B9AE
			public unsafe static int DistanceCamClipping
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DistanceCamClipping, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DistanceCamClipping, (void*)(&value));
				}
			}

			// Token: 0x17003B79 RID: 15225
			// (get) Token: 0x0600BF44 RID: 48964 RVA: 0x002EE4EC File Offset: 0x002EC6EC
			// (set) Token: 0x0600BF45 RID: 48965 RVA: 0x0005D7BC File Offset: 0x0005B9BC
			public unsafe static int FresnelPow
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_FresnelPow, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_FresnelPow, (void*)(&value));
				}
			}

			// Token: 0x17003B7A RID: 15226
			// (get) Token: 0x0600BF46 RID: 48966 RVA: 0x002EE508 File Offset: 0x002EC708
			// (set) Token: 0x0600BF47 RID: 48967 RVA: 0x0005D7CA File Offset: 0x0005B9CA
			public unsafe static int GlareBehind
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_GlareBehind, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_GlareBehind, (void*)(&value));
				}
			}

			// Token: 0x17003B7B RID: 15227
			// (get) Token: 0x0600BF48 RID: 48968 RVA: 0x002EE524 File Offset: 0x002EC724
			// (set) Token: 0x0600BF49 RID: 48969 RVA: 0x0005D7D8 File Offset: 0x0005B9D8
			public unsafe static int GlareFrontal
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_GlareFrontal, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_GlareFrontal, (void*)(&value));
				}
			}

			// Token: 0x17003B7C RID: 15228
			// (get) Token: 0x0600BF4A RID: 48970 RVA: 0x002EE540 File Offset: 0x002EC740
			// (set) Token: 0x0600BF4B RID: 48971 RVA: 0x0005D7E6 File Offset: 0x0005B9E6
			public unsafe static int DrawCap
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DrawCap, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DrawCap, (void*)(&value));
				}
			}

			// Token: 0x17003B7D RID: 15229
			// (get) Token: 0x0600BF4C RID: 48972 RVA: 0x002EE55C File Offset: 0x002EC75C
			// (set) Token: 0x0600BF4D RID: 48973 RVA: 0x0005D7F4 File Offset: 0x0005B9F4
			public unsafe static int DepthBlendDistance
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DepthBlendDistance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DepthBlendDistance, (void*)(&value));
				}
			}

			// Token: 0x17003B7E RID: 15230
			// (get) Token: 0x0600BF4E RID: 48974 RVA: 0x002EE578 File Offset: 0x002EC778
			// (set) Token: 0x0600BF4F RID: 48975 RVA: 0x0005D802 File Offset: 0x0005BA02
			public unsafe static int CameraParams
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_CameraParams, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_CameraParams, (void*)(&value));
				}
			}

			// Token: 0x17003B7F RID: 15231
			// (get) Token: 0x0600BF50 RID: 48976 RVA: 0x002EE594 File Offset: 0x002EC794
			// (set) Token: 0x0600BF51 RID: 48977 RVA: 0x0005D810 File Offset: 0x0005BA10
			public unsafe static int DynamicOcclusionClippingPlaneWS
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneWS, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneWS, (void*)(&value));
				}
			}

			// Token: 0x17003B80 RID: 15232
			// (get) Token: 0x0600BF52 RID: 48978 RVA: 0x002EE5B0 File Offset: 0x002EC7B0
			// (set) Token: 0x0600BF53 RID: 48979 RVA: 0x0005D81E File Offset: 0x0005BA1E
			public unsafe static int DynamicOcclusionClippingPlaneProps
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneProps, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionClippingPlaneProps, (void*)(&value));
				}
			}

			// Token: 0x17003B81 RID: 15233
			// (get) Token: 0x0600BF54 RID: 48980 RVA: 0x002EE5CC File Offset: 0x002EC7CC
			// (set) Token: 0x0600BF55 RID: 48981 RVA: 0x0005D82C File Offset: 0x0005BA2C
			public unsafe static int DynamicOcclusionDepthTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthTexture, (void*)(&value));
				}
			}

			// Token: 0x17003B82 RID: 15234
			// (get) Token: 0x0600BF56 RID: 48982 RVA: 0x002EE5E8 File Offset: 0x002EC7E8
			// (set) Token: 0x0600BF57 RID: 48983 RVA: 0x0005D83A File Offset: 0x0005BA3A
			public unsafe static int DynamicOcclusionDepthProps
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthProps, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_DynamicOcclusionDepthProps, (void*)(&value));
				}
			}

			// Token: 0x17003B83 RID: 15235
			// (get) Token: 0x0600BF58 RID: 48984 RVA: 0x002EE604 File Offset: 0x002EC804
			// (set) Token: 0x0600BF59 RID: 48985 RVA: 0x0005D848 File Offset: 0x0005BA48
			public unsafe static int LocalForwardDirection
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_LocalForwardDirection, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_LocalForwardDirection, (void*)(&value));
				}
			}

			// Token: 0x17003B84 RID: 15236
			// (get) Token: 0x0600BF5A RID: 48986 RVA: 0x002EE620 File Offset: 0x002EC820
			// (set) Token: 0x0600BF5B RID: 48987 RVA: 0x0005D856 File Offset: 0x0005BA56
			public unsafe static int TiltVector
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_TiltVector, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_TiltVector, (void*)(&value));
				}
			}

			// Token: 0x17003B85 RID: 15237
			// (get) Token: 0x0600BF5C RID: 48988 RVA: 0x002EE63C File Offset: 0x002EC83C
			// (set) Token: 0x0600BF5D RID: 48989 RVA: 0x0005D864 File Offset: 0x0005BA64
			public unsafe static int AdditionalClippingPlaneWS
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.SD.NativeFieldInfoPtr_AdditionalClippingPlaneWS, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.SD.NativeFieldInfoPtr_AdditionalClippingPlaneWS, (void*)(&value));
				}
			}

			// Token: 0x04008191 RID: 33169
			private static readonly IntPtr NativeFieldInfoPtr_FadeOutFactor;

			// Token: 0x04008192 RID: 33170
			private static readonly IntPtr NativeFieldInfoPtr_ConeSlopeCosSin;

			// Token: 0x04008193 RID: 33171
			private static readonly IntPtr NativeFieldInfoPtr_AlphaInside;

			// Token: 0x04008194 RID: 33172
			private static readonly IntPtr NativeFieldInfoPtr_AlphaOutside;

			// Token: 0x04008195 RID: 33173
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationLerpLinearQuad;

			// Token: 0x04008196 RID: 33174
			private static readonly IntPtr NativeFieldInfoPtr_DistanceCamClipping;

			// Token: 0x04008197 RID: 33175
			private static readonly IntPtr NativeFieldInfoPtr_FresnelPow;

			// Token: 0x04008198 RID: 33176
			private static readonly IntPtr NativeFieldInfoPtr_GlareBehind;

			// Token: 0x04008199 RID: 33177
			private static readonly IntPtr NativeFieldInfoPtr_GlareFrontal;

			// Token: 0x0400819A RID: 33178
			private static readonly IntPtr NativeFieldInfoPtr_DrawCap;

			// Token: 0x0400819B RID: 33179
			private static readonly IntPtr NativeFieldInfoPtr_DepthBlendDistance;

			// Token: 0x0400819C RID: 33180
			private static readonly IntPtr NativeFieldInfoPtr_CameraParams;

			// Token: 0x0400819D RID: 33181
			private static readonly IntPtr NativeFieldInfoPtr_DynamicOcclusionClippingPlaneWS;

			// Token: 0x0400819E RID: 33182
			private static readonly IntPtr NativeFieldInfoPtr_DynamicOcclusionClippingPlaneProps;

			// Token: 0x0400819F RID: 33183
			private static readonly IntPtr NativeFieldInfoPtr_DynamicOcclusionDepthTexture;

			// Token: 0x040081A0 RID: 33184
			private static readonly IntPtr NativeFieldInfoPtr_DynamicOcclusionDepthProps;

			// Token: 0x040081A1 RID: 33185
			private static readonly IntPtr NativeFieldInfoPtr_LocalForwardDirection;

			// Token: 0x040081A2 RID: 33186
			private static readonly IntPtr NativeFieldInfoPtr_TiltVector;

			// Token: 0x040081A3 RID: 33187
			private static readonly IntPtr NativeFieldInfoPtr_AdditionalClippingPlaneWS;
		}

		// Token: 0x0200083A RID: 2106
		public static class HD : Object
		{
			// Token: 0x0600BF5E RID: 48990 RVA: 0x002EE658 File Offset: 0x002EC858
			// Note: this type is marked as 'beforefieldinit'.
			static HD()
			{
				Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderProperties>.NativeClassPtr, "HD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr);
				ShaderProperties.HD.NativeFieldInfoPtr_Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "Intensity");
				ShaderProperties.HD.NativeFieldInfoPtr_SideSoftness = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "SideSoftness");
				ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardOS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "CameraForwardOS");
				ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardWS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "CameraForwardWS");
				ShaderProperties.HD.NativeFieldInfoPtr_TransformScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "TransformScale");
				ShaderProperties.HD.NativeFieldInfoPtr_ShadowDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "ShadowDepthTexture");
				ShaderProperties.HD.NativeFieldInfoPtr_ShadowProps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "ShadowProps");
				ShaderProperties.HD.NativeFieldInfoPtr_Jittering = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "Jittering");
				ShaderProperties.HD.NativeFieldInfoPtr_CookieTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "CookieTexture");
				ShaderProperties.HD.NativeFieldInfoPtr_CookieProperties = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "CookieProperties");
				ShaderProperties.HD.NativeFieldInfoPtr_CookiePosAndScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "CookiePosAndScale");
				ShaderProperties.HD.NativeFieldInfoPtr_GlobalCameraBlendingDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "GlobalCameraBlendingDistance");
				ShaderProperties.HD.NativeFieldInfoPtr_GlobalJitteringNoiseTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperties.HD>.NativeClassPtr, "GlobalJitteringNoiseTex");
			}

			// Token: 0x0600BF5F RID: 48991 RVA: 0x0005D872 File Offset: 0x0005BA72
			public HD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B86 RID: 15238
			// (get) Token: 0x0600BF60 RID: 48992 RVA: 0x002EE788 File Offset: 0x002EC988
			// (set) Token: 0x0600BF61 RID: 48993 RVA: 0x0005D87B File Offset: 0x0005BA7B
			public unsafe static int Intensity
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_Intensity, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_Intensity, (void*)(&value));
				}
			}

			// Token: 0x17003B87 RID: 15239
			// (get) Token: 0x0600BF62 RID: 48994 RVA: 0x002EE7A4 File Offset: 0x002EC9A4
			// (set) Token: 0x0600BF63 RID: 48995 RVA: 0x0005D889 File Offset: 0x0005BA89
			public unsafe static int SideSoftness
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_SideSoftness, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_SideSoftness, (void*)(&value));
				}
			}

			// Token: 0x17003B88 RID: 15240
			// (get) Token: 0x0600BF64 RID: 48996 RVA: 0x002EE7C0 File Offset: 0x002EC9C0
			// (set) Token: 0x0600BF65 RID: 48997 RVA: 0x0005D897 File Offset: 0x0005BA97
			public unsafe static int CameraForwardOS
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardOS, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardOS, (void*)(&value));
				}
			}

			// Token: 0x17003B89 RID: 15241
			// (get) Token: 0x0600BF66 RID: 48998 RVA: 0x002EE7DC File Offset: 0x002EC9DC
			// (set) Token: 0x0600BF67 RID: 48999 RVA: 0x0005D8A5 File Offset: 0x0005BAA5
			public unsafe static int CameraForwardWS
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardWS, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_CameraForwardWS, (void*)(&value));
				}
			}

			// Token: 0x17003B8A RID: 15242
			// (get) Token: 0x0600BF68 RID: 49000 RVA: 0x002EE7F8 File Offset: 0x002EC9F8
			// (set) Token: 0x0600BF69 RID: 49001 RVA: 0x0005D8B3 File Offset: 0x0005BAB3
			public unsafe static int TransformScale
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_TransformScale, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_TransformScale, (void*)(&value));
				}
			}

			// Token: 0x17003B8B RID: 15243
			// (get) Token: 0x0600BF6A RID: 49002 RVA: 0x002EE814 File Offset: 0x002ECA14
			// (set) Token: 0x0600BF6B RID: 49003 RVA: 0x0005D8C1 File Offset: 0x0005BAC1
			public unsafe static int ShadowDepthTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_ShadowDepthTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_ShadowDepthTexture, (void*)(&value));
				}
			}

			// Token: 0x17003B8C RID: 15244
			// (get) Token: 0x0600BF6C RID: 49004 RVA: 0x002EE830 File Offset: 0x002ECA30
			// (set) Token: 0x0600BF6D RID: 49005 RVA: 0x0005D8CF File Offset: 0x0005BACF
			public unsafe static int ShadowProps
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_ShadowProps, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_ShadowProps, (void*)(&value));
				}
			}

			// Token: 0x17003B8D RID: 15245
			// (get) Token: 0x0600BF6E RID: 49006 RVA: 0x002EE84C File Offset: 0x002ECA4C
			// (set) Token: 0x0600BF6F RID: 49007 RVA: 0x0005D8DD File Offset: 0x0005BADD
			public unsafe static int Jittering
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_Jittering, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_Jittering, (void*)(&value));
				}
			}

			// Token: 0x17003B8E RID: 15246
			// (get) Token: 0x0600BF70 RID: 49008 RVA: 0x002EE868 File Offset: 0x002ECA68
			// (set) Token: 0x0600BF71 RID: 49009 RVA: 0x0005D8EB File Offset: 0x0005BAEB
			public unsafe static int CookieTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_CookieTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_CookieTexture, (void*)(&value));
				}
			}

			// Token: 0x17003B8F RID: 15247
			// (get) Token: 0x0600BF72 RID: 49010 RVA: 0x002EE884 File Offset: 0x002ECA84
			// (set) Token: 0x0600BF73 RID: 49011 RVA: 0x0005D8F9 File Offset: 0x0005BAF9
			public unsafe static int CookieProperties
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_CookieProperties, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_CookieProperties, (void*)(&value));
				}
			}

			// Token: 0x17003B90 RID: 15248
			// (get) Token: 0x0600BF74 RID: 49012 RVA: 0x002EE8A0 File Offset: 0x002ECAA0
			// (set) Token: 0x0600BF75 RID: 49013 RVA: 0x0005D907 File Offset: 0x0005BB07
			public unsafe static int CookiePosAndScale
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_CookiePosAndScale, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_CookiePosAndScale, (void*)(&value));
				}
			}

			// Token: 0x17003B91 RID: 15249
			// (get) Token: 0x0600BF76 RID: 49014 RVA: 0x002EE8BC File Offset: 0x002ECABC
			// (set) Token: 0x0600BF77 RID: 49015 RVA: 0x0005D915 File Offset: 0x0005BB15
			public unsafe static int GlobalCameraBlendingDistance
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_GlobalCameraBlendingDistance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_GlobalCameraBlendingDistance, (void*)(&value));
				}
			}

			// Token: 0x17003B92 RID: 15250
			// (get) Token: 0x0600BF78 RID: 49016 RVA: 0x002EE8D8 File Offset: 0x002ECAD8
			// (set) Token: 0x0600BF79 RID: 49017 RVA: 0x0005D923 File Offset: 0x0005BB23
			public unsafe static int GlobalJitteringNoiseTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ShaderProperties.HD.NativeFieldInfoPtr_GlobalJitteringNoiseTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderProperties.HD.NativeFieldInfoPtr_GlobalJitteringNoiseTex, (void*)(&value));
				}
			}

			// Token: 0x040081A4 RID: 33188
			private static readonly IntPtr NativeFieldInfoPtr_Intensity;

			// Token: 0x040081A5 RID: 33189
			private static readonly IntPtr NativeFieldInfoPtr_SideSoftness;

			// Token: 0x040081A6 RID: 33190
			private static readonly IntPtr NativeFieldInfoPtr_CameraForwardOS;

			// Token: 0x040081A7 RID: 33191
			private static readonly IntPtr NativeFieldInfoPtr_CameraForwardWS;

			// Token: 0x040081A8 RID: 33192
			private static readonly IntPtr NativeFieldInfoPtr_TransformScale;

			// Token: 0x040081A9 RID: 33193
			private static readonly IntPtr NativeFieldInfoPtr_ShadowDepthTexture;

			// Token: 0x040081AA RID: 33194
			private static readonly IntPtr NativeFieldInfoPtr_ShadowProps;

			// Token: 0x040081AB RID: 33195
			private static readonly IntPtr NativeFieldInfoPtr_Jittering;

			// Token: 0x040081AC RID: 33196
			private static readonly IntPtr NativeFieldInfoPtr_CookieTexture;

			// Token: 0x040081AD RID: 33197
			private static readonly IntPtr NativeFieldInfoPtr_CookieProperties;

			// Token: 0x040081AE RID: 33198
			private static readonly IntPtr NativeFieldInfoPtr_CookiePosAndScale;

			// Token: 0x040081AF RID: 33199
			private static readonly IntPtr NativeFieldInfoPtr_GlobalCameraBlendingDistance;

			// Token: 0x040081B0 RID: 33200
			private static readonly IntPtr NativeFieldInfoPtr_GlobalJitteringNoiseTex;
		}
	}
}
