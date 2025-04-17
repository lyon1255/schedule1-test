using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000050 RID: 80
	public sealed class BloomComponent : PostProcessingComponentRenderTexture<BloomModel>
	{
		// Token: 0x06000648 RID: 1608 RVA: 0x00082FD4 File Offset: 0x000811D4
		// Note: this type is marked as 'beforefieldinit'.
		static BloomComponent()
		{
			Il2CppClassPointerStore<BloomComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "BloomComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr);
			BloomComponent.NativeFieldInfoPtr_k_MaxPyramidBlurLevel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr, "k_MaxPyramidBlurLevel");
			BloomComponent.NativeFieldInfoPtr_m_BlurBuffer1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr, "m_BlurBuffer1");
			BloomComponent.NativeFieldInfoPtr_m_BlurBuffer2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr, "m_BlurBuffer2");
			BloomComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr, 100663884);
			BloomComponent.NativeMethodInfoPtr_Prepare_Public_Void_RenderTexture_Material_Texture_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr, 100663885);
			BloomComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr, 100663886);
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x06000649 RID: 1609 RVA: 0x0008307C File Offset: 0x0008127C
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75925, XrefRangeEnd = 75926, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600064A RID: 1610 RVA: 0x000830B8 File Offset: 0x000812B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76023, RefRangeEnd = 76024, XrefRangeStart = 75926, XrefRangeEnd = 76023, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Prepare(RenderTexture source, Material uberMaterial, Texture autoExposure)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(autoExposure);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomComponent.NativeMethodInfoPtr_Prepare_Public_Void_RenderTexture_Material_Texture_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064B RID: 1611 RVA: 0x00083120 File Offset: 0x00081320
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76034, RefRangeEnd = 76035, XrefRangeStart = 76024, XrefRangeEnd = 76034, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BloomComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BloomComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600064C RID: 1612 RVA: 0x00005ADE File Offset: 0x00003CDE
		public BloomComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x0600064D RID: 1613 RVA: 0x0008315C File Offset: 0x0008135C
		// (set) Token: 0x0600064E RID: 1614 RVA: 0x00005AE7 File Offset: 0x00003CE7
		public unsafe static int k_MaxPyramidBlurLevel
		{
			get
			{
				int result;
				IL2CPP.il2cpp_field_static_get_value(BloomComponent.NativeFieldInfoPtr_k_MaxPyramidBlurLevel, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(BloomComponent.NativeFieldInfoPtr_k_MaxPyramidBlurLevel, (void*)(&value));
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00083178 File Offset: 0x00081378
		// (set) Token: 0x06000650 RID: 1616 RVA: 0x00005AF5 File Offset: 0x00003CF5
		public unsafe Il2CppReferenceArray<RenderTexture> m_BlurBuffer1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomComponent.NativeFieldInfoPtr_m_BlurBuffer1);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RenderTexture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomComponent.NativeFieldInfoPtr_m_BlurBuffer1), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06000651 RID: 1617 RVA: 0x000831A8 File Offset: 0x000813A8
		// (set) Token: 0x06000652 RID: 1618 RVA: 0x00005B14 File Offset: 0x00003D14
		public unsafe Il2CppReferenceArray<RenderTexture> m_BlurBuffer2
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomComponent.NativeFieldInfoPtr_m_BlurBuffer2);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RenderTexture>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BloomComponent.NativeFieldInfoPtr_m_BlurBuffer2), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003BC RID: 956
		private static readonly IntPtr NativeFieldInfoPtr_k_MaxPyramidBlurLevel;

		// Token: 0x040003BD RID: 957
		private static readonly IntPtr NativeFieldInfoPtr_m_BlurBuffer1;

		// Token: 0x040003BE RID: 958
		private static readonly IntPtr NativeFieldInfoPtr_m_BlurBuffer2;

		// Token: 0x040003BF RID: 959
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x040003C0 RID: 960
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Void_RenderTexture_Material_Texture_0;

		// Token: 0x040003C1 RID: 961
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007C5 RID: 1989
		public static class Uniforms : Object
		{
			// Token: 0x0600BAD9 RID: 47833 RVA: 0x002E46D4 File Offset: 0x002E28D4
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<BloomComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr);
				BloomComponent.Uniforms.NativeFieldInfoPtr__AutoExposure = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_AutoExposure");
				BloomComponent.Uniforms.NativeFieldInfoPtr__Threshold = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_Threshold");
				BloomComponent.Uniforms.NativeFieldInfoPtr__Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_Curve");
				BloomComponent.Uniforms.NativeFieldInfoPtr__PrefilterOffs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_PrefilterOffs");
				BloomComponent.Uniforms.NativeFieldInfoPtr__SampleScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_SampleScale");
				BloomComponent.Uniforms.NativeFieldInfoPtr__BaseTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_BaseTex");
				BloomComponent.Uniforms.NativeFieldInfoPtr__BloomTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_BloomTex");
				BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_Bloom_Settings");
				BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_DirtTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_Bloom_DirtTex");
				BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_DirtIntensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BloomComponent.Uniforms>.NativeClassPtr, "_Bloom_DirtIntensity");
			}

			// Token: 0x0600BADA RID: 47834 RVA: 0x0005B756 File Offset: 0x00059956
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039B9 RID: 14777
			// (get) Token: 0x0600BADB RID: 47835 RVA: 0x002E47C8 File Offset: 0x002E29C8
			// (set) Token: 0x0600BADC RID: 47836 RVA: 0x0005B75F File Offset: 0x0005995F
			public unsafe static int _AutoExposure
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__AutoExposure, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__AutoExposure, (void*)(&value));
				}
			}

			// Token: 0x170039BA RID: 14778
			// (get) Token: 0x0600BADD RID: 47837 RVA: 0x002E47E4 File Offset: 0x002E29E4
			// (set) Token: 0x0600BADE RID: 47838 RVA: 0x0005B76D File Offset: 0x0005996D
			public unsafe static int _Threshold
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Threshold, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Threshold, (void*)(&value));
				}
			}

			// Token: 0x170039BB RID: 14779
			// (get) Token: 0x0600BADF RID: 47839 RVA: 0x002E4800 File Offset: 0x002E2A00
			// (set) Token: 0x0600BAE0 RID: 47840 RVA: 0x0005B77B File Offset: 0x0005997B
			public unsafe static int _Curve
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Curve, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Curve, (void*)(&value));
				}
			}

			// Token: 0x170039BC RID: 14780
			// (get) Token: 0x0600BAE1 RID: 47841 RVA: 0x002E481C File Offset: 0x002E2A1C
			// (set) Token: 0x0600BAE2 RID: 47842 RVA: 0x0005B789 File Offset: 0x00059989
			public unsafe static int _PrefilterOffs
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__PrefilterOffs, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__PrefilterOffs, (void*)(&value));
				}
			}

			// Token: 0x170039BD RID: 14781
			// (get) Token: 0x0600BAE3 RID: 47843 RVA: 0x002E4838 File Offset: 0x002E2A38
			// (set) Token: 0x0600BAE4 RID: 47844 RVA: 0x0005B797 File Offset: 0x00059997
			public unsafe static int _SampleScale
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__SampleScale, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__SampleScale, (void*)(&value));
				}
			}

			// Token: 0x170039BE RID: 14782
			// (get) Token: 0x0600BAE5 RID: 47845 RVA: 0x002E4854 File Offset: 0x002E2A54
			// (set) Token: 0x0600BAE6 RID: 47846 RVA: 0x0005B7A5 File Offset: 0x000599A5
			public unsafe static int _BaseTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__BaseTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__BaseTex, (void*)(&value));
				}
			}

			// Token: 0x170039BF RID: 14783
			// (get) Token: 0x0600BAE7 RID: 47847 RVA: 0x002E4870 File Offset: 0x002E2A70
			// (set) Token: 0x0600BAE8 RID: 47848 RVA: 0x0005B7B3 File Offset: 0x000599B3
			public unsafe static int _BloomTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__BloomTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__BloomTex, (void*)(&value));
				}
			}

			// Token: 0x170039C0 RID: 14784
			// (get) Token: 0x0600BAE9 RID: 47849 RVA: 0x002E488C File Offset: 0x002E2A8C
			// (set) Token: 0x0600BAEA RID: 47850 RVA: 0x0005B7C1 File Offset: 0x000599C1
			public unsafe static int _Bloom_Settings
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_Settings, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_Settings, (void*)(&value));
				}
			}

			// Token: 0x170039C1 RID: 14785
			// (get) Token: 0x0600BAEB RID: 47851 RVA: 0x002E48A8 File Offset: 0x002E2AA8
			// (set) Token: 0x0600BAEC RID: 47852 RVA: 0x0005B7CF File Offset: 0x000599CF
			public unsafe static int _Bloom_DirtTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_DirtTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_DirtTex, (void*)(&value));
				}
			}

			// Token: 0x170039C2 RID: 14786
			// (get) Token: 0x0600BAED RID: 47853 RVA: 0x002E48C4 File Offset: 0x002E2AC4
			// (set) Token: 0x0600BAEE RID: 47854 RVA: 0x0005B7DD File Offset: 0x000599DD
			public unsafe static int _Bloom_DirtIntensity
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_DirtIntensity, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(BloomComponent.Uniforms.NativeFieldInfoPtr__Bloom_DirtIntensity, (void*)(&value));
				}
			}

			// Token: 0x04007E01 RID: 32257
			private static readonly IntPtr NativeFieldInfoPtr__AutoExposure;

			// Token: 0x04007E02 RID: 32258
			private static readonly IntPtr NativeFieldInfoPtr__Threshold;

			// Token: 0x04007E03 RID: 32259
			private static readonly IntPtr NativeFieldInfoPtr__Curve;

			// Token: 0x04007E04 RID: 32260
			private static readonly IntPtr NativeFieldInfoPtr__PrefilterOffs;

			// Token: 0x04007E05 RID: 32261
			private static readonly IntPtr NativeFieldInfoPtr__SampleScale;

			// Token: 0x04007E06 RID: 32262
			private static readonly IntPtr NativeFieldInfoPtr__BaseTex;

			// Token: 0x04007E07 RID: 32263
			private static readonly IntPtr NativeFieldInfoPtr__BloomTex;

			// Token: 0x04007E08 RID: 32264
			private static readonly IntPtr NativeFieldInfoPtr__Bloom_Settings;

			// Token: 0x04007E09 RID: 32265
			private static readonly IntPtr NativeFieldInfoPtr__Bloom_DirtTex;

			// Token: 0x04007E0A RID: 32266
			private static readonly IntPtr NativeFieldInfoPtr__Bloom_DirtIntensity;
		}
	}
}
