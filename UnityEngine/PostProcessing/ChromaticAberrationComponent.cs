using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000052 RID: 82
	public sealed class ChromaticAberrationComponent : PostProcessingComponentRenderTexture<ChromaticAberrationModel>
	{
		// Token: 0x06000664 RID: 1636 RVA: 0x000835FC File Offset: 0x000817FC
		// Note: this type is marked as 'beforefieldinit'.
		static ChromaticAberrationComponent()
		{
			Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "ChromaticAberrationComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr);
			ChromaticAberrationComponent.NativeFieldInfoPtr_m_SpectrumLut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr, "m_SpectrumLut");
			ChromaticAberrationComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr, 100663909);
			ChromaticAberrationComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr, 100663910);
			ChromaticAberrationComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr, 100663911);
			ChromaticAberrationComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr, 100663912);
		}

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00083690 File Offset: 0x00081890
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76215, XrefRangeEnd = 76216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x000836CC File Offset: 0x000818CC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76216, XrefRangeEnd = 76218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x00083700 File Offset: 0x00081900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76218, XrefRangeEnd = 76255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Prepare(Material uberMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00083744 File Offset: 0x00081944
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 76258, RefRangeEnd = 76259, XrefRangeStart = 76255, XrefRangeEnd = 76258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ChromaticAberrationComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ChromaticAberrationComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00005B6D File Offset: 0x00003D6D
		public ChromaticAberrationComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00083780 File Offset: 0x00081980
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00005B76 File Offset: 0x00003D76
		public unsafe Texture2D m_SpectrumLut
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationComponent.NativeFieldInfoPtr_m_SpectrumLut);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Texture2D>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ChromaticAberrationComponent.NativeFieldInfoPtr_m_SpectrumLut), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040003CF RID: 975
		private static readonly IntPtr NativeFieldInfoPtr_m_SpectrumLut;

		// Token: 0x040003D0 RID: 976
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x040003D1 RID: 977
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x040003D2 RID: 978
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0;

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007C9 RID: 1993
		public static class Uniforms : Object
		{
			// Token: 0x0600BB10 RID: 47888 RVA: 0x002E4E30 File Offset: 0x002E3030
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<ChromaticAberrationComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ChromaticAberrationComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChromaticAberrationComponent.Uniforms>.NativeClassPtr);
				ChromaticAberrationComponent.Uniforms.NativeFieldInfoPtr__ChromaticAberration_Amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChromaticAberrationComponent.Uniforms>.NativeClassPtr, "_ChromaticAberration_Amount");
				ChromaticAberrationComponent.Uniforms.NativeFieldInfoPtr__ChromaticAberration_Spectrum = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChromaticAberrationComponent.Uniforms>.NativeClassPtr, "_ChromaticAberration_Spectrum");
			}

			// Token: 0x0600BB11 RID: 47889 RVA: 0x0005B8B4 File Offset: 0x00059AB4
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x170039D0 RID: 14800
			// (get) Token: 0x0600BB12 RID: 47890 RVA: 0x002E4E84 File Offset: 0x002E3084
			// (set) Token: 0x0600BB13 RID: 47891 RVA: 0x0005B8BD File Offset: 0x00059ABD
			public unsafe static int _ChromaticAberration_Amount
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ChromaticAberrationComponent.Uniforms.NativeFieldInfoPtr__ChromaticAberration_Amount, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChromaticAberrationComponent.Uniforms.NativeFieldInfoPtr__ChromaticAberration_Amount, (void*)(&value));
				}
			}

			// Token: 0x170039D1 RID: 14801
			// (get) Token: 0x0600BB14 RID: 47892 RVA: 0x002E4EA0 File Offset: 0x002E30A0
			// (set) Token: 0x0600BB15 RID: 47893 RVA: 0x0005B8CB File Offset: 0x00059ACB
			public unsafe static int _ChromaticAberration_Spectrum
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(ChromaticAberrationComponent.Uniforms.NativeFieldInfoPtr__ChromaticAberration_Spectrum, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(ChromaticAberrationComponent.Uniforms.NativeFieldInfoPtr__ChromaticAberration_Spectrum, (void*)(&value));
				}
			}

			// Token: 0x04007E24 RID: 32292
			private static readonly IntPtr NativeFieldInfoPtr__ChromaticAberration_Amount;

			// Token: 0x04007E25 RID: 32293
			private static readonly IntPtr NativeFieldInfoPtr__ChromaticAberration_Spectrum;
		}
	}
}
