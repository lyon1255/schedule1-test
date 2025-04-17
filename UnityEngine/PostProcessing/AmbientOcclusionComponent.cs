using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200004F RID: 79
	public sealed class AmbientOcclusionComponent : PostProcessingComponentCommandBuffer<AmbientOcclusionModel>
	{
		// Token: 0x06000638 RID: 1592 RVA: 0x00082C74 File Offset: 0x00080E74
		// Note: this type is marked as 'beforefieldinit'.
		static AmbientOcclusionComponent()
		{
			Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "AmbientOcclusionComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr);
			AmbientOcclusionComponent.NativeFieldInfoPtr_k_BlitShaderString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, "k_BlitShaderString");
			AmbientOcclusionComponent.NativeFieldInfoPtr_k_ShaderString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, "k_ShaderString");
			AmbientOcclusionComponent.NativeFieldInfoPtr_m_MRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, "m_MRT");
			AmbientOcclusionComponent.NativeMethodInfoPtr_get_occlusionSource_Private_get_OcclusionSource_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, 100663875);
			AmbientOcclusionComponent.NativeMethodInfoPtr_get_ambientOnlySupported_Private_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, 100663876);
			AmbientOcclusionComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, 100663877);
			AmbientOcclusionComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, 100663878);
			AmbientOcclusionComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, 100663879);
			AmbientOcclusionComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, 100663880);
			AmbientOcclusionComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, 100663881);
			AmbientOcclusionComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, 100663882);
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000639 RID: 1593 RVA: 0x00082D80 File Offset: 0x00080F80
		public unsafe AmbientOcclusionComponent.OcclusionSource occlusionSource
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 75785, RefRangeEnd = 75789, XrefRangeStart = 75783, XrefRangeEnd = 75785, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionComponent.NativeMethodInfoPtr_get_occlusionSource_Private_get_OcclusionSource_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x0600063A RID: 1594 RVA: 0x00082DBC File Offset: 0x00080FBC
		public unsafe bool ambientOnlySupported
		{
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 75792, RefRangeEnd = 75794, XrefRangeStart = 75789, XrefRangeEnd = 75792, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionComponent.NativeMethodInfoPtr_get_ambientOnlySupported_Private_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x0600063B RID: 1595 RVA: 0x00082DF8 File Offset: 0x00080FF8
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75794, XrefRangeEnd = 75795, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00082E34 File Offset: 0x00081034
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75795, XrefRangeEnd = 75797, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00082E70 File Offset: 0x00081070
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75797, XrefRangeEnd = 75799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string GetName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionComponent.NativeMethodInfoPtr_GetName_Public_Virtual_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00082EA8 File Offset: 0x000810A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75799, XrefRangeEnd = 75801, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override CameraEvent GetCameraEvent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionComponent.NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00082EE4 File Offset: 0x000810E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 75801, XrefRangeEnd = 75913, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void PopulateCommandBuffer(CommandBuffer cb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionComponent.NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00082F28 File Offset: 0x00081128
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 75924, RefRangeEnd = 75925, XrefRangeStart = 75913, XrefRangeEnd = 75924, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AmbientOcclusionComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AmbientOcclusionComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000641 RID: 1601 RVA: 0x00005A92 File Offset: 0x00003C92
		public AmbientOcclusionComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x00082F64 File Offset: 0x00081164
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00005A9B File Offset: 0x00003C9B
		public unsafe static string k_BlitShaderString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.NativeFieldInfoPtr_k_BlitShaderString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.NativeFieldInfoPtr_k_BlitShaderString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00082F84 File Offset: 0x00081184
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x00005AAD File Offset: 0x00003CAD
		public unsafe static string k_ShaderString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.NativeFieldInfoPtr_k_ShaderString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.NativeFieldInfoPtr_k_ShaderString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x00082FA4 File Offset: 0x000811A4
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x00005ABF File Offset: 0x00003CBF
		public unsafe Il2CppStructArray<RenderTargetIdentifier> m_MRT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusionComponent.NativeFieldInfoPtr_m_MRT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RenderTargetIdentifier>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AmbientOcclusionComponent.NativeFieldInfoPtr_m_MRT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003B1 RID: 945
		private static readonly IntPtr NativeFieldInfoPtr_k_BlitShaderString;

		// Token: 0x040003B2 RID: 946
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderString;

		// Token: 0x040003B3 RID: 947
		private static readonly IntPtr NativeFieldInfoPtr_m_MRT;

		// Token: 0x040003B4 RID: 948
		private static readonly IntPtr NativeMethodInfoPtr_get_occlusionSource_Private_get_OcclusionSource_0;

		// Token: 0x040003B5 RID: 949
		private static readonly IntPtr NativeMethodInfoPtr_get_ambientOnlySupported_Private_get_Boolean_0;

		// Token: 0x040003B6 RID: 950
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x040003B7 RID: 951
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0;

		// Token: 0x040003B8 RID: 952
		private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_String_0;

		// Token: 0x040003B9 RID: 953
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraEvent_Public_Virtual_CameraEvent_0;

		// Token: 0x040003BA RID: 954
		private static readonly IntPtr NativeMethodInfoPtr_PopulateCommandBuffer_Public_Virtual_Void_CommandBuffer_0;

		// Token: 0x040003BB RID: 955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007C3 RID: 1987
		public static class Uniforms : Object
		{
			// Token: 0x0600BAC3 RID: 47811 RVA: 0x002E44C8 File Offset: 0x002E26C8
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AmbientOcclusionComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr);
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Intensity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_Intensity");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_Radius");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__FogParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_FogParams");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Downsample = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_Downsample");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__SampleCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_SampleCount");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_OcclusionTexture1");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_OcclusionTexture2");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_OcclusionTexture");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_MainTex");
				AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__TempRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AmbientOcclusionComponent.Uniforms>.NativeClassPtr, "_TempRT");
			}

			// Token: 0x0600BAC4 RID: 47812 RVA: 0x0005B6C1 File Offset: 0x000598C1
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039AF RID: 14767
			// (get) Token: 0x0600BAC5 RID: 47813 RVA: 0x002E45BC File Offset: 0x002E27BC
			// (set) Token: 0x0600BAC6 RID: 47814 RVA: 0x0005B6CA File Offset: 0x000598CA
			public unsafe static int _Intensity
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Intensity, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Intensity, (void*)(&value));
				}
			}

			// Token: 0x170039B0 RID: 14768
			// (get) Token: 0x0600BAC7 RID: 47815 RVA: 0x002E45D8 File Offset: 0x002E27D8
			// (set) Token: 0x0600BAC8 RID: 47816 RVA: 0x0005B6D8 File Offset: 0x000598D8
			public unsafe static int _Radius
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Radius, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Radius, (void*)(&value));
				}
			}

			// Token: 0x170039B1 RID: 14769
			// (get) Token: 0x0600BAC9 RID: 47817 RVA: 0x002E45F4 File Offset: 0x002E27F4
			// (set) Token: 0x0600BACA RID: 47818 RVA: 0x0005B6E6 File Offset: 0x000598E6
			public unsafe static int _FogParams
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__FogParams, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__FogParams, (void*)(&value));
				}
			}

			// Token: 0x170039B2 RID: 14770
			// (get) Token: 0x0600BACB RID: 47819 RVA: 0x002E4610 File Offset: 0x002E2810
			// (set) Token: 0x0600BACC RID: 47820 RVA: 0x0005B6F4 File Offset: 0x000598F4
			public unsafe static int _Downsample
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Downsample, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__Downsample, (void*)(&value));
				}
			}

			// Token: 0x170039B3 RID: 14771
			// (get) Token: 0x0600BACD RID: 47821 RVA: 0x002E462C File Offset: 0x002E282C
			// (set) Token: 0x0600BACE RID: 47822 RVA: 0x0005B702 File Offset: 0x00059902
			public unsafe static int _SampleCount
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__SampleCount, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__SampleCount, (void*)(&value));
				}
			}

			// Token: 0x170039B4 RID: 14772
			// (get) Token: 0x0600BACF RID: 47823 RVA: 0x002E4648 File Offset: 0x002E2848
			// (set) Token: 0x0600BAD0 RID: 47824 RVA: 0x0005B710 File Offset: 0x00059910
			public unsafe static int _OcclusionTexture1
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture1, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture1, (void*)(&value));
				}
			}

			// Token: 0x170039B5 RID: 14773
			// (get) Token: 0x0600BAD1 RID: 47825 RVA: 0x002E4664 File Offset: 0x002E2864
			// (set) Token: 0x0600BAD2 RID: 47826 RVA: 0x0005B71E File Offset: 0x0005991E
			public unsafe static int _OcclusionTexture2
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture2, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture2, (void*)(&value));
				}
			}

			// Token: 0x170039B6 RID: 14774
			// (get) Token: 0x0600BAD3 RID: 47827 RVA: 0x002E4680 File Offset: 0x002E2880
			// (set) Token: 0x0600BAD4 RID: 47828 RVA: 0x0005B72C File Offset: 0x0005992C
			public unsafe static int _OcclusionTexture
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__OcclusionTexture, (void*)(&value));
				}
			}

			// Token: 0x170039B7 RID: 14775
			// (get) Token: 0x0600BAD5 RID: 47829 RVA: 0x002E469C File Offset: 0x002E289C
			// (set) Token: 0x0600BAD6 RID: 47830 RVA: 0x0005B73A File Offset: 0x0005993A
			public unsafe static int _MainTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&value));
				}
			}

			// Token: 0x170039B8 RID: 14776
			// (get) Token: 0x0600BAD7 RID: 47831 RVA: 0x002E46B8 File Offset: 0x002E28B8
			// (set) Token: 0x0600BAD8 RID: 47832 RVA: 0x0005B748 File Offset: 0x00059948
			public unsafe static int _TempRT
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__TempRT, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AmbientOcclusionComponent.Uniforms.NativeFieldInfoPtr__TempRT, (void*)(&value));
				}
			}

			// Token: 0x04007DF3 RID: 32243
			private static readonly IntPtr NativeFieldInfoPtr__Intensity;

			// Token: 0x04007DF4 RID: 32244
			private static readonly IntPtr NativeFieldInfoPtr__Radius;

			// Token: 0x04007DF5 RID: 32245
			private static readonly IntPtr NativeFieldInfoPtr__FogParams;

			// Token: 0x04007DF6 RID: 32246
			private static readonly IntPtr NativeFieldInfoPtr__Downsample;

			// Token: 0x04007DF7 RID: 32247
			private static readonly IntPtr NativeFieldInfoPtr__SampleCount;

			// Token: 0x04007DF8 RID: 32248
			private static readonly IntPtr NativeFieldInfoPtr__OcclusionTexture1;

			// Token: 0x04007DF9 RID: 32249
			private static readonly IntPtr NativeFieldInfoPtr__OcclusionTexture2;

			// Token: 0x04007DFA RID: 32250
			private static readonly IntPtr NativeFieldInfoPtr__OcclusionTexture;

			// Token: 0x04007DFB RID: 32251
			private static readonly IntPtr NativeFieldInfoPtr__MainTex;

			// Token: 0x04007DFC RID: 32252
			private static readonly IntPtr NativeFieldInfoPtr__TempRT;
		}

		// Token: 0x020007C4 RID: 1988
		[OriginalName("Assembly-CSharp.dll", "", "OcclusionSource")]
		public enum OcclusionSource
		{
			// Token: 0x04007DFE RID: 32254
			DepthTexture,
			// Token: 0x04007DFF RID: 32255
			DepthNormalsTexture,
			// Token: 0x04007E00 RID: 32256
			GBuffer
		}
	}
}
