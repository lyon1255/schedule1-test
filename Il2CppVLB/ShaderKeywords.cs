using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Il2CppVLB
{
	// Token: 0x020000AF RID: 175
	public static class ShaderKeywords : Object
	{
		// Token: 0x06000CF8 RID: 3320 RVA: 0x0009A400 File Offset: 0x00098600
		// Note: this type is marked as 'beforefieldinit'.
		static ShaderKeywords()
		{
			Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "VLB", "ShaderKeywords");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr);
			ShaderKeywords.NativeFieldInfoPtr_AlphaAsBlack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "AlphaAsBlack");
			ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixLow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "ColorGradientMatrixLow");
			ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "ColorGradientMatrixHigh");
			ShaderKeywords.NativeFieldInfoPtr_Noise3D = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "Noise3D");
		}

		// Token: 0x06000CF9 RID: 3321 RVA: 0x00008618 File Offset: 0x00006818
		public ShaderKeywords(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700044E RID: 1102
		// (get) Token: 0x06000CFA RID: 3322 RVA: 0x0009A480 File Offset: 0x00098680
		// (set) Token: 0x06000CFB RID: 3323 RVA: 0x00008621 File Offset: 0x00006821
		public unsafe static string AlphaAsBlack
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.NativeFieldInfoPtr_AlphaAsBlack, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.NativeFieldInfoPtr_AlphaAsBlack, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x1700044F RID: 1103
		// (get) Token: 0x06000CFC RID: 3324 RVA: 0x0009A4A0 File Offset: 0x000986A0
		// (set) Token: 0x06000CFD RID: 3325 RVA: 0x00008633 File Offset: 0x00006833
		public unsafe static string ColorGradientMatrixLow
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixLow, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixLow, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06000CFE RID: 3326 RVA: 0x0009A4C0 File Offset: 0x000986C0
		// (set) Token: 0x06000CFF RID: 3327 RVA: 0x00008645 File Offset: 0x00006845
		public unsafe static string ColorGradientMatrixHigh
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixHigh, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.NativeFieldInfoPtr_ColorGradientMatrixHigh, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06000D00 RID: 3328 RVA: 0x0009A4E0 File Offset: 0x000986E0
		// (set) Token: 0x06000D01 RID: 3329 RVA: 0x00008657 File Offset: 0x00006857
		public unsafe static string Noise3D
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.NativeFieldInfoPtr_Noise3D, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.NativeFieldInfoPtr_Noise3D, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040008C3 RID: 2243
		private static readonly IntPtr NativeFieldInfoPtr_AlphaAsBlack;

		// Token: 0x040008C4 RID: 2244
		private static readonly IntPtr NativeFieldInfoPtr_ColorGradientMatrixLow;

		// Token: 0x040008C5 RID: 2245
		private static readonly IntPtr NativeFieldInfoPtr_ColorGradientMatrixHigh;

		// Token: 0x040008C6 RID: 2246
		private static readonly IntPtr NativeFieldInfoPtr_Noise3D;

		// Token: 0x02000837 RID: 2103
		public static class SD : Object
		{
			// Token: 0x0600BF1B RID: 48923 RVA: 0x002EDFBC File Offset: 0x002EC1BC
			// Note: this type is marked as 'beforefieldinit'.
			static SD()
			{
				Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "SD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr);
				ShaderKeywords.SD.NativeFieldInfoPtr_DepthBlend = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr, "DepthBlend");
				ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionClippingPlane = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr, "OcclusionClippingPlane");
				ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionDepthTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr, "OcclusionDepthTexture");
				ShaderKeywords.SD.NativeFieldInfoPtr_MeshSkewing = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr, "MeshSkewing");
				ShaderKeywords.SD.NativeFieldInfoPtr_ShaderAccuracyHigh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.SD>.NativeClassPtr, "ShaderAccuracyHigh");
			}

			// Token: 0x0600BF1C RID: 48924 RVA: 0x0005D687 File Offset: 0x0005B887
			public SD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B68 RID: 15208
			// (get) Token: 0x0600BF1D RID: 48925 RVA: 0x002EE04C File Offset: 0x002EC24C
			// (set) Token: 0x0600BF1E RID: 48926 RVA: 0x0005D690 File Offset: 0x0005B890
			public unsafe static string DepthBlend
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.SD.NativeFieldInfoPtr_DepthBlend, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.SD.NativeFieldInfoPtr_DepthBlend, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B69 RID: 15209
			// (get) Token: 0x0600BF1F RID: 48927 RVA: 0x002EE06C File Offset: 0x002EC26C
			// (set) Token: 0x0600BF20 RID: 48928 RVA: 0x0005D6A2 File Offset: 0x0005B8A2
			public unsafe static string OcclusionClippingPlane
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionClippingPlane, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionClippingPlane, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B6A RID: 15210
			// (get) Token: 0x0600BF21 RID: 48929 RVA: 0x002EE08C File Offset: 0x002EC28C
			// (set) Token: 0x0600BF22 RID: 48930 RVA: 0x0005D6B4 File Offset: 0x0005B8B4
			public unsafe static string OcclusionDepthTexture
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionDepthTexture, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.SD.NativeFieldInfoPtr_OcclusionDepthTexture, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B6B RID: 15211
			// (get) Token: 0x0600BF23 RID: 48931 RVA: 0x002EE0AC File Offset: 0x002EC2AC
			// (set) Token: 0x0600BF24 RID: 48932 RVA: 0x0005D6C6 File Offset: 0x0005B8C6
			public unsafe static string MeshSkewing
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.SD.NativeFieldInfoPtr_MeshSkewing, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.SD.NativeFieldInfoPtr_MeshSkewing, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B6C RID: 15212
			// (get) Token: 0x0600BF25 RID: 48933 RVA: 0x002EE0CC File Offset: 0x002EC2CC
			// (set) Token: 0x0600BF26 RID: 48934 RVA: 0x0005D6D8 File Offset: 0x0005B8D8
			public unsafe static string ShaderAccuracyHigh
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.SD.NativeFieldInfoPtr_ShaderAccuracyHigh, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.SD.NativeFieldInfoPtr_ShaderAccuracyHigh, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x04008185 RID: 33157
			private static readonly IntPtr NativeFieldInfoPtr_DepthBlend;

			// Token: 0x04008186 RID: 33158
			private static readonly IntPtr NativeFieldInfoPtr_OcclusionClippingPlane;

			// Token: 0x04008187 RID: 33159
			private static readonly IntPtr NativeFieldInfoPtr_OcclusionDepthTexture;

			// Token: 0x04008188 RID: 33160
			private static readonly IntPtr NativeFieldInfoPtr_MeshSkewing;

			// Token: 0x04008189 RID: 33161
			private static readonly IntPtr NativeFieldInfoPtr_ShaderAccuracyHigh;
		}

		// Token: 0x02000838 RID: 2104
		public static class HD : Object
		{
			// Token: 0x0600BF27 RID: 48935 RVA: 0x002EE0EC File Offset: 0x002EC2EC
			// Note: this type is marked as 'beforefieldinit'.
			static HD()
			{
				Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderKeywords>.NativeClassPtr, "HD");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr);
				ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationLinear = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "AttenuationLinear");
				ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationQuad = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "AttenuationQuad");
				ShaderKeywords.HD.NativeFieldInfoPtr_Shadow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "Shadow");
				ShaderKeywords.HD.NativeFieldInfoPtr_CookieSingleChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "CookieSingleChannel");
				ShaderKeywords.HD.NativeFieldInfoPtr_CookieRGBA = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "CookieRGBA");
				ShaderKeywords.HD.NativeFieldInfoPtr_RaymarchingStepCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, "RaymarchingStepCount");
				ShaderKeywords.HD.NativeMethodInfoPtr_GetRaymarchingQuality_Public_Static_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderKeywords.HD>.NativeClassPtr, 100664901);
			}

			// Token: 0x0600BF28 RID: 48936 RVA: 0x002EE1A4 File Offset: 0x002EC3A4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 84376, XrefRangeEnd = 84380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static string GetRaymarchingQuality(int id)
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ShaderKeywords.HD.NativeMethodInfoPtr_GetRaymarchingQuality_Public_Static_String_Int32_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}

			// Token: 0x0600BF29 RID: 48937 RVA: 0x0005D6EA File Offset: 0x0005B8EA
			public HD(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003B6D RID: 15213
			// (get) Token: 0x0600BF2A RID: 48938 RVA: 0x002EE1DC File Offset: 0x002EC3DC
			// (set) Token: 0x0600BF2B RID: 48939 RVA: 0x0005D6F3 File Offset: 0x0005B8F3
			public unsafe static string AttenuationLinear
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationLinear, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationLinear, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B6E RID: 15214
			// (get) Token: 0x0600BF2C RID: 48940 RVA: 0x002EE1FC File Offset: 0x002EC3FC
			// (set) Token: 0x0600BF2D RID: 48941 RVA: 0x0005D705 File Offset: 0x0005B905
			public unsafe static string AttenuationQuad
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationQuad, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_AttenuationQuad, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B6F RID: 15215
			// (get) Token: 0x0600BF2E RID: 48942 RVA: 0x002EE21C File Offset: 0x002EC41C
			// (set) Token: 0x0600BF2F RID: 48943 RVA: 0x0005D717 File Offset: 0x0005B917
			public unsafe static string Shadow
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_Shadow, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_Shadow, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B70 RID: 15216
			// (get) Token: 0x0600BF30 RID: 48944 RVA: 0x002EE23C File Offset: 0x002EC43C
			// (set) Token: 0x0600BF31 RID: 48945 RVA: 0x0005D729 File Offset: 0x0005B929
			public unsafe static string CookieSingleChannel
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_CookieSingleChannel, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_CookieSingleChannel, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B71 RID: 15217
			// (get) Token: 0x0600BF32 RID: 48946 RVA: 0x002EE25C File Offset: 0x002EC45C
			// (set) Token: 0x0600BF33 RID: 48947 RVA: 0x0005D73B File Offset: 0x0005B93B
			public unsafe static string CookieRGBA
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_CookieRGBA, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_CookieRGBA, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17003B72 RID: 15218
			// (get) Token: 0x0600BF34 RID: 48948 RVA: 0x002EE27C File Offset: 0x002EC47C
			// (set) Token: 0x0600BF35 RID: 48949 RVA: 0x0005D74D File Offset: 0x0005B94D
			public unsafe static string RaymarchingStepCount
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(ShaderKeywords.HD.NativeFieldInfoPtr_RaymarchingStepCount, (void*)(&intPtr));
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ShaderKeywords.HD.NativeFieldInfoPtr_RaymarchingStepCount, IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400818A RID: 33162
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationLinear;

			// Token: 0x0400818B RID: 33163
			private static readonly IntPtr NativeFieldInfoPtr_AttenuationQuad;

			// Token: 0x0400818C RID: 33164
			private static readonly IntPtr NativeFieldInfoPtr_Shadow;

			// Token: 0x0400818D RID: 33165
			private static readonly IntPtr NativeFieldInfoPtr_CookieSingleChannel;

			// Token: 0x0400818E RID: 33166
			private static readonly IntPtr NativeFieldInfoPtr_CookieRGBA;

			// Token: 0x0400818F RID: 33167
			private static readonly IntPtr NativeFieldInfoPtr_RaymarchingStepCount;

			// Token: 0x04008190 RID: 33168
			private static readonly IntPtr NativeMethodInfoPtr_GetRaymarchingQuality_Public_Static_String_Int32_0;
		}
	}
}
