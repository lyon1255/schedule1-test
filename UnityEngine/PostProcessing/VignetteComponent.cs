using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.PostProcessing
{
	// Token: 0x0200005E RID: 94
	public sealed class VignetteComponent : PostProcessingComponentRenderTexture<VignetteModel>
	{
		// Token: 0x0600072D RID: 1837 RVA: 0x000861D4 File Offset: 0x000843D4
		// Note: this type is marked as 'beforefieldinit'.
		static VignetteComponent()
		{
			Il2CppClassPointerStore<VignetteComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "UnityEngine.PostProcessing", "VignetteComponent");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VignetteComponent>.NativeClassPtr);
			VignetteComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteComponent>.NativeClassPtr, 100664033);
			VignetteComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteComponent>.NativeClassPtr, 100664034);
			VignetteComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VignetteComponent>.NativeClassPtr, 100664035);
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00086240 File Offset: 0x00084440
		public unsafe override bool active
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77711, XrefRangeEnd = 77712, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VignetteComponent.NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x0008627C File Offset: 0x0008447C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77712, XrefRangeEnd = 77732, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Prepare(Material uberMaterial)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(uberMaterial);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VignetteComponent.NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x000862C0 File Offset: 0x000844C0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 77732, XrefRangeEnd = 77735, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe VignetteComponent() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VignetteComponent>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(VignetteComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x00005FB8 File Offset: 0x000041B8
		public VignetteComponent(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x04000458 RID: 1112
		private static readonly IntPtr NativeMethodInfoPtr_get_active_Public_Virtual_get_Boolean_0;

		// Token: 0x04000459 RID: 1113
		private static readonly IntPtr NativeMethodInfoPtr_Prepare_Public_Virtual_Void_Material_0;

		// Token: 0x0400045A RID: 1114
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020007D9 RID: 2009
		public static class Uniforms : Object
		{
			// Token: 0x0600BC33 RID: 48179 RVA: 0x002E6CB8 File Offset: 0x002E4EB8
			// Note: this type is marked as 'beforefieldinit'.
			static Uniforms()
			{
				Il2CppClassPointerStore<VignetteComponent.Uniforms>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VignetteComponent>.NativeClassPtr, "Uniforms");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VignetteComponent.Uniforms>.NativeClassPtr);
				VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteComponent.Uniforms>.NativeClassPtr, "_Vignette_Color");
				VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Center = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteComponent.Uniforms>.NativeClassPtr, "_Vignette_Center");
				VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Settings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteComponent.Uniforms>.NativeClassPtr, "_Vignette_Settings");
				VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Mask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteComponent.Uniforms>.NativeClassPtr, "_Vignette_Mask");
				VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Opacity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VignetteComponent.Uniforms>.NativeClassPtr, "_Vignette_Opacity");
			}

			// Token: 0x0600BC34 RID: 48180 RVA: 0x0005C068 File Offset: 0x0005A268
			public Uniforms(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x17003A4E RID: 14926
			// (get) Token: 0x0600BC35 RID: 48181 RVA: 0x002E6D48 File Offset: 0x002E4F48
			// (set) Token: 0x0600BC36 RID: 48182 RVA: 0x0005C071 File Offset: 0x0005A271
			public unsafe static int _Vignette_Color
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Color, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Color, (void*)(&value));
				}
			}

			// Token: 0x17003A4F RID: 14927
			// (get) Token: 0x0600BC37 RID: 48183 RVA: 0x002E6D64 File Offset: 0x002E4F64
			// (set) Token: 0x0600BC38 RID: 48184 RVA: 0x0005C07F File Offset: 0x0005A27F
			public unsafe static int _Vignette_Center
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Center, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Center, (void*)(&value));
				}
			}

			// Token: 0x17003A50 RID: 14928
			// (get) Token: 0x0600BC39 RID: 48185 RVA: 0x002E6D80 File Offset: 0x002E4F80
			// (set) Token: 0x0600BC3A RID: 48186 RVA: 0x0005C08D File Offset: 0x0005A28D
			public unsafe static int _Vignette_Settings
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Settings, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Settings, (void*)(&value));
				}
			}

			// Token: 0x17003A51 RID: 14929
			// (get) Token: 0x0600BC3B RID: 48187 RVA: 0x002E6D9C File Offset: 0x002E4F9C
			// (set) Token: 0x0600BC3C RID: 48188 RVA: 0x0005C09B File Offset: 0x0005A29B
			public unsafe static int _Vignette_Mask
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Mask, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Mask, (void*)(&value));
				}
			}

			// Token: 0x17003A52 RID: 14930
			// (get) Token: 0x0600BC3D RID: 48189 RVA: 0x002E6DB8 File Offset: 0x002E4FB8
			// (set) Token: 0x0600BC3E RID: 48190 RVA: 0x0005C0A9 File Offset: 0x0005A2A9
			public unsafe static int _Vignette_Opacity
			{
				get
				{
					int result;
					IL2CPP.il2cpp_field_static_get_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Opacity, (void*)(&result));
					return result;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(VignetteComponent.Uniforms.NativeFieldInfoPtr__Vignette_Opacity, (void*)(&value));
				}
			}

			// Token: 0x04007EC1 RID: 32449
			private static readonly IntPtr NativeFieldInfoPtr__Vignette_Color;

			// Token: 0x04007EC2 RID: 32450
			private static readonly IntPtr NativeFieldInfoPtr__Vignette_Center;

			// Token: 0x04007EC3 RID: 32451
			private static readonly IntPtr NativeFieldInfoPtr__Vignette_Settings;

			// Token: 0x04007EC4 RID: 32452
			private static readonly IntPtr NativeFieldInfoPtr__Vignette_Mask;

			// Token: 0x04007EC5 RID: 32453
			private static readonly IntPtr NativeFieldInfoPtr__Vignette_Opacity;
		}
	}
}
