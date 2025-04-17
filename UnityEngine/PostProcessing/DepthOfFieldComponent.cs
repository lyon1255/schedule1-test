using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000054 RID: 84
	public sealed class DepthOfFieldComponent : PostProcessingComponentRenderTexture<DepthOfFieldModel>
	{
		// Token: 0x0600068F RID: 1679 RVA: 0x00084134 File Offset: 0x00082334
		// Note: this type is marked as 'beforefieldinit'.
		static DepthOfFieldComponent()
		{
			Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "DepthOfFieldComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr);
			DepthOfFieldComponent.NativeFieldInfoPtr_k_ShaderString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, "k_ShaderString");
			DepthOfFieldComponent.NativeFieldInfoPtr_m_CoCHistory = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, "m_CoCHistory");
			DepthOfFieldComponent.NativeFieldInfoPtr_k_FilmHeight = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, "k_FilmHeight");
			DepthOfFieldComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663938);
			DepthOfFieldComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663939);
			DepthOfFieldComponent.NativeMethodInfoPtr_CalculateFocalLength_Private_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663940);
			DepthOfFieldComponent.NativeMethodInfoPtr_CalculateMaxCoCRadius_Private_Single_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663941);
			DepthOfFieldComponent.NativeMethodInfoPtr_CheckHistory_Private_Boolean_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663942);
			DepthOfFieldComponent.NativeMethodInfoPtr_SelectFormat_Private_RenderTextureFormat_RenderTextureFormat_RenderTextureFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663943);
			DepthOfFieldComponent.NativeMethodInfoPtr_Prepare_Public_Void_RenderTexture_Material_Boolean_Vector2_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663944);
			DepthOfFieldComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663945);
			DepthOfFieldComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, 100663946);
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000690 RID: 1680 RVA: 0x00084254 File Offset: 0x00082454
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76498, XrefRangeEnd = 76499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x00084290 File Offset: 0x00082490
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 76499, RefRangeEnd = 76503, XrefRangeStart = 76499, XrefRangeEnd = 76499, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override DepthTextureMode GetCameraFlags()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x000842CC File Offset: 0x000824CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76503, XrefRangeEnd = 76506, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateFocalLength()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr_CalculateFocalLength_Private_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x00084308 File Offset: 0x00082508
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76506, XrefRangeEnd = 76507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe float CalculateMaxCoCRadius(int screenHeight)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref screenHeight;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr_CalculateMaxCoCRadius_Private_Single_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x00084354 File Offset: 0x00082554
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76507, XrefRangeEnd = 76513, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckHistory(int width, int height)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref width;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref height;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr_CheckHistory_Private_Boolean_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x000843AC File Offset: 0x000825AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76513, XrefRangeEnd = 76515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RenderTextureFormat SelectFormat(RenderTextureFormat primary, RenderTextureFormat secondary)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref primary;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref secondary;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr_SelectFormat_Private_RenderTextureFormat_RenderTextureFormat_RenderTextureFormat_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x00084404 File Offset: 0x00082604
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76613, RefRangeEnd = 76614, XrefRangeStart = 76515, XrefRangeEnd = 76613, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Prepare(RenderTexture source, Material uberMaterial, bool antialiasCoC, Vector2 taaJitter, float taaBlending)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(source);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref antialiasCoC;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taaJitter;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref taaBlending;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr_Prepare_Public_Void_RenderTexture_Material_Boolean_Vector2_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x00084484 File Offset: 0x00082684
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76614, XrefRangeEnd = 76620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x000844B8 File Offset: 0x000826B8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76623, RefRangeEnd = 76624, XrefRangeStart = 76620, XrefRangeEnd = 76623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DepthOfFieldComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DepthOfFieldComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x00005C06 File Offset: 0x00003E06
		public DepthOfFieldComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x000844F4 File Offset: 0x000826F4
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x00005C0F File Offset: 0x00003E0F
		public unsafe static string k_ShaderString
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.NativeFieldInfoPtr_k_ShaderString, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.NativeFieldInfoPtr_k_ShaderString, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x00084514 File Offset: 0x00082714
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x00005C21 File Offset: 0x00003E21
		public unsafe RenderTexture m_CoCHistory
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfFieldComponent.NativeFieldInfoPtr_m_CoCHistory);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DepthOfFieldComponent.NativeFieldInfoPtr_m_CoCHistory), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x00084544 File Offset: 0x00082744
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x00005C40 File Offset: 0x00003E40
		public unsafe static float k_FilmHeight
		{
			get
			{
				float result;
				IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.NativeFieldInfoPtr_k_FilmHeight, (void*)(&result));
				return result;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.NativeFieldInfoPtr_k_FilmHeight, (void*)(&value));
			}
		}

		// Token: 0x040003F0 RID: 1008
		private static readonly IntPtr NativeFieldInfoPtr_k_ShaderString;

		// Token: 0x040003F1 RID: 1009
		private static readonly IntPtr NativeFieldInfoPtr_m_CoCHistory;

		// Token: 0x040003F2 RID: 1010
		private static readonly IntPtr NativeFieldInfoPtr_k_FilmHeight;

		// Token: 0x040003F3 RID: 1011
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x040003F4 RID: 1012
		private static readonly IntPtr NativeMethodInfoPtr_GetCameraFlags_Public_Virtual_DepthTextureMode_0;

		// Token: 0x040003F5 RID: 1013
		private static readonly IntPtr NativeMethodInfoPtr_CalculateFocalLength_Private_Single_0;

		// Token: 0x040003F6 RID: 1014
		private static readonly IntPtr NativeMethodInfoPtr_CalculateMaxCoCRadius_Private_Single_Int32_0;

		// Token: 0x040003F7 RID: 1015
		private static readonly IntPtr NativeMethodInfoPtr_CheckHistory_Private_Boolean_Int32_Int32_0;

		// Token: 0x040003F8 RID: 1016
		private static readonly IntPtr NativeMethodInfoPtr_SelectFormat_Private_RenderTextureFormat_RenderTextureFormat_RenderTextureFormat_0;

		// Token: 0x040003F9 RID: 1017
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Void_RenderTexture_Material_Boolean_Vector2_Single_0;

		// Token: 0x040003FA RID: 1018
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x040003FB RID: 1019
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007CB RID: 1995
		public static class Uniforms : Object
		{
			// Token: 0x0600BB40 RID: 47936 RVA: 0x002E52A8 File Offset: 0x002E34A8
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DepthOfFieldComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr);
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_DepthOfFieldTex");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldCoCTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_DepthOfFieldCoCTex");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__Distance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_Distance");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__LensCoeff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_LensCoeff");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__MaxCoC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_MaxCoC");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__RcpMaxCoC = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_RcpMaxCoC");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__RcpAspect = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_RcpAspect");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__MainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_MainTex");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__CoCTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_CoCTex");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__TaaParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_TaaParams");
				DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldParams = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DepthOfFieldComponent.Uniforms>.NativeClassPtr, "_DepthOfFieldParams");
			}

			// Token: 0x0600BB41 RID: 47937 RVA: 0x0005B9FA File Offset: 0x00059BFA
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039E6 RID: 14822
			// (get) Token: 0x0600BB42 RID: 47938 RVA: 0x002E53B0 File Offset: 0x002E35B0
			// (set) Token: 0x0600BB43 RID: 47939 RVA: 0x0005BA03 File Offset: 0x00059C03
			public unsafe static int _DepthOfFieldTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldTex, (void*)(&value));
				}
			}

			// Token: 0x170039E7 RID: 14823
			// (get) Token: 0x0600BB44 RID: 47940 RVA: 0x002E53CC File Offset: 0x002E35CC
			// (set) Token: 0x0600BB45 RID: 47941 RVA: 0x0005BA11 File Offset: 0x00059C11
			public unsafe static int _DepthOfFieldCoCTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldCoCTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldCoCTex, (void*)(&value));
				}
			}

			// Token: 0x170039E8 RID: 14824
			// (get) Token: 0x0600BB46 RID: 47942 RVA: 0x002E53E8 File Offset: 0x002E35E8
			// (set) Token: 0x0600BB47 RID: 47943 RVA: 0x0005BA1F File Offset: 0x00059C1F
			public unsafe static int _Distance
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__Distance, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__Distance, (void*)(&value));
				}
			}

			// Token: 0x170039E9 RID: 14825
			// (get) Token: 0x0600BB48 RID: 47944 RVA: 0x002E5404 File Offset: 0x002E3604
			// (set) Token: 0x0600BB49 RID: 47945 RVA: 0x0005BA2D File Offset: 0x00059C2D
			public unsafe static int _LensCoeff
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__LensCoeff, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__LensCoeff, (void*)(&value));
				}
			}

			// Token: 0x170039EA RID: 14826
			// (get) Token: 0x0600BB4A RID: 47946 RVA: 0x002E5420 File Offset: 0x002E3620
			// (set) Token: 0x0600BB4B RID: 47947 RVA: 0x0005BA3B File Offset: 0x00059C3B
			public unsafe static int _MaxCoC
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__MaxCoC, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__MaxCoC, (void*)(&value));
				}
			}

			// Token: 0x170039EB RID: 14827
			// (get) Token: 0x0600BB4C RID: 47948 RVA: 0x002E543C File Offset: 0x002E363C
			// (set) Token: 0x0600BB4D RID: 47949 RVA: 0x0005BA49 File Offset: 0x00059C49
			public unsafe static int _RcpMaxCoC
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__RcpMaxCoC, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__RcpMaxCoC, (void*)(&value));
				}
			}

			// Token: 0x170039EC RID: 14828
			// (get) Token: 0x0600BB4E RID: 47950 RVA: 0x002E5458 File Offset: 0x002E3658
			// (set) Token: 0x0600BB4F RID: 47951 RVA: 0x0005BA57 File Offset: 0x00059C57
			public unsafe static int _RcpAspect
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__RcpAspect, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__RcpAspect, (void*)(&value));
				}
			}

			// Token: 0x170039ED RID: 14829
			// (get) Token: 0x0600BB50 RID: 47952 RVA: 0x002E5474 File Offset: 0x002E3674
			// (set) Token: 0x0600BB51 RID: 47953 RVA: 0x0005BA65 File Offset: 0x00059C65
			public unsafe static int _MainTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__MainTex, (void*)(&value));
				}
			}

			// Token: 0x170039EE RID: 14830
			// (get) Token: 0x0600BB52 RID: 47954 RVA: 0x002E5490 File Offset: 0x002E3690
			// (set) Token: 0x0600BB53 RID: 47955 RVA: 0x0005BA73 File Offset: 0x00059C73
			public unsafe static int _CoCTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__CoCTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__CoCTex, (void*)(&value));
				}
			}

			// Token: 0x170039EF RID: 14831
			// (get) Token: 0x0600BB54 RID: 47956 RVA: 0x002E54AC File Offset: 0x002E36AC
			// (set) Token: 0x0600BB55 RID: 47957 RVA: 0x0005BA81 File Offset: 0x00059C81
			public unsafe static int _TaaParams
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__TaaParams, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__TaaParams, (void*)(&value));
				}
			}

			// Token: 0x170039F0 RID: 14832
			// (get) Token: 0x0600BB56 RID: 47958 RVA: 0x002E54C8 File Offset: 0x002E36C8
			// (set) Token: 0x0600BB57 RID: 47959 RVA: 0x0005BA8F File Offset: 0x00059C8F
			public unsafe static int _DepthOfFieldParams
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldParams, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(DepthOfFieldComponent.Uniforms.NativeFieldInfoPtr__DepthOfFieldParams, (void*)(&value));
				}
			}

			// Token: 0x04007E3A RID: 32314
			private static readonly IntPtr NativeFieldInfoPtr__DepthOfFieldTex;

			// Token: 0x04007E3B RID: 32315
			private static readonly IntPtr NativeFieldInfoPtr__DepthOfFieldCoCTex;

			// Token: 0x04007E3C RID: 32316
			private static readonly IntPtr NativeFieldInfoPtr__Distance;

			// Token: 0x04007E3D RID: 32317
			private static readonly IntPtr NativeFieldInfoPtr__LensCoeff;

			// Token: 0x04007E3E RID: 32318
			private static readonly IntPtr NativeFieldInfoPtr__MaxCoC;

			// Token: 0x04007E3F RID: 32319
			private static readonly IntPtr NativeFieldInfoPtr__RcpMaxCoC;

			// Token: 0x04007E40 RID: 32320
			private static readonly IntPtr NativeFieldInfoPtr__RcpAspect;

			// Token: 0x04007E41 RID: 32321
			private static readonly IntPtr NativeFieldInfoPtr__MainTex;

			// Token: 0x04007E42 RID: 32322
			private static readonly IntPtr NativeFieldInfoPtr__CoCTex;

			// Token: 0x04007E43 RID: 32323
			private static readonly IntPtr NativeFieldInfoPtr__TaaParams;

			// Token: 0x04007E44 RID: 32324
			private static readonly IntPtr NativeFieldInfoPtr__DepthOfFieldParams;
		}
	}
}
