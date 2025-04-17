using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x02000059 RID: 89
	public sealed class GrainComponent : PostProcessingComponentRenderTexture<GrainModel>
	{
		// Token: 0x060006DC RID: 1756 RVA: 0x00085098 File Offset: 0x00083298
		// Note: this type is marked as 'beforefieldinit'.
		static GrainComponent()
		{
			Il2CppClassPointerStore<GrainComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "GrainComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrainComponent>.NativeClassPtr);
			GrainComponent.NativeFieldInfoPtr_m_GrainLookupRT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainComponent>.NativeClassPtr, "m_GrainLookupRT");
			GrainComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainComponent>.NativeClassPtr, 100663974);
			GrainComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainComponent>.NativeClassPtr, 100663975);
			GrainComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainComponent>.NativeClassPtr, 100663976);
			GrainComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<GrainComponent>.NativeClassPtr, 100663977);
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x0008512C File Offset: 0x0008332C
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76935, XrefRangeEnd = 76937, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00085168 File Offset: 0x00083368
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void OnDisable()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainComponent.NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0008519C File Offset: 0x0008339C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76937, XrefRangeEnd = 76984, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Prepare(Material uberMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x000851E0 File Offset: 0x000833E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 76984, XrefRangeEnd = 76987, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe GrainComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<GrainComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(GrainComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00005DD9 File Offset: 0x00003FD9
		public GrainComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0008521C File Offset: 0x0008341C
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x00005DE2 File Offset: 0x00003FE2
		public unsafe RenderTexture m_GrainLookupRT
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrainComponent.NativeFieldInfoPtr_m_GrainLookupRT);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RenderTexture>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(GrainComponent.NativeFieldInfoPtr_m_GrainLookupRT), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000421 RID: 1057
		private static readonly IntPtr NativeFieldInfoPtr_m_GrainLookupRT;

		// Token: 0x04000422 RID: 1058
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x04000423 RID: 1059
		private static readonly IntPtr NativeMethodInfoPtr_OnDisable_Public_Virtual_Void_0;

		// Token: 0x04000424 RID: 1060
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0;

		// Token: 0x04000425 RID: 1061
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007D0 RID: 2000
		public static class Uniforms : Object
		{
			// Token: 0x0600BB7E RID: 47998 RVA: 0x002E5864 File Offset: 0x002E3A64
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<GrainComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<GrainComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<GrainComponent.Uniforms>.NativeClassPtr);
				GrainComponent.Uniforms.NativeFieldInfoPtr__Grain_Params1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainComponent.Uniforms>.NativeClassPtr, "_Grain_Params1");
				GrainComponent.Uniforms.NativeFieldInfoPtr__Grain_Params2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainComponent.Uniforms>.NativeClassPtr, "_Grain_Params2");
				GrainComponent.Uniforms.NativeFieldInfoPtr__GrainTex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainComponent.Uniforms>.NativeClassPtr, "_GrainTex");
				GrainComponent.Uniforms.NativeFieldInfoPtr__Phase = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<GrainComponent.Uniforms>.NativeClassPtr, "_Phase");
			}

			// Token: 0x0600BB7F RID: 47999 RVA: 0x0005BB93 File Offset: 0x00059D93
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A00 RID: 14848
			// (get) Token: 0x0600BB80 RID: 48000 RVA: 0x002E58E0 File Offset: 0x002E3AE0
			// (set) Token: 0x0600BB81 RID: 48001 RVA: 0x0005BB9C File Offset: 0x00059D9C
			public unsafe static int _Grain_Params1
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(GrainComponent.Uniforms.NativeFieldInfoPtr__Grain_Params1, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GrainComponent.Uniforms.NativeFieldInfoPtr__Grain_Params1, (void*)(&value));
				}
			}

			// Token: 0x17003A01 RID: 14849
			// (get) Token: 0x0600BB82 RID: 48002 RVA: 0x002E58FC File Offset: 0x002E3AFC
			// (set) Token: 0x0600BB83 RID: 48003 RVA: 0x0005BBAA File Offset: 0x00059DAA
			public unsafe static int _Grain_Params2
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(GrainComponent.Uniforms.NativeFieldInfoPtr__Grain_Params2, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GrainComponent.Uniforms.NativeFieldInfoPtr__Grain_Params2, (void*)(&value));
				}
			}

			// Token: 0x17003A02 RID: 14850
			// (get) Token: 0x0600BB84 RID: 48004 RVA: 0x002E5918 File Offset: 0x002E3B18
			// (set) Token: 0x0600BB85 RID: 48005 RVA: 0x0005BBB8 File Offset: 0x00059DB8
			public unsafe static int _GrainTex
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(GrainComponent.Uniforms.NativeFieldInfoPtr__GrainTex, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GrainComponent.Uniforms.NativeFieldInfoPtr__GrainTex, (void*)(&value));
				}
			}

			// Token: 0x17003A03 RID: 14851
			// (get) Token: 0x0600BB86 RID: 48006 RVA: 0x002E5934 File Offset: 0x002E3B34
			// (set) Token: 0x0600BB87 RID: 48007 RVA: 0x0005BBC6 File Offset: 0x00059DC6
			public unsafe static int _Phase
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(GrainComponent.Uniforms.NativeFieldInfoPtr__Phase, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(GrainComponent.Uniforms.NativeFieldInfoPtr__Phase, (void*)(&value));
				}
			}

			// Token: 0x04007E54 RID: 32340
			private static readonly IntPtr NativeFieldInfoPtr__Grain_Params1;

			// Token: 0x04007E55 RID: 32341
			private static readonly IntPtr NativeFieldInfoPtr__Grain_Params2;

			// Token: 0x04007E56 RID: 32342
			private static readonly IntPtr NativeFieldInfoPtr__GrainTex;

			// Token: 0x04007E57 RID: 32343
			private static readonly IntPtr NativeFieldInfoPtr__Phase;
		}
	}
}
